using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Cryptanalysis.Model.Services.Interfacecs;
using System.IO;
using MyLibrary.DataStructures.SuffixAutomaton;

namespace Cryptanalysis.Model.Services
{
	public class ProhibitedCombinationsCriterion : IPlaintextCriterion
	{
		private string[] _prohibitedCombinations;

		public ProhibitedCombinationsCriterion(string fileWithProhibitedCombinations)
		{
			try
			{
				StreamReader reader = new StreamReader(fileWithProhibitedCombinations);
				_prohibitedCombinations = reader.ReadToEnd().Split("|", StringSplitOptions.RemoveEmptyEntries);
				reader.Close();
			}
			catch(Exception e)
			{
				_prohibitedCombinations = new string[0];
			}
		}
		public bool IsPlainText(string text)
		{
			SuffixAutomaton automaton = new SuffixAutomaton(text);
			if (automaton.IsBuilted)
			{
				for (int i = 0; i < _prohibitedCombinations.Length; i++)
				{
					if (automaton.FindConditionForSubstring(_prohibitedCombinations[i]) != 0)
						return false;
				}
			}
			else
			{
				throw new Exception("Автомат не был построен");
			}
			return true;
		}

		public async Task<bool> IsPlainTextAsync(string text)
		{
			return await Task.Run(() => IsPlainText(text));
		}
	}
}
