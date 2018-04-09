namespace DragDropViewer {
  partial class MainForm {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
      this.listFormats = new System.Windows.Forms.ListBox();
      this.propertyGrid = new System.Windows.Forms.PropertyGrid();
      this.toolStrip1 = new System.Windows.Forms.ToolStrip();
      this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
      this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
      this.butFromClipboard = new System.Windows.Forms.ToolStripButton();
      this.butSave = new System.Windows.Forms.ToolStripButton();
      this.butHex = new System.Windows.Forms.ToolStripButton();
      this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
      this.tableLayoutPanel1.SuspendLayout();
      this.toolStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // tableLayoutPanel1
      // 
      this.tableLayoutPanel1.ColumnCount = 2;
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel1.Controls.Add(this.listFormats, 0, 0);
      this.tableLayoutPanel1.Controls.Add(this.propertyGrid, 0, 1);
      this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 25);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      this.tableLayoutPanel1.RowCount = 2;
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tableLayoutPanel1.Size = new System.Drawing.Size(672, 495);
      this.tableLayoutPanel1.TabIndex = 0;
      this.tableLayoutPanel1.DragDrop += new System.Windows.Forms.DragEventHandler(this.MainForm_DragDrop);
      // 
      // listFormats
      // 
      this.listFormats.AllowDrop = true;
      this.listFormats.Dock = System.Windows.Forms.DockStyle.Fill;
      this.listFormats.FormattingEnabled = true;
      this.listFormats.Location = new System.Drawing.Point(3, 3);
      this.listFormats.Name = "listFormats";
      this.listFormats.Size = new System.Drawing.Size(330, 241);
      this.listFormats.TabIndex = 1;
      this.listFormats.SelectedIndexChanged += new System.EventHandler(this.listFormats_SelectedIndexChanged);
      this.listFormats.DragDrop += new System.Windows.Forms.DragEventHandler(this.MainForm_DragDrop);
      // 
      // propertyGrid
      // 
      this.propertyGrid.Dock = System.Windows.Forms.DockStyle.Fill;
      this.propertyGrid.LineColor = System.Drawing.SystemColors.ControlDark;
      this.propertyGrid.Location = new System.Drawing.Point(3, 250);
      this.propertyGrid.Name = "propertyGrid";
      this.propertyGrid.Size = new System.Drawing.Size(330, 242);
      this.propertyGrid.TabIndex = 2;
      // 
      // toolStrip1
      // 
      this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
      this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.butFromClipboard,
            this.toolStripSeparator1,
            this.butSave,
            this.toolStripSeparator2,
            this.butHex});
      this.toolStrip1.Location = new System.Drawing.Point(0, 0);
      this.toolStrip1.Name = "toolStrip1";
      this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
      this.toolStrip1.Size = new System.Drawing.Size(672, 25);
      this.toolStrip1.TabIndex = 1;
      this.toolStrip1.Text = "toolStrip1";
      // 
      // toolStripSeparator1
      // 
      this.toolStripSeparator1.Name = "toolStripSeparator1";
      this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
      // 
      // toolStripSeparator2
      // 
      this.toolStripSeparator2.Name = "toolStripSeparator2";
      this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
      // 
      // butFromClipboard
      // 
      this.butFromClipboard.Image = global::DragDropViewer.Properties.Resources.Paste_16_n_p;
      this.butFromClipboard.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.butFromClipboard.Name = "butFromClipboard";
      this.butFromClipboard.Size = new System.Drawing.Size(110, 22);
      this.butFromClipboard.Text = "From Clipboard";
      this.butFromClipboard.Click += new System.EventHandler(this.butFromClipboard_Click);
      // 
      // butSave
      // 
      this.butSave.Image = global::DragDropViewer.Properties.Resources.Save_Blue_16_n_p;
      this.butSave.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.butSave.Name = "butSave";
      this.butSave.Size = new System.Drawing.Size(51, 22);
      this.butSave.Text = "Save";
      this.butSave.Click += new System.EventHandler(this.butSave_Click);
      // 
      // butHex
      // 
      this.butHex.CheckOnClick = true;
      this.butHex.Image = global::DragDropViewer.Properties.Resources.Bug_16_n_p;
      this.butHex.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.butHex.Name = "butHex";
      this.butHex.Size = new System.Drawing.Size(47, 22);
      this.butHex.Text = "Hex";
      this.butHex.CheckedChanged += new System.EventHandler(this.butHex_CheckedChanged);
      // 
      // saveFileDialog1
      // 
      this.saveFileDialog1.Filter = "All Files|*.*";
      this.saveFileDialog1.Title = "Save Stream";
      // 
      // MainForm
      // 
      this.AllowDrop = true;
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(672, 520);
      this.Controls.Add(this.tableLayoutPanel1);
      this.Controls.Add(this.toolStrip1);
      this.Name = "MainForm";
      this.Text = "Drag Drop Viewer";
      this.DragDrop += new System.Windows.Forms.DragEventHandler(this.MainForm_DragDrop);
      this.DragEnter += new System.Windows.Forms.DragEventHandler(this.MainForm_DragEnter);
      this.tableLayoutPanel1.ResumeLayout(false);
      this.toolStrip1.ResumeLayout(false);
      this.toolStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.ListBox listFormats;
    private System.Windows.Forms.PropertyGrid propertyGrid;
    private System.Windows.Forms.ToolStrip toolStrip1;
    private System.Windows.Forms.ToolStripButton butFromClipboard;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    private System.Windows.Forms.ToolStripButton butSave;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    private System.Windows.Forms.ToolStripButton butHex;
    private System.Windows.Forms.SaveFileDialog saveFileDialog1;
  }
}

