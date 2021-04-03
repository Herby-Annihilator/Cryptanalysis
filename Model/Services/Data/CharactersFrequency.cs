using System;
using System.Collections.Generic;
using System.Text;

namespace Cryptanalysis.Model.Services.Data
{
	public abstract class CharactersFrequency
	{
		public abstract double FrequencyOfCharacter(char character);
		public abstract char GetClosestSymbolInFrequency(double frequence);
	}
}
