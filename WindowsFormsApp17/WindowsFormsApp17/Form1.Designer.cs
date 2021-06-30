using System;

namespace WindowsFormsApp17
{
    partial class Form1
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
            //this.label1 = new System.Windows.Forms.Label();
            //this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            //this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            //this.label1.AutoSize = true;
            //this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            //this.label1.Location = new System.Drawing.Point(30, 60);
            //this.label1.Name = "label1";
            //this.label1.Size = new System.Drawing.Size(426, 108);
            //this.label1.TabIndex = 0;
            //this.label1.Text = $"{DateTime.Now.ToShortTimeString()}";
            //this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            //this.panel1.Controls.Add(this.label1);
            //this.panel1.Location = new System.Drawing.Point(153, 107);
            //this.panel1.Name = "panel1";
            //this.panel1.Size = new System.Drawing.Size(488, 232);
            //this.panel1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(713, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 60);
            this.button1.TabIndex = 2;
            this.button1.Text = "Settings";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            //this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            //this.panel1.ResumeLayout(false);
            //this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        //private System.Windows.Forms.Label label1;
        //private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
    }
}

