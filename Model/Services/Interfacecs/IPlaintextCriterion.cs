using System;
using System.Collections.Generic;
using System.Text;

namespace Cryptanalysis.Model.Services.Interfacecs
{
	public interface IPlaintextCriterion
	{
		bool IsPlainText(string text);
	}
}
