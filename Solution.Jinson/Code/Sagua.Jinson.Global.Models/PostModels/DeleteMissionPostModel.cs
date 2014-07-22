using System;
using System.Collections.Generic;
using System.Text;
using Sagua.Global.Common;
using Sagua.Jinson.Global.Domain; 

namespace Sagua.Jinson.Global.Models.PostModels
{
    public class DeleteMissionPostModel : BaseRestPostModel
    {

        public long MissionId
        {
            get;
            set;
        }
    }
}
