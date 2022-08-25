using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Memory;

namespace Obsidian_ToolBox_Update;

public class MW2 : XtraForm
{
	private Mem mw2 = new Mem();

	private IContainer components = null;

	private ToolStrip toolStrip1;

	private ToolStripLabel toolStripLabel1;

	private ToolStripLabel ProcStatus;

	private CheckButton checkButton3;

	private NumericUpDown Prestige;

	private NumericUpDown XP;

	private CheckButton checkButton4;

	private NumericUpDown Score;

	private CheckButton checkButton5;

	private NumericUpDown Wins;

	private CheckButton checkButton6;

	private NumericUpDown Losses;

	private CheckButton checkButton7;

	private NumericUpDown Ties;

	private CheckButton checkButton8;

	private NumericUpDown Kills;

	private CheckButton checkButton9;

	private NumericUpDown Headshots;

	private CheckButton checkButton10;

	private NumericUpDown Assists;

	private CheckButton checkButton11;

	private NumericUpDown Streaks;

	private CheckButton checkButton12;

	private NumericUpDown Deaths;

	private CheckButton checkButton13;

	private NumericUpDown WinStreaks;

	private CheckButton checkButton14;

	private CheckButton checkButton15;

	private CheckButton checkButton16;

	private NumericUpDown TimePlay;

	private CheckButton checkButton1;

	public MW2()
	{
		InitializeComponent();
	}

	private void MW2_Closed(object sender, FormClosedEventArgs e)
	{
		Hide();
		Form1 form1 = new Form1();
		form1.Show();
	}

	private void MW2_Load(object sender, EventArgs e)
	{
		int PID = mw2.GetProcIdFromName("iw4mp");
		if (PID > 0)
		{
			mw2.OpenProcess(PID);
			ProcStatus.ForeColor = Color.Green;
			ProcStatus.Text = "Found MW2";
		}
	}

	private void checkButton2_CheckedChanged(object sender, EventArgs e)
	{
	}

	private void checkButton3_CheckedChanged(object sender, EventArgs e)
	{
		byte[] bytes = BitConverter.GetBytes(Convert.ToInt32(Prestige.Value));
		mw2.WriteBytes((UIntPtr)28882928uL, bytes);
	}

	private void ESP_Toggled(object sender, EventArgs e)
	{
	}

	private void checkButton16_CheckedChanged(object sender, EventArgs e)
	{
	}

	private void checkButton16_CheckedChanged_1(object sender, EventArgs e)
	{
		byte[] bytes = new byte[1369]
		{
			144, 144, 144, 144, 144, 144, 144, 144, 144, 144,
			144, 144, 144, 144, 144, 144, 144, 144, 144, 144,
			144, 144, 144, 144, 144, 144, 144, 144, 144, 144,
			144, 144, 144, 144, 144, 144, 144, 144, 144, 144,
			144, 144, 144, 144, 144, 144, 144, 144, 144, 144,
			144, 144, 144, 144, 144, 144, 144, 144, 144, 144,
			144, 144, 144, 144, 144, 144, 144, 144, 144, 144,
			144, 144, 144, 144, 144, 144, 144, 144, 144, 144,
			144, 144, 144, 144, 144, 144, 144, 144, 144, 144,
			144, 144, 144, 144, 144, 144, 144, 144, 144, 144,
			144, 144, 144, 144, 144, 144, 144, 144, 144, 144,
			144, 144, 144, 144, 144, 144, 144, 144, 144, 144,
			144, 144, 144, 144, 144, 144, 144, 144, 144, 144,
			144, 144, 144, 144, 144, 144, 144, 144, 144, 144,
			144, 144, 144, 144, 144, 144, 144, 144, 144, 144,
			144, 144, 144, 144, 144, 144, 144, 144, 144, 144,
			144, 144, 144, 144, 144, 144, 144, 144, 144, 144,
			144, 144, 144, 144, 144, 144, 144, 144, 144, 144,
			144, 144, 144, 144, 144, 144, 144, 144, 144, 144,
			144, 144, 144, 144, 144, 144, 144, 144, 144, 144,
			144, 144, 144, 144, 144, 144, 144, 144, 144, 144,
			144, 144, 144, 144, 144, 144, 144, 144, 144, 144,
			144, 144, 144, 144, 144, 144, 144, 144, 144, 144,
			144, 144, 144, 144, 144, 144, 144, 144, 144, 144,
			144, 144, 144, 144, 144, 144, 144, 144, 144, 144,
			144, 144, 144, 144, 144, 144, 144, 144, 144, 144,
			144, 144, 144, 144, 144, 144, 144, 144, 144, 144,
			144, 144, 144, 144, 144, 144, 144, 144, 144, 144,
			144, 144, 144, 144, 144, 144, 144, 144, 144, 144,
			144, 144, 144, 144, 144, 144, 144, 144, 144, 144,
			144, 144, 144, 144, 144, 144, 144, 144, 144, 144,
			144, 144, 144, 144, 144, 144, 144, 144, 144, 144,
			144, 144, 144, 144, 144, 144, 144, 144, 144, 144,
			144, 144, 144, 144, 144, 144, 144, 144, 144, 144,
			144, 144, 144, 144, 144, 144, 144, 144, 144, 144,
			144, 144, 144, 144, 144, 144, 144, 144, 144, 144,
			144, 144, 144, 144, 144, 144, 144, 144, 144, 144,
			144, 144, 144, 144, 144, 144, 144, 144, 144, 144,
			144, 144, 144, 144, 144, 144, 144, 144, 144, 144,
			144, 144, 144, 144, 144, 144, 144, 144, 144, 144,
			144, 144, 144, 144, 144, 144, 144, 144, 144, 144,
			144, 144, 144, 144, 144, 144, 144, 144, 144, 144,
			144, 144, 144, 144, 144, 144, 144, 144, 144, 144,
			144, 144, 144, 144, 144, 144, 144, 144, 144, 144,
			144, 144, 144, 144, 144, 144, 144, 144, 144, 144,
			144, 144, 144, 144, 144, 144, 144, 144, 144, 144,
			144, 144, 144, 144, 144, 144, 144, 144, 144, 144,
			144, 144, 144, 144, 144, 144, 144, 144, 144, 144,
			144, 144, 144, 144, 144, 144, 144, 144, 144, 144,
			144, 144, 144, 144, 144, 144, 144, 144, 144, 144,
			144, 144, 144, 144, 144, 144, 144, 144, 144, 144,
			144, 144, 144, 144, 144, 144, 144, 144, 144, 144,
			144, 144, 144, 144, 144, 144, 144, 144, 144, 144,
			144, 144, 144, 144, 144, 144, 144, 144, 144, 144,
			144, 144, 144, 144, 144, 144, 144, 144, 144, 144,
			144, 144, 144, 144, 144, 144, 144, 144, 144, 144,
			144, 144, 144, 144, 144, 144, 144, 144, 144, 144,
			144, 144, 144, 144, 144, 144, 144, 144, 144, 144,
			144, 144, 144, 144, 144, 144, 144, 144, 144, 144,
			144, 144, 144, 144, 144, 144, 144, 144, 144, 144,
			144, 144, 144, 144, 144, 144, 144, 144, 144, 144,
			144, 144, 144, 144, 144, 144, 144, 144, 144, 144,
			144, 144, 144, 144, 144, 144, 144, 144, 144, 144,
			144, 144, 144, 144, 144, 144, 144, 144, 144, 144,
			144, 144, 144, 144, 144, 144, 144, 144, 144, 144,
			144, 144, 144, 144, 144, 144, 144, 144, 144, 144,
			144, 144, 144, 144, 144, 144, 144, 144, 144, 144,
			144, 144, 144, 144, 144, 144, 144, 144, 144, 144,
			144, 144, 144, 144, 144, 144, 144, 144, 144, 144,
			144, 144, 144, 144, 144, 144, 144, 144, 144, 144,
			144, 144, 144, 144, 144, 144, 144, 144, 144, 144,
			144, 144, 144, 144, 144, 144, 144, 144, 144, 144,
			144, 144, 144, 144, 144, 144, 144, 144, 144, 144,
			144, 144, 144, 144, 144, 144, 144, 144, 144, 144,
			144, 144, 144, 144, 144, 144, 144, 144, 144, 144,
			144, 144, 144, 144, 144, 144, 144, 144, 144, 144,
			144, 144, 144, 144, 144, 144, 144, 144, 144, 144,
			144, 144, 144, 144, 144, 144, 144, 144, 144, 144,
			144, 144, 144, 144, 144, 144, 144, 144, 144, 144,
			144, 144, 144, 144, 144, 144, 144, 144, 144, 144,
			144, 144, 144, 144, 144, 144, 144, 144, 144, 144,
			144, 144, 144, 144, 144, 144, 144, 144, 144, 144,
			144, 144, 144, 144, 144, 144, 144, 144, 144, 144,
			144, 144, 144, 144, 144, 144, 144, 144, 144, 144,
			144, 144, 144, 144, 144, 144, 144, 144, 144, 144,
			144, 144, 144, 144, 144, 144, 144, 144, 144, 144,
			144, 144, 144, 144, 144, 144, 144, 144, 144, 144,
			144, 144, 144, 144, 144, 144, 144, 144, 144, 144,
			144, 144, 144, 144, 144, 144, 144, 144, 144, 144,
			144, 144, 144, 144, 144, 144, 144, 144, 144, 144,
			144, 144, 144, 144, 144, 144, 144, 144, 144, 144,
			144, 144, 144, 144, 144, 144, 144, 144, 144, 144,
			144, 144, 144, 144, 144, 144, 144, 144, 144, 144,
			144, 144, 144, 144, 144, 144, 144, 144, 144, 144,
			144, 144, 144, 144, 144, 144, 144, 144, 144, 144,
			144, 144, 144, 144, 144, 144, 144, 144, 144, 144,
			144, 144, 144, 144, 144, 144, 144, 144, 144, 144,
			144, 144, 144, 144, 144, 144, 144, 144, 144, 144,
			144, 144, 144, 144, 144, 144, 144, 144, 144, 144,
			144, 144, 144, 144, 144, 144, 144, 144, 144, 144,
			144, 144, 144, 144, 144, 144, 144, 144, 144, 144,
			144, 144, 144, 144, 144, 144, 144, 144, 144, 144,
			144, 144, 144, 144, 144, 144, 144, 144, 144, 144,
			144, 144, 144, 144, 144, 144, 144, 144, 144, 144,
			144, 144, 144, 144, 144, 144, 144, 144, 144, 144,
			144, 144, 144, 144, 144, 144, 144, 144, 144, 144,
			144, 144, 144, 144, 144, 144, 144, 144, 144, 144,
			144, 144, 144, 144, 144, 144, 144, 144, 144, 144,
			144, 144, 144, 144, 144, 144, 144, 144, 144, 144,
			144, 144, 144, 144, 144, 144, 144, 144, 144, 144,
			144, 144, 144, 144, 144, 144, 144, 144, 144, 144,
			144, 144, 144, 144, 144, 144, 144, 144, 144, 144,
			144, 144, 144, 144, 144, 144, 144, 144, 144, 144,
			144, 144, 144, 144, 144, 144, 144, 144, 144, 144,
			144, 144, 144, 144, 144, 144, 144, 144, 144, 144,
			144, 144, 144, 144, 144, 144, 144, 144, 144, 144,
			144, 144, 144, 144, 144, 144, 144, 144, 144, 144,
			144, 144, 144, 144, 144, 144, 144, 144, 144, 144,
			144, 144, 144, 144, 144, 144, 144, 144, 144, 144,
			144, 144, 144, 144, 144, 144, 144, 144, 144, 144,
			144, 144, 144, 144, 144, 144, 144, 144, 144, 144,
			144, 144, 144, 144, 144, 144, 144, 144, 144, 144,
			144, 144, 144, 144, 144, 144, 144, 144, 144, 144,
			144, 144, 144, 144, 144, 144, 144, 144, 144, 144,
			144, 144, 144, 144, 144, 144, 144, 144, 144, 144,
			144, 144, 144, 144, 144, 144, 144, 144, 144, 144,
			144, 144, 144, 144, 144, 144, 144, 144, 144, 144,
			144, 144, 144, 144, 144, 144, 144, 144, 144, 144,
			144, 144, 144, 144, 144, 144, 144, 144, 144, 144,
			144, 144, 144, 144, 144, 144, 144, 144, 144, 144,
			144, 144, 144, 144, 144, 144, 144, 144, 144, 144,
			144, 144, 144, 144, 144, 144, 144, 144, 144, 144,
			144, 144, 144, 144, 144, 144, 144, 144, 144, 144,
			144, 144, 144, 144, 144, 144, 144, 144, 144, 144,
			144, 144, 144, 144, 144, 144, 144, 144, 144, 144,
			144, 144, 144, 144, 144, 144, 144, 144, 144, 144,
			144, 144, 144, 144, 144, 144, 144, 144, 144
		};
		mw2.WriteBytes((UIntPtr)28884496uL, bytes);
	}

	private void checkButton4_CheckedChanged(object sender, EventArgs e)
	{
		byte[] bytes = BitConverter.GetBytes(Convert.ToInt32(XP.Value));
		mw2.WriteBytes((UIntPtr)28882920uL, bytes);
	}

	private void checkButton15_CheckedChanged(object sender, EventArgs e)
	{
		byte[] bytes = BitConverter.GetBytes(Convert.ToInt32(TimePlay.Value));
		mw2.WriteBytes((UIntPtr)28882976uL, bytes);
	}

	private void checkButton5_CheckedChanged(object sender, EventArgs e)
	{
		byte[] bytes = BitConverter.GetBytes(Convert.ToInt32(Score.Value));
		mw2.WriteBytes((UIntPtr)28882936uL, bytes);
	}

	private void checkButton6_CheckedChanged(object sender, EventArgs e)
	{
		byte[] bytes = BitConverter.GetBytes(Convert.ToInt32(Wins.Value));
		mw2.WriteBytes((UIntPtr)28882992uL, bytes);
	}

	private void checkButton7_CheckedChanged(object sender, EventArgs e)
	{
		byte[] bytes = BitConverter.GetBytes(Convert.ToInt32(Losses.Value));
		mw2.WriteBytes((UIntPtr)28882996uL, bytes);
	}

	private void checkButton8_CheckedChanged(object sender, EventArgs e)
	{
		byte[] bytes = BitConverter.GetBytes(Convert.ToInt32(Ties.Value));
		mw2.WriteBytes((UIntPtr)28883000uL, bytes);
	}

	private void checkButton14_CheckedChanged(object sender, EventArgs e)
	{
		byte[] bytes = BitConverter.GetBytes(Convert.ToInt32(Deaths.Value));
		mw2.WriteBytes((UIntPtr)28882948uL, bytes);
	}

	private void checkButton9_CheckedChanged(object sender, EventArgs e)
	{
		byte[] bytes = BitConverter.GetBytes(Convert.ToInt32(WinStreaks.Value));
		mw2.WriteBytes((UIntPtr)28883004uL, bytes);
	}

	private void checkButton10_CheckedChanged(object sender, EventArgs e)
	{
		byte[] bytes = BitConverter.GetBytes(Convert.ToInt32(Kills.Value));
		mw2.WriteBytes((UIntPtr)28882940uL, bytes);
	}

	private void checkButton11_CheckedChanged(object sender, EventArgs e)
	{
		byte[] bytes = BitConverter.GetBytes(Convert.ToInt32(Headshots.Value));
		mw2.WriteBytes((UIntPtr)28882960uL, bytes);
	}

	private void checkButton12_CheckedChanged(object sender, EventArgs e)
	{
		byte[] bytes = BitConverter.GetBytes(Convert.ToInt32(Assists.Value));
		mw2.WriteBytes((UIntPtr)28882956uL, bytes);
	}

	private void checkButton13_CheckedChanged(object sender, EventArgs e)
	{
		byte[] bytes = BitConverter.GetBytes(Convert.ToInt32(Streaks.Value));
		mw2.WriteBytes((UIntPtr)28882944uL, bytes);
	}

	private void checkButton1_CheckedChanged(object sender, EventArgs e)
	{
		mw2.WriteMemory("1B8B7E8", "int", "2434700");
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
            this.checkButton3 = new DevExpress.XtraEditors.CheckButton();
            this.Prestige = new System.Windows.Forms.NumericUpDown();
            this.XP = new System.Windows.Forms.NumericUpDown();
            this.checkButton4 = new DevExpress.XtraEditors.CheckButton();
            this.Score = new System.Windows.Forms.NumericUpDown();
            this.checkButton5 = new DevExpress.XtraEditors.CheckButton();
            this.Wins = new System.Windows.Forms.NumericUpDown();
            this.checkButton6 = new DevExpress.XtraEditors.CheckButton();
            this.Losses = new System.Windows.Forms.NumericUpDown();
            this.checkButton7 = new DevExpress.XtraEditors.CheckButton();
            this.Ties = new System.Windows.Forms.NumericUpDown();
            this.checkButton8 = new DevExpress.XtraEditors.CheckButton();
            this.Kills = new System.Windows.Forms.NumericUpDown();
            this.checkButton9 = new DevExpress.XtraEditors.CheckButton();
            this.Headshots = new System.Windows.Forms.NumericUpDown();
            this.checkButton10 = new DevExpress.XtraEditors.CheckButton();
            this.Assists = new System.Windows.Forms.NumericUpDown();
            this.checkButton11 = new DevExpress.XtraEditors.CheckButton();
            this.Streaks = new System.Windows.Forms.NumericUpDown();
            this.checkButton12 = new DevExpress.XtraEditors.CheckButton();
            this.Deaths = new System.Windows.Forms.NumericUpDown();
            this.checkButton13 = new DevExpress.XtraEditors.CheckButton();
            this.WinStreaks = new System.Windows.Forms.NumericUpDown();
            this.checkButton14 = new DevExpress.XtraEditors.CheckButton();
            this.checkButton15 = new DevExpress.XtraEditors.CheckButton();
            this.checkButton16 = new DevExpress.XtraEditors.CheckButton();
            this.TimePlay = new System.Windows.Forms.NumericUpDown();
            this.checkButton1 = new DevExpress.XtraEditors.CheckButton();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Prestige)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.XP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Score)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Wins)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Losses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Kills)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Headshots)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Assists)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Streaks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Deaths)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WinStreaks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimePlay)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.ProcStatus});
            this.toolStrip1.Location = new System.Drawing.Point(0, 287);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(564, 25);
            this.toolStrip1.TabIndex = 0;
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
            // checkButton3
            // 
            this.checkButton3.Location = new System.Drawing.Point(155, 12);
            this.checkButton3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.checkButton3.Name = "checkButton3";
            this.checkButton3.Size = new System.Drawing.Size(118, 26);
            this.checkButton3.TabIndex = 6;
            this.checkButton3.Text = "等级";
            this.checkButton3.CheckedChanged += new System.EventHandler(this.checkButton3_CheckedChanged);
            // 
            // Prestige
            // 
            this.Prestige.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Prestige.ForeColor = System.Drawing.Color.White;
            this.Prestige.Location = new System.Drawing.Point(8, 15);
            this.Prestige.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Prestige.Maximum = new decimal(new int[] {
            11,
            0,
            0,
            0});
            this.Prestige.Name = "Prestige";
            this.Prestige.Size = new System.Drawing.Size(140, 22);
            this.Prestige.TabIndex = 8;
            // 
            // XP
            // 
            this.XP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.XP.ForeColor = System.Drawing.Color.White;
            this.XP.Location = new System.Drawing.Point(8, 51);
            this.XP.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.XP.Maximum = new decimal(new int[] {
            276447231,
            23283,
            0,
            0});
            this.XP.Name = "XP";
            this.XP.Size = new System.Drawing.Size(140, 22);
            this.XP.TabIndex = 10;
            // 
            // checkButton4
            // 
            this.checkButton4.Location = new System.Drawing.Point(155, 47);
            this.checkButton4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.checkButton4.Name = "checkButton4";
            this.checkButton4.Size = new System.Drawing.Size(118, 26);
            this.checkButton4.TabIndex = 9;
            this.checkButton4.Text = "经验";
            this.checkButton4.CheckedChanged += new System.EventHandler(this.checkButton4_CheckedChanged);
            // 
            // Score
            // 
            this.Score.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Score.ForeColor = System.Drawing.Color.White;
            this.Score.Location = new System.Drawing.Point(8, 84);
            this.Score.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Score.Maximum = new decimal(new int[] {
            276447231,
            23283,
            0,
            0});
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(140, 22);
            this.Score.TabIndex = 12;
            // 
            // checkButton5
            // 
            this.checkButton5.Location = new System.Drawing.Point(155, 81);
            this.checkButton5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.checkButton5.Name = "checkButton5";
            this.checkButton5.Size = new System.Drawing.Size(118, 26);
            this.checkButton5.TabIndex = 11;
            this.checkButton5.Text = "分数";
            this.checkButton5.CheckedChanged += new System.EventHandler(this.checkButton5_CheckedChanged);
            // 
            // Wins
            // 
            this.Wins.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Wins.ForeColor = System.Drawing.Color.White;
            this.Wins.Location = new System.Drawing.Point(8, 123);
            this.Wins.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Wins.Maximum = new decimal(new int[] {
            276447231,
            23283,
            0,
            0});
            this.Wins.Name = "Wins";
            this.Wins.Size = new System.Drawing.Size(140, 22);
            this.Wins.TabIndex = 14;
            // 
            // checkButton6
            // 
            this.checkButton6.Location = new System.Drawing.Point(155, 120);
            this.checkButton6.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.checkButton6.Name = "checkButton6";
            this.checkButton6.Size = new System.Drawing.Size(118, 26);
            this.checkButton6.TabIndex = 13;
            this.checkButton6.Text = "胜场";
            this.checkButton6.CheckedChanged += new System.EventHandler(this.checkButton6_CheckedChanged);
            // 
            // Losses
            // 
            this.Losses.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Losses.ForeColor = System.Drawing.Color.White;
            this.Losses.Location = new System.Drawing.Point(8, 159);
            this.Losses.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Losses.Maximum = new decimal(new int[] {
            276447231,
            23283,
            0,
            0});
            this.Losses.Name = "Losses";
            this.Losses.Size = new System.Drawing.Size(140, 22);
            this.Losses.TabIndex = 16;
            // 
            // checkButton7
            // 
            this.checkButton7.Location = new System.Drawing.Point(155, 159);
            this.checkButton7.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.checkButton7.Name = "checkButton7";
            this.checkButton7.Size = new System.Drawing.Size(118, 26);
            this.checkButton7.TabIndex = 15;
            this.checkButton7.Text = "输场";
            this.checkButton7.CheckedChanged += new System.EventHandler(this.checkButton7_CheckedChanged);
            // 
            // Ties
            // 
            this.Ties.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Ties.ForeColor = System.Drawing.Color.White;
            this.Ties.Location = new System.Drawing.Point(8, 194);
            this.Ties.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Ties.Maximum = new decimal(new int[] {
            276447231,
            23283,
            0,
            0});
            this.Ties.Name = "Ties";
            this.Ties.Size = new System.Drawing.Size(140, 22);
            this.Ties.TabIndex = 18;
            // 
            // checkButton8
            // 
            this.checkButton8.Location = new System.Drawing.Point(155, 194);
            this.checkButton8.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.checkButton8.Name = "checkButton8";
            this.checkButton8.Size = new System.Drawing.Size(118, 26);
            this.checkButton8.TabIndex = 17;
            this.checkButton8.Text = "Set Ties";
            this.checkButton8.CheckedChanged += new System.EventHandler(this.checkButton8_CheckedChanged);
            // 
            // Kills
            // 
            this.Kills.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Kills.ForeColor = System.Drawing.Color.White;
            this.Kills.Location = new System.Drawing.Point(280, 48);
            this.Kills.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Kills.Maximum = new decimal(new int[] {
            276447231,
            23283,
            0,
            0});
            this.Kills.Name = "Kills";
            this.Kills.Size = new System.Drawing.Size(140, 22);
            this.Kills.TabIndex = 20;
            // 
            // checkButton9
            // 
            this.checkButton9.Location = new System.Drawing.Point(427, 12);
            this.checkButton9.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.checkButton9.Name = "checkButton9";
            this.checkButton9.Size = new System.Drawing.Size(118, 26);
            this.checkButton9.TabIndex = 19;
            this.checkButton9.Text = "连胜场数";
            this.checkButton9.CheckedChanged += new System.EventHandler(this.checkButton9_CheckedChanged);
            // 
            // Headshots
            // 
            this.Headshots.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Headshots.ForeColor = System.Drawing.Color.White;
            this.Headshots.Location = new System.Drawing.Point(280, 84);
            this.Headshots.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Headshots.Maximum = new decimal(new int[] {
            276447231,
            23283,
            0,
            0});
            this.Headshots.Name = "Headshots";
            this.Headshots.Size = new System.Drawing.Size(140, 22);
            this.Headshots.TabIndex = 22;
            // 
            // checkButton10
            // 
            this.checkButton10.Location = new System.Drawing.Point(427, 47);
            this.checkButton10.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.checkButton10.Name = "checkButton10";
            this.checkButton10.Size = new System.Drawing.Size(118, 26);
            this.checkButton10.TabIndex = 21;
            this.checkButton10.Text = "击杀";
            this.checkButton10.CheckedChanged += new System.EventHandler(this.checkButton10_CheckedChanged);
            // 
            // Assists
            // 
            this.Assists.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Assists.ForeColor = System.Drawing.Color.White;
            this.Assists.Location = new System.Drawing.Point(280, 120);
            this.Assists.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Assists.Maximum = new decimal(new int[] {
            276447231,
            23283,
            0,
            0});
            this.Assists.Name = "Assists";
            this.Assists.Size = new System.Drawing.Size(140, 22);
            this.Assists.TabIndex = 24;
            // 
            // checkButton11
            // 
            this.checkButton11.Location = new System.Drawing.Point(427, 81);
            this.checkButton11.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.checkButton11.Name = "checkButton11";
            this.checkButton11.Size = new System.Drawing.Size(118, 26);
            this.checkButton11.TabIndex = 23;
            this.checkButton11.Text = "爆头击杀";
            this.checkButton11.CheckedChanged += new System.EventHandler(this.checkButton11_CheckedChanged);
            // 
            // Streaks
            // 
            this.Streaks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Streaks.ForeColor = System.Drawing.Color.White;
            this.Streaks.Location = new System.Drawing.Point(280, 159);
            this.Streaks.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Streaks.Maximum = new decimal(new int[] {
            276447231,
            23283,
            0,
            0});
            this.Streaks.Name = "Streaks";
            this.Streaks.Size = new System.Drawing.Size(140, 22);
            this.Streaks.TabIndex = 26;
            // 
            // checkButton12
            // 
            this.checkButton12.Location = new System.Drawing.Point(427, 120);
            this.checkButton12.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.checkButton12.Name = "checkButton12";
            this.checkButton12.Size = new System.Drawing.Size(118, 26);
            this.checkButton12.TabIndex = 25;
            this.checkButton12.Text = "助攻";
            this.checkButton12.CheckedChanged += new System.EventHandler(this.checkButton12_CheckedChanged);
            // 
            // Deaths
            // 
            this.Deaths.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Deaths.ForeColor = System.Drawing.Color.White;
            this.Deaths.Location = new System.Drawing.Point(280, 197);
            this.Deaths.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Deaths.Maximum = new decimal(new int[] {
            276447231,
            23283,
            0,
            0});
            this.Deaths.Name = "Deaths";
            this.Deaths.Size = new System.Drawing.Size(140, 22);
            this.Deaths.TabIndex = 28;
            // 
            // checkButton13
            // 
            this.checkButton13.Location = new System.Drawing.Point(427, 156);
            this.checkButton13.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.checkButton13.Name = "checkButton13";
            this.checkButton13.Size = new System.Drawing.Size(118, 26);
            this.checkButton13.TabIndex = 27;
            this.checkButton13.Text = "连胜";
            this.checkButton13.CheckedChanged += new System.EventHandler(this.checkButton13_CheckedChanged);
            // 
            // WinStreaks
            // 
            this.WinStreaks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.WinStreaks.ForeColor = System.Drawing.Color.White;
            this.WinStreaks.Location = new System.Drawing.Point(280, 15);
            this.WinStreaks.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.WinStreaks.Maximum = new decimal(new int[] {
            276447231,
            23283,
            0,
            0});
            this.WinStreaks.Name = "WinStreaks";
            this.WinStreaks.Size = new System.Drawing.Size(140, 22);
            this.WinStreaks.TabIndex = 30;
            // 
            // checkButton14
            // 
            this.checkButton14.Location = new System.Drawing.Point(427, 194);
            this.checkButton14.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.checkButton14.Name = "checkButton14";
            this.checkButton14.Size = new System.Drawing.Size(118, 26);
            this.checkButton14.TabIndex = 29;
            this.checkButton14.Text = "死亡";
            this.checkButton14.CheckedChanged += new System.EventHandler(this.checkButton14_CheckedChanged);
            // 
            // checkButton15
            // 
            this.checkButton15.Location = new System.Drawing.Point(427, 232);
            this.checkButton15.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.checkButton15.Name = "checkButton15";
            this.checkButton15.Size = new System.Drawing.Size(118, 26);
            this.checkButton15.TabIndex = 31;
            this.checkButton15.Text = "游玩时间";
            this.checkButton15.CheckedChanged += new System.EventHandler(this.checkButton15_CheckedChanged);
            // 
            // checkButton16
            // 
            this.checkButton16.Location = new System.Drawing.Point(8, 232);
            this.checkButton16.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.checkButton16.Name = "checkButton16";
            this.checkButton16.Size = new System.Drawing.Size(265, 26);
            this.checkButton16.TabIndex = 36;
            this.checkButton16.Text = "解锁全部";
            this.checkButton16.CheckedChanged += new System.EventHandler(this.checkButton16_CheckedChanged_1);
            // 
            // TimePlay
            // 
            this.TimePlay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.TimePlay.ForeColor = System.Drawing.Color.White;
            this.TimePlay.Location = new System.Drawing.Point(280, 235);
            this.TimePlay.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TimePlay.Maximum = new decimal(new int[] {
            276447231,
            23283,
            0,
            0});
            this.TimePlay.Name = "TimePlay";
            this.TimePlay.Size = new System.Drawing.Size(140, 22);
            this.TimePlay.TabIndex = 37;
            // 
            // checkButton1
            // 
            this.checkButton1.Location = new System.Drawing.Point(8, 264);
            this.checkButton1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.checkButton1.Name = "checkButton1";
            this.checkButton1.Size = new System.Drawing.Size(265, 26);
            this.checkButton1.TabIndex = 38;
            this.checkButton1.Text = "等级 70";
            this.checkButton1.CheckedChanged += new System.EventHandler(this.checkButton1_CheckedChanged);
            // 
            // MW2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 312);
            this.Controls.Add(this.checkButton1);
            this.Controls.Add(this.TimePlay);
            this.Controls.Add(this.checkButton16);
            this.Controls.Add(this.checkButton15);
            this.Controls.Add(this.WinStreaks);
            this.Controls.Add(this.checkButton14);
            this.Controls.Add(this.Deaths);
            this.Controls.Add(this.checkButton13);
            this.Controls.Add(this.Streaks);
            this.Controls.Add(this.checkButton12);
            this.Controls.Add(this.Assists);
            this.Controls.Add(this.checkButton11);
            this.Controls.Add(this.Headshots);
            this.Controls.Add(this.checkButton10);
            this.Controls.Add(this.Kills);
            this.Controls.Add(this.checkButton9);
            this.Controls.Add(this.Ties);
            this.Controls.Add(this.checkButton8);
            this.Controls.Add(this.Losses);
            this.Controls.Add(this.checkButton7);
            this.Controls.Add(this.Wins);
            this.Controls.Add(this.checkButton6);
            this.Controls.Add(this.Score);
            this.Controls.Add(this.checkButton5);
            this.Controls.Add(this.XP);
            this.Controls.Add(this.checkButton4);
            this.Controls.Add(this.Prestige);
            this.Controls.Add(this.checkButton3);
            this.Controls.Add(this.toolStrip1);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximumSize = new System.Drawing.Size(580, 360);
            this.MinimumSize = new System.Drawing.Size(580, 360);
            this.Name = "MW2";
            this.Text = "Modern Warfare 2";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MW2_Closed);
            this.Load += new System.EventHandler(this.MW2_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Prestige)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.XP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Score)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Wins)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Losses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Kills)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Headshots)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Assists)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Streaks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Deaths)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WinStreaks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimePlay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

	}
}
