using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Cryptanalysis.Model.Services.Interfacecs
{
	public interface IPlaintextCriterion
	{
		bool IsPlainText(string text);
		Task<bool> IsPlainTextAsync(string text);
	}
}
