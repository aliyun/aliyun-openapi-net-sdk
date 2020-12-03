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
    public class QueryDevicePropertiesDataResponseUnmarshaller
    {
        public static QueryDevicePropertiesDataResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryDevicePropertiesDataResponse queryDevicePropertiesDataResponse = new QueryDevicePropertiesDataResponse();

			queryDevicePropertiesDataResponse.HttpResponse = _ctx.HttpResponse;
			queryDevicePropertiesDataResponse.RequestId = _ctx.StringValue("QueryDevicePropertiesData.RequestId");
			queryDevicePropertiesDataResponse.Success = _ctx.BooleanValue("QueryDevicePropertiesData.Success");
			queryDevicePropertiesDataResponse.Code = _ctx.StringValue("QueryDevicePropertiesData.Code");
			queryDevicePropertiesDataResponse.ErrorMessage = _ctx.StringValue("QueryDevicePropertiesData.ErrorMessage");
			queryDevicePropertiesDataResponse.NextValid = _ctx.BooleanValue("QueryDevicePropertiesData.NextValid");
			queryDevicePropertiesDataResponse.NextTime = _ctx.LongValue("QueryDevicePropertiesData.NextTime");

			List<QueryDevicePropertiesDataResponse.QueryDevicePropertiesData_PropertyDataInfo> queryDevicePropertiesDataResponse_propertyDataInfos = new List<QueryDevicePropertiesDataResponse.QueryDevicePropertiesData_PropertyDataInfo>();
			for (int i = 0; i < _ctx.Length("QueryDevicePropertiesData.PropertyDataInfos.Length"); i++) {
				QueryDevicePropertiesDataResponse.QueryDevicePropertiesData_PropertyDataInfo propertyDataInfo = new QueryDevicePropertiesDataResponse.QueryDevicePropertiesData_PropertyDataInfo();
				propertyDataInfo.Identifier = _ctx.StringValue("QueryDevicePropertiesData.PropertyDataInfos["+ i +"].Identifier");

				List<QueryDevicePropertiesDataResponse.QueryDevicePropertiesData_PropertyDataInfo.QueryDevicePropertiesData_PropertyInfo> propertyDataInfo_list = new List<QueryDevicePropertiesDataResponse.QueryDevicePropertiesData_PropertyDataInfo.QueryDevicePropertiesData_PropertyInfo>();
				for (int j = 0; j < _ctx.Length("QueryDevicePropertiesData.PropertyDataInfos["+ i +"].List.Length"); j++) {
					QueryDevicePropertiesDataResponse.QueryDevicePropertiesData_PropertyDataInfo.QueryDevicePropertiesData_PropertyInfo propertyInfo = new QueryDevicePropertiesDataResponse.QueryDevicePropertiesData_PropertyDataInfo.QueryDevicePropertiesData_PropertyInfo();
					propertyInfo.Time = _ctx.LongValue("QueryDevicePropertiesData.PropertyDataInfos["+ i +"].List["+ j +"].Time");
					propertyInfo._Value = _ctx.StringValue("QueryDevicePropertiesData.PropertyDataInfos["+ i +"].List["+ j +"].Value");

					propertyDataInfo_list.Add(propertyInfo);
				}
				propertyDataInfo.List = propertyDataInfo_list;

				queryDevicePropertiesDataResponse_propertyDataInfos.Add(propertyDataInfo);
			}
			queryDevicePropertiesDataResponse.PropertyDataInfos = queryDevicePropertiesDataResponse_propertyDataInfos;
        
			return queryDevicePropertiesDataResponse;
        }
    }
}
