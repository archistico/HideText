namespace HideText
{
    partial class frmHideText
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHideText));
            this.tbxOriginale = new System.Windows.Forms.TextBox();
            this.tbxSegreto = new System.Windows.Forms.TextBox();
            this.btnCalcola = new System.Windows.Forms.Button();
            this.tbxRisultato = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tbxEstraiOriginale = new System.Windows.Forms.TextBox();
            this.tbxEstraiRisultato = new System.Windows.Forms.TextBox();
            this.tbxEstraiSegreto = new System.Windows.Forms.TextBox();
            this.btnEstrai = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbxOriginale
            // 
            this.tbxOriginale.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxOriginale.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxOriginale.Location = new System.Drawing.Point(3, 23);
            this.tbxOriginale.Multiline = true;
            this.tbxOriginale.Name = "tbxOriginale";
            this.tbxOriginale.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbxOriginale.Size = new System.Drawing.Size(372, 99);
            this.tbxOriginale.TabIndex = 0;
            this.tbxOriginale.Text = "Text that will be used as a base to hide the secret message. It is not visible bu" +
    "t the hidden message will be placed between the characters.";
            // 
            // tbxSegreto
            // 
            this.tbxSegreto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxSegreto.Font = new System.Drawing.Font("Arial", 12F);
            this.tbxSegreto.Location = new System.Drawing.Point(3, 148);
            this.tbxSegreto.Multiline = true;
            this.tbxSegreto.Name = "tbxSegreto";
            this.tbxSegreto.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbxSegreto.Size = new System.Drawing.Size(372, 99);
            this.tbxSegreto.TabIndex = 1;
            this.tbxSegreto.Text = "The password is \"-P@ssWord123-\"";
            // 
            // btnCalcola
            // 
            this.btnCalcola.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCalcola.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcola.Image = global::HideText.Properties.Resources.HideText_32;
            this.btnCalcola.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCalcola.Location = new System.Drawing.Point(3, 253);
            this.btnCalcola.Name = "btnCalcola";
            this.btnCalcola.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnCalcola.Size = new System.Drawing.Size(372, 44);
            this.btnCalcola.TabIndex = 2;
            this.btnCalcola.Text = "Hide";
            this.btnCalcola.UseVisualStyleBackColor = true;
            this.btnCalcola.Click += new System.EventHandler(this.btnCalcola_Click);
            // 
            // tbxRisultato
            // 
            this.tbxRisultato.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxRisultato.Font = new System.Drawing.Font("Arial", 12F);
            this.tbxRisultato.Location = new System.Drawing.Point(3, 323);
            this.tbxRisultato.Multiline = true;
            this.tbxRisultato.Name = "tbxRisultato";
            this.tbxRisultato.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbxRisultato.Size = new System.Drawing.Size(372, 99);
            this.tbxRisultato.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tbxOriginale, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tbxRisultato, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.tbxSegreto, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnCalcola, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(20, 20);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.44481F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.44481F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.11037F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(378, 425);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(10, 53);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(426, 491);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(20);
            this.tabPage1.Size = new System.Drawing.Size(418, 465);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Hide text";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tableLayoutPanel2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(20);
            this.tabPage2.Size = new System.Drawing.Size(418, 465);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Extract";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 15);
            this.label1.Size = new System.Drawing.Size(426, 43);
            this.label1.TabIndex = 6;
            this.label1.Text = "Hide secret with invisible unicode chars";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 3);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(372, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Plain text";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 128);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(372, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Secret";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(3, 303);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(372, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Result - Plain text + secret";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.tbxEstraiOriginale, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.tbxEstraiRisultato, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.tbxEstraiSegreto, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.btnEstrai, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.label6, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.label7, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(20, 20);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 7;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(378, 425);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // tbxEstraiOriginale
            // 
            this.tbxEstraiOriginale.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxEstraiOriginale.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxEstraiOriginale.Location = new System.Drawing.Point(3, 198);
            this.tbxEstraiOriginale.Multiline = true;
            this.tbxEstraiOriginale.Name = "tbxEstraiOriginale";
            this.tbxEstraiOriginale.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbxEstraiOriginale.Size = new System.Drawing.Size(372, 99);
            this.tbxEstraiOriginale.TabIndex = 0;
            // 
            // tbxEstraiRisultato
            // 
            this.tbxEstraiRisultato.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxEstraiRisultato.Font = new System.Drawing.Font("Arial", 12F);
            this.tbxEstraiRisultato.Location = new System.Drawing.Point(3, 23);
            this.tbxEstraiRisultato.Multiline = true;
            this.tbxEstraiRisultato.Name = "tbxEstraiRisultato";
            this.tbxEstraiRisultato.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbxEstraiRisultato.Size = new System.Drawing.Size(372, 99);
            this.tbxEstraiRisultato.TabIndex = 3;
            // 
            // tbxEstraiSegreto
            // 
            this.tbxEstraiSegreto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxEstraiSegreto.Font = new System.Drawing.Font("Arial", 12F);
            this.tbxEstraiSegreto.Location = new System.Drawing.Point(3, 323);
            this.tbxEstraiSegreto.Multiline = true;
            this.tbxEstraiSegreto.Name = "tbxEstraiSegreto";
            this.tbxEstraiSegreto.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbxEstraiSegreto.Size = new System.Drawing.Size(372, 99);
            this.tbxEstraiSegreto.TabIndex = 1;
            // 
            // btnEstrai
            // 
            this.btnEstrai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEstrai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstrai.Image = global::HideText.Properties.Resources.HideText_32;
            this.btnEstrai.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEstrai.Location = new System.Drawing.Point(3, 128);
            this.btnEstrai.Name = "btnEstrai";
            this.btnEstrai.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.btnEstrai.Size = new System.Drawing.Size(372, 44);
            this.btnEstrai.TabIndex = 2;
            this.btnEstrai.Text = "Extract";
            this.btnEstrai.UseVisualStyleBackColor = true;
            this.btnEstrai.Click += new System.EventHandler(this.btnEstrai_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(3, 178);
            this.label5.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(372, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Plain text";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(3, 303);
            this.label6.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(372, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Secret";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Location = new System.Drawing.Point(3, 3);
            this.label7.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(372, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Result - Plain text + secret";
            // 
            // frmHideText
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 554);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmHideText";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HideText";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbxOriginale;
        private System.Windows.Forms.TextBox tbxSegreto;
        private System.Windows.Forms.Button btnCalcola;
        private System.Windows.Forms.TextBox tbxRisultato;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox tbxEstraiOriginale;
        private System.Windows.Forms.TextBox tbxEstraiRisultato;
        private System.Windows.Forms.TextBox tbxEstraiSegreto;
        private System.Windows.Forms.Button btnEstrai;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

