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
      this.butFromClipboard = new System.Windows.Forms.Button();
      this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
      this.tableLayoutPanel1.SuspendLayout();
      this.flowLayoutPanel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // tableLayoutPanel1
      // 
      this.tableLayoutPanel1.ColumnCount = 2;
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel1.Controls.Add(this.listFormats, 0, 1);
      this.tableLayoutPanel1.Controls.Add(this.propertyGrid, 0, 2);
      this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 0);
      this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      this.tableLayoutPanel1.RowCount = 3;
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel1.Size = new System.Drawing.Size(672, 520);
      this.tableLayoutPanel1.TabIndex = 0;
      this.tableLayoutPanel1.DragDrop += new System.Windows.Forms.DragEventHandler(this.MainForm_DragDrop);
      // 
      // listFormats
      // 
      this.listFormats.AllowDrop = true;
      this.listFormats.Dock = System.Windows.Forms.DockStyle.Fill;
      this.listFormats.FormattingEnabled = true;
      this.listFormats.Location = new System.Drawing.Point(3, 38);
      this.listFormats.Name = "listFormats";
      this.listFormats.Size = new System.Drawing.Size(330, 236);
      this.listFormats.TabIndex = 1;
      this.listFormats.SelectedIndexChanged += new System.EventHandler(this.listFormats_SelectedIndexChanged);
      this.listFormats.DragDrop += new System.Windows.Forms.DragEventHandler(this.MainForm_DragDrop);
      // 
      // propertyGrid
      // 
      this.propertyGrid.Dock = System.Windows.Forms.DockStyle.Fill;
      this.propertyGrid.LineColor = System.Drawing.SystemColors.ControlDark;
      this.propertyGrid.Location = new System.Drawing.Point(3, 280);
      this.propertyGrid.Name = "propertyGrid";
      this.propertyGrid.Size = new System.Drawing.Size(330, 237);
      this.propertyGrid.TabIndex = 2;
      // 
      // butFromClipboard
      // 
      this.butFromClipboard.Location = new System.Drawing.Point(3, 3);
      this.butFromClipboard.Name = "butFromClipboard";
      this.butFromClipboard.Size = new System.Drawing.Size(154, 23);
      this.butFromClipboard.TabIndex = 0;
      this.butFromClipboard.Text = "Get Clipboard Data";
      this.butFromClipboard.UseVisualStyleBackColor = true;
      this.butFromClipboard.Click += new System.EventHandler(this.butFromClipboard_Click);
      // 
      // flowLayoutPanel1
      // 
      this.flowLayoutPanel1.AutoSize = true;
      this.tableLayoutPanel1.SetColumnSpan(this.flowLayoutPanel1, 2);
      this.flowLayoutPanel1.Controls.Add(this.butFromClipboard);
      this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
      this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
      this.flowLayoutPanel1.Name = "flowLayoutPanel1";
      this.flowLayoutPanel1.Size = new System.Drawing.Size(666, 29);
      this.flowLayoutPanel1.TabIndex = 3;
      this.flowLayoutPanel1.DragDrop += new System.Windows.Forms.DragEventHandler(this.MainForm_DragDrop);
      // 
      // MainForm
      // 
      this.AllowDrop = true;
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(672, 520);
      this.Controls.Add(this.tableLayoutPanel1);
      this.Name = "MainForm";
      this.Text = "Drag Drop Viewer";
      this.DragDrop += new System.Windows.Forms.DragEventHandler(this.MainForm_DragDrop);
      this.DragEnter += new System.Windows.Forms.DragEventHandler(this.MainForm_DragEnter);
      this.tableLayoutPanel1.ResumeLayout(false);
      this.tableLayoutPanel1.PerformLayout();
      this.flowLayoutPanel1.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.ListBox listFormats;
    private System.Windows.Forms.PropertyGrid propertyGrid;
    private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    private System.Windows.Forms.Button butFromClipboard;
  }
}

