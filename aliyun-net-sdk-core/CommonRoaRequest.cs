using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Aliyun.Acs.Core.Http;

namespace Aliyun.Acs.Core
{
    class CommonRoaRequest : RoaAcsRequest<CommonResponse>
    {
        public CommonRoaRequest(string product)
            : base(product)
        {
            this.AcceptFormat = FormatType.JSON;
        }

        public override CommonResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return null;
        }
    }
}
