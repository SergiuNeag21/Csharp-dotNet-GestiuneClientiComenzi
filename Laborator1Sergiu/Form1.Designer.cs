namespace Laborator1Sergiu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridClienti = new System.Windows.Forms.DataGridView();
            this.dataGridComenzi = new System.Windows.Forms.DataGridView();
            this.display = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.tbIdComanda = new System.Windows.Forms.TextBox();
            this.tbDataComanda = new System.Windows.Forms.TextBox();
            this.tbTotalComanda = new System.Windows.Forms.TextBox();
            this.tbIdClient = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridClienti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridComenzi)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridClienti
            // 
            this.dataGridClienti.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridClienti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridClienti.Location = new System.Drawing.Point(457, 23);
            this.dataGridClienti.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridClienti.Name = "dataGridClienti";
            this.dataGridClienti.RowHeadersWidth = 51;
            this.dataGridClienti.Size = new System.Drawing.Size(762, 216);
            this.dataGridClienti.TabIndex = 0;
            // 
            // dataGridComenzi
            // 
            this.dataGridComenzi.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridComenzi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridComenzi.Location = new System.Drawing.Point(457, 287);
            this.dataGridComenzi.Name = "dataGridComenzi";
            this.dataGridComenzi.RowHeadersWidth = 51;
            this.dataGridComenzi.RowTemplate.Height = 24;
            this.dataGridComenzi.Size = new System.Drawing.Size(762, 198);
            this.dataGridComenzi.TabIndex = 2;
            // 
            // display
            // 
            this.display.BackColor = System.Drawing.Color.PaleTurquoise;
            this.display.Font = new System.Drawing.Font("Showcard Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.display.Location = new System.Drawing.Point(78, 38);
            this.display.Name = "display";
            this.display.Size = new System.Drawing.Size(207, 39);
            this.display.TabIndex = 3;
            this.display.Text = "Display";
            this.display.UseVisualStyleBackColor = false;
            this.display.Click += new System.EventHandler(this.display_Click);
            // 
            // Delete
            // 
            this.Delete.BackColor = System.Drawing.Color.PaleTurquoise;
            this.Delete.Font = new System.Drawing.Font("Showcard Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete.Location = new System.Drawing.Point(78, 109);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(207, 36);
            this.Delete.TabIndex = 4;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = false;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnAdd.Font = new System.Drawing.Font("Showcard Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(78, 172);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(207, 36);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnUpdate.Font = new System.Drawing.Font("Showcard Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(78, 242);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(207, 36);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // tbIdComanda
            // 
            this.tbIdComanda.Location = new System.Drawing.Point(147, 324);
            this.tbIdComanda.Name = "tbIdComanda";
            this.tbIdComanda.Size = new System.Drawing.Size(123, 22);
            this.tbIdComanda.TabIndex = 7;
            this.tbIdComanda.TextChanged += new System.EventHandler(this.tbIdComanda_TextChanged);
            // 
            // tbDataComanda
            // 
            this.tbDataComanda.Location = new System.Drawing.Point(147, 415);
            this.tbDataComanda.Name = "tbDataComanda";
            this.tbDataComanda.Size = new System.Drawing.Size(123, 22);
            this.tbDataComanda.TabIndex = 8;
            this.tbDataComanda.TextChanged += new System.EventHandler(this.tbDataComanda_TextChanged);
            // 
            // tbTotalComanda
            // 
            this.tbTotalComanda.Location = new System.Drawing.Point(147, 463);
            this.tbTotalComanda.Name = "tbTotalComanda";
            this.tbTotalComanda.Size = new System.Drawing.Size(123, 22);
            this.tbTotalComanda.TabIndex = 9;
            this.tbTotalComanda.TextChanged += new System.EventHandler(this.tbTotalComanda_TextChanged);
            // 
            // tbIdClient
            // 
            this.tbIdClient.Location = new System.Drawing.Point(147, 367);
            this.tbIdClient.Name = "tbIdClient";
            this.tbIdClient.Size = new System.Drawing.Size(123, 22);
            this.tbIdClient.TabIndex = 10;
            this.tbIdClient.TextChanged += new System.EventHandler(this.tbIdClient_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.RoyalBlue;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label1.Location = new System.Drawing.Point(12, 329);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "ID Comanda:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.RoyalBlue;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Location = new System.Drawing.Point(12, 372);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "ID Client:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.RoyalBlue;
            this.label3.Font = new System.Drawing.Font("Showcard Gothic", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label3.Location = new System.Drawing.Point(12, 417);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Data Comenzii:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.RoyalBlue;
            this.label4.Font = new System.Drawing.Font("Showcard Gothic", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label4.Location = new System.Drawing.Point(12, 463);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Total Comanda";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1314, 514);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbIdClient);
            this.Controls.Add(this.tbTotalComanda);
            this.Controls.Add(this.tbDataComanda);
            this.Controls.Add(this.tbIdComanda);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.display);
            this.Controls.Add(this.dataGridComenzi);
            this.Controls.Add(this.dataGridClienti);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridClienti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridComenzi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridClienti;
        private System.Windows.Forms.DataGridView dataGridComenzi;
        private System.Windows.Forms.Button display;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox tbIdComanda;
        private System.Windows.Forms.TextBox tbDataComanda;
        private System.Windows.Forms.TextBox tbTotalComanda;
        private System.Windows.Forms.TextBox tbIdClient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

