using Cryptanalysis.Model.Services.Interfacecs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cryptanalysis.Model.Services
{
	public class ColumnPermutationCipherDecryptor : IDecryptor
	{
		public string Decrypt(string text)
		{
			char[][] characterMatrix = BuildCharacterMatrix(text);
			return null;
		}

		private char[][] BuildCharacterMatrix(string text)
		{
			int size = (int)Math.Sqrt(text.Length);
			char[][] toReturn = new char[size][];
			for (int i = 0; i < size; i++)
			{
				toReturn[i] = new char[size];
				for (int j = 0; j < size; j++)
				{
					toReturn[i][j] = text[i * size + j];
				}
			}
			return toReturn;
		}
	}
}
