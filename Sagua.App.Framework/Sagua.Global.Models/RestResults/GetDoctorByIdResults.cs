using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sagua.Global.Common;

namespace Sagua.Global.Models.RestResults
{
    public class GetDoctorByIdResults : BaseRestResult
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class SetDoctorPhotoResults : BaseRestResult
    {
		public string Info{ get; set; }
    }
}
