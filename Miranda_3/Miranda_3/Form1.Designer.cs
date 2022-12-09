namespace Miranda_3
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
            this.customerinformationGroupBox = new System.Windows.Forms.GroupBox();
            this.zipcodeMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.stateMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.phonenumberMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.streetTextBox = new System.Windows.Forms.TextBox();
            this.lastnameTextBox = new System.Windows.Forms.TextBox();
            this.firstnameTextBox = new System.Windows.Forms.TextBox();
            this.phonenumberLabel = new System.Windows.Forms.Label();
            this.zipcodeLabel = new System.Windows.Forms.Label();
            this.stateLabel = new System.Windows.Forms.Label();
            this.cityLabel = new System.Windows.Forms.Label();
            this.streetLabel = new System.Windows.Forms.Label();
            this.lastnameLabel = new System.Windows.Forms.Label();
            this.firstnameLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.titleComboBox = new System.Windows.Forms.ComboBox();
            this.deliveryinformationGroupBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.homedeliveryRadioButton = new System.Windows.Forms.RadioButton();
            this.storepickupRadioButton = new System.Windows.Forms.RadioButton();
            this.deliverytypeLabel = new System.Windows.Forms.Label();
            this.dateMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.deliverydateLabel = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.extrapriceLabel = new System.Windows.Forms.Label();
            this.personalizedmessageLabel = new System.Windows.Forms.Label();
            this.personalizedmessagepriceLabel = new System.Windows.Forms.Label();
            this.listboxPriceLabel = new System.Windows.Forms.Label();
            this.personalizedmessageTextBox = new System.Windows.Forms.TextBox();
            this.personalizedmessageCheckBox = new System.Windows.Forms.CheckBox();
            this.extrasListBox = new System.Windows.Forms.ListBox();
            this.occassionsComboBox = new System.Windows.Forms.ComboBox();
            this.specialoccasionLabel = new System.Windows.Forms.Label();
            this.dozenLabel = new System.Windows.Forms.Label();
            this.halfdozenLabel = new System.Windows.Forms.Label();
            this.singleLabel = new System.Windows.Forms.Label();
            this.dozenballoonRadioButton = new System.Windows.Forms.RadioButton();
            this.halfdozenRadioButton = new System.Windows.Forms.RadioButton();
            this.singleballoonRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.totalsLabel = new System.Windows.Forms.Label();
            this.saletaxLabel = new System.Windows.Forms.Label();
            this.subLabel = new System.Windows.Forms.Label();
            this.ordertotalLabel = new System.Windows.Forms.Label();
            this.salespriceLabel = new System.Windows.Forms.Label();
            this.subtotalLabel = new System.Windows.Forms.Label();
            this.displaysummaryButton = new System.Windows.Forms.Button();
            this.clearformButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.balloonsPictureBox = new System.Windows.Forms.PictureBox();
            this.companyLabel = new System.Windows.Forms.Label();
            this.starthereLabel = new System.Windows.Forms.Label();
            this.customerinformationGroupBox.SuspendLayout();
            this.deliveryinformationGroupBox.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.balloonsPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // customerinformationGroupBox
            // 
            this.customerinformationGroupBox.Controls.Add(this.zipcodeMaskedTextBox);
            this.customerinformationGroupBox.Controls.Add(this.stateMaskedTextBox);
            this.customerinformationGroupBox.Controls.Add(this.phonenumberMaskedTextBox);
            this.customerinformationGroupBox.Controls.Add(this.cityTextBox);
            this.customerinformationGroupBox.Controls.Add(this.streetTextBox);
            this.customerinformationGroupBox.Controls.Add(this.lastnameTextBox);
            this.customerinformationGroupBox.Controls.Add(this.firstnameTextBox);
            this.customerinformationGroupBox.Controls.Add(this.phonenumberLabel);
            this.customerinformationGroupBox.Controls.Add(this.zipcodeLabel);
            this.customerinformationGroupBox.Controls.Add(this.stateLabel);
            this.customerinformationGroupBox.Controls.Add(this.cityLabel);
            this.customerinformationGroupBox.Controls.Add(this.streetLabel);
            this.customerinformationGroupBox.Controls.Add(this.lastnameLabel);
            this.customerinformationGroupBox.Controls.Add(this.firstnameLabel);
            this.customerinformationGroupBox.Controls.Add(this.titleLabel);
            this.customerinformationGroupBox.Controls.Add(this.titleComboBox);
            this.customerinformationGroupBox.Location = new System.Drawing.Point(247, 236);
            this.customerinformationGroupBox.Name = "customerinformationGroupBox";
            this.customerinformationGroupBox.Size = new System.Drawing.Size(241, 302);
            this.customerinformationGroupBox.TabIndex = 2;
            this.customerinformationGroupBox.TabStop = false;
            this.customerinformationGroupBox.Text = "Customer Information";
            // 
            // zipcodeMaskedTextBox
            // 
            this.zipcodeMaskedTextBox.Location = new System.Drawing.Point(97, 207);
            this.zipcodeMaskedTextBox.Mask = "#####";
            this.zipcodeMaskedTextBox.Name = "zipcodeMaskedTextBox";
            this.zipcodeMaskedTextBox.Size = new System.Drawing.Size(100, 20);
            this.zipcodeMaskedTextBox.TabIndex = 14;
            // 
            // stateMaskedTextBox
            // 
            this.stateMaskedTextBox.Location = new System.Drawing.Point(97, 177);
            this.stateMaskedTextBox.Mask = ">L>L";
            this.stateMaskedTextBox.Name = "stateMaskedTextBox";
            this.stateMaskedTextBox.Size = new System.Drawing.Size(100, 20);
            this.stateMaskedTextBox.TabIndex = 13;
            // 
            // phonenumberMaskedTextBox
            // 
            this.phonenumberMaskedTextBox.Location = new System.Drawing.Point(97, 243);
            this.phonenumberMaskedTextBox.Mask = "(999) 000-0000";
            this.phonenumberMaskedTextBox.Name = "phonenumberMaskedTextBox";
            this.phonenumberMaskedTextBox.Size = new System.Drawing.Size(100, 20);
            this.phonenumberMaskedTextBox.TabIndex = 15;
            // 
            // cityTextBox
            // 
            this.cityTextBox.Location = new System.Drawing.Point(97, 151);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(100, 20);
            this.cityTextBox.TabIndex = 12;
            // 
            // streetTextBox
            // 
            this.streetTextBox.Location = new System.Drawing.Point(97, 118);
            this.streetTextBox.Name = "streetTextBox";
            this.streetTextBox.Size = new System.Drawing.Size(100, 20);
            this.streetTextBox.TabIndex = 11;
            // 
            // lastnameTextBox
            // 
            this.lastnameTextBox.Location = new System.Drawing.Point(97, 79);
            this.lastnameTextBox.Name = "lastnameTextBox";
            this.lastnameTextBox.Size = new System.Drawing.Size(100, 20);
            this.lastnameTextBox.TabIndex = 10;
            // 
            // firstnameTextBox
            // 
            this.firstnameTextBox.Location = new System.Drawing.Point(97, 46);
            this.firstnameTextBox.Name = "firstnameTextBox";
            this.firstnameTextBox.Size = new System.Drawing.Size(100, 20);
            this.firstnameTextBox.TabIndex = 9;
            // 
            // phonenumberLabel
            // 
            this.phonenumberLabel.AutoSize = true;
            this.phonenumberLabel.Location = new System.Drawing.Point(11, 246);
            this.phonenumberLabel.Name = "phonenumberLabel";
            this.phonenumberLabel.Size = new System.Drawing.Size(81, 13);
            this.phonenumberLabel.TabIndex = 8;
            this.phonenumberLabel.Text = "Phone Number:";
            // 
            // zipcodeLabel
            // 
            this.zipcodeLabel.AutoSize = true;
            this.zipcodeLabel.Location = new System.Drawing.Point(11, 210);
            this.zipcodeLabel.Name = "zipcodeLabel";
            this.zipcodeLabel.Size = new System.Drawing.Size(53, 13);
            this.zipcodeLabel.TabIndex = 7;
            this.zipcodeLabel.Text = "Zip Code:";
            // 
            // stateLabel
            // 
            this.stateLabel.AutoSize = true;
            this.stateLabel.Location = new System.Drawing.Point(11, 178);
            this.stateLabel.Name = "stateLabel";
            this.stateLabel.Size = new System.Drawing.Size(35, 13);
            this.stateLabel.TabIndex = 6;
            this.stateLabel.Text = "State:";
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Location = new System.Drawing.Point(11, 151);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(27, 13);
            this.cityLabel.TabIndex = 5;
            this.cityLabel.Text = "City:";
            // 
            // streetLabel
            // 
            this.streetLabel.AutoSize = true;
            this.streetLabel.Location = new System.Drawing.Point(11, 121);
            this.streetLabel.Name = "streetLabel";
            this.streetLabel.Size = new System.Drawing.Size(38, 13);
            this.streetLabel.TabIndex = 4;
            this.streetLabel.Text = "Street:";
            // 
            // lastnameLabel
            // 
            this.lastnameLabel.AutoSize = true;
            this.lastnameLabel.Location = new System.Drawing.Point(11, 86);
            this.lastnameLabel.Name = "lastnameLabel";
            this.lastnameLabel.Size = new System.Drawing.Size(61, 13);
            this.lastnameLabel.TabIndex = 3;
            this.lastnameLabel.Text = "Last Name:";
            // 
            // firstnameLabel
            // 
            this.firstnameLabel.AutoSize = true;
            this.firstnameLabel.Location = new System.Drawing.Point(7, 53);
            this.firstnameLabel.Name = "firstnameLabel";
            this.firstnameLabel.Size = new System.Drawing.Size(60, 13);
            this.firstnameLabel.TabIndex = 2;
            this.firstnameLabel.Text = "First Name:";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(11, 27);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(30, 13);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "Title:";
            // 
            // titleComboBox
            // 
            this.titleComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.titleComboBox.FormattingEnabled = true;
            this.titleComboBox.Items.AddRange(new object[] {
            "Dr.",
            "Mr.",
            "Mrs.",
            "Ms.",
            "Rev."});
            this.titleComboBox.Location = new System.Drawing.Point(76, 19);
            this.titleComboBox.Name = "titleComboBox";
            this.titleComboBox.Size = new System.Drawing.Size(121, 21);
            this.titleComboBox.TabIndex = 0;
            // 
            // deliveryinformationGroupBox
            // 
            this.deliveryinformationGroupBox.Controls.Add(this.label1);
            this.deliveryinformationGroupBox.Controls.Add(this.homedeliveryRadioButton);
            this.deliveryinformationGroupBox.Controls.Add(this.storepickupRadioButton);
            this.deliveryinformationGroupBox.Controls.Add(this.deliverytypeLabel);
            this.deliveryinformationGroupBox.Controls.Add(this.dateMaskedTextBox);
            this.deliveryinformationGroupBox.Controls.Add(this.deliverydateLabel);
            this.deliveryinformationGroupBox.Location = new System.Drawing.Point(12, 125);
            this.deliveryinformationGroupBox.Name = "deliveryinformationGroupBox";
            this.deliveryinformationGroupBox.Size = new System.Drawing.Size(229, 138);
            this.deliveryinformationGroupBox.TabIndex = 0;
            this.deliveryinformationGroupBox.TabStop = false;
            this.deliveryinformationGroupBox.Text = "Delivery Information";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(6, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 1);
            this.label1.TabIndex = 2;
            // 
            // homedeliveryRadioButton
            // 
            this.homedeliveryRadioButton.AutoSize = true;
            this.homedeliveryRadioButton.Location = new System.Drawing.Point(112, 98);
            this.homedeliveryRadioButton.Name = "homedeliveryRadioButton";
            this.homedeliveryRadioButton.Size = new System.Drawing.Size(94, 17);
            this.homedeliveryRadioButton.TabIndex = 3;
            this.homedeliveryRadioButton.Text = "Home Delivery";
            this.homedeliveryRadioButton.UseVisualStyleBackColor = true;
            this.homedeliveryRadioButton.CheckedChanged += new System.EventHandler(this.homedeliveryRadioButton_CheckedChanged);
            // 
            // storepickupRadioButton
            // 
            this.storepickupRadioButton.AutoSize = true;
            this.storepickupRadioButton.Checked = true;
            this.storepickupRadioButton.Location = new System.Drawing.Point(9, 98);
            this.storepickupRadioButton.Name = "storepickupRadioButton";
            this.storepickupRadioButton.Size = new System.Drawing.Size(91, 17);
            this.storepickupRadioButton.TabIndex = 2;
            this.storepickupRadioButton.TabStop = true;
            this.storepickupRadioButton.Text = "Store Pick-Up";
            this.storepickupRadioButton.UseVisualStyleBackColor = true;
            // 
            // deliverytypeLabel
            // 
            this.deliverytypeLabel.AutoSize = true;
            this.deliverytypeLabel.Location = new System.Drawing.Point(64, 65);
            this.deliverytypeLabel.Name = "deliverytypeLabel";
            this.deliverytypeLabel.Size = new System.Drawing.Size(75, 13);
            this.deliverytypeLabel.TabIndex = 2;
            this.deliverytypeLabel.Text = "Delivery Type:";
            // 
            // dateMaskedTextBox
            // 
            this.dateMaskedTextBox.Location = new System.Drawing.Point(86, 24);
            this.dateMaskedTextBox.Mask = "00/00/0000";
            this.dateMaskedTextBox.Name = "dateMaskedTextBox";
            this.dateMaskedTextBox.Size = new System.Drawing.Size(100, 20);
            this.dateMaskedTextBox.TabIndex = 1;
            this.dateMaskedTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // deliverydateLabel
            // 
            this.deliverydateLabel.AutoSize = true;
            this.deliverydateLabel.Location = new System.Drawing.Point(6, 27);
            this.deliverydateLabel.Name = "deliverydateLabel";
            this.deliverydateLabel.Size = new System.Drawing.Size(74, 13);
            this.deliverydateLabel.TabIndex = 0;
            this.deliverydateLabel.Text = "Delivery Date:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.extrapriceLabel);
            this.groupBox3.Controls.Add(this.personalizedmessageLabel);
            this.groupBox3.Controls.Add(this.personalizedmessagepriceLabel);
            this.groupBox3.Controls.Add(this.listboxPriceLabel);
            this.groupBox3.Controls.Add(this.personalizedmessageTextBox);
            this.groupBox3.Controls.Add(this.personalizedmessageCheckBox);
            this.groupBox3.Controls.Add(this.extrasListBox);
            this.groupBox3.Controls.Add(this.occassionsComboBox);
            this.groupBox3.Controls.Add(this.specialoccasionLabel);
            this.groupBox3.Controls.Add(this.dozenLabel);
            this.groupBox3.Controls.Add(this.halfdozenLabel);
            this.groupBox3.Controls.Add(this.singleLabel);
            this.groupBox3.Controls.Add(this.dozenballoonRadioButton);
            this.groupBox3.Controls.Add(this.halfdozenRadioButton);
            this.groupBox3.Controls.Add(this.singleballoonRadioButton);
            this.groupBox3.Location = new System.Drawing.Point(12, 265);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(229, 409);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Order Details";
            // 
            // extrapriceLabel
            // 
            this.extrapriceLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.extrapriceLabel.Location = new System.Drawing.Point(142, 196);
            this.extrapriceLabel.Name = "extrapriceLabel";
            this.extrapriceLabel.Size = new System.Drawing.Size(50, 23);
            this.extrapriceLabel.TabIndex = 10;
            // 
            // personalizedmessageLabel
            // 
            this.personalizedmessageLabel.Location = new System.Drawing.Point(142, 327);
            this.personalizedmessageLabel.Name = "personalizedmessageLabel";
            this.personalizedmessageLabel.Size = new System.Drawing.Size(35, 13);
            this.personalizedmessageLabel.TabIndex = 13;
            // 
            // personalizedmessagepriceLabel
            // 
            this.personalizedmessagepriceLabel.AutoSize = true;
            this.personalizedmessagepriceLabel.Location = new System.Drawing.Point(142, 309);
            this.personalizedmessagepriceLabel.Name = "personalizedmessagepriceLabel";
            this.personalizedmessagepriceLabel.Size = new System.Drawing.Size(42, 13);
            this.personalizedmessagepriceLabel.TabIndex = 12;
            this.personalizedmessagepriceLabel.Text = "PRICE:";
            // 
            // listboxPriceLabel
            // 
            this.listboxPriceLabel.AutoSize = true;
            this.listboxPriceLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listboxPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listboxPriceLabel.Location = new System.Drawing.Point(142, 170);
            this.listboxPriceLabel.Name = "listboxPriceLabel";
            this.listboxPriceLabel.Size = new System.Drawing.Size(50, 15);
            this.listboxPriceLabel.TabIndex = 9;
            this.listboxPriceLabel.Text = "PRICE:";
            // 
            // personalizedmessageTextBox
            // 
            this.personalizedmessageTextBox.Enabled = false;
            this.personalizedmessageTextBox.Location = new System.Drawing.Point(6, 348);
            this.personalizedmessageTextBox.MaxLength = 30;
            this.personalizedmessageTextBox.Name = "personalizedmessageTextBox";
            this.personalizedmessageTextBox.Size = new System.Drawing.Size(171, 20);
            this.personalizedmessageTextBox.TabIndex = 12;
            // 
            // personalizedmessageCheckBox
            // 
            this.personalizedmessageCheckBox.AutoSize = true;
            this.personalizedmessageCheckBox.Location = new System.Drawing.Point(6, 309);
            this.personalizedmessageCheckBox.Name = "personalizedmessageCheckBox";
            this.personalizedmessageCheckBox.Size = new System.Drawing.Size(135, 17);
            this.personalizedmessageCheckBox.TabIndex = 11;
            this.personalizedmessageCheckBox.Text = "Personalized Message:";
            this.personalizedmessageCheckBox.UseVisualStyleBackColor = true;
            // 
            // extrasListBox
            // 
            this.extrasListBox.FormattingEnabled = true;
            this.extrasListBox.Location = new System.Drawing.Point(10, 170);
            this.extrasListBox.Name = "extrasListBox";
            this.extrasListBox.Size = new System.Drawing.Size(120, 95);
            this.extrasListBox.TabIndex = 5;
            // 
            // occassionsComboBox
            // 
            this.occassionsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.occassionsComboBox.FormattingEnabled = true;
            this.occassionsComboBox.Location = new System.Drawing.Point(105, 32);
            this.occassionsComboBox.Name = "occassionsComboBox";
            this.occassionsComboBox.Size = new System.Drawing.Size(108, 21);
            this.occassionsComboBox.TabIndex = 2;
            // 
            // specialoccasionLabel
            // 
            this.specialoccasionLabel.AutoSize = true;
            this.specialoccasionLabel.Location = new System.Drawing.Point(6, 35);
            this.specialoccasionLabel.Name = "specialoccasionLabel";
            this.specialoccasionLabel.Size = new System.Drawing.Size(93, 13);
            this.specialoccasionLabel.TabIndex = 1;
            this.specialoccasionLabel.Text = "Special Occasion:";
            // 
            // dozenLabel
            // 
            this.dozenLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dozenLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dozenLabel.Location = new System.Drawing.Point(138, 128);
            this.dozenLabel.Name = "dozenLabel";
            this.dozenLabel.Size = new System.Drawing.Size(48, 15);
            this.dozenLabel.TabIndex = 8;
            // 
            // halfdozenLabel
            // 
            this.halfdozenLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.halfdozenLabel.Enabled = false;
            this.halfdozenLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.halfdozenLabel.Location = new System.Drawing.Point(138, 102);
            this.halfdozenLabel.Name = "halfdozenLabel";
            this.halfdozenLabel.Size = new System.Drawing.Size(48, 15);
            this.halfdozenLabel.TabIndex = 7;
            // 
            // singleLabel
            // 
            this.singleLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.singleLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.singleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.singleLabel.Location = new System.Drawing.Point(138, 75);
            this.singleLabel.Name = "singleLabel";
            this.singleLabel.Size = new System.Drawing.Size(48, 15);
            this.singleLabel.TabIndex = 6;
            // 
            // dozenballoonRadioButton
            // 
            this.dozenballoonRadioButton.AutoSize = true;
            this.dozenballoonRadioButton.Location = new System.Drawing.Point(9, 126);
            this.dozenballoonRadioButton.Name = "dozenballoonRadioButton";
            this.dozenballoonRadioButton.Size = new System.Drawing.Size(93, 17);
            this.dozenballoonRadioButton.TabIndex = 4;
            this.dozenballoonRadioButton.Text = "Dozen Ballons";
            this.dozenballoonRadioButton.UseVisualStyleBackColor = true;
            this.dozenballoonRadioButton.CheckedChanged += new System.EventHandler(this.dozenballoonRadioButton_CheckedChanged);
            // 
            // halfdozenRadioButton
            // 
            this.halfdozenRadioButton.AutoSize = true;
            this.halfdozenRadioButton.Location = new System.Drawing.Point(9, 98);
            this.halfdozenRadioButton.Name = "halfdozenRadioButton";
            this.halfdozenRadioButton.Size = new System.Drawing.Size(121, 17);
            this.halfdozenRadioButton.TabIndex = 3;
            this.halfdozenRadioButton.Text = "Half-Dozen Balloons";
            this.halfdozenRadioButton.UseVisualStyleBackColor = true;
            this.halfdozenRadioButton.CheckedChanged += new System.EventHandler(this.halfdozenRadioButton_CheckedChanged);
            // 
            // singleballoonRadioButton
            // 
            this.singleballoonRadioButton.AutoSize = true;
            this.singleballoonRadioButton.Checked = true;
            this.singleballoonRadioButton.Location = new System.Drawing.Point(10, 73);
            this.singleballoonRadioButton.Name = "singleballoonRadioButton";
            this.singleballoonRadioButton.Size = new System.Drawing.Size(92, 17);
            this.singleballoonRadioButton.TabIndex = 2;
            this.singleballoonRadioButton.TabStop = true;
            this.singleballoonRadioButton.Text = "Single Balloon";
            this.singleballoonRadioButton.UseVisualStyleBackColor = true;
            this.singleballoonRadioButton.CheckedChanged += new System.EventHandler(this.singleballoonRadioButton_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox4.Controls.Add(this.totalsLabel);
            this.groupBox4.Controls.Add(this.saletaxLabel);
            this.groupBox4.Controls.Add(this.subLabel);
            this.groupBox4.Controls.Add(this.ordertotalLabel);
            this.groupBox4.Controls.Add(this.salespriceLabel);
            this.groupBox4.Controls.Add(this.subtotalLabel);
            this.groupBox4.Location = new System.Drawing.Point(247, 544);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(241, 130);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Order Totals";
            // 
            // totalsLabel
            // 
            this.totalsLabel.BackColor = System.Drawing.Color.White;
            this.totalsLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalsLabel.Location = new System.Drawing.Point(97, 91);
            this.totalsLabel.Name = "totalsLabel";
            this.totalsLabel.Size = new System.Drawing.Size(100, 23);
            this.totalsLabel.TabIndex = 8;
            // 
            // saletaxLabel
            // 
            this.saletaxLabel.BackColor = System.Drawing.Color.White;
            this.saletaxLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.saletaxLabel.Location = new System.Drawing.Point(97, 57);
            this.saletaxLabel.Name = "saletaxLabel";
            this.saletaxLabel.Size = new System.Drawing.Size(100, 23);
            this.saletaxLabel.TabIndex = 7;
            // 
            // subLabel
            // 
            this.subLabel.BackColor = System.Drawing.Color.White;
            this.subLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.subLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.subLabel.Location = new System.Drawing.Point(97, 26);
            this.subLabel.Name = "subLabel";
            this.subLabel.Size = new System.Drawing.Size(100, 23);
            this.subLabel.TabIndex = 6;
            // 
            // ordertotalLabel
            // 
            this.ordertotalLabel.AutoSize = true;
            this.ordertotalLabel.Location = new System.Drawing.Point(11, 92);
            this.ordertotalLabel.Name = "ordertotalLabel";
            this.ordertotalLabel.Size = new System.Drawing.Size(63, 13);
            this.ordertotalLabel.TabIndex = 2;
            this.ordertotalLabel.Text = "Order Total:";
            // 
            // salespriceLabel
            // 
            this.salespriceLabel.AutoSize = true;
            this.salespriceLabel.Location = new System.Drawing.Point(11, 58);
            this.salespriceLabel.Name = "salespriceLabel";
            this.salespriceLabel.Size = new System.Drawing.Size(57, 13);
            this.salespriceLabel.TabIndex = 1;
            this.salespriceLabel.Text = "Sales Tax:";
            // 
            // subtotalLabel
            // 
            this.subtotalLabel.AutoSize = true;
            this.subtotalLabel.Location = new System.Drawing.Point(11, 26);
            this.subtotalLabel.Name = "subtotalLabel";
            this.subtotalLabel.Size = new System.Drawing.Size(49, 13);
            this.subtotalLabel.TabIndex = 0;
            this.subtotalLabel.Text = "Subtotal:";
            // 
            // displaysummaryButton
            // 
            this.displaysummaryButton.Location = new System.Drawing.Point(334, 697);
            this.displaysummaryButton.Name = "displaysummaryButton";
            this.displaysummaryButton.Size = new System.Drawing.Size(75, 48);
            this.displaysummaryButton.TabIndex = 3;
            this.displaysummaryButton.Text = "Display Summary";
            this.displaysummaryButton.UseVisualStyleBackColor = true;
            // 
            // clearformButton
            // 
            this.clearformButton.Location = new System.Drawing.Point(185, 697);
            this.clearformButton.Name = "clearformButton";
            this.clearformButton.Size = new System.Drawing.Size(75, 48);
            this.clearformButton.TabIndex = 4;
            this.clearformButton.Text = "Clear Form";
            this.clearformButton.UseVisualStyleBackColor = true;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(39, 697);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 48);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "Exit Program";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // balloonsPictureBox
            // 
            this.balloonsPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.balloonsPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("balloonsPictureBox.Image")));
            this.balloonsPictureBox.Location = new System.Drawing.Point(247, 12);
            this.balloonsPictureBox.Name = "balloonsPictureBox";
            this.balloonsPictureBox.Size = new System.Drawing.Size(241, 217);
            this.balloonsPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.balloonsPictureBox.TabIndex = 6;
            this.balloonsPictureBox.TabStop = false;
            // 
            // companyLabel
            // 
            this.companyLabel.AutoSize = true;
            this.companyLabel.Font = new System.Drawing.Font("Magneto", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.companyLabel.Location = new System.Drawing.Point(-1, 12);
            this.companyLabel.Name = "companyLabel";
            this.companyLabel.Size = new System.Drawing.Size(242, 28);
            this.companyLabel.TabIndex = 7;
            this.companyLabel.Text = "Bonnie\'s Balloons";
            // 
            // starthereLabel
            // 
            this.starthereLabel.AutoSize = true;
            this.starthereLabel.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.starthereLabel.Location = new System.Drawing.Point(34, 86);
            this.starthereLabel.Name = "starthereLabel";
            this.starthereLabel.Size = new System.Drawing.Size(175, 26);
            this.starthereLabel.TabIndex = 8;
            this.starthereLabel.Text = "Please Start Here !";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 774);
            this.Controls.Add(this.starthereLabel);
            this.Controls.Add(this.companyLabel);
            this.Controls.Add(this.balloonsPictureBox);
            this.Controls.Add(this.displaysummaryButton);
            this.Controls.Add(this.clearformButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.deliveryinformationGroupBox);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.customerinformationGroupBox);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bonnie\'s Ballons";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.customerinformationGroupBox.ResumeLayout(false);
            this.customerinformationGroupBox.PerformLayout();
            this.deliveryinformationGroupBox.ResumeLayout(false);
            this.deliveryinformationGroupBox.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.balloonsPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox customerinformationGroupBox;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.ComboBox titleComboBox;
        private System.Windows.Forms.GroupBox deliveryinformationGroupBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.MaskedTextBox stateMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox phonenumberMaskedTextBox;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.TextBox streetTextBox;
        private System.Windows.Forms.TextBox lastnameTextBox;
        private System.Windows.Forms.TextBox firstnameTextBox;
        private System.Windows.Forms.Label phonenumberLabel;
        private System.Windows.Forms.Label zipcodeLabel;
        private System.Windows.Forms.Label stateLabel;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.Label streetLabel;
        private System.Windows.Forms.Label lastnameLabel;
        private System.Windows.Forms.Label firstnameLabel;
        private System.Windows.Forms.MaskedTextBox zipcodeMaskedTextBox;
        private System.Windows.Forms.Label deliverydateLabel;
        private System.Windows.Forms.MaskedTextBox dateMaskedTextBox;
        private System.Windows.Forms.Label deliverytypeLabel;
        private System.Windows.Forms.RadioButton homedeliveryRadioButton;
        private System.Windows.Forms.RadioButton storepickupRadioButton;
        private System.Windows.Forms.ComboBox occassionsComboBox;
        private System.Windows.Forms.Label specialoccasionLabel;
        private System.Windows.Forms.Label dozenLabel;
        private System.Windows.Forms.Label halfdozenLabel;
        private System.Windows.Forms.Label singleLabel;
        private System.Windows.Forms.RadioButton dozenballoonRadioButton;
        private System.Windows.Forms.RadioButton halfdozenRadioButton;
        private System.Windows.Forms.RadioButton singleballoonRadioButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox extrasListBox;
        private System.Windows.Forms.CheckBox personalizedmessageCheckBox;
        private System.Windows.Forms.TextBox personalizedmessageTextBox;
        private System.Windows.Forms.Label ordertotalLabel;
        private System.Windows.Forms.Label salespriceLabel;
        private System.Windows.Forms.Label subtotalLabel;
        private System.Windows.Forms.Button displaysummaryButton;
        private System.Windows.Forms.Button clearformButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label extrapriceLabel;
        private System.Windows.Forms.Label personalizedmessageLabel;
        private System.Windows.Forms.Label personalizedmessagepriceLabel;
        private System.Windows.Forms.Label listboxPriceLabel;
        private System.Windows.Forms.Label totalsLabel;
        private System.Windows.Forms.Label saletaxLabel;
        private System.Windows.Forms.Label subLabel;
        private System.Windows.Forms.PictureBox balloonsPictureBox;
        private System.Windows.Forms.Label companyLabel;
        private System.Windows.Forms.Label starthereLabel;
    }
}

