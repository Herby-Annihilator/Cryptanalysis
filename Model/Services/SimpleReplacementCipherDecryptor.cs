/*
Шифрование заключалось в замене каждой буквы на двузначное число. Отдельные слова разделены 
несколькими пробелами, знаки препинания сохранены. Таблица частот букв русского языка известна.
 */



using Cryptanalysis.Model.Services.Interfacecs;
using System;
using System.Collections.Generic;
using System.Text;
using MyLibrary.DataStructures.SuffixAutomaton;
using Cryptanalysis.Model.Services.Data;

namespace Cryptanalysis.Model.Services
{
	public class SimpleReplacementCipherDecryptor : IDecryptor
	{
		private const int COUNT_OF_TWO_DIGIT_NUMBERS = 90;
		private CharactersFrequency _charactersFrequency;
		public SimpleReplacementCipherDecryptor()
		{
			_charactersFrequency = new RussianCharactersFrequency();
		}
		public string Decrypt(string text)
		{
			int countOfCharsInOriginalText = 0;
			SuffixAutomaton automaton = new SuffixAutomaton(text);
			double[] numbersFrequency = new double[COUNT_OF_TWO_DIGIT_NUMBERS];
			for (int i = 0; i < COUNT_OF_TWO_DIGIT_NUMBERS; i++)
			{
				numbersFrequency[i] = automaton.CountSubstringOccurences((i + 10).ToString());
				countOfCharsInOriginalText += (int)numbersFrequency[i];
			}
			for (int i = 0; i < COUNT_OF_TWO_DIGIT_NUMBERS; i++)
			{
				numbersFrequency[i] /= countOfCharsInOriginalText;
				if (numbersFrequency[i] > 0)
				{

				}
			}
		}

		public string Decrypt(string text, CharactersFrequency charactersFrequency)
		{
			_charactersFrequency = charactersFrequency;
			return Decrypt(text);
		}
	}

	
}
