using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using Memory;

namespace Obsidian_ToolBox_Update;

public class BlackOps_2 : XtraForm
{
	private Mem BO2 = new Mem();

	private IContainer components = null;

	private ToggleSwitch bo2GodToggle;

	private ToggleSwitch BO2uAmmo;

	private ToggleSwitch uNade;

	private ToggleSwitch PointsToggle;

	private ToolStrip toolStrip1;

	private ToolStripLabel toolStripLabel1;

	private ToolStripLabel ProcStatus;

	private ToggleSwitch ThirdPToggle;

	private TrackBarControl trackBarControl1;

	private LabelControl labelControl1;

	private LabelControl labelControl2;

	private TrackBarControl trackBarControl2;

	private TextEdit inGametxt;

	private SimpleButton simpleButton1;

	private ToggleSwitch SpeedToggle;

	private ToggleSwitch JumpToggle;

	private ToggleSwitch MeleeToggle;

	private SimpleButton simpleButton2;

	private TextEdit SpoofName;

	private SimpleButton simpleButton3;

	private TextEdit RoundEdit;

	private ToggleSwitch NoClipToggle;

	private ToggleSwitch toggleSwitch2;

	public BlackOps_2()
	{
		InitializeComponent();
	}

	private void trackBarControl1_EditValueChanged(object sender, EventArgs e)
	{
		if (trackBarControl1.Value == 65)
		{
			BO2.WriteMemory("2A11740", "float", "65");
		}
		if (trackBarControl1.Value == 80)
		{
			BO2.WriteMemory("2A11740", "float", "80");
		}
		if (trackBarControl1.Value == 90)
		{
			BO2.WriteMemory("2A11740", "float", "90");
		}
		if (trackBarControl1.Value == 100)
		{
			BO2.WriteMemory("2A11740", "float", "100");
		}
		if (trackBarControl1.Value == 110)
		{
			BO2.WriteMemory("2A11740", "float", "110");
		}
		if (trackBarControl1.Value == 120)
		{
			BO2.WriteMemory("2A11740", "float", "120");
		}
	}

	private void BO2_Closed(object sender, FormClosedEventArgs e)
	{
		Hide();
		Form1 form1 = new Form1();
		form1.Show();
	}

	private void trackBarControl2_EditValueChanged(object sender, EventArgs e)
	{
		if (trackBarControl2.Value == 1)
		{
			BO2.WriteMemory("02A04DE0", "float", "1");
		}
		if (trackBarControl2.Value == 2)
		{
			BO2.WriteMemory("02A04DE0", "float", "2");
		}
		if (trackBarControl2.Value == 3)
		{
			BO2.WriteMemory("02A04DE0", "float", "3");
		}
		if (trackBarControl2.Value == 4)
		{
			BO2.WriteMemory("02A04DE0", "float", "4");
		}
		if (trackBarControl2.Value == 5)
		{
			BO2.WriteMemory("02A04DE0", "float", "5");
		}
		if (trackBarControl2.Value == 6)
		{
			BO2.WriteMemory("02A04DE0", "float", "6");
		}
	}

	private void BlackOps_2_Load(object sender, EventArgs e)
	{
		int PID = BO2.GetProcIdFromName("plutonium-bootstrapper-win32");
		if (PID > 0)
		{
			BO2.OpenProcess(PID);
			ProcStatus.ForeColor = Color.Green;
			ProcStatus.Text = "Found Black Ops 2";
		}
	}

	private void simpleButton1_Click(object sender, EventArgs e)
	{
		BO2.WriteMemory("02347CD4", "string", inGametxt.Text);
	}

	private void simpleButton2_Click(object sender, EventArgs e)
	{
		BO2.WriteMemory("2068D7F8", "string", SpoofName.Text);
	}

	private void bo2GodToggle_Toggled(object sender, EventArgs e)
	{
		if (bo2GodToggle.IsOn)
		{
			BO2.FreezeValue("021C1568", "int", "999");
		}
		else
		{
			BO2.UnfreezeValue("021C1568");
		}
	}

	private void toggleSwitch2_Toggled(object sender, EventArgs e)
	{
		if (BO2uAmmo.IsOn)
		{
			BO2.FreezeValue("02342BCC", "int", "9999");
			BO2.FreezeValue("02342B90", "int", "9999");
			BO2.FreezeValue("02342BD4", "int", "9999");
			BO2.FreezeValue("02342B98", "int", "9999");
			BO2.FreezeValue("02342BD8", "int", "9999");
		}
		else
		{
			BO2.UnfreezeValue("02342BCC");
			BO2.UnfreezeValue("02342B90");
			BO2.UnfreezeValue("02342BD4");
			BO2.UnfreezeValue("02342B98");
			BO2.UnfreezeValue("02342BD8");
		}
	}

	private void uNade_Toggled(object sender, EventArgs e)
	{
		if (uNade.IsOn)
		{
			BO2.FreezeValue("02342BD0", "int", "4");
		}
		else
		{
			BO2.UnfreezeValue("02342BD0");
		}
	}

	private void JumpToggle_Toggled(object sender, EventArgs e)
	{
		if (JumpToggle.IsOn)
		{
			BO2.FreezeValue("029FE480", "float", "999999");
		}
		else
		{
			BO2.FreezeValue("029FE480", "float", "39");
		}
	}

	private void PointsToggle_Toggled(object sender, EventArgs e)
	{
		BO2.FreezeValue("02347D68", "int", "99999");
	}

	private void ThirdPToggle_Toggled(object sender, EventArgs e)
	{
		if (ThirdPToggle.IsOn)
		{
			BO2.FreezeValue("02342824", "int", "1");
		}
		else
		{
			BO2.FreezeValue("02342824", "int", "0");
		}
	}

	private void SpeedToggle_Toggled(object sender, EventArgs e)
	{
		if (SpeedToggle.IsOn)
		{
			BO2.FreezeValue("029F21E0", "int", "500");
		}
		else
		{
			BO2.FreezeValue("029F21E0", "int", "190");
		}
	}

	private void MeleeToggle_Toggled(object sender, EventArgs e)
	{
		if (MeleeToggle.IsOn)
		{
			BO2.FreezeValue("029FC380", "float", "999");
		}
		else
		{
			BO2.FreezeValue("029FC380", "float", "55");
		}
	}

	private void simpleButton3_Click(object sender, EventArgs e)
	{
		BO2.WriteMemory("0233FA10", "int", RoundEdit.Text);
	}

	private void toggleSwitch1_Toggled(object sender, EventArgs e)
	{
		if (NoClipToggle.IsOn)
		{
			BO2.WriteMemory("2347E24", "byte", "1");
		}
		else
		{
			BO2.WriteMemory("2347E24", "byte", "0");
		}
	}

	private void simpleButton4_Click(object sender, EventArgs e)
	{
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
            DevExpress.XtraEditors.Repository.TrackBarLabel trackBarLabel2 = new DevExpress.XtraEditors.Repository.TrackBarLabel();
            this.bo2GodToggle = new DevExpress.XtraEditors.ToggleSwitch();
            this.BO2uAmmo = new DevExpress.XtraEditors.ToggleSwitch();
            this.uNade = new DevExpress.XtraEditors.ToggleSwitch();
            this.PointsToggle = new DevExpress.XtraEditors.ToggleSwitch();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.ProcStatus = new System.Windows.Forms.ToolStripLabel();
            this.ThirdPToggle = new DevExpress.XtraEditors.ToggleSwitch();
            this.trackBarControl1 = new DevExpress.XtraEditors.TrackBarControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.trackBarControl2 = new DevExpress.XtraEditors.TrackBarControl();
            this.inGametxt = new DevExpress.XtraEditors.TextEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.SpeedToggle = new DevExpress.XtraEditors.ToggleSwitch();
            this.JumpToggle = new DevExpress.XtraEditors.ToggleSwitch();
            this.MeleeToggle = new DevExpress.XtraEditors.ToggleSwitch();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.SpoofName = new DevExpress.XtraEditors.TextEdit();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.RoundEdit = new DevExpress.XtraEditors.TextEdit();
            this.NoClipToggle = new DevExpress.XtraEditors.ToggleSwitch();
            this.toggleSwitch2 = new DevExpress.XtraEditors.ToggleSwitch();
            ((System.ComponentModel.ISupportInitialize)(this.bo2GodToggle.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BO2uAmmo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uNade.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PointsToggle.Properties)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ThirdPToggle.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarControl1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarControl2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inGametxt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpeedToggle.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.JumpToggle.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MeleeToggle.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpoofName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RoundEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NoClipToggle.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toggleSwitch2.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // bo2GodToggle
            // 
            this.bo2GodToggle.Location = new System.Drawing.Point(14, 13);
            this.bo2GodToggle.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bo2GodToggle.Name = "bo2GodToggle";
            // 
            // 
            // 
            this.bo2GodToggle.Properties.OffText = "无敌 Off";
            this.bo2GodToggle.Properties.OnText = "无敌 On";
            this.bo2GodToggle.Size = new System.Drawing.Size(164, 25);
            this.bo2GodToggle.TabIndex = 0;
            this.bo2GodToggle.Toggled += new System.EventHandler(this.bo2GodToggle_Toggled);
            // 
            // BO2uAmmo
            // 
            this.BO2uAmmo.Location = new System.Drawing.Point(14, 45);
            this.BO2uAmmo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BO2uAmmo.Name = "BO2uAmmo";
            // 
            // 
            // 
            this.BO2uAmmo.Properties.OffText = "无限子弹 Off";
            this.BO2uAmmo.Properties.OnText = "无限子弹 On";
            this.BO2uAmmo.Size = new System.Drawing.Size(164, 25);
            this.BO2uAmmo.TabIndex = 1;
            this.BO2uAmmo.Toggled += new System.EventHandler(this.toggleSwitch2_Toggled);
            // 
            // uNade
            // 
            this.uNade.Location = new System.Drawing.Point(14, 78);
            this.uNade.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.uNade.Name = "uNade";
            // 
            // 
            // 
            this.uNade.Properties.OffText = "无限手雷 Off";
            this.uNade.Properties.OnText = "无限手雷 On";
            this.uNade.Size = new System.Drawing.Size(164, 25);
            this.uNade.TabIndex = 3;
            this.uNade.Toggled += new System.EventHandler(this.uNade_Toggled);
            // 
            // PointsToggle
            // 
            this.PointsToggle.Location = new System.Drawing.Point(204, 13);
            this.PointsToggle.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.PointsToggle.Name = "PointsToggle";
            // 
            // 
            // 
            this.PointsToggle.Properties.OffText = "最大分数 Off";
            this.PointsToggle.Properties.OnText = "最大分数 On";
            this.PointsToggle.Size = new System.Drawing.Size(172, 25);
            this.PointsToggle.TabIndex = 4;
            this.PointsToggle.Toggled += new System.EventHandler(this.PointsToggle_Toggled);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.ProcStatus});
            this.toolStrip1.Location = new System.Drawing.Point(0, 355);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(394, 25);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
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
            // ThirdPToggle
            // 
            this.ThirdPToggle.Location = new System.Drawing.Point(204, 45);
            this.ThirdPToggle.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ThirdPToggle.Name = "ThirdPToggle";
            // 
            // 
            // 
            this.ThirdPToggle.Properties.OffText = "第三人称 Off";
            this.ThirdPToggle.Properties.OnText = "第三人称 On";
            this.ThirdPToggle.Size = new System.Drawing.Size(172, 25);
            this.ThirdPToggle.TabIndex = 6;
            this.ThirdPToggle.Toggled += new System.EventHandler(this.ThirdPToggle_Toggled);
            // 
            // trackBarControl1
            // 
            this.trackBarControl1.EditValue = 65;
            this.trackBarControl1.Location = new System.Drawing.Point(12, 191);
            this.trackBarControl1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.trackBarControl1.Name = "trackBarControl1";
            // 
            // 
            // 
            this.trackBarControl1.Properties.LabelAppearance.Options.UseTextOptions = true;
            this.trackBarControl1.Properties.LabelAppearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            trackBarLabel2.Label = "65";
            trackBarLabel2.Value = 65;
            this.trackBarControl1.Properties.Labels.AddRange(new DevExpress.XtraEditors.Repository.TrackBarLabel[] {
            trackBarLabel2});
            this.trackBarControl1.Properties.LargeChange = 10;
            this.trackBarControl1.Properties.Maximum = 120;
            this.trackBarControl1.Properties.Minimum = 65;
            this.trackBarControl1.Properties.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBarControl1.Size = new System.Drawing.Size(172, 45);
            this.trackBarControl1.TabIndex = 8;
            this.trackBarControl1.Value = 65;
            this.trackBarControl1.EditValueChanged += new System.EventHandler(this.trackBarControl1_EditValueChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(61, 177);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(53, 14);
            this.labelControl1.TabIndex = 9;
            this.labelControl1.Text = "FOV 调整";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(268, 177);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(52, 14);
            this.labelControl2.TabIndex = 11;
            this.labelControl2.Text = "时间速度";
            // 
            // trackBarControl2
            // 
            this.trackBarControl2.EditValue = 1;
            this.trackBarControl2.Location = new System.Drawing.Point(218, 191);
            this.trackBarControl2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.trackBarControl2.Name = "trackBarControl2";
            // 
            // 
            // 
            this.trackBarControl2.Properties.LabelAppearance.Options.UseTextOptions = true;
            this.trackBarControl2.Properties.LabelAppearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.trackBarControl2.Properties.Maximum = 6;
            this.trackBarControl2.Properties.Minimum = 1;
            this.trackBarControl2.Properties.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBarControl2.Size = new System.Drawing.Size(172, 45);
            this.trackBarControl2.TabIndex = 10;
            this.trackBarControl2.Value = 1;
            this.trackBarControl2.EditValueChanged += new System.EventHandler(this.trackBarControl2_EditValueChanged);
            // 
            // inGametxt
            // 
            this.inGametxt.Location = new System.Drawing.Point(12, 246);
            this.inGametxt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.inGametxt.Name = "inGametxt";
            this.inGametxt.Size = new System.Drawing.Size(164, 20);
            this.inGametxt.TabIndex = 12;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(12, 275);
            this.simpleButton1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(164, 25);
            this.simpleButton1.TabIndex = 13;
            this.simpleButton1.Text = "更改名称";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // SpeedToggle
            // 
            this.SpeedToggle.Location = new System.Drawing.Point(204, 78);
            this.SpeedToggle.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SpeedToggle.Name = "SpeedToggle";
            // 
            // 
            // 
            this.SpeedToggle.Properties.OffText = "超级加速 Off";
            this.SpeedToggle.Properties.OnText = "超级加速 On";
            this.SpeedToggle.Size = new System.Drawing.Size(164, 25);
            this.SpeedToggle.TabIndex = 14;
            this.SpeedToggle.Toggled += new System.EventHandler(this.SpeedToggle_Toggled);
            // 
            // JumpToggle
            // 
            this.JumpToggle.Location = new System.Drawing.Point(14, 110);
            this.JumpToggle.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.JumpToggle.Name = "JumpToggle";
            // 
            // 
            // 
            this.JumpToggle.Properties.OffText = "超级跳跃 Off";
            this.JumpToggle.Properties.OnText = "超级跳跃 On";
            this.JumpToggle.Size = new System.Drawing.Size(164, 25);
            this.JumpToggle.TabIndex = 15;
            this.JumpToggle.Toggled += new System.EventHandler(this.JumpToggle_Toggled);
            // 
            // MeleeToggle
            // 
            this.MeleeToggle.Location = new System.Drawing.Point(204, 110);
            this.MeleeToggle.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MeleeToggle.Name = "MeleeToggle";
            // 
            // 
            // 
            this.MeleeToggle.Properties.OffText = "近战切换 Off";
            this.MeleeToggle.Properties.OnText = "近战切换 On";
            this.MeleeToggle.Size = new System.Drawing.Size(194, 25);
            this.MeleeToggle.TabIndex = 16;
            this.MeleeToggle.Toggled += new System.EventHandler(this.MeleeToggle_Toggled);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(218, 275);
            this.simpleButton2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(164, 25);
            this.simpleButton2.TabIndex = 18;
            this.simpleButton2.Text = "恶搞名称";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // SpoofName
            // 
            this.SpoofName.Location = new System.Drawing.Point(218, 246);
            this.SpoofName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SpoofName.Name = "SpoofName";
            this.SpoofName.Size = new System.Drawing.Size(164, 20);
            this.SpoofName.TabIndex = 17;
            // 
            // simpleButton3
            // 
            this.simpleButton3.Location = new System.Drawing.Point(119, 344);
            this.simpleButton3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(164, 25);
            this.simpleButton3.TabIndex = 20;
            this.simpleButton3.Text = "确认";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // RoundEdit
            // 
            this.RoundEdit.Location = new System.Drawing.Point(119, 316);
            this.RoundEdit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.RoundEdit.Name = "RoundEdit";
            // 
            // 
            // 
            this.RoundEdit.Properties.MaxLength = 99999;
            this.RoundEdit.Size = new System.Drawing.Size(164, 20);
            this.RoundEdit.TabIndex = 19;
            // 
            // NoClipToggle
            // 
            this.NoClipToggle.Location = new System.Drawing.Point(14, 144);
            this.NoClipToggle.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.NoClipToggle.Name = "NoClipToggle";
            // 
            // 
            // 
            this.NoClipToggle.Properties.OffText = "无碰撞 Off";
            this.NoClipToggle.Properties.OnText = "无碰撞 On";
            this.NoClipToggle.Size = new System.Drawing.Size(164, 25);
            this.NoClipToggle.TabIndex = 24;
            this.NoClipToggle.Toggled += new System.EventHandler(this.toggleSwitch1_Toggled);
            // 
            // toggleSwitch2
            // 
            this.toggleSwitch2.Location = new System.Drawing.Point(204, 144);
            this.toggleSwitch2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.toggleSwitch2.Name = "toggleSwitch2";
            // 
            // 
            // 
            this.toggleSwitch2.Properties.OffText = "快速射击 Off";
            this.toggleSwitch2.Properties.OnText = "快速射击 On";
            this.toggleSwitch2.Size = new System.Drawing.Size(164, 25);
            this.toggleSwitch2.TabIndex = 25;
            // 
            // BlackOps_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 380);
            this.Controls.Add(this.toggleSwitch2);
            this.Controls.Add(this.NoClipToggle);
            this.Controls.Add(this.simpleButton3);
            this.Controls.Add(this.RoundEdit);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.SpoofName);
            this.Controls.Add(this.MeleeToggle);
            this.Controls.Add(this.JumpToggle);
            this.Controls.Add(this.SpeedToggle);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.inGametxt);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.trackBarControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.trackBarControl1);
            this.Controls.Add(this.ThirdPToggle);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.PointsToggle);
            this.Controls.Add(this.uNade);
            this.Controls.Add(this.BO2uAmmo);
            this.Controls.Add(this.bo2GodToggle);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximumSize = new System.Drawing.Size(410, 428);
            this.MinimumSize = new System.Drawing.Size(410, 428);
            this.Name = "BlackOps_2";
            this.Text = "BO2 Plutonium";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BO2_Closed);
            this.Load += new System.EventHandler(this.BlackOps_2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bo2GodToggle.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BO2uAmmo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uNade.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PointsToggle.Properties)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ThirdPToggle.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarControl1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarControl2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inGametxt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpeedToggle.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.JumpToggle.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MeleeToggle.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpoofName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RoundEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NoClipToggle.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toggleSwitch2.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

	}
}
