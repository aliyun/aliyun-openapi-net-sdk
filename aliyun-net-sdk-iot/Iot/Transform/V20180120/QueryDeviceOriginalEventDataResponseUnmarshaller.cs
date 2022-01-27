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
    public class QueryDeviceOriginalEventDataResponseUnmarshaller
    {
        public static QueryDeviceOriginalEventDataResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryDeviceOriginalEventDataResponse queryDeviceOriginalEventDataResponse = new QueryDeviceOriginalEventDataResponse();

			queryDeviceOriginalEventDataResponse.HttpResponse = _ctx.HttpResponse;
			queryDeviceOriginalEventDataResponse.RequestId = _ctx.StringValue("QueryDeviceOriginalEventData.RequestId");
			queryDeviceOriginalEventDataResponse.Success = _ctx.BooleanValue("QueryDeviceOriginalEventData.Success");
			queryDeviceOriginalEventDataResponse.Code = _ctx.StringValue("QueryDeviceOriginalEventData.Code");
			queryDeviceOriginalEventDataResponse.ErrorMessage = _ctx.StringValue("QueryDeviceOriginalEventData.ErrorMessage");

			QueryDeviceOriginalEventDataResponse.QueryDeviceOriginalEventData_Data data = new QueryDeviceOriginalEventDataResponse.QueryDeviceOriginalEventData_Data();
			data.NextPageToken = _ctx.StringValue("QueryDeviceOriginalEventData.Data.NextPageToken");
			data.NextValid = _ctx.BooleanValue("QueryDeviceOriginalEventData.Data.NextValid");

			List<QueryDeviceOriginalEventDataResponse.QueryDeviceOriginalEventData_Data.QueryDeviceOriginalEventData_EventInfo> data_list = new List<QueryDeviceOriginalEventDataResponse.QueryDeviceOriginalEventData_Data.QueryDeviceOriginalEventData_EventInfo>();
			for (int i = 0; i < _ctx.Length("QueryDeviceOriginalEventData.Data.List.Length"); i++) {
				QueryDeviceOriginalEventDataResponse.QueryDeviceOriginalEventData_Data.QueryDeviceOriginalEventData_EventInfo eventInfo = new QueryDeviceOriginalEventDataResponse.QueryDeviceOriginalEventData_Data.QueryDeviceOriginalEventData_EventInfo();
				eventInfo.Time = _ctx.StringValue("QueryDeviceOriginalEventData.Data.List["+ i +"].Time");
				eventInfo.Identifier = _ctx.StringValue("QueryDeviceOriginalEventData.Data.List["+ i +"].Identifier");
				eventInfo.Name = _ctx.StringValue("QueryDeviceOriginalEventData.Data.List["+ i +"].Name");
				eventInfo.EventType = _ctx.StringValue("QueryDeviceOriginalEventData.Data.List["+ i +"].EventType");
				eventInfo.OutputData = _ctx.StringValue("QueryDeviceOriginalEventData.Data.List["+ i +"].OutputData");

				data_list.Add(eventInfo);
			}
			data.List = data_list;
			queryDeviceOriginalEventDataResponse.Data = data;
        
			return queryDeviceOriginalEventDataResponse;
        }
    }
}
