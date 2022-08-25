using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Memory;

namespace Obsidian_ToolBox_Update;

public class Advanced_Warfare_S1X : XtraForm
{
	private Mem AW = new Mem();

	private IContainer components = null;

	private ToggleSwitch awGodToggle;

	private ToggleSwitch awuAmmoToggle;

	private ToggleSwitch awNCToggle;

	private ToolStrip toolStrip1;

	private ToolStripLabel toolStripLabel1;

	private ToolStripLabel ProcStatus;

	private ToggleSwitch awTSCToggle;

	private ToggleSwitch awmptOGGLE;

	private TextEdit textEdit1;

	private CheckButton checkButton1;

	public Advanced_Warfare_S1X()
	{
		InitializeComponent();
	}

	private void Advanced_Warfare_S1X_Load(object sender, EventArgs e)
	{
		int PID = AW.GetProcIdFromName("S1X");
		if (PID > 0)
		{
			AW.OpenProcess(PID);
			ProcStatus.ForeColor = Color.Green;
			ProcStatus.Text = "Found Advanced Warfare";
		}
	}

	private void awGodToggle_Toggled(object sender, EventArgs e)
	{
		if (awGodToggle.IsOn)
		{
			AW.FreezeValue("144758E40", "int", "9999");
		}
		else
		{
			AW.UnfreezeValue("144758E40");
		}
	}

	private void awuAmmoToggle_Toggled(object sender, EventArgs e)
	{
		if (awuAmmoToggle.IsOn)
		{
			AW.FreezeValue("14495FA70", "int", "9999");
			AW.FreezeValue("14495FB30", "int", "255");
			AW.FreezeValue("1418266E4", "int", "9999");
			AW.FreezeValue("1418267B0", "int", "255");
		}
		else
		{
			AW.UnfreezeValue("14495FA70");
			AW.UnfreezeValue("14495FB30");
			AW.UnfreezeValue("1418266E4");
			AW.UnfreezeValue("1418267B0");
		}
	}

	private void awNCToggle_Toggled(object sender, EventArgs e)
	{
		if (awNCToggle.IsOn)
		{
			AW.FreezeValue("144964810", "byte", "1");
		}
		else
		{
			AW.FreezeValue("144964810", "byte", "0");
		}
	}

	private void AW_Closed(object sender, FormClosedEventArgs e)
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
            this.awGodToggle = new DevExpress.XtraEditors.ToggleSwitch();
            this.awuAmmoToggle = new DevExpress.XtraEditors.ToggleSwitch();
            this.awNCToggle = new DevExpress.XtraEditors.ToggleSwitch();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.ProcStatus = new System.Windows.Forms.ToolStripLabel();
            this.awTSCToggle = new DevExpress.XtraEditors.ToggleSwitch();
            this.awmptOGGLE = new DevExpress.XtraEditors.ToggleSwitch();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.checkButton1 = new DevExpress.XtraEditors.CheckButton();
            ((System.ComponentModel.ISupportInitialize)(this.awGodToggle.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.awuAmmoToggle.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.awNCToggle.Properties)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.awTSCToggle.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.awmptOGGLE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // awGodToggle
            // 
            this.awGodToggle.Location = new System.Drawing.Point(14, 13);
            this.awGodToggle.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.awGodToggle.Name = "awGodToggle";
            // 
            // 
            // 
            this.awGodToggle.Properties.OffText = "无敌 Off";
            this.awGodToggle.Properties.OnText = "无敌 On";
            this.awGodToggle.Size = new System.Drawing.Size(164, 25);
            this.awGodToggle.TabIndex = 0;
            this.awGodToggle.Toggled += new System.EventHandler(this.awGodToggle_Toggled);
            // 
            // awuAmmoToggle
            // 
            this.awuAmmoToggle.Location = new System.Drawing.Point(14, 45);
            this.awuAmmoToggle.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.awuAmmoToggle.Name = "awuAmmoToggle";
            // 
            // 
            // 
            this.awuAmmoToggle.Properties.OffText = "无限子弹 Off";
            this.awuAmmoToggle.Properties.OnText = "无限子弹 On";
            this.awuAmmoToggle.Size = new System.Drawing.Size(164, 25);
            this.awuAmmoToggle.TabIndex = 1;
            this.awuAmmoToggle.Toggled += new System.EventHandler(this.awuAmmoToggle_Toggled);
            // 
            // awNCToggle
            // 
            this.awNCToggle.Location = new System.Drawing.Point(14, 78);
            this.awNCToggle.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.awNCToggle.Name = "awNCToggle";
            // 
            // 
            // 
            this.awNCToggle.Properties.OffText = "无碰撞 Off";
            this.awNCToggle.Properties.OnText = "无碰撞 On";
            this.awNCToggle.Size = new System.Drawing.Size(164, 25);
            this.awNCToggle.TabIndex = 2;
            this.awNCToggle.Toggled += new System.EventHandler(this.awNCToggle_Toggled);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.ProcStatus});
            this.toolStrip1.Location = new System.Drawing.Point(0, 127);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(354, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "进程连接";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(39, 22);
            this.toolStripLabel1.Text = "进程 :";
            // 
            // ProcStatus
            // 
            this.ProcStatus.Name = "ProcStatus";
            this.ProcStatus.Size = new System.Drawing.Size(31, 22);
            this.ProcStatus.Text = "N/A";
            // 
            // awTSCToggle
            // 
            this.awTSCToggle.Location = new System.Drawing.Point(186, 13);
            this.awTSCToggle.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.awTSCToggle.Name = "awTSCToggle";
            // 
            // 
            // 
            this.awTSCToggle.Properties.OffText = "时间尺度 Off";
            this.awTSCToggle.Properties.OnText = "时间尺度 On";
            this.awTSCToggle.Size = new System.Drawing.Size(164, 25);
            this.awTSCToggle.TabIndex = 4;
            // 
            // awmptOGGLE
            // 
            this.awmptOGGLE.Location = new System.Drawing.Point(186, 45);
            this.awmptOGGLE.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.awmptOGGLE.Name = "awmptOGGLE";
            // 
            // 
            // 
            this.awmptOGGLE.Properties.OffText = "无限分数 Off";
            this.awmptOGGLE.Properties.OnText = "无限分数 On";
            this.awmptOGGLE.Size = new System.Drawing.Size(178, 25);
            this.awmptOGGLE.TabIndex = 5;
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(186, 79);
            this.textEdit1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(162, 20);
            this.textEdit1.TabIndex = 6;
            // 
            // checkButton1
            // 
            this.checkButton1.Location = new System.Drawing.Point(186, 107);
            this.checkButton1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.checkButton1.Name = "checkButton1";
            this.checkButton1.Size = new System.Drawing.Size(162, 25);
            this.checkButton1.TabIndex = 7;
            this.checkButton1.Text = "轮换";
            // 
            // Advanced_Warfare_S1X
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 152);
            this.Controls.Add(this.checkButton1);
            this.Controls.Add(this.textEdit1);
            this.Controls.Add(this.awmptOGGLE);
            this.Controls.Add(this.awTSCToggle);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.awNCToggle);
            this.Controls.Add(this.awuAmmoToggle);
            this.Controls.Add(this.awGodToggle);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximumSize = new System.Drawing.Size(370, 200);
            this.MinimumSize = new System.Drawing.Size(370, 200);
            this.Name = "Advanced_Warfare_S1X";
            this.Text = "AW S1X";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AW_Closed);
            this.Load += new System.EventHandler(this.Advanced_Warfare_S1X_Load);
            ((System.ComponentModel.ISupportInitialize)(this.awGodToggle.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.awuAmmoToggle.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.awNCToggle.Properties)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.awTSCToggle.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.awmptOGGLE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

	}
}
