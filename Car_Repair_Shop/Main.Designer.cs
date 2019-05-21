namespace Car_Repair_Shop
{
    partial class Main
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
            this.tableSearchForm = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_CountPlate = new System.Windows.Forms.Label();
            this.label_CountVIN = new System.Windows.Forms.Label();
            this.txtVIN = new System.Windows.Forms.TextBox();
            this.txtPlate = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tableOptions = new System.Windows.Forms.TableLayoutPanel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSearchVIN = new System.Windows.Forms.Button();
            this.btnSearchPlate = new System.Windows.Forms.Button();
            this.tableSearchForm.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableSearchForm
            // 
            this.tableSearchForm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableSearchForm.AutoSize = true;
            this.tableSearchForm.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableSearchForm.ColumnCount = 3;
            this.tableSearchForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableSearchForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableSearchForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableSearchForm.Controls.Add(this.label3, 0, 1);
            this.tableSearchForm.Controls.Add(this.label2, 0, 0);
            this.tableSearchForm.Controls.Add(this.label_CountPlate, 2, 1);
            this.tableSearchForm.Controls.Add(this.label_CountVIN, 2, 0);
            this.tableSearchForm.Controls.Add(this.txtVIN, 1, 0);
            this.tableSearchForm.Controls.Add(this.txtPlate, 1, 1);
            this.tableSearchForm.Location = new System.Drawing.Point(174, 224);
            this.tableSearchForm.Name = "tableSearchForm";
            this.tableSearchForm.RowCount = 2;
            this.tableSearchForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableSearchForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableSearchForm.Size = new System.Drawing.Size(440, 80);
            this.tableSearchForm.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(3, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 40);
            this.label3.TabIndex = 1;
            this.label3.Text = "Plate";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 40);
            this.label2.TabIndex = 1;
            this.label2.Text = "VIN";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_CountPlate
            // 
            this.label_CountPlate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_CountPlate.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_CountPlate.Location = new System.Drawing.Point(355, 40);
            this.label_CountPlate.Name = "label_CountPlate";
            this.label_CountPlate.Size = new System.Drawing.Size(82, 40);
            this.label_CountPlate.TabIndex = 5;
            this.label_CountPlate.Text = "0/9";
            this.label_CountPlate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_CountVIN
            // 
            this.label_CountVIN.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_CountVIN.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_CountVIN.Location = new System.Drawing.Point(355, 0);
            this.label_CountVIN.Name = "label_CountVIN";
            this.label_CountVIN.Size = new System.Drawing.Size(82, 40);
            this.label_CountVIN.TabIndex = 5;
            this.label_CountVIN.Text = "0/17";
            this.label_CountVIN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtVIN
            // 
            this.txtVIN.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtVIN.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtVIN.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtVIN.Location = new System.Drawing.Point(135, 3);
            this.txtVIN.MaxLength = 17;
            this.txtVIN.Name = "txtVIN";
            this.txtVIN.Size = new System.Drawing.Size(214, 29);
            this.txtVIN.TabIndex = 2;
            this.txtVIN.TextChanged += new System.EventHandler(this.TxtVIN_TextChanged);
            this.txtVIN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtVIN_KeyPress);
            // 
            // txtPlate
            // 
            this.txtPlate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPlate.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPlate.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtPlate.Location = new System.Drawing.Point(135, 43);
            this.txtPlate.MaxLength = 9;
            this.txtPlate.Name = "txtPlate";
            this.txtPlate.Size = new System.Drawing.Size(214, 29);
            this.txtPlate.TabIndex = 2;
            this.txtPlate.TextChanged += new System.EventHandler(this.TxtPlateLength_TextChanged);
            this.txtPlate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPlate_KeyPress);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(28, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 147F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(725, 147);
            this.tableLayoutPanel1.TabIndex = 11;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Location = new System.Drawing.Point(583, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(139, 141);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(148, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(429, 147);
            this.label1.TabIndex = 0;
            this.label1.Text = "Logged";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableOptions
            // 
            this.tableOptions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableOptions.AutoSize = true;
            this.tableOptions.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableOptions.ColumnCount = 3;
            this.tableOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableOptions.Controls.Add(this.btnAdd, 0, 0);
            this.tableOptions.Controls.Add(this.btnSearchVIN, 1, 0);
            this.tableOptions.Controls.Add(this.btnSearchPlate, 2, 0);
            this.tableOptions.Location = new System.Drawing.Point(174, 325);
            this.tableOptions.Name = "tableOptions";
            this.tableOptions.RowCount = 1;
            this.tableOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableOptions.Size = new System.Drawing.Size(440, 40);
            this.tableOptions.TabIndex = 12;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAdd.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAdd.Location = new System.Drawing.Point(3, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(126, 34);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // btnSearchVIN
            // 
            this.btnSearchVIN.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearchVIN.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSearchVIN.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSearchVIN.Location = new System.Drawing.Point(135, 3);
            this.btnSearchVIN.Name = "btnSearchVIN";
            this.btnSearchVIN.Size = new System.Drawing.Size(148, 34);
            this.btnSearchVIN.TabIndex = 3;
            this.btnSearchVIN.Text = "Search VIN";
            this.btnSearchVIN.UseVisualStyleBackColor = true;
            this.btnSearchVIN.Click += new System.EventHandler(this.BtnSearchVIN_Click);
            // 
            // btnSearchPlate
            // 
            this.btnSearchPlate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearchPlate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSearchPlate.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSearchPlate.Location = new System.Drawing.Point(289, 3);
            this.btnSearchPlate.Name = "btnSearchPlate";
            this.btnSearchPlate.Size = new System.Drawing.Size(148, 34);
            this.btnSearchPlate.TabIndex = 3;
            this.btnSearchPlate.Text = "Search Plate";
            this.btnSearchPlate.UseVisualStyleBackColor = true;
            this.btnSearchPlate.Click += new System.EventHandler(this.BtnSearchPlate_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(792, 573);
            this.Controls.Add(this.tableOptions);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.tableSearchForm);
            this.MaximizeBox = false;
            this.Name = "Main";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.tableSearchForm.ResumeLayout(false);
            this.tableSearchForm.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableOptions.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableSearchForm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_CountPlate;
        private System.Windows.Forms.Label label_CountVIN;
        private System.Windows.Forms.TextBox txtVIN;
        private System.Windows.Forms.TextBox txtPlate;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableOptions;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSearchVIN;
        private System.Windows.Forms.Button btnSearchPlate;
    }
}