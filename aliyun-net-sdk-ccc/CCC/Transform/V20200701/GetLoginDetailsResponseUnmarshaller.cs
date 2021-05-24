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
using Aliyun.Acs.CCC.Model.V20200701;

namespace Aliyun.Acs.CCC.Transform.V20200701
{
    public class GetLoginDetailsResponseUnmarshaller
    {
        public static GetLoginDetailsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetLoginDetailsResponse getLoginDetailsResponse = new GetLoginDetailsResponse();

			getLoginDetailsResponse.HttpResponse = _ctx.HttpResponse;
			getLoginDetailsResponse.Code = _ctx.StringValue("GetLoginDetails.Code");
			getLoginDetailsResponse.HttpStatusCode = _ctx.IntegerValue("GetLoginDetails.HttpStatusCode");
			getLoginDetailsResponse.Message = _ctx.StringValue("GetLoginDetails.Message");
			getLoginDetailsResponse.RequestId = _ctx.StringValue("GetLoginDetails.RequestId");

			List<string> getLoginDetailsResponse_params = new List<string>();
			for (int i = 0; i < _ctx.Length("GetLoginDetails.Params.Length"); i++) {
				getLoginDetailsResponse_params.Add(_ctx.StringValue("GetLoginDetails.Params["+ i +"]"));
			}
			getLoginDetailsResponse._Params = getLoginDetailsResponse_params;

			GetLoginDetailsResponse.GetLoginDetails_Data data = new GetLoginDetailsResponse.GetLoginDetails_Data();
			data.DeviceId = _ctx.StringValue("GetLoginDetails.Data.DeviceId");
			data.DisplayName = _ctx.StringValue("GetLoginDetails.Data.DisplayName");
			data.Extension = _ctx.StringValue("GetLoginDetails.Data.Extension");
			data.Signature = _ctx.StringValue("GetLoginDetails.Data.Signature");
			data.SipServerUrl = _ctx.StringValue("GetLoginDetails.Data.SipServerUrl");
			data.UserId = _ctx.StringValue("GetLoginDetails.Data.UserId");
			data.UserKey = _ctx.StringValue("GetLoginDetails.Data.UserKey");
			getLoginDetailsResponse.Data = data;
        
			return getLoginDetailsResponse;
        }
    }
}
