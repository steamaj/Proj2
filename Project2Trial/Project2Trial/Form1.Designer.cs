namespace Project2Trial
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
            this.labelCategory = new System.Windows.Forms.Label();
            this.labelWhichOnes = new System.Windows.Forms.Label();
            this.groupBoxCategory = new System.Windows.Forms.GroupBox();
            this.radioButtonDeathCause = new System.Windows.Forms.RadioButton();
            this.radioButtonEducation = new System.Windows.Forms.RadioButton();
            this.radioButtonParty = new System.Windows.Forms.RadioButton();
            this.panelParty = new System.Windows.Forms.Panel();
            this.listBoxParty = new System.Windows.Forms.ListBox();
            this.panelEducation = new System.Windows.Forms.Panel();
            this.listBoxEducation = new System.Windows.Forms.ListBox();
            this.panelDeathCause = new System.Windows.Forms.Panel();
            this.listBoxDeathCause = new System.Windows.Forms.ListBox();
            this.buttonWriteCategory = new System.Windows.Forms.Button();
            this.labelPresident = new System.Windows.Forms.Label();
            this.comboBoxPresident = new System.Windows.Forms.ComboBox();
            this.labelWhatToKnow = new System.Windows.Forms.Label();
            this.listBoxWhatToKnow = new System.Windows.Forms.ListBox();
            this.buttonWritePresident = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBoxCategory.SuspendLayout();
            this.panelParty.SuspendLayout();
            this.panelEducation.SuspendLayout();
            this.panelDeathCause.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelCategory
            // 
            this.labelCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelCategory.Location = new System.Drawing.Point(36, 107);
            this.labelCategory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(220, 33);
            this.labelCategory.TabIndex = 0;
            this.labelCategory.Text = "Choose Category";
            // 
            // labelWhichOnes
            // 
            this.labelWhichOnes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelWhichOnes.Location = new System.Drawing.Point(36, 343);
            this.labelWhichOnes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelWhichOnes.Name = "labelWhichOnes";
            this.labelWhichOnes.Size = new System.Drawing.Size(276, 33);
            this.labelWhichOnes.TabIndex = 1;
            this.labelWhichOnes.Text = "Choose Which Ones...";
            // 
            // groupBoxCategory
            // 
            this.groupBoxCategory.Controls.Add(this.radioButtonDeathCause);
            this.groupBoxCategory.Controls.Add(this.radioButtonEducation);
            this.groupBoxCategory.Controls.Add(this.radioButtonParty);
            this.groupBoxCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBoxCategory.Location = new System.Drawing.Point(41, 144);
            this.groupBoxCategory.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxCategory.Name = "groupBoxCategory";
            this.groupBoxCategory.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxCategory.Size = new System.Drawing.Size(267, 153);
            this.groupBoxCategory.TabIndex = 2;
            this.groupBoxCategory.TabStop = false;
            this.groupBoxCategory.Enter += new System.EventHandler(this.groupBoxCategory_Enter);
            // 
            // radioButtonDeathCause
            // 
            this.radioButtonDeathCause.AutoSize = true;
            this.radioButtonDeathCause.Location = new System.Drawing.Point(25, 107);
            this.radioButtonDeathCause.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonDeathCause.Name = "radioButtonDeathCause";
            this.radioButtonDeathCause.Size = new System.Drawing.Size(148, 29);
            this.radioButtonDeathCause.TabIndex = 2;
            this.radioButtonDeathCause.Text = "Death Cause";
            this.radioButtonDeathCause.UseVisualStyleBackColor = true;
            this.radioButtonDeathCause.CheckedChanged += new System.EventHandler(this.radioButtonDeathCause_CheckedChanged);
            // 
            // radioButtonEducation
            // 
            this.radioButtonEducation.AutoSize = true;
            this.radioButtonEducation.Location = new System.Drawing.Point(25, 70);
            this.radioButtonEducation.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonEducation.Name = "radioButtonEducation";
            this.radioButtonEducation.Size = new System.Drawing.Size(120, 29);
            this.radioButtonEducation.TabIndex = 1;
            this.radioButtonEducation.Text = "Education";
            this.radioButtonEducation.UseVisualStyleBackColor = true;
            this.radioButtonEducation.CheckedChanged += new System.EventHandler(this.radioButtonEducation_CheckedChanged);
            // 
            // radioButtonParty
            // 
            this.radioButtonParty.AutoSize = true;
            this.radioButtonParty.Location = new System.Drawing.Point(25, 32);
            this.radioButtonParty.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonParty.Name = "radioButtonParty";
            this.radioButtonParty.Size = new System.Drawing.Size(78, 29);
            this.radioButtonParty.TabIndex = 0;
            this.radioButtonParty.Text = "Party";
            this.radioButtonParty.UseVisualStyleBackColor = true;
            this.radioButtonParty.CheckedChanged += new System.EventHandler(this.radioButtonParty_CheckedChanged);
            // 
            // panelParty
            // 
            this.panelParty.Controls.Add(this.listBoxParty);
            this.panelParty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.panelParty.Location = new System.Drawing.Point(41, 401);
            this.panelParty.Margin = new System.Windows.Forms.Padding(4);
            this.panelParty.Name = "panelParty";
            this.panelParty.Size = new System.Drawing.Size(316, 222);
            this.panelParty.TabIndex = 3;
            this.panelParty.Visible = false;
            // 
            // listBoxParty
            // 
            this.listBoxParty.FormattingEnabled = true;
            this.listBoxParty.ItemHeight = 25;
            this.listBoxParty.Items.AddRange(new object[] {
            "Democratic",
            "Republican",
            "Union",
            "Dem-Rep",
            "Whig"});
            this.listBoxParty.Location = new System.Drawing.Point(4, 4);
            this.listBoxParty.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxParty.Name = "listBoxParty";
            this.listBoxParty.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxParty.Size = new System.Drawing.Size(265, 154);
            this.listBoxParty.TabIndex = 0;
            // 
            // panelEducation
            // 
            this.panelEducation.Controls.Add(this.listBoxEducation);
            this.panelEducation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.panelEducation.Location = new System.Drawing.Point(41, 401);
            this.panelEducation.Margin = new System.Windows.Forms.Padding(4);
            this.panelEducation.Name = "panelEducation";
            this.panelEducation.Size = new System.Drawing.Size(316, 222);
            this.panelEducation.TabIndex = 4;
            this.panelEducation.Visible = false;
            // 
            // listBoxEducation
            // 
            this.listBoxEducation.FormattingEnabled = true;
            this.listBoxEducation.ItemHeight = 25;
            this.listBoxEducation.Items.AddRange(new object[] {
            "No Formal Education ",
            "Havard",
            "Yale",
            "Duke",
            "Oxford"});
            this.listBoxEducation.Location = new System.Drawing.Point(4, 4);
            this.listBoxEducation.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxEducation.Name = "listBoxEducation";
            this.listBoxEducation.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxEducation.Size = new System.Drawing.Size(265, 154);
            this.listBoxEducation.TabIndex = 0;
            // 
            // panelDeathCause
            // 
            this.panelDeathCause.Controls.Add(this.listBoxDeathCause);
            this.panelDeathCause.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.panelDeathCause.Location = new System.Drawing.Point(41, 401);
            this.panelDeathCause.Margin = new System.Windows.Forms.Padding(4);
            this.panelDeathCause.Name = "panelDeathCause";
            this.panelDeathCause.Size = new System.Drawing.Size(316, 222);
            this.panelDeathCause.TabIndex = 5;
            this.panelDeathCause.Visible = false;
            // 
            // listBoxDeathCause
            // 
            this.listBoxDeathCause.FormattingEnabled = true;
            this.listBoxDeathCause.ItemHeight = 25;
            this.listBoxDeathCause.Items.AddRange(new object[] {
            "Heart Failure",
            "Stroke",
            "Kidney Damage",
            "Gunshot Wound",
            "None- Still Alive"});
            this.listBoxDeathCause.Location = new System.Drawing.Point(4, 4);
            this.listBoxDeathCause.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxDeathCause.Name = "listBoxDeathCause";
            this.listBoxDeathCause.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxDeathCause.Size = new System.Drawing.Size(265, 154);
            this.listBoxDeathCause.TabIndex = 0;
            // 
            // buttonWriteCategory
            // 
            this.buttonWriteCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonWriteCategory.Location = new System.Drawing.Point(41, 626);
            this.buttonWriteCategory.Margin = new System.Windows.Forms.Padding(4);
            this.buttonWriteCategory.Name = "buttonWriteCategory";
            this.buttonWriteCategory.Size = new System.Drawing.Size(271, 37);
            this.buttonWriteCategory.TabIndex = 6;
            this.buttonWriteCategory.Text = "Write ";
            this.buttonWriteCategory.UseVisualStyleBackColor = true;
            this.buttonWriteCategory.Click += new System.EventHandler(this.buttonWriteCategory_Click);
            // 
            // labelPresident
            // 
            this.labelPresident.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelPresident.Location = new System.Drawing.Point(681, 107);
            this.labelPresident.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPresident.Name = "labelPresident";
            this.labelPresident.Size = new System.Drawing.Size(220, 33);
            this.labelPresident.TabIndex = 7;
            this.labelPresident.Text = "Choose President";
            // 
            // comboBoxPresident
            // 
            this.comboBoxPresident.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.comboBoxPresident.FormattingEnabled = true;
            this.comboBoxPresident.Location = new System.Drawing.Point(687, 144);
            this.comboBoxPresident.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxPresident.Name = "comboBoxPresident";
            this.comboBoxPresident.Size = new System.Drawing.Size(265, 33);
            this.comboBoxPresident.TabIndex = 8;
            // 
            // labelWhatToKnow
            // 
            this.labelWhatToKnow.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelWhatToKnow.Location = new System.Drawing.Point(681, 247);
            this.labelWhatToKnow.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelWhatToKnow.Name = "labelWhatToKnow";
            this.labelWhatToKnow.Size = new System.Drawing.Size(220, 33);
            this.labelWhatToKnow.TabIndex = 9;
            this.labelWhatToKnow.Text = "What to Know?";
            // 
            // listBoxWhatToKnow
            // 
            this.listBoxWhatToKnow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.listBoxWhatToKnow.FormattingEnabled = true;
            this.listBoxWhatToKnow.ItemHeight = 25;
            this.listBoxWhatToKnow.Items.AddRange(new object[] {
            "Start Year",
            "End Year",
            "Occupation",
            "Education",
            "State Born"});
            this.listBoxWhatToKnow.Location = new System.Drawing.Point(687, 284);
            this.listBoxWhatToKnow.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxWhatToKnow.Name = "listBoxWhatToKnow";
            this.listBoxWhatToKnow.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxWhatToKnow.Size = new System.Drawing.Size(265, 154);
            this.listBoxWhatToKnow.TabIndex = 10;
            // 
            // buttonWritePresident
            // 
            this.buttonWritePresident.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonWritePresident.Location = new System.Drawing.Point(687, 507);
            this.buttonWritePresident.Margin = new System.Windows.Forms.Padding(4);
            this.buttonWritePresident.Name = "buttonWritePresident";
            this.buttonWritePresident.Size = new System.Drawing.Size(267, 37);
            this.buttonWritePresident.TabIndex = 11;
            this.buttonWritePresident.Text = "Write ";
            this.buttonWritePresident.UseVisualStyleBackColor = true;
            this.buttonWritePresident.Click += new System.EventHandler(this.buttonWritePresident_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(460, 596);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(441, 68);
            this.label1.TabIndex = 12;
            this.label1.Text = "Files Written to: c:\\\\users\\\\steamaj\\\\PresidentInfo.csv";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(315, 28);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(359, 42);
            this.label2.TabIndex = 13;
            this.label2.Text = "President Information";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 699);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonWritePresident);
            this.Controls.Add(this.listBoxWhatToKnow);
            this.Controls.Add(this.labelWhatToKnow);
            this.Controls.Add(this.comboBoxPresident);
            this.Controls.Add(this.labelPresident);
            this.Controls.Add(this.buttonWriteCategory);
            this.Controls.Add(this.panelDeathCause);
            this.Controls.Add(this.panelEducation);
            this.Controls.Add(this.panelParty);
            this.Controls.Add(this.groupBoxCategory);
            this.Controls.Add(this.labelWhichOnes);
            this.Controls.Add(this.labelCategory);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.groupBoxCategory.ResumeLayout(false);
            this.groupBoxCategory.PerformLayout();
            this.panelParty.ResumeLayout(false);
            this.panelEducation.ResumeLayout(false);
            this.panelDeathCause.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelCategory;
        private System.Windows.Forms.Label labelWhichOnes;
        private System.Windows.Forms.GroupBox groupBoxCategory;
        private System.Windows.Forms.RadioButton radioButtonDeathCause;
        private System.Windows.Forms.RadioButton radioButtonEducation;
        private System.Windows.Forms.RadioButton radioButtonParty;
        private System.Windows.Forms.Panel panelParty;
        private System.Windows.Forms.ListBox listBoxParty;
        private System.Windows.Forms.Panel panelEducation;
        private System.Windows.Forms.ListBox listBoxEducation;
        private System.Windows.Forms.Panel panelDeathCause;
        private System.Windows.Forms.ListBox listBoxDeathCause;
        private System.Windows.Forms.Button buttonWriteCategory;
        private System.Windows.Forms.Label labelPresident;
        private System.Windows.Forms.ComboBox comboBoxPresident;
        private System.Windows.Forms.Label labelWhatToKnow;
        private System.Windows.Forms.ListBox listBoxWhatToKnow;
        private System.Windows.Forms.Button buttonWritePresident;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

