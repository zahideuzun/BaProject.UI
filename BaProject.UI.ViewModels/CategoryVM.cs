using BaProject.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaProject.UI.ViewModels
{
	public class CategoryVM : IModel
	{
		public int CategoryId { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
	}
}
