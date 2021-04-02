using Cryptanalysis.ViewModels.Base;
using Cryptanalysis.Infrastructure.Commands;
using System.Windows.Input;
using System.Windows.Markup;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cryptanalysis.ViewModels
{
	[MarkupExtensionReturnType(typeof(MainWindowViewModel))]
	public class MainWindowViewModel : ViewModel
	{
		#region Properties
		private string _title = "Title";
		public string Title { get => _title; set => Set(ref _title, value); }
		#endregion

		#region Commands

		#endregion
	}
}
