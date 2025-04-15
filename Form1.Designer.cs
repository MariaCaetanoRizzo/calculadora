namespace AppAtividadePoo
{
    partial class frmdivisao
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
            this.lblnum1 = new System.Windows.Forms.Label();
            this.lblnum2 = new System.Windows.Forms.Label();
            this.lblresult = new System.Windows.Forms.Label();
            this.txtsoma1 = new System.Windows.Forms.TextBox();
            this.txtsoma2 = new System.Windows.Forms.TextBox();
            this.txtresultado = new System.Windows.Forms.TextBox();
            this.btndividir = new System.Windows.Forms.Button();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.btnsair = new System.Windows.Forms.Button();
            this.btnsomar = new System.Windows.Forms.Button();
            this.btnmultiplicar = new System.Windows.Forms.Button();
            this.btnsubtrair = new System.Windows.Forms.Button();
            this.btnraiz = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblnum1
            // 
            this.lblnum1.AutoSize = true;
            this.lblnum1.BackColor = System.Drawing.Color.LightCyan;
            this.lblnum1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnum1.ForeColor = System.Drawing.Color.IndianRed;
            this.lblnum1.Location = new System.Drawing.Point(49, 42);
            this.lblnum1.Name = "lblnum1";
            this.lblnum1.Size = new System.Drawing.Size(180, 25);
            this.lblnum1.TabIndex = 0;
            this.lblnum1.Text = "Digite um numero";
            // 
            // lblnum2
            // 
            this.lblnum2.AutoSize = true;
            this.lblnum2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnum2.ForeColor = System.Drawing.Color.IndianRed;
            this.lblnum2.Location = new System.Drawing.Point(50, 118);
            this.lblnum2.Name = "lblnum2";
            this.lblnum2.Size = new System.Drawing.Size(176, 24);
            this.lblnum2.TabIndex = 1;
            this.lblnum2.Text = "Digite outro numero";
            this.lblnum2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblresult
            // 
            this.lblresult.AutoSize = true;
            this.lblresult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblresult.ForeColor = System.Drawing.Color.IndianRed;
            this.lblresult.Location = new System.Drawing.Point(50, 191);
            this.lblresult.Name = "lblresult";
            this.lblresult.Size = new System.Drawing.Size(94, 24);
            this.lblresult.TabIndex = 2;
            this.lblresult.Text = "Resultado";
            // 
            // txtsoma1
            // 
            this.txtsoma1.BackColor = System.Drawing.Color.MistyRose;
            this.txtsoma1.Location = new System.Drawing.Point(255, 53);
            this.txtsoma1.Name = "txtsoma1";
            this.txtsoma1.Size = new System.Drawing.Size(364, 20);
            this.txtsoma1.TabIndex = 3;
            this.txtsoma1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtsoma2
            // 
            this.txtsoma2.BackColor = System.Drawing.Color.MistyRose;
            this.txtsoma2.Location = new System.Drawing.Point(252, 126);
            this.txtsoma2.Name = "txtsoma2";
            this.txtsoma2.Size = new System.Drawing.Size(366, 20);
            this.txtsoma2.TabIndex = 4;
            // 
            // txtresultado
            // 
            this.txtresultado.BackColor = System.Drawing.Color.MistyRose;
            this.txtresultado.Enabled = false;
            this.txtresultado.Location = new System.Drawing.Point(173, 191);
            this.txtresultado.Name = "txtresultado";
            this.txtresultado.Size = new System.Drawing.Size(238, 20);
            this.txtresultado.TabIndex = 5;
            this.txtresultado.TextChanged += new System.EventHandler(this.txtresultado_TextChanged);
            // 
            // btndividir
            // 
            this.btndividir.BackColor = System.Drawing.Color.MistyRose;
            this.btndividir.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndividir.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btndividir.Location = new System.Drawing.Point(12, 227);
            this.btndividir.Name = "btndividir";
            this.btndividir.Size = new System.Drawing.Size(147, 70);
            this.btndividir.TabIndex = 6;
            this.btndividir.Text = "DIVIDIR";
            this.btndividir.UseVisualStyleBackColor = false;
            this.btndividir.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // btnlimpar
            // 
            this.btnlimpar.BackColor = System.Drawing.Color.MistyRose;
            this.btnlimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlimpar.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnlimpar.Location = new System.Drawing.Point(366, 298);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(150, 69);
            this.btnlimpar.TabIndex = 7;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.UseVisualStyleBackColor = false;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // btnsair
            // 
            this.btnsair.BackColor = System.Drawing.Color.MistyRose;
            this.btnsair.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsair.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnsair.Location = new System.Drawing.Point(564, 298);
            this.btnsair.Name = "btnsair";
            this.btnsair.Size = new System.Drawing.Size(154, 68);
            this.btnsair.TabIndex = 8;
            this.btnsair.Text = "Sair";
            this.btnsair.UseVisualStyleBackColor = false;
            this.btnsair.Click += new System.EventHandler(this.btnsair_Click);
            // 
            // btnsomar
            // 
            this.btnsomar.BackColor = System.Drawing.Color.MistyRose;
            this.btnsomar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsomar.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnsomar.Location = new System.Drawing.Point(173, 227);
            this.btnsomar.Name = "btnsomar";
            this.btnsomar.Size = new System.Drawing.Size(140, 70);
            this.btnsomar.TabIndex = 9;
            this.btnsomar.Text = "SOMAR";
            this.btnsomar.UseVisualStyleBackColor = false;
            this.btnsomar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnmultiplicar
            // 
            this.btnmultiplicar.BackColor = System.Drawing.Color.MistyRose;
            this.btnmultiplicar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmultiplicar.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnmultiplicar.Location = new System.Drawing.Point(173, 304);
            this.btnmultiplicar.Name = "btnmultiplicar";
            this.btnmultiplicar.Size = new System.Drawing.Size(140, 63);
            this.btnmultiplicar.TabIndex = 10;
            this.btnmultiplicar.Text = "MULTIPLICAR";
            this.btnmultiplicar.UseVisualStyleBackColor = false;
            this.btnmultiplicar.Click += new System.EventHandler(this.btnmultiplicar_Click);
            // 
            // btnsubtrair
            // 
            this.btnsubtrair.BackColor = System.Drawing.Color.MistyRose;
            this.btnsubtrair.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsubtrair.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnsubtrair.Location = new System.Drawing.Point(12, 302);
            this.btnsubtrair.Name = "btnsubtrair";
            this.btnsubtrair.Size = new System.Drawing.Size(147, 63);
            this.btnsubtrair.TabIndex = 11;
            this.btnsubtrair.Text = "SUBTRAIR";
            this.btnsubtrair.UseVisualStyleBackColor = false;
            this.btnsubtrair.Click += new System.EventHandler(this.btnsubtrair_Click);
            // 
            // btnraiz
            // 
            this.btnraiz.BackColor = System.Drawing.Color.MistyRose;
            this.btnraiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnraiz.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnraiz.Location = new System.Drawing.Point(74, 373);
            this.btnraiz.Name = "btnraiz";
            this.btnraiz.Size = new System.Drawing.Size(155, 53);
            this.btnraiz.TabIndex = 12;
            this.btnraiz.Text = "RAIZ";
            this.btnraiz.UseVisualStyleBackColor = false;
            this.btnraiz.Click += new System.EventHandler(this.btnraiz_Click);
            // 
            // frmdivisao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnraiz);
            this.Controls.Add(this.btnsubtrair);
            this.Controls.Add(this.btnmultiplicar);
            this.Controls.Add(this.btnsomar);
            this.Controls.Add(this.btnsair);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.btndividir);
            this.Controls.Add(this.txtresultado);
            this.Controls.Add(this.txtsoma2);
            this.Controls.Add(this.txtsoma1);
            this.Controls.Add(this.lblresult);
            this.Controls.Add(this.lblnum2);
            this.Controls.Add(this.lblnum1);
            this.Name = "frmdivisao";
            this.Text = "Atividade 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblnum1;
        private System.Windows.Forms.Label lblnum2;
        private System.Windows.Forms.Label lblresult;
        private System.Windows.Forms.TextBox txtsoma1;
        private System.Windows.Forms.TextBox txtsoma2;
        private System.Windows.Forms.TextBox txtresultado;
        private System.Windows.Forms.Button btndividir;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.Button btnsair;
        private System.Windows.Forms.Button btnsomar;
        private System.Windows.Forms.Button btnmultiplicar;
        private System.Windows.Forms.Button btnsubtrair;
        private System.Windows.Forms.Button btnraiz;
    }
}

