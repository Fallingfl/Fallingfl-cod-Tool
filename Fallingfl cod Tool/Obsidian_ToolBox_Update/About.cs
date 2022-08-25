using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Obsidian_ToolBox_Update;

public class About : XtraForm
{
	private IContainer components = null;

	private LabelControl labelControl1;

	private LabelControl labelControl2;

	private LabelControl labelControl3;

	private LabelControl labelControl4;

	public About()
	{
		InitializeComponent();
	}

	private void About_Closed(object sender, FormClosedEventArgs e)
	{
		Hide();
		Form1 form1 = new Form1();
		form1.Show();
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			components.Dispose();
		}
		base.Dispose(disposing);
	}

	private void InitializeComponent()
	{
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(41, 43);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(215, 25);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "此工具由Fallingfl编写";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(0, 0);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(0, 14);
            this.labelControl2.TabIndex = 2;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(0, 0);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(0, 14);
            this.labelControl3.TabIndex = 1;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(0, 0);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(0, 14);
            this.labelControl4.TabIndex = 0;
            // 
            // About
            // 
            this.Appearance.ForeColor = System.Drawing.Color.Fuchsia;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 158);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "About";
            this.Text = "关于";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.About_Closed);
            this.ResumeLayout(false);
            this.PerformLayout();

	}
}
