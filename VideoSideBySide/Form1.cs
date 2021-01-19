using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoSideBySide {
	public partial class Form1 : Form {
		public Form1() {
			InitializeComponent();
		}

		private void openLeftVideoToolStripMenuItem_Click(object sender, EventArgs e) {
			DialogResult result = openFileDialog1.ShowDialog();

			if(result == DialogResult.OK) {
				var ffProbe = new NReco.VideoInfo.FFProbe();
				var videoInfo = ffProbe.GetMediaInfo(openFileDialog1.FileName);

				if(videoInfo.Streams.Length < 1) {
					return;
				}

				axWindowsMediaPlayer1.Size = new Size(videoInfo.Streams[0].Width, videoInfo.Streams[0].Height);

				axWindowsMediaPlayer1.URL = openFileDialog1.FileName;

				axWindowsMediaPlayer1.Ctlcontrols.stop();
			}
		}

		private void openRightVideoToolStripMenuItem_Click(object sender, EventArgs e) {
			DialogResult result = openFileDialog2.ShowDialog();

			if(result == DialogResult.OK) {
				var ffProbe = new NReco.VideoInfo.FFProbe();
				var videoInfo = ffProbe.GetMediaInfo(openFileDialog2.FileName);

				if(videoInfo.Streams.Length < 1) {
					return;
				}

				axWindowsMediaPlayer2.Size = new Size(videoInfo.Streams[0].Width, videoInfo.Streams[0].Height);

				axWindowsMediaPlayer2.URL = openFileDialog2.FileName;

				axWindowsMediaPlayer2.Ctlcontrols.stop();
			}
		}

		private void playToolStripMenuItem_Click(object sender, EventArgs e) {
			axWindowsMediaPlayer1.Ctlcontrols.play();
			axWindowsMediaPlayer2.Ctlcontrols.play();
		}

		private void pauseToolStripMenuItem_Click(object sender, EventArgs e) {
			axWindowsMediaPlayer1.Ctlcontrols.pause();
			axWindowsMediaPlayer2.Ctlcontrols.pause();
		}

		private void stopToolStripMenuItem_Click(object sender, EventArgs e) {
			axWindowsMediaPlayer1.Ctlcontrols.stop();
			axWindowsMediaPlayer2.Ctlcontrols.stop();
		}

		private void panel1_Scroll(object sender, ScrollEventArgs e) {
			if(e.ScrollOrientation == ScrollOrientation.HorizontalScroll) {
				if(panel2.HorizontalScroll.Value != e.NewValue) {
					panel2.HorizontalScroll.Value = e.NewValue;
				}
			} else {
				if(panel2.VerticalScroll.Value != e.NewValue) {
					panel2.VerticalScroll.Value = e.NewValue;
				}
			}
		}

		private void panel2_Scroll(object sender, ScrollEventArgs e) {
			if(e.ScrollOrientation == ScrollOrientation.HorizontalScroll) {
				if(panel1.HorizontalScroll.Value != e.NewValue) {
					panel1.HorizontalScroll.Value = e.NewValue;
				}
			} else {
				if(panel1.VerticalScroll.Value != e.NewValue) {
					panel1.VerticalScroll.Value = e.NewValue;
				}
			}
		}
	}
}
