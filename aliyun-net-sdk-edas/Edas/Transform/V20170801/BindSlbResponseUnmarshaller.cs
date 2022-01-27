/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using System;
using System.Collections.Generic;

using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Edas.Model.V20170801;

namespace Aliyun.Acs.Edas.Transform.V20170801
{
    public class BindSlbResponseUnmarshaller
    {
        public static BindSlbResponse Unmarshall(UnmarshallerContext _ctx)
        {
			BindSlbResponse bindSlbResponse = new BindSlbResponse();

			bindSlbResponse.HttpResponse = _ctx.HttpResponse;
			bindSlbResponse.Code = _ctx.IntegerValue("BindSlb.Code");
			bindSlbResponse.Message = _ctx.StringValue("BindSlb.Message");
			bindSlbResponse.RequestId = _ctx.StringValue("BindSlb.RequestId");

			BindSlbResponse.BindSlb_Data data = new BindSlbResponse.BindSlb_Data();
			data.ExtSlbId = _ctx.StringValue("BindSlb.Data.ExtSlbId");
			data.ExtSlbIp = _ctx.StringValue("BindSlb.Data.ExtSlbIp");
			data.ExtSlbName = _ctx.StringValue("BindSlb.Data.ExtSlbName");
			data.ExtVServerGroupId = _ctx.StringValue("BindSlb.Data.ExtVServerGroupId");
			data.SlbId = _ctx.StringValue("BindSlb.Data.SlbId");
			data.SlbIp = _ctx.StringValue("BindSlb.Data.SlbIp");
			data.SlbName = _ctx.StringValue("BindSlb.Data.SlbName");
			data.SlbPort = _ctx.IntegerValue("BindSlb.Data.SlbPort");
			data.VServerGroupId = _ctx.StringValue("BindSlb.Data.VServerGroupId");
			bindSlbResponse.Data = data;
        
			return bindSlbResponse;
        }
    }
}
