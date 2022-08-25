using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using Obsidian_ToolBox_Update.Properties;

namespace Obsidian_ToolBox_Update;

public class Form1 : XtraForm
{
	private IContainer components = null;

	private ToolStrip Controller;

	private ToolStripDropDownButton toolStripDropDownButton1;

	private ToolStripMenuItem ThemeControl;

	private ToolStripDropDownButton Game;

	private ToolStripMenuItem Games;

	private ToolStripMenuItem IW;

	private ToolStripMenuItem toolStripMenuItem2;

	private ToolStripMenuItem toolStripMenuItem3;

	private ToolStripMenuItem toolStripMenuItem4;

	private ToolStripMenuItem toolStripMenuItem5;

	private ToolStripMenuItem toolStripMenuItem6;
    private ToolStripButton toolStripButton1;
    private ToolStripButton toolStripButton2;
    private ToolStripMenuItem toolStripMenuItem1;

	public Form1()
	{
		InitializeComponent();
	}

	private void IW_Click(object sender, EventArgs e)
	{
		Infinite_Warfare IW = new Infinite_Warfare();
		IW.Show();
		Hide();
	}

	private void toolStripMenuItem6_Click(object sender, EventArgs e)
	{
		Advanced_Warfare_S1X AW = new Advanced_Warfare_S1X();
		AW.Show();
		Hide();
	}

	private void toolStripMenuItem4_Click(object sender, EventArgs e)
	{
		BlackOps_2 BO2 = new BlackOps_2();
		BO2.Show();
		Hide();
	}

	private void toolStripMenuItem5_Click(object sender, EventArgs e)
	{
		Ghosts Ghosts = new Ghosts();
		Ghosts.Show();
		Hide();
	}

	private void toolStripMenuItem1_Click(object sender, EventArgs e)
	{
	}

	private void process_end(object sender, FormClosedEventArgs e)
	{
		Environment.Exit(0);
	}

	private void ScooterFlow_Click(object sender, EventArgs e)
	{
	}

	private void toolStripMenuItem1_Click_1(object sender, EventArgs e)
	{
		MW2 MW2MP = new MW2();
		MW2MP.Show();
		Hide();
	}

	private void toolStripMenuItem3_Click(object sender, EventArgs e)
	{
		BlackOps BO1 = new BlackOps();
		BO1.Show();
		Hide();
	}

	private void ThemeControl_Click(object sender, EventArgs e)
	{
		About info = new About();
		info.Show();
		Hide();
	}

	private void toolStripMenuItem2_Click(object sender, EventArgs e)
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
            this.Controller = new System.Windows.Forms.ToolStrip();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.ThemeControl = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.Game = new System.Windows.Forms.ToolStripDropDownButton();
            this.Games = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.IW = new System.Windows.Forms.ToolStripMenuItem();
            this.Controller.SuspendLayout();
            this.SuspendLayout();
            // 
            // Controller
            // 
            this.Controller.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Controller.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.Controller.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton2,
            this.toolStripDropDownButton1,
            this.toolStripButton1,
            this.Game});
            this.Controller.Location = new System.Drawing.Point(0, 0);
            this.Controller.Name = "Controller";
            this.Controller.Size = new System.Drawing.Size(678, 25);
            this.Controller.TabIndex = 0;
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = global::Obsidian_ToolBox_Update_Form1.toolStripDropDownButton1_Image;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "toolStripButton2";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ThemeControl});
            this.toolStripDropDownButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(13, 22);
            // 
            // ThemeControl
            // 
            this.ThemeControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ThemeControl.ForeColor = System.Drawing.Color.White;
            this.ThemeControl.Name = "ThemeControl";
            this.ThemeControl.Size = new System.Drawing.Size(100, 22);
            this.ThemeControl.Text = "πÿ”⁄";
            this.ThemeControl.Click += new System.EventHandler(this.ThemeControl_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::Obsidian_ToolBox_Update_Form1.Game_Image;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // Game
            // 
            this.Game.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Game.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Games});
            this.Game.ForeColor = System.Drawing.Color.White;
            this.Game.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Game.Name = "Game";
            this.Game.Size = new System.Drawing.Size(13, 22);
            // 
            // Games
            // 
            this.Games.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Games.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5,
            this.toolStripMenuItem6,
            this.IW});
            this.Games.ForeColor = System.Drawing.Color.White;
            this.Games.Name = "Games";
            this.Games.Size = new System.Drawing.Size(100, 22);
            this.Games.Text = "”Œœ∑";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.toolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(122, 22);
            this.toolStripMenuItem1.Text = "MW2";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click_1);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.toolStripMenuItem2.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(122, 22);
            this.toolStripMenuItem2.Text = "MW3";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.toolStripMenuItem3.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(122, 22);
            this.toolStripMenuItem3.Text = "BO1";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.toolStripMenuItem4.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(122, 22);
            this.toolStripMenuItem4.Text = "BO2 P";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.toolStripMenuItem5.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(122, 22);
            this.toolStripMenuItem5.Text = "Ghosts";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.toolStripMenuItem5_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.toolStripMenuItem6.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(122, 22);
            this.toolStripMenuItem6.Text = "AW S1X";
            this.toolStripMenuItem6.Click += new System.EventHandler(this.toolStripMenuItem6_Click);
            // 
            // IW
            // 
            this.IW.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.IW.ForeColor = System.Drawing.Color.White;
            this.IW.Name = "IW";
            this.IW.Size = new System.Drawing.Size(122, 22);
            this.IW.Text = "IW";
            this.IW.Click += new System.EventHandler(this.IW_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 462);
            this.Controls.Add(this.Controller);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximumSize = new System.Drawing.Size(694, 510);
            this.MinimumSize = new System.Drawing.Size(694, 510);
            this.Name = "Form1";
            this.Text = "Fallingfl Tool";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.process_end);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Controller.ResumeLayout(false);
            this.Controller.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

	}

    private void Form1_Load(object sender, EventArgs e)
    {

    }

    private void toolStripButton1_Click(object sender, EventArgs e)
    {

    }

    private void toolStripButton2_Click(object sender, EventArgs e)
    {

    }
}
