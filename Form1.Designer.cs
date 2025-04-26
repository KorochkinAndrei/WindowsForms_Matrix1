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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}
