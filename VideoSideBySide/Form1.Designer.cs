
namespace VideoSideBySide {
	partial class Form1 {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if(disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
			this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.openLeftVideoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.openRightVideoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.playToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.pauseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.stopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
			this.axWindowsMediaPlayer2 = new AxWMPLib.AxWindowsMediaPlayer();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.tableLayoutPanel1.SuspendLayout();
			this.tableLayoutPanel4.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer2)).BeginInit();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 27);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(974, 576);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// openFileDialog2
			// 
			this.openFileDialog2.FileName = "openFileDialog2";
			// 
			// tableLayoutPanel4
			// 
			this.tableLayoutPanel4.ColumnCount = 1;
			this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel1, 0, 1);
			this.tableLayoutPanel4.Controls.Add(this.menuStrip1, 0, 0);
			this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel4.Name = "tableLayoutPanel4";
			this.tableLayoutPanel4.RowCount = 2;
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel4.Size = new System.Drawing.Size(980, 606);
			this.tableLayoutPanel4.TabIndex = 1;
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openLeftVideoToolStripMenuItem,
            this.openRightVideoToolStripMenuItem,
            this.playToolStripMenuItem,
            this.pauseToolStripMenuItem,
            this.stopToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(980, 24);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// openLeftVideoToolStripMenuItem
			// 
			this.openLeftVideoToolStripMenuItem.Name = "openLeftVideoToolStripMenuItem";
			this.openLeftVideoToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
			this.openLeftVideoToolStripMenuItem.Text = "Open left video";
			this.openLeftVideoToolStripMenuItem.Click += new System.EventHandler(this.openLeftVideoToolStripMenuItem_Click);
			// 
			// openRightVideoToolStripMenuItem
			// 
			this.openRightVideoToolStripMenuItem.Name = "openRightVideoToolStripMenuItem";
			this.openRightVideoToolStripMenuItem.Size = new System.Drawing.Size(108, 20);
			this.openRightVideoToolStripMenuItem.Text = "Open right video";
			this.openRightVideoToolStripMenuItem.Click += new System.EventHandler(this.openRightVideoToolStripMenuItem_Click);
			// 
			// playToolStripMenuItem
			// 
			this.playToolStripMenuItem.Name = "playToolStripMenuItem";
			this.playToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
			this.playToolStripMenuItem.Text = "Play";
			this.playToolStripMenuItem.Click += new System.EventHandler(this.playToolStripMenuItem_Click);
			// 
			// pauseToolStripMenuItem
			// 
			this.pauseToolStripMenuItem.Name = "pauseToolStripMenuItem";
			this.pauseToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
			this.pauseToolStripMenuItem.Text = "Pause";
			this.pauseToolStripMenuItem.Click += new System.EventHandler(this.pauseToolStripMenuItem_Click);
			// 
			// stopToolStripMenuItem
			// 
			this.stopToolStripMenuItem.Name = "stopToolStripMenuItem";
			this.stopToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
			this.stopToolStripMenuItem.Text = "Stop";
			this.stopToolStripMenuItem.Click += new System.EventHandler(this.stopToolStripMenuItem_Click);
			// 
			// axWindowsMediaPlayer1
			// 
			this.axWindowsMediaPlayer1.Enabled = true;
			this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(0, 0);
			this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
			this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
			this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(444, 452);
			this.axWindowsMediaPlayer1.TabIndex = 4;
			// 
			// axWindowsMediaPlayer2
			// 
			this.axWindowsMediaPlayer2.Enabled = true;
			this.axWindowsMediaPlayer2.Location = new System.Drawing.Point(0, 0);
			this.axWindowsMediaPlayer2.Name = "axWindowsMediaPlayer2";
			this.axWindowsMediaPlayer2.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer2.OcxState")));
			this.axWindowsMediaPlayer2.Size = new System.Drawing.Size(438, 452);
			this.axWindowsMediaPlayer2.TabIndex = 5;
			// 
			// panel1
			// 
			this.panel1.AutoScroll = true;
			this.panel1.BackColor = System.Drawing.Color.Black;
			this.panel1.Controls.Add(this.axWindowsMediaPlayer1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(3, 3);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(481, 570);
			this.panel1.TabIndex = 6;
			this.panel1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.panel1_Scroll);
			// 
			// panel2
			// 
			this.panel2.AutoScroll = true;
			this.panel2.BackColor = System.Drawing.Color.Black;
			this.panel2.Controls.Add(this.axWindowsMediaPlayer2);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(490, 3);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(481, 570);
			this.panel2.TabIndex = 7;
			this.panel2.Scroll += new System.Windows.Forms.ScrollEventHandler(this.panel2_Scroll);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(980, 606);
			this.Controls.Add(this.tableLayoutPanel4);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Form1";
			this.Text = "Video Side By Side";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel4.ResumeLayout(false);
			this.tableLayoutPanel4.PerformLayout();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer2)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.OpenFileDialog openFileDialog2;
		private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
		private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer2;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem openLeftVideoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem openRightVideoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem playToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem pauseToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem stopToolStripMenuItem;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
	}
}

