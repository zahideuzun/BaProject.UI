using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaProject.Validation;
using BaProject.UI.ViewModels;

namespace BaProject.UI.Validations
{
	public class CategoryValidator : ValidatorBase<CategoryVM>
	{
		public CategoryValidator(CategoryVM model): base(model)
		{
			
		}

		public override void OnValidate()
		{
			if (string.IsNullOrEmpty(Model.Name))
			{
				IsValid = false;
				ValidationMessages.Add("kategori adı boş geçilemez!");
			}

			if (Model.Name!= null)
			{
				if (Model.Name.Length <2)
				{
					IsValid =false;
					ValidationMessages.Add("kategori adı en az 3 karakter olmalı!");
				}
			}
		}
	}
}
