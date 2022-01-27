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
using Aliyun.Acs.LinkWAN.Model.V20190301;

namespace Aliyun.Acs.LinkWAN.Transform.V20190301
{
    public class GetNodeLocalConfigResponseUnmarshaller
    {
        public static GetNodeLocalConfigResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetNodeLocalConfigResponse getNodeLocalConfigResponse = new GetNodeLocalConfigResponse();

			getNodeLocalConfigResponse.HttpResponse = _ctx.HttpResponse;
			getNodeLocalConfigResponse.RequestId = _ctx.StringValue("GetNodeLocalConfig.RequestId");
			getNodeLocalConfigResponse.Success = _ctx.BooleanValue("GetNodeLocalConfig.Success");
			getNodeLocalConfigResponse.Code = _ctx.StringValue("GetNodeLocalConfig.Code");
			getNodeLocalConfigResponse.ErrorMessage = _ctx.StringValue("GetNodeLocalConfig.ErrorMessage");

			GetNodeLocalConfigResponse.GetNodeLocalConfig_Data data = new GetNodeLocalConfigResponse.GetNodeLocalConfig_Data();
			data.DevType = _ctx.StringValue("GetNodeLocalConfig.Data.DevType");
			data.Eui = _ctx.StringValue("GetNodeLocalConfig.Data.Eui");
			data.D2dAddr = _ctx.StringValue("GetNodeLocalConfig.Data.D2dAddr");
			data.D2dKey = _ctx.StringValue("GetNodeLocalConfig.Data.D2dKey");
			data.Freq = _ctx.IntegerValue("GetNodeLocalConfig.Data.Freq");
			data.Datr = _ctx.IntegerValue("GetNodeLocalConfig.Data.Datr");
			data.TaskId = _ctx.LongValue("GetNodeLocalConfig.Data.TaskId");
			data.CreateMillis = _ctx.LongValue("GetNodeLocalConfig.Data.CreateMillis");
			data.ModifiedMillis = _ctx.LongValue("GetNodeLocalConfig.Data.ModifiedMillis");
			getNodeLocalConfigResponse.Data = data;
        
			return getNodeLocalConfigResponse;
        }
    }
}
