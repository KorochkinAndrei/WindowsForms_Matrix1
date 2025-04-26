namespace WindowsForms_Matrix1
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
            this.label1 = new System.Windows.Forms.Label();
            this.Box12 = new System.Windows.Forms.TextBox();
            this.Box22 = new System.Windows.Forms.TextBox();
            this.Box32 = new System.Windows.Forms.TextBox();
            this.Box13 = new System.Windows.Forms.TextBox();
            this.Box23 = new System.Windows.Forms.TextBox();
            this.Box33 = new System.Windows.Forms.TextBox();
            this.Box11 = new System.Windows.Forms.TextBox();
            this.Box21 = new System.Windows.Forms.TextBox();
            this.Box31 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.erorr_Mes = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Answer = new System.Windows.Forms.Label();
            this.button_Exit = new System.Windows.Forms.Button();
            this.TBox31 = new System.Windows.Forms.TextBox();
            this.TBox21 = new System.Windows.Forms.TextBox();
            this.TBox11 = new System.Windows.Forms.TextBox();
            this.TBox33 = new System.Windows.Forms.TextBox();
            this.TBox23 = new System.Windows.Forms.TextBox();
            this.TBox13 = new System.Windows.Forms.TextBox();
            this.TBox32 = new System.Windows.Forms.TextBox();
            this.TBox22 = new System.Windows.Forms.TextBox();
            this.TBox12 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.Error_tr = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(27, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите исходную матрицу";
            // 
            // Box12
            // 
            this.Box12.Location = new System.Drawing.Point(132, 100);
            this.Box12.Name = "Box12";
            this.Box12.Size = new System.Drawing.Size(60, 22);
            this.Box12.TabIndex = 1;
            this.Box12.TextChanged += new System.EventHandler(this.TextScan12);
            // 
            // Box22
            // 
            this.Box22.Location = new System.Drawing.Point(132, 150);
            this.Box22.Name = "Box22";
            this.Box22.Size = new System.Drawing.Size(60, 22);
            this.Box22.TabIndex = 2;
            this.Box22.TextChanged += new System.EventHandler(this.TextScan22);
            // 
            // Box32
            // 
            this.Box32.Location = new System.Drawing.Point(132, 200);
            this.Box32.Name = "Box32";
            this.Box32.Size = new System.Drawing.Size(60, 22);
            this.Box32.TabIndex = 3;
            this.Box32.TextChanged += new System.EventHandler(this.TextScan32);
            // 
            // Box13
            // 
            this.Box13.Location = new System.Drawing.Point(232, 100);
            this.Box13.Name = "Box13";
            this.Box13.Size = new System.Drawing.Size(60, 22);
            this.Box13.TabIndex = 4;
            this.Box13.TextChanged += new System.EventHandler(this.TextScan13);
            // 
            // Box23
            // 
            this.Box23.Location = new System.Drawing.Point(232, 150);
            this.Box23.Name = "Box23";
            this.Box23.Size = new System.Drawing.Size(60, 22);
            this.Box23.TabIndex = 5;
            this.Box23.TextChanged += new System.EventHandler(this.TextScan23);
            // 
            // Box33
            // 
            this.Box33.Location = new System.Drawing.Point(232, 200);
            this.Box33.Name = "Box33";
            this.Box33.Size = new System.Drawing.Size(60, 22);
            this.Box33.TabIndex = 6;
            this.Box33.TextChanged += new System.EventHandler(this.TextScan33);
            // 
            // Box11
            // 
            this.Box11.Location = new System.Drawing.Point(32, 100);
            this.Box11.Name = "Box11";
            this.Box11.Size = new System.Drawing.Size(60, 22);
            this.Box11.TabIndex = 7;
            this.Box11.TextChanged += new System.EventHandler(this.TextScan11);
            // 
            // Box21
            // 
            this.Box21.Location = new System.Drawing.Point(32, 150);
            this.Box21.Name = "Box21";
            this.Box21.Size = new System.Drawing.Size(60, 22);
            this.Box21.TabIndex = 8;
            this.Box21.TextChanged += new System.EventHandler(this.TextScan21);
            // 
            // Box31
            // 
            this.Box31.Location = new System.Drawing.Point(32, 200);
            this.Box31.Name = "Box31";
            this.Box31.Size = new System.Drawing.Size(60, 22);
            this.Box31.TabIndex = 9;
            this.Box31.TextChanged += new System.EventHandler(this.TextScan31);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(54, 279);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(221, 51);
            this.button1.TabIndex = 10;
            this.button1.Text = "Найти определитель матрицы";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // erorr_Mes
            // 
            this.erorr_Mes.AutoSize = true;
            this.erorr_Mes.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.erorr_Mes.ForeColor = System.Drawing.Color.Red;
            this.erorr_Mes.Location = new System.Drawing.Point(83, 245);
            this.erorr_Mes.Name = "erorr_Mes";
            this.erorr_Mes.Size = new System.Drawing.Size(0, 22);
            this.erorr_Mes.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(12, 340);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 26);
            this.label2.TabIndex = 12;
            // 
            // Answer
            // 
            this.Answer.AutoSize = true;
            this.Answer.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Answer.Location = new System.Drawing.Point(29, 377);
            this.Answer.Name = "Answer";
            this.Answer.Size = new System.Drawing.Size(0, 22);
            this.Answer.TabIndex = 13;
            // 
            // button_Exit
            // 
            this.button_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Exit.Location = new System.Drawing.Point(699, 409);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(75, 29);
            this.button_Exit.TabIndex = 14;
            this.button_Exit.Text = "Выход";
            this.button_Exit.UseVisualStyleBackColor = true;
            this.button_Exit.Click += new System.EventHandler(this.button_Exit_Click);
            // 
            // TBox31
            // 
            this.TBox31.Enabled = false;
            this.TBox31.Location = new System.Drawing.Point(445, 200);
            this.TBox31.Name = "TBox31";
            this.TBox31.Size = new System.Drawing.Size(60, 22);
            this.TBox31.TabIndex = 23;
            // 
            // TBox21
            // 
            this.TBox21.Enabled = false;
            this.TBox21.Location = new System.Drawing.Point(445, 150);
            this.TBox21.Name = "TBox21";
            this.TBox21.Size = new System.Drawing.Size(60, 22);
            this.TBox21.TabIndex = 22;
            // 
            // TBox11
            // 
            this.TBox11.Enabled = false;
            this.TBox11.Location = new System.Drawing.Point(445, 100);
            this.TBox11.Name = "TBox11";
            this.TBox11.Size = new System.Drawing.Size(60, 22);
            this.TBox11.TabIndex = 21;
            // 
            // TBox33
            // 
            this.TBox33.Enabled = false;
            this.TBox33.Location = new System.Drawing.Point(645, 200);
            this.TBox33.Name = "TBox33";
            this.TBox33.Size = new System.Drawing.Size(60, 22);
            this.TBox33.TabIndex = 20;
            // 
            // TBox23
            // 
            this.TBox23.Enabled = false;
            this.TBox23.Location = new System.Drawing.Point(645, 150);
            this.TBox23.Name = "TBox23";
            this.TBox23.Size = new System.Drawing.Size(60, 22);
            this.TBox23.TabIndex = 19;
            // 
            // TBox13
            // 
            this.TBox13.Enabled = false;
            this.TBox13.Location = new System.Drawing.Point(645, 100);
            this.TBox13.Name = "TBox13";
            this.TBox13.Size = new System.Drawing.Size(60, 22);
            this.TBox13.TabIndex = 18;
            // 
            // TBox32
            // 
            this.TBox32.Enabled = false;
            this.TBox32.Location = new System.Drawing.Point(545, 200);
            this.TBox32.Name = "TBox32";
            this.TBox32.Size = new System.Drawing.Size(60, 22);
            this.TBox32.TabIndex = 17;
            // 
            // TBox22
            // 
            this.TBox22.Enabled = false;
            this.TBox22.Location = new System.Drawing.Point(545, 150);
            this.TBox22.Name = "TBox22";
            this.TBox22.Size = new System.Drawing.Size(60, 22);
            this.TBox22.TabIndex = 16;
            // 
            // TBox12
            // 
            this.TBox12.Enabled = false;
            this.TBox12.Location = new System.Drawing.Point(545, 100);
            this.TBox12.Name = "TBox12";
            this.TBox12.Size = new System.Drawing.Size(60, 22);
            this.TBox12.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(440, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(293, 26);
            this.label3.TabIndex = 24;
            this.label3.Text = "Транспонированная матрица";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(468, 279);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(221, 51);
            this.button2.TabIndex = 25;
            this.button2.Text = "Транспонировать исходную матрицу";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Error_tr
            // 
            this.Error_tr.AutoSize = true;
            this.Error_tr.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Error_tr.ForeColor = System.Drawing.Color.Red;
            this.Error_tr.Location = new System.Drawing.Point(421, 340);
            this.Error_tr.Name = "Error_tr";
            this.Error_tr.Size = new System.Drawing.Size(0, 26);
            this.Error_tr.TabIndex = 26;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Error_tr);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TBox31);
            this.Controls.Add(this.TBox21);
            this.Controls.Add(this.TBox11);
            this.Controls.Add(this.TBox33);
            this.Controls.Add(this.TBox23);
            this.Controls.Add(this.TBox13);
            this.Controls.Add(this.TBox32);
            this.Controls.Add(this.TBox22);
            this.Controls.Add(this.TBox12);
            this.Controls.Add(this.button_Exit);
            this.Controls.Add(this.Answer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.erorr_Mes);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Box31);
            this.Controls.Add(this.Box21);
            this.Controls.Add(this.Box11);
            this.Controls.Add(this.Box33);
            this.Controls.Add(this.Box23);
            this.Controls.Add(this.Box13);
            this.Controls.Add(this.Box32);
            this.Controls.Add(this.Box22);
            this.Controls.Add(this.Box12);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Работа с матрицами 3х3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Box12;
        private System.Windows.Forms.TextBox Box22;
        private System.Windows.Forms.TextBox Box32;
        private System.Windows.Forms.TextBox Box13;
        private System.Windows.Forms.TextBox Box23;
        private System.Windows.Forms.TextBox Box33;
        private System.Windows.Forms.TextBox Box11;
        private System.Windows.Forms.TextBox Box21;
        private System.Windows.Forms.TextBox Box31;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label erorr_Mes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Answer;
        private System.Windows.Forms.Button button_Exit;
        private System.Windows.Forms.TextBox TBox31;
        private System.Windows.Forms.TextBox TBox21;
        private System.Windows.Forms.TextBox TBox11;
        private System.Windows.Forms.TextBox TBox33;
        private System.Windows.Forms.TextBox TBox23;
        private System.Windows.Forms.TextBox TBox13;
        private System.Windows.Forms.TextBox TBox32;
        private System.Windows.Forms.TextBox TBox22;
        private System.Windows.Forms.TextBox TBox12;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label Error_tr;
    }
}
