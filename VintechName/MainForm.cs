using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace NewProject
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
        
		public MainForm()
		{
			InitializeComponent();
          
		}

        private void T_button_Ok_Tick(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        public static GraphicsPath RoundedRect(Rectangle baseRect, int radius)
		{
			var diameter = radius * 2;
			var sz = new Size(diameter, diameter);
			var arc = new Rectangle(baseRect.Location, sz);
			var path = new GraphicsPath();
			// Верхний левый угол
			path.AddArc(arc, 180, 90);
			// Верхний правый угол
			arc.X = baseRect.Right - diameter;
			path.AddArc(arc, 270, 90);
			// Нижний правый угол
			arc.Y = baseRect.Bottom - diameter;
			path.AddArc(arc, 0, 90);
			// Нижний левый угол
			arc.X = baseRect.Left;
			path.AddArc(arc, 90, 90);
			path.CloseFigure();
			return path;
		}
		async void MainForm_Load(object sender, EventArgs e)
		{
			this.Region = new Region(
				RoundedRect(
					new Rectangle(0, 0, this.Width, this.Height)
                    , 15
				)
			);
			button_Ok.Region = new Region(
				RoundedRect(
					new Rectangle(0, 0, button_Ok.Width, button_Ok.Height)
                    , 20
				)
			);
			for (Opacity = 0; Opacity < 1; Opacity += .03) {
				await Task.Delay(10);
			}
			
		}
	
		
		void button_Ok_Click(object sender, EventArgs e)
		{
		
			string nameFileDate = DateTime.Now.ToShortDateString();
			string nameFileTime = DateTime.Now.ToLongTimeString();
			string[] nfd = nameFileDate.Split('.');
			string[] nft = nameFileTime.Split(':');
			string NFD;
			string nameAplication;
			button_Ok.Text = "OK";
			if (textBox_thinkess.Text == "") {
				Message mess = new Message();
				var answer = mess.ShowDialog();
				if (answer == DialogResult.OK) {
					textBox_thinkess.Focus();
				}
			} else {
				
				if (nft[0].Length < 2) {
					NFD = nfd[2] + '-' + nfd[1] + '-' + nfd[0] + "--" + nft[0] + nft[1];
				} else {
					NFD = nfd[2] + '-' + nfd[1] + '-' + nfd[0] + '-' + nft[0] + nft[1];
				}			
				nameAplication = textBox_thinkess.Text + " мм  " + NFD + "--.rcam";
				if (Directory.Exists(NFD)) {
					
					button_Ok.Text = "Такая папка уже существует";
					
				} else {
			
					Directory.CreateDirectory(NFD);
					File.Create(NFD + '\\' + nameAplication);
				
					Process.Start(NFD + '\\' + nameAplication);

					Application.Exit();
				}
			}
		}
		void textBox_thinkess_KeyPress(object sender, KeyPressEventArgs e)
		{
	

			char number = e.KeyChar;
			if (textBox_thinkess.Text == "") {
				e.Handled |= !Char.IsDigit(number) && number != 8;
			} else {
				e.Handled |= !Char.IsDigit(number) && number != 8 && number != 44 && number != 46;
			}
			
		}
		void textBox_thinkess_TextChanged(object sender, EventArgs e)
		{
			string str = textBox_thinkess.Text;
            
			string outS = string.Empty;
			bool zapyataya = true;
			foreach (char ch in str)
				if (Char.IsDigit(ch) | Char.IsLetter(ch) || (ch == ',' && zapyataya)) {
					outS += ch;
					if (ch == ',')
						zapyataya = false;
				}
 
			textBox_thinkess.Text = outS;
			textBox_thinkess.SelectionStart = outS.Length;
            
			if (str.Contains(".")) {
				string s = str.Replace(".", ",");
				textBox_thinkess.Clear();
				textBox_thinkess.AppendText(str.Replace(".", ","));
 
			}
		}
		void pictureBox2_Click(object sender, EventArgs e)
		{
			Close();
		}
		void pictureBox2_MouseHover(object sender, EventArgs e)
		{
			pictureBox_Close.Height = 27;
			pictureBox_Close.Width = 27;
			
		}
		void pictureBox_Close_MouseLeave(object sender, EventArgs e)
		{
			pictureBox_Close.Height = 25;
			pictureBox_Close.Width = 25;
			
		}
		void pictureBox_Close_MouseDown(object sender, MouseEventArgs e)
		{
			pictureBox_Close.BorderStyle = BorderStyle.Fixed3D;
			
			pictureBox_Close.Height = 27;
			pictureBox_Close.Width = 27;
		}
		
		
	}
}
