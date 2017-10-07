namespace Rochambeau_client
{
	partial class Rochambeau
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rochambeau));
			this.lblServerIp = new System.Windows.Forms.Label();
			this.txtServerIp = new System.Windows.Forms.TextBox();
			this.lblPort = new System.Windows.Forms.Label();
			this.txtPort = new System.Windows.Forms.TextBox();
			this.btnConnect = new System.Windows.Forms.Button();
			this.btn1Rock = new System.Windows.Forms.Button();
			this.btn2Scissors = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.btn3Paper = new System.Windows.Forms.Button();
			this.lblStatus = new System.Windows.Forms.Label();
			this.lblMessage = new System.Windows.Forms.Label();
			this.btnReplay = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblServerIp
			// 
			this.lblServerIp.AutoSize = true;
			this.lblServerIp.Location = new System.Drawing.Point(12, 13);
			this.lblServerIp.Name = "lblServerIp";
			this.lblServerIp.Size = new System.Drawing.Size(54, 13);
			this.lblServerIp.TabIndex = 0;
			this.lblServerIp.Text = "Server IP:";
			// 
			// txtServerIp
			// 
			this.txtServerIp.Location = new System.Drawing.Point(72, 10);
			this.txtServerIp.Name = "txtServerIp";
			this.txtServerIp.Size = new System.Drawing.Size(100, 20);
			this.txtServerIp.TabIndex = 1;
			this.txtServerIp.Text = "192.168.1.2";
			// 
			// lblPort
			// 
			this.lblPort.AutoSize = true;
			this.lblPort.Location = new System.Drawing.Point(193, 13);
			this.lblPort.Name = "lblPort";
			this.lblPort.Size = new System.Drawing.Size(29, 13);
			this.lblPort.TabIndex = 0;
			this.lblPort.Text = "Port:";
			// 
			// txtPort
			// 
			this.txtPort.Location = new System.Drawing.Point(228, 10);
			this.txtPort.Name = "txtPort";
			this.txtPort.Size = new System.Drawing.Size(60, 20);
			this.txtPort.TabIndex = 1;
			this.txtPort.Text = "44111";
			// 
			// btnConnect
			// 
			this.btnConnect.Location = new System.Drawing.Point(331, 8);
			this.btnConnect.Name = "btnConnect";
			this.btnConnect.Size = new System.Drawing.Size(75, 23);
			this.btnConnect.TabIndex = 2;
			this.btnConnect.Text = "Connect";
			this.btnConnect.UseVisualStyleBackColor = true;
			this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
			// 
			// btn1Rock
			// 
			this.btn1Rock.Enabled = false;
			this.btn1Rock.Image = global::Rochambeau_client.Properties.Resources._1_Rock;
			this.btn1Rock.Location = new System.Drawing.Point(12, 64);
			this.btn1Rock.Name = "btn1Rock";
			this.btn1Rock.Size = new System.Drawing.Size(110, 110);
			this.btn1Rock.TabIndex = 3;
			this.btn1Rock.UseVisualStyleBackColor = true;
			this.btn1Rock.Click += new System.EventHandler(this.btn1Rock_Click);
			// 
			// btn2Scissors
			// 
			this.btn2Scissors.Enabled = false;
			this.btn2Scissors.Image = global::Rochambeau_client.Properties.Resources._2_Scissors;
			this.btn2Scissors.Location = new System.Drawing.Point(153, 64);
			this.btn2Scissors.Name = "btn2Scissors";
			this.btn2Scissors.Size = new System.Drawing.Size(110, 110);
			this.btn2Scissors.TabIndex = 3;
			this.btn2Scissors.UseVisualStyleBackColor = true;
			this.btn2Scissors.Click += new System.EventHandler(this.btn2Scissors_Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(296, 64);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(110, 110);
			this.button3.TabIndex = 3;
			this.button3.Text = "button1";
			this.button3.UseVisualStyleBackColor = true;
			// 
			// btn3Paper
			// 
			this.btn3Paper.Enabled = false;
			this.btn3Paper.Image = global::Rochambeau_client.Properties.Resources._3_Paper;
			this.btn3Paper.Location = new System.Drawing.Point(296, 64);
			this.btn3Paper.Name = "btn3Paper";
			this.btn3Paper.Size = new System.Drawing.Size(110, 110);
			this.btn3Paper.TabIndex = 3;
			this.btn3Paper.UseVisualStyleBackColor = true;
			this.btn3Paper.Click += new System.EventHandler(this.btn3Paper_Click);
			// 
			// lblStatus
			// 
			this.lblStatus.AutoSize = true;
			this.lblStatus.Location = new System.Drawing.Point(12, 40);
			this.lblStatus.Name = "lblStatus";
			this.lblStatus.Size = new System.Drawing.Size(0, 13);
			this.lblStatus.TabIndex = 6;
			// 
			// lblMessage
			// 
			this.lblMessage.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.lblMessage.AutoSize = true;
			this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lblMessage.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblMessage.Location = new System.Drawing.Point(17, 186);
			this.lblMessage.Name = "lblMessage";
			this.lblMessage.Size = new System.Drawing.Size(0, 13);
			this.lblMessage.TabIndex = 7;
			this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnReplay
			// 
			this.btnReplay.Location = new System.Drawing.Point(351, 180);
			this.btnReplay.Name = "btnReplay";
			this.btnReplay.Size = new System.Drawing.Size(55, 23);
			this.btnReplay.TabIndex = 8;
			this.btnReplay.Text = "Replay";
			this.btnReplay.UseVisualStyleBackColor = true;
			this.btnReplay.Visible = false;
			this.btnReplay.Click += new System.EventHandler(this.btnReplay_Click);
			// 
			// Rochambeau
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(418, 208);
			this.Controls.Add(this.btnReplay);
			this.Controls.Add(this.lblMessage);
			this.Controls.Add(this.lblStatus);
			this.Controls.Add(this.btn3Paper);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.btn2Scissors);
			this.Controls.Add(this.btn1Rock);
			this.Controls.Add(this.btnConnect);
			this.Controls.Add(this.txtPort);
			this.Controls.Add(this.txtServerIp);
			this.Controls.Add(this.lblPort);
			this.Controls.Add(this.lblServerIp);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Rochambeau";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Rochambeau";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Rochambeau_FormClosing);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblServerIp;
		private System.Windows.Forms.TextBox txtServerIp;
		private System.Windows.Forms.Label lblPort;
		private System.Windows.Forms.TextBox txtPort;
		private System.Windows.Forms.Button btnConnect;
		private System.Windows.Forms.Button btn1Rock;
		private System.Windows.Forms.Button btn2Scissors;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button btn3Paper;
		private System.Windows.Forms.Label lblStatus;
		private System.Windows.Forms.Label lblMessage;
		private System.Windows.Forms.Button btnReplay;
	}
}

