using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Reflection.Emit;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace NewProject
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();

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
			//Закругление формы
			this.Region = new Region(
				RoundedRect(
					new Rectangle(0, 0, this.Width, this.Height)
					, 15
				)
			);
			//Закругление кнопки
			button_Ok.Region = new Region(
				RoundedRect(
					new Rectangle(0, 0, button_Ok.Width, button_Ok.Height)
					, 20
				)
			);
            
            //Плавная загрузка формы
            for (Opacity = 0; Opacity < 1; Opacity += .02)
			{
				await Task.Delay(10);
			}
		}

		async void button_Ok_Click(object sender, EventArgs e)
		{
			string year = DateTime.Now.Year.ToString();             //Год
			string day = DateTime.Now.Day.ToString();               //День
			string month = DateTime.Now.Month.ToString();           //Месяц
			string hours = DateTime.Now.Hour.ToString();            //Час
			string minutes = DateTime.Now.Minute.ToString();        //Минута		
			string NFD;                                             //Основа имени папки и файла
			string nameDayFolder;                                   //Имя папки дня
			string nameAplication;                                  //Имя для проекта Vintech
			
			bool check = false;                                     //Флаг проверки возможности создания новой папки и файла
            string unit;           // "mm" или "мм"
            string extension;       //расширение файла
			string thickness = ""; 


            if (day.Length == 1)
			{
				day = $"0{day}";
			}
			if (month.Length == 1)
			{
				month = $"0{month}";
			}
			if (minutes.Length == 1)
			{
				minutes = $"0{minutes}";
			}

			button_Ok.Text = "OK";
			if ((textBox_thinkess.Text == "" || comboBox_Cut.Text == "") && !(comboBox_Cut.SelectedIndex == 4))
			{
				Message mess = new Message();
				var answer = mess.ShowDialog();
				if (answer == DialogResult.OK)
				{
					textBox_thinkess.Focus();
				}
			}
			else
			{

				nameDayFolder = $"{year}-{month}-{day}";

				if (hours.Length == 1)
				{
					NFD = $"{nameDayFolder}--{hours}{minutes}";
				}
				else
				{
					NFD = $"{nameDayFolder}-{hours}{minutes}";
				}

                if (textBox_thinkess.Enabled)
                {
                    thickness = textBox_thinkess.Text.Trim();
                }

                //nameAplication = $"{textBox_thinkess.Text} {(comboBox_Cut.SelectedIndex == 3 ? "mm" : "мм")}  {NFD}--{(comboBox_Cut.Text).ToUpper()}.{(comboBox_Cut.SelectedIndex == 3 ? "Dsp" : "rcam")}";
                if (comboBox_Cut.SelectedIndex == 3)
                {
                    unit = "mm";
                    extension = "Dsp";
                }
				else if(comboBox_Cut.SelectedIndex == 4)
				{
					unit = "";
					thickness = "";
					extension = "aucb";
				}
                else
                {
                    unit = "мм";
                    extension = "rcam";
                }

				string cutType = comboBox_Cut.Text.ToUpper();

                nameAplication = $"{thickness} {unit} {NFD}--{cutType}.{extension}";

                if (!Directory.Exists(nameDayFolder))
				{
					Directory.CreateDirectory(nameDayFolder);
				}

				if (Directory.Exists($@"{nameDayFolder}\{NFD}"))
				{

					button_Ok.Enabled = false;
					check = true;
					await Task.Run(async () =>
					{
						while (check)
						{
							int checkNowSec = Convert.ToInt32(DateTime.Now.Second);

							if (checkNowSec == 59)
							{
								check = false;
							}
							button_Ok.Text = $"Такая папка уже существует ({60 - checkNowSec} сек.)";
							await Task.Delay(1000);

						}
						button_Ok.Text = "OK";
						button_Ok.Enabled = true;
					});

				}
				else
				{

					Directory.CreateDirectory($@"{nameDayFolder}\{NFD}");
					File.Create($@"{nameDayFolder}\{NFD}\{nameAplication}");
					//Process.Start($@"{nameDayFolder}\{NFD}\{nameAplication}");
					Application.Exit();
				}
			}
		}
		void textBox_thinkess_KeyPress(object sender, KeyPressEventArgs e)
		{
			char number = e.KeyChar;
			if (textBox_thinkess.Text == "")
			{
				e.Handled |= !Char.IsDigit(number) && number != 8;
			}
			else
			{
				e.Handled |= !Char.IsDigit(number) && number != 8 && number != 44 && number != 46;
			}
		}
		void textBox_thinkess_TextChanged(object sender, EventArgs e)
		{
			string str = textBox_thinkess.Text;
			string outS = string.Empty;
			bool comma = true;
			foreach (char ch in str)
				if (Char.IsDigit(ch) | Char.IsLetter(ch) || (ch == ',' && comma))
				{
					outS += ch;
					if (ch == ',')
						comma = false;
				}

			textBox_thinkess.Text = outS;
			textBox_thinkess.SelectionStart = outS.Length;

			if (str.Contains("."))
			{
                _ = str.Replace(".", ",");
                textBox_thinkess.Clear();
				textBox_thinkess.AppendText(str.Replace(".", ","));
			}
		}
		void pictureBox2_Click(object sender, EventArgs e)
		{
			Close();
		}

		void pictureBox_Close_MouseLeave(object sender, EventArgs e)
		{
			pictureBox_Close.Height = 25;
			pictureBox_Close.Width = 25;
			pictureBox_Close.Location = new Point(pictureBox_Close.Location.X + 3, pictureBox_Close.Location.Y + 3);

		}
		void pictureBox_Close_MouseDown(object sender, MouseEventArgs e)
		{
			pictureBox_Close.BorderStyle = BorderStyle.Fixed3D;
			pictureBox_Close.Height = 31;
			pictureBox_Close.Width = 31;
		}

		private void pictureBox_Close_MouseEnter(object sender, EventArgs e)
		{
			pictureBox_Close.Height = 31;
			pictureBox_Close.Width = 31;
			pictureBox_Close.Location = new Point(pictureBox_Close.Location.X - 3, pictureBox_Close.Location.Y - 3);

		}

        private void comboBox_Cut_SelectedIndexChanged(object sender, EventArgs e)
        {
			if (comboBox_Cut.SelectedIndex == 3)
			{
				pictureBox_Vintech.Visible = false;
                pictureBox_Unimach.Visible = false;
                label1.Visible = true;
                label2.Visible = true;
                panel_Top.BackColor = Color.DarkSlateGray;
				pictureBox_Close.BackColor = panel_Top.BackColor;
				pictureBox_Metalix.Visible = true;
			}
			else if (comboBox_Cut.SelectedIndex == 4)
			{
				pictureBox_Vintech.Visible = false;
				pictureBox_Metalix.Visible = false;
				label1.Visible = false;
				label2.Visible = false;
				panel_Top.BackColor = SystemColors.HotTrack;
				pictureBox_Close.BackColor = panel_Top.BackColor;
				pictureBox_Unimach.Visible = true;
			}

			else
			{
				pictureBox_Metalix.Visible = false;
				pictureBox_Unimach.Visible = false;
				label1.Visible = true;
				label2.Visible = true;
				panel_Top.BackColor = SystemColors.HotTrack;
				pictureBox_Close.BackColor = panel_Top.BackColor;
				pictureBox_Vintech.Visible = true;
			}
        }
    }
}
