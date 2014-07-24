using Sagua.Global.Common;

namespace Sagua.Jinson.Shopper.Models
{
    public class UiServer : ObservableObject
    {

        public long Id
        {
            get;
            set;
        }

        private string mUrl;
        public string Url
        {
            get
            {
                return mUrl;
            }
            set
            {
                mUrl = value;
                OnPropertyChanged();
            }
        }

         

        private bool mIsEnable;
        public bool IsEnable
        {
            get
            {
                return mIsEnable;
            }
            set
            {
                mIsEnable = value;
                OnPropertyChanged();
            }
        }


        private bool mIsOpenning;
        public bool IsOpenning
        {
            get
            {
                return mIsOpenning;
            }
            set
            {
                mIsOpenning = value;
                OnPropertyChanged();
            }
        }
      
      
      
    }
}