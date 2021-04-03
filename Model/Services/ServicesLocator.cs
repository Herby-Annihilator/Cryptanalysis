using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cryptanalysis.Model.Services
{
	public class ServicesLocator
	{
		public ProhibitedCombinationsCriterion ProhibitedCombinationsCriterion => App.Host.Services.GetRequiredService<ProhibitedCombinationsCriterion>();
		public ColumnPermutationCipherDecryptor ColumnPermutationCipherDecryptor => App.Host.Services.GetRequiredService<ColumnPermutationCipherDecryptor>();
	}
}
