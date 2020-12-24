namespace Ejemplo_básico_de_Programación_Concurrente
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelnumber = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbs50 = new System.Windows.Forms.Label();
            this.lbs40 = new System.Windows.Forms.Label();
            this.lbs30 = new System.Windows.Forms.Label();
            this.lbs20 = new System.Windows.Forms.Label();
            this.lbs10 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.labelTime1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(352, 211);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 49);
            this.button1.TabIndex = 0;
            this.button1.Text = "SUMADOR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(385, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Numero";
            // 
            // labelnumber
            // 
            this.labelnumber.AutoSize = true;
            this.labelnumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 100F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelnumber.Location = new System.Drawing.Point(365, 55);
            this.labelnumber.Name = "labelnumber";
            this.labelnumber.Size = new System.Drawing.Size(140, 153);
            this.labelnumber.TabIndex = 2;
            this.labelnumber.Text = "#";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(35, 73);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(166, 187);
            this.button2.TabIndex = 3;
            this.button2.Text = "SECUENCIAL";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(662, 73);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(166, 187);
            this.button3.TabIndex = 4;
            this.button3.Text = "CONCURRENTE";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 277);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Burbuja a 10000";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 301);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Burbuja a 20000";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 326);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Burbuja a 30000";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 350);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Burbuja a 40000";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 374);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Burbuja a 50000";
            // 
            // lbs50
            // 
            this.lbs50.AutoSize = true;
            this.lbs50.Location = new System.Drawing.Point(117, 374);
            this.lbs50.Name = "lbs50";
            this.lbs50.Size = new System.Drawing.Size(25, 13);
            this.lbs50.TabIndex = 14;
            this.lbs50.Text = "___";
            // 
            // lbs40
            // 
            this.lbs40.AutoSize = true;
            this.lbs40.Location = new System.Drawing.Point(117, 350);
            this.lbs40.Name = "lbs40";
            this.lbs40.Size = new System.Drawing.Size(25, 13);
            this.lbs40.TabIndex = 13;
            this.lbs40.Text = "___";
            // 
            // lbs30
            // 
            this.lbs30.AutoSize = true;
            this.lbs30.Location = new System.Drawing.Point(117, 326);
            this.lbs30.Name = "lbs30";
            this.lbs30.Size = new System.Drawing.Size(25, 13);
            this.lbs30.TabIndex = 12;
            this.lbs30.Text = "___";
            // 
            // lbs20
            // 
            this.lbs20.AutoSize = true;
            this.lbs20.Location = new System.Drawing.Point(117, 301);
            this.lbs20.Name = "lbs20";
            this.lbs20.Size = new System.Drawing.Size(25, 13);
            this.lbs20.TabIndex = 11;
            this.lbs20.Text = "___";
            // 
            // lbs10
            // 
            this.lbs10.AutoSize = true;
            this.lbs10.Location = new System.Drawing.Point(117, 277);
            this.lbs10.Name = "lbs10";
            this.lbs10.Size = new System.Drawing.Size(25, 13);
            this.lbs10.TabIndex = 10;
            this.lbs10.Text = "___";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(352, 277);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(166, 49);
            this.button4.TabIndex = 25;
            this.button4.Text = "CREAR ARREGLO";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 423);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "TIEMPO:";
            // 
            // labelTime1
            // 
            this.labelTime1.AutoSize = true;
            this.labelTime1.Location = new System.Drawing.Point(117, 423);
            this.labelTime1.Name = "labelTime1";
            this.labelTime1.Size = new System.Drawing.Size(25, 13);
            this.labelTime1.TabIndex = 27;
            this.labelTime1.Text = "___";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 461);
            this.Controls.Add(this.labelTime1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.lbs50);
            this.Controls.Add(this.lbs40);
            this.Controls.Add(this.lbs30);
            this.Controls.Add(this.lbs20);
            this.Controls.Add(this.lbs10);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.labelnumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelnumber;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbs50;
        private System.Windows.Forms.Label lbs40;
        private System.Windows.Forms.Label lbs30;
        private System.Windows.Forms.Label lbs20;
        private System.Windows.Forms.Label lbs10;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelTime1;
    }
}