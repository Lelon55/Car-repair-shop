namespace Car_Repair_Shop
{
    partial class AddForm
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
            this.tableTop = new System.Windows.Forms.TableLayoutPanel();
            this.label_VIN = new System.Windows.Forms.Label();
            this.tableDatasCar = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtBrandCar = new System.Windows.Forms.TextBox();
            this.label_BrandLength = new System.Windows.Forms.Label();
            this.label_MileageStatusLength = new System.Windows.Forms.Label();
            this.txtMileage = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtModelCar = new System.Windows.Forms.TextBox();
            this.label_PlateLength = new System.Windows.Forms.Label();
            this.label_YearProductionLength = new System.Windows.Forms.Label();
            this.label_ModelCarLength = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtYearProduction = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtPlate = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateAcceptanceCar = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dateDevotionCar = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPartCost = new System.Windows.Forms.TextBox();
            this.label_PartCostLength = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtLaborCost = new System.Windows.Forms.TextBox();
            this.label_LaborCostLength = new System.Windows.Forms.Label();
            this.tableDescription = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtToDo = new System.Windows.Forms.TextBox();
            this.label_ToDoLength = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.label_CommentCount = new System.Windows.Forms.Label();
            this.txtRepaired = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label_RepairedLength = new System.Windows.Forms.Label();
            this.tableOptions = new System.Windows.Forms.TableLayoutPanel();
            this.btnGeneratePDF = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.tableTop.SuspendLayout();
            this.tableDatasCar.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableDescription.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tableOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableTop
            // 
            this.tableTop.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableTop.AutoSize = true;
            this.tableTop.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableTop.ColumnCount = 1;
            this.tableTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableTop.Controls.Add(this.label_VIN, 0, 0);
            this.tableTop.Location = new System.Drawing.Point(12, 12);
            this.tableTop.Name = "tableTop";
            this.tableTop.RowCount = 1;
            this.tableTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableTop.Size = new System.Drawing.Size(979, 31);
            this.tableTop.TabIndex = 15;
            // 
            // label_VIN
            // 
            this.label_VIN.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_VIN.AutoSize = true;
            this.label_VIN.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_VIN.Location = new System.Drawing.Point(3, 0);
            this.label_VIN.Name = "label_VIN";
            this.label_VIN.Size = new System.Drawing.Size(973, 31);
            this.label_VIN.TabIndex = 0;
            this.label_VIN.Text = "VIN: xyz 012 354 000";
            // 
            // tableDatasCar
            // 
            this.tableDatasCar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableDatasCar.AutoSize = true;
            this.tableDatasCar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableDatasCar.ColumnCount = 3;
            this.tableDatasCar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33332F));
            this.tableDatasCar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableDatasCar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableDatasCar.Controls.Add(this.groupBox1, 0, 0);
            this.tableDatasCar.Controls.Add(this.groupBox3, 1, 0);
            this.tableDatasCar.Controls.Add(this.groupBox2, 2, 0);
            this.tableDatasCar.Location = new System.Drawing.Point(12, 49);
            this.tableDatasCar.Name = "tableDatasCar";
            this.tableDatasCar.RowCount = 1;
            this.tableDatasCar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 215F));
            this.tableDatasCar.Size = new System.Drawing.Size(935, 215);
            this.tableDatasCar.TabIndex = 16;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtBrandCar);
            this.groupBox1.Controls.Add(this.label_BrandLength);
            this.groupBox1.Controls.Add(this.label_MileageStatusLength);
            this.groupBox1.Controls.Add(this.txtMileage);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtModelCar);
            this.groupBox1.Controls.Add(this.label_PlateLength);
            this.groupBox1.Controls.Add(this.label_YearProductionLength);
            this.groupBox1.Controls.Add(this.label_ModelCarLength);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtYearProduction);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txtPlate);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(305, 209);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data Car";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(6, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 21);
            this.label9.TabIndex = 1;
            this.label9.Text = "Brand:";
            // 
            // txtBrandCar
            // 
            this.txtBrandCar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBrandCar.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtBrandCar.Location = new System.Drawing.Point(73, 28);
            this.txtBrandCar.MaxLength = 32;
            this.txtBrandCar.Name = "txtBrandCar";
            this.txtBrandCar.Size = new System.Drawing.Size(165, 29);
            this.txtBrandCar.TabIndex = 0;
            this.txtBrandCar.TextChanged += new System.EventHandler(this.CountBrandLength);
            this.txtBrandCar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtDigitLetter_KeyPress);
            // 
            // label_BrandLength
            // 
            this.label_BrandLength.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_BrandLength.AutoSize = true;
            this.label_BrandLength.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_BrandLength.Location = new System.Drawing.Point(243, 31);
            this.label_BrandLength.Name = "label_BrandLength";
            this.label_BrandLength.Size = new System.Drawing.Size(42, 21);
            this.label_BrandLength.TabIndex = 5;
            this.label_BrandLength.Text = "0/32";
            // 
            // label_MileageStatusLength
            // 
            this.label_MileageStatusLength.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_MileageStatusLength.AutoSize = true;
            this.label_MileageStatusLength.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_MileageStatusLength.Location = new System.Drawing.Point(243, 171);
            this.label_MileageStatusLength.Name = "label_MileageStatusLength";
            this.label_MileageStatusLength.Size = new System.Drawing.Size(33, 21);
            this.label_MileageStatusLength.TabIndex = 5;
            this.label_MileageStatusLength.Text = "0/8";
            // 
            // txtMileage
            // 
            this.txtMileage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMileage.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtMileage.Location = new System.Drawing.Point(90, 168);
            this.txtMileage.MaxLength = 8;
            this.txtMileage.Name = "txtMileage";
            this.txtMileage.Size = new System.Drawing.Size(148, 29);
            this.txtMileage.TabIndex = 4;
            this.txtMileage.TextChanged += new System.EventHandler(this.CountMileageLength);
            this.txtMileage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtDigit_KeyPress);
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.Location = new System.Drawing.Point(6, 67);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 21);
            this.label10.TabIndex = 1;
            this.label10.Text = "Model:";
            // 
            // txtModelCar
            // 
            this.txtModelCar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtModelCar.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtModelCar.Location = new System.Drawing.Point(74, 63);
            this.txtModelCar.MaxLength = 32;
            this.txtModelCar.Name = "txtModelCar";
            this.txtModelCar.Size = new System.Drawing.Size(164, 29);
            this.txtModelCar.TabIndex = 1;
            this.txtModelCar.TextChanged += new System.EventHandler(this.CountModelCarLength);
            this.txtModelCar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtDigitLetter_KeyPress);
            // 
            // label_PlateLength
            // 
            this.label_PlateLength.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_PlateLength.AutoSize = true;
            this.label_PlateLength.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_PlateLength.Location = new System.Drawing.Point(243, 136);
            this.label_PlateLength.Name = "label_PlateLength";
            this.label_PlateLength.Size = new System.Drawing.Size(33, 21);
            this.label_PlateLength.TabIndex = 5;
            this.label_PlateLength.Text = "0/9";
            // 
            // label_YearProductionLength
            // 
            this.label_YearProductionLength.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_YearProductionLength.AutoSize = true;
            this.label_YearProductionLength.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_YearProductionLength.Location = new System.Drawing.Point(243, 101);
            this.label_YearProductionLength.Name = "label_YearProductionLength";
            this.label_YearProductionLength.Size = new System.Drawing.Size(33, 21);
            this.label_YearProductionLength.TabIndex = 5;
            this.label_YearProductionLength.Text = "0/4";
            // 
            // label_ModelCarLength
            // 
            this.label_ModelCarLength.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_ModelCarLength.AutoSize = true;
            this.label_ModelCarLength.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_ModelCarLength.Location = new System.Drawing.Point(243, 66);
            this.label_ModelCarLength.Name = "label_ModelCarLength";
            this.label_ModelCarLength.Size = new System.Drawing.Size(42, 21);
            this.label_ModelCarLength.TabIndex = 5;
            this.label_ModelCarLength.Text = "0/32";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.Location = new System.Drawing.Point(6, 101);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(93, 21);
            this.label11.TabIndex = 1;
            this.label11.Text = "Year prod.:";
            // 
            // txtYearProduction
            // 
            this.txtYearProduction.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtYearProduction.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtYearProduction.Location = new System.Drawing.Point(105, 98);
            this.txtYearProduction.MaxLength = 4;
            this.txtYearProduction.Name = "txtYearProduction";
            this.txtYearProduction.Size = new System.Drawing.Size(133, 29);
            this.txtYearProduction.TabIndex = 2;
            this.txtYearProduction.TextChanged += new System.EventHandler(this.CountYearProductionLength);
            this.txtYearProduction.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtDigit_KeyPress);
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label12.Location = new System.Drawing.Point(6, 136);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 21);
            this.label12.TabIndex = 1;
            this.label12.Text = "Plate:";
            // 
            // txtPlate
            // 
            this.txtPlate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPlate.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPlate.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtPlate.Location = new System.Drawing.Point(73, 133);
            this.txtPlate.MaxLength = 9;
            this.txtPlate.Name = "txtPlate";
            this.txtPlate.Size = new System.Drawing.Size(165, 29);
            this.txtPlate.TabIndex = 3;
            this.txtPlate.TextChanged += new System.EventHandler(this.CountPlateLength);
            this.txtPlate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtDigitLetter_KeyPress);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(6, 171);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 21);
            this.label7.TabIndex = 1;
            this.label7.Text = "Mileage:";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.dateAcceptanceCar);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.dateDevotionCar);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox3.Location = new System.Drawing.Point(314, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(305, 209);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Dates";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Acceptance Car:";
            // 
            // dateAcceptanceCar
            // 
            this.dateAcceptanceCar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateAcceptanceCar.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateAcceptanceCar.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateAcceptanceCar.Location = new System.Drawing.Point(146, 25);
            this.dateAcceptanceCar.Name = "dateAcceptanceCar";
            this.dateAcceptanceCar.Size = new System.Drawing.Size(153, 29);
            this.dateAcceptanceCar.TabIndex = 5;
            this.dateAcceptanceCar.Value = new System.DateTime(2019, 5, 7, 0, 0, 0, 0);
            this.dateAcceptanceCar.CloseUp += new System.EventHandler(this.SetDateDevotion);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(6, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 21);
            this.label4.TabIndex = 1;
            this.label4.Text = "Devotion Car:";
            // 
            // dateDevotionCar
            // 
            this.dateDevotionCar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateDevotionCar.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateDevotionCar.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateDevotionCar.Location = new System.Drawing.Point(146, 61);
            this.dateDevotionCar.Name = "dateDevotionCar";
            this.dateDevotionCar.Size = new System.Drawing.Size(153, 29);
            this.dateDevotionCar.TabIndex = 6;
            this.dateDevotionCar.Value = new System.DateTime(2019, 4, 27, 0, 0, 0, 0);
            this.dateDevotionCar.CloseUp += new System.EventHandler(this.CheckDates);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtPartCost);
            this.groupBox2.Controls.Add(this.label_PartCostLength);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtLaborCost);
            this.groupBox2.Controls.Add(this.label_LaborCostLength);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(625, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(307, 209);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cost";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(4, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 21);
            this.label3.TabIndex = 1;
            this.label3.Text = "Parts:";
            // 
            // txtPartCost
            // 
            this.txtPartCost.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPartCost.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtPartCost.Location = new System.Drawing.Point(74, 28);
            this.txtPartCost.MaxLength = 8;
            this.txtPartCost.Name = "txtPartCost";
            this.txtPartCost.Size = new System.Drawing.Size(164, 29);
            this.txtPartCost.TabIndex = 7;
            this.txtPartCost.TextChanged += new System.EventHandler(this.CountPartCostLength);
            this.txtPartCost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtDigit_KeyPress);
            // 
            // label_PartCostLength
            // 
            this.label_PartCostLength.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_PartCostLength.AutoSize = true;
            this.label_PartCostLength.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_PartCostLength.Location = new System.Drawing.Point(244, 31);
            this.label_PartCostLength.Name = "label_PartCostLength";
            this.label_PartCostLength.Size = new System.Drawing.Size(33, 21);
            this.label_PartCostLength.TabIndex = 5;
            this.label_PartCostLength.Text = "0/8";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(4, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 21);
            this.label6.TabIndex = 1;
            this.label6.Text = "Labor:";
            // 
            // txtLaborCost
            // 
            this.txtLaborCost.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLaborCost.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtLaborCost.Location = new System.Drawing.Point(74, 64);
            this.txtLaborCost.MaxLength = 8;
            this.txtLaborCost.Name = "txtLaborCost";
            this.txtLaborCost.Size = new System.Drawing.Size(164, 29);
            this.txtLaborCost.TabIndex = 8;
            this.txtLaborCost.TextChanged += new System.EventHandler(this.CountLaborCostLength);
            this.txtLaborCost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtDigit_KeyPress);
            // 
            // label_LaborCostLength
            // 
            this.label_LaborCostLength.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_LaborCostLength.AutoSize = true;
            this.label_LaborCostLength.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_LaborCostLength.Location = new System.Drawing.Point(244, 67);
            this.label_LaborCostLength.Name = "label_LaborCostLength";
            this.label_LaborCostLength.Size = new System.Drawing.Size(33, 21);
            this.label_LaborCostLength.TabIndex = 5;
            this.label_LaborCostLength.Text = "0/8";
            // 
            // tableDescription
            // 
            this.tableDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableDescription.AutoSize = true;
            this.tableDescription.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableDescription.ColumnCount = 1;
            this.tableDescription.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableDescription.Controls.Add(this.groupBox4, 0, 0);
            this.tableDescription.Location = new System.Drawing.Point(12, 270);
            this.tableDescription.Name = "tableDescription";
            this.tableDescription.RowCount = 1;
            this.tableDescription.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 350F));
            this.tableDescription.Size = new System.Drawing.Size(982, 350);
            this.tableDescription.TabIndex = 17;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.AutoSize = true;
            this.groupBox4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.txtToDo);
            this.groupBox4.Controls.Add(this.label_ToDoLength);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.txtComment);
            this.groupBox4.Controls.Add(this.label_CommentCount);
            this.groupBox4.Controls.Add(this.txtRepaired);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label_RepairedLength);
            this.groupBox4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox4.Location = new System.Drawing.Point(3, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(976, 344);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Description";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(6, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "To do:";
            // 
            // txtToDo
            // 
            this.txtToDo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtToDo.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtToDo.Location = new System.Drawing.Point(121, 22);
            this.txtToDo.MaxLength = 5000;
            this.txtToDo.Multiline = true;
            this.txtToDo.Name = "txtToDo";
            this.txtToDo.Size = new System.Drawing.Size(783, 103);
            this.txtToDo.TabIndex = 9;
            this.txtToDo.TextChanged += new System.EventHandler(this.CountToDoLength);
            // 
            // label_ToDoLength
            // 
            this.label_ToDoLength.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_ToDoLength.AutoSize = true;
            this.label_ToDoLength.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_ToDoLength.Location = new System.Drawing.Point(910, 25);
            this.label_ToDoLength.Name = "label_ToDoLength";
            this.label_ToDoLength.Size = new System.Drawing.Size(60, 21);
            this.label_ToDoLength.TabIndex = 5;
            this.label_ToDoLength.Text = "0/5000";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(6, 134);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 21);
            this.label8.TabIndex = 1;
            this.label8.Text = "Repaired:";
            // 
            // txtComment
            // 
            this.txtComment.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtComment.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtComment.Location = new System.Drawing.Point(121, 240);
            this.txtComment.MaxLength = 5000;
            this.txtComment.Multiline = true;
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(783, 98);
            this.txtComment.TabIndex = 11;
            this.txtComment.TextChanged += new System.EventHandler(this.CountCommentLength);
            // 
            // label_CommentCount
            // 
            this.label_CommentCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_CommentCount.AutoSize = true;
            this.label_CommentCount.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_CommentCount.Location = new System.Drawing.Point(910, 243);
            this.label_CommentCount.Name = "label_CommentCount";
            this.label_CommentCount.Size = new System.Drawing.Size(60, 21);
            this.label_CommentCount.TabIndex = 5;
            this.label_CommentCount.Text = "0/5000";
            // 
            // txtRepaired
            // 
            this.txtRepaired.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRepaired.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtRepaired.Location = new System.Drawing.Point(121, 131);
            this.txtRepaired.MaxLength = 5000;
            this.txtRepaired.Multiline = true;
            this.txtRepaired.Name = "txtRepaired";
            this.txtRepaired.Size = new System.Drawing.Size(783, 103);
            this.txtRepaired.TabIndex = 10;
            this.txtRepaired.TextChanged += new System.EventHandler(this.CountRepairedLength);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(6, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 21);
            this.label5.TabIndex = 1;
            this.label5.Text = "Comment:";
            // 
            // label_RepairedLength
            // 
            this.label_RepairedLength.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_RepairedLength.AutoSize = true;
            this.label_RepairedLength.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_RepairedLength.Location = new System.Drawing.Point(910, 134);
            this.label_RepairedLength.Name = "label_RepairedLength";
            this.label_RepairedLength.Size = new System.Drawing.Size(60, 21);
            this.label_RepairedLength.TabIndex = 5;
            this.label_RepairedLength.Text = "0/5000";
            // 
            // tableOptions
            // 
            this.tableOptions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableOptions.AutoSize = true;
            this.tableOptions.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableOptions.ColumnCount = 3;
            this.tableOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableOptions.Controls.Add(this.btnGeneratePDF, 2, 0);
            this.tableOptions.Controls.Add(this.btnAdd, 1, 0);
            this.tableOptions.Controls.Add(this.btnBack, 0, 0);
            this.tableOptions.Location = new System.Drawing.Point(196, 626);
            this.tableOptions.Name = "tableOptions";
            this.tableOptions.RowCount = 1;
            this.tableOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableOptions.Size = new System.Drawing.Size(600, 45);
            this.tableOptions.TabIndex = 18;
            // 
            // btnGeneratePDF
            // 
            this.btnGeneratePDF.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGeneratePDF.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGeneratePDF.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnGeneratePDF.Location = new System.Drawing.Point(423, 3);
            this.btnGeneratePDF.Name = "btnGeneratePDF";
            this.btnGeneratePDF.Size = new System.Drawing.Size(174, 39);
            this.btnGeneratePDF.TabIndex = 9;
            this.btnGeneratePDF.Text = "Add/Generate PDF";
            this.btnGeneratePDF.UseVisualStyleBackColor = true;
            this.btnGeneratePDF.Click += new System.EventHandler(this.BtnGeneratePDF_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAdd.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAdd.Location = new System.Drawing.Point(123, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(294, 39);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add to Database";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBack.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBack.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnBack.Location = new System.Drawing.Point(3, 3);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(114, 39);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1016, 673);
            this.Controls.Add(this.tableOptions);
            this.Controls.Add(this.tableDescription);
            this.Controls.Add(this.tableDatasCar);
            this.Controls.Add(this.tableTop);
            this.Name = "AddForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddForm_FormClosing);
            this.Load += new System.EventHandler(this.AddForm_Load);
            this.tableTop.ResumeLayout(false);
            this.tableTop.PerformLayout();
            this.tableDatasCar.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tableDescription.ResumeLayout(false);
            this.tableDescription.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tableOptions.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableTop;
        private System.Windows.Forms.Label label_VIN;
        private System.Windows.Forms.TableLayoutPanel tableDatasCar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtBrandCar;
        private System.Windows.Forms.Label label_BrandLength;
        private System.Windows.Forms.Label label_MileageStatusLength;
        private System.Windows.Forms.TextBox txtMileage;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtModelCar;
        private System.Windows.Forms.Label label_PlateLength;
        private System.Windows.Forms.Label label_YearProductionLength;
        private System.Windows.Forms.Label label_ModelCarLength;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtYearProduction;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtPlate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateAcceptanceCar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateDevotionCar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPartCost;
        private System.Windows.Forms.Label label_PartCostLength;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtLaborCost;
        private System.Windows.Forms.Label label_LaborCostLength;
        private System.Windows.Forms.TableLayoutPanel tableDescription;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtToDo;
        private System.Windows.Forms.Label label_ToDoLength;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.Label label_CommentCount;
        private System.Windows.Forms.TextBox txtRepaired;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label_RepairedLength;
        private System.Windows.Forms.TableLayoutPanel tableOptions;
        private System.Windows.Forms.Button btnGeneratePDF;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnBack;
    }
}