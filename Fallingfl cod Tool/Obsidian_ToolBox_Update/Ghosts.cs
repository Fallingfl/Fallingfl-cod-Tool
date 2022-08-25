using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Obsidian_ToolBox_Update;

public class Ghosts : XtraForm
{
	private IContainer components = null;

	private ToggleSwitch toggleSwitch1;

	private ToggleSwitch toggleSwitch2;

	private ToggleSwitch toggleSwitch3;

	private ToggleSwitch toggleSwitch4;

	private ToolStrip toolStrip1;

	private ToolStripLabel toolStripLabel1;

	private ToolStripLabel toolStripLabel2;

	public Ghosts()
	{
		InitializeComponent();
	}

	private void Ghosts_Closed(object sender, FormClosedEventArgs e)
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Obsidian_ToolBox_Update.Ghosts));
		this.toggleSwitch1 = new DevExpress.XtraEditors.ToggleSwitch();
		this.toggleSwitch2 = new DevExpress.XtraEditors.ToggleSwitch();
		this.toggleSwitch3 = new DevExpress.XtraEditors.ToggleSwitch();
		this.toggleSwitch4 = new DevExpress.XtraEditors.ToggleSwitch();
		this.toolStrip1 = new System.Windows.Forms.ToolStrip();
		this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
		this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
		((System.ComponentModel.ISupportInitialize)this.toggleSwitch1.Properties).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.toggleSwitch2.Properties).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.toggleSwitch3.Properties).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.toggleSwitch4.Properties).BeginInit();
		this.toolStrip1.SuspendLayout();
		base.SuspendLayout();
		this.toggleSwitch1.Location = new System.Drawing.Point(12, 12);
		this.toggleSwitch1.Name = "toggleSwitch1";
		this.toggleSwitch1.Properties.OffText = "无敌 Off";
		this.toggleSwitch1.Properties.OnText = "无敌 On";
		this.toggleSwitch1.Size = new System.Drawing.Size(141, 24);
		this.toggleSwitch1.TabIndex = 0;
		this.toggleSwitch2.Location = new System.Drawing.Point(12, 42);
		this.toggleSwitch2.Name = "toggleSwitch2";
		this.toggleSwitch2.Properties.OffText = "最大金钱 Off";
		this.toggleSwitch2.Properties.OnText = "最大金钱 On";
		this.toggleSwitch2.Size = new System.Drawing.Size(149, 24);
		this.toggleSwitch2.TabIndex = 1;
		this.toggleSwitch3.Location = new System.Drawing.Point(12, 72);
		this.toggleSwitch3.Name = "toggleSwitch3";
		this.toggleSwitch3.Properties.OffText = "无限子弹 Off";
		this.toggleSwitch3.Properties.OnText = "无限子弹 On";
		this.toggleSwitch3.Size = new System.Drawing.Size(141, 24);
		this.toggleSwitch3.TabIndex = 2;
		this.toggleSwitch4.Location = new System.Drawing.Point(12, 102);
		this.toggleSwitch4.Name = "toggleSwitch4";
		this.toggleSwitch4.Properties.OffText = "无碰撞 Off";
		this.toggleSwitch4.Properties.OnText = "无碰撞 On";
		this.toggleSwitch4.Size = new System.Drawing.Size(141, 24);
		this.toggleSwitch4.TabIndex = 3;
		this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(45, 45, 48);
		this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
		this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[2] { this.toolStripLabel1, this.toolStripLabel2 });
		this.toolStrip1.Location = new System.Drawing.Point(0, 139);
		this.toolStrip1.Name = "toolStrip1";
		this.toolStrip1.Size = new System.Drawing.Size(322, 25);
		this.toolStrip1.TabIndex = 4;
		this.toolStrip1.Text = "";
		this.toolStripLabel1.Name = "toolStripLabel1";
		this.toolStripLabel1.Size = new System.Drawing.Size(53, 22);
		this.toolStripLabel1.Text = "进程 :";
		this.toolStripLabel2.Name = "toolStripLabel2";
		this.toolStripLabel2.Size = new System.Drawing.Size(29, 22);
		this.toolStripLabel2.Text = "N/A";
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(322, 164);
		base.Controls.Add(this.toolStrip1);
		base.Controls.Add(this.toggleSwitch4);
		base.Controls.Add(this.toggleSwitch3);
		base.Controls.Add(this.toggleSwitch2);
		base.Controls.Add(this.toggleSwitch1);
		base.IconOptions.Image = (System.Drawing.Image)resources.GetObject("Ghosts.IconOptions.Image");
		base.Name = "Ghosts";
		this.Text = "Ghosts";
		base.FormClosed += new System.Windows.Forms.FormClosedEventHandler(Ghosts_Closed);
		((System.ComponentModel.ISupportInitialize)this.toggleSwitch1.Properties).EndInit();
		((System.ComponentModel.ISupportInitialize)this.toggleSwitch2.Properties).EndInit();
		((System.ComponentModel.ISupportInitialize)this.toggleSwitch3.Properties).EndInit();
		((System.ComponentModel.ISupportInitialize)this.toggleSwitch4.Properties).EndInit();
		this.toolStrip1.ResumeLayout(false);
		this.toolStrip1.PerformLayout();
		base.ResumeLayout(false);
		base.PerformLayout();
	}
}
