namespace EntityCodeFirst
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
            this.GridKlijent = new System.Windows.Forms.DataGridView();
            this.GridServis = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtKlijentID = new System.Windows.Forms.TextBox();
            this.btnInsertKlijent = new System.Windows.Forms.Button();
            this.txtRegBroj = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKontakt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtKomentar = new System.Windows.Forms.RichTextBox();
            this.btnUpdateKlijent = new System.Windows.Forms.Button();
            this.btnDeleteKlijent = new System.Windows.Forms.Button();
            this.btnDeleteServis = new System.Windows.Forms.Button();
            this.btnUpdateServis = new System.Windows.Forms.Button();
            this.txtOpisUsluge = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnInsertServis = new System.Windows.Forms.Button();
            this.txtKlijentID2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dateServis = new System.Windows.Forms.DateTimePicker();
            this.GridFilter = new System.Windows.Forms.DataGridView();
            this.btnKlijentiServisa = new System.Windows.Forms.Button();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GridKlijent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridServis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridFilter)).BeginInit();
            this.SuspendLayout();
            // 
            // GridKlijent
            // 
            this.GridKlijent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridKlijent.Location = new System.Drawing.Point(29, 34);
            this.GridKlijent.Name = "GridKlijent";
            this.GridKlijent.RowHeadersWidth = 51;
            this.GridKlijent.RowTemplate.Height = 24;
            this.GridKlijent.Size = new System.Drawing.Size(482, 239);
            this.GridKlijent.TabIndex = 0;
            // 
            // GridServis
            // 
            this.GridServis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridServis.Location = new System.Drawing.Point(29, 293);
            this.GridServis.Name = "GridServis";
            this.GridServis.RowHeadersWidth = 51;
            this.GridServis.RowTemplate.Height = 24;
            this.GridServis.Size = new System.Drawing.Size(482, 248);
            this.GridServis.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(538, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Naziv klijenta";
            // 
            // txtKlijentID
            // 
            this.txtKlijentID.Location = new System.Drawing.Point(541, 53);
            this.txtKlijentID.Name = "txtKlijentID";
            this.txtKlijentID.Size = new System.Drawing.Size(100, 22);
            this.txtKlijentID.TabIndex = 3;
            // 
            // btnInsertKlijent
            // 
            this.btnInsertKlijent.Location = new System.Drawing.Point(674, 46);
            this.btnInsertKlijent.Name = "btnInsertKlijent";
            this.btnInsertKlijent.Size = new System.Drawing.Size(75, 36);
            this.btnInsertKlijent.TabIndex = 4;
            this.btnInsertKlijent.Text = "Insert";
            this.btnInsertKlijent.UseVisualStyleBackColor = true;
            this.btnInsertKlijent.Click += new System.EventHandler(this.btnInsertKlijent_Click);
            // 
            // txtRegBroj
            // 
            this.txtRegBroj.Location = new System.Drawing.Point(541, 107);
            this.txtRegBroj.Name = "txtRegBroj";
            this.txtRegBroj.Size = new System.Drawing.Size(100, 22);
            this.txtRegBroj.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(538, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Registarski broj";
            // 
            // txtKontakt
            // 
            this.txtKontakt.Location = new System.Drawing.Point(541, 151);
            this.txtKontakt.Name = "txtKontakt";
            this.txtKontakt.Size = new System.Drawing.Size(100, 22);
            this.txtKontakt.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(538, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Kontakt";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(538, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Dodatni komentar";
            // 
            // txtKomentar
            // 
            this.txtKomentar.Location = new System.Drawing.Point(541, 195);
            this.txtKomentar.Name = "txtKomentar";
            this.txtKomentar.Size = new System.Drawing.Size(208, 78);
            this.txtKomentar.TabIndex = 11;
            this.txtKomentar.Text = "";
            // 
            // btnUpdateKlijent
            // 
            this.btnUpdateKlijent.Location = new System.Drawing.Point(674, 94);
            this.btnUpdateKlijent.Name = "btnUpdateKlijent";
            this.btnUpdateKlijent.Size = new System.Drawing.Size(75, 42);
            this.btnUpdateKlijent.TabIndex = 12;
            this.btnUpdateKlijent.Text = "Update";
            this.btnUpdateKlijent.UseVisualStyleBackColor = true;
            this.btnUpdateKlijent.Click += new System.EventHandler(this.btnUpdateKlijent_Click);
            // 
            // btnDeleteKlijent
            // 
            this.btnDeleteKlijent.Location = new System.Drawing.Point(674, 147);
            this.btnDeleteKlijent.Name = "btnDeleteKlijent";
            this.btnDeleteKlijent.Size = new System.Drawing.Size(75, 42);
            this.btnDeleteKlijent.TabIndex = 13;
            this.btnDeleteKlijent.Text = "Delete";
            this.btnDeleteKlijent.UseVisualStyleBackColor = true;
            this.btnDeleteKlijent.Click += new System.EventHandler(this.btnDeleteKlijent_Click);
            // 
            // btnDeleteServis
            // 
            this.btnDeleteServis.Location = new System.Drawing.Point(674, 412);
            this.btnDeleteServis.Name = "btnDeleteServis";
            this.btnDeleteServis.Size = new System.Drawing.Size(75, 42);
            this.btnDeleteServis.TabIndex = 24;
            this.btnDeleteServis.Text = "Delete";
            this.btnDeleteServis.UseVisualStyleBackColor = true;
            this.btnDeleteServis.Click += new System.EventHandler(this.btnDeleteServis_Click);
            // 
            // btnUpdateServis
            // 
            this.btnUpdateServis.Location = new System.Drawing.Point(674, 359);
            this.btnUpdateServis.Name = "btnUpdateServis";
            this.btnUpdateServis.Size = new System.Drawing.Size(75, 42);
            this.btnUpdateServis.TabIndex = 23;
            this.btnUpdateServis.Text = "Update";
            this.btnUpdateServis.UseVisualStyleBackColor = true;
            this.btnUpdateServis.Click += new System.EventHandler(this.btnUpdateServis_Click);
            // 
            // txtOpisUsluge
            // 
            this.txtOpisUsluge.Location = new System.Drawing.Point(541, 460);
            this.txtOpisUsluge.Name = "txtOpisUsluge";
            this.txtOpisUsluge.Size = new System.Drawing.Size(208, 78);
            this.txtOpisUsluge.TabIndex = 22;
            this.txtOpisUsluge.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(538, 441);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 16);
            this.label5.TabIndex = 21;
            this.label5.Text = "Opis usluge";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(538, 353);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 16);
            this.label7.TabIndex = 17;
            this.label7.Text = "Datum servisa";
            // 
            // btnInsertServis
            // 
            this.btnInsertServis.Location = new System.Drawing.Point(674, 311);
            this.btnInsertServis.Name = "btnInsertServis";
            this.btnInsertServis.Size = new System.Drawing.Size(75, 36);
            this.btnInsertServis.TabIndex = 16;
            this.btnInsertServis.Text = "Insert";
            this.btnInsertServis.UseVisualStyleBackColor = true;
            this.btnInsertServis.Click += new System.EventHandler(this.btnInsertServis_Click);
            // 
            // txtKlijentID2
            // 
            this.txtKlijentID2.Location = new System.Drawing.Point(541, 318);
            this.txtKlijentID2.Name = "txtKlijentID2";
            this.txtKlijentID2.Size = new System.Drawing.Size(100, 22);
            this.txtKlijentID2.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(538, 299);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 16);
            this.label8.TabIndex = 14;
            this.label8.Text = "Klijent ID";
            // 
            // dateServis
            // 
            this.dateServis.Location = new System.Drawing.Point(543, 379);
            this.dateServis.Name = "dateServis";
            this.dateServis.Size = new System.Drawing.Size(98, 22);
            this.dateServis.TabIndex = 25;
            // 
            // GridFilter
            // 
            this.GridFilter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridFilter.Location = new System.Drawing.Point(789, 299);
            this.GridFilter.Name = "GridFilter";
            this.GridFilter.RowHeadersWidth = 51;
            this.GridFilter.RowTemplate.Height = 24;
            this.GridFilter.Size = new System.Drawing.Size(449, 248);
            this.GridFilter.TabIndex = 26;
            // 
            // btnKlijentiServisa
            // 
            this.btnKlijentiServisa.Location = new System.Drawing.Point(1163, 237);
            this.btnKlijentiServisa.Name = "btnKlijentiServisa";
            this.btnKlijentiServisa.Size = new System.Drawing.Size(75, 36);
            this.btnKlijentiServisa.TabIndex = 29;
            this.btnKlijentiServisa.Text = "Prikazi";
            this.btnKlijentiServisa.UseVisualStyleBackColor = true;
            this.btnKlijentiServisa.Click += new System.EventHandler(this.btnKlijentiServisa_Click);
            // 
            // txtFilter
            // 
            this.txtFilter.Location = new System.Drawing.Point(1030, 244);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(100, 22);
            this.txtFilter.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1027, 225);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 16);
            this.label6.TabIndex = 27;
            this.label6.Text = "Klijenti Servisa";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(883, 46);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 30;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1250, 550);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnKlijentiServisa);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.GridFilter);
            this.Controls.Add(this.dateServis);
            this.Controls.Add(this.btnDeleteServis);
            this.Controls.Add(this.btnUpdateServis);
            this.Controls.Add(this.txtOpisUsluge);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnInsertServis);
            this.Controls.Add(this.txtKlijentID2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnDeleteKlijent);
            this.Controls.Add(this.btnUpdateKlijent);
            this.Controls.Add(this.txtKomentar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtKontakt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtRegBroj);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnInsertKlijent);
            this.Controls.Add(this.txtKlijentID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GridServis);
            this.Controls.Add(this.GridKlijent);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridKlijent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridServis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridFilter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GridKlijent;
        private System.Windows.Forms.DataGridView GridServis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKlijentID;
        private System.Windows.Forms.Button btnInsertKlijent;
        private System.Windows.Forms.TextBox txtRegBroj;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKontakt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox txtKomentar;
        private System.Windows.Forms.Button btnUpdateKlijent;
        private System.Windows.Forms.Button btnDeleteKlijent;
        private System.Windows.Forms.Button btnDeleteServis;
        private System.Windows.Forms.Button btnUpdateServis;
        private System.Windows.Forms.RichTextBox txtOpisUsluge;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnInsertServis;
        private System.Windows.Forms.TextBox txtKlijentID2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateServis;
        private System.Windows.Forms.DataGridView GridFilter;
        private System.Windows.Forms.Button btnKlijentiServisa;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnRefresh;
    }
}

