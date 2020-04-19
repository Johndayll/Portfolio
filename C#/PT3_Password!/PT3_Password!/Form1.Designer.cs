namespace PT3_Password_
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
            this.components = new System.ComponentModel.Container();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.Character = new System.Windows.Forms.Label();
            this.Length = new System.Windows.Forms.Label();
            this.Digit = new System.Windows.Forms.Label();
            this.Restriction = new System.Windows.Forms.Label();
            this.Validity = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.PassWordBox = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.bunifuButton1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuElipse3 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 30;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // Character
            // 
            this.Character.AutoSize = true;
            this.Character.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Character.Location = new System.Drawing.Point(59, 353);
            this.Character.Name = "Character";
            this.Character.Size = new System.Drawing.Size(42, 29);
            this.Character.TabIndex = 3;
            this.Character.Text = "❌";
            // 
            // Length
            // 
            this.Length.AutoSize = true;
            this.Length.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Length.Location = new System.Drawing.Point(59, 307);
            this.Length.Name = "Length";
            this.Length.Size = new System.Drawing.Size(42, 29);
            this.Length.TabIndex = 3;
            this.Length.Text = "❌";
            // 
            // Digit
            // 
            this.Digit.AutoSize = true;
            this.Digit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Digit.Location = new System.Drawing.Point(59, 413);
            this.Digit.Name = "Digit";
            this.Digit.Size = new System.Drawing.Size(42, 29);
            this.Digit.TabIndex = 3;
            this.Digit.Text = "❌";
            // 
            // Restriction
            // 
            this.Restriction.AutoSize = true;
            this.Restriction.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Restriction.Location = new System.Drawing.Point(59, 460);
            this.Restriction.Name = "Restriction";
            this.Restriction.Size = new System.Drawing.Size(42, 29);
            this.Restriction.TabIndex = 3;
            this.Restriction.Text = "❌";
            // 
            // Validity
            // 
            this.Validity.AutoSize = true;
            this.Validity.Font = new System.Drawing.Font("FinkHeavy", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Validity.ForeColor = System.Drawing.Color.Red;
            this.Validity.Location = new System.Drawing.Point(202, 243);
            this.Validity.Name = "Validity";
            this.Validity.Size = new System.Drawing.Size(155, 53);
            this.Validity.TabIndex = 5;
            this.Validity.Text = "Invalid!";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("FinkHeavy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(107, 313);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(315, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "The length must be 2-8 characters...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("FinkHeavy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(107, 359);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(424, 50);
            this.label2.TabIndex = 6;
            this.label2.Text = "The first character must be an uppercase letter \r\nWhile the last character is a l" +
    "owercase letter";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("FinkHeavy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(108, 419);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(436, 50);
            this.label3.TabIndex = 6;
            this.label3.Text = "There should be a digit between the first and last\r\ncharacter\r\n";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("FinkHeavy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(108, 472);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(409, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "The password only consists of letters/numbers";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("FinkHeavy", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(167, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(363, 106);
            this.label5.TabIndex = 7;
            this.label5.Text = "Isabelle\'s Password \r\nChecker";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::PT3_Password_.Properties.Resources.Shocc__2_;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(149, 157);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 30;
            this.bunifuElipse2.TargetControl = this.PassWordBox;
            // 
            // PassWordBox
            // 
            this.PassWordBox.AcceptsReturn = false;
            this.PassWordBox.AcceptsTab = false;
            this.PassWordBox.AnimationSpeed = 200;
            this.PassWordBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.PassWordBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.PassWordBox.BackColor = System.Drawing.Color.Transparent;
            this.PassWordBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PassWordBox.BackgroundImage")));
            this.PassWordBox.BorderColorActive = System.Drawing.Color.MediumAquamarine;
            this.PassWordBox.BorderColorDisabled = System.Drawing.Color.MediumAquamarine;
            this.PassWordBox.BorderColorHover = System.Drawing.Color.MediumAquamarine;
            this.PassWordBox.BorderColorIdle = System.Drawing.Color.MediumAquamarine;
            this.PassWordBox.BorderRadius = 1;
            this.PassWordBox.BorderThickness = 2;
            this.PassWordBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.PassWordBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PassWordBox.DefaultFont = new System.Drawing.Font("FinkHeavy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassWordBox.DefaultText = "";
            this.PassWordBox.FillColor = System.Drawing.Color.MediumAquamarine;
            this.PassWordBox.HideSelection = true;
            this.PassWordBox.IconLeft = null;
            this.PassWordBox.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.PassWordBox.IconPadding = 10;
            this.PassWordBox.IconRight = null;
            this.PassWordBox.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.PassWordBox.Lines = new string[0];
            this.PassWordBox.Location = new System.Drawing.Point(64, 193);
            this.PassWordBox.MaxLength = 32767;
            this.PassWordBox.MinimumSize = new System.Drawing.Size(1, 1);
            this.PassWordBox.Modified = false;
            this.PassWordBox.Multiline = false;
            this.PassWordBox.Name = "PassWordBox";
            stateProperties3.BorderColor = System.Drawing.Color.MediumAquamarine;
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.PassWordBox.OnActiveState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.MediumAquamarine;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.PassWordBox.OnDisabledState = stateProperties4;
            stateProperties5.BorderColor = System.Drawing.Color.MediumAquamarine;
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.PassWordBox.OnHoverState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.MediumAquamarine;
            stateProperties6.FillColor = System.Drawing.Color.MediumAquamarine;
            stateProperties6.ForeColor = System.Drawing.Color.Empty;
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.PassWordBox.OnIdleState = stateProperties6;
            this.PassWordBox.PasswordChar = '\0';
            this.PassWordBox.PlaceholderForeColor = System.Drawing.Color.Black;
            this.PassWordBox.PlaceholderText = "Enter text";
            this.PassWordBox.ReadOnly = false;
            this.PassWordBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.PassWordBox.SelectedText = "";
            this.PassWordBox.SelectionLength = 0;
            this.PassWordBox.SelectionStart = 0;
            this.PassWordBox.ShortcutsEnabled = true;
            this.PassWordBox.Size = new System.Drawing.Size(452, 44);
            this.PassWordBox.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.PassWordBox.TabIndex = 9;
            this.PassWordBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.PassWordBox.TextMarginBottom = 0;
            this.PassWordBox.TextMarginLeft = 5;
            this.PassWordBox.TextMarginTop = 0;
            this.PassWordBox.TextPlaceholder = "Enter text";
            this.PassWordBox.UseSystemPasswordChar = false;
            this.PassWordBox.WordWrap = true;
            this.PassWordBox.TextChange += new System.EventHandler(this.PassWordBox_TextChange);
            // 
            // bunifuButton1
            // 
            this.bunifuButton1.AllowToggling = false;
            this.bunifuButton1.AnimationSpeed = 200;
            this.bunifuButton1.AutoGenerateColors = false;
            this.bunifuButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuButton1.BackColor1 = System.Drawing.Color.MediumAquamarine;
            this.bunifuButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuButton1.BackgroundImage")));
            this.bunifuButton1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton1.ButtonText = "X";
            this.bunifuButton1.ButtonTextMarginLeft = 0;
            this.bunifuButton1.ColorContrastOnClick = 45;
            this.bunifuButton1.ColorContrastOnHover = 45;
            this.bunifuButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.bunifuButton1.CustomizableEdges = borderEdges1;
            this.bunifuButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuButton1.DisabledBorderColor = System.Drawing.Color.MediumAquamarine;
            this.bunifuButton1.DisabledFillColor = System.Drawing.Color.MediumAquamarine;
            this.bunifuButton1.DisabledForecolor = System.Drawing.Color.MediumAquamarine;
            this.bunifuButton1.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.bunifuButton1.Font = new System.Drawing.Font("FinkHeavy", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuButton1.ForeColor = System.Drawing.Color.Black;
            this.bunifuButton1.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuButton1.IconMarginLeft = 11;
            this.bunifuButton1.IconPadding = 10;
            this.bunifuButton1.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuButton1.IdleBorderColor = System.Drawing.Color.MediumAquamarine;
            this.bunifuButton1.IdleBorderRadius = 3;
            this.bunifuButton1.IdleBorderThickness = 1;
            this.bunifuButton1.IdleFillColor = System.Drawing.Color.MediumAquamarine;
            this.bunifuButton1.IdleIconLeftImage = null;
            this.bunifuButton1.IdleIconRightImage = null;
            this.bunifuButton1.IndicateFocus = false;
            this.bunifuButton1.Location = new System.Drawing.Point(536, 12);
            this.bunifuButton1.Name = "bunifuButton1";
            stateProperties1.BorderColor = System.Drawing.Color.Red;
            stateProperties1.BorderRadius = 3;
            stateProperties1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties1.BorderThickness = 1;
            stateProperties1.FillColor = System.Drawing.Color.Red;
            stateProperties1.ForeColor = System.Drawing.Color.Black;
            stateProperties1.IconLeftImage = null;
            stateProperties1.IconRightImage = null;
            this.bunifuButton1.onHoverState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.Crimson;
            stateProperties2.BorderRadius = 3;
            stateProperties2.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties2.BorderThickness = 1;
            stateProperties2.FillColor = System.Drawing.Color.Crimson;
            stateProperties2.ForeColor = System.Drawing.Color.Black;
            stateProperties2.IconLeftImage = null;
            stateProperties2.IconRightImage = null;
            this.bunifuButton1.OnPressedState = stateProperties2;
            this.bunifuButton1.Size = new System.Drawing.Size(53, 45);
            this.bunifuButton1.TabIndex = 10;
            this.bunifuButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuButton1.TextMarginLeft = 0;
            this.bunifuButton1.UseDefaultRadiusAndThickness = true;
            this.bunifuButton1.Click += new System.EventHandler(this.bunifuButton1_Click);
            // 
            // bunifuElipse3
            // 
            this.bunifuElipse3.ElipseRadius = 30;
            this.bunifuElipse3.TargetControl = this.bunifuButton1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(601, 551);
            this.Controls.Add(this.bunifuButton1);
            this.Controls.Add(this.PassWordBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Validity);
            this.Controls.Add(this.Length);
            this.Controls.Add(this.Restriction);
            this.Controls.Add(this.Digit);
            this.Controls.Add(this.Character);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Isabelle\'s Password Checker";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Label Character;
        private System.Windows.Forms.Label Length;
        private System.Windows.Forms.Label Restriction;
        private System.Windows.Forms.Label Digit;
        private System.Windows.Forms.Label Validity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox PassWordBox;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton bunifuButton1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse3;
    }
}

