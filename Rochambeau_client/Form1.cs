using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Forms;

namespace Rochambeau_client
{
	public partial class Rochambeau : Form
	{
		TcpClient socketForServer;
		NetworkStream networkStream;
		StreamReader streamReader;
		StreamWriter streamWriter;
		string answer = ""; // server's answer

		public Rochambeau()
		{
			InitializeComponent();
			// setting local IP into  server IP textbox
			txtServerIp.Text = getMyIp().ToString();
		}

		// Connecting to server
		private void btnConnect_Click(object sender, EventArgs e)
		{
  
			try
			{
				// trying to start connection to server
				socketForServer = new TcpClient(txtServerIp.Text.Trim(), int.Parse(txtPort.Text.Trim()));
				// creating stream
				networkStream = socketForServer.GetStream();
				streamReader = new StreamReader(networkStream);
				streamWriter = new StreamWriter(networkStream);
				// showing that we've connected succesfully
				lblStatus.Text = ("Connected to server at " + socketForServer.Client.RemoteEndPoint.ToString());
                // get player name
                GetName();
				// change buttons & boxes accessibility mode 
				btnConnect.Enabled = false;
				txtPort.Enabled = txtServerIp.Enabled = false;
				unblockButtons();

			}
			catch (Exception)
			{
				MessageBox.Show("Failed to connect to server.");
			}
		}

		// Send turn to server
		private void makeTurn(string turn)
		{
			// send turn to server
			try
			{
				streamWriter.WriteLine(turn);
				streamWriter.Flush();
				blockButtons(); // disable turn buttons
			
			// receive server's answer
				lblMessage.Text = "";
				while (true)
				{
					answer = streamReader.ReadLine();
					if (answer != "")
					{
						break;
					}
				}
				MessageBox.Show(answer);
				lblMessage.Text = "New game?";
				unblockButtons();
			}
			catch
			{
				MessageBox.Show("Error in \"makeTurn\" function");
			}
		}

		// block turn buttons
		private void blockButtons()
		{
			btn1Rock.Enabled = btn2Scissors.Enabled = btn3Paper.Enabled = false;

		}

		// unblock turn buttons 
		private void unblockButtons()
		{
			btn1Rock.Enabled = btn2Scissors.Enabled = btn3Paper.Enabled = true;
			//lblMessage.Text = "Make your choice.";
			//btnReplay.Enabled = false;
		}

		private void btn1Rock_Click(object sender, EventArgs e)
		{
			makeTurn("1");
		}

		private void btn2Scissors_Click(object sender, EventArgs e)
		{
			makeTurn("2");
		}

		private void btn3Paper_Click(object sender, EventArgs e)
		{
			makeTurn("3");
		}

		private void Rochambeau_FormClosing(object sender, FormClosingEventArgs e)
		{
			if(streamReader != null) streamReader.Close();
			if (streamWriter != null) streamWriter.Close();
			if (networkStream != null) networkStream.Close();
			if (socketForServer != null) socketForServer.Close();
		}

		private void btnReplay_Click(object sender, EventArgs e)
		{
			unblockButtons();
		}

		private static IPAddress getMyIp()
		{
			IPAddress[] allMyIp = Dns.GetHostAddresses(Dns.GetHostName());
			IPAddress myInetIp = allMyIp[0];
			foreach (IPAddress item in allMyIp)
			{
				if (item.AddressFamily == AddressFamily.InterNetwork)
				{
					myInetIp = item;
				}
			}
			return myInetIp;
		}

        private void GetName()
        {
            try
            {
                // send request "name" to server 
                streamWriter.WriteLine("name");
                streamWriter.Flush();
                // receive answer from server 
                while (true)
                {
                    answer = streamReader.ReadLine();
                    if (answer == null)
                    {
                        break;
                    }
                // set application name
                    this.Text += " - " + answer;
                    // Show hello message
                    MessageBox.Show("Welcome to the Rochambeau, " + answer + "!");
                    break;
                }
            }
            catch
            {
                MessageBox.Show("Failed to get name.");
            }
        }

        private void Rochambeau_Load(object sender, EventArgs e)
        {

        }

	}
}
