using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using Memory;

namespace Obsidian_ToolBox_Update;

public class BlackOps : XtraForm
{
	[StructLayout(LayoutKind.Sequential, Size = 1)]
	public struct Weapons
	{
		public static string PrimaryPointer = "0x1C08D34";

		public static string SecondaryPointer = "0x1808D64";

		public static bool RapidFire;

		public static string RapidFirePointer = "0x3669EC";

		public static string PrimaryAmmoPointer = "01808F00";

		public static string PrimaryAmmoSparePointer = "01C08E88,999";

		public static string SecondaryAmmoPointer = "0x1808F10";

		public static string SecondaryAmmoSparePointer = "0x1808E98";
	}

	private Mem bo1 = new Mem();

	private string FOVPtnr = "base+02BF6888,18";

	private string ThirdPerson = "base+0221D60C,18";

	private string LRK = "base+007A62DC,18";

	private string SpeedPntr = "base+01801810,18";

	private IContainer components = null;

	private ToggleSwitch God;

	private ToggleSwitch NoClip;

	private ToggleSwitch Points;

	private ToggleSwitch uAmmo;

	private ToolStrip toolStrip1;

	private ToolStripLabel toolStripLabel1;

	private ToolStripLabel ProcStatus;

	private ToggleSwitch KnifeRange;

	private ToggleSwitch NRecoil;

	private ToggleSwitch fullbright;

	private ToggleSwitch speedtoggle;

	private LabelControl labelControl1;

	private TrackBarControl trackBarControl1;

	private ToggleSwitch thridperson;

	private ToggleSwitch fogtoggle;

	private TextEdit fpsunlocker;

	private CheckButton checkButton1;

	private TextEdit XtxtBox;

	private TextEdit YtxtBox;

	private TextEdit ZtxtBox;

	private CheckButton Teleportbutn;

	private LabelControl labelControl2;

	private TrackBarControl trackBarControl2;

	private CheckButton checkButton4;

	private CheckButton checkButton5;

	private CheckButton checkButton6;

	private LabelControl labelControl3;

	private LabelControl labelControl4;

	private LabelControl labelControl5;

	private ComboBoxEdit weapongive;

	private LabelControl labelControl6;

	public BlackOps()
	{
		InitializeComponent();
	}

	private void BlackOps_Load(object sender, EventArgs e)
	{
		int PID = bo1.GetProcIdFromName("BlackOps");
		if (PID > 0)
		{
			bo1.OpenProcess(PID);
			ProcStatus.ForeColor = Color.Green;
			ProcStatus.Text = "Found Black Ops";
		}
	}

	private void BO1_Closed(object sender, FormClosedEventArgs e)
	{
		Form1 form1 = new Form1();
		form1.Show();
		Hide();
	}

	private void toggleSwitch1_Toggled(object sender, EventArgs e)
	{
		if (God.IsOn)
		{
			bo1.FreezeValue("01A7987C ", "int", "999");
		}
		else
		{
			bo1.UnfreezeValue("01A7987C ");
		}
	}

	private void NoClip_Toggled(object sender, EventArgs e)
	{
		if (NoClip.IsOn)
		{
			bo1.WriteMemory("01C0A74C", "int", "1");
		}
		else
		{
			bo1.WriteMemory("01C0A74C", "int", "0");
		}
	}

	private void toggleSwitch3_Toggled(object sender, EventArgs e)
	{
		if (Points.IsOn)
		{
			bo1.WriteMemory("1C0A6C8", "int", "999999");
		}
	}

	private void fullbright_Toggled(object sender, EventArgs e)
	{
		if (fullbright.IsOn)
		{
			bo1.WriteMemory("045FBDAC ", "int", "4");
		}
		else
		{
			bo1.WriteMemory("045FBDAC ", "int", "-16120566");
		}
	}

	private void NRecoil_Toggled(object sender, EventArgs e)
	{
		if (NRecoil.IsOn)
		{
			bo1.FreezeValue("006562F0", "byte", "117");
		}
		else
		{
			bo1.UnfreezeValue("006562F0");
		}
	}

	private void checkButton3_CheckedChanged(object sender, EventArgs e)
	{
	}

	private void trackBarControl1_EditValueChanged(object sender, EventArgs e)
	{
		if (trackBarControl1.Value == 65)
		{
			bo1.WriteMemory(FOVPtnr, "float", "65");
		}
		if (trackBarControl1.Value == 80)
		{
			bo1.WriteMemory(FOVPtnr, "float", "80");
		}
		if (trackBarControl1.Value == 90)
		{
			bo1.WriteMemory(FOVPtnr, "float", "90");
		}
		if (trackBarControl1.Value == 100)
		{
			bo1.WriteMemory(FOVPtnr, "float", "100");
		}
		if (trackBarControl1.Value == 110)
		{
			bo1.WriteMemory(FOVPtnr, "float", "110");
		}
		if (trackBarControl1.Value == 120)
		{
			bo1.WriteMemory(FOVPtnr, "float", "120");
		}
	}

	private void trackBarControl2_EditValueChanged(object sender, EventArgs e)
	{
		if (trackBarControl2.Value == 65)
		{
			bo1.WriteMemory("0265EB38", "float", "0");
		}
		if (trackBarControl2.Value == 80)
		{
			bo1.WriteMemory("0265EB38", "float", "300");
		}
		if (trackBarControl2.Value == 90)
		{
			bo1.WriteMemory("0265EB38", "float", "400");
		}
		if (trackBarControl2.Value == 100)
		{
			bo1.WriteMemory("0265EB38", "float", "500");
		}
		if (trackBarControl2.Value == 110)
		{
			bo1.WriteMemory("0265EB38", "float", "600");
		}
		if (trackBarControl2.Value == 120)
		{
			bo1.WriteMemory("0265EB38", "float", "700");
		}
		if (trackBarControl2.Value == 120)
		{
			bo1.WriteMemory("0265EB38", "float", "800");
		}
	}

	private void checkButton1_CheckedChanged(object sender, EventArgs e)
	{
		bo1.WriteMemory("0263A558", "int", fpsunlocker.Text);
	}

	private void toggleSwitch9_Toggled(object sender, EventArgs e)
	{
		if (thridperson.IsOn)
		{
			bo1.WriteMemory(ThirdPerson, "byte", "1");
		}
		else
		{
			bo1.WriteMemory(ThirdPerson, "byte", "0");
		}
	}

	private void KnifeRange_Toggled(object sender, EventArgs e)
	{
		if (KnifeRange.IsOn)
		{
			bo1.WriteMemory(LRK, "float", "500");
		}
		else
		{
			bo1.WriteMemory(LRK, "float", "300");
		}
	}

	private void toggleSwitch10_Toggled(object sender, EventArgs e)
	{
		if (fogtoggle.IsOn)
		{
			bo1.WriteMemory("02666B68", "byte", "1");
		}
		else
		{
			bo1.WriteMemory("02666B68", "byte", "0");
		}
	}

	private void speedtoggle_Toggled(object sender, EventArgs e)
	{
		if (speedtoggle.IsOn)
		{
			bo1.WriteMemory(SpeedPntr, "int", "500");
		}
		else
		{
			bo1.WriteMemory(SpeedPntr, "int", "190");
		}
	}

	private void weapongive_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (weapongive.SelectedIndex != -1)
		{
			bo1.WriteMemory(Weapons.PrimaryPointer, "int", weapongive.SelectedIndex.ToString());
		}
	}

	private void uAmmo_Toggled(object sender, EventArgs e)
	{
		if (uAmmo.IsOn)
		{
			bo1.FreezeValue("01C08F00", "int", "9999");
			bo1.FreezeValue("01C08E88", "int", "9999");
			bo1.FreezeValue("01C08F10", "int", "9999");
			bo1.FreezeValue("01C08E98", "int", "9999");
			bo1.FreezeValue("01C08EA0", "int", "9999");
			bo1.FreezeValue("01C08F18", "int", "9999");
		}
		else
		{
			bo1.UnfreezeValue("01C08F00");
			bo1.UnfreezeValue("01C08E88");
			bo1.UnfreezeValue("01C08F10");
			bo1.UnfreezeValue("01C08E98");
			bo1.UnfreezeValue("01C08EA0");
			bo1.UnfreezeValue("01C08F18");
		}
	}

	private void checkButton2_CheckedChanged(object sender, EventArgs e)
	{
		bo1.WriteMemory("01C08E88", "float", XtxtBox.Text);
		bo1.WriteMemory("01C08F10", "float", YtxtBox.Text);
		bo1.WriteMemory("01C08E98", "float", ZtxtBox.Text);
	}

	private void checkButton2_CheckedChanged_1(object sender, EventArgs e)
	{
		bo1.WriteMemory("01C08E88", "float", XtxtBox.Text);
		bo1.WriteMemory("01C08F10", "float", YtxtBox.Text);
		bo1.WriteMemory("01C08E98", "float", ZtxtBox.Text);
	}

	private void checkButton4_CheckedChanged(object sender, EventArgs e)
	{
		bo1.WriteMemory("01C08B6C", "float", "92.125");
		bo1.WriteMemory("01C08B6C ", "float", "92.125");
		bo1.WriteMemory("01C08B64", "float", "-7.288922787");
	}

	private void checkButton5_CheckedChanged(object sender, EventArgs e)
	{
		bo1.WriteMemory("01C08B6C ", "float", "168.625");
		bo1.WriteMemory("01C08B6C ", "float", "168.625");
		bo1.WriteMemory("01C08B64", "float", "-905.9795532");
	}

	private void checkButton6_CheckedChanged(object sender, EventArgs e)
	{
		bo1.WriteMemory("01C08B6C ", "float", "87.16007233");
		bo1.WriteMemory("01C08B6C ", "float", "87.16007233");
		bo1.WriteMemory("01C08B64", "float", "-1681.131958");
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
            DevExpress.XtraEditors.Repository.TrackBarLabel trackBarLabel3 = new DevExpress.XtraEditors.Repository.TrackBarLabel();
            DevExpress.XtraEditors.Repository.TrackBarLabel trackBarLabel4 = new DevExpress.XtraEditors.Repository.TrackBarLabel();
            this.God = new DevExpress.XtraEditors.ToggleSwitch();
            this.NoClip = new DevExpress.XtraEditors.ToggleSwitch();
            this.Points = new DevExpress.XtraEditors.ToggleSwitch();
            this.uAmmo = new DevExpress.XtraEditors.ToggleSwitch();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.ProcStatus = new System.Windows.Forms.ToolStripLabel();
            this.KnifeRange = new DevExpress.XtraEditors.ToggleSwitch();
            this.NRecoil = new DevExpress.XtraEditors.ToggleSwitch();
            this.fullbright = new DevExpress.XtraEditors.ToggleSwitch();
            this.speedtoggle = new DevExpress.XtraEditors.ToggleSwitch();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.trackBarControl1 = new DevExpress.XtraEditors.TrackBarControl();
            this.thridperson = new DevExpress.XtraEditors.ToggleSwitch();
            this.fogtoggle = new DevExpress.XtraEditors.ToggleSwitch();
            this.fpsunlocker = new DevExpress.XtraEditors.TextEdit();
            this.checkButton1 = new DevExpress.XtraEditors.CheckButton();
            this.XtxtBox = new DevExpress.XtraEditors.TextEdit();
            this.YtxtBox = new DevExpress.XtraEditors.TextEdit();
            this.ZtxtBox = new DevExpress.XtraEditors.TextEdit();
            this.Teleportbutn = new DevExpress.XtraEditors.CheckButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.trackBarControl2 = new DevExpress.XtraEditors.TrackBarControl();
            this.checkButton4 = new DevExpress.XtraEditors.CheckButton();
            this.checkButton5 = new DevExpress.XtraEditors.CheckButton();
            this.checkButton6 = new DevExpress.XtraEditors.CheckButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.weapongive = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.God.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NoClip.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Points.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uAmmo.Properties)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KnifeRange.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NRecoil.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fullbright.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.speedtoggle.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarControl1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thridperson.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fogtoggle.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fpsunlocker.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.XtxtBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.YtxtBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ZtxtBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarControl2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weapongive.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // God
            // 
            this.God.Location = new System.Drawing.Point(14, 13);
            this.God.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.God.Name = "God";
            // 
            // 
            // 
            this.God.Properties.OffText = "无敌 Off";
            this.God.Properties.OnText = "无敌 On";
            this.God.Size = new System.Drawing.Size(163, 25);
            this.God.TabIndex = 0;
            this.God.Toggled += new System.EventHandler(this.toggleSwitch1_Toggled);
            // 
            // NoClip
            // 
            this.NoClip.Location = new System.Drawing.Point(14, 45);
            this.NoClip.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.NoClip.Name = "NoClip";
            // 
            // 
            // 
            this.NoClip.Properties.OffText = "无碰撞 Off";
            this.NoClip.Properties.OnText = "无碰撞 On";
            this.NoClip.Size = new System.Drawing.Size(163, 25);
            this.NoClip.TabIndex = 1;
            this.NoClip.Toggled += new System.EventHandler(this.NoClip_Toggled);
            // 
            // Points
            // 
            this.Points.Location = new System.Drawing.Point(14, 78);
            this.Points.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Points.Name = "Points";
            // 
            // 
            // 
            this.Points.Properties.OffText = "分数 Off";
            this.Points.Properties.OnText = "分数 On";
            this.Points.Size = new System.Drawing.Size(163, 25);
            this.Points.TabIndex = 2;
            this.Points.Toggled += new System.EventHandler(this.toggleSwitch3_Toggled);
            // 
            // uAmmo
            // 
            this.uAmmo.Location = new System.Drawing.Point(14, 110);
            this.uAmmo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.uAmmo.Name = "uAmmo";
            // 
            // 
            // 
            this.uAmmo.Properties.OffText = "无限子弹 Off";
            this.uAmmo.Properties.OnText = "无限子弹 On";
            this.uAmmo.Size = new System.Drawing.Size(163, 25);
            this.uAmmo.TabIndex = 3;
            this.uAmmo.Toggled += new System.EventHandler(this.uAmmo_Toggled);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.ProcStatus});
            this.toolStrip1.Location = new System.Drawing.Point(0, 397);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(394, 25);
            this.toolStrip1.TabIndex = 4;
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
            // KnifeRange
            // 
            this.KnifeRange.Location = new System.Drawing.Point(184, 13);
            this.KnifeRange.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.KnifeRange.Name = "KnifeRange";
            // 
            // 
            // 
            this.KnifeRange.Properties.OffText = "近战距离 Off";
            this.KnifeRange.Properties.OnText = "近战距离 On";
            this.KnifeRange.Size = new System.Drawing.Size(210, 25);
            this.KnifeRange.TabIndex = 5;
            this.KnifeRange.Toggled += new System.EventHandler(this.KnifeRange_Toggled);
            // 
            // NRecoil
            // 
            this.NRecoil.Location = new System.Drawing.Point(184, 45);
            this.NRecoil.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.NRecoil.Name = "NRecoil";
            // 
            // 
            // 
            this.NRecoil.Properties.OffText = "无后座 Off";
            this.NRecoil.Properties.OnText = "无后座 On";
            this.NRecoil.Size = new System.Drawing.Size(163, 25);
            this.NRecoil.TabIndex = 6;
            this.NRecoil.Toggled += new System.EventHandler(this.NRecoil_Toggled);
            // 
            // fullbright
            // 
            this.fullbright.Location = new System.Drawing.Point(184, 78);
            this.fullbright.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.fullbright.Name = "fullbright";
            // 
            // 
            // 
            this.fullbright.Properties.OffText = "明亮 Off";
            this.fullbright.Properties.OnText = "明亮t On";
            this.fullbright.Size = new System.Drawing.Size(163, 25);
            this.fullbright.TabIndex = 7;
            this.fullbright.Toggled += new System.EventHandler(this.fullbright_Toggled);
            // 
            // speedtoggle
            // 
            this.speedtoggle.Location = new System.Drawing.Point(184, 110);
            this.speedtoggle.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.speedtoggle.Name = "speedtoggle";
            // 
            // 
            // 
            this.speedtoggle.Properties.OffText = "超级速度 Off";
            this.speedtoggle.Properties.OnText = "超级速度 On";
            this.speedtoggle.Size = new System.Drawing.Size(182, 25);
            this.speedtoggle.TabIndex = 8;
            this.speedtoggle.Toggled += new System.EventHandler(this.speedtoggle_Toggled);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(261, 181);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(65, 14);
            this.labelControl1.TabIndex = 11;
            this.labelControl1.Text = "   FOV 调整";
            // 
            // trackBarControl1
            // 
            this.trackBarControl1.EditValue = 65;
            this.trackBarControl1.Location = new System.Drawing.Point(212, 195);
            this.trackBarControl1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.trackBarControl1.Name = "trackBarControl1";
            // 
            // 
            // 
            this.trackBarControl1.Properties.LabelAppearance.Options.UseTextOptions = true;
            this.trackBarControl1.Properties.LabelAppearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            trackBarLabel3.Label = "65";
            trackBarLabel3.Value = 65;
            this.trackBarControl1.Properties.Labels.AddRange(new DevExpress.XtraEditors.Repository.TrackBarLabel[] {
            trackBarLabel3});
            this.trackBarControl1.Properties.LargeChange = 10;
            this.trackBarControl1.Properties.Maximum = 120;
            this.trackBarControl1.Properties.Minimum = 65;
            this.trackBarControl1.Properties.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBarControl1.Size = new System.Drawing.Size(172, 45);
            this.trackBarControl1.TabIndex = 10;
            this.trackBarControl1.Value = 65;
            this.trackBarControl1.EditValueChanged += new System.EventHandler(this.trackBarControl1_EditValueChanged);
            // 
            // thridperson
            // 
            this.thridperson.Location = new System.Drawing.Point(14, 142);
            this.thridperson.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.thridperson.Name = "thridperson";
            // 
            // 
            // 
            this.thridperson.Properties.OffText = "第三人称 Off";
            this.thridperson.Properties.OnText = "第三人称 On";
            this.thridperson.Size = new System.Drawing.Size(170, 25);
            this.thridperson.TabIndex = 12;
            this.thridperson.Toggled += new System.EventHandler(this.toggleSwitch9_Toggled);
            // 
            // fogtoggle
            // 
            this.fogtoggle.Location = new System.Drawing.Point(184, 142);
            this.fogtoggle.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.fogtoggle.Name = "fogtoggle";
            // 
            // 
            // 
            this.fogtoggle.Properties.OffText = "迷雾 Off";
            this.fogtoggle.Properties.OnText = "迷雾 On";
            this.fogtoggle.Size = new System.Drawing.Size(138, 25);
            this.fogtoggle.TabIndex = 13;
            this.fogtoggle.Toggled += new System.EventHandler(this.toggleSwitch10_Toggled);
            // 
            // fpsunlocker
            // 
            this.fpsunlocker.Location = new System.Drawing.Point(14, 174);
            this.fpsunlocker.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.fpsunlocker.Name = "fpsunlocker";
            this.fpsunlocker.Size = new System.Drawing.Size(182, 20);
            this.fpsunlocker.TabIndex = 14;
            // 
            // checkButton1
            // 
            this.checkButton1.Location = new System.Drawing.Point(14, 204);
            this.checkButton1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.checkButton1.Name = "checkButton1";
            this.checkButton1.Size = new System.Drawing.Size(182, 25);
            this.checkButton1.TabIndex = 15;
            this.checkButton1.Text = "解锁FPS";
            this.checkButton1.CheckedChanged += new System.EventHandler(this.checkButton1_CheckedChanged);
            // 
            // XtxtBox
            // 
            this.XtxtBox.Location = new System.Drawing.Point(14, 243);
            this.XtxtBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.XtxtBox.Name = "XtxtBox";
            this.XtxtBox.Size = new System.Drawing.Size(163, 20);
            this.XtxtBox.TabIndex = 16;
            // 
            // YtxtBox
            // 
            this.YtxtBox.Location = new System.Drawing.Point(14, 271);
            this.YtxtBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.YtxtBox.Name = "YtxtBox";
            this.YtxtBox.Size = new System.Drawing.Size(163, 20);
            this.YtxtBox.TabIndex = 17;
            // 
            // ZtxtBox
            // 
            this.ZtxtBox.Location = new System.Drawing.Point(14, 299);
            this.ZtxtBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ZtxtBox.Name = "ZtxtBox";
            this.ZtxtBox.Size = new System.Drawing.Size(163, 20);
            this.ZtxtBox.TabIndex = 18;
            // 
            // Teleportbutn
            // 
            this.Teleportbutn.Location = new System.Drawing.Point(15, 328);
            this.Teleportbutn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Teleportbutn.Name = "Teleportbutn";
            this.Teleportbutn.Size = new System.Drawing.Size(163, 25);
            this.Teleportbutn.TabIndex = 19;
            this.Teleportbutn.Text = "传送";
            this.Teleportbutn.CheckedChanged += new System.EventHandler(this.checkButton2_CheckedChanged_1);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(253, 250);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(26, 14);
            this.labelControl2.TabIndex = 22;
            this.labelControl2.Text = "重力";
            // 
            // trackBarControl2
            // 
            this.trackBarControl2.EditValue = 10;
            this.trackBarControl2.Location = new System.Drawing.Point(212, 264);
            this.trackBarControl2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.trackBarControl2.Name = "trackBarControl2";
            // 
            // 
            // 
            this.trackBarControl2.Properties.LabelAppearance.Options.UseTextOptions = true;
            this.trackBarControl2.Properties.LabelAppearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            trackBarLabel4.Label = "65";
            trackBarLabel4.Value = 65;
            this.trackBarControl2.Properties.Labels.AddRange(new DevExpress.XtraEditors.Repository.TrackBarLabel[] {
            trackBarLabel4});
            this.trackBarControl2.Properties.LargeChange = 10;
            this.trackBarControl2.Properties.Maximum = 800;
            this.trackBarControl2.Properties.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBarControl2.Size = new System.Drawing.Size(172, 45);
            this.trackBarControl2.TabIndex = 21;
            this.trackBarControl2.Value = 10;
            this.trackBarControl2.EditValueChanged += new System.EventHandler(this.trackBarControl2_EditValueChanged);
            // 
            // checkButton4
            // 
            this.checkButton4.Location = new System.Drawing.Point(214, 328);
            this.checkButton4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.checkButton4.Name = "checkButton4";
            this.checkButton4.Size = new System.Drawing.Size(172, 25);
            this.checkButton4.TabIndex = 23;
            this.checkButton4.Text = "传送出生点";
            this.checkButton4.CheckedChanged += new System.EventHandler(this.checkButton4_CheckedChanged);
            // 
            // checkButton5
            // 
            this.checkButton5.Location = new System.Drawing.Point(214, 360);
            this.checkButton5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.checkButton5.Name = "checkButton5";
            this.checkButton5.Size = new System.Drawing.Size(172, 25);
            this.checkButton5.TabIndex = 24;
            this.checkButton5.Text = "传送地图顶部";
            this.checkButton5.CheckedChanged += new System.EventHandler(this.checkButton5_CheckedChanged);
            // 
            // checkButton6
            // 
            this.checkButton6.Location = new System.Drawing.Point(214, 391);
            this.checkButton6.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.checkButton6.Name = "checkButton6";
            this.checkButton6.Size = new System.Drawing.Size(172, 25);
            this.checkButton6.TabIndex = 25;
            this.checkButton6.Text = "传送地图外边";
            this.checkButton6.CheckedChanged += new System.EventHandler(this.checkButton6_CheckedChanged);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(184, 244);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(10, 16);
            this.labelControl3.TabIndex = 26;
            this.labelControl3.Text = "X";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(184, 272);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(9, 16);
            this.labelControl4.TabIndex = 27;
            this.labelControl4.Text = "Y";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(184, 300);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(7, 16);
            this.labelControl5.TabIndex = 28;
            this.labelControl5.Text = "Z";
            // 
            // weapongive
            // 
            this.weapongive.Location = new System.Drawing.Point(15, 360);
            this.weapongive.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.weapongive.Name = "weapongive";
            // 
            // 
            // 
            this.weapongive.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.weapongive.Properties.Items.AddRange(new object[] {
            "WEAPON_DEFAULTWEAPON",
            "Invisible Machine Gun",
            "AK47",
            "M1911",
            "Mustand & Sally",
            "Mustand & Sally //Broken",
            "Python",
            "Cobra",
            "CZ-75",
            "Calamity",
            "M14",
            "Mnesia",
            "M16",
            "Skullcrusher",
            "G11",
            "G115 Generator",
            "Famas",
            "G16-GL35",
            "AK74U",
            "AK74FU2",
            "MP5K",
            "MP115 Kollider",
            "MP40",
            "The Afterburner",
            "MPL",
            "MPL-LF",
            "PM63",
            "Tokyo & Rose",
            "Tokyo & Rose //Broken",
            "Spectre",
            "Phantom",
            "CZ-75 Dual Wield",
            "CZ-75 Dual Wield //Broken",
            "Calamity & Jane",
            "Calamity & Jane //Broken",
            "Stakeout",
            "Raid",
            "Olympia",
            "Hades",
            "Spas-12",
            "Spaz-24",
            "HS10",
            "Typhoid & Mary",
            "Typhoid & Mary //Broken",
            "AUG",
            "AUG-50M3",
            "Galil",
            "Lamentation",
            "Commando",
            "Predator",
            "FN FAL",
            "EPC WN",
            "Dragunov",
            "D115 Disassembler",
            "L96A1",
            "L115 Isolator",
            "RPK",
            "R115 Resonator",
            "HK21",
            "H115 Oscillator",
            "M72 Law",
            "M72 Anarchy",
            "China Lake",
            "China Beach",
            "Ray Gun",
            "Porter\'s X2 Ray Gun",
            "Thundergun",
            "ZeusCannon",
            "Crossbow Explosive Tip",
            "Awful Lawton",
            "Ballistic Knife",
            "The Krauss Refibrillator",
            "Ballistic Knife (Butcher Knife)",
            "The Krauss Refibrillator (Butcher Knife)"});
            this.weapongive.Size = new System.Drawing.Size(162, 20);
            this.weapongive.TabIndex = 29;
            this.weapongive.SelectedIndexChanged += new System.EventHandler(this.weapongive_SelectedIndexChanged);
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(253, 307);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(0, 14);
            this.labelControl6.TabIndex = 30;
            // 
            // BlackOps
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 422);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.weapongive);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.checkButton6);
            this.Controls.Add(this.checkButton5);
            this.Controls.Add(this.checkButton4);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.trackBarControl2);
            this.Controls.Add(this.Teleportbutn);
            this.Controls.Add(this.ZtxtBox);
            this.Controls.Add(this.YtxtBox);
            this.Controls.Add(this.XtxtBox);
            this.Controls.Add(this.checkButton1);
            this.Controls.Add(this.fpsunlocker);
            this.Controls.Add(this.fogtoggle);
            this.Controls.Add(this.thridperson);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.trackBarControl1);
            this.Controls.Add(this.speedtoggle);
            this.Controls.Add(this.fullbright);
            this.Controls.Add(this.NRecoil);
            this.Controls.Add(this.KnifeRange);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.uAmmo);
            this.Controls.Add(this.Points);
            this.Controls.Add(this.NoClip);
            this.Controls.Add(this.God);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximumSize = new System.Drawing.Size(410, 470);
            this.MinimumSize = new System.Drawing.Size(410, 470);
            this.Name = "BlackOps";
            this.Text = "BO1 僵尸";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BO1_Closed);
            this.Load += new System.EventHandler(this.BlackOps_Load);
            ((System.ComponentModel.ISupportInitialize)(this.God.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NoClip.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Points.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uAmmo.Properties)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KnifeRange.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NRecoil.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fullbright.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.speedtoggle.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarControl1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thridperson.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fogtoggle.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fpsunlocker.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.XtxtBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.YtxtBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ZtxtBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarControl2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weapongive.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

	}
}
