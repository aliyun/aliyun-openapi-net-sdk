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
    public class QueryDeviceOriginalPropertyDataResponseUnmarshaller
    {
        public static QueryDeviceOriginalPropertyDataResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryDeviceOriginalPropertyDataResponse queryDeviceOriginalPropertyDataResponse = new QueryDeviceOriginalPropertyDataResponse();

			queryDeviceOriginalPropertyDataResponse.HttpResponse = _ctx.HttpResponse;
			queryDeviceOriginalPropertyDataResponse.RequestId = _ctx.StringValue("QueryDeviceOriginalPropertyData.RequestId");
			queryDeviceOriginalPropertyDataResponse.Success = _ctx.BooleanValue("QueryDeviceOriginalPropertyData.Success");
			queryDeviceOriginalPropertyDataResponse.Code = _ctx.StringValue("QueryDeviceOriginalPropertyData.Code");
			queryDeviceOriginalPropertyDataResponse.ErrorMessage = _ctx.StringValue("QueryDeviceOriginalPropertyData.ErrorMessage");

			QueryDeviceOriginalPropertyDataResponse.QueryDeviceOriginalPropertyData_Data data = new QueryDeviceOriginalPropertyDataResponse.QueryDeviceOriginalPropertyData_Data();
			data.NextValid = _ctx.BooleanValue("QueryDeviceOriginalPropertyData.Data.NextValid");
			data.NextPageToken = _ctx.StringValue("QueryDeviceOriginalPropertyData.Data.nextPageToken");

			List<QueryDeviceOriginalPropertyDataResponse.QueryDeviceOriginalPropertyData_Data.QueryDeviceOriginalPropertyData_PropertyInfo> data_list = new List<QueryDeviceOriginalPropertyDataResponse.QueryDeviceOriginalPropertyData_Data.QueryDeviceOriginalPropertyData_PropertyInfo>();
			for (int i = 0; i < _ctx.Length("QueryDeviceOriginalPropertyData.Data.List.Length"); i++) {
				QueryDeviceOriginalPropertyDataResponse.QueryDeviceOriginalPropertyData_Data.QueryDeviceOriginalPropertyData_PropertyInfo propertyInfo = new QueryDeviceOriginalPropertyDataResponse.QueryDeviceOriginalPropertyData_Data.QueryDeviceOriginalPropertyData_PropertyInfo();
				propertyInfo.Time = _ctx.StringValue("QueryDeviceOriginalPropertyData.Data.List["+ i +"].Time");
				propertyInfo._Value = _ctx.StringValue("QueryDeviceOriginalPropertyData.Data.List["+ i +"].Value");

				data_list.Add(propertyInfo);
			}
			data.List = data_list;
			queryDeviceOriginalPropertyDataResponse.Data = data;
        
			return queryDeviceOriginalPropertyDataResponse;
        }
    }
}
