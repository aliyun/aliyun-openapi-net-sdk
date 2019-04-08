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
    public class QueryDeviceServiceDataResponseUnmarshaller
    {
        public static QueryDeviceServiceDataResponse Unmarshall(UnmarshallerContext context)
        {
			QueryDeviceServiceDataResponse queryDeviceServiceDataResponse = new QueryDeviceServiceDataResponse();

			queryDeviceServiceDataResponse.HttpResponse = context.HttpResponse;
			queryDeviceServiceDataResponse.RequestId = context.StringValue("QueryDeviceServiceData.RequestId");
			queryDeviceServiceDataResponse.Success = context.BooleanValue("QueryDeviceServiceData.Success");
			queryDeviceServiceDataResponse.Code = context.StringValue("QueryDeviceServiceData.Code");
			queryDeviceServiceDataResponse.ErrorMessage = context.StringValue("QueryDeviceServiceData.ErrorMessage");

			QueryDeviceServiceDataResponse.QueryDeviceServiceData_Data data = new QueryDeviceServiceDataResponse.QueryDeviceServiceData_Data();
			data.NextTime = context.LongValue("QueryDeviceServiceData.Data.NextTime");
			data.NextValid = context.BooleanValue("QueryDeviceServiceData.Data.NextValid");

			List<QueryDeviceServiceDataResponse.QueryDeviceServiceData_Data.QueryDeviceServiceData_ServiceInfo> data_list = new List<QueryDeviceServiceDataResponse.QueryDeviceServiceData_Data.QueryDeviceServiceData_ServiceInfo>();
			for (int i = 0; i < context.Length("QueryDeviceServiceData.Data.List.Length"); i++) {
				QueryDeviceServiceDataResponse.QueryDeviceServiceData_Data.QueryDeviceServiceData_ServiceInfo serviceInfo = new QueryDeviceServiceDataResponse.QueryDeviceServiceData_Data.QueryDeviceServiceData_ServiceInfo();
				serviceInfo.Time = context.StringValue("QueryDeviceServiceData.Data.List["+ i +"].Time");
				serviceInfo.Identifier = context.StringValue("QueryDeviceServiceData.Data.List["+ i +"].Identifier");
				serviceInfo.Name = context.StringValue("QueryDeviceServiceData.Data.List["+ i +"].Name");
				serviceInfo.InputData = context.StringValue("QueryDeviceServiceData.Data.List["+ i +"].InputData");
				serviceInfo.OutputData = context.StringValue("QueryDeviceServiceData.Data.List["+ i +"].OutputData");

				data_list.Add(serviceInfo);
			}
			data.List = data_list;
			queryDeviceServiceDataResponse.Data = data;
        
			return queryDeviceServiceDataResponse;
        }
    }
}
