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
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.Graphs = new System.Windows.Forms.ListBox();
            this.MenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btApagar = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.tabIndex = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.polist = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.gbRetas.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.MenuStrip.SuspendLayout();
            this.tabIndex.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
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
            this.gbRetas.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbRetas.Location = new System.Drawing.Point(6, 6);
            this.gbRetas.Name = "gbRetas";
            this.gbRetas.Size = new System.Drawing.Size(226, 121);
            this.gbRetas.TabIndex = 1;
            this.gbRetas.TabStop = false;
            this.gbRetas.Text = "Retas";
            // 
            // rdReta
            // 
            this.rdReta.AutoSize = true;
            this.rdReta.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdReta.Location = new System.Drawing.Point(18, 27);
            this.rdReta.Name = "rdReta";
            this.rdReta.Size = new System.Drawing.Size(158, 21);
            this.rdReta.TabIndex = 0;
            this.rdReta.TabStop = true;
            this.rdReta.Text = "Equação Real da Reta";
            this.rdReta.UseVisualStyleBackColor = true;
            this.rdReta.Click += new System.EventHandler(this.CheckedChanged);
            // 
            // rdBresenham
            // 
            this.rdBresenham.AutoSize = true;
            this.rdBresenham.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdBresenham.ForeColor = System.Drawing.Color.Black;
            this.rdBresenham.Location = new System.Drawing.Point(18, 81);
            this.rdBresenham.Name = "rdBresenham";
            this.rdBresenham.Size = new System.Drawing.Size(91, 21);
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
            this.rdDDA.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdDDA.ForeColor = System.Drawing.Color.Black;
            this.rdDDA.Location = new System.Drawing.Point(18, 54);
            this.rdDDA.Name = "rdDDA";
            this.rdDDA.Size = new System.Drawing.Size(53, 21);
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
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(6, 133);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(226, 143);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Circunferência";
            // 
            // rdCircMed
            // 
            this.rdCircMed.AutoSize = true;
            this.rdCircMed.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdCircMed.ForeColor = System.Drawing.Color.Black;
            this.rdCircMed.Location = new System.Drawing.Point(18, 97);
            this.rdCircMed.Name = "rdCircMed";
            this.rdCircMed.Size = new System.Drawing.Size(102, 21);
            this.rdCircMed.TabIndex = 2;
            this.rdCircMed.TabStop = true;
            this.rdCircMed.Text = "Ponto Médio";
            this.rdCircMed.UseVisualStyleBackColor = true;
            this.rdCircMed.Click += new System.EventHandler(this.CheckedChanged);
            // 
            // rdTrig
            // 
            this.rdTrig.AutoSize = true;
            this.rdTrig.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdTrig.ForeColor = System.Drawing.Color.Black;
            this.rdTrig.Location = new System.Drawing.Point(18, 70);
            this.rdTrig.Name = "rdTrig";
            this.rdTrig.Size = new System.Drawing.Size(108, 21);
            this.rdTrig.TabIndex = 1;
            this.rdTrig.TabStop = true;
            this.rdTrig.Text = "Trigonometria";
            this.rdTrig.UseVisualStyleBackColor = true;
            this.rdTrig.Click += new System.EventHandler(this.CheckedChanged);
            // 
            // rdCirc
            // 
            this.rdCirc.AutoSize = true;
            this.rdCirc.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdCirc.Location = new System.Drawing.Point(18, 27);
            this.rdCirc.Name = "rdCirc";
            this.rdCirc.Size = new System.Drawing.Size(130, 38);
            this.rdCirc.TabIndex = 0;
            this.rdCirc.TabStop = true;
            this.rdCirc.Text = "Equação Real da \r\nCircunferência";
            this.rdCirc.UseVisualStyleBackColor = true;
            this.rdCirc.Click += new System.EventHandler(this.CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdEliMed);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(6, 280);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(226, 70);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Elipse";
            // 
            // rdEliMed
            // 
            this.rdEliMed.AutoSize = true;
            this.rdEliMed.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdEliMed.ForeColor = System.Drawing.Color.Black;
            this.rdEliMed.Location = new System.Drawing.Point(18, 30);
            this.rdEliMed.Name = "rdEliMed";
            this.rdEliMed.Size = new System.Drawing.Size(138, 21);
            this.rdEliMed.TabIndex = 1;
            this.rdEliMed.TabStop = true;
            this.rdEliMed.Text = "Ponto Médio Elipse";
            this.rdEliMed.UseVisualStyleBackColor = true;
            this.rdEliMed.Click += new System.EventHandler(this.CheckedChanged);
            // 
            // Graphs
            // 
            this.Graphs.ContextMenuStrip = this.MenuStrip;
            this.Graphs.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Graphs.FormattingEnabled = true;
            this.Graphs.HorizontalScrollbar = true;
            this.Graphs.ItemHeight = 17;
            this.Graphs.Location = new System.Drawing.Point(6, 381);
            this.Graphs.Name = "Graphs";
            this.Graphs.Size = new System.Drawing.Size(226, 89);
            this.Graphs.TabIndex = 6;
            this.Graphs.SelectedIndexChanged += new System.EventHandler(this.Graphs_SelectedIndexChanged);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 359);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Objetos";
            // 
            // tabIndex
            // 
            this.tabIndex.Controls.Add(this.tabPage2);
            this.tabIndex.Controls.Add(this.tabPage1);
            this.tabIndex.Location = new System.Drawing.Point(688, 12);
            this.tabIndex.Name = "tabIndex";
            this.tabIndex.SelectedIndex = 0;
            this.tabIndex.Size = new System.Drawing.Size(246, 505);
            this.tabIndex.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.gbRetas);
            this.tabPage1.Controls.Add(this.Graphs);
            this.tabPage1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(238, 476);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Algoritmos";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.polist);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(238, 476);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Polígonos";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.numericUpDown2);
            this.groupBox3.Controls.Add(this.numericUpDown1);
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(6, 185);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(226, 115);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Escala";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LimeGreen;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(6, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 37);
            this.button1.TabIndex = 3;
            this.button1.Text = "Novo";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(122, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 37);
            this.button2.TabIndex = 4;
            this.button2.Text = "Apagar";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // polist
            // 
            this.polist.ContextMenuStrip = this.MenuStrip;
            this.polist.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.polist.FormattingEnabled = true;
            this.polist.HorizontalScrollbar = true;
            this.polist.ItemHeight = 17;
            this.polist.Location = new System.Drawing.Point(6, 49);
            this.polist.Name = "polist";
            this.polist.Size = new System.Drawing.Size(226, 89);
            this.polist.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(230, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "_____________________________________";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LimeGreen;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(6, 82);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(214, 27);
            this.button3.TabIndex = 9;
            this.button3.Text = "OK";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(64, 53);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(45, 23);
            this.numericUpDown1.TabIndex = 10;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(115, 53);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(45, 23);
            this.numericUpDown2.TabIndex = 11;
            this.numericUpDown2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown2.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // FMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(946, 528);
            this.Controls.Add(this.tabIndex);
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
            this.tabIndex.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ListBox Graphs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem btApagar;
        private System.Windows.Forms.TabControl tabIndex;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox polist;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
    }
}

