using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace PasswordGenerator
{
	class PwGen
	{
		#region Private

		private const int DefaultMinimum = 6;
		private const int DefaultMaximum = 10;
		private const int UBoundDigit = 61;

		private RNGCryptoServiceProvider rng;
		private int minSize;
		private int maxSize;
		private bool hasRepeating;
		private bool hasConsecutive;
		private bool hasLowerChar = true;
		private bool hasUpperChar = true;
		private bool hasNumbers = true;
		private bool hasSymbols = false;
		private bool requireAlltype = true;
		private string exclusionSet;
		private string lowerCharString = "abcdefghijklmnopqrstuvwxyz";
		private string upperCharString = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
		private string numberCharString = "0123456789";
		private string symbolCharString = "`~!@#$%^&*()-_=+[]{}\\|;:'\",<.>/?";

		#endregion

		#region Properties

		public string Exclusions
		{
			get { return this.exclusionSet; }
			set { this.exclusionSet = value; }
		}

		public int Minimum
		{
			get { return this.minSize; }
			set
			{
				if ( value > 0 )
					this.minSize = value;
				if ( this.maxSize < this.minSize )
					this.maxSize = this.minSize;
			}
		}

		public int Maximum
		{
			get { return this.maxSize; }
			set
			{
				if ( value > 0 )
					this.maxSize = value;
				if ( this.minSize > this.maxSize )
					this.minSize = this.maxSize;
			}
		}

		public bool AllowLowerChar
		{
			get { return this.hasLowerChar; }
			set { this.hasLowerChar = value; }
		}

		public bool AllowUpperChar
		{
			get { return this.hasUpperChar; }
			set { this.hasUpperChar = value; }
		}

		public bool AllowNumbers
		{
			get { return this.hasNumbers; }
			set { this.hasNumbers = value; }
		}

		public bool AllowSymbols
		{
			get { return this.hasSymbols; }
			set { this.hasSymbols = value; }
		}

		public bool RepeatCharacters
		{
			get { return this.hasRepeating; }
			set { this.hasRepeating = value; }
		}

		public bool ConsecutiveCharacters
		{
			get { return this.hasConsecutive; }
			set { this.hasConsecutive = value; }
		}

		public bool RequireAllType
		{
			get { return this.requireAlltype; }
			set { this.requireAlltype = value; }
		}

		#endregion

		#region Constructor

		public PwGen()
			: this( PwGen.DefaultMaximum )
		{
		}
		public PwGen( int Maximum )
			: this( PwGen.DefaultMinimum, Maximum )
		{
		}
		public PwGen( int Minimum, int Maximum )
			: this( Minimum, Maximum, false )
		{
		}
		public PwGen( int Minimum, int Maximum, bool ConsecutiveCharacters )
			: this( Minimum, Maximum, ConsecutiveCharacters, true )
		{
		}
		public PwGen( int Minimum, int Maximum, bool ConsecutiveCharacters, bool RepeatCharacters )
			: this( Minimum, Maximum, ConsecutiveCharacters, RepeatCharacters, false )
		{
		}
		public PwGen( int Minimum, int Maximum, bool ConsecutiveCharacters, bool RepeatCharacters, bool ExcludeSymbols )
			: this( Minimum, Maximum, ConsecutiveCharacters, RepeatCharacters, ExcludeSymbols, null )
		{
		}

		public PwGen( int Minimum, int Maximum, bool ConsecutiveCharacters, bool RepeatCharacters, bool ExcludeSymbols, string Exclusions )
		{
			this.minSize = Minimum;
			this.maxSize = Maximum;
			this.hasConsecutive = ConsecutiveCharacters;
			this.hasRepeating = RepeatCharacters;
			this.hasSymbols = ExcludeSymbols;
			this.Exclusions = Exclusions;

			rng = new RNGCryptoServiceProvider();
		}

		#endregion


		public string Generate()
		{
			// Pick random length between minimum and maximum   
			int pwdLength = GetCryptographicRandomNumber( this.Minimum, this.Maximum );

			if ( !this.hasRepeating && ( GetAllowedChars().Length < pwdLength ) )
				throw new Exception( "Nemtudok a feltetelnek megfelelo jelszot generalni" );

			if ( ( this.exclusionSet != null ) &&
				( ( this.hasLowerChar && this.requireAlltype && IsSubString( this.lowerCharString, this.exclusionSet ) )
				|| ( this.hasUpperChar && this.requireAlltype && IsSubString( this.upperCharString, this.exclusionSet ) )
				|| ( this.hasNumbers && this.requireAlltype && IsSubString( this.numberCharString, this.exclusionSet ) )
				|| ( this.hasSymbols && this.requireAlltype && IsSubString( this.symbolCharString, this.exclusionSet ) ) ) )
				throw new Exception( "Az egyik karakterhalmaz teljesen ki van zarva" );

			StringBuilder pwdBuffer = new StringBuilder();
			pwdBuffer.Capacity = this.Maximum;

			// Generate random characters
			char lastCharacter, nextCharacter;

			// Initial dummy character flag
			lastCharacter = nextCharacter = '\n';

			do
			{
				pwdBuffer.Length = 0;
				while ( pwdBuffer.Length < pwdLength )
				{
					nextCharacter = GetRandomCharacter();

					if ( !this.ConsecutiveCharacters )
					{
						if ( lastCharacter == nextCharacter )
							continue;
					}

					if ( !this.RepeatCharacters )
					{
						if ( pwdBuffer.ToString().IndexOf( nextCharacter ) >= 0 )
							continue;
					}

					if ( null != this.Exclusions )
					{
						if ( this.Exclusions.IndexOf( nextCharacter ) >= 0 )
							continue;
					}

					pwdBuffer.Append( nextCharacter );
					lastCharacter = nextCharacter;
				}
			} while ( this.requireAlltype && !IsGoodPassword( pwdBuffer.ToString() ) );

			return pwdBuffer.ToString();
		}

		protected bool IsGoodPassword( string password )
		{
			if ( hasLowerChar && ( password.IndexOfAny( lowerCharString.ToCharArray() ) < 0 ) )
				return false;
			if ( hasUpperChar && ( password.IndexOfAny( upperCharString.ToCharArray() ) < 0 ) )
				return false;
			if ( hasNumbers && ( password.IndexOfAny( numberCharString.ToCharArray() ) < 0 ) )
				return false;
			if ( hasSymbols && ( password.IndexOfAny( symbolCharString.ToCharArray() ) < 0 ) )
				return false;
			return true;
		}

		protected bool IsSubString( string needle, string haystack )
		{
			foreach ( char c in needle )
			{
				if ( haystack.IndexOf( c ) < 0 )
					return false;
			}
			return true;
		}

		protected int GetCryptographicRandomNumber( int lBound, int uBound )
		{
			// Assumes lBound >= 0 && lBound < uBound
			// returns an int >= lBound and < uBound
			uint urndnum;
			byte[] rndnum = new Byte[4];
			if ( lBound >= uBound - 1 )
			{
				// test for degenerate case where only lBound can be returned   
				return lBound;
			}

			uint xcludeRndBase = ( uint.MaxValue - ( uint.MaxValue % (uint)( uBound - lBound ) ) );

			do
			{
				rng.GetBytes( rndnum );
				urndnum = System.BitConverter.ToUInt32( rndnum, 0 );
			} while ( urndnum >= xcludeRndBase );

			return (int)( urndnum % ( uBound - lBound ) ) + lBound;
		}

		protected string GetAllowedChars()
		{
			if ( !( hasLowerChar || hasUpperChar || hasNumbers || hasSymbols ) )
				throw new ArgumentException( "Egy karakterhalmazt engedelyezni kell" );

			string pwdChar = "";
			if ( hasLowerChar )
				pwdChar += lowerCharString;
			if ( hasUpperChar )
				pwdChar += upperCharString;
			if ( hasNumbers )
				pwdChar += numberCharString;
			if ( hasSymbols )
				pwdChar += symbolCharString;
			return pwdChar;
		}

		protected char GetRandomCharacter()
		{
			char[] pwdCharArray = GetAllowedChars().ToCharArray();
			int randomCharPosition = GetCryptographicRandomNumber( pwdCharArray.GetLowerBound( 0 ), pwdCharArray.GetUpperBound( 0 ) );
			char randomChar = pwdCharArray[randomCharPosition];
			return randomChar;
		}
	}
}
