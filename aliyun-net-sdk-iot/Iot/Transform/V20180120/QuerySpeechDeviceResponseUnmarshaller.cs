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
    public class QuerySpeechDeviceResponseUnmarshaller
    {
        public static QuerySpeechDeviceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QuerySpeechDeviceResponse querySpeechDeviceResponse = new QuerySpeechDeviceResponse();

			querySpeechDeviceResponse.HttpResponse = _ctx.HttpResponse;
			querySpeechDeviceResponse.RequestId = _ctx.StringValue("QuerySpeechDevice.RequestId");
			querySpeechDeviceResponse.Success = _ctx.BooleanValue("QuerySpeechDevice.Success");
			querySpeechDeviceResponse.Code = _ctx.StringValue("QuerySpeechDevice.Code");
			querySpeechDeviceResponse.ErrorMessage = _ctx.StringValue("QuerySpeechDevice.ErrorMessage");

			QuerySpeechDeviceResponse.QuerySpeechDevice_Data data = new QuerySpeechDeviceResponse.QuerySpeechDevice_Data();
			data.Total = _ctx.IntegerValue("QuerySpeechDevice.Data.Total");
			data.PageId = _ctx.IntegerValue("QuerySpeechDevice.Data.PageId");
			data.PageSize = _ctx.IntegerValue("QuerySpeechDevice.Data.PageSize");

			List<QuerySpeechDeviceResponse.QuerySpeechDevice_Data.QuerySpeechDevice_Items> data_list = new List<QuerySpeechDeviceResponse.QuerySpeechDevice_Data.QuerySpeechDevice_Items>();
			for (int i = 0; i < _ctx.Length("QuerySpeechDevice.Data.List.Length"); i++) {
				QuerySpeechDeviceResponse.QuerySpeechDevice_Data.QuerySpeechDevice_Items items = new QuerySpeechDeviceResponse.QuerySpeechDevice_Data.QuerySpeechDevice_Items();
				items.ProductKey = _ctx.StringValue("QuerySpeechDevice.Data.List["+ i +"].ProductKey");
				items.DeviceName = _ctx.StringValue("QuerySpeechDevice.Data.List["+ i +"].DeviceName");
				items.IotId = _ctx.StringValue("QuerySpeechDevice.Data.List["+ i +"].IotId");
				items.AvailableSpace = _ctx.FloatValue("QuerySpeechDevice.Data.List["+ i +"].AvailableSpace");

				data_list.Add(items);
			}
			data.List = data_list;
			querySpeechDeviceResponse.Data = data;
        
			return querySpeechDeviceResponse;
        }
    }
}
