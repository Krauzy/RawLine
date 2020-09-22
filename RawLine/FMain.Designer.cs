namespace RawLine
{
    partial class FMain
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
            this.components = new System.ComponentModel.Container();
            this.picBox = new System.Windows.Forms.PictureBox();
            this.gbRetas = new System.Windows.Forms.GroupBox();
            this.rdReta = new System.Windows.Forms.RadioButton();
            this.rdBresenham = new System.Windows.Forms.RadioButton();
            this.rdDDA = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdCircMed = new System.Windows.Forms.RadioButton();
            this.rdTrig = new System.Windows.Forms.RadioButton();
            this.rdCirc = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdEliMed = new System.Windows.Forms.RadioButton();
            this.btAbrir = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.Graphs = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btApagar = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.gbRetas.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.MenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // picBox
            // 
            this.picBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBox.Cursor = System.Windows.Forms.Cursors.Cross;
            this.picBox.Location = new System.Drawing.Point(12, 12);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(670, 505);
            this.picBox.TabIndex = 0;
            this.picBox.TabStop = false;
            this.picBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picBox_MouseDown);
            this.picBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picBox_MouseMove);
            this.picBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picBox_MouseUp);
            // 
            // gbRetas
            // 
            this.gbRetas.Controls.Add(this.rdReta);
            this.gbRetas.Controls.Add(this.rdBresenham);
            this.gbRetas.Controls.Add(this.rdDDA);
            this.gbRetas.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbRetas.Location = new System.Drawing.Point(689, 13);
            this.gbRetas.Name = "gbRetas";
            this.gbRetas.Size = new System.Drawing.Size(245, 121);
            this.gbRetas.TabIndex = 1;
            this.gbRetas.TabStop = false;
            this.gbRetas.Text = "Retas";
            // 
            // rdReta
            // 
            this.rdReta.AutoSize = true;
            this.rdReta.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdReta.Location = new System.Drawing.Point(18, 27);
            this.rdReta.Name = "rdReta";
            this.rdReta.Size = new System.Drawing.Size(156, 20);
            this.rdReta.TabIndex = 0;
            this.rdReta.TabStop = true;
            this.rdReta.Text = "Equação Real da Reta";
            this.rdReta.UseVisualStyleBackColor = true;
            this.rdReta.Click += new System.EventHandler(this.CheckedChanged);
            // 
            // rdBresenham
            // 
            this.rdBresenham.AutoSize = true;
            this.rdBresenham.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdBresenham.ForeColor = System.Drawing.Color.Black;
            this.rdBresenham.Location = new System.Drawing.Point(18, 81);
            this.rdBresenham.Name = "rdBresenham";
            this.rdBresenham.Size = new System.Drawing.Size(91, 20);
            this.rdBresenham.TabIndex = 2;
            this.rdBresenham.TabStop = true;
            this.rdBresenham.Text = "Bresenham";
            this.rdBresenham.UseVisualStyleBackColor = true;
            this.rdBresenham.Click += new System.EventHandler(this.CheckedChanged);
            // 
            // rdDDA
            // 
            this.rdDDA.AutoSize = true;
            this.rdDDA.Checked = true;
            this.rdDDA.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdDDA.ForeColor = System.Drawing.Color.Black;
            this.rdDDA.Location = new System.Drawing.Point(18, 54);
            this.rdDDA.Name = "rdDDA";
            this.rdDDA.Size = new System.Drawing.Size(51, 20);
            this.rdDDA.TabIndex = 1;
            this.rdDDA.TabStop = true;
            this.rdDDA.Text = "DDA";
            this.rdDDA.UseVisualStyleBackColor = true;
            this.rdDDA.Click += new System.EventHandler(this.CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdCircMed);
            this.groupBox1.Controls.Add(this.rdTrig);
            this.groupBox1.Controls.Add(this.rdCirc);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(689, 140);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(245, 143);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Circunferência";
            // 
            // rdCircMed
            // 
            this.rdCircMed.AutoSize = true;
            this.rdCircMed.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdCircMed.ForeColor = System.Drawing.Color.Black;
            this.rdCircMed.Location = new System.Drawing.Point(18, 97);
            this.rdCircMed.Name = "rdCircMed";
            this.rdCircMed.Size = new System.Drawing.Size(100, 20);
            this.rdCircMed.TabIndex = 2;
            this.rdCircMed.TabStop = true;
            this.rdCircMed.Text = "Ponto Médio";
            this.rdCircMed.UseVisualStyleBackColor = true;
            this.rdCircMed.Click += new System.EventHandler(this.CheckedChanged);
            // 
            // rdTrig
            // 
            this.rdTrig.AutoSize = true;
            this.rdTrig.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdTrig.ForeColor = System.Drawing.Color.Black;
            this.rdTrig.Location = new System.Drawing.Point(18, 70);
            this.rdTrig.Name = "rdTrig";
            this.rdTrig.Size = new System.Drawing.Size(107, 20);
            this.rdTrig.TabIndex = 1;
            this.rdTrig.TabStop = true;
            this.rdTrig.Text = "Trigonometria";
            this.rdTrig.UseVisualStyleBackColor = true;
            this.rdTrig.Click += new System.EventHandler(this.CheckedChanged);
            // 
            // rdCirc
            // 
            this.rdCirc.AutoSize = true;
            this.rdCirc.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdCirc.Location = new System.Drawing.Point(18, 27);
            this.rdCirc.Name = "rdCirc";
            this.rdCirc.Size = new System.Drawing.Size(130, 36);
            this.rdCirc.TabIndex = 0;
            this.rdCirc.TabStop = true;
            this.rdCirc.Text = "Equação Real da \r\nCircunferência";
            this.rdCirc.UseVisualStyleBackColor = true;
            this.rdCirc.Click += new System.EventHandler(this.CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdEliMed);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(689, 289);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(245, 70);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Elipse";
            // 
            // rdEliMed
            // 
            this.rdEliMed.AutoSize = true;
            this.rdEliMed.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdEliMed.ForeColor = System.Drawing.Color.Black;
            this.rdEliMed.Location = new System.Drawing.Point(18, 30);
            this.rdEliMed.Name = "rdEliMed";
            this.rdEliMed.Size = new System.Drawing.Size(136, 20);
            this.rdEliMed.TabIndex = 1;
            this.rdEliMed.TabStop = true;
            this.rdEliMed.Text = "Ponto Médio Elipse";
            this.rdEliMed.UseVisualStyleBackColor = true;
            this.rdEliMed.Click += new System.EventHandler(this.CheckedChanged);
            // 
            // btAbrir
            // 
            this.btAbrir.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAbrir.Location = new System.Drawing.Point(266, 234);
            this.btAbrir.Name = "btAbrir";
            this.btAbrir.Size = new System.Drawing.Size(142, 37);
            this.btAbrir.TabIndex = 5;
            this.btAbrir.Text = "Abrir Imagem";
            this.btAbrir.UseVisualStyleBackColor = true;
            this.btAbrir.Click += new System.EventHandler(this.btAbrir_Click);
            // 
            // Graphs
            // 
            this.Graphs.ContextMenuStrip = this.MenuStrip;
            this.Graphs.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Graphs.FormattingEnabled = true;
            this.Graphs.ItemHeight = 17;
            this.Graphs.Location = new System.Drawing.Point(689, 393);
            this.Graphs.Name = "Graphs";
            this.Graphs.Size = new System.Drawing.Size(245, 123);
            this.Graphs.TabIndex = 6;
            this.Graphs.SelectedIndexChanged += new System.EventHandler(this.Graphs_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(688, 373);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Histórico";
            // 
            // MenuStrip
            // 
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btApagar});
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(113, 26);
            this.MenuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.MenuStrip_ItemClicked);
            // 
            // btApagar
            // 
            this.btApagar.Name = "btApagar";
            this.btApagar.Size = new System.Drawing.Size(112, 22);
            this.btApagar.Text = "Apagar";
            // 
            // FMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(946, 528);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Graphs);
            this.Controls.Add(this.btAbrir);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbRetas);
            this.Controls.Add(this.picBox);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RawLine";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FMain_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.gbRetas.ResumeLayout(false);
            this.gbRetas.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.MenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBox;
        private System.Windows.Forms.GroupBox gbRetas;
        private System.Windows.Forms.RadioButton rdBresenham;
        private System.Windows.Forms.RadioButton rdDDA;
        private System.Windows.Forms.RadioButton rdReta;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdCircMed;
        private System.Windows.Forms.RadioButton rdTrig;
        private System.Windows.Forms.RadioButton rdCirc;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdEliMed;
        private System.Windows.Forms.Button btAbrir;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ListBox Graphs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem btApagar;
    }
}

