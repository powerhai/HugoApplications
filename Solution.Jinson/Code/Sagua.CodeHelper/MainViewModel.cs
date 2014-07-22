using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using Microsoft.Practices.Prism.Commands;
using Sagua.CodeHelper.Annotations;

namespace Sagua.CodeHelper
{
    public class MainViewModel : INotifyPropertyChanged
    {


        private String mClientController;
        public String ClientController
        {
            get
            {
                return mClientController;
            }
            set
            {
                mClientController = value;
                OnPropertyChanged();
            }
        }
      

        private String mServerController;
        public String ServerController
        {
            get
            {
                return mServerController;
            }
            set
            {
                mServerController = value;
                OnPropertyChanged();
            }
        }
      
        private string mName;
        private List<string> mFiles;

        public string Name
        {
            get
            {
                return mName;
            }
            set
            {
                mName = value;
                OnPropertyChanged();
            }
        }

        public List<string> Files
        {
            get
            {
                return mFiles;
            }
            set
            {
                mFiles = value;
                OnPropertyChanged();
            }
        }

        public ICommand CreateCommand
        {
            get
            {
                return new DelegateCommand(() =>
                {
                    Create();
                });
            }
        }



        public ICommand CopyCommand
        {
            get
            {
                return new DelegateCommand<string>((file) =>
                {
                    Clipboard.SetFileDropList(new StringCollection() { file});
                });
            }

        }



        public ICommand CopyStringCommand
        {
            get
            {
                return new DelegateCommand<string>((str) =>
                {
                    Clipboard.SetText(str);
                });
            }

        }
      

        public void Create ()
        {
            var dir = new DirectoryInfo("Temp");
            if(!dir.Exists)
                dir.Create();
            var fs = dir.GetFiles();
            foreach(var file in fs)
            {
                file.Delete();
            }
              

            var files = new List<string>();
            files.Add(CreateResultFile(Name,dir.FullName ));
            files.Add(CreatePostModelFile(Name,dir.FullName)); 
            this.Files = files;
            CreateServerControllerString(Name);
            CreateClientControllerString(Name);
        }
        private void CreateClientControllerString (string name)
        {
            this.ClientController = Properties.Resources.ClientController.Replace("[Name]", name);
        }

        private void CreateServerControllerString (string name)
        {
            this.ServerController = Properties.Resources.ServerController.Replace("[Name]", name);
        }

        private string CreatePostModelFile(string name, string path)
        {
            var filename = string.Format("{0}\\{1}PostModel.cs", path, name);
            var file = File.CreateText(filename);
            file.Write(Properties.Resources.PostModel.Replace("[Name]", name));
            file.Close();
            return filename;
        }

        private string CreateResultFile (string name,string path)
        {
            var filename = string.Format("{0}\\{1}PostResult.cs", path, name);
            var file =   File.CreateText(filename);
            file.Write(Properties.Resources.Results.Replace("[Name]", name));
            file.Close();
            return filename;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged ([CallerMemberName] string propertyName = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if(handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
