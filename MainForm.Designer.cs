namespace PasswordGenerator
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
		protected override void Dispose( bool disposing )
		{
			if ( disposing && ( components != null ) )
			{
				components.Dispose();
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.PasswordLengthLabel = new System.Windows.Forms.Label();
			this.PasswordLengthUpDown = new System.Windows.Forms.NumericUpDown();
			this.IncludeLettersLabel = new System.Windows.Forms.Label();
			this.IncludeLettersCheckbox = new System.Windows.Forms.CheckBox();
			this.IncludeMixedcaseLabel = new System.Windows.Forms.Label();
			this.IncludeMixedcaseCheckbox = new System.Windows.Forms.CheckBox();
			this.IncludeNumbersLabel = new System.Windows.Forms.Label();
			this.IncludeNumbersCheckbox = new System.Windows.Forms.CheckBox();
			this.PasswordListbox = new System.Windows.Forms.ListBox();
			this.GenerateButton = new System.Windows.Forms.Button();
			this.QuantityCombobox = new System.Windows.Forms.ComboBox();
			this.QuantityLabel = new System.Windows.Forms.Label();
			( (System.ComponentModel.ISupportInitialize)( this.PasswordLengthUpDown ) ).BeginInit();
			this.SuspendLayout();
			// 
			// PasswordLengthLabel
			// 
			this.PasswordLengthLabel.AutoSize = true;
			this.PasswordLengthLabel.Location = new System.Drawing.Point( 12, 9 );
			this.PasswordLengthLabel.Name = "PasswordLengthLabel";
			this.PasswordLengthLabel.Size = new System.Drawing.Size( 89, 13 );
			this.PasswordLengthLabel.TabIndex = 0;
			this.PasswordLengthLabel.Text = "Jelszo hosszusag";
			// 
			// PasswordLengthUpDown
			// 
			this.PasswordLengthUpDown.Location = new System.Drawing.Point( 160, 7 );
			this.PasswordLengthUpDown.Maximum = new decimal( new int[] {
            14,
            0,
            0,
            0} );
			this.PasswordLengthUpDown.Minimum = new decimal( new int[] {
            5,
            0,
            0,
            0} );
			this.PasswordLengthUpDown.Name = "PasswordLengthUpDown";
			this.PasswordLengthUpDown.Size = new System.Drawing.Size( 63, 20 );
			this.PasswordLengthUpDown.TabIndex = 1;
			this.PasswordLengthUpDown.Value = new decimal( new int[] {
            8,
            0,
            0,
            0} );
			// 
			// IncludeLettersLabel
			// 
			this.IncludeLettersLabel.AutoSize = true;
			this.IncludeLettersLabel.Location = new System.Drawing.Point( 12, 37 );
			this.IncludeLettersLabel.Name = "IncludeLettersLabel";
			this.IncludeLettersLabel.Size = new System.Drawing.Size( 89, 13 );
			this.IncludeLettersLabel.TabIndex = 2;
			this.IncludeLettersLabel.Text = "Betuk hasznalata";
			// 
			// IncludeLettersCheckbox
			// 
			this.IncludeLettersCheckbox.AutoSize = true;
			this.IncludeLettersCheckbox.Checked = true;
			this.IncludeLettersCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
			this.IncludeLettersCheckbox.Location = new System.Drawing.Point( 160, 36 );
			this.IncludeLettersCheckbox.Name = "IncludeLettersCheckbox";
			this.IncludeLettersCheckbox.Size = new System.Drawing.Size( 79, 17 );
			this.IncludeLettersCheckbox.TabIndex = 3;
			this.IncludeLettersCheckbox.Text = "(pl. abcdef)";
			this.IncludeLettersCheckbox.UseVisualStyleBackColor = true;
			// 
			// IncludeMixedcaseLabel
			// 
			this.IncludeMixedcaseLabel.AutoSize = true;
			this.IncludeMixedcaseLabel.Location = new System.Drawing.Point( 12, 60 );
			this.IncludeMixedcaseLabel.Name = "IncludeMixedcaseLabel";
			this.IncludeMixedcaseLabel.Size = new System.Drawing.Size( 113, 13 );
			this.IncludeMixedcaseLabel.TabIndex = 4;
			this.IncludeMixedcaseLabel.Text = "Nagybetuk hasznalata";
			// 
			// IncludeMixedcaseCheckbox
			// 
			this.IncludeMixedcaseCheckbox.AutoSize = true;
			this.IncludeMixedcaseCheckbox.Checked = true;
			this.IncludeMixedcaseCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
			this.IncludeMixedcaseCheckbox.Location = new System.Drawing.Point( 160, 59 );
			this.IncludeMixedcaseCheckbox.Name = "IncludeMixedcaseCheckbox";
			this.IncludeMixedcaseCheckbox.Size = new System.Drawing.Size( 83, 17 );
			this.IncludeMixedcaseCheckbox.TabIndex = 5;
			this.IncludeMixedcaseCheckbox.Text = "(pl. AbcDEf)";
			this.IncludeMixedcaseCheckbox.UseVisualStyleBackColor = true;
			// 
			// IncludeNumbersLabel
			// 
			this.IncludeNumbersLabel.AutoSize = true;
			this.IncludeNumbersLabel.Location = new System.Drawing.Point( 12, 83 );
			this.IncludeNumbersLabel.Name = "IncludeNumbersLabel";
			this.IncludeNumbersLabel.Size = new System.Drawing.Size( 99, 13 );
			this.IncludeNumbersLabel.TabIndex = 6;
			this.IncludeNumbersLabel.Text = "Szamok hasznalata";
			// 
			// IncludeNumbersCheckbox
			// 
			this.IncludeNumbersCheckbox.AutoSize = true;
			this.IncludeNumbersCheckbox.Checked = true;
			this.IncludeNumbersCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
			this.IncludeNumbersCheckbox.Location = new System.Drawing.Point( 159, 82 );
			this.IncludeNumbersCheckbox.Name = "IncludeNumbersCheckbox";
			this.IncludeNumbersCheckbox.Size = new System.Drawing.Size( 88, 17 );
			this.IncludeNumbersCheckbox.TabIndex = 7;
			this.IncludeNumbersCheckbox.Text = "(pl. a9b8c7d)";
			this.IncludeNumbersCheckbox.UseVisualStyleBackColor = true;
			// 
			// PasswordListbox
			// 
			this.PasswordListbox.Font = new System.Drawing.Font( "Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );
			this.PasswordListbox.Location = new System.Drawing.Point( 256, 12 );
			this.PasswordListbox.Name = "PasswordListbox";
			this.PasswordListbox.Size = new System.Drawing.Size( 188, 186 );
			this.PasswordListbox.TabIndex = 11;
			this.PasswordListbox.DoubleClick += new System.EventHandler( this.PasswordListbox_DoubleClick );
			// 
			// GenerateButton
			// 
			this.GenerateButton.Location = new System.Drawing.Point( 15, 160 );
			this.GenerateButton.Name = "GenerateButton";
			this.GenerateButton.Size = new System.Drawing.Size( 121, 23 );
			this.GenerateButton.TabIndex = 10;
			this.GenerateButton.Text = "Elkeszit";
			this.GenerateButton.UseVisualStyleBackColor = true;
			this.GenerateButton.Click += new System.EventHandler( this.GenerateButton_Click );
			// 
			// QuantityCombobox
			// 
			this.QuantityCombobox.DisplayMember = "10";
			this.QuantityCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.QuantityCombobox.FormattingEnabled = true;
			this.QuantityCombobox.Items.AddRange( new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15"} );
			this.QuantityCombobox.Location = new System.Drawing.Point( 159, 117 );
			this.QuantityCombobox.Name = "QuantityCombobox";
			this.QuantityCombobox.Size = new System.Drawing.Size( 64, 21 );
			this.QuantityCombobox.TabIndex = 9;
			// 
			// QuantityLabel
			// 
			this.QuantityLabel.AutoSize = true;
			this.QuantityLabel.Location = new System.Drawing.Point( 12, 120 );
			this.QuantityLabel.Name = "QuantityLabel";
			this.QuantityLabel.Size = new System.Drawing.Size( 60, 13 );
			this.QuantityLabel.TabIndex = 8;
			this.QuantityLabel.Text = "Darabszam";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size( 456, 210 );
			this.Controls.Add( this.QuantityLabel );
			this.Controls.Add( this.QuantityCombobox );
			this.Controls.Add( this.GenerateButton );
			this.Controls.Add( this.PasswordListbox );
			this.Controls.Add( this.IncludeNumbersCheckbox );
			this.Controls.Add( this.IncludeNumbersLabel );
			this.Controls.Add( this.IncludeMixedcaseCheckbox );
			this.Controls.Add( this.IncludeMixedcaseLabel );
			this.Controls.Add( this.IncludeLettersCheckbox );
			this.Controls.Add( this.IncludeLettersLabel );
			this.Controls.Add( this.PasswordLengthUpDown );
			this.Controls.Add( this.PasswordLengthLabel );
			this.DoubleBuffered = true;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.Text = "Jelszo generator";
			this.Load += new System.EventHandler( this.MainForm_Load );
			( (System.ComponentModel.ISupportInitialize)( this.PasswordLengthUpDown ) ).EndInit();
			this.ResumeLayout( false );
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label PasswordLengthLabel;
		private System.Windows.Forms.NumericUpDown PasswordLengthUpDown;
		private System.Windows.Forms.Label IncludeLettersLabel;
		private System.Windows.Forms.CheckBox IncludeLettersCheckbox;
		private System.Windows.Forms.Label IncludeMixedcaseLabel;
		private System.Windows.Forms.CheckBox IncludeMixedcaseCheckbox;
		private System.Windows.Forms.Label IncludeNumbersLabel;
		private System.Windows.Forms.CheckBox IncludeNumbersCheckbox;
		private System.Windows.Forms.ListBox PasswordListbox;
		private System.Windows.Forms.Button GenerateButton;
		private System.Windows.Forms.ComboBox QuantityCombobox;
		private System.Windows.Forms.Label QuantityLabel;
	}
}

