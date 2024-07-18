namespace DLL_App
{
    public partial class Interfaz : Form
    {
        //ComboBox Data
        String[] available_types = ["Write", "Read", "Exec"];
        String[] available_ports;

        List<Dictionary<string, dynamic>> commands = new List<Dictionary<string, dynamic>>();

        public Interfaz()
        {
            InitializeComponent();

            //DELETE THIS LATER
            Dictionary<string, dynamic> command1 = new Dictionary<string, dynamic>()
        {
            { "code", "0x01" },
            { "type", "Write" }
        };
            Dictionary<string, dynamic> command2 = new Dictionary<string, dynamic>()
        {
            { "code", "0x02" },
            { "type", "Read" }
        };

            //EDIT LIST WITH REAL DATA
            commands.Add(command1);
            commands.Add(command2);

            available_ports = ["Port1", "Port2", "Port3"];
        }

        private void btnInit_Click(object sender, EventArgs e)
        {

        }

        private void btnOpen_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {

        }

        private void Interfaz_Load(object sender, EventArgs e)
        {
            btnOpen.Enabled = false;
            btnClose.Enabled = false;
            btnSend.Enabled = false;
            combCommands.Enabled = false;

            txtboxResp.Text = "";
            txtboxResp.ReadOnly = true;  

            //Get ComboBox Data Functions
            GetAvailablePorts();
            GetCmdTypes();


        }


        private void GetAvailablePorts()
        {
            for (int i = 0; i < available_ports.Length; i++)
            {
                combPorts.Items.Add(available_ports[i]);
            }
        }

        private void GetCmdTypes()
        {
            for (int i = 0; i < available_types.Length; i++)
            {
                combType.Items.Add(available_types[i]);
            }
        }

        private void combPorts_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnOpen.Enabled = true;
            btnClose.Enabled = true;

            if (combType.SelectedItem != null && combCommands.SelectedItem != null)
            {
                btnSend.Enabled = true;
            }
            else
            {
                btnSend.Enabled = false;
            }

        }

        private void combType_SelectedIndexChanged(object sender, EventArgs e)
        {

            combCommands.Items.Clear();

            string selectedType = combType.SelectedItem.ToString();
            combCommands.Enabled = true;

            foreach (var cmd in commands)
            {
                if (cmd.ContainsKey("code") && cmd["type"] == selectedType)
                {
                    combCommands.Items.Add(cmd["code"]);
                }
            }

            if (combPorts.SelectedItem != null && combCommands.SelectedItem != null)
            {
                btnSend.Enabled = true;
            }
            else
            {
                btnSend.Enabled = false;
            }


        }

        private void combCommands_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combPorts.SelectedItem != null)
            {
                btnSend.Enabled = true;
            }
            else
            {
                btnSend.Enabled = false;
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            byte[] response_bytes = getCommandResponse();
            string response_string = decodeBytes(response_bytes);

            txtboxResp.Text = response_string;

            txtboxResp.Multiline = true;
            txtboxResp.WordWrap = true;
            txtboxResp.Size = new System.Drawing.Size(700, 100);


        }

        private byte[] getCommandResponse()
        {
            //MODIFY ARRAY VALUE LATER
            byte[] response;

            List<byte> result = new List<byte>();
            result.AddRange([0xEE,0x01,0x02,0x03,0x04,0x05,0x06,0xEE]);

            response = result.ToArray();

            return response;
        }

        private string decodeBytes(byte[] bytes)
        {
            string data = "";
            data += "Decoded Data";
            data += Environment.NewLine;
            data += "This is just an Example";
            return data;
        }


    }
}
