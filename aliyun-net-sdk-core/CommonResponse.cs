using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Aliyun.Acs.Core.Http;

namespace Aliyun.Acs.Core
{
    public class CommonResponse : AcsResponse
    {
        public string Data { get; set; }
    }
}
