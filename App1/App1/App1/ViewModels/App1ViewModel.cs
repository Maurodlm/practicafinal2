
namespace App1.ViewModels
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using Services;

    public class App1ViewModel:BaseViewModel
    {
        #region Services
        private ApiService apiService;
        #endregion

        #region Attributes
        private ObservableCollection<App> app1;
        #endregion

        #region Properties
        public ObservableCollection<App> App1
        {
            get { return this.app1; }
            set { SetValue(ref this.app1, value); }
        }
        #endregion

        #region Constructors
        public App1ViewModel()
        {
            this.apiService = new ApiService();
            this.LoadApp1();
        }
        #endregion

        #region Methods
        private async void LoadApp1()
        {
            var response = await this.apiService.GetList<App>(
                "",
                "",
                "");
        }
        #endregion
    }

}
