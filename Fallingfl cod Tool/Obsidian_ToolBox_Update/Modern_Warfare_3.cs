using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Memory;
using Obsidian_ToolBox_Update.Properties;

namespace Obsidian_ToolBox_Update;

public class Modern_Warfare_3 : XtraForm
{
	private Mem MW3 = new Mem();

	private string God = "18447400";

	private string Noc = "20499276";

	private IContainer components = null;

	private ToolStrip toolStrip1;

	private ToolStripLabel toolStripLabel1;

	private ToolStripLabel ProcStatus;

	private ToggleSwitch god;

	private ToggleSwitch toggleSwitch2;

	private ToggleSwitch NoClip;

	private ToggleSwitch toggleSwitch4;

	public Modern_Warfare_3()
	{
		InitializeComponent();
	}

	private void Modern_Warfare_3_Load(object sender, EventArgs e)
	{
		int PID = MW3.GetProcIdFromName("iw5sp");
		if (PID > 0)
		{
			MW3.OpenProcess(PID);
			ProcStatus.ForeColor = Color.Green;
			ProcStatus.Text = "Found MW3";
		}
	}

	private void god_Toggled(object sender, EventArgs e)
	{
		if (god.IsOn)
		{
			MW3.WriteMemory(God, "int", "9999");
		}
		else
		{
			MW3.WriteMemory(God, "int", "100");
		}
	}

	private void NoClip_Toggled(object sender, EventArgs e)
	{
		if (NoClip.IsOn)
		{
			MW3.WriteMemory(Noc, "byte", "1");
		}
		else
		{
			MW3.WriteMemory(Noc, "byte", "0");
		}
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
		this.toolStrip1 = new System.Windows.Forms.ToolStrip();
		this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
		this.ProcStatus = new System.Windows.Forms.ToolStripLabel();
		this.god = new DevExpress.XtraEditors.ToggleSwitch();
		this.toggleSwitch2 = new DevExpress.XtraEditors.ToggleSwitch();
		this.NoClip = new DevExpress.XtraEditors.ToggleSwitch();
		this.toggleSwitch4 = new DevExpress.XtraEditors.ToggleSwitch();
		this.toolStrip1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.god.Properties).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.toggleSwitch2.Properties).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.NoClip.Properties).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.toggleSwitch4.Properties).BeginInit();
		base.SuspendLayout();
		this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(45, 45, 48);
		this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
		this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[2] { this.toolStripLabel1, this.ProcStatus });
		this.toolStrip1.Location = new System.Drawing.Point(0, 83);
		this.toolStrip1.Name = "toolStrip1";
		this.toolStrip1.Size = new System.Drawing.Size(299, 25);
		this.toolStrip1.TabIndex = 0;
		this.toolStrip1.Text = "toolStrip1";
		this.toolStripLabel1.Name = "toolStripLabel1";
		this.toolStripLabel1.Size = new System.Drawing.Size(53, 22);
		this.toolStripLabel1.Text = "Process :";
		this.ProcStatus.Name = "ProcStatus";
		this.ProcStatus.Size = new System.Drawing.Size(29, 22);
		this.ProcStatus.Text = "N/A";
		this.god.Location = new System.Drawing.Point(12, 12);
		this.god.Name = "god";
		this.god.Properties.OffText = "GodMode Off";
		this.god.Properties.OnText = "GodMode On";
		this.god.Size = new System.Drawing.Size(142, 24);
		this.god.TabIndex = 1;
		this.god.Toggled += new System.EventHandler(god_Toggled);
		this.toggleSwitch2.Location = new System.Drawing.Point(160, 12);
		this.toggleSwitch2.Name = "toggleSwitch2";
		this.toggleSwitch2.Properties.OffText = "uAmmo Off";
		this.toggleSwitch2.Properties.OnText = "uAmmo On";
		this.toggleSwitch2.Size = new System.Drawing.Size(142, 24);
		this.toggleSwitch2.TabIndex = 2;
		this.NoClip.Location = new System.Drawing.Point(12, 42);
		this.NoClip.MaximumSize = new System.Drawing.Size(142, 24);
		this.NoClip.MinimumSize = new System.Drawing.Size(142, 24);
		this.NoClip.Name = "NoClip";
		this.NoClip.Properties.OffText = "No Clip Off";
		this.NoClip.Properties.OnText = "No Clip On";
		this.NoClip.Size = new System.Drawing.Size(142, 24);
		this.NoClip.TabIndex = 3;
		this.NoClip.Toggled += new System.EventHandler(NoClip_Toggled);
		this.toggleSwitch4.Location = new System.Drawing.Point(160, 42);
		this.toggleSwitch4.Name = "toggleSwitch4";
		this.toggleSwitch4.Properties.OffText = "Speed Off";
		this.toggleSwitch4.Properties.OnText = "Speed On";
		this.toggleSwitch4.Size = new System.Drawing.Size(142, 24);
		this.toggleSwitch4.TabIndex = 4;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(299, 108);
		base.Controls.Add(this.toggleSwitch4);
		base.Controls.Add(this.NoClip);
		base.Controls.Add(this.toggleSwitch2);
		base.Controls.Add(this.god);
		base.Controls.Add(this.toolStrip1);
		base.IconOptions.Image = Obsidian_ToolBox_Update.Properties.Resources.kisspng_call_of_duty_modern_warfare_3_delta_force_united_5af9c6fe30bf93_4497314715263188461997_jpg;
		base.Name = "Modern_Warfare_3";
		this.Text = "MW3 - Spec Ops";
		base.Load += new System.EventHandler(Modern_Warfare_3_Load);
		this.toolStrip1.ResumeLayout(false);
		this.toolStrip1.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.god.Properties).EndInit();
		((System.ComponentModel.ISupportInitialize)this.toggleSwitch2.Properties).EndInit();
		((System.ComponentModel.ISupportInitialize)this.NoClip.Properties).EndInit();
		((System.ComponentModel.ISupportInitialize)this.toggleSwitch4.Properties).EndInit();
		base.ResumeLayout(false);
		base.PerformLayout();
	}
}
