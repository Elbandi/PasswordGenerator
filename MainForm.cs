using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PasswordGenerator
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void MainForm_Load( object sender, EventArgs e )
		{
			QuantityCombobox.SelectedIndex = 9;
			ActiveControl = GenerateButton;
		}

		private void GenerateButton_Click( object sender, EventArgs e )
		{
			if ( IncludeLettersCheckbox.Checked || IncludeMixedcaseCheckbox.Checked || IncludeNumbersCheckbox.Checked )
			{
				try
				{
					PwGen jelszo = new PwGen( (int)PasswordLengthUpDown.Value, (int)PasswordLengthUpDown.Value );
					jelszo.AllowLowerChar = IncludeLettersCheckbox.Checked;
					jelszo.AllowUpperChar = IncludeMixedcaseCheckbox.Checked;
					jelszo.AllowNumbers = IncludeNumbersCheckbox.Checked;
					jelszo.AllowSymbols = false;
					PasswordListbox.Items.Clear();
					for ( int i = 0; i <= QuantityCombobox.SelectedIndex; i++ )
					{
						PasswordListbox.Items.Add( jelszo.Generate() );
					}
				}
				catch ( Exception ee )
				{
					MessageBox.Show( ee.Message, ee.Source, MessageBoxButtons.OK, MessageBoxIcon.Asterisk );
				}
			}
			else
				MessageBox.Show( "Milyenfajta betuk legyenek a jelszoban?", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error );
		}

		private void PasswordListbox_DoubleClick( object sender, EventArgs e )
		{
			Clipboard.SetText( PasswordListbox.SelectedItem as string );
		}
	}
}
