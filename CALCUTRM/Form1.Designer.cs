namespace CALCUTRM
{
    public partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtIngMonto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnActu = new System.Windows.Forms.Button();
            this.lblActu = new System.Windows.Forms.Label();
            this.btnConvertir = new System.Windows.Forms.Button();
            this.lblResul = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblActu2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblResul2 = new System.Windows.Forms.Label();
            this.btnConvertir2 = new System.Windows.Forms.Button();
            this.txtIngMonto2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnActu2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtIngMonto
            // 
            this.txtIngMonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIngMonto.Location = new System.Drawing.Point(265, 64);
            this.txtIngMonto.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtIngMonto.Multiline = true;
            this.txtIngMonto.Name = "txtIngMonto";
            this.txtIngMonto.Size = new System.Drawing.Size(202, 30);
            this.txtIngMonto.TabIndex = 0;
            this.txtIngMonto.TextChanged += new System.EventHandler(this.txtIngMonto_TextChanged);
            this.txtIngMonto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtIngMonto_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(281, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "INGRESE LOS DOLARUCOS \r\n           A CONVERTIR";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnActu
            // 
            this.btnActu.Location = new System.Drawing.Point(59, 24);
            this.btnActu.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnActu.Name = "btnActu";
            this.btnActu.Size = new System.Drawing.Size(133, 32);
            this.btnActu.TabIndex = 2;
            this.btnActu.Text = "CONSULTAR TRM";
            this.btnActu.UseVisualStyleBackColor = true;
            this.btnActu.Click += new System.EventHandler(this.btnActu_Click);
            // 
            // lblActu
            // 
            this.lblActu.AutoSize = true;
            this.lblActu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActu.Location = new System.Drawing.Point(7, 5);
            this.lblActu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblActu.Name = "lblActu";
            this.lblActu.Size = new System.Drawing.Size(0, 16);
            this.lblActu.TabIndex = 3;
            this.lblActu.Click += new System.EventHandler(this.lblActu_Click);
            // 
            // btnConvertir
            // 
            this.btnConvertir.Location = new System.Drawing.Point(289, 112);
            this.btnConvertir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnConvertir.Name = "btnConvertir";
            this.btnConvertir.Size = new System.Drawing.Size(160, 30);
            this.btnConvertir.TabIndex = 4;
            this.btnConvertir.Text = "CONVERTIR A PESOS";
            this.btnConvertir.UseVisualStyleBackColor = true;
            this.btnConvertir.Click += new System.EventHandler(this.btnConvertir_Click);
            // 
            // lblResul
            // 
            this.lblResul.AutoSize = true;
            this.lblResul.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResul.Location = new System.Drawing.Point(100, 14);
            this.lblResul.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResul.Name = "lblResul";
            this.lblResul.Size = new System.Drawing.Size(0, 31);
            this.lblResul.TabIndex = 5;
            this.lblResul.Click += new System.EventHandler(this.lblResul_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Green;
            this.groupBox1.Controls.Add(this.lblResul);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 172);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(531, 48);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "RESULTADO:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(-4, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(486, 246);
            this.tabControl1.TabIndex = 8;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Controls.Add(this.btnActu);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.btnConvertir);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txtIngMonto);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage1.Size = new System.Drawing.Size(478, 217);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "DOLAR A PESOS";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox4.Controls.Add(this.lblActu);
            this.groupBox4.Location = new System.Drawing.Point(7, 64);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox4.Size = new System.Drawing.Size(248, 90);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.btnConvertir2);
            this.tabPage2.Controls.Add(this.txtIngMonto2);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.btnActu2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage2.Size = new System.Drawing.Size(528, 217);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "PESOS A DOLAR";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox3.Controls.Add(this.lblActu2);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(7, 64);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox3.Size = new System.Drawing.Size(248, 90);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            // 
            // lblActu2
            // 
            this.lblActu2.AutoSize = true;
            this.lblActu2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActu2.Location = new System.Drawing.Point(7, 5);
            this.lblActu2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblActu2.Name = "lblActu2";
            this.lblActu2.Size = new System.Drawing.Size(0, 16);
            this.lblActu2.TabIndex = 4;
            this.lblActu2.Click += new System.EventHandler(this.lblActu2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.groupBox2.Controls.Add(this.lblResul2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(0, 172);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Size = new System.Drawing.Size(537, 48);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "RESULTADO:";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // lblResul2
            // 
            this.lblResul2.AutoSize = true;
            this.lblResul2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResul2.Location = new System.Drawing.Point(100, 14);
            this.lblResul2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResul2.Name = "lblResul2";
            this.lblResul2.Size = new System.Drawing.Size(0, 31);
            this.lblResul2.TabIndex = 5;
            this.lblResul2.Click += new System.EventHandler(this.lblResul2_Click);
            // 
            // btnConvertir2
            // 
            this.btnConvertir2.Location = new System.Drawing.Point(275, 112);
            this.btnConvertir2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnConvertir2.Name = "btnConvertir2";
            this.btnConvertir2.Size = new System.Drawing.Size(184, 30);
            this.btnConvertir2.TabIndex = 7;
            this.btnConvertir2.Text = "CONVERTIR A DOLARES";
            this.btnConvertir2.UseVisualStyleBackColor = true;
            this.btnConvertir2.Click += new System.EventHandler(this.btnConvertir2_Click);
            // 
            // txtIngMonto2
            // 
            this.txtIngMonto2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIngMonto2.Location = new System.Drawing.Point(265, 64);
            this.txtIngMonto2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtIngMonto2.Multiline = true;
            this.txtIngMonto2.Name = "txtIngMonto2";
            this.txtIngMonto2.Size = new System.Drawing.Size(202, 30);
            this.txtIngMonto2.TabIndex = 6;
            this.txtIngMonto2.TextChanged += new System.EventHandler(this.txtIngMonto2_TextChanged);
            this.txtIngMonto2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtIngMonto2_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(290, 24);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 32);
            this.label2.TabIndex = 5;
            this.label2.Text = "INGRESE LOS PESITOS \r\n       A CONVERTIR";
            // 
            // btnActu2
            // 
            this.btnActu2.Location = new System.Drawing.Point(59, 24);
            this.btnActu2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnActu2.Name = "btnActu2";
            this.btnActu2.Size = new System.Drawing.Size(133, 32);
            this.btnActu2.TabIndex = 3;
            this.btnActu2.Text = "CONSULTAR TRM";
            this.btnActu2.UseVisualStyleBackColor = true;
            this.btnActu2.Click += new System.EventHandler(this.btnActu2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 243);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "CALCULAMESTA";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtIngMonto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnActu;
        private System.Windows.Forms.Label lblActu;
        private System.Windows.Forms.Button btnConvertir;
        private System.Windows.Forms.Label lblResul;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnActu2;
        private System.Windows.Forms.Label lblActu2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblResul2;
        private System.Windows.Forms.Button btnConvertir2;
        private System.Windows.Forms.TextBox txtIngMonto2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
    }
}

