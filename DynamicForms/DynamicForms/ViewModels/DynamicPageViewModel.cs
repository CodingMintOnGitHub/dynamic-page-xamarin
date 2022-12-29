using System;
using System.Threading.Tasks;
using DynamicForms.Template;
using MvvmCross.Commands;
using Newtonsoft.Json;

namespace DynamicForms.ViewModels
{
    public class DynamicPageViewModel : BaseViewModel
    {
        public const string defaultSerializedJson = "{\"title\":\"Music Form\",\"fields\":[{\"label\":\"Band Name\",\"type\":\"textbox\"},{\"label\":\"Genre\",\"type\":\"dropdown\",\"values\":[\"Rock\",\"Metal\",\"Jazz\"]},{\"label\":\"Member Count\",\"type\":\"dropdown\",\"values\":[\"One\",\"Two\",\"Three\",\"More Than Three\"]},{\"label\":\"Rating out of 5\",\"type\":\"numericTextBox\"}]}";

        private string _serializedJson = defaultSerializedJson;
        public string SerializedJson
        {
            get
            {
                return _serializedJson;
            }
            set { SetProperty(ref _serializedJson, value); }
        }



        public override Task Initialize()
        {
            Task.Run(async () =>
            {
                await Task.Delay(2000); // api call and response delay
                PageTemplateInput = JsonConvert.DeserializeObject<PageTemplate>(SerializedJson);
                await RaisePropertyChanged("PageTemplateInput");
            });
            return base.Initialize();
        }

        public IMvxCommand SubmitCommand => new MvxCommand(() =>
        {
            var submit = this.PageTemplateInput;
        });
    }
}
