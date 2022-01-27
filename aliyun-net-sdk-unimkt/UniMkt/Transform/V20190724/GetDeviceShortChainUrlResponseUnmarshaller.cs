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
using Aliyun.Acs.UniMkt.Model.V20190724;

namespace Aliyun.Acs.UniMkt.Transform.V20190724
{
    public class GetDeviceShortChainUrlResponseUnmarshaller
    {
        public static GetDeviceShortChainUrlResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetDeviceShortChainUrlResponse getDeviceShortChainUrlResponse = new GetDeviceShortChainUrlResponse();

			getDeviceShortChainUrlResponse.HttpResponse = _ctx.HttpResponse;
			getDeviceShortChainUrlResponse.RequestId = _ctx.StringValue("GetDeviceShortChainUrl.RequestId");
			getDeviceShortChainUrlResponse.Status = _ctx.BooleanValue("GetDeviceShortChainUrl.Status");
			getDeviceShortChainUrlResponse.ErrorMessage = _ctx.StringValue("GetDeviceShortChainUrl.ErrorMessage");
			getDeviceShortChainUrlResponse.ErrorCode = _ctx.StringValue("GetDeviceShortChainUrl.ErrorCode");

			GetDeviceShortChainUrlResponse.GetDeviceShortChainUrl_Data data = new GetDeviceShortChainUrlResponse.GetDeviceShortChainUrl_Data();
			data.ShortImgUrl = _ctx.StringValue("GetDeviceShortChainUrl.Data.ShortImgUrl");
			data.ShortUrl = _ctx.StringValue("GetDeviceShortChainUrl.Data.ShortUrl");
			getDeviceShortChainUrlResponse.Data = data;
        
			return getDeviceShortChainUrlResponse;
        }
    }
}
