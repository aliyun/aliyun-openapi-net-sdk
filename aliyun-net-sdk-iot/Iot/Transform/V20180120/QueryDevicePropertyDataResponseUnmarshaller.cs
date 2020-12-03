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
    public class QueryDevicePropertyDataResponseUnmarshaller
    {
        public static QueryDevicePropertyDataResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryDevicePropertyDataResponse queryDevicePropertyDataResponse = new QueryDevicePropertyDataResponse();

			queryDevicePropertyDataResponse.HttpResponse = _ctx.HttpResponse;
			queryDevicePropertyDataResponse.RequestId = _ctx.StringValue("QueryDevicePropertyData.RequestId");
			queryDevicePropertyDataResponse.Success = _ctx.BooleanValue("QueryDevicePropertyData.Success");
			queryDevicePropertyDataResponse.Code = _ctx.StringValue("QueryDevicePropertyData.Code");
			queryDevicePropertyDataResponse.ErrorMessage = _ctx.StringValue("QueryDevicePropertyData.ErrorMessage");

			QueryDevicePropertyDataResponse.QueryDevicePropertyData_Data data = new QueryDevicePropertyDataResponse.QueryDevicePropertyData_Data();
			data.NextValid = _ctx.BooleanValue("QueryDevicePropertyData.Data.NextValid");
			data.NextTime = _ctx.LongValue("QueryDevicePropertyData.Data.NextTime");

			List<QueryDevicePropertyDataResponse.QueryDevicePropertyData_Data.QueryDevicePropertyData_PropertyInfo> data_list = new List<QueryDevicePropertyDataResponse.QueryDevicePropertyData_Data.QueryDevicePropertyData_PropertyInfo>();
			for (int i = 0; i < _ctx.Length("QueryDevicePropertyData.Data.List.Length"); i++) {
				QueryDevicePropertyDataResponse.QueryDevicePropertyData_Data.QueryDevicePropertyData_PropertyInfo propertyInfo = new QueryDevicePropertyDataResponse.QueryDevicePropertyData_Data.QueryDevicePropertyData_PropertyInfo();
				propertyInfo.Time = _ctx.StringValue("QueryDevicePropertyData.Data.List["+ i +"].Time");
				propertyInfo._Value = _ctx.StringValue("QueryDevicePropertyData.Data.List["+ i +"].Value");

				data_list.Add(propertyInfo);
			}
			data.List = data_list;
			queryDevicePropertyDataResponse.Data = data;
        
			return queryDevicePropertyDataResponse;
        }
    }
}
