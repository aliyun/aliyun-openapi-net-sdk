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
    public class QueryDeviceVodUrlByTimeResponseUnmarshaller
    {
        public static QueryDeviceVodUrlByTimeResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryDeviceVodUrlByTimeResponse queryDeviceVodUrlByTimeResponse = new QueryDeviceVodUrlByTimeResponse();

			queryDeviceVodUrlByTimeResponse.HttpResponse = _ctx.HttpResponse;
			queryDeviceVodUrlByTimeResponse.Code = _ctx.StringValue("QueryDeviceVodUrlByTime.Code");
			queryDeviceVodUrlByTimeResponse.ErrorMessage = _ctx.StringValue("QueryDeviceVodUrlByTime.ErrorMessage");
			queryDeviceVodUrlByTimeResponse.RequestId = _ctx.StringValue("QueryDeviceVodUrlByTime.RequestId");
			queryDeviceVodUrlByTimeResponse.Success = _ctx.BooleanValue("QueryDeviceVodUrlByTime.Success");

			QueryDeviceVodUrlByTimeResponse.QueryDeviceVodUrlByTime_Data data = new QueryDeviceVodUrlByTimeResponse.QueryDeviceVodUrlByTime_Data();
			data.DecryptKey = _ctx.StringValue("QueryDeviceVodUrlByTime.Data.DecryptKey");
			data.StunInfo = _ctx.StringValue("QueryDeviceVodUrlByTime.Data.StunInfo");
			data.VodUrl = _ctx.StringValue("QueryDeviceVodUrlByTime.Data.VodUrl");
			queryDeviceVodUrlByTimeResponse.Data = data;
        
			return queryDeviceVodUrlByTimeResponse;
        }
    }
}
