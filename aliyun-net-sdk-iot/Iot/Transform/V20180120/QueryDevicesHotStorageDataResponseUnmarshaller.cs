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
    public class QueryDevicesHotStorageDataResponseUnmarshaller
    {
        public static QueryDevicesHotStorageDataResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryDevicesHotStorageDataResponse queryDevicesHotStorageDataResponse = new QueryDevicesHotStorageDataResponse();

			queryDevicesHotStorageDataResponse.HttpResponse = _ctx.HttpResponse;
			queryDevicesHotStorageDataResponse.RequestId = _ctx.StringValue("QueryDevicesHotStorageData.RequestId");
			queryDevicesHotStorageDataResponse.Success = _ctx.BooleanValue("QueryDevicesHotStorageData.Success");
			queryDevicesHotStorageDataResponse.Code = _ctx.StringValue("QueryDevicesHotStorageData.Code");
			queryDevicesHotStorageDataResponse.ErrorMessage = _ctx.StringValue("QueryDevicesHotStorageData.ErrorMessage");

			QueryDevicesHotStorageDataResponse.QueryDevicesHotStorageData_Data data = new QueryDevicesHotStorageDataResponse.QueryDevicesHotStorageData_Data();
			data.NextValid = _ctx.BooleanValue("QueryDevicesHotStorageData.Data.NextValid");
			data.NextPageToken = _ctx.StringValue("QueryDevicesHotStorageData.Data.nextPageToken");

			List<QueryDevicesHotStorageDataResponse.QueryDevicesHotStorageData_Data.QueryDevicesHotStorageData_PropertyInfo> data_list = new List<QueryDevicesHotStorageDataResponse.QueryDevicesHotStorageData_Data.QueryDevicesHotStorageData_PropertyInfo>();
			for (int i = 0; i < _ctx.Length("QueryDevicesHotStorageData.Data.List.Length"); i++) {
				QueryDevicesHotStorageDataResponse.QueryDevicesHotStorageData_Data.QueryDevicesHotStorageData_PropertyInfo propertyInfo = new QueryDevicesHotStorageDataResponse.QueryDevicesHotStorageData_Data.QueryDevicesHotStorageData_PropertyInfo();
				propertyInfo.Time = _ctx.StringValue("QueryDevicesHotStorageData.Data.List["+ i +"].Time");
				propertyInfo._Value = _ctx.StringValue("QueryDevicesHotStorageData.Data.List["+ i +"].Value");

				data_list.Add(propertyInfo);
			}
			data.List = data_list;
			queryDevicesHotStorageDataResponse.Data = data;
        
			return queryDevicesHotStorageDataResponse;
        }
    }
}
