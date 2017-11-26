using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace Rochambeau_server
{
	public class AsynchIoServer
	{
		// keeps connected player's data
		class Player
		{
			public string name;
			public IPEndPoint endPoint;
			public byte turn;

			public Player() { }

			public Player(string name)
			{
				this.name = name;
			}
		}

		// listening for new connections
		static TcpListener tcpListener = new TcpListener(IPAddress.Any, 44111);
		static Player player1 = new Player("Player 1");
		static Player player2 = new Player("Player 2");

		static void Listeners()
		{
			// add new socket for each client & accept client's connection
			Socket socketForClient = tcpListener.AcceptSocket();
			try
			{
				if (socketForClient.Connected)
				{
					// creating streams for this connection
					NetworkStream networkStream = new NetworkStream(socketForClient);
					StreamWriter streamWriter = new StreamWriter(networkStream);
					StreamReader streamReader = new StreamReader(networkStream);

					if (!bothPlayersRegistered(player1, player2))
					{
						// Adding new player if needed
						Player thePlayer = addNewPlayer(socketForClient.RemoteEndPoint as IPEndPoint, player1, player2);
						// here we recieve client's message.
						while (true)
						{
							// starting to wait for this player's turn
							string theString = streamReader.ReadLine();
							Console.WriteLine("{0} send: {1}", socketForClient.RemoteEndPoint, theString);
							// if this client exit break the loop
							if (theString == "name")
							{
								streamWriter.WriteLine(thePlayer.name);
								streamWriter.Flush();
								Console.WriteLine("Sent name to " + thePlayer.name);
								continue;
							}
							if (theString == null)
							{
								break;
							}

							thePlayer.turn = byte.Parse(theString);
							// processing turn
							while (true)
							{
								if (player1.turn != 0 && player2.turn != 0)
								{
									Console.WriteLine("Sending started to the player " + thePlayer.endPoint);
									string result = gameResult(thePlayer);
									streamWriter.Write(result);
									streamWriter.Flush();
									thePlayer.turn = 0;

									break;
								}
							}

						}
						Console.WriteLine(thePlayer.name + " at " + thePlayer.endPoint.ToString() + " quit the game.");
					}
					// closing streams for this connection
					streamReader.Close();
					streamWriter.Close();
					networkStream.Close();
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine("Error! " + ex.Message);
			}
			finally
			{
				socketForClient.Close();
			}
		}

		// get game result for this player
		private static string gameResult(Player thePlayer)
		{
			if (thePlayer == player1)
			{
				return getResult(player1.turn, player2.turn);
			}
			// else
			return getResult(player2.turn, player1.turn);
		}

		// calculate game result from turns
		private static string getResult(byte myTurn, byte opponentTurn)
		{
			string[,] results = new string[3, 3]{
				{"It's draw! You both chose Rock.",  "You win! Opponent chose Scissors.",   "You lose! Opponent chose Paper."},
				{"You lose! Opponent chose Rock.",   "It's draw! You both chose Scissors.", "You win! Opponent chose Paper." },
				{"You win! Opponent chose Rock.",    "You lose! Opponent chose Scissors.",  "It's draw! You both chose Paper."} };
			return (results[(myTurn - 1), (opponentTurn - 1)] + "\n");
		}

		public static void Main()
		{
			// start listening for connections
			tcpListener.Start();
			Console.WriteLine("Server started at " + getMyIp().ToString() + ". Waiting for connections.");

			// new thread for each client connected (here max = 2)
			int threadCount = 0;
			do
			{
				Thread nextThread = new Thread(new ThreadStart(Listeners));
				nextThread.Start();
				threadCount++;
			} while (threadCount < 2/* this is MAX connections */);

			Console.ReadKey();
		}

		// register new player
		private static Player addNewPlayer(IPEndPoint remoteIpEndPoint, Player player1, Player player2)
		{
			Player player;
			Console.WriteLine("Registering new player...");
			if (player1.endPoint == null)
			{
				player = player1;
			}
			else
			{
				player = player2;
			}
			player.endPoint = remoteIpEndPoint as IPEndPoint;
			Console.WriteLine(String.Format("{0} successfully registered from {1}.", player.name, player.endPoint));
			return player;
		}

		// true if both players have IPEndPoints
		private static bool bothPlayersRegistered(Player player1, Player player2)
		{
			bool result = true ? (player1.endPoint != null && player2.endPoint != null) : false;
			return result;
		}


		// getting my inet IP address
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

	}
}