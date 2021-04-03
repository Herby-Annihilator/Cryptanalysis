using System;
using System.Collections.Generic;
using System.Text;

namespace Cryptanalysis.Model.Services.Data
{
	public class RussianCharactersFrequency : CharactersFrequency
	{
		public override double FrequencyOfCharacter(char character)
		{
			character = char.ToLower(character);
			return character switch
			{
				'а' => 0.062,
				'б' => 0.014,
				'в' => 0.038,
				'г' => 0.013,
				'д' => 0.025,
				'е' => 0.072,
				'ж' => 0.007,
				'з' => 0.016,
				'и' => 0.062,
				'й' => 0.010,
				'к' => 0.028,
				'л' => 0.035,
				'м' => 0.026,
				'н' => 0.053,
				'о' => 0.090,
				'п' => 0.023,
				'р' => 0.040,
				'с' => 0.045,
				'т' => 0.053,
				'у' => 0.021,
				'ф' => 0.002,
				'х' => 0.009,
				'ц' => 0.004,
				'ч' => 0.012,
				'ш' => 0.006,
				'щ' => 0.003,
				'ъ' => 0.014,
				'ы' => 0.016,
				'ь' => 0.014,
				'э' => 0.003,
				'ю' => 0.006,
				'я' => 0.018
			};
			throw new ArgumentException($"{character} не поддерживается либо не является символом русского алфавита");
		}

		public override char GetClosestSymbolInFrequency(double frequence)
		{
			char closestSymbol = 'а';
			double closestFrequency = FrequencyOfCharacter('а');
			double currentFrequency;
			for (char i = 'б'; i <= 'я'; i++)
			{
				currentFrequency = FrequencyOfCharacter(i);
				if (Math.Abs(frequence - currentFrequency) < Math.Abs(frequence - closestFrequency))
				{
					closestFrequency = currentFrequency;
					closestSymbol = i;
				}
			}
			return closestSymbol;
		}
	}
}
