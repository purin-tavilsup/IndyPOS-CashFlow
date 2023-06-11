namespace IndyPOS.CashFlow.Windows.Forms.UI
{
    partial class MainForm
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            PullLatestDataFromDatabaseButton = new Button();
            groupBox1 = new GroupBox();
            HardwareSaleLabel = new Label();
            GeneralGoodsSaleLabel = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            label31 = new Label();
            label22 = new Label();
            label21 = new Label();
            WelfareCardPaymentLabel = new Label();
            MoneyTransferPaymentLabel = new Label();
            CashPaymentLabel = new Label();
            label8 = new Label();
            label5 = new Label();
            label6 = new Label();
            groupBox3 = new GroupBox();
            RemoveChangeButton = new Button();
            AddChangeButton = new Button();
            ChangeAmountTextBox = new TextBox();
            ChangesListView = new ListView();
            ChangesTotalLabel = new Label();
            label14 = new Label();
            groupBox4 = new GroupBox();
            RemovePayOutButton = new Button();
            PayOutAmountTextBox = new TextBox();
            AddPayOutButton = new Button();
            PayOutItemTextBox = new TextBox();
            PayoutsListView = new ListView();
            PayoutsTotalLabel = new Label();
            label4 = new Label();
            groupBox5 = new GroupBox();
            RemoveReceivedPayLaterPaymentButton = new Button();
            ReceivedPayLaterAmountTextBox = new TextBox();
            AddReceivedPayLaterPaymentButton = new Button();
            PayLaterAccountNameTextBox = new TextBox();
            ReceivedPayLaterPaymentsListView = new ListView();
            ReceivedPayLaterPaymentsTotalLabel = new Label();
            label7 = new Label();
            groupBox6 = new GroupBox();
            groupBox7 = new GroupBox();
            ResetCountingButton = new Button();
            Coin1CountTotalLabel = new Label();
            Coin2CountTotalLabel = new Label();
            Coin5CountTotalLabel = new Label();
            Coin10CountTotalLabel = new Label();
            label27 = new Label();
            label28 = new Label();
            label29 = new Label();
            Coin1CountTextBox = new TextBox();
            Coin2CountTextBox = new TextBox();
            Coin5CountTextBox = new TextBox();
            Coin10CountTextBox = new TextBox();
            label30 = new Label();
            label33 = new Label();
            label34 = new Label();
            label35 = new Label();
            BankNote20CountTotalLabel = new Label();
            BankNote50CountTotalLabel = new Label();
            BankNote100CountTotalLabel = new Label();
            BankNote500CountTotalLabel = new Label();
            BankNote1000CountTotalLabel = new Label();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            BankNote20CountTextBox = new TextBox();
            BankNote50CountTextBox = new TextBox();
            BankNote100CountTextBox = new TextBox();
            BankNote500CountTextBox = new TextBox();
            BankNote1000CountTextBox = new TextBox();
            label3 = new Label();
            label10 = new Label();
            SaveToFileButton = new Button();
            CalculatedCashTotalLabel = new Label();
            label15 = new Label();
            ActualCashTotalLabel = new Label();
            label17 = new Label();
            DateLabel = new Label();
            label9 = new Label();
            DiffCashLabel = new Label();
            groupBox8 = new GroupBox();
            DiffCashDescriptionLabel = new Label();
            groupBox9 = new GroupBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox6.SuspendLayout();
            groupBox7.SuspendLayout();
            groupBox8.SuspendLayout();
            groupBox9.SuspendLayout();
            SuspendLayout();
            // 
            // PullLatestDataFromDatabaseButton
            // 
            PullLatestDataFromDatabaseButton.BackColor = Color.Wheat;
            PullLatestDataFromDatabaseButton.Font = new Font("FC Subject [Non-commercial] Reg", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point);
            PullLatestDataFromDatabaseButton.ForeColor = Color.Black;
            PullLatestDataFromDatabaseButton.Location = new Point(9, 19);
            PullLatestDataFromDatabaseButton.Margin = new Padding(6, 7, 6, 7);
            PullLatestDataFromDatabaseButton.Name = "PullLatestDataFromDatabaseButton";
            PullLatestDataFromDatabaseButton.Size = new Size(180, 42);
            PullLatestDataFromDatabaseButton.TabIndex = 0;
            PullLatestDataFromDatabaseButton.Text = "ดึงข้อมูลล่าสุด";
            PullLatestDataFromDatabaseButton.UseVisualStyleBackColor = false;
            PullLatestDataFromDatabaseButton.Click += PullLatestDataFromDatabaseButton_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(HardwareSaleLabel);
            groupBox1.Controls.Add(GeneralGoodsSaleLabel);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("FC Subject [Non-commercial] Reg", 11.2499981F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(9, 25);
            groupBox1.Margin = new Padding(6, 7, 6, 7);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(6, 7, 6, 7);
            groupBox1.Size = new Size(255, 91);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "ยอดขาย";
            // 
            // HardwareSaleLabel
            // 
            HardwareSaleLabel.BackColor = Color.Wheat;
            HardwareSaleLabel.BorderStyle = BorderStyle.Fixed3D;
            HardwareSaleLabel.Font = new Font("FC Subject [Non-commercial] Reg", 11.2499981F, FontStyle.Regular, GraphicsUnit.Point);
            HardwareSaleLabel.Location = new Point(129, 51);
            HardwareSaleLabel.Name = "HardwareSaleLabel";
            HardwareSaleLabel.Size = new Size(108, 29);
            HardwareSaleLabel.TabIndex = 3;
            HardwareSaleLabel.Text = "0.00";
            HardwareSaleLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // GeneralGoodsSaleLabel
            // 
            GeneralGoodsSaleLabel.BackColor = Color.Wheat;
            GeneralGoodsSaleLabel.BorderStyle = BorderStyle.Fixed3D;
            GeneralGoodsSaleLabel.Font = new Font("FC Subject [Non-commercial] Reg", 11.2499981F, FontStyle.Regular, GraphicsUnit.Point);
            GeneralGoodsSaleLabel.Location = new Point(129, 22);
            GeneralGoodsSaleLabel.Name = "GeneralGoodsSaleLabel";
            GeneralGoodsSaleLabel.Size = new Size(108, 29);
            GeneralGoodsSaleLabel.TabIndex = 2;
            GeneralGoodsSaleLabel.Text = "0.00";
            GeneralGoodsSaleLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.BackColor = Color.Tan;
            label2.Font = new Font("FC Subject [Non-commercial] Reg", 11.2499981F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(21, 51);
            label2.Name = "label2";
            label2.Size = new Size(102, 29);
            label2.TabIndex = 1;
            label2.Text = "สินค้าฮาร์ดแวร์";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.BackColor = Color.Tan;
            label1.Font = new Font("FC Subject [Non-commercial] Reg", 11.2499981F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(21, 22);
            label1.Name = "label1";
            label1.Size = new Size(102, 29);
            label1.TabIndex = 0;
            label1.Text = "สินค้าเบ็ดเตล็ด";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label31);
            groupBox2.Controls.Add(label22);
            groupBox2.Controls.Add(label21);
            groupBox2.Controls.Add(WelfareCardPaymentLabel);
            groupBox2.Controls.Add(MoneyTransferPaymentLabel);
            groupBox2.Controls.Add(CashPaymentLabel);
            groupBox2.Font = new Font("FC Subject [Non-commercial] Reg", 11.2499981F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(9, 130);
            groupBox2.Margin = new Padding(6, 7, 6, 7);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(6, 7, 6, 7);
            groupBox2.Size = new Size(255, 121);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "รายรับ";
            // 
            // label31
            // 
            label31.BackColor = Color.Tan;
            label31.Font = new Font("FC Subject [Non-commercial] Reg", 11.2499981F, FontStyle.Regular, GraphicsUnit.Point);
            label31.Location = new Point(21, 78);
            label31.Name = "label31";
            label31.Size = new Size(102, 29);
            label31.TabIndex = 8;
            label31.Text = "บัตรสวัสดิการ";
            label31.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label22
            // 
            label22.BackColor = Color.Tan;
            label22.Font = new Font("FC Subject [Non-commercial] Reg", 11.2499981F, FontStyle.Regular, GraphicsUnit.Point);
            label22.Location = new Point(21, 49);
            label22.Name = "label22";
            label22.Size = new Size(102, 29);
            label22.TabIndex = 7;
            label22.Text = "เงินโอน";
            label22.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label21
            // 
            label21.BackColor = Color.Tan;
            label21.Font = new Font("FC Subject [Non-commercial] Reg", 11.2499981F, FontStyle.Regular, GraphicsUnit.Point);
            label21.Location = new Point(21, 20);
            label21.Name = "label21";
            label21.Size = new Size(102, 29);
            label21.TabIndex = 6;
            label21.Text = "เงินสด";
            label21.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // WelfareCardPaymentLabel
            // 
            WelfareCardPaymentLabel.BackColor = Color.Wheat;
            WelfareCardPaymentLabel.BorderStyle = BorderStyle.Fixed3D;
            WelfareCardPaymentLabel.Font = new Font("FC Subject [Non-commercial] Reg", 11.2499981F, FontStyle.Regular, GraphicsUnit.Point);
            WelfareCardPaymentLabel.Location = new Point(129, 78);
            WelfareCardPaymentLabel.Name = "WelfareCardPaymentLabel";
            WelfareCardPaymentLabel.Size = new Size(108, 29);
            WelfareCardPaymentLabel.TabIndex = 5;
            WelfareCardPaymentLabel.Text = "0.00";
            WelfareCardPaymentLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // MoneyTransferPaymentLabel
            // 
            MoneyTransferPaymentLabel.BackColor = Color.Wheat;
            MoneyTransferPaymentLabel.BorderStyle = BorderStyle.Fixed3D;
            MoneyTransferPaymentLabel.Font = new Font("FC Subject [Non-commercial] Reg", 11.2499981F, FontStyle.Regular, GraphicsUnit.Point);
            MoneyTransferPaymentLabel.Location = new Point(129, 49);
            MoneyTransferPaymentLabel.Name = "MoneyTransferPaymentLabel";
            MoneyTransferPaymentLabel.Size = new Size(108, 29);
            MoneyTransferPaymentLabel.TabIndex = 3;
            MoneyTransferPaymentLabel.Text = "0.00";
            MoneyTransferPaymentLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // CashPaymentLabel
            // 
            CashPaymentLabel.BackColor = Color.Wheat;
            CashPaymentLabel.BorderStyle = BorderStyle.Fixed3D;
            CashPaymentLabel.Font = new Font("FC Subject [Non-commercial] Reg", 11.2499981F, FontStyle.Regular, GraphicsUnit.Point);
            CashPaymentLabel.Location = new Point(129, 20);
            CashPaymentLabel.Name = "CashPaymentLabel";
            CashPaymentLabel.Size = new Size(108, 29);
            CashPaymentLabel.TabIndex = 2;
            CashPaymentLabel.Text = "0.00";
            CashPaymentLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            label8.BorderStyle = BorderStyle.FixedSingle;
            label8.Font = new Font("FC Subject [Non-commercial] Reg", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(21, 123);
            label8.Name = "label8";
            label8.Size = new Size(76, 24);
            label8.TabIndex = 4;
            label8.Text = "100";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.BorderStyle = BorderStyle.FixedSingle;
            label5.Font = new Font("FC Subject [Non-commercial] Reg", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(21, 93);
            label5.Name = "label5";
            label5.Size = new Size(76, 24);
            label5.TabIndex = 1;
            label5.Text = "500";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.BorderStyle = BorderStyle.FixedSingle;
            label6.Font = new Font("FC Subject [Non-commercial] Reg", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(21, 63);
            label6.Name = "label6";
            label6.Size = new Size(76, 24);
            label6.TabIndex = 0;
            label6.Text = "1,000";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(RemoveChangeButton);
            groupBox3.Controls.Add(AddChangeButton);
            groupBox3.Controls.Add(ChangeAmountTextBox);
            groupBox3.Controls.Add(ChangesListView);
            groupBox3.Controls.Add(ChangesTotalLabel);
            groupBox3.Controls.Add(label14);
            groupBox3.Font = new Font("FC Subject [Non-commercial] Reg", 11.2499981F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox3.Location = new Point(9, 265);
            groupBox3.Margin = new Padding(6, 7, 6, 7);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(6, 7, 6, 7);
            groupBox3.Size = new Size(255, 332);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "รายการ [ เงินทอน ]";
            // 
            // RemoveChangeButton
            // 
            RemoveChangeButton.BackColor = Color.Wheat;
            RemoveChangeButton.Location = new Point(140, 289);
            RemoveChangeButton.Name = "RemoveChangeButton";
            RemoveChangeButton.Size = new Size(97, 35);
            RemoveChangeButton.TabIndex = 6;
            RemoveChangeButton.Text = "ลบ";
            RemoveChangeButton.UseVisualStyleBackColor = false;
            RemoveChangeButton.Click += RemoveChangeButton_Click;
            // 
            // AddChangeButton
            // 
            AddChangeButton.BackColor = Color.Wheat;
            AddChangeButton.Location = new Point(140, 72);
            AddChangeButton.Name = "AddChangeButton";
            AddChangeButton.Size = new Size(97, 35);
            AddChangeButton.TabIndex = 5;
            AddChangeButton.Text = "เพิ่ม";
            AddChangeButton.UseVisualStyleBackColor = false;
            AddChangeButton.Click += AddChangeButton_Click;
            // 
            // ChangeAmountTextBox
            // 
            ChangeAmountTextBox.BackColor = Color.Cornsilk;
            ChangeAmountTextBox.BorderStyle = BorderStyle.FixedSingle;
            ChangeAmountTextBox.Font = new Font("FC Subject [Non-commercial] Reg", 11.2499981F, FontStyle.Regular, GraphicsUnit.Point);
            ChangeAmountTextBox.Location = new Point(21, 76);
            ChangeAmountTextBox.Name = "ChangeAmountTextBox";
            ChangeAmountTextBox.PlaceholderText = "จำนวน";
            ChangeAmountTextBox.Size = new Size(113, 24);
            ChangeAmountTextBox.TabIndex = 4;
            ChangeAmountTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // ChangesListView
            // 
            ChangesListView.BackColor = Color.Tan;
            ChangesListView.Font = new Font("FC Subject [Non-commercial] Reg", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
            ChangesListView.LabelEdit = true;
            ChangesListView.Location = new Point(21, 120);
            ChangesListView.MultiSelect = false;
            ChangesListView.Name = "ChangesListView";
            ChangesListView.Size = new Size(216, 163);
            ChangesListView.TabIndex = 3;
            ChangesListView.UseCompatibleStateImageBehavior = false;
            ChangesListView.View = View.Details;
            ChangesListView.Click += ChangesListView_Click;
            // 
            // ChangesTotalLabel
            // 
            ChangesTotalLabel.BackColor = Color.Wheat;
            ChangesTotalLabel.BorderStyle = BorderStyle.Fixed3D;
            ChangesTotalLabel.Font = new Font("FC Subject [Non-commercial] Reg", 11.2499981F, FontStyle.Regular, GraphicsUnit.Point);
            ChangesTotalLabel.Location = new Point(113, 33);
            ChangesTotalLabel.Name = "ChangesTotalLabel";
            ChangesTotalLabel.Size = new Size(124, 29);
            ChangesTotalLabel.TabIndex = 2;
            ChangesTotalLabel.Text = "0.00";
            ChangesTotalLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label14
            // 
            label14.Font = new Font("FC Subject [Non-commercial] Reg", 11.2499981F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(21, 33);
            label14.Name = "label14";
            label14.Size = new Size(86, 29);
            label14.TabIndex = 0;
            label14.Text = "ยอดรวม";
            label14.TextAlign = ContentAlignment.MiddleRight;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(RemovePayOutButton);
            groupBox4.Controls.Add(PayOutAmountTextBox);
            groupBox4.Controls.Add(AddPayOutButton);
            groupBox4.Controls.Add(PayOutItemTextBox);
            groupBox4.Controls.Add(PayoutsListView);
            groupBox4.Controls.Add(PayoutsTotalLabel);
            groupBox4.Controls.Add(label4);
            groupBox4.Font = new Font("FC Subject [Non-commercial] Reg", 11.2499981F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox4.Location = new Point(276, 25);
            groupBox4.Margin = new Padding(6, 7, 6, 7);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(6, 7, 6, 7);
            groupBox4.Size = new Size(335, 572);
            groupBox4.TabIndex = 4;
            groupBox4.TabStop = false;
            groupBox4.Text = "รายการ [ รายจ่าย ]";
            // 
            // RemovePayOutButton
            // 
            RemovePayOutButton.BackColor = Color.Wheat;
            RemovePayOutButton.Location = new Point(219, 529);
            RemovePayOutButton.Name = "RemovePayOutButton";
            RemovePayOutButton.Size = new Size(97, 35);
            RemovePayOutButton.TabIndex = 9;
            RemovePayOutButton.Text = "ลบ";
            RemovePayOutButton.UseVisualStyleBackColor = false;
            RemovePayOutButton.Click += RemovePayOutItemButton_Click;
            // 
            // PayOutAmountTextBox
            // 
            PayOutAmountTextBox.BackColor = Color.Cornsilk;
            PayOutAmountTextBox.BorderStyle = BorderStyle.FixedSingle;
            PayOutAmountTextBox.Font = new Font("FC Subject [Non-commercial] Reg", 11.2499981F, FontStyle.Regular, GraphicsUnit.Point);
            PayOutAmountTextBox.Location = new Point(21, 100);
            PayOutAmountTextBox.Name = "PayOutAmountTextBox";
            PayOutAmountTextBox.PlaceholderText = "จำนวน";
            PayOutAmountTextBox.Size = new Size(128, 24);
            PayOutAmountTextBox.TabIndex = 8;
            PayOutAmountTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // AddPayOutButton
            // 
            AddPayOutButton.BackColor = Color.Wheat;
            AddPayOutButton.Location = new Point(219, 70);
            AddPayOutButton.Name = "AddPayOutButton";
            AddPayOutButton.Size = new Size(97, 35);
            AddPayOutButton.TabIndex = 7;
            AddPayOutButton.Text = "เพิ่ม";
            AddPayOutButton.UseVisualStyleBackColor = false;
            AddPayOutButton.Click += AddPayOutItemButton_Click;
            // 
            // PayOutItemTextBox
            // 
            PayOutItemTextBox.BackColor = Color.Cornsilk;
            PayOutItemTextBox.BorderStyle = BorderStyle.FixedSingle;
            PayOutItemTextBox.Font = new Font("FC Subject [Non-commercial] Reg", 11.2499981F, FontStyle.Regular, GraphicsUnit.Point);
            PayOutItemTextBox.Location = new Point(21, 70);
            PayOutItemTextBox.Name = "PayOutItemTextBox";
            PayOutItemTextBox.PlaceholderText = "รายการ";
            PayOutItemTextBox.Size = new Size(128, 24);
            PayOutItemTextBox.TabIndex = 6;
            PayOutItemTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // PayoutsListView
            // 
            PayoutsListView.BackColor = Color.Tan;
            PayoutsListView.Font = new Font("FC Subject [Non-commercial] Reg", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
            PayoutsListView.Location = new Point(21, 130);
            PayoutsListView.MultiSelect = false;
            PayoutsListView.Name = "PayoutsListView";
            PayoutsListView.Size = new Size(295, 393);
            PayoutsListView.TabIndex = 3;
            PayoutsListView.UseCompatibleStateImageBehavior = false;
            PayoutsListView.Click += PayOutListView_Click;
            // 
            // PayoutsTotalLabel
            // 
            PayoutsTotalLabel.BackColor = Color.Wheat;
            PayoutsTotalLabel.BorderStyle = BorderStyle.Fixed3D;
            PayoutsTotalLabel.Font = new Font("FC Subject [Non-commercial] Reg", 11.2499981F, FontStyle.Regular, GraphicsUnit.Point);
            PayoutsTotalLabel.Location = new Point(192, 29);
            PayoutsTotalLabel.Name = "PayoutsTotalLabel";
            PayoutsTotalLabel.Size = new Size(124, 29);
            PayoutsTotalLabel.TabIndex = 2;
            PayoutsTotalLabel.Text = "0.00";
            PayoutsTotalLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            label4.Font = new Font("FC Subject [Non-commercial] Reg", 11.2499981F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(21, 29);
            label4.Name = "label4";
            label4.Size = new Size(165, 29);
            label4.TabIndex = 0;
            label4.Text = "ยอดรวม";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(RemoveReceivedPayLaterPaymentButton);
            groupBox5.Controls.Add(ReceivedPayLaterAmountTextBox);
            groupBox5.Controls.Add(AddReceivedPayLaterPaymentButton);
            groupBox5.Controls.Add(PayLaterAccountNameTextBox);
            groupBox5.Controls.Add(ReceivedPayLaterPaymentsListView);
            groupBox5.Controls.Add(ReceivedPayLaterPaymentsTotalLabel);
            groupBox5.Controls.Add(label7);
            groupBox5.Font = new Font("FC Subject [Non-commercial] Reg", 11.2499981F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox5.Location = new Point(623, 25);
            groupBox5.Margin = new Padding(6, 7, 6, 7);
            groupBox5.Name = "groupBox5";
            groupBox5.Padding = new Padding(6, 7, 6, 7);
            groupBox5.Size = new Size(317, 572);
            groupBox5.TabIndex = 5;
            groupBox5.TabStop = false;
            groupBox5.Text = "รายการ [ ลูกค้าชำระหนี้ ]";
            // 
            // RemoveReceivedPayLaterPaymentButton
            // 
            RemoveReceivedPayLaterPaymentButton.BackColor = Color.Wheat;
            RemoveReceivedPayLaterPaymentButton.Location = new Point(199, 529);
            RemoveReceivedPayLaterPaymentButton.Name = "RemoveReceivedPayLaterPaymentButton";
            RemoveReceivedPayLaterPaymentButton.Size = new Size(97, 35);
            RemoveReceivedPayLaterPaymentButton.TabIndex = 9;
            RemoveReceivedPayLaterPaymentButton.Text = "ลบ";
            RemoveReceivedPayLaterPaymentButton.UseVisualStyleBackColor = false;
            RemoveReceivedPayLaterPaymentButton.Click += RemoveReceivedPayLaterPaymentButton_Click;
            // 
            // ReceivedPayLaterAmountTextBox
            // 
            ReceivedPayLaterAmountTextBox.BackColor = Color.Cornsilk;
            ReceivedPayLaterAmountTextBox.BorderStyle = BorderStyle.FixedSingle;
            ReceivedPayLaterAmountTextBox.Font = new Font("FC Subject [Non-commercial] Reg", 11.2499981F, FontStyle.Regular, GraphicsUnit.Point);
            ReceivedPayLaterAmountTextBox.Location = new Point(21, 100);
            ReceivedPayLaterAmountTextBox.Name = "ReceivedPayLaterAmountTextBox";
            ReceivedPayLaterAmountTextBox.PlaceholderText = "จำนวน";
            ReceivedPayLaterAmountTextBox.Size = new Size(128, 24);
            ReceivedPayLaterAmountTextBox.TabIndex = 8;
            ReceivedPayLaterAmountTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // AddReceivedPayLaterPaymentButton
            // 
            AddReceivedPayLaterPaymentButton.BackColor = Color.Wheat;
            AddReceivedPayLaterPaymentButton.Location = new Point(199, 70);
            AddReceivedPayLaterPaymentButton.Name = "AddReceivedPayLaterPaymentButton";
            AddReceivedPayLaterPaymentButton.Size = new Size(97, 35);
            AddReceivedPayLaterPaymentButton.TabIndex = 7;
            AddReceivedPayLaterPaymentButton.Text = "เพิ่ม";
            AddReceivedPayLaterPaymentButton.UseVisualStyleBackColor = false;
            AddReceivedPayLaterPaymentButton.Click += AddReceivedPayLaterPaymentButton_Click;
            // 
            // PayLaterAccountNameTextBox
            // 
            PayLaterAccountNameTextBox.BackColor = Color.Cornsilk;
            PayLaterAccountNameTextBox.BorderStyle = BorderStyle.FixedSingle;
            PayLaterAccountNameTextBox.Font = new Font("FC Subject [Non-commercial] Reg", 11.2499981F, FontStyle.Regular, GraphicsUnit.Point);
            PayLaterAccountNameTextBox.Location = new Point(21, 70);
            PayLaterAccountNameTextBox.Name = "PayLaterAccountNameTextBox";
            PayLaterAccountNameTextBox.PlaceholderText = "ชื่อ";
            PayLaterAccountNameTextBox.Size = new Size(128, 24);
            PayLaterAccountNameTextBox.TabIndex = 6;
            PayLaterAccountNameTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // ReceivedPayLaterPaymentsListView
            // 
            ReceivedPayLaterPaymentsListView.BackColor = Color.Tan;
            ReceivedPayLaterPaymentsListView.Font = new Font("FC Subject [Non-commercial] Reg", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
            ReceivedPayLaterPaymentsListView.Location = new Point(21, 130);
            ReceivedPayLaterPaymentsListView.MultiSelect = false;
            ReceivedPayLaterPaymentsListView.Name = "ReceivedPayLaterPaymentsListView";
            ReceivedPayLaterPaymentsListView.Size = new Size(275, 393);
            ReceivedPayLaterPaymentsListView.TabIndex = 3;
            ReceivedPayLaterPaymentsListView.UseCompatibleStateImageBehavior = false;
            ReceivedPayLaterPaymentsListView.Click += ReceivedPayLaterPaymentsListView_Click;
            // 
            // ReceivedPayLaterPaymentsTotalLabel
            // 
            ReceivedPayLaterPaymentsTotalLabel.BackColor = Color.Wheat;
            ReceivedPayLaterPaymentsTotalLabel.BorderStyle = BorderStyle.Fixed3D;
            ReceivedPayLaterPaymentsTotalLabel.Font = new Font("FC Subject [Non-commercial] Reg", 11.2499981F, FontStyle.Regular, GraphicsUnit.Point);
            ReceivedPayLaterPaymentsTotalLabel.Location = new Point(172, 29);
            ReceivedPayLaterPaymentsTotalLabel.Name = "ReceivedPayLaterPaymentsTotalLabel";
            ReceivedPayLaterPaymentsTotalLabel.Size = new Size(124, 29);
            ReceivedPayLaterPaymentsTotalLabel.TabIndex = 2;
            ReceivedPayLaterPaymentsTotalLabel.Text = "0.00";
            ReceivedPayLaterPaymentsTotalLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            label7.Font = new Font("FC Subject [Non-commercial] Reg", 11.2499981F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(21, 29);
            label7.Name = "label7";
            label7.Size = new Size(145, 29);
            label7.TabIndex = 0;
            label7.Text = "ยอดรวม";
            label7.TextAlign = ContentAlignment.MiddleRight;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(groupBox1);
            groupBox6.Controls.Add(groupBox5);
            groupBox6.Controls.Add(groupBox2);
            groupBox6.Controls.Add(groupBox4);
            groupBox6.Controls.Add(groupBox3);
            groupBox6.Font = new Font("FC Subject [Non-commercial] Reg", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox6.Location = new Point(15, 76);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(954, 608);
            groupBox6.TabIndex = 6;
            groupBox6.TabStop = false;
            groupBox6.Text = "เงินสด [ คำนวณ ]";
            // 
            // groupBox7
            // 
            groupBox7.Controls.Add(ResetCountingButton);
            groupBox7.Controls.Add(Coin1CountTotalLabel);
            groupBox7.Controls.Add(Coin2CountTotalLabel);
            groupBox7.Controls.Add(Coin5CountTotalLabel);
            groupBox7.Controls.Add(Coin10CountTotalLabel);
            groupBox7.Controls.Add(label27);
            groupBox7.Controls.Add(label28);
            groupBox7.Controls.Add(label29);
            groupBox7.Controls.Add(Coin1CountTextBox);
            groupBox7.Controls.Add(Coin2CountTextBox);
            groupBox7.Controls.Add(Coin5CountTextBox);
            groupBox7.Controls.Add(Coin10CountTextBox);
            groupBox7.Controls.Add(label30);
            groupBox7.Controls.Add(label33);
            groupBox7.Controls.Add(label34);
            groupBox7.Controls.Add(label35);
            groupBox7.Controls.Add(BankNote20CountTotalLabel);
            groupBox7.Controls.Add(BankNote50CountTotalLabel);
            groupBox7.Controls.Add(BankNote100CountTotalLabel);
            groupBox7.Controls.Add(BankNote500CountTotalLabel);
            groupBox7.Controls.Add(BankNote1000CountTotalLabel);
            groupBox7.Controls.Add(label13);
            groupBox7.Controls.Add(label12);
            groupBox7.Controls.Add(label11);
            groupBox7.Controls.Add(BankNote20CountTextBox);
            groupBox7.Controls.Add(BankNote50CountTextBox);
            groupBox7.Controls.Add(BankNote100CountTextBox);
            groupBox7.Controls.Add(BankNote500CountTextBox);
            groupBox7.Controls.Add(BankNote1000CountTextBox);
            groupBox7.Controls.Add(label3);
            groupBox7.Controls.Add(label10);
            groupBox7.Controls.Add(label6);
            groupBox7.Controls.Add(label8);
            groupBox7.Controls.Add(label5);
            groupBox7.Font = new Font("FC Subject [Non-commercial] Reg", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox7.Location = new Point(983, 12);
            groupBox7.Name = "groupBox7";
            groupBox7.Size = new Size(292, 450);
            groupBox7.TabIndex = 7;
            groupBox7.TabStop = false;
            groupBox7.Text = "เงินสด [ นับ ]";
            // 
            // ResetCountingButton
            // 
            ResetCountingButton.BackColor = Color.Wheat;
            ResetCountingButton.Font = new Font("FC Subject [Non-commercial] Reg", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point);
            ResetCountingButton.ForeColor = Color.Black;
            ResetCountingButton.Location = new Point(21, 387);
            ResetCountingButton.Margin = new Padding(6, 7, 6, 7);
            ResetCountingButton.Name = "ResetCountingButton";
            ResetCountingButton.Size = new Size(172, 42);
            ResetCountingButton.TabIndex = 43;
            ResetCountingButton.Text = "เริ่มการนับใหม่";
            ResetCountingButton.UseVisualStyleBackColor = false;
            ResetCountingButton.Click += ResetCountingButton_Click;
            // 
            // Coin1CountTotalLabel
            // 
            Coin1CountTotalLabel.Font = new Font("FC Subject [Non-commercial] Reg", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
            Coin1CountTotalLabel.Location = new Point(199, 343);
            Coin1CountTotalLabel.Name = "Coin1CountTotalLabel";
            Coin1CountTotalLabel.Size = new Size(78, 24);
            Coin1CountTotalLabel.TabIndex = 42;
            Coin1CountTotalLabel.Text = "0.00";
            Coin1CountTotalLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Coin2CountTotalLabel
            // 
            Coin2CountTotalLabel.Font = new Font("FC Subject [Non-commercial] Reg", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
            Coin2CountTotalLabel.Location = new Point(199, 313);
            Coin2CountTotalLabel.Name = "Coin2CountTotalLabel";
            Coin2CountTotalLabel.Size = new Size(78, 24);
            Coin2CountTotalLabel.TabIndex = 41;
            Coin2CountTotalLabel.Text = "0.00";
            Coin2CountTotalLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Coin5CountTotalLabel
            // 
            Coin5CountTotalLabel.Font = new Font("FC Subject [Non-commercial] Reg", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
            Coin5CountTotalLabel.Location = new Point(199, 283);
            Coin5CountTotalLabel.Name = "Coin5CountTotalLabel";
            Coin5CountTotalLabel.Size = new Size(78, 24);
            Coin5CountTotalLabel.TabIndex = 40;
            Coin5CountTotalLabel.Text = "0.00";
            Coin5CountTotalLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Coin10CountTotalLabel
            // 
            Coin10CountTotalLabel.Font = new Font("FC Subject [Non-commercial] Reg", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
            Coin10CountTotalLabel.Location = new Point(199, 253);
            Coin10CountTotalLabel.Name = "Coin10CountTotalLabel";
            Coin10CountTotalLabel.Size = new Size(78, 24);
            Coin10CountTotalLabel.TabIndex = 39;
            Coin10CountTotalLabel.Text = "0.00";
            Coin10CountTotalLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label27
            // 
            label27.Font = new Font("FC Subject [Non-commercial] Reg", 11.2499981F, FontStyle.Regular, GraphicsUnit.Point);
            label27.Location = new Point(199, 225);
            label27.Name = "label27";
            label27.Size = new Size(78, 24);
            label27.TabIndex = 38;
            label27.Text = "ยอดรวม";
            label27.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label28
            // 
            label28.Font = new Font("FC Subject [Non-commercial] Reg", 11.2499981F, FontStyle.Regular, GraphicsUnit.Point);
            label28.Location = new Point(103, 225);
            label28.Name = "label28";
            label28.Size = new Size(90, 24);
            label28.TabIndex = 37;
            label28.Text = "จำนวนนับ";
            label28.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label29
            // 
            label29.Font = new Font("FC Subject [Non-commercial] Reg", 11.2499981F, FontStyle.Regular, GraphicsUnit.Point);
            label29.Location = new Point(21, 225);
            label29.Name = "label29";
            label29.Size = new Size(76, 24);
            label29.TabIndex = 36;
            label29.Text = "เหรีญ";
            label29.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Coin1CountTextBox
            // 
            Coin1CountTextBox.BackColor = Color.Cornsilk;
            Coin1CountTextBox.BorderStyle = BorderStyle.FixedSingle;
            Coin1CountTextBox.Font = new Font("FC Subject [Non-commercial] Reg", 11.2499981F, FontStyle.Regular, GraphicsUnit.Point);
            Coin1CountTextBox.Location = new Point(103, 343);
            Coin1CountTextBox.Name = "Coin1CountTextBox";
            Coin1CountTextBox.PlaceholderText = "จำนวน";
            Coin1CountTextBox.Size = new Size(90, 24);
            Coin1CountTextBox.TabIndex = 33;
            Coin1CountTextBox.TextAlign = HorizontalAlignment.Center;
            Coin1CountTextBox.TextChanged += Coin1CountTextBox_TextChanged;
            Coin1CountTextBox.Leave += Coin1CountTextBox_Leave;
            // 
            // Coin2CountTextBox
            // 
            Coin2CountTextBox.BackColor = Color.Cornsilk;
            Coin2CountTextBox.BorderStyle = BorderStyle.FixedSingle;
            Coin2CountTextBox.Font = new Font("FC Subject [Non-commercial] Reg", 11.2499981F, FontStyle.Regular, GraphicsUnit.Point);
            Coin2CountTextBox.Location = new Point(103, 313);
            Coin2CountTextBox.Name = "Coin2CountTextBox";
            Coin2CountTextBox.PlaceholderText = "จำนวน";
            Coin2CountTextBox.Size = new Size(90, 24);
            Coin2CountTextBox.TabIndex = 32;
            Coin2CountTextBox.TextAlign = HorizontalAlignment.Center;
            Coin2CountTextBox.TextChanged += Coin2CountTextBox_TextChanged;
            Coin2CountTextBox.Leave += Coin2CountTextBox_Leave;
            // 
            // Coin5CountTextBox
            // 
            Coin5CountTextBox.BackColor = Color.Cornsilk;
            Coin5CountTextBox.BorderStyle = BorderStyle.FixedSingle;
            Coin5CountTextBox.Font = new Font("FC Subject [Non-commercial] Reg", 11.2499981F, FontStyle.Regular, GraphicsUnit.Point);
            Coin5CountTextBox.Location = new Point(103, 283);
            Coin5CountTextBox.Name = "Coin5CountTextBox";
            Coin5CountTextBox.PlaceholderText = "จำนวน";
            Coin5CountTextBox.Size = new Size(90, 24);
            Coin5CountTextBox.TabIndex = 31;
            Coin5CountTextBox.TextAlign = HorizontalAlignment.Center;
            Coin5CountTextBox.TextChanged += Coin5CountTextBox_TextChanged;
            Coin5CountTextBox.Leave += Coin5CountTextBox_Leave;
            // 
            // Coin10CountTextBox
            // 
            Coin10CountTextBox.BackColor = Color.Cornsilk;
            Coin10CountTextBox.BorderStyle = BorderStyle.FixedSingle;
            Coin10CountTextBox.Font = new Font("FC Subject [Non-commercial] Reg", 11.2499981F, FontStyle.Regular, GraphicsUnit.Point);
            Coin10CountTextBox.Location = new Point(103, 253);
            Coin10CountTextBox.Name = "Coin10CountTextBox";
            Coin10CountTextBox.PlaceholderText = "จำนวน";
            Coin10CountTextBox.Size = new Size(90, 24);
            Coin10CountTextBox.TabIndex = 30;
            Coin10CountTextBox.TextAlign = HorizontalAlignment.Center;
            Coin10CountTextBox.TextChanged += Coin10CountTextBox_TextChanged;
            Coin10CountTextBox.Leave += Coin10CountTextBox_Leave;
            // 
            // label30
            // 
            label30.BorderStyle = BorderStyle.FixedSingle;
            label30.Font = new Font("FC Subject [Non-commercial] Reg", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
            label30.Location = new Point(21, 343);
            label30.Name = "label30";
            label30.Size = new Size(76, 24);
            label30.TabIndex = 27;
            label30.Text = "1";
            label30.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label33
            // 
            label33.BorderStyle = BorderStyle.FixedSingle;
            label33.Font = new Font("FC Subject [Non-commercial] Reg", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
            label33.Location = new Point(21, 253);
            label33.Name = "label33";
            label33.Size = new Size(76, 24);
            label33.TabIndex = 24;
            label33.Text = "10";
            label33.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label34
            // 
            label34.BorderStyle = BorderStyle.FixedSingle;
            label34.Font = new Font("FC Subject [Non-commercial] Reg", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
            label34.Location = new Point(21, 313);
            label34.Name = "label34";
            label34.Size = new Size(76, 24);
            label34.TabIndex = 26;
            label34.Text = "2";
            label34.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label35
            // 
            label35.BorderStyle = BorderStyle.FixedSingle;
            label35.Font = new Font("FC Subject [Non-commercial] Reg", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
            label35.Location = new Point(21, 283);
            label35.Name = "label35";
            label35.Size = new Size(76, 24);
            label35.TabIndex = 25;
            label35.Text = "5";
            label35.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BankNote20CountTotalLabel
            // 
            BankNote20CountTotalLabel.Font = new Font("FC Subject [Non-commercial] Reg", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
            BankNote20CountTotalLabel.Location = new Point(199, 181);
            BankNote20CountTotalLabel.Name = "BankNote20CountTotalLabel";
            BankNote20CountTotalLabel.Size = new Size(78, 24);
            BankNote20CountTotalLabel.TabIndex = 22;
            BankNote20CountTotalLabel.Text = "0.00";
            BankNote20CountTotalLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // BankNote50CountTotalLabel
            // 
            BankNote50CountTotalLabel.Font = new Font("FC Subject [Non-commercial] Reg", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
            BankNote50CountTotalLabel.Location = new Point(199, 153);
            BankNote50CountTotalLabel.Name = "BankNote50CountTotalLabel";
            BankNote50CountTotalLabel.Size = new Size(78, 24);
            BankNote50CountTotalLabel.TabIndex = 21;
            BankNote50CountTotalLabel.Text = "0.00";
            BankNote50CountTotalLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // BankNote100CountTotalLabel
            // 
            BankNote100CountTotalLabel.Font = new Font("FC Subject [Non-commercial] Reg", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
            BankNote100CountTotalLabel.Location = new Point(199, 123);
            BankNote100CountTotalLabel.Name = "BankNote100CountTotalLabel";
            BankNote100CountTotalLabel.Size = new Size(78, 24);
            BankNote100CountTotalLabel.TabIndex = 20;
            BankNote100CountTotalLabel.Text = "0.00";
            BankNote100CountTotalLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // BankNote500CountTotalLabel
            // 
            BankNote500CountTotalLabel.Font = new Font("FC Subject [Non-commercial] Reg", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
            BankNote500CountTotalLabel.Location = new Point(199, 93);
            BankNote500CountTotalLabel.Name = "BankNote500CountTotalLabel";
            BankNote500CountTotalLabel.Size = new Size(78, 24);
            BankNote500CountTotalLabel.TabIndex = 19;
            BankNote500CountTotalLabel.Text = "0.00";
            BankNote500CountTotalLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // BankNote1000CountTotalLabel
            // 
            BankNote1000CountTotalLabel.Font = new Font("FC Subject [Non-commercial] Reg", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
            BankNote1000CountTotalLabel.Location = new Point(199, 63);
            BankNote1000CountTotalLabel.Name = "BankNote1000CountTotalLabel";
            BankNote1000CountTotalLabel.Size = new Size(78, 24);
            BankNote1000CountTotalLabel.TabIndex = 18;
            BankNote1000CountTotalLabel.Text = "0.00";
            BankNote1000CountTotalLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label13
            // 
            label13.Font = new Font("FC Subject [Non-commercial] Reg", 11.2499981F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(199, 35);
            label13.Name = "label13";
            label13.Size = new Size(78, 24);
            label13.TabIndex = 17;
            label13.Text = "ยอดรวม";
            label13.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            label12.Font = new Font("FC Subject [Non-commercial] Reg", 11.2499981F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(103, 35);
            label12.Name = "label12";
            label12.Size = new Size(90, 24);
            label12.TabIndex = 16;
            label12.Text = "จำนวนนับ";
            label12.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            label11.Font = new Font("FC Subject [Non-commercial] Reg", 11.2499981F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(21, 35);
            label11.Name = "label11";
            label11.Size = new Size(76, 24);
            label11.TabIndex = 15;
            label11.Text = "ธนบัตร";
            label11.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BankNote20CountTextBox
            // 
            BankNote20CountTextBox.BackColor = Color.Cornsilk;
            BankNote20CountTextBox.BorderStyle = BorderStyle.FixedSingle;
            BankNote20CountTextBox.Font = new Font("FC Subject [Non-commercial] Reg", 11.2499981F, FontStyle.Regular, GraphicsUnit.Point);
            BankNote20CountTextBox.Location = new Point(103, 183);
            BankNote20CountTextBox.Name = "BankNote20CountTextBox";
            BankNote20CountTextBox.PlaceholderText = "จำนวน";
            BankNote20CountTextBox.Size = new Size(90, 24);
            BankNote20CountTextBox.TabIndex = 13;
            BankNote20CountTextBox.TextAlign = HorizontalAlignment.Center;
            BankNote20CountTextBox.TextChanged += BankNote20CountTextBox_TextChanged;
            BankNote20CountTextBox.Leave += BankNote20CountTextBox_Leave;
            // 
            // BankNote50CountTextBox
            // 
            BankNote50CountTextBox.BackColor = Color.Cornsilk;
            BankNote50CountTextBox.BorderStyle = BorderStyle.FixedSingle;
            BankNote50CountTextBox.Font = new Font("FC Subject [Non-commercial] Reg", 11.2499981F, FontStyle.Regular, GraphicsUnit.Point);
            BankNote50CountTextBox.Location = new Point(103, 153);
            BankNote50CountTextBox.Name = "BankNote50CountTextBox";
            BankNote50CountTextBox.PlaceholderText = "จำนวน";
            BankNote50CountTextBox.Size = new Size(90, 24);
            BankNote50CountTextBox.TabIndex = 12;
            BankNote50CountTextBox.TextAlign = HorizontalAlignment.Center;
            BankNote50CountTextBox.TextChanged += BankNote50CountTextBox_TextChanged;
            BankNote50CountTextBox.Leave += BankNote50CountTextBox_Leave;
            // 
            // BankNote100CountTextBox
            // 
            BankNote100CountTextBox.BackColor = Color.Cornsilk;
            BankNote100CountTextBox.BorderStyle = BorderStyle.FixedSingle;
            BankNote100CountTextBox.Font = new Font("FC Subject [Non-commercial] Reg", 11.2499981F, FontStyle.Regular, GraphicsUnit.Point);
            BankNote100CountTextBox.Location = new Point(103, 123);
            BankNote100CountTextBox.Name = "BankNote100CountTextBox";
            BankNote100CountTextBox.PlaceholderText = "จำนวน";
            BankNote100CountTextBox.Size = new Size(90, 24);
            BankNote100CountTextBox.TabIndex = 11;
            BankNote100CountTextBox.TextAlign = HorizontalAlignment.Center;
            BankNote100CountTextBox.TextChanged += BankNote100CountTextBox_TextChanged;
            BankNote100CountTextBox.Leave += BankNote100CountTextBox_Leave;
            // 
            // BankNote500CountTextBox
            // 
            BankNote500CountTextBox.BackColor = Color.Cornsilk;
            BankNote500CountTextBox.BorderStyle = BorderStyle.FixedSingle;
            BankNote500CountTextBox.Font = new Font("FC Subject [Non-commercial] Reg", 11.2499981F, FontStyle.Regular, GraphicsUnit.Point);
            BankNote500CountTextBox.Location = new Point(103, 93);
            BankNote500CountTextBox.Name = "BankNote500CountTextBox";
            BankNote500CountTextBox.PlaceholderText = "จำนวน";
            BankNote500CountTextBox.Size = new Size(90, 24);
            BankNote500CountTextBox.TabIndex = 10;
            BankNote500CountTextBox.TextAlign = HorizontalAlignment.Center;
            BankNote500CountTextBox.TextChanged += BankNote500CountTextBox_TextChanged;
            BankNote500CountTextBox.Leave += BankNote500CountTextBox_Leave;
            // 
            // BankNote1000CountTextBox
            // 
            BankNote1000CountTextBox.BackColor = Color.Cornsilk;
            BankNote1000CountTextBox.BorderStyle = BorderStyle.FixedSingle;
            BankNote1000CountTextBox.Font = new Font("FC Subject [Non-commercial] Reg", 11.2499981F, FontStyle.Regular, GraphicsUnit.Point);
            BankNote1000CountTextBox.Location = new Point(103, 63);
            BankNote1000CountTextBox.Name = "BankNote1000CountTextBox";
            BankNote1000CountTextBox.PlaceholderText = "จำนวน";
            BankNote1000CountTextBox.Size = new Size(90, 24);
            BankNote1000CountTextBox.TabIndex = 9;
            BankNote1000CountTextBox.TextAlign = HorizontalAlignment.Center;
            BankNote1000CountTextBox.TextChanged += BankNote1000CountTextBox_TextChanged;
            BankNote1000CountTextBox.Leave += BankNote1000CountTextBox_Leave;
            // 
            // label3
            // 
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.Font = new Font("FC Subject [Non-commercial] Reg", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(21, 153);
            label3.Name = "label3";
            label3.Size = new Size(76, 24);
            label3.TabIndex = 5;
            label3.Text = "50";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            label10.BorderStyle = BorderStyle.FixedSingle;
            label10.Font = new Font("FC Subject [Non-commercial] Reg", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(21, 183);
            label10.Name = "label10";
            label10.Size = new Size(76, 24);
            label10.TabIndex = 6;
            label10.Text = "20";
            label10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // SaveToFileButton
            // 
            SaveToFileButton.BackColor = Color.Wheat;
            SaveToFileButton.Font = new Font("FC Subject [Non-commercial] Reg", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point);
            SaveToFileButton.ForeColor = Color.Black;
            SaveToFileButton.Location = new Point(201, 19);
            SaveToFileButton.Margin = new Padding(6, 7, 6, 7);
            SaveToFileButton.Name = "SaveToFileButton";
            SaveToFileButton.Size = new Size(180, 42);
            SaveToFileButton.TabIndex = 8;
            SaveToFileButton.Text = "บันทึก";
            SaveToFileButton.UseVisualStyleBackColor = false;
            SaveToFileButton.Click += SaveToFileButton_Click;
            // 
            // CalculatedCashTotalLabel
            // 
            CalculatedCashTotalLabel.BackColor = Color.Wheat;
            CalculatedCashTotalLabel.BorderStyle = BorderStyle.FixedSingle;
            CalculatedCashTotalLabel.Font = new Font("FC Subject [Non-commercial] Reg", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point);
            CalculatedCashTotalLabel.ForeColor = Color.Black;
            CalculatedCashTotalLabel.Location = new Point(21, 111);
            CalculatedCashTotalLabel.Name = "CalculatedCashTotalLabel";
            CalculatedCashTotalLabel.Size = new Size(256, 30);
            CalculatedCashTotalLabel.TabIndex = 10;
            CalculatedCashTotalLabel.Text = "0.00";
            CalculatedCashTotalLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            label15.BackColor = Color.FromArgb(38, 38, 38);
            label15.Font = new Font("FC Subject [Non-commercial] Reg", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point);
            label15.ForeColor = Color.WhiteSmoke;
            label15.Location = new Point(21, 82);
            label15.Name = "label15";
            label15.Size = new Size(256, 29);
            label15.TabIndex = 9;
            label15.Text = "ยอดรวมเงินสด [ คำนวณ ]";
            label15.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ActualCashTotalLabel
            // 
            ActualCashTotalLabel.BackColor = Color.Wheat;
            ActualCashTotalLabel.BorderStyle = BorderStyle.FixedSingle;
            ActualCashTotalLabel.Font = new Font("FC Subject [Non-commercial] Reg", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point);
            ActualCashTotalLabel.ForeColor = Color.Black;
            ActualCashTotalLabel.Location = new Point(21, 47);
            ActualCashTotalLabel.Name = "ActualCashTotalLabel";
            ActualCashTotalLabel.Size = new Size(256, 30);
            ActualCashTotalLabel.TabIndex = 12;
            ActualCashTotalLabel.Text = "0.00";
            ActualCashTotalLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label17
            // 
            label17.BackColor = Color.FromArgb(38, 38, 38);
            label17.Font = new Font("FC Subject [Non-commercial] Reg", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point);
            label17.ForeColor = Color.WhiteSmoke;
            label17.Location = new Point(21, 18);
            label17.Name = "label17";
            label17.Size = new Size(256, 29);
            label17.TabIndex = 11;
            label17.Text = "ยอดรวมเงินสด [ นับ ]";
            label17.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // DateLabel
            // 
            DateLabel.BackColor = Color.Tan;
            DateLabel.Font = new Font("FC Subject [Non-commercial] Reg", 11.2499981F, FontStyle.Regular, GraphicsUnit.Point);
            DateLabel.Location = new Point(671, 19);
            DateLabel.Name = "DateLabel";
            DateLabel.Size = new Size(277, 42);
            DateLabel.TabIndex = 9;
            DateLabel.Text = "Date";
            DateLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            label9.BackColor = Color.FromArgb(38, 38, 38);
            label9.Font = new Font("FC Subject [Non-commercial] Reg", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.WhiteSmoke;
            label9.Location = new Point(21, 146);
            label9.Name = "label9";
            label9.Size = new Size(172, 29);
            label9.TabIndex = 13;
            label9.Text = "ผลต่าง";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // DiffCashLabel
            // 
            DiffCashLabel.BackColor = Color.Wheat;
            DiffCashLabel.BorderStyle = BorderStyle.FixedSingle;
            DiffCashLabel.Font = new Font("FC Subject [Non-commercial] Reg", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point);
            DiffCashLabel.ForeColor = Color.Black;
            DiffCashLabel.Location = new Point(21, 175);
            DiffCashLabel.Name = "DiffCashLabel";
            DiffCashLabel.Size = new Size(172, 30);
            DiffCashLabel.TabIndex = 14;
            DiffCashLabel.Text = "0.00";
            DiffCashLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox8
            // 
            groupBox8.Controls.Add(DiffCashDescriptionLabel);
            groupBox8.Controls.Add(label9);
            groupBox8.Controls.Add(ActualCashTotalLabel);
            groupBox8.Controls.Add(DiffCashLabel);
            groupBox8.Controls.Add(label17);
            groupBox8.Controls.Add(label15);
            groupBox8.Controls.Add(CalculatedCashTotalLabel);
            groupBox8.Font = new Font("FC Subject [Non-commercial] Reg", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox8.Location = new Point(983, 468);
            groupBox8.Name = "groupBox8";
            groupBox8.Size = new Size(292, 216);
            groupBox8.TabIndex = 14;
            groupBox8.TabStop = false;
            // 
            // DiffCashDescriptionLabel
            // 
            DiffCashDescriptionLabel.BorderStyle = BorderStyle.FixedSingle;
            DiffCashDescriptionLabel.Font = new Font("FC Subject [Non-commercial] Reg", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point);
            DiffCashDescriptionLabel.ForeColor = Color.Black;
            DiffCashDescriptionLabel.Location = new Point(199, 175);
            DiffCashDescriptionLabel.Name = "DiffCashDescriptionLabel";
            DiffCashDescriptionLabel.Size = new Size(78, 29);
            DiffCashDescriptionLabel.TabIndex = 15;
            DiffCashDescriptionLabel.Text = "?";
            DiffCashDescriptionLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox9
            // 
            groupBox9.Controls.Add(DateLabel);
            groupBox9.Controls.Add(PullLatestDataFromDatabaseButton);
            groupBox9.Controls.Add(SaveToFileButton);
            groupBox9.Location = new Point(15, -1);
            groupBox9.Name = "groupBox9";
            groupBox9.Size = new Size(954, 71);
            groupBox9.TabIndex = 15;
            groupBox9.TabStop = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(11F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Tan;
            ClientSize = new Size(1289, 697);
            Controls.Add(groupBox9);
            Controls.Add(groupBox8);
            Controls.Add(groupBox7);
            Controls.Add(groupBox6);
            Font = new Font("FC Subject [Non-commercial] Reg", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(6, 7, 6, 7);
            Name = "MainForm";
            Text = "IndyPOS Cash Flow";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox6.ResumeLayout(false);
            groupBox7.ResumeLayout(false);
            groupBox7.PerformLayout();
            groupBox8.ResumeLayout(false);
            groupBox9.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button PullLatestDataFromDatabaseButton;
        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private Label HardwareSaleLabel;
        private Label GeneralGoodsSaleLabel;
        private GroupBox groupBox2;
        private Label MoneyTransferPaymentLabel;
        private Label CashPaymentLabel;
        private Label label5;
        private Label label6;
        private Label WelfareCardPaymentLabel;
        private Label label8;
        private GroupBox groupBox3;
        private Label ChangesTotalLabel;
        private Label label14;
        private ListView ChangesListView;
        private GroupBox groupBox4;
        private ListView PayoutsListView;
        private Label PayoutsTotalLabel;
        private Label label4;
        private TextBox ChangeAmountTextBox;
        private Button AddChangeButton;
        private TextBox PayOutAmountTextBox;
        private Button AddPayOutButton;
        private TextBox PayOutItemTextBox;
        private Button RemoveChangeButton;
        private Button RemovePayOutButton;
        private GroupBox groupBox5;
        private Button RemoveReceivedPayLaterPaymentButton;
        private TextBox ReceivedPayLaterAmountTextBox;
        private Button AddReceivedPayLaterPaymentButton;
        private TextBox PayLaterAccountNameTextBox;
        private ListView ReceivedPayLaterPaymentsListView;
        private Label ReceivedPayLaterPaymentsTotalLabel;
        private Label label7;
        private GroupBox groupBox6;
        private GroupBox groupBox7;
        private Label label3;
        private Label label10;
        private TextBox BankNote20CountTextBox;
        private TextBox BankNote50CountTextBox;
        private TextBox BankNote100CountTextBox;
        private TextBox BankNote500CountTextBox;
        private TextBox BankNote1000CountTextBox;
        private Label BankNote20CountTotalLabel;
        private Label BankNote50CountTotalLabel;
        private Label BankNote100CountTotalLabel;
        private Label BankNote500CountTotalLabel;
        private Label BankNote1000CountTotalLabel;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label Coin1CountTotalLabel;
        private Label Coin2CountTotalLabel;
        private Label Coin5CountTotalLabel;
        private Label Coin10CountTotalLabel;
        private Label label27;
        private Label label28;
        private Label label29;
        private TextBox Coin1CountTextBox;
        private TextBox Coin2CountTextBox;
        private TextBox Coin5CountTextBox;
        private TextBox Coin10CountTextBox;
        private Label label30;
        private Label label33;
        private Label label34;
        private Label label35;
        private Label label31;
        private Label label22;
        private Label label21;
        private Button SaveToFileButton;
        private Label CalculatedCashTotalLabel;
        private Label label15;
        private Label ActualCashTotalLabel;
        private Label label17;
        private Label label9;
        private Label DiffCashLabel;
        private GroupBox groupBox8;
        private Label DiffCashDescriptionLabel;
        private Label DateLabel;
        private GroupBox groupBox9;
        private Button ResetCountingButton;
    }
}