﻿using DragDropViewer.ExtensionMethods;
using System;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace DragDropViewer {
  public partial class MainForm : Form {
    #region Fields
    private Control preview;
    #endregion

    #region Properties
    private bool DisplayHex {
      get {
        return butHex.Checked;
      }
      set {
        butHex.Checked = value;
      }
    }

    private Control PreviewControl {
      get {
        return preview;
      }
      set {
        var current = PreviewControl;
        if (current != null) {
          tableLayoutPanel1.Controls.Remove(current);
          current.Dispose();
          current = null;
        }

        preview = value;

        if (preview != null) {
          // Some special cases
          if (preview is TextBoxBase) {
            ((TextBoxBase)preview).Multiline = true;
          }

          value.Dock = DockStyle.Fill;

          tableLayoutPanel1.Controls.Add(value, 1, 0);
          tableLayoutPanel1.SetRowSpan(value, 2);
        }
      }
    }

    private DataFormat SelectedItem {
      get {
        return listFormats.SelectedIndex == -1 ? null : (DataFormat)listFormats.SelectedItem;
      }
    }
    #endregion

    #region Constructors
    public MainForm() {
      InitializeComponent();

      saveFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
    }
    #endregion

    #region Methods
    private void LoadData(IDataObject data) {
      listFormats.SelectedIndexChanged -= listFormats_SelectedIndexChanged;
      listFormats.BeginUpdate();

      listFormats.Items.Clear();
      if (data != null) {
        foreach (var fmt in data.GetFormats(true)) {
          var item = new DataFormat() {
            Data = data.GetData(fmt),
            Name = fmt
          };
          listFormats.Items.Add(item);
        }
      }

      var files = data.GetFileContentNames();
      if (files.Length != 0) {
        for (int i = 0; i < files.Length; i++) {
          object parsedData;
          using (var ms = data.GetFileContent(i)) {
            ms.Position = 0;
            using (var fs = new FileStream("y:\\DragDrop\\foo.jpeg", FileMode.Open, FileAccess.Write)) {
              ms.WriteTo(fs);
            }
            ms.Position = 0;

            try {
              using (var img = new Bitmap(ms)) {
                parsedData = new Bitmap(img);
              }
            } catch {
              parsedData = ms.ToArray();
            }
          }
          var item = new DataFormat() {
            Data = parsedData,
            Name = $"X-FileContent-{files[i]}"
          };
          listFormats.Items.Add(item);
        }
      }

      listFormats.EndUpdate();
      listFormats.SelectedIndex = -1;
      listFormats.SelectedIndexChanged += listFormats_SelectedIndexChanged;

    }

    private void OnSelectedItemChanged() {
      var selected = SelectedItem;

      propertyGrid.SelectedObject = selected?.Data;

      butSave.Enabled = butHex.Enabled = (selected != null) && (selected.Type == typeof(MemoryStream));

      if ((selected == null) || (selected.Data == null)) {
        PreviewControl = null;
        return;
      }

      if (selected.Name == "Rich Text Format") {
        PreviewControl = new RichTextBox() {
          Rtf = (string)selected.Data
        };

      } else if (selected.Name == "text/html") {
        var stream = selected.Data as Stream;
        stream.Position = 0;

        PreviewControl = new WebBrowser() {
          DocumentStream = stream
        };

      } else if (selected.Type == typeof(string)) {
        PreviewControl = new TextBox() {
          Text = (string)selected.Data
        };

      } else if (selected.Type == typeof(string[])) {
        PreviewControl = new TextBox() {
          Lines = (string[])selected.Data
        };

      } else if ((selected.Type == typeof(MemoryStream)) || (selected.Type == typeof(byte[]))) {
        byte[] bytes;

        if (selected.Type == typeof(MemoryStream)) {
          bytes = ((MemoryStream)selected.Data).ToArray();
        } else {
          bytes = (byte[])selected.Data;
        }

        string text;
        if (DisplayHex) {
          var sb = new StringBuilder();
          foreach (byte b in bytes) {
            if (sb.Length != 0) sb.Append(" ");
            sb.Append(b.ToString("x2"));
          }
          text = sb.ToString();

        } else {
          Encoding enc;
          if (
            selected.Name.EndsWith("W")
            || selected.Name.Contains("x-moz")
            ) {
            enc = Encoding.Unicode;
          } else {
            enc = Encoding.UTF8;
          }

          using (var ms = new MemoryStream(bytes)) {
            using (var reader = new StreamReader(ms, enc, true, 1024, true)) {
              text = reader.ReadToEnd();
            }
          }
        }

        PreviewControl = new TextBox() {
          Text = text
        };

      } else if (selected.Type == typeof(Bitmap)) {
        PreviewControl = new PictureBox() {
          Image = (Bitmap)selected.Data,
          SizeMode = PictureBoxSizeMode.Zoom
        };

      } else {
        PreviewControl = null;
      }
      
    }
    #endregion

    #region Event handlers
    private void butFromClipboard_Click(object sender, EventArgs e) {
      LoadData(Clipboard.GetDataObject());
    }

    private void butHex_CheckedChanged(object sender, EventArgs e) {
      OnSelectedItemChanged();
    }

    private void butSave_Click(object sender, EventArgs e) {
      saveFileDialog1.FileName = $"{SelectedItem.Name}.bin";
      if (saveFileDialog1.ShowDialog() != DialogResult.OK) return;

      using (var fs = new FileStream(saveFileDialog1.FileName, FileMode.Create, FileAccess.Write)) {
        var ms = SelectedItem.Data as MemoryStream;
        ms.WriteTo(fs);
      }
    }

    private void listFormats_SelectedIndexChanged(object sender, EventArgs e) {
      OnSelectedItemChanged();
    }

    private void MainForm_DragEnter(object sender, DragEventArgs e) {
      e.Effect = e.AllowedEffect;
    }

    private void MainForm_DragDrop(object sender, DragEventArgs e) {
      LoadData(e.Data);
    }
    #endregion

    #region Inner classes
    public class DataFormat {
      public object Data { get; set; }

      public string Name { get; set; }

      public Type Type => Data?.GetType();

      public string TypeName => Type == null ? "null" : Type.Name;

      public override string ToString() {
        return $"{TypeName} {Name}";
      }
    }
    #endregion
  }
}
