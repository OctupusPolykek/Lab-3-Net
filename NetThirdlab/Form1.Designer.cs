namespace NetThirdlab
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
            this.Alabel = new System.Windows.Forms.Label();
            this.AX = new System.Windows.Forms.TextBox();
            this.AY = new System.Windows.Forms.TextBox();
            this.AZ = new System.Windows.Forms.TextBox();
            this.BZ = new System.Windows.Forms.TextBox();
            this.BY = new System.Windows.Forms.TextBox();
            this.BX = new System.Windows.Forms.TextBox();
            this.Blabel = new System.Windows.Forms.Label();
            this.SaveV = new System.Windows.Forms.Button();
            this.Calculate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Scalar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Collinearity = new System.Windows.Forms.TextBox();
            this.Reset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Alabel
            // 
            this.Alabel.AutoSize = true;
            this.Alabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Alabel.Location = new System.Drawing.Point(13, 13);
            this.Alabel.Name = "Alabel";
            this.Alabel.Size = new System.Drawing.Size(20, 20);
            this.Alabel.TabIndex = 0;
            this.Alabel.Text = "A";
            // 
            // AX
            // 
            this.AX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AX.Location = new System.Drawing.Point(39, 10);
            this.AX.Name = "AX";
            this.AX.Size = new System.Drawing.Size(19, 26);
            this.AX.TabIndex = 1;
            // 
            // AY
            // 
            this.AY.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AY.Location = new System.Drawing.Point(64, 10);
            this.AY.Name = "AY";
            this.AY.Size = new System.Drawing.Size(19, 26);
            this.AY.TabIndex = 2;
            // 
            // AZ
            // 
            this.AZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AZ.Location = new System.Drawing.Point(89, 10);
            this.AZ.Name = "AZ";
            this.AZ.Size = new System.Drawing.Size(19, 26);
            this.AZ.TabIndex = 3;
            // 
            // BZ
            // 
            this.BZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BZ.Location = new System.Drawing.Point(224, 10);
            this.BZ.Name = "BZ";
            this.BZ.Size = new System.Drawing.Size(19, 26);
            this.BZ.TabIndex = 7;
            // 
            // BY
            // 
            this.BY.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BY.Location = new System.Drawing.Point(199, 10);
            this.BY.Name = "BY";
            this.BY.Size = new System.Drawing.Size(19, 26);
            this.BY.TabIndex = 6;
            // 
            // BX
            // 
            this.BX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BX.Location = new System.Drawing.Point(174, 10);
            this.BX.Name = "BX";
            this.BX.Size = new System.Drawing.Size(19, 26);
            this.BX.TabIndex = 5;
            // 
            // Blabel
            // 
            this.Blabel.AutoSize = true;
            this.Blabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Blabel.Location = new System.Drawing.Point(148, 13);
            this.Blabel.Name = "Blabel";
            this.Blabel.Size = new System.Drawing.Size(20, 20);
            this.Blabel.TabIndex = 4;
            this.Blabel.Text = "B";
            // 
            // SaveV
            // 
            this.SaveV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveV.Location = new System.Drawing.Point(157, 162);
            this.SaveV.Name = "SaveV";
            this.SaveV.Size = new System.Drawing.Size(86, 34);
            this.SaveV.TabIndex = 8;
            this.SaveV.Text = "Решить";
            this.SaveV.UseVisualStyleBackColor = true;
            this.SaveV.Click += new System.EventHandler(this.SaveV_Click);
            // 
            // Calculate
            // 
            this.Calculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Calculate.Location = new System.Drawing.Point(127, 52);
            this.Calculate.Name = "Calculate";
            this.Calculate.ReadOnly = true;
            this.Calculate.Size = new System.Drawing.Size(116, 26);
            this.Calculate.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(13, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "c = (a+a)*b =>";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(46, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "d = ab =>";
            // 
            // Scalar
            // 
            this.Scalar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Scalar.Location = new System.Drawing.Point(127, 84);
            this.Scalar.Name = "Scalar";
            this.Scalar.ReadOnly = true;
            this.Scalar.Size = new System.Drawing.Size(116, 26);
            this.Scalar.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Колинеарны ли векторы:";
            // 
            // Collinearity
            // 
            this.Collinearity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Collinearity.Location = new System.Drawing.Point(192, 117);
            this.Collinearity.Name = "Collinearity";
            this.Collinearity.ReadOnly = true;
            this.Collinearity.Size = new System.Drawing.Size(51, 26);
            this.Collinearity.TabIndex = 14;
            // 
            // Reset
            // 
            this.Reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Reset.Location = new System.Drawing.Point(50, 162);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(100, 34);
            this.Reset.TabIndex = 15;
            this.Reset.Text = "Очистить";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 207);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.Collinearity);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Scalar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Calculate);
            this.Controls.Add(this.SaveV);
            this.Controls.Add(this.BZ);
            this.Controls.Add(this.BY);
            this.Controls.Add(this.BX);
            this.Controls.Add(this.Blabel);
            this.Controls.Add(this.AZ);
            this.Controls.Add(this.AY);
            this.Controls.Add(this.AX);
            this.Controls.Add(this.Alabel);
            this.Name = "Form1";
            this.Text = "Vectors";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Alabel;
        private System.Windows.Forms.TextBox AX;
        private System.Windows.Forms.TextBox AY;
        private System.Windows.Forms.TextBox AZ;
        private System.Windows.Forms.TextBox BZ;
        private System.Windows.Forms.TextBox BY;
        private System.Windows.Forms.TextBox BX;
        private System.Windows.Forms.Label Blabel;
        private System.Windows.Forms.Button SaveV;
        private System.Windows.Forms.TextBox Calculate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Collinearity;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.TextBox Scalar;
    }
}

