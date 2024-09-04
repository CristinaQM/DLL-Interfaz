using AmiDLL;
using System.IO.Ports;
using System.Reflection;

namespace DLL_App
{
	public partial class Interfaz : Form
	{
		readonly string[] BaudRates = ["1200", "2400", "4800", "9600", "19200", "38400", "57600", "115200", "460800", "921600", "230400"];

		EzmAmi? ezmAmi = null;

		readonly string[] Commands = [
			"GetMacAddress",
			"GetMCU",
			"GetFirmwareVersion",
			"GetHardwareVersion",
			"GetErrorFlags",
			"ExecReset",
			"GetAssemblyPartNumber",
			"GetSerialNumber",
			"GetDateCode",
			"GetFccId",
			"GetIcId",
			"GetVoltage",
			"GetTemperature",
			"GetICCID",
			"ExecRestoreFactory",
			"GetCustomerPassword",
			"GetReaderPassword",
			"GetMasterPassword",
			"SetCustomerPassword",
			"SetReaderPassword",
			"SetMasterPassword",
			"ExecResetPassword",
			"GetStReading",
			"SetStReading",
			"GetCellularModemVersion",
			"GetCellularImei",
			"GetCellularFwVersion",
			"GetCellularManufacturer",
			"SetForceCarrier",
			"SetPlmnIdFormat",
			"SetPlmnIdName",
			"SetForceRat",
			"GetCellularRssi",
			"GetCellularCcid",
			"ExecCellularDisableEcho",
			"ExecModuleForceCarrier",
			"ExecCellularModemTurnOn",
			"ExecCellularModemTurnOff",
			"GetLotInfo",
			"ExecBootMode",
			"ExecFactoryMode",
			"ExecQuietMode",
			"ExecEndSession",
			"ExecBackupAddresing",
			"ExecRestoreAddresing",
		];

		public Interfaz()
		{
			InitializeComponent();
		}

		private async void btnOpen_Click(object sender, EventArgs e)
		{
			ezmAmi = new EzmAmi((string)combPorts.SelectedItem, int.Parse((string)combBaudRate.SelectedItem));

			combPorts.Enabled = false;
			combBaudRate.Enabled = false;

			ezmAmi.OpenSerialPort();

			combCommands.Enabled = true;
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			if (ezmAmi != null) ezmAmi.CloseSerialPort();

			ezmAmi = null;
			combPorts.Enabled = true;
			combBaudRate.Enabled = true;


			combCommands.Enabled = false;


			lblParamValue.Visible = false;
			panelParamValue.Visible = false;
			textboxParamValue.Visible = false;

			lblMessages.Text = "";
			txtboxResp.Text = "";

			combCommands.SelectedItem = null;
		}

		private void Interfaz_Load(object sender, EventArgs e)
		{
			btnOpen.Enabled = false;
			btnClose.Enabled = false;
			btnHandshake.Enabled = false;
			btnSend.Enabled = false;
			combCommands.Enabled = false;

			txtboxResp.Text = "";
			txtboxResp.ReadOnly = true;

			txtBoxStatus.Text = "";
			txtBoxStatus.ReadOnly = true;

			lblParamValue.Visible = false;
			panelParamValue.Visible = false;
			textboxParamValue.Visible = false;

			var version = Assembly.GetExecutingAssembly().GetName().Version;
			lblAppVersion.Text = $"{version}";

			combBaudRate.Items.AddRange(BaudRates);
			combCommands.Items.AddRange(Commands);

			combPorts.Select();


			GetAvailablePorts();
		}


		private void GetAvailablePorts()
		{
			combPorts.Items.Clear();

			combPorts.Items.AddRange(SerialPort.GetPortNames());
		}

		private void combPorts_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (combPorts.SelectedItem != null && combBaudRate.SelectedItem != null)
			{
				btnOpen.Enabled = true;
				btnClose.Enabled = true;
				btnHandshake.Enabled = true;
			}
		}

		private void combBaudRate_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (combPorts.SelectedItem != null && combBaudRate.SelectedItem != null)
			{
				btnOpen.Enabled = true;
				btnClose.Enabled = true;
				btnHandshake.Enabled = true;
			}
		}

		private void combCommands_SelectedIndexChanged(object sender, EventArgs e)
		{
			lblParamValue.Visible = false;
			panelParamValue.Visible = false;
			textboxParamValue.Visible = false;

			if (combCommands.SelectedItem != null)
			{
				btnSend.Enabled = true;
				if (combCommands.SelectedItem.ToString().StartsWith("Set") ||
					(new List<string> { "ExecReset", "ExecOpticalDisable", "SetStReading", "SetMtReading", "ExecEndSessionAndReset",
										"SetForceCarrier", "SetPlmnIdFormat", "SetPlmnIdName", "SetForceRat"}).Contains(combCommands.SelectedItem.ToString()))
				{
					lblParamValue.Visible = true;
					panelParamValue.Visible = true;
					textboxParamValue.Visible = true;
				}
			}
			else
			{
				btnSend.Enabled = false;
			}
		}

		private void btnSend_Click(object sender, EventArgs e)
		{
			txtboxResp.Text = "";
			txtBoxStatus.Text = "";

			dynamic response = getCommandResponse();

			txtboxResp.Text = (response == null) ? "NULL" : response.ToString();
			txtBoxStatus.Text = ezmAmi?.LastStatus().ToString();

			txtboxResp.Multiline = true;
			txtboxResp.WordWrap = true;
			txtboxResp.Size = new System.Drawing.Size(700, 100);
		}

		private dynamic getCommandResponse()
		{
			lblMessages.Text = combCommands.SelectedItem.ToString();

			uint? numericOptionalParameter;

			switch (combCommands.SelectedItem.ToString())
			{
				case "GetMacAddress":
					return ezmAmi.GetMacAddress();
				case "GetMCU":
					return ezmAmi.GetMCU();
				case "GetFirmwareVersion":
					return ezmAmi.GetFirmwareVersion();
				case "GetHardwareVersion":
					return ezmAmi.GetHardwareVersion();
				case "GetErrorFlags":
					return ezmAmi.GetErrorFlags();
				case "ExecReset":
					numericOptionalParameter = textboxParamValue.Text.Length == 0 ? null : uint.Parse(textboxParamValue.Text);
					return ezmAmi.ExecReset((byte?)numericOptionalParameter);
				//case "ExecOpticalDisable":
				//    numericOptionalParameter = textboxParamValue.Text.Length == 0 ? null : uint.Parse(textboxParamValue.Text);
				//    return ezmAmi.ExecOpticalDisable((ushort?)numericOptionalParameter);
				case "GetAssemblyPartNumber":
					return ezmAmi.GetAssemblyPartNumber();
				case "GetSerialNumber":
					return ezmAmi.GetSerialNumber();
				case "GetDateCode":
					return ezmAmi.GetDateCode();
				case "GetFccId":
					return ezmAmi.GetFccId();
				case "GetIcId":
					return ezmAmi.GetIcId();
				case "GetVoltage":
					return ezmAmi.GetVoltage();
				case "GetTemperature":
					return ezmAmi.GetTemperature();
				case "GetICCID":
					return ezmAmi.GetICCID();
				case "ExecRestoreFactory":
					return ezmAmi.ExecRestoreFactory();
				case "GetCustomerPassword":
					return ezmAmi.GetCustomerPassword();
				case "GetReaderPassword":
					return ezmAmi.GetReaderPassword();
				case "GetMasterPassword":
					return ezmAmi.GetMasterPassword();
				case "SetCustomerPassword":
					return ezmAmi.SetCustomerPassword(textboxParamValue.Text);
				case "SetReaderPassword":
					return ezmAmi.SetReaderPassword(textboxParamValue.Text);
				case "SetMasterPassword":
					return ezmAmi.SetMasterPassword(textboxParamValue.Text);
				case "ExecResetPassword":
					return ezmAmi.ExecResetPassword();
				case "GetStReading":
					return ezmAmi.GetStReading();
				//case "GetMtReading":
				//    return ezmAmi.GetMtReading();
				case "SetStReading":
					return ezmAmi.SetStReading(byte.Parse(textboxParamValue.Text));
				//case "SetMtReading":
				//    return ezmAmi.SetMtReading(byte.Parse(textboxParamValue.Text));
				//case "GetCellularModemModel":
				//    return ezmAmi.GetCellularModemModel();
				case "GetCellularModemVersion":
					return ezmAmi.GetCellularModemVersion();
				case "GetCellularImei":
					return ezmAmi.GetCellularImei();
				case "GetCellularFwVersion":
					return ezmAmi.GetCellularFwVersion();
				//case "GetCellularRat":
				//    return ezmAmi.GetCellularRat();
				case "GetCellularManufacturer":
					return ezmAmi.GetCellularManufacturer();
				case "SetForceCarrier":
					return ezmAmi.SetForceCarrier(uint.Parse(textboxParamValue.Text));
				case "SetPlmnIdFormat":
					return ezmAmi.SetPlmnIdFormat(uint.Parse(textboxParamValue.Text));
				case "SetPlmnIdName":
					return ezmAmi.SetPlmnIdName(textboxParamValue.Text);
				case "SetForceRat":
					return ezmAmi.SetForceRat(sbyte.Parse(textboxParamValue.Text));
				case "GetCellularRssi":
					return ezmAmi.GetCellularRssi();
				case "GetCellularCcid":
					return ezmAmi.GetCellularCcid();
				case "ExecCellularDisableEcho":
					return ezmAmi.ExecCellularDisableEcho();
				case "ExecModuleForceCarrier":
					return ezmAmi.ExecModuleForceCarrier();
				case "ExecCellularModemTurnOn":
					return ezmAmi.ExecCellularModemTurnOn();
				case "ExecCellularModemTurnOff":
					return ezmAmi.ExecCellularModemTurnOff();
				//case "GetWifiMac":
				//    return ezmAmi.GetWifiMac();
				//case "GetWifiTechnology":
				//    return ezmAmi.GetWifiTechnology();
				//case "GetBluetoothMac":
				//    return ezmAmi.GetBluetoothMac();
				//case "GetBluetoothTechnology":
				//    return ezmAmi.GetBluetoothTechnology();
				case "GetLotInfo":
					return ezmAmi.GetLotInfo();
				//case "GetMeterTypeInfo":
				//    return ezmAmi.GetMeterTypeInfo();
				//case "SetLotInfo":
				//    return ezmAmi.SetLotInfo(textboxParamValue.Text);
				//case "SetMeterTypeInfo":
				//    return ezmAmi.SetMeterTypeInfo(textboxParamValue.Text);
				case "ExecBootMode":
					return ezmAmi.ExecBootMode();
				case "ExecFactoryMode":
					return ezmAmi.ExecFactoryMode();
				case "ExecQuietMode":
					return ezmAmi.ExecQuietMode();
				case "ExecEndSession":
					return ezmAmi.ExecEndSession();
				//case "ExecEndSessionAndReset":
				//    numericOptionalParameter = textboxParamValue.Text.Length == 0 ? null : uint.Parse(textboxParamValue.Text);
				//    return ezmAmi.ExecEndSessionAndReset((byte?)numericOptionalParameter);
				//case "SetUtilityTesting":
				//    return ezmAmi.SetUtilityTesting(ushort.Parse(textboxParamValue.Text));
				//case "SetIpActColTesting":
				//    return ezmAmi.SetIpActColTesting(uint.Parse(textboxParamValue.Text));
				//case "SetPortActColTesting":
				//    return ezmAmi.SetPortActColTesting(ushort.Parse(textboxParamValue.Text));
				//case "SetPortMonitorTesting":
				//    return ezmAmi.SetPortMonitorTesting(ushort.Parse(textboxParamValue.Text));
				case "ExecBackupAddresing":
					return ezmAmi.ExecBackupAddresing();
				case "ExecRestoreAddresing":
					return ezmAmi.ExecRestoreAddresing();
			}

			return "";
		}

		private void btnReloadPorts_Click(object sender, EventArgs e)
		{
			GetAvailablePorts();
		}

		private void btnHandshake_Click(object sender, EventArgs e)
		{
			if (ezmAmi.DoHandshake())
			{
				lblMessages.Text = "Handshake completed successfully!";
			}
			else
			{
				lblMessages.Text = "Can't complete handshake. Maybe it has been done before?";
			}
		}

		private void btnDefaultAddressing_Click(object sender, EventArgs e)
		{
			if (ezmAmi.SetDefaultAddressing() == AmiDLL.Enums.Status.OK)
			{
				lblMessages.Text = "Test configuration set successfully!";
			}
			else
			{
				lblMessages.Text = "Error while setting test configuration";
			}
		}
	}
}
