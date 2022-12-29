using System;
using DynamicForms.Template;
using MvvmCross.ViewModels;

namespace DynamicForms.ViewModels
{
    public class BaseViewModel : MvxViewModel
    {
        private PageTemplate _pageTemplateInput = default;
        public PageTemplate PageTemplateInput
        {
            get
            {
                return _pageTemplateInput;
            }
            set { SetProperty(ref _pageTemplateInput, value); }
        }
    }
}
