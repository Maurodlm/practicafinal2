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
        #endregion
        #region Constructors
        public MainViewModel()
        {
            this.Login = new LoginViewModel();
        }
        #endregion
    }
}

