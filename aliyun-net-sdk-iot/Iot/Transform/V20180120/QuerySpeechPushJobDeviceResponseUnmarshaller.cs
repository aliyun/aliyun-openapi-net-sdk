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
using Aliyun.Acs.Iot.Model.V20180120;

namespace Aliyun.Acs.Iot.Transform.V20180120
{
    public class QuerySpeechPushJobDeviceResponseUnmarshaller
    {
        public static QuerySpeechPushJobDeviceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QuerySpeechPushJobDeviceResponse querySpeechPushJobDeviceResponse = new QuerySpeechPushJobDeviceResponse();

			querySpeechPushJobDeviceResponse.HttpResponse = _ctx.HttpResponse;
			querySpeechPushJobDeviceResponse.RequestId = _ctx.StringValue("QuerySpeechPushJobDevice.RequestId");
			querySpeechPushJobDeviceResponse.Success = _ctx.BooleanValue("QuerySpeechPushJobDevice.Success");
			querySpeechPushJobDeviceResponse.Code = _ctx.StringValue("QuerySpeechPushJobDevice.Code");
			querySpeechPushJobDeviceResponse.ErrorMessage = _ctx.StringValue("QuerySpeechPushJobDevice.ErrorMessage");

			QuerySpeechPushJobDeviceResponse.QuerySpeechPushJobDevice_Data data = new QuerySpeechPushJobDeviceResponse.QuerySpeechPushJobDevice_Data();
			data.Total = _ctx.IntegerValue("QuerySpeechPushJobDevice.Data.Total");
			data.PageId = _ctx.IntegerValue("QuerySpeechPushJobDevice.Data.PageId");
			data.PageSize = _ctx.IntegerValue("QuerySpeechPushJobDevice.Data.PageSize");

			List<QuerySpeechPushJobDeviceResponse.QuerySpeechPushJobDevice_Data.QuerySpeechPushJobDevice_Items> data_list = new List<QuerySpeechPushJobDeviceResponse.QuerySpeechPushJobDevice_Data.QuerySpeechPushJobDevice_Items>();
			for (int i = 0; i < _ctx.Length("QuerySpeechPushJobDevice.Data.List.Length"); i++) {
				QuerySpeechPushJobDeviceResponse.QuerySpeechPushJobDevice_Data.QuerySpeechPushJobDevice_Items items = new QuerySpeechPushJobDeviceResponse.QuerySpeechPushJobDevice_Data.QuerySpeechPushJobDevice_Items();
				items.GmtModified = _ctx.LongValue("QuerySpeechPushJobDevice.Data.List["+ i +"].GmtModified");
				items.Status = _ctx.StringValue("QuerySpeechPushJobDevice.Data.List["+ i +"].Status");
				items.DeviceName = _ctx.StringValue("QuerySpeechPushJobDevice.Data.List["+ i +"].DeviceName");
				items.ErrorCode = _ctx.StringValue("QuerySpeechPushJobDevice.Data.List["+ i +"].ErrorCode");
				items.ErrorMessage = _ctx.StringValue("QuerySpeechPushJobDevice.Data.List["+ i +"].ErrorMessage");

				data_list.Add(items);
			}
			data.List = data_list;
			querySpeechPushJobDeviceResponse.Data = data;
        
			return querySpeechPushJobDeviceResponse;
        }
    }
}
