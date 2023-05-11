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
using Aliyun.Acs.Linkvisual.Model.V20180120;

namespace Aliyun.Acs.Linkvisual.Transform.V20180120
{
    public class QueryDeviceVodUrlResponseUnmarshaller
    {
        public static QueryDeviceVodUrlResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryDeviceVodUrlResponse queryDeviceVodUrlResponse = new QueryDeviceVodUrlResponse();

			queryDeviceVodUrlResponse.HttpResponse = _ctx.HttpResponse;
			queryDeviceVodUrlResponse.Code = _ctx.StringValue("QueryDeviceVodUrl.Code");
			queryDeviceVodUrlResponse.ErrorMessage = _ctx.StringValue("QueryDeviceVodUrl.ErrorMessage");
			queryDeviceVodUrlResponse.RequestId = _ctx.StringValue("QueryDeviceVodUrl.RequestId");
			queryDeviceVodUrlResponse.Success = _ctx.BooleanValue("QueryDeviceVodUrl.Success");

			QueryDeviceVodUrlResponse.QueryDeviceVodUrl_Data data = new QueryDeviceVodUrlResponse.QueryDeviceVodUrl_Data();
			data.DecryptKey = _ctx.StringValue("QueryDeviceVodUrl.Data.DecryptKey");
			data.StunInfo = _ctx.StringValue("QueryDeviceVodUrl.Data.StunInfo");
			data.VodUrl = _ctx.StringValue("QueryDeviceVodUrl.Data.VodUrl");
			queryDeviceVodUrlResponse.Data = data;
        
			return queryDeviceVodUrlResponse;
        }
    }
}
