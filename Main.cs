using System.Diagnostics;
using System.Text;

namespace WorkshopDownloader
{
    public partial class Main : Form
    {
        private IList<string> rawIDs;
        private IList<string> formattedIDs;
        private string AppID;

        public Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists("gameid.txt"))
            {
                AppID = File.ReadAllLines("gameid.txt")[0];
            }

            rawIDs = new List<string>();
            formattedIDs = new List<string>();

            tb_PID.Text = AppID;


        }

        private void Download_Click(object sender, EventArgs e)
        {
            Download.Enabled = false;

            DirectoryInfo di = new DirectoryInfo("./steamcmd");

            var args = new StringBuilder($"+login anonymous");

            foreach (var item in formattedIDs)
            {
                args.Append($" +workshop_download_item {AppID} {item}");
            }


            var processInfo = new ProcessStartInfo(Path.Join(di.ToString(), "steamcmd.exe"), args.ToString())
            {
                WorkingDirectory = di.ToString(),
            };
            var process = new Process();
            process.StartInfo = processInfo;
            process.Start();

            Download.Enabled = true;
        }

        private void Format_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < links_TB.Lines.Count(); i++)
            {
                rawIDs.Add(links_TB.Lines[i].ToString());
            }

            for (int i = 0; i < rawIDs.Count; i++)
            {
                formattedIDs.Add(rawIDs[i].Split('=')[1]);

                fIds.Items.Add(formattedIDs[i]);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_PID_TextChanged(object sender, EventArgs e)
        {
            File.Delete("gameid.txt");

            using (StreamWriter sw = new("gameid.txt"))
            {
                sw.WriteLine(tb_PID.Text);
            }
        }
    }
}