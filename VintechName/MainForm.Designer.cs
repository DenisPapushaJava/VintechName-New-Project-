/*
 * Создано в SharpDevelop.
 * Пользователь: denis
 * Дата: 30.12.2022
 * Время: 20:36
 * 
 * Для изменения этого шаблона используйте меню "Инструменты | Параметры | Кодирование | Стандартные заголовки".
 */
namespace NewProject
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label_Head;
		private System.Windows.Forms.TextBox textBox_thinkess;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button button_Ok;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pictureBox_Close;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.panel1 = new System.Windows.Forms.Panel();
			this.pictureBox_Close = new System.Windows.Forms.PictureBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label_Head = new System.Windows.Forms.Label();
			this.textBox_thinkess = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.button_Ok = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_Close)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
			this.panel1.Controls.Add(this.pictureBox_Close);
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Controls.Add(this.label_Head);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(300, 40);
			this.panel1.TabIndex = 0;
			// 
			// pictureBox_Close
			// 
			this.pictureBox_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox_Close.BackColor = System.Drawing.SystemColors.HotTrack;
			this.pictureBox_Close.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_Close.BackgroundImage")));
			this.pictureBox_Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBox_Close.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pictureBox_Close.ErrorImage = null;
			this.pictureBox_Close.InitialImage = null;
			this.pictureBox_Close.Location = new System.Drawing.Point(270, 6);
			this.pictureBox_Close.Name = "pictureBox_Close";
			this.pictureBox_Close.Size = new System.Drawing.Size(25, 25);
			this.pictureBox_Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox_Close.TabIndex = 1;
			this.pictureBox_Close.TabStop = false;
			this.pictureBox_Close.Click += new System.EventHandler(this.pictureBox2_Click);
			this.pictureBox_Close.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_Close_MouseDown);
			this.pictureBox_Close.MouseLeave += new System.EventHandler(this.pictureBox_Close_MouseLeave);
			this.pictureBox_Close.MouseHover += new System.EventHandler(this.pictureBox2_MouseHover);
			// 
			// pictureBox1
			// 
			this.pictureBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
			this.pictureBox1.BackColor = System.Drawing.SystemColors.HotTrack;
			this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
			this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pictureBox1.ErrorImage = null;
			this.pictureBox1.InitialImage = null;
			this.pictureBox1.Location = new System.Drawing.Point(160, 8);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(25, 25);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// label_Head
			// 
			this.label_Head.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label_Head.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.label_Head.Location = new System.Drawing.Point(24, 8);
			this.label_Head.Name = "label_Head";
			this.label_Head.Size = new System.Drawing.Size(264, 23);
			this.label_Head.TabIndex = 0;
			this.label_Head.Text = "Новый проект";
			// 
			// textBox_thinkess
			// 
			this.textBox_thinkess.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.textBox_thinkess.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox_thinkess.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox_thinkess.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.textBox_thinkess.Location = new System.Drawing.Point(160, 80);
			this.textBox_thinkess.MaxLength = 3;
			this.textBox_thinkess.Name = "textBox_thinkess";
			this.textBox_thinkess.Size = new System.Drawing.Size(40, 25);
			this.textBox_thinkess.TabIndex = 1;
			this.textBox_thinkess.TextChanged += new System.EventHandler(this.textBox_thinkess_TextChanged);
			this.textBox_thinkess.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_thinkess_KeyPress);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.label1.Location = new System.Drawing.Point(56, 80);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(104, 32);
			this.label1.TabIndex = 0;
			this.label1.Text = "Толщина:";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.label2.Location = new System.Drawing.Point(192, 80);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(40, 32);
			this.label2.TabIndex = 0;
			this.label2.Text = "мм";
			// 
			// button_Ok
			// 
			this.button_Ok.BackColor = System.Drawing.SystemColors.HotTrack;
			this.button_Ok.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button_Ok.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
			this.button_Ok.FlatAppearance.BorderSize = 0;
			this.button_Ok.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
			this.button_Ok.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumBlue;
			this.button_Ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button_Ok.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button_Ok.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.button_Ok.Location = new System.Drawing.Point(64, 136);
			this.button_Ok.Name = "button_Ok";
			this.button_Ok.Size = new System.Drawing.Size(168, 48);
			this.button_Ok.TabIndex = 2;
			this.button_Ok.Text = "OK";
			this.button_Ok.UseVisualStyleBackColor = false;
			this.button_Ok.Click += new System.EventHandler(this.button_Ok_Click);
			// 
			// MainForm
			// 
			this.AcceptButton = this.button_Ok;
			this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.BackColor = System.Drawing.SystemColors.Highlight;
			this.ClientSize = new System.Drawing.Size(300, 200);
			this.ControlBox = false;
			this.Controls.Add(this.button_Ok);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBox_thinkess);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(300, 200);
			this.MinimumSize = new System.Drawing.Size(300, 200);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "NewProject";
			this.TopMost = true;
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_Close)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		}
	}

