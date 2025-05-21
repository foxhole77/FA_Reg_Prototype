namespace FA_Reg_Prototype
{
    partial class RegForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegForm));
            lblRegFormTitle = new Label();
            lblUserInstruction = new Label();
            lblLastName = new Label();
            lblFirstName = new Label();
            tbLastName = new TextBox();
            tbFirstName = new TextBox();
            lblUserListInstruct = new Label();
            btnAttending = new Button();
            lbEmployees = new ListBox();
            lblCamera = new Label();
            cboCamera = new ComboBox();
            pbCamera = new PictureBox();
            txtQRCode = new TextBox();
            btnStartCamera = new Button();
            timerCamera = new System.Windows.Forms.Timer(components);
            panelScanID = new Panel();
            btnScanRegAbort = new Button();
            panelManIDEntry = new Panel();
            btnManRegAbort = new Button();
            panelHomeScreen = new Panel();
            pictureBox1 = new PictureBox();
            btnTypeOption = new Button();
            btnScanOption = new Button();
            lblQuestion = new Label();
            panelPositiveFeedback = new Panel();
            lblResetText = new Label();
            picboxSuccessImage = new PictureBox();
            lblNameRegSuccess = new Label();
            panelNegativeFeedback = new Panel();
            lblNegFeebackResetText = new Label();
            picboxNegativeFeedbackImage = new PictureBox();
            lblRegAbort = new Label();
            timerConfirmationScreen = new System.Windows.Forms.Timer(components);
            timerAbortReg = new System.Windows.Forms.Timer(components);
            panelNonActiveMember = new Panel();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            btnNotActiveOkay = new Button();
            lblGuestInstructions = new Label();
            lblMembershipName = new Label();
            ((System.ComponentModel.ISupportInitialize)pbCamera).BeginInit();
            panelScanID.SuspendLayout();
            panelManIDEntry.SuspendLayout();
            panelHomeScreen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelPositiveFeedback.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picboxSuccessImage).BeginInit();
            panelNegativeFeedback.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picboxNegativeFeedbackImage).BeginInit();
            panelNonActiveMember.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // lblRegFormTitle
            // 
            lblRegFormTitle.AutoSize = true;
            lblRegFormTitle.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRegFormTitle.Location = new Point(27, 6);
            lblRegFormTitle.Name = "lblRegFormTitle";
            lblRegFormTitle.Size = new Size(423, 32);
            lblRegFormTitle.TabIndex = 0;
            lblRegFormTitle.Text = "Registration For Coffee (May 10, 2025)";
            // 
            // lblUserInstruction
            // 
            lblUserInstruction.AutoSize = true;
            lblUserInstruction.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUserInstruction.Location = new Point(17, 8);
            lblUserInstruction.Name = "lblUserInstruction";
            lblUserInstruction.Size = new Size(360, 21);
            lblUserInstruction.TabIndex = 1;
            lblUserInstruction.Text = "Enter letters from your name to filter the list below";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLastName.Location = new Point(18, 40);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(84, 21);
            lblLastName.TabIndex = 2;
            lblLastName.Text = "Last Name";
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFirstName.Location = new Point(379, 37);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(86, 21);
            lblFirstName.TabIndex = 3;
            lblFirstName.Text = "First Name";
            // 
            // tbLastName
            // 
            tbLastName.Location = new Point(120, 37);
            tbLastName.Name = "tbLastName";
            tbLastName.Size = new Size(227, 23);
            tbLastName.TabIndex = 4;
            tbLastName.TextChanged += tbLastName_TextChanged;
            // 
            // tbFirstName
            // 
            tbFirstName.Location = new Point(482, 37);
            tbFirstName.Name = "tbFirstName";
            tbFirstName.Size = new Size(227, 23);
            tbFirstName.TabIndex = 5;
            tbFirstName.TextChanged += tbFirstName_TextChanged;
            // 
            // lblUserListInstruct
            // 
            lblUserListInstruct.AutoSize = true;
            lblUserListInstruct.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUserListInstruct.Location = new Point(17, 88);
            lblUserListInstruct.Name = "lblUserListInstruct";
            lblUserListInstruct.Size = new Size(389, 25);
            lblUserListInstruct.TabIndex = 6;
            lblUserListInstruct.Text = "Select your name below then Click Attending";
            // 
            // btnAttending
            // 
            btnAttending.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAttending.Location = new Point(20, 327);
            btnAttending.Name = "btnAttending";
            btnAttending.Size = new Size(266, 53);
            btnAttending.TabIndex = 8;
            btnAttending.Text = "I am attending (Click Me)";
            btnAttending.UseVisualStyleBackColor = true;
            btnAttending.Click += btnAttending_Click;
            // 
            // lbEmployees
            // 
            lbEmployees.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbEmployees.FormattingEnabled = true;
            lbEmployees.Location = new Point(17, 123);
            lbEmployees.Name = "lbEmployees";
            lbEmployees.Size = new Size(739, 151);
            lbEmployees.TabIndex = 10;
            lbEmployees.SelectedIndexChanged += lbEmployees_SelectedIndexChanged;
            // 
            // lblCamera
            // 
            lblCamera.AutoSize = true;
            lblCamera.Location = new Point(20, 14);
            lblCamera.Name = "lblCamera";
            lblCamera.Size = new Size(48, 15);
            lblCamera.TabIndex = 11;
            lblCamera.Text = "Camera";
            // 
            // cboCamera
            // 
            cboCamera.FormattingEnabled = true;
            cboCamera.Location = new Point(74, 11);
            cboCamera.Name = "cboCamera";
            cboCamera.Size = new Size(235, 23);
            cboCamera.TabIndex = 12;
            // 
            // pbCamera
            // 
            pbCamera.BorderStyle = BorderStyle.Fixed3D;
            pbCamera.Location = new Point(20, 40);
            pbCamera.Name = "pbCamera";
            pbCamera.Size = new Size(289, 310);
            pbCamera.TabIndex = 13;
            pbCamera.TabStop = false;
            // 
            // txtQRCode
            // 
            txtQRCode.Location = new Point(358, 298);
            txtQRCode.Name = "txtQRCode";
            txtQRCode.Size = new Size(100, 23);
            txtQRCode.TabIndex = 14;
            txtQRCode.Visible = false;
            // 
            // btnStartCamera
            // 
            btnStartCamera.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnStartCamera.Location = new Point(372, 32);
            btnStartCamera.Name = "btnStartCamera";
            btnStartCamera.Size = new Size(435, 59);
            btnStartCamera.TabIndex = 15;
            btnStartCamera.Text = "Scan in my CTA ID (QR Code)";
            btnStartCamera.UseVisualStyleBackColor = true;
            btnStartCamera.Click += btnStartCamera_Click;
            // 
            // timerCamera
            // 
            timerCamera.Interval = 1000;
            timerCamera.Tick += timerCamera_Tick;
            // 
            // panelScanID
            // 
            panelScanID.Controls.Add(btnScanRegAbort);
            panelScanID.Controls.Add(pbCamera);
            panelScanID.Controls.Add(btnStartCamera);
            panelScanID.Controls.Add(txtQRCode);
            panelScanID.Controls.Add(lblCamera);
            panelScanID.Controls.Add(cboCamera);
            panelScanID.Location = new Point(27, 41);
            panelScanID.Name = "panelScanID";
            panelScanID.Size = new Size(845, 410);
            panelScanID.TabIndex = 16;
            panelScanID.Visible = false;
            // 
            // btnScanRegAbort
            // 
            btnScanRegAbort.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnScanRegAbort.Location = new Point(372, 137);
            btnScanRegAbort.Name = "btnScanRegAbort";
            btnScanRegAbort.Size = new Size(435, 69);
            btnScanRegAbort.TabIndex = 16;
            btnScanRegAbort.Text = "Oops take me to type my name";
            btnScanRegAbort.UseVisualStyleBackColor = true;
            btnScanRegAbort.Click += btnScanRegAbort_Click;
            // 
            // panelManIDEntry
            // 
            panelManIDEntry.Controls.Add(btnManRegAbort);
            panelManIDEntry.Controls.Add(lblUserInstruction);
            panelManIDEntry.Controls.Add(lbEmployees);
            panelManIDEntry.Controls.Add(lblLastName);
            panelManIDEntry.Controls.Add(btnAttending);
            panelManIDEntry.Controls.Add(lblFirstName);
            panelManIDEntry.Controls.Add(lblUserListInstruct);
            panelManIDEntry.Controls.Add(tbLastName);
            panelManIDEntry.Controls.Add(tbFirstName);
            panelManIDEntry.Location = new Point(27, 41);
            panelManIDEntry.Name = "panelManIDEntry";
            panelManIDEntry.Size = new Size(845, 410);
            panelManIDEntry.TabIndex = 16;
            panelManIDEntry.Visible = false;
            // 
            // btnManRegAbort
            // 
            btnManRegAbort.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnManRegAbort.Location = new Point(321, 327);
            btnManRegAbort.Name = "btnManRegAbort";
            btnManRegAbort.Size = new Size(435, 53);
            btnManRegAbort.TabIndex = 11;
            btnManRegAbort.Text = "Oops take me to scan my CTA ID (QR Code)";
            btnManRegAbort.UseVisualStyleBackColor = true;
            btnManRegAbort.Click += btnManRegAbort_Click;
            // 
            // panelHomeScreen
            // 
            panelHomeScreen.Controls.Add(pictureBox1);
            panelHomeScreen.Controls.Add(btnTypeOption);
            panelHomeScreen.Controls.Add(btnScanOption);
            panelHomeScreen.Controls.Add(lblQuestion);
            panelHomeScreen.Location = new Point(27, 41);
            panelHomeScreen.Name = "panelHomeScreen";
            panelHomeScreen.Size = new Size(845, 407);
            panelHomeScreen.TabIndex = 17;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(206, 171);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(375, 226);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // btnTypeOption
            // 
            btnTypeOption.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTypeOption.Location = new Point(461, 97);
            btnTypeOption.Name = "btnTypeOption";
            btnTypeOption.Size = new Size(295, 58);
            btnTypeOption.TabIndex = 2;
            btnTypeOption.Text = "Type And Select My Name";
            btnTypeOption.UseVisualStyleBackColor = true;
            btnTypeOption.Click += btnTypeOption_Click;
            // 
            // btnScanOption
            // 
            btnScanOption.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnScanOption.Location = new Point(20, 97);
            btnScanOption.Name = "btnScanOption";
            btnScanOption.Size = new Size(295, 58);
            btnScanOption.TabIndex = 1;
            btnScanOption.Text = "Scan In My CTA ID (QR Code)";
            btnScanOption.UseVisualStyleBackColor = true;
            btnScanOption.Click += btnScanOption_Click;
            // 
            // lblQuestion
            // 
            lblQuestion.AutoSize = true;
            lblQuestion.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblQuestion.Location = new Point(17, 29);
            lblQuestion.Name = "lblQuestion";
            lblQuestion.Size = new Size(790, 32);
            lblQuestion.TabIndex = 0;
            lblQuestion.Text = "Please click one of the buttons to scan in your CTA ID or type your name";
            // 
            // panelPositiveFeedback
            // 
            panelPositiveFeedback.Controls.Add(lblResetText);
            panelPositiveFeedback.Controls.Add(picboxSuccessImage);
            panelPositiveFeedback.Controls.Add(lblNameRegSuccess);
            panelPositiveFeedback.Location = new Point(27, 41);
            panelPositiveFeedback.Name = "panelPositiveFeedback";
            panelPositiveFeedback.Size = new Size(845, 410);
            panelPositiveFeedback.TabIndex = 18;
            panelPositiveFeedback.Visible = false;
            // 
            // lblResetText
            // 
            lblResetText.AutoSize = true;
            lblResetText.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblResetText.Location = new Point(110, 356);
            lblResetText.Name = "lblResetText";
            lblResetText.Size = new Size(392, 32);
            lblResetText.TabIndex = 2;
            lblResetText.Text = "This screen will reset in 10 seconds.";
            // 
            // picboxSuccessImage
            // 
            picboxSuccessImage.BackColor = Color.Green;
            picboxSuccessImage.Image = (Image)resources.GetObject("picboxSuccessImage.Image");
            picboxSuccessImage.Location = new Point(105, 97);
            picboxSuccessImage.Name = "picboxSuccessImage";
            picboxSuccessImage.Size = new Size(435, 224);
            picboxSuccessImage.TabIndex = 1;
            picboxSuccessImage.TabStop = false;
            // 
            // lblNameRegSuccess
            // 
            lblNameRegSuccess.AutoSize = true;
            lblNameRegSuccess.Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNameRegSuccess.Location = new Point(17, 37);
            lblNameRegSuccess.Name = "lblNameRegSuccess";
            lblNameRegSuccess.Size = new Size(321, 23);
            lblNameRegSuccess.TabIndex = 0;
            lblNameRegSuccess.Text = "<name>, You are successfully registered!";
            // 
            // panelNegativeFeedback
            // 
            panelNegativeFeedback.Controls.Add(lblNegFeebackResetText);
            panelNegativeFeedback.Controls.Add(picboxNegativeFeedbackImage);
            panelNegativeFeedback.Controls.Add(lblRegAbort);
            panelNegativeFeedback.Location = new Point(27, 41);
            panelNegativeFeedback.Name = "panelNegativeFeedback";
            panelNegativeFeedback.Size = new Size(845, 410);
            panelNegativeFeedback.TabIndex = 19;
            panelNegativeFeedback.Visible = false;
            // 
            // lblNegFeebackResetText
            // 
            lblNegFeebackResetText.AutoSize = true;
            lblNegFeebackResetText.Location = new Point(103, 365);
            lblNegFeebackResetText.Name = "lblNegFeebackResetText";
            lblNegFeebackResetText.Size = new Size(486, 15);
            lblNegFeebackResetText.TabIndex = 2;
            lblNegFeebackResetText.Text = "This screen will reset in 10 seconds, If you did not mean to abort, you can retry at that time.";
            // 
            // picboxNegativeFeedbackImage
            // 
            picboxNegativeFeedbackImage.BackColor = Color.FromArgb(255, 255, 128);
            picboxNegativeFeedbackImage.Location = new Point(107, 88);
            picboxNegativeFeedbackImage.Name = "picboxNegativeFeedbackImage";
            picboxNegativeFeedbackImage.Size = new Size(497, 265);
            picboxNegativeFeedbackImage.TabIndex = 1;
            picboxNegativeFeedbackImage.TabStop = false;
            // 
            // lblRegAbort
            // 
            lblRegAbort.AutoSize = true;
            lblRegAbort.Location = new Point(103, 32);
            lblRegAbort.Name = "lblRegAbort";
            lblRegAbort.Size = new Size(212, 15);
            lblRegAbort.TabIndex = 0;
            lblRegAbort.Text = "Registration Aborted. At user's request.";
            // 
            // timerConfirmationScreen
            // 
            timerConfirmationScreen.Interval = 1000;
            timerConfirmationScreen.Tick += timerConfirmationScreen_Tick;
            // 
            // timerAbortReg
            // 
            timerAbortReg.Interval = 1000;
            timerAbortReg.Tick += timerAbortReg_Tick;
            // 
            // panelNonActiveMember
            // 
            panelNonActiveMember.Controls.Add(label1);
            panelNonActiveMember.Controls.Add(pictureBox2);
            panelNonActiveMember.Controls.Add(btnNotActiveOkay);
            panelNonActiveMember.Controls.Add(lblGuestInstructions);
            panelNonActiveMember.Controls.Add(lblMembershipName);
            panelNonActiveMember.Location = new Point(27, 41);
            panelNonActiveMember.Name = "panelNonActiveMember";
            panelNonActiveMember.Size = new Size(845, 410);
            panelNonActiveMember.TabIndex = 20;
            panelNonActiveMember.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(20, 55);
            label1.Name = "label1";
            label1.Size = new Size(356, 32);
            label1.TabIndex = 4;
            label1.Text = "Your membership is not current.";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(460, 173);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(375, 226);
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // btnNotActiveOkay
            // 
            btnNotActiveOkay.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNotActiveOkay.Location = new Point(198, 183);
            btnNotActiveOkay.Name = "btnNotActiveOkay";
            btnNotActiveOkay.Size = new Size(111, 54);
            btnNotActiveOkay.TabIndex = 2;
            btnNotActiveOkay.Text = "OK";
            btnNotActiveOkay.UseVisualStyleBackColor = true;
            btnNotActiveOkay.Click += btnNotActiveOkay_Click;
            // 
            // lblGuestInstructions
            // 
            lblGuestInstructions.AutoSize = true;
            lblGuestInstructions.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGuestInstructions.Location = new Point(20, 96);
            lblGuestInstructions.Name = "lblGuestInstructions";
            lblGuestInstructions.Size = new Size(489, 32);
            lblGuestInstructions.TabIndex = 1;
            lblGuestInstructions.Text = "Please speak to the event host, and click OK.";
            // 
            // lblMembershipName
            // 
            lblMembershipName.AutoSize = true;
            lblMembershipName.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMembershipName.Location = new Point(20, 14);
            lblMembershipName.Name = "lblMembershipName";
            lblMembershipName.Size = new Size(110, 32);
            lblMembershipName.TabIndex = 0;
            lblMembershipName.Text = "<Name>";
            // 
            // RegForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 450);
            Controls.Add(lblRegFormTitle);
            Controls.Add(panelHomeScreen);
            Controls.Add(panelManIDEntry);
            Controls.Add(panelScanID);
            Controls.Add(panelNonActiveMember);
            Controls.Add(panelNegativeFeedback);
            Controls.Add(panelPositiveFeedback);
            Name = "RegForm";
            Text = "FA Event Registration Form";
            FormClosing += RegForm_FormClosing;
            Load += RegForm_Load;
            ((System.ComponentModel.ISupportInitialize)pbCamera).EndInit();
            panelScanID.ResumeLayout(false);
            panelScanID.PerformLayout();
            panelManIDEntry.ResumeLayout(false);
            panelManIDEntry.PerformLayout();
            panelHomeScreen.ResumeLayout(false);
            panelHomeScreen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelPositiveFeedback.ResumeLayout(false);
            panelPositiveFeedback.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picboxSuccessImage).EndInit();
            panelNegativeFeedback.ResumeLayout(false);
            panelNegativeFeedback.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picboxNegativeFeedbackImage).EndInit();
            panelNonActiveMember.ResumeLayout(false);
            panelNonActiveMember.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblRegFormTitle;
        private Label lblUserInstruction;
        private Label lblLastName;
        private Label lblFirstName;
        private TextBox tbLastName;
        private TextBox tbFirstName;
        private Label lblUserListInstruct;
        private Button btnAttending;
        private ListBox lbEmployees;
        private Label lblCamera;
        private ComboBox cboCamera;
        private PictureBox pbCamera;
        private TextBox txtQRCode;
        private Button btnStartCamera;
        private System.Windows.Forms.Timer timerCamera;
        private Panel panelScanID;
        private Panel panelManIDEntry;
        private Panel panelHomeScreen;
        private Label lblQuestion;
        private Button btnTypeOption;
        private Button btnScanOption;
        private Panel panelPositiveFeedback;
        private Label lblNameRegSuccess;
        private Label lblResetText;
        private PictureBox picboxSuccessImage;
        private Panel panelNegativeFeedback;
        private Label lblNegFeebackResetText;
        private PictureBox picboxNegativeFeedbackImage;
        private Label lblRegAbort;
        private Button btnManRegAbort;
        private Button btnScanRegAbort;
        private System.Windows.Forms.Timer timerConfirmationScreen;
        private System.Windows.Forms.Timer timerAbortReg;
        private PictureBox pictureBox1;
        private Panel panelNonActiveMember;
        private Button btnNotActiveOkay;
        private Label lblGuestInstructions;
        private Label lblMembershipName;
        private PictureBox pictureBox2;
        private Label label1;
    }
}
