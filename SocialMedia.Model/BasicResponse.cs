using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMedia.Model
{
    public class BasicResponse
    {
        public bool IsSuccess { get; set; } = true;
        public string Message { get; set; } = SocialMedia.Model.Constant.Constant.SUCCESS;
    }
}
