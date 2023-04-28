namespace UC11_Login_BD
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBoxUSUARIO = new System.Windows.Forms.TextBox();
            this.textBoxSENHA = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonENTRAR = new System.Windows.Forms.Button();
            this.buttonLIMPAR = new System.Windows.Forms.Button();
            this.buttonCADASTRAR = new System.Windows.Forms.Button();
            this.labelErro = new System.Windows.Forms.Label();
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            this.labelErro2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxUSUARIO
            // 
            this.textBoxUSUARIO.Location = new System.Drawing.Point(94, 95);
            this.textBoxUSUARIO.Name = "textBoxUSUARIO";
            this.textBoxUSUARIO.Size = new System.Drawing.Size(190, 20);
            this.textBoxUSUARIO.TabIndex = 0;
            // 
            // textBoxSENHA
            // 
            this.textBoxSENHA.Location = new System.Drawing.Point(94, 146);
            this.textBoxSENHA.Name = "textBoxSENHA";
            this.textBoxSENHA.PasswordChar = '*';
            this.textBoxSENHA.Size = new System.Drawing.Size(190, 20);
            this.textBoxSENHA.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(91, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Usuário";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(91, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Senha";
            // 
            // buttonENTRAR
            // 
            this.buttonENTRAR.BackColor = System.Drawing.Color.MediumPurple;
            this.buttonENTRAR.FlatAppearance.BorderSize = 0;
            this.buttonENTRAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonENTRAR.Font = new System.Drawing.Font("Kalam", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonENTRAR.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonENTRAR.Image = global::UC11_Login_BD.Properties.Resources.login;
            this.buttonENTRAR.Location = new System.Drawing.Point(82, 220);
            this.buttonENTRAR.Name = "buttonENTRAR";
            this.buttonENTRAR.Size = new System.Drawing.Size(85, 28);
            this.buttonENTRAR.TabIndex = 4;
            this.buttonENTRAR.Text = "Entrar";
            this.buttonENTRAR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonENTRAR.UseVisualStyleBackColor = false;
            this.buttonENTRAR.Click += new System.EventHandler(this.buttonENTRAR_Click);
            // 
            // buttonLIMPAR
            // 
            this.buttonLIMPAR.FlatAppearance.BorderSize = 0;
            this.buttonLIMPAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLIMPAR.Font = new System.Drawing.Font("Kalam", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLIMPAR.ForeColor = System.Drawing.Color.White;
            this.buttonLIMPAR.Image = global::UC11_Login_BD.Properties.Resources.tool;
            this.buttonLIMPAR.Location = new System.Drawing.Point(211, 220);
            this.buttonLIMPAR.Name = "buttonLIMPAR";
            this.buttonLIMPAR.Size = new System.Drawing.Size(86, 28);
            this.buttonLIMPAR.TabIndex = 5;
            this.buttonLIMPAR.Text = "Limpar";
            this.buttonLIMPAR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonLIMPAR.UseVisualStyleBackColor = true;
            this.buttonLIMPAR.Click += new System.EventHandler(this.buttonLIMPAR_Click);
            // 
            // buttonCADASTRAR
            // 
            this.buttonCADASTRAR.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonCADASTRAR.FlatAppearance.BorderSize = 0;
            this.buttonCADASTRAR.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Window;
            this.buttonCADASTRAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCADASTRAR.Font = new System.Drawing.Font("Kalam", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCADASTRAR.ForeColor = System.Drawing.Color.White;
            this.buttonCADASTRAR.Image = global::UC11_Login_BD.Properties.Resources.register;
            this.buttonCADASTRAR.Location = new System.Drawing.Point(132, 303);
            this.buttonCADASTRAR.Name = "buttonCADASTRAR";
            this.buttonCADASTRAR.Size = new System.Drawing.Size(118, 34);
            this.buttonCADASTRAR.TabIndex = 6;
            this.buttonCADASTRAR.Text = "Cadastrar";
            this.buttonCADASTRAR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonCADASTRAR.UseVisualStyleBackColor = false;
            this.buttonCADASTRAR.Click += new System.EventHandler(this.buttonCADASTRAR_Click);
            // 
            // labelErro
            // 
            this.labelErro.AutoSize = true;
            this.labelErro.BackColor = System.Drawing.Color.Black;
            this.labelErro.Font = new System.Drawing.Font("Kalam", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelErro.ForeColor = System.Drawing.Color.Red;
            this.labelErro.Location = new System.Drawing.Point(68, 184);
            this.labelErro.Name = "labelErro";
            this.labelErro.Size = new System.Drawing.Size(245, 22);
            this.labelErro.TabIndex = 7;
            this.labelErro.Text = "Por favor, preencha usuário e/ou senha.";
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CacheAge = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.EnableCaching = false;
            this.mySqlCommand1.Transaction = null;
            // 
            // labelErro2
            // 
            this.labelErro2.AutoSize = true;
            this.labelErro2.BackColor = System.Drawing.Color.Black;
            this.labelErro2.Font = new System.Drawing.Font("Kalam", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelErro2.ForeColor = System.Drawing.Color.Red;
            this.labelErro2.Location = new System.Drawing.Point(114, 184);
            this.labelErro2.Name = "labelErro2";
            this.labelErro2.Size = new System.Drawing.Size(143, 22);
            this.labelErro2.TabIndex = 8;
            this.labelErro2.Text = "Usuário já cadastrado!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BackgroundImage = global::UC11_Login_BD.Properties.Resources.fundo;
            this.ClientSize = new System.Drawing.Size(374, 409);
            this.Controls.Add(this.labelErro2);
            this.Controls.Add(this.labelErro);
            this.Controls.Add(this.buttonCADASTRAR);
            this.Controls.Add(this.buttonLIMPAR);
            this.Controls.Add(this.buttonENTRAR);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxSENHA);
            this.Controls.Add(this.textBoxUSUARIO);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Tela de Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxUSUARIO;
        private System.Windows.Forms.TextBox textBoxSENHA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonENTRAR;
        private System.Windows.Forms.Button buttonLIMPAR;
        private System.Windows.Forms.Button buttonCADASTRAR;
        private System.Windows.Forms.Label labelErro;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private System.Windows.Forms.Label labelErro2;
    }
}

