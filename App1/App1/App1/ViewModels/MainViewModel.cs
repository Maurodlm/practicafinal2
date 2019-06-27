namespace App1.ViewModels
{
    public class MainViewModel
    {
        #region VieModels
        public LoginViewModel Login
        {
            get;
            set;
        }
        public App1ViewModel App1
        {
            get;
            set;
        }
        #endregion

        #region Constructors
        public MainViewModel()
        {
            instance = this;
            this.Login = new LoginViewModel();
        }
        #endregion

        #region Singleton
        private static MainViewModel instance;

        public static MainViewModel GetInstance()
        {
            if (instance==null)
            {
                return new MainViewModel();
            }
            return instance;
        }
        #endregion
    }
}

