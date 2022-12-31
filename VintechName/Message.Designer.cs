/*
 * Создано в SharpDevelop.
 * Пользователь: denis
 * Дата: 30.12.2022
 * Время: 22:31
 * 
 * Для изменения этого шаблона используйте меню "Инструменты | Параметры | Кодирование | Стандартные заголовки".
 */
namespace NewProject
{
	partial class Message
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button button_Ok;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.button_Ok = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.DarkOrange;
			this.panel1.Controls.Add(this.label1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(268, 24);
			this.panel1.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.label1.Location = new System.Drawing.Point(48, 3);
			this.label1.Margin = new System.Windows.Forms.Padding(5);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(72, 24);
			this.label1.TabIndex = 0;
			this.label1.Text = "Ошибка";
			// 
			// button_Ok
			// 
			this.button_Ok.BackColor = System.Drawing.Color.DarkSalmon;
			this.button_Ok.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button_Ok.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.button_Ok.FlatAppearance.BorderSize = 0;
			this.button_Ok.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Salmon;
			this.button_Ok.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Tomato;
			this.button_Ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button_Ok.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button_Ok.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.button_Ok.Location = new System.Drawing.Point(96, 80);
			this.button_Ok.Name = "button_Ok";
			this.button_Ok.Size = new System.Drawing.Size(75, 31);
			this.button_Ok.TabIndex = 1;
			this.button_Ok.Text = "OK";
			this.button_Ok.UseVisualStyleBackColor = false;
			this.button_Ok.Click += new System.EventHandler(this.button_Ok_Click);
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.label2.Location = new System.Drawing.Point(24, 40);
			this.label2.Margin = new System.Windows.Forms.Padding(5);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(216, 24);
			this.label2.TabIndex = 0;
			this.label2.Text = "Нужно указать толщину";
			// 
			// Message
			// 
			this.AcceptButton = this.button_Ok;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LightSalmon;
			this.ClientSize = new System.Drawing.Size(268, 125);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.button_Ok);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Message";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Message";
			this.TopMost = true;
			this.Load += new System.EventHandler(this.Message_Load);
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
	}
}
