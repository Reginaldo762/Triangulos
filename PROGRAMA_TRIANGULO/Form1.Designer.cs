namespace PROGRAMA_TRIANGULO
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnverificar = new System.Windows.Forms.Button();
            this.txtlado1 = new System.Windows.Forms.TextBox();
            this.txtlado2 = new System.Windows.Forms.TextBox();
            this.txtlado3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lbresultado = new System.Windows.Forms.Label();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(185, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(463, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "PROGRAMA TRIÂNGULO";
            this.label1.UseWaitCursor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(55, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "LADO 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(55, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "LADO 2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(55, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "LADO 3";
            // 
            // btnverificar
            // 
            this.btnverificar.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnverificar.Location = new System.Drawing.Point(322, 327);
            this.btnverificar.Name = "btnverificar";
            this.btnverificar.Size = new System.Drawing.Size(152, 48);
            this.btnverificar.TabIndex = 4;
            this.btnverificar.Text = "VERIFICAR";
            this.btnverificar.UseVisualStyleBackColor = true;
            this.btnverificar.Click += new System.EventHandler(this.btnverificar_Click);
            // 
            // txtlado1
            // 
            this.txtlado1.Location = new System.Drawing.Point(164, 108);
            this.txtlado1.Name = "txtlado1";
            this.txtlado1.Size = new System.Drawing.Size(100, 23);
            this.txtlado1.TabIndex = 5;
            // 
            // txtlado2
            // 
            this.txtlado2.Location = new System.Drawing.Point(164, 146);
            this.txtlado2.Name = "txtlado2";
            this.txtlado2.Size = new System.Drawing.Size(100, 23);
            this.txtlado2.TabIndex = 6;
            // 
            // txtlado3
            // 
            this.txtlado3.Location = new System.Drawing.Point(164, 184);
            this.txtlado3.Name = "txtlado3";
            this.txtlado3.Size = new System.Drawing.Size(100, 23);
            this.txtlado3.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(55, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 19);
            this.label5.TabIndex = 9;
            this.label5.Text = "RESULTADO";
            // 
            // lbresultado
            // 
            this.lbresultado.AutoSize = true;
            this.lbresultado.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbresultado.Location = new System.Drawing.Point(164, 224);
            this.lbresultado.Name = "lbresultado";
            this.lbresultado.Size = new System.Drawing.Size(60, 28);
            this.lbresultado.TabIndex = 10;
            this.lbresultado.Text = "result";
            // 
            // btnlimpar
            // 
            this.btnlimpar.Location = new System.Drawing.Point(680, 399);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(75, 23);
            this.btnlimpar.TabIndex = 11;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.UseVisualStyleBackColor = true;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.lbresultado);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtlado3);
            this.Controls.Add(this.txtlado2);
            this.Controls.Add(this.txtlado1);
            this.Controls.Add(this.btnverificar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnverificar;
        private TextBox txtlado1;
        private TextBox txtlado2;
        private TextBox txtlado3;
        private Label label5;
        private Label lbresultado;
        private Button btnlimpar;
    }
}