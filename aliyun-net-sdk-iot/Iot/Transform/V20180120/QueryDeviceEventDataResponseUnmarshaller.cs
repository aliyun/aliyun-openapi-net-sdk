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
    public class QueryDeviceEventDataResponseUnmarshaller
    {
        public static QueryDeviceEventDataResponse Unmarshall(UnmarshallerContext context)
        {
			QueryDeviceEventDataResponse queryDeviceEventDataResponse = new QueryDeviceEventDataResponse();

			queryDeviceEventDataResponse.HttpResponse = context.HttpResponse;
			queryDeviceEventDataResponse.RequestId = context.StringValue("QueryDeviceEventData.RequestId");
			queryDeviceEventDataResponse.Success = context.BooleanValue("QueryDeviceEventData.Success");
			queryDeviceEventDataResponse.Code = context.StringValue("QueryDeviceEventData.Code");
			queryDeviceEventDataResponse.ErrorMessage = context.StringValue("QueryDeviceEventData.ErrorMessage");

			QueryDeviceEventDataResponse.QueryDeviceEventData_Data data = new QueryDeviceEventDataResponse.QueryDeviceEventData_Data();
			data.NextTime = context.LongValue("QueryDeviceEventData.Data.NextTime");
			data.NextValid = context.BooleanValue("QueryDeviceEventData.Data.NextValid");

			List<QueryDeviceEventDataResponse.QueryDeviceEventData_Data.QueryDeviceEventData_EventInfo> data_list = new List<QueryDeviceEventDataResponse.QueryDeviceEventData_Data.QueryDeviceEventData_EventInfo>();
			for (int i = 0; i < context.Length("QueryDeviceEventData.Data.List.Length"); i++) {
				QueryDeviceEventDataResponse.QueryDeviceEventData_Data.QueryDeviceEventData_EventInfo eventInfo = new QueryDeviceEventDataResponse.QueryDeviceEventData_Data.QueryDeviceEventData_EventInfo();
				eventInfo.Time = context.StringValue("QueryDeviceEventData.Data.List["+ i +"].Time");
				eventInfo.Identifier = context.StringValue("QueryDeviceEventData.Data.List["+ i +"].Identifier");
				eventInfo.Name = context.StringValue("QueryDeviceEventData.Data.List["+ i +"].Name");
				eventInfo.EventType = context.StringValue("QueryDeviceEventData.Data.List["+ i +"].EventType");
				eventInfo.OutputData = context.StringValue("QueryDeviceEventData.Data.List["+ i +"].OutputData");

				data_list.Add(eventInfo);
			}
			data.List = data_list;
			queryDeviceEventDataResponse.Data = data;
        
			return queryDeviceEventDataResponse;
        }
    }
}
