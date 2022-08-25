using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.Utils.Behaviors;
using DevExpress.XtraEditors;
using Memory;

namespace Obsidian_ToolBox_Update;

public class Infinite_Warfare : XtraForm
{
	private Mem IW = new Mem();

	private string Class1 = "145EC5E49";

	private string Class2 = "145EC5E9C";

	private string Class3 = "145EC5EEF";

	private string Class4 = "145EC5F42";

	private string Class5 = "145EC5F95";

	private string Class6 = "145EC5FE8";

	private string Class7 = "145EC603B";

	private string Class8 = "145EC608E";

	private string Class9 = "145EC60E1";

	private string Class10 = "145EC6134";

	private string MPRC = "145EC3ECA";

	private string MPRCXP = "145EC3EC6";

	private string MPRCK = "145EC3969";

	private string MPRCD = "145EC5051";

	private string MPRCW = "145EC373D";

	private string MPRCL = "145EC5069";

	private string MPRCT = "145EC48DE";

	private string JTF = "145EC5C7A";

	private string ORION = "145EC5C98";

	private string SABRE = "145EC5CB6";

	private string WRAITH = "145EC5CD4";

	private string BLOOD = "145EC5CF2";

	private string RigSolar = "145EC3DF6";

	private string RigBSky = "145EC3DF7";

	private string NV4XP = "145EC1D78";

	private string R3KXP = "145EC1D96";

	private string KBARXP = "145EC1D64";

	private string TYPE2XP = "145EC1D8C";

	private string VOLKXP = "145EC1D6E";

	private string RVNXP = "145EC1E6C";

	private string XEONXP = "145EC1E80";

	private string GRAILXP = "145EC1EBC";

	private string ERADXP = "145EC1D04";

	private string FHRXP = "145EC1D2C";

	private string KARMXP = "145EC1D0A";

	private string RPRXP = "145EC1D22";

	private string HVRXP = "145EC1D36";

	private string VPRXP = "145EC1E8A";

	private string TRENCHXP = "145EC1E94";

	private string RAIJXP = "145EC1EE4";

	private string RAWXP = "145EC1E26";

	private string MAULXP = "145EC1E1C";

	private string TITANXP = "145EC1E2C";

	private string AUGXP = "145EC1E9E";

	private string ATLXP = "145EC1ED0";

	private string KBSXP = "145EC1DAE";

	private string EBRXP = "145EC1DB8";

	private string WIDMXP = "145EC1DC2";

	private string DMR1XP = "145EC1DD6";

	private string TREKXP = "145EC1EB2";

	private string PROTXP = "145EC1EC2";

	private string REAVXP = "145EC1DEA";

	private string BANSXP = "145EC1DF4";

	private string DCMXP = "145EC1DFE";

	private string RACKXP = "145EC1E08";

	private string M21XP = "145EC1EA8";

	private string OSAXP = "145EC1DA4";

	private string UMPXP = "145EC1D3C";

	private string TF141XP = "145EC1DCC";

	private string SRXP = "145EC1E0F";

	private string M1GXP = "145EC1DDC";

	private string EMCXP = "145EC1CDC";

	private string ONIXP = "145EC1CD2";

	private string KENDXP = "145EC1CF0";

	private string HAILXP = "145EC1CE6";

	private string UDMXP = "145EC1E76";

	private string STALLXP = "145EC1ED6";

	private string SPARTXP = "145EC1E3A";

	private string PLAWXP = "145EC1E4A";

	private string HOWXP = "145EC1E40";

	private string VENOXP = "145EC1EEA";

	private string CKNIFEXP = "145EC1D4A";

	private string AXEXP = "145EC1E54";

	private string KATXP = "145EC1EF4";

	private string NUNXP = "145EC1EFE";

	private string HORNXP = "145EC1CF6";

	private string NV4P3 = "145EC1D80";

	private string RKP3 = "145EC1D9E";

	private string KBARP3 = "145EC1D6C";

	private string TYPE2P3 = "145EC1D94";

	private string VOLKP3 = "145EC1D76";

	private string RVNP3 = "145EC1E70";

	private string XEONP3 = "145EC1E84";

	private string GRAILP3 = "145EC1EC0";

	private string ERADP3 = "145EC1D08";

	private string FHRP3 = "145EC1D30";

	private string KARP3 = "145EC1D12";

	private string RPRP3 = "145EC1D26";

	private string HVRP3 = "145EC1D3A";

	private string VPRP3 = "145EC1E8E";

	private string TRENCHP3 = "145EC1E98";

	private string RAIJP3 = "145EC1EE8";

	private string RAWP3 = "145EC1E2A";

	private string MAULP3 = "145EC1E20";

	private string TITP3 = "145EC1E34";

	private string AUGP3 = "145EC1EA2";

	private string ATP3 = "145EC1ED4";

	private string KBSP3 = "145EC1DB2";

	private string EBRP3 = "145EC1DBC";

	private string WIDP3 = "145EC1DC6";

	private string DMRP3 = "145EC1DDA";

	private string TREKP3 = "145EC1EB6";

	private string PRTP3 = "145EC1ECA";

	private string REAVP3 = "145EC1DEE";

	private string BANP3 = "145EC1DF8";

	private string DCMP3 = "145EC1E02";

	private string RCKP3 = "145EC1E0C";

	private string M21P3 = "145EC1EAC";

	private string OSAP3 = "145EC1DA8";

	private string UMPP3 = "145EC1D44";

	private string TF1P3 = "145EC1DD0";

	private string SRP3 = "145EC1E16";

	private string M1GP3 = "145EC1DE4";

	private string EMCP3 = "145EC1CE0";

	private string ONIP3 = "145EC1CD6";

	private string KENDP3 = "145EC1CF4";

	private string HAILP3 = "145EC1CEA";

	private string UDMP3 = "145EC1E7A";

	private string STALLP3 = "145EC1EDE";

	private string HORNP3 = "145EC1CFE";

	private IContainer components = null;

	private ToolStrip toolStrip1;

	private ToolStripLabel toolStripLabel1;

	private ToolStripLabel ProcStatus;

	private ToggleSwitch GodToggle;

	private ToggleSwitch uAmmo;

	private ToggleSwitch Money;

	private ToggleSwitch nRecoilToggle;

	private ToggleSwitch uNadeToggle;

	private ToggleSwitch ThirdPToggle;

	private ToggleSwitch nTargetToggle;

	private ToggleSwitch RFToggle;

	private ToggleSwitch JumpToggle;

	private ToggleSwitch TScaleToggle;

	private ToggleSwitch ufoToggle;

	private ToggleSwitch OneHToggle;

	private TextEdit RoundButn;

	private BehaviorManager behaviorManager1;

	private CheckButton Round;

	private CheckButton cModelButn;

	private TextEdit ModelTXT;

	private CheckButton CCNButn;

	private TextEdit CCNTXT;

	private CheckButton ZMRCButn;

	private CheckButton MPRCBtn;

	private CheckButton MaxZLvl;

	private CheckButton checkButton7;

	private CheckButton MMButn;

	private CheckButton CCButn;

	private CheckButton MWButn;

	private CheckButton IZSButn;

	private TextEdit ZValue;

	private TextEdit YValue;

	private TextEdit XValue;

	private LabelControl labelControl1;

	private LabelControl labelControl2;

	private LabelControl labelControl3;

	private CheckButton tpButn;

	private CheckButton TeleSPWNButn;

	private CheckButton TelePAPButn;

	private CheckButton YTCCButn;

	public Infinite_Warfare()
	{
		InitializeComponent();
	}

	private void IW_Closed(object sender, FormClosedEventArgs e)
	{
		Hide();
		Form1 form1 = new Form1();
		form1.Show();
	}

	private void checkEdit1_Toggled(object sender, EventArgs e)
	{
		if (GodToggle.IsOn)
		{
			IW.FreezeValue("143D227F0", "int", "99999");
		}
		else
		{
			IW.UnfreezeValue("143D227F0");
		}
	}

	private void toggleSwitch2_Toggled(object sender, EventArgs e)
	{
		IW.FreezeValue("25E4BEE4E", "int", "999999");
	}

	private void toggleSwitch3_Toggled(object sender, EventArgs e)
	{
		if (nRecoilToggle.IsOn)
		{
			IW.WriteMemory("1408E188C", "int", "11437327");
		}
		else
		{
			IW.WriteMemory("1408E188C", "int", "11437071");
		}
	}

	private void toggleSwitch10_Toggled(object sender, EventArgs e)
	{
		if (ufoToggle.IsOn)
		{
			IW.WriteMemory("143CA6AF4", "byte", "2");
		}
		else
		{
			IW.WriteMemory("143CA6AF4", "byte", "0");
		}
	}

	private void checkButton3_CheckedChanged(object sender, EventArgs e)
	{
		IW.WriteMemory(Class1, "string", CCNTXT.Text);
		IW.WriteMemory(Class2, "string", CCNTXT.Text);
		IW.WriteMemory(Class3, "string", CCNTXT.Text);
		IW.WriteMemory(Class4, "string", CCNTXT.Text);
		IW.WriteMemory(Class5, "string", CCNTXT.Text);
		IW.WriteMemory(Class6, "string", CCNTXT.Text);
		IW.WriteMemory(Class7, "string", CCNTXT.Text);
		IW.WriteMemory(Class8, "string", CCNTXT.Text);
		IW.WriteMemory(Class9, "string", CCNTXT.Text);
		IW.WriteMemory(Class10, "string", CCNTXT.Text);
	}

	private void checkButton5_CheckedChanged(object sender, EventArgs e)
	{
		IW.WriteMemory(MPRC, "int", "10");
		IW.WriteMemory(MPRCXP, "int", "1457199");
		IW.WriteMemory(MPRCK, "int", "255000");
		IW.WriteMemory(MPRCD, "int", "50000");
		IW.WriteMemory(MPRCW, "int", "100000");
		IW.WriteMemory(MPRCL, "int", "35000");
		IW.WriteMemory(MPRCT, "int", "9999999");
	}

	private void checkButton6_CheckedChanged(object sender, EventArgs e)
	{
		IW.WriteMemory("145ECA68C", "int", "99999999");
	}

	private void checkButton13_CheckedChanged(object sender, EventArgs e)
	{
		IW.WriteMemory("143CA208C", "float", "3319.98999");
		IW.WriteMemory("143CA2088", "float", "527.6842041");
		IW.WriteMemory("143CA2090", "float", "0.02777294815");
	}

	private void checkButton14_CheckedChanged(object sender, EventArgs e)
	{
		IW.WriteMemory("143CA208C", "float", "807.8001709");
		IW.WriteMemory("143CA2088", "float", "-10330.2959");
		IW.WriteMemory("143CA2090", "float", "-1629.873535");
	}

	private void checkButton15_CheckedChanged(object sender, EventArgs e)
	{
		IW.WriteMemory(Class1, "string", "^1Fallingfl");
		IW.WriteMemory(Class2, "string", "^2Xiao478");
		IW.WriteMemory(Class3, "string", "^3Icarus");
		IW.WriteMemory(Class4, "string", "^4MK");
		IW.WriteMemory(Class5, "string", "^5Ayu");
		IW.WriteMemory(Class6, "string", "^6LeiMu");
		IW.WriteMemory(Class7, "string", "^7Null");
		IW.WriteMemory(Class8, "string", "^8Thanks");
		IW.WriteMemory(Class9, "string", "^9AZ");
		IW.WriteMemory(Class10, "string", "^1My Tool");
	}

	private void Infinite_Warfare_Load(object sender, EventArgs e)
	{
		int PID = IW.GetProcIdFromName("iw7_ship");
		if (PID > 0)
		{
			IW.OpenProcess(PID);
			ProcStatus.ForeColor = Color.Green;
			ProcStatus.Text = "Found Infinite Warfare";
		}
	}

	private void checkButton2_CheckedChanged(object sender, EventArgs e)
	{
		IW.WriteMemory("143D228D0", "int", ModelTXT.Text);
	}

	private void Round_CheckedChanged(object sender, EventArgs e)
	{
		IW.FreezeValue("146854DC0", "int", RoundButn.Text);
	}

	private void checkButton7_CheckedChanged(object sender, EventArgs e)
	{
		IW.WriteMemory("145EC3ECA", "int", "30");
	}

	private void toggleSwitch1_Toggled(object sender, EventArgs e)
	{
		if (uAmmo.IsOn)
		{
			IW.FreezeValue("143CA294C", "int", "99999");
			IW.FreezeValue("143CA2AC0", "int", "99999");
			IW.FreezeValue("143CA2994", "int", "99999");
			IW.FreezeValue("143CA2B08", "int", "99999");
			IW.FreezeValue("143CA2AC4", "int", "99999");
		}
		else
		{
			IW.UnfreezeValue("143CA294C");
			IW.UnfreezeValue("143CA2AC0");
			IW.UnfreezeValue("143CA2994");
			IW.UnfreezeValue("143CA2B08");
			IW.UnfreezeValue("143CA2AC4");
		}
	}

	private void checkButton10_CheckedChanged(object sender, EventArgs e)
	{
		IW.WriteMemory(NV4P3, "int", "3");
		IW.WriteMemory(RKP3, "int", "3");
		IW.WriteMemory(KBARP3, "int", "3");
		IW.WriteMemory(TYPE2P3, "int", "3");
		IW.WriteMemory(VOLKP3, "int", "3");
		IW.WriteMemory(RVNP3, "int", "3");
		IW.WriteMemory(XEONP3, "int", "3");
		IW.WriteMemory(GRAILP3, "int", "3");
		IW.WriteMemory(ERADP3, "int", "3");
		IW.WriteMemory(FHRP3, "int", "3");
		IW.WriteMemory(KARP3, "int", "3");
		IW.WriteMemory(RPRP3, "int", "3");
		IW.WriteMemory(HVRP3, "int", "3");
		IW.WriteMemory(VPRP3, "int", "3");
		IW.WriteMemory(TRENCHP3, "int", "3");
		IW.WriteMemory(RAIJP3, "int", "3");
		IW.WriteMemory(RAWP3, "int", "3");
		IW.WriteMemory(MAULP3, "int", "3");
		IW.WriteMemory(TITP3, "int", "3");
		IW.WriteMemory(AUGP3, "int", "3");
		IW.WriteMemory(ATP3, "int", "3");
		IW.WriteMemory(KBSP3, "int", "3");
		IW.WriteMemory(EBRP3, "int", "3");
		IW.WriteMemory(WIDP3, "int", "3");
		IW.WriteMemory(DMRP3, "int", "3");
		IW.WriteMemory(TREKP3, "int", "3");
		IW.WriteMemory(PRTP3, "int", "3");
		IW.WriteMemory(REAVP3, "int", "3");
		IW.WriteMemory(BANP3, "int", "3");
		IW.WriteMemory(DCMP3, "int", "3");
		IW.WriteMemory(RCKP3, "int", "3");
		IW.WriteMemory(M21P3, "int", "3");
		IW.WriteMemory(OSAP3, "int", "3");
		IW.WriteMemory(UMPP3, "int", "3");
		IW.WriteMemory(TF1P3, "int", "3");
		IW.WriteMemory(SRP3, "int", "3");
		IW.WriteMemory(M1GP3, "int", "3");
		IW.WriteMemory(EMCP3, "int", "3");
		IW.WriteMemory(ONIP3, "int", "3");
		IW.WriteMemory(KENDP3, "int", "3");
		IW.WriteMemory(HAILP3, "int", "3");
		IW.WriteMemory(UDMP3, "int", "3");
		IW.WriteMemory(STALLP3, "int", "3");
		IW.WriteMemory(HORNP3, "int", "3");
		IW.WriteMemory(NV4XP, "int", "45400");
		IW.WriteMemory(R3KXP, "int", "45400");
		IW.WriteMemory(VOLKXP, "int", "45400");
		IW.WriteMemory(KARMXP, "int", "45400");
		IW.WriteMemory(TITANXP, "int", "45400");
		IW.WriteMemory(PROTXP, "int", "45400");
		IW.WriteMemory(KBARXP, "int", "45400");
		IW.WriteMemory(TYPE2XP, "int", "45400");
		IW.WriteMemory(RVNXP, "int", "45400");
		IW.WriteMemory(XEONXP, "int", "45400");
		IW.WriteMemory(GRAILXP, "int", "45400");
		IW.WriteMemory(ERADXP, "int", "45400");
		IW.WriteMemory(FHRXP, "int", "45400");
		IW.WriteMemory(RPRXP, "int", "45400");
		IW.WriteMemory(HVRXP, "int", "45400");
		IW.WriteMemory(VPRXP, "int", "45400");
		IW.WriteMemory(TRENCHXP, "int", "45400");
		IW.WriteMemory(RAIJXP, "int", "45400");
		IW.WriteMemory(RAWXP, "int", "45400");
		IW.WriteMemory(MAULXP, "int", "45400");
		IW.WriteMemory(AUGXP, "int", "45400");
		IW.WriteMemory(ATLXP, "int", "45400");
		IW.WriteMemory(KBSXP, "int", "45400");
		IW.WriteMemory(EBRXP, "int", "45400");
		IW.WriteMemory(WIDMXP, "int", "45400");
		IW.WriteMemory(DMR1XP, "int", "45400");
		IW.WriteMemory(TREKXP, "int", "45400");
		IW.WriteMemory(REAVXP, "int", "45400");
		IW.WriteMemory(BANSXP, "int", "45400");
		IW.WriteMemory(DCMXP, "int", "45400");
		IW.WriteMemory(RACKXP, "int", "45400");
		IW.WriteMemory(M21XP, "int", "45400");
		IW.WriteMemory(OSAXP, "int", "45400");
		IW.WriteMemory(UMPXP, "int", "45400");
		IW.WriteMemory(TF141XP, "int", "45400");
		IW.WriteMemory(SRXP, "int", "45400");
		IW.WriteMemory(M1GXP, "int", "45400");
		IW.WriteMemory(EMCXP, "int", "45400");
		IW.WriteMemory(ONIXP, "int", "45400");
		IW.WriteMemory(KENDXP, "int", "45400");
		IW.WriteMemory(HAILXP, "int", "45400");
		IW.WriteMemory(UDMXP, "int", "45400");
		IW.WriteMemory(STALLXP, "int", "45400");
		IW.WriteMemory(SPARTXP, "int", "45400");
		IW.WriteMemory(PLAWXP, "int", "45400");
		IW.WriteMemory(HOWXP, "int", "45400");
		IW.WriteMemory(VENOXP, "int", "45400");
		IW.WriteMemory(CKNIFEXP, "int", "45400");
		IW.WriteMemory(AXEXP, "int", "45400");
		IW.WriteMemory(KATXP, "int", "45400");
		IW.WriteMemory(NUNXP, "int", "45400");
		IW.WriteMemory(HORNXP, "int", "45400");
	}

	private void uNadeToggle_Toggled(object sender, EventArgs e)
	{
		if (uNadeToggle.IsOn)
		{
			IW.FreezeValue("1468B5720", "int", "4");
		}
		else
		{
			IW.UnfreezeValue("1468B5720");
		}
	}

	private void toggleSwitch5_Toggled(object sender, EventArgs e)
	{
		if (ThirdPToggle.IsOn)
		{
			IW.FreezeValue("1475D76F0", "int", "1");
		}
		else
		{
			IW.FreezeValue("1475D76F0", "int", "0");
		}
	}

	private void nTargetToggle_Toggled(object sender, EventArgs e)
	{
		if (nTargetToggle.IsOn)
		{
			IW.FreezeValue("143D227F0", "int", "2764472317");
		}
		else
		{
			IW.UnfreezeValue("143D227F0");
		}
	}

	private void RFToggle_Toggled(object sender, EventArgs e)
	{
		if (RFToggle.IsOn)
		{
			byte[] bytes2 = new byte[1] { 148 };
			IW.WriteBytes("14072EB61", bytes2);
		}
		else
		{
			byte[] bytes = new byte[1] { 132 };
			IW.WriteBytes("14072EB61", bytes);
		}
	}

	private void JumpToggle_Toggled(object sender, EventArgs e)
	{
		if (JumpToggle.IsOn)
		{
			byte[] bytes2 = new byte[1] { 117 };
			IW.WriteBytes("14070F47C", bytes2);
		}
		else
		{
			byte[] bytes = new byte[1] { 116 };
			IW.WriteBytes("14070F47C", bytes);
		}
	}

	private void TScaleToggle_Toggled(object sender, EventArgs e)
	{
		if (TScaleToggle.IsOn)
		{
			IW.WriteMemory("146005D84", "float", "6");
		}
		else
		{
			IW.WriteMemory("146005D84", "float", "1");
		}
	}

	private void OneHToggle_Toggled(object sender, EventArgs e)
	{
		if (OneHToggle.IsOn)
		{
			IW.FreezeValue("143D26F60", "int", "1");
			IW.FreezeValue("143D27358", "int", "1");
			IW.FreezeValue("143D27750", "int", "1");
			IW.FreezeValue("143D27B48", "int", "1");
			IW.FreezeValue("143D28B28", "int", "1");
			IW.FreezeValue("143D28730", "int", "1");
			IW.FreezeValue("143D28338", "int", "1");
			IW.FreezeValue("143D27F40", "int", "1");
			IW.FreezeValue("143D2AEE0", "int", "1");
			IW.FreezeValue("143D2BAC8", "int", "1");
			IW.FreezeValue("143D2BEC0", "int", "1");
			IW.FreezeValue("143D2C6B0", "int", "1");
			IW.FreezeValue("143D2C2B8", "int", "1");
			IW.FreezeValue("143D2CAA8", "int", "1");
			IW.FreezeValue("143D2B6D0", "int", "1");
			IW.FreezeValue("143D28F20", "int", "1");
			IW.FreezeValue("143D29318", "int", "1");
			IW.FreezeValue("143D2B2D8", "int", "1");
			IW.FreezeValue("143D29710", "int", "1");
			IW.FreezeValue("143D29B08", "int", "1");
			IW.FreezeValue("143D29F00", "int", "1");
			IW.FreezeValue("143D2A2F8", "int", "1");
			IW.FreezeValue("143D2A6F0", "int", "1");
			IW.FreezeValue("143D2AAE8", "int", "1");
		}
		else
		{
			IW.UnfreezeValue("143D26F60");
			IW.UnfreezeValue("143D27358");
			IW.UnfreezeValue("143D27750");
			IW.UnfreezeValue("143D27B48");
			IW.UnfreezeValue("143D28B28");
			IW.UnfreezeValue("143D28730");
			IW.UnfreezeValue("143D28338");
			IW.UnfreezeValue("143D27F40");
			IW.UnfreezeValue("143D2AEE0");
			IW.UnfreezeValue("143D2BAC8");
			IW.UnfreezeValue("143D2BEC0");
			IW.UnfreezeValue("143D2C6B0");
			IW.UnfreezeValue("143D2C2B8");
			IW.UnfreezeValue("143D2CAA8");
			IW.UnfreezeValue("143D2B6D0");
			IW.UnfreezeValue("143D28F20");
			IW.UnfreezeValue("143D29318");
			IW.UnfreezeValue("143D2B2D8");
			IW.UnfreezeValue("143D29710");
			IW.UnfreezeValue("143D29B08");
			IW.UnfreezeValue("143D29F00");
			IW.UnfreezeValue("143D2A2F8");
			IW.UnfreezeValue("143D2A6F0");
			IW.UnfreezeValue("143D2AAE8");
		}
	}

	private void checkButton12_CheckedChanged(object sender, EventArgs e)
	{
		IW.WriteMemory("143CA208C", "float", XValue.Text);
		IW.WriteMemory("143CA2088", "float", YValue.Text);
		IW.WriteMemory("143CA2090", "float", ZValue.Text);
	}

	private void ZMRCButn_CheckedChanged(object sender, EventArgs e)
	{
		IW.WriteMemory("145ECA68C", "int", "35634343");
		IW.WriteMemory("145ECAEDE", "int", "355000");
		IW.WriteMemory("145ECAEEA", "int", "157000");
		IW.WriteMemory("145ECAF06", "int", "621000");
		IW.WriteMemory("145ECAF0A", "int", "253000");
		IW.WriteMemory("145ECAEDA", "int", "72");
		IW.WriteMemory("145ECAEC2", "int", "682000");
		IW.WriteMemory("145ECAEBE", "int", "133700");
		IW.WriteMemory("145ECAED6", "int", "254000");
		IW.WriteMemory("145ECAF02", "int", "999999");
		IW.WriteMemory("145ECAEFE", "int", "175000");
	}

	private void CCButn_CheckedChanged(object sender, EventArgs e)
	{
		IW.WriteMemory(Class1, "string", "^1Loadout 1");
		IW.WriteMemory(Class2, "string", "^2Loadout 2");
		IW.WriteMemory(Class3, "string", "^3Loadout 3");
		IW.WriteMemory(Class4, "string", "^4Loadout 4");
		IW.WriteMemory(Class5, "string", "^5Loadout 5");
		IW.WriteMemory(Class6, "string", "^6Loadout 6");
		IW.WriteMemory(Class7, "string", "^7Loadout 7");
		IW.WriteMemory(Class8, "string", "^1Loadout 8");
		IW.WriteMemory(Class9, "string", "^2Loadout 9");
		IW.WriteMemory(Class10, "string", "^3Loadout 10");
	}

	private void checkButton8_CheckedChanged(object sender, EventArgs e)
	{
		IW.WriteMemory(JTF, "int", "99");
		IW.WriteMemory(ORION, "int", "99");
		IW.WriteMemory(SABRE, "int", "99");
		IW.WriteMemory(WRAITH, "int", "99");
		IW.WriteMemory(BLOOD, "int", "99");
		IW.WriteMemory(RigSolar, "int", "1");
		IW.WriteMemory(RigBSky, "int", "1");
	}

	private void checkButton11_CheckedChanged(object sender, EventArgs e)
	{
		IW.WriteMemory("145ECAEDE", "int", "999999");
		IW.WriteMemory("145ECAEEA", "int", "999999");
		IW.WriteMemory("145ECAF06", "int", "999999");
		IW.WriteMemory("145ECAF0A", "int", "999999");
		IW.WriteMemory("145ECAEDA", "int", "999999");
		IW.WriteMemory("145ECAEC2", "int", "999999");
		IW.WriteMemory("145ECAEBE", "int", "999999");
		IW.WriteMemory("145ECAED6", "int", "999999");
		IW.WriteMemory("145ECAF02", "int", "99999999");
		IW.WriteMemory("145ECAEFE", "int", "999999");
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
            this.components = new System.ComponentModel.Container();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.ProcStatus = new System.Windows.Forms.ToolStripLabel();
            this.GodToggle = new DevExpress.XtraEditors.ToggleSwitch();
            this.uAmmo = new DevExpress.XtraEditors.ToggleSwitch();
            this.Money = new DevExpress.XtraEditors.ToggleSwitch();
            this.nRecoilToggle = new DevExpress.XtraEditors.ToggleSwitch();
            this.uNadeToggle = new DevExpress.XtraEditors.ToggleSwitch();
            this.ThirdPToggle = new DevExpress.XtraEditors.ToggleSwitch();
            this.nTargetToggle = new DevExpress.XtraEditors.ToggleSwitch();
            this.RFToggle = new DevExpress.XtraEditors.ToggleSwitch();
            this.JumpToggle = new DevExpress.XtraEditors.ToggleSwitch();
            this.TScaleToggle = new DevExpress.XtraEditors.ToggleSwitch();
            this.ufoToggle = new DevExpress.XtraEditors.ToggleSwitch();
            this.OneHToggle = new DevExpress.XtraEditors.ToggleSwitch();
            this.RoundButn = new DevExpress.XtraEditors.TextEdit();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.Round = new DevExpress.XtraEditors.CheckButton();
            this.cModelButn = new DevExpress.XtraEditors.CheckButton();
            this.ModelTXT = new DevExpress.XtraEditors.TextEdit();
            this.CCNButn = new DevExpress.XtraEditors.CheckButton();
            this.CCNTXT = new DevExpress.XtraEditors.TextEdit();
            this.ZMRCButn = new DevExpress.XtraEditors.CheckButton();
            this.MPRCBtn = new DevExpress.XtraEditors.CheckButton();
            this.MaxZLvl = new DevExpress.XtraEditors.CheckButton();
            this.checkButton7 = new DevExpress.XtraEditors.CheckButton();
            this.MMButn = new DevExpress.XtraEditors.CheckButton();
            this.CCButn = new DevExpress.XtraEditors.CheckButton();
            this.MWButn = new DevExpress.XtraEditors.CheckButton();
            this.IZSButn = new DevExpress.XtraEditors.CheckButton();
            this.ZValue = new DevExpress.XtraEditors.TextEdit();
            this.YValue = new DevExpress.XtraEditors.TextEdit();
            this.XValue = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.tpButn = new DevExpress.XtraEditors.CheckButton();
            this.TeleSPWNButn = new DevExpress.XtraEditors.CheckButton();
            this.TelePAPButn = new DevExpress.XtraEditors.CheckButton();
            this.YTCCButn = new DevExpress.XtraEditors.CheckButton();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GodToggle.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uAmmo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Money.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nRecoilToggle.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uNadeToggle.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThirdPToggle.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nTargetToggle.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RFToggle.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.JumpToggle.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TScaleToggle.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ufoToggle.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OneHToggle.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RoundButn.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ModelTXT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CCNTXT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ZValue.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.YValue.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.XValue.Properties)).BeginInit();
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
            this.toolStrip1.Location = new System.Drawing.Point(0, 293);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(694, 25);
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
            // GodToggle
            // 
            this.GodToggle.Location = new System.Drawing.Point(14, 13);
            this.GodToggle.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.GodToggle.Name = "GodToggle";
            // 
            // 
            // 
            this.GodToggle.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.GodToggle.Properties.OffText = "无敌 Off";
            this.GodToggle.Properties.OnText = "无敌 On";
            this.GodToggle.Size = new System.Drawing.Size(162, 25);
            this.GodToggle.TabIndex = 4;
            this.GodToggle.Toggled += new System.EventHandler(this.checkEdit1_Toggled);
            // 
            // uAmmo
            // 
            this.uAmmo.Location = new System.Drawing.Point(14, 45);
            this.uAmmo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.uAmmo.Name = "uAmmo";
            // 
            // 
            // 
            this.uAmmo.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.uAmmo.Properties.OffText = "无限子弹 Off";
            this.uAmmo.Properties.OnText = "无限子弹 On";
            this.uAmmo.Size = new System.Drawing.Size(162, 25);
            this.uAmmo.TabIndex = 5;
            this.uAmmo.Toggled += new System.EventHandler(this.toggleSwitch1_Toggled);
            // 
            // Money
            // 
            this.Money.Location = new System.Drawing.Point(14, 78);
            this.Money.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Money.Name = "Money";
            // 
            // 
            // 
            this.Money.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.Money.Properties.OffText = "最大金钱 Off";
            this.Money.Properties.OnText = "最大金钱 On";
            this.Money.Size = new System.Drawing.Size(177, 25);
            this.Money.TabIndex = 6;
            this.Money.Toggled += new System.EventHandler(this.toggleSwitch2_Toggled);
            // 
            // nRecoilToggle
            // 
            this.nRecoilToggle.Location = new System.Drawing.Point(14, 110);
            this.nRecoilToggle.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.nRecoilToggle.Name = "nRecoilToggle";
            // 
            // 
            // 
            this.nRecoilToggle.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.nRecoilToggle.Properties.OffText = "无后坐 Off";
            this.nRecoilToggle.Properties.OnText = "无后坐 On";
            this.nRecoilToggle.Size = new System.Drawing.Size(162, 25);
            this.nRecoilToggle.TabIndex = 7;
            this.nRecoilToggle.Toggled += new System.EventHandler(this.toggleSwitch3_Toggled);
            // 
            // uNadeToggle
            // 
            this.uNadeToggle.Location = new System.Drawing.Point(14, 142);
            this.uNadeToggle.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.uNadeToggle.Name = "uNadeToggle";
            // 
            // 
            // 
            this.uNadeToggle.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.uNadeToggle.Properties.OffText = "无限手雷 Off";
            this.uNadeToggle.Properties.OnText = "无限手雷 On";
            this.uNadeToggle.Size = new System.Drawing.Size(162, 25);
            this.uNadeToggle.TabIndex = 8;
            this.uNadeToggle.Toggled += new System.EventHandler(this.uNadeToggle_Toggled);
            // 
            // ThirdPToggle
            // 
            this.ThirdPToggle.Location = new System.Drawing.Point(14, 174);
            this.ThirdPToggle.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ThirdPToggle.Name = "ThirdPToggle";
            // 
            // 
            // 
            this.ThirdPToggle.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.ThirdPToggle.Properties.OffText = "第三人称 Off";
            this.ThirdPToggle.Properties.OnText = "第三人称 On";
            this.ThirdPToggle.Size = new System.Drawing.Size(173, 25);
            this.ThirdPToggle.TabIndex = 9;
            this.ThirdPToggle.Toggled += new System.EventHandler(this.toggleSwitch5_Toggled);
            // 
            // nTargetToggle
            // 
            this.nTargetToggle.Location = new System.Drawing.Point(205, 13);
            this.nTargetToggle.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.nTargetToggle.Name = "nTargetToggle";
            // 
            // 
            // 
            this.nTargetToggle.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.nTargetToggle.Properties.OffText = "无视 Off";
            this.nTargetToggle.Properties.OnText = "无视 On";
            this.nTargetToggle.Size = new System.Drawing.Size(162, 25);
            this.nTargetToggle.TabIndex = 10;
            this.nTargetToggle.Toggled += new System.EventHandler(this.nTargetToggle_Toggled);
            // 
            // RFToggle
            // 
            this.RFToggle.Location = new System.Drawing.Point(205, 45);
            this.RFToggle.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.RFToggle.Name = "RFToggle";
            // 
            // 
            // 
            this.RFToggle.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.RFToggle.Properties.OffText = "快速射击 Off";
            this.RFToggle.Properties.OnText = "快速射击 On";
            this.RFToggle.Size = new System.Drawing.Size(162, 25);
            this.RFToggle.TabIndex = 11;
            this.RFToggle.Toggled += new System.EventHandler(this.RFToggle_Toggled);
            // 
            // JumpToggle
            // 
            this.JumpToggle.Location = new System.Drawing.Point(205, 78);
            this.JumpToggle.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.JumpToggle.Name = "JumpToggle";
            // 
            // 
            // 
            this.JumpToggle.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.JumpToggle.Properties.OffText = "超级跳跃 Off";
            this.JumpToggle.Properties.OnText = "超级跳跃 On";
            this.JumpToggle.Size = new System.Drawing.Size(162, 25);
            this.JumpToggle.TabIndex = 12;
            this.JumpToggle.Toggled += new System.EventHandler(this.JumpToggle_Toggled);
            // 
            // TScaleToggle
            // 
            this.TScaleToggle.Location = new System.Drawing.Point(205, 110);
            this.TScaleToggle.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TScaleToggle.Name = "TScaleToggle";
            // 
            // 
            // 
            this.TScaleToggle.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.TScaleToggle.Properties.OffText = "时间速度 Off";
            this.TScaleToggle.Properties.OnText = "时间速度 On";
            this.TScaleToggle.Size = new System.Drawing.Size(162, 25);
            this.TScaleToggle.TabIndex = 13;
            this.TScaleToggle.Toggled += new System.EventHandler(this.TScaleToggle_Toggled);
            // 
            // ufoToggle
            // 
            this.ufoToggle.Location = new System.Drawing.Point(205, 142);
            this.ufoToggle.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ufoToggle.Name = "ufoToggle";
            // 
            // 
            // 
            this.ufoToggle.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.ufoToggle.Properties.OffText = "UFO Off";
            this.ufoToggle.Properties.OnText = "UFO On";
            this.ufoToggle.Size = new System.Drawing.Size(162, 25);
            this.ufoToggle.TabIndex = 14;
            this.ufoToggle.Toggled += new System.EventHandler(this.toggleSwitch10_Toggled);
            // 
            // OneHToggle
            // 
            this.OneHToggle.Location = new System.Drawing.Point(205, 174);
            this.OneHToggle.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.OneHToggle.Name = "OneHToggle";
            // 
            // 
            // 
            this.OneHToggle.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.OneHToggle.Properties.OffText = "一击必杀 Off";
            this.OneHToggle.Properties.OnText = "一击必杀 On";
            this.OneHToggle.Size = new System.Drawing.Size(162, 25);
            this.OneHToggle.TabIndex = 15;
            this.OneHToggle.Toggled += new System.EventHandler(this.OneHToggle_Toggled);
            // 
            // RoundButn
            // 
            this.RoundButn.Location = new System.Drawing.Point(14, 215);
            this.RoundButn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.RoundButn.Name = "RoundButn";
            // 
            // 
            // 
            this.RoundButn.Properties.MaxLength = 99;
            this.RoundButn.Size = new System.Drawing.Size(117, 20);
            this.RoundButn.TabIndex = 16;
            // 
            // Round
            // 
            this.Round.Location = new System.Drawing.Point(138, 213);
            this.Round.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Round.Name = "Round";
            this.Round.Size = new System.Drawing.Size(149, 25);
            this.Round.TabIndex = 17;
            this.Round.Text = "改变";
            this.Round.CheckedChanged += new System.EventHandler(this.Round_CheckedChanged);
            // 
            // cModelButn
            // 
            this.cModelButn.Location = new System.Drawing.Point(138, 244);
            this.cModelButn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cModelButn.Name = "cModelButn";
            this.cModelButn.Size = new System.Drawing.Size(149, 25);
            this.cModelButn.TabIndex = 19;
            this.cModelButn.Text = "改变模型";
            this.cModelButn.CheckedChanged += new System.EventHandler(this.checkButton2_CheckedChanged);
            // 
            // ModelTXT
            // 
            this.ModelTXT.Location = new System.Drawing.Point(14, 247);
            this.ModelTXT.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ModelTXT.Name = "ModelTXT";
            // 
            // 
            // 
            this.ModelTXT.Properties.MaxLength = 999;
            this.ModelTXT.Size = new System.Drawing.Size(117, 20);
            this.ModelTXT.TabIndex = 18;
            // 
            // CCNButn
            // 
            this.CCNButn.Location = new System.Drawing.Point(138, 276);
            this.CCNButn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CCNButn.Name = "CCNButn";
            this.CCNButn.Size = new System.Drawing.Size(149, 25);
            this.CCNButn.TabIndex = 21;
            this.CCNButn.Text = "改变对战配置名";
            this.CCNButn.CheckedChanged += new System.EventHandler(this.checkButton3_CheckedChanged);
            // 
            // CCNTXT
            // 
            this.CCNTXT.Location = new System.Drawing.Point(14, 278);
            this.CCNTXT.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CCNTXT.Name = "CCNTXT";
            // 
            // 
            // 
            this.CCNTXT.Properties.MaxLength = 99;
            this.CCNTXT.Size = new System.Drawing.Size(117, 20);
            this.CCNTXT.TabIndex = 20;
            // 
            // ZMRCButn
            // 
            this.ZMRCButn.Location = new System.Drawing.Point(387, 13);
            this.ZMRCButn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ZMRCButn.Name = "ZMRCButn";
            this.ZMRCButn.Size = new System.Drawing.Size(149, 25);
            this.ZMRCButn.TabIndex = 22;
            this.ZMRCButn.Text = "僵尸重置";
            this.ZMRCButn.CheckedChanged += new System.EventHandler(this.ZMRCButn_CheckedChanged);
            // 
            // MPRCBtn
            // 
            this.MPRCBtn.Location = new System.Drawing.Point(387, 44);
            this.MPRCBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MPRCBtn.Name = "MPRCBtn";
            this.MPRCBtn.Size = new System.Drawing.Size(149, 25);
            this.MPRCBtn.TabIndex = 23;
            this.MPRCBtn.Text = "多人重置";
            this.MPRCBtn.CheckedChanged += new System.EventHandler(this.checkButton5_CheckedChanged);
            // 
            // MaxZLvl
            // 
            this.MaxZLvl.Location = new System.Drawing.Point(387, 75);
            this.MaxZLvl.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaxZLvl.Name = "MaxZLvl";
            this.MaxZLvl.Size = new System.Drawing.Size(149, 25);
            this.MaxZLvl.TabIndex = 24;
            this.MaxZLvl.Text = "最高僵尸等级";
            this.MaxZLvl.CheckedChanged += new System.EventHandler(this.checkButton6_CheckedChanged);
            // 
            // checkButton7
            // 
            this.checkButton7.Location = new System.Drawing.Point(387, 107);
            this.checkButton7.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.checkButton7.Name = "checkButton7";
            this.checkButton7.Size = new System.Drawing.Size(149, 25);
            this.checkButton7.TabIndex = 25;
            this.checkButton7.Text = "30转生";
            this.checkButton7.CheckedChanged += new System.EventHandler(this.checkButton7_CheckedChanged);
            // 
            // MMButn
            // 
            this.MMButn.Location = new System.Drawing.Point(544, 13);
            this.MMButn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MMButn.Name = "MMButn";
            this.MMButn.Size = new System.Drawing.Size(149, 25);
            this.MMButn.TabIndex = 26;
            this.MMButn.Text = "最高任务小组等级";
            this.MMButn.CheckedChanged += new System.EventHandler(this.checkButton8_CheckedChanged);
            // 
            // CCButn
            // 
            this.CCButn.Location = new System.Drawing.Point(544, 110);
            this.CCButn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CCButn.Name = "CCButn";
            this.CCButn.Size = new System.Drawing.Size(149, 25);
            this.CCButn.TabIndex = 27;
            this.CCButn.Text = "彩色对战配置";
            this.CCButn.CheckedChanged += new System.EventHandler(this.CCButn_CheckedChanged);
            // 
            // MWButn
            // 
            this.MWButn.Location = new System.Drawing.Point(544, 44);
            this.MWButn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MWButn.Name = "MWButn";
            this.MWButn.Size = new System.Drawing.Size(149, 25);
            this.MWButn.TabIndex = 28;
            this.MWButn.Text = "最高武器等级";
            this.MWButn.CheckedChanged += new System.EventHandler(this.checkButton10_CheckedChanged);
            // 
            // IZSButn
            // 
            this.IZSButn.Location = new System.Drawing.Point(544, 75);
            this.IZSButn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.IZSButn.Name = "IZSButn";
            this.IZSButn.Size = new System.Drawing.Size(149, 25);
            this.IZSButn.TabIndex = 29;
            this.IZSButn.Text = "僵尸统计数据";
            this.IZSButn.CheckedChanged += new System.EventHandler(this.checkButton11_CheckedChanged);
            // 
            // ZValue
            // 
            this.ZValue.Location = new System.Drawing.Point(404, 200);
            this.ZValue.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ZValue.Name = "ZValue";
            // 
            // 
            // 
            this.ZValue.Properties.MaxLength = 32767;
            this.ZValue.Size = new System.Drawing.Size(133, 20);
            this.ZValue.TabIndex = 32;
            // 
            // YValue
            // 
            this.YValue.Location = new System.Drawing.Point(404, 169);
            this.YValue.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.YValue.Name = "YValue";
            // 
            // 
            // 
            this.YValue.Properties.MaxLength = 32767;
            this.YValue.Size = new System.Drawing.Size(133, 20);
            this.YValue.TabIndex = 31;
            // 
            // XValue
            // 
            this.XValue.Location = new System.Drawing.Point(404, 138);
            this.XValue.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.XValue.Name = "XValue";
            // 
            // 
            // 
            this.XValue.Properties.MaxLength = 32767;
            this.XValue.Size = new System.Drawing.Size(133, 20);
            this.XValue.TabIndex = 30;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(386, 141);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(9, 14);
            this.labelControl1.TabIndex = 33;
            this.labelControl1.Text = "X";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(386, 171);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(8, 14);
            this.labelControl2.TabIndex = 34;
            this.labelControl2.Text = "Y";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(386, 202);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(7, 14);
            this.labelControl3.TabIndex = 35;
            this.labelControl3.Text = "Z";
            // 
            // tpButn
            // 
            this.tpButn.Location = new System.Drawing.Point(404, 228);
            this.tpButn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tpButn.Name = "tpButn";
            this.tpButn.Size = new System.Drawing.Size(133, 27);
            this.tpButn.TabIndex = 36;
            this.tpButn.Text = "传送";
            this.tpButn.CheckedChanged += new System.EventHandler(this.checkButton12_CheckedChanged);
            // 
            // TeleSPWNButn
            // 
            this.TeleSPWNButn.Location = new System.Drawing.Point(544, 172);
            this.TeleSPWNButn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TeleSPWNButn.Name = "TeleSPWNButn";
            this.TeleSPWNButn.Size = new System.Drawing.Size(149, 25);
            this.TeleSPWNButn.TabIndex = 37;
            this.TeleSPWNButn.Text = "传送到出生点";
            this.TeleSPWNButn.CheckedChanged += new System.EventHandler(this.checkButton13_CheckedChanged);
            // 
            // TelePAPButn
            // 
            this.TelePAPButn.Location = new System.Drawing.Point(544, 201);
            this.TelePAPButn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TelePAPButn.Name = "TelePAPButn";
            this.TelePAPButn.Size = new System.Drawing.Size(149, 25);
            this.TelePAPButn.TabIndex = 38;
            this.TelePAPButn.Text = "传送到PAP";
            this.TelePAPButn.CheckedChanged += new System.EventHandler(this.checkButton14_CheckedChanged);
            // 
            // YTCCButn
            // 
            this.YTCCButn.Location = new System.Drawing.Point(544, 141);
            this.YTCCButn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.YTCCButn.Name = "YTCCButn";
            this.YTCCButn.Size = new System.Drawing.Size(149, 25);
            this.YTCCButn.TabIndex = 39;
            this.YTCCButn.Text = "名字对战配置";
            this.YTCCButn.CheckedChanged += new System.EventHandler(this.checkButton15_CheckedChanged);
            // 
            // Infinite_Warfare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 318);
            this.Controls.Add(this.YTCCButn);
            this.Controls.Add(this.TelePAPButn);
            this.Controls.Add(this.TeleSPWNButn);
            this.Controls.Add(this.tpButn);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.ZValue);
            this.Controls.Add(this.YValue);
            this.Controls.Add(this.XValue);
            this.Controls.Add(this.IZSButn);
            this.Controls.Add(this.MWButn);
            this.Controls.Add(this.CCButn);
            this.Controls.Add(this.MMButn);
            this.Controls.Add(this.checkButton7);
            this.Controls.Add(this.MaxZLvl);
            this.Controls.Add(this.MPRCBtn);
            this.Controls.Add(this.ZMRCButn);
            this.Controls.Add(this.CCNButn);
            this.Controls.Add(this.CCNTXT);
            this.Controls.Add(this.cModelButn);
            this.Controls.Add(this.ModelTXT);
            this.Controls.Add(this.Round);
            this.Controls.Add(this.RoundButn);
            this.Controls.Add(this.OneHToggle);
            this.Controls.Add(this.ufoToggle);
            this.Controls.Add(this.TScaleToggle);
            this.Controls.Add(this.JumpToggle);
            this.Controls.Add(this.RFToggle);
            this.Controls.Add(this.nTargetToggle);
            this.Controls.Add(this.ThirdPToggle);
            this.Controls.Add(this.uNadeToggle);
            this.Controls.Add(this.nRecoilToggle);
            this.Controls.Add(this.Money);
            this.Controls.Add(this.uAmmo);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.GodToggle);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximumSize = new System.Drawing.Size(710, 366);
            this.MinimumSize = new System.Drawing.Size(710, 366);
            this.Name = "Infinite_Warfare";
            this.Text = "Infinite Warfare";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.IW_Closed);
            this.Load += new System.EventHandler(this.Infinite_Warfare_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GodToggle.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uAmmo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Money.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nRecoilToggle.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uNadeToggle.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThirdPToggle.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nTargetToggle.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RFToggle.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.JumpToggle.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TScaleToggle.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ufoToggle.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OneHToggle.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RoundButn.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ModelTXT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CCNTXT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ZValue.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.YValue.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.XValue.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

	}
}
