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
    public class QueryDeviceOriginalServiceDataResponseUnmarshaller
    {
        public static QueryDeviceOriginalServiceDataResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryDeviceOriginalServiceDataResponse queryDeviceOriginalServiceDataResponse = new QueryDeviceOriginalServiceDataResponse();

			queryDeviceOriginalServiceDataResponse.HttpResponse = _ctx.HttpResponse;
			queryDeviceOriginalServiceDataResponse.RequestId = _ctx.StringValue("QueryDeviceOriginalServiceData.RequestId");
			queryDeviceOriginalServiceDataResponse.Success = _ctx.BooleanValue("QueryDeviceOriginalServiceData.Success");
			queryDeviceOriginalServiceDataResponse.Code = _ctx.StringValue("QueryDeviceOriginalServiceData.Code");
			queryDeviceOriginalServiceDataResponse.ErrorMessage = _ctx.StringValue("QueryDeviceOriginalServiceData.ErrorMessage");

			QueryDeviceOriginalServiceDataResponse.QueryDeviceOriginalServiceData_Data data = new QueryDeviceOriginalServiceDataResponse.QueryDeviceOriginalServiceData_Data();
			data.NextPageToken = _ctx.StringValue("QueryDeviceOriginalServiceData.Data.NextPageToken");
			data.NextValid = _ctx.BooleanValue("QueryDeviceOriginalServiceData.Data.NextValid");

			List<QueryDeviceOriginalServiceDataResponse.QueryDeviceOriginalServiceData_Data.QueryDeviceOriginalServiceData_ServiceInfo> data_list = new List<QueryDeviceOriginalServiceDataResponse.QueryDeviceOriginalServiceData_Data.QueryDeviceOriginalServiceData_ServiceInfo>();
			for (int i = 0; i < _ctx.Length("QueryDeviceOriginalServiceData.Data.List.Length"); i++) {
				QueryDeviceOriginalServiceDataResponse.QueryDeviceOriginalServiceData_Data.QueryDeviceOriginalServiceData_ServiceInfo serviceInfo = new QueryDeviceOriginalServiceDataResponse.QueryDeviceOriginalServiceData_Data.QueryDeviceOriginalServiceData_ServiceInfo();
				serviceInfo.Time = _ctx.StringValue("QueryDeviceOriginalServiceData.Data.List["+ i +"].Time");
				serviceInfo.Identifier = _ctx.StringValue("QueryDeviceOriginalServiceData.Data.List["+ i +"].Identifier");
				serviceInfo.Name = _ctx.StringValue("QueryDeviceOriginalServiceData.Data.List["+ i +"].Name");
				serviceInfo.InputData = _ctx.StringValue("QueryDeviceOriginalServiceData.Data.List["+ i +"].InputData");
				serviceInfo.OutputData = _ctx.StringValue("QueryDeviceOriginalServiceData.Data.List["+ i +"].OutputData");

				data_list.Add(serviceInfo);
			}
			data.List = data_list;
			queryDeviceOriginalServiceDataResponse.Data = data;
        
			return queryDeviceOriginalServiceDataResponse;
        }
    }
}
