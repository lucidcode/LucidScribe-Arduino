namespace lucidcode.LucidScribe.Plugout.Arduino
{
  partial class PortForm
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PortForm));
      this.pnlPlugins = new lucidcode.Controls.Panel3D();
      this.lstPorts = new System.Windows.Forms.ListView();
      this.lstImg = new System.Windows.Forms.ImageList(this.components);
      this.Panel3D4 = new lucidcode.Controls.Panel3D();
      this.Label5 = new System.Windows.Forms.Label();
      this.Label6 = new System.Windows.Forms.Label();
      this.panel3D3 = new lucidcode.Controls.Panel3D();
      this.cmbArduinoDelay = new System.Windows.Forms.ComboBox();
      this.txtArduinoOff = new System.Windows.Forms.TextBox();
      this.txtArduinoOn = new System.Windows.Forms.TextBox();
      this.label7 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.panel3D5 = new lucidcode.Controls.Panel3D();
      this.label3 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.pnlPlugins.SuspendLayout();
      this.Panel3D4.SuspendLayout();
      this.panel3D3.SuspendLayout();
      this.panel3D5.SuspendLayout();
      this.SuspendLayout();
      // 
      // pnlPlugins
      // 
      this.pnlPlugins.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.pnlPlugins.BackColor = System.Drawing.Color.White;
      this.pnlPlugins.Controls.Add(this.lstPorts);
      this.pnlPlugins.Controls.Add(this.Panel3D4);
      this.pnlPlugins.Location = new System.Drawing.Point(12, 12);
      this.pnlPlugins.Name = "pnlPlugins";
      this.pnlPlugins.Size = new System.Drawing.Size(355, 224);
      this.pnlPlugins.TabIndex = 5;
      // 
      // lstPorts
      // 
      this.lstPorts.Activation = System.Windows.Forms.ItemActivation.OneClick;
      this.lstPorts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.lstPorts.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.lstPorts.LargeImageList = this.lstImg;
      this.lstPorts.Location = new System.Drawing.Point(3, 25);
      this.lstPorts.MultiSelect = false;
      this.lstPorts.Name = "lstPorts";
      this.lstPorts.Size = new System.Drawing.Size(349, 196);
      this.lstPorts.TabIndex = 8;
      this.lstPorts.TileSize = new System.Drawing.Size(150, 32);
      this.lstPorts.UseCompatibleStateImageBehavior = false;
      this.lstPorts.View = System.Windows.Forms.View.Tile;
      this.lstPorts.SelectedIndexChanged += new System.EventHandler(this.lstPlaylists_SelectedIndexChanged);
      this.lstPorts.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lstPlaylists_MouseMove);
      // 
      // lstImg
      // 
      this.lstImg.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("lstImg.ImageStream")));
      this.lstImg.TransparentColor = System.Drawing.Color.Transparent;
      this.lstImg.Images.SetKeyName(0, "Graph.Plugin2.bmp");
      // 
      // Panel3D4
      // 
      this.Panel3D4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.Panel3D4.BackColor = System.Drawing.Color.SteelBlue;
      this.Panel3D4.Controls.Add(this.Label5);
      this.Panel3D4.Controls.Add(this.Label6);
      this.Panel3D4.Location = new System.Drawing.Point(0, 0);
      this.Panel3D4.Name = "Panel3D4";
      this.Panel3D4.Size = new System.Drawing.Size(355, 24);
      this.Panel3D4.TabIndex = 4;
      // 
      // Label5
      // 
      this.Label5.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
      this.Label5.ForeColor = System.Drawing.Color.White;
      this.Label5.Image = ((System.Drawing.Image)(resources.GetObject("Label5.Image")));
      this.Label5.Location = new System.Drawing.Point(3, 3);
      this.Label5.Name = "Label5";
      this.Label5.Size = new System.Drawing.Size(19, 19);
      this.Label5.TabIndex = 4;
      this.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // Label6
      // 
      this.Label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.Label6.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold);
      this.Label6.ForeColor = System.Drawing.Color.White;
      this.Label6.Location = new System.Drawing.Point(24, 3);
      this.Label6.Name = "Label6";
      this.Label6.Size = new System.Drawing.Size(328, 19);
      this.Label6.TabIndex = 3;
      this.Label6.Text = "Select port to connect";
      this.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // panel3D3
      // 
      this.panel3D3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.panel3D3.BackColor = System.Drawing.Color.LightSteelBlue;
      this.panel3D3.Controls.Add(this.cmbArduinoDelay);
      this.panel3D3.Controls.Add(this.txtArduinoOff);
      this.panel3D3.Controls.Add(this.txtArduinoOn);
      this.panel3D3.Controls.Add(this.label7);
      this.panel3D3.Controls.Add(this.label1);
      this.panel3D3.Controls.Add(this.label2);
      this.panel3D3.Controls.Add(this.panel3D5);
      this.panel3D3.Location = new System.Drawing.Point(12, 242);
      this.panel3D3.Name = "panel3D3";
      this.panel3D3.Size = new System.Drawing.Size(355, 113);
      this.panel3D3.TabIndex = 38;
      // 
      // cmbArduinoDelay
      // 
      this.cmbArduinoDelay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.cmbArduinoDelay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cmbArduinoDelay.FormattingEnabled = true;
      this.cmbArduinoDelay.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
      this.cmbArduinoDelay.Location = new System.Drawing.Point(69, 30);
      this.cmbArduinoDelay.Name = "cmbArduinoDelay";
      this.cmbArduinoDelay.Size = new System.Drawing.Size(280, 21);
      this.cmbArduinoDelay.TabIndex = 295;
      // 
      // txtArduinoOff
      // 
      this.txtArduinoOff.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.txtArduinoOff.Location = new System.Drawing.Point(69, 84);
      this.txtArduinoOff.Name = "txtArduinoOff";
      this.txtArduinoOff.Size = new System.Drawing.Size(280, 21);
      this.txtArduinoOff.TabIndex = 294;
      this.txtArduinoOff.Text = "0";
      // 
      // txtArduinoOn
      // 
      this.txtArduinoOn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.txtArduinoOn.Location = new System.Drawing.Point(69, 57);
      this.txtArduinoOn.Name = "txtArduinoOn";
      this.txtArduinoOn.Size = new System.Drawing.Size(280, 21);
      this.txtArduinoOn.TabIndex = 292;
      this.txtArduinoOn.Text = "1";
      // 
      // label7
      // 
      this.label7.ForeColor = System.Drawing.Color.MidnightBlue;
      this.label7.Location = new System.Drawing.Point(6, 83);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(87, 21);
      this.label7.TabIndex = 297;
      this.label7.Text = "Off";
      this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // label1
      // 
      this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
      this.label1.Location = new System.Drawing.Point(6, 57);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(87, 21);
      this.label1.TabIndex = 297;
      this.label1.Text = "On";
      this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // label2
      // 
      this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
      this.label2.Location = new System.Drawing.Point(6, 29);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(87, 21);
      this.label2.TabIndex = 296;
      this.label2.Text = "Delay";
      this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // panel3D5
      // 
      this.panel3D5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.panel3D5.BackColor = System.Drawing.Color.SteelBlue;
      this.panel3D5.Controls.Add(this.label3);
      this.panel3D5.Controls.Add(this.label4);
      this.panel3D5.Location = new System.Drawing.Point(0, 0);
      this.panel3D5.Name = "panel3D5";
      this.panel3D5.Size = new System.Drawing.Size(355, 24);
      this.panel3D5.TabIndex = 4;
      // 
      // label3
      // 
      this.label3.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
      this.label3.ForeColor = System.Drawing.Color.White;
      this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
      this.label3.Location = new System.Drawing.Point(3, 3);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(19, 19);
      this.label3.TabIndex = 4;
      this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // label4
      // 
      this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.label4.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold);
      this.label4.ForeColor = System.Drawing.Color.White;
      this.label4.Location = new System.Drawing.Point(24, 3);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(328, 19);
      this.label4.TabIndex = 3;
      this.label4.Text = "Settings";
      this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // PortForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.LightSteelBlue;
      this.ClientSize = new System.Drawing.Size(379, 367);
      this.Controls.Add(this.panel3D3);
      this.Controls.Add(this.pnlPlugins);
      this.Font = new System.Drawing.Font("Verdana", 8.25F);
      this.ForeColor = System.Drawing.Color.MidnightBlue;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "PortForm";
      this.Text = "Lucid Scribe - Arduino";
      this.Load += new System.EventHandler(this.PortForm_Load);
      this.pnlPlugins.ResumeLayout(false);
      this.Panel3D4.ResumeLayout(false);
      this.panel3D3.ResumeLayout(false);
      this.panel3D3.PerformLayout();
      this.panel3D5.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    internal lucidcode.Controls.Panel3D pnlPlugins;
    internal lucidcode.Controls.Panel3D Panel3D4;
    internal System.Windows.Forms.Label Label5;
    internal System.Windows.Forms.Label Label6;
    internal System.Windows.Forms.ListView lstPorts;
    internal System.Windows.Forms.ImageList lstImg;
    internal lucidcode.Controls.Panel3D panel3D3;
    private System.Windows.Forms.ComboBox cmbArduinoDelay;
    private System.Windows.Forms.TextBox txtArduinoOff;
    private System.Windows.Forms.TextBox txtArduinoOn;
    internal lucidcode.Controls.Panel3D panel3D5;
    internal System.Windows.Forms.Label label3;
    internal System.Windows.Forms.Label label4;
    internal System.Windows.Forms.Label label7;
    internal System.Windows.Forms.Label label1;
    internal System.Windows.Forms.Label label2;
  }
}