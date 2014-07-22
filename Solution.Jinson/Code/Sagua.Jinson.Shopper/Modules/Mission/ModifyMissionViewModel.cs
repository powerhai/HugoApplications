using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Unity;
using Sagua.Jinson.Shopper.Common;
using Sagua.Jinson.Shopper.Models;

namespace Sagua.Jinson.Shopper.Modules.Mission
{
    public class ModifyMissionViewModel : BaseViewModel
    {
        public UiMission Mission
        {
            get;
            set;
        }
        public ModifyMissionViewModel (IUnityContainer container) : base(container) {}
        public override void LoadViewData ()
        {
             
        }
    }
}
