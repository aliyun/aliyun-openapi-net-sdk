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
    public class QueryDeviceDesiredPropertyResponseUnmarshaller
    {
        public static QueryDeviceDesiredPropertyResponse Unmarshall(UnmarshallerContext context)
        {
			QueryDeviceDesiredPropertyResponse queryDeviceDesiredPropertyResponse = new QueryDeviceDesiredPropertyResponse();

			queryDeviceDesiredPropertyResponse.HttpResponse = context.HttpResponse;
			queryDeviceDesiredPropertyResponse.RequestId = context.StringValue("QueryDeviceDesiredProperty.RequestId");
			queryDeviceDesiredPropertyResponse.Success = context.BooleanValue("QueryDeviceDesiredProperty.Success");
			queryDeviceDesiredPropertyResponse.Code = context.StringValue("QueryDeviceDesiredProperty.Code");
			queryDeviceDesiredPropertyResponse.ErrorMessage = context.StringValue("QueryDeviceDesiredProperty.ErrorMessage");

			QueryDeviceDesiredPropertyResponse.QueryDeviceDesiredProperty_Data data = new QueryDeviceDesiredPropertyResponse.QueryDeviceDesiredProperty_Data();

			List<QueryDeviceDesiredPropertyResponse.QueryDeviceDesiredProperty_Data.QueryDeviceDesiredProperty_DesiredPropertyInfo> data_list = new List<QueryDeviceDesiredPropertyResponse.QueryDeviceDesiredProperty_Data.QueryDeviceDesiredProperty_DesiredPropertyInfo>();
			for (int i = 0; i < context.Length("QueryDeviceDesiredProperty.Data.List.Length"); i++) {
				QueryDeviceDesiredPropertyResponse.QueryDeviceDesiredProperty_Data.QueryDeviceDesiredProperty_DesiredPropertyInfo desiredPropertyInfo = new QueryDeviceDesiredPropertyResponse.QueryDeviceDesiredProperty_Data.QueryDeviceDesiredProperty_DesiredPropertyInfo();
				desiredPropertyInfo.Unit = context.StringValue("QueryDeviceDesiredProperty.Data.List["+ i +"].Unit");
				desiredPropertyInfo.Identifier = context.StringValue("QueryDeviceDesiredProperty.Data.List["+ i +"].Identifier");
				desiredPropertyInfo.DataType = context.StringValue("QueryDeviceDesiredProperty.Data.List["+ i +"].DataType");
				desiredPropertyInfo.Time = context.StringValue("QueryDeviceDesiredProperty.Data.List["+ i +"].Time");
				desiredPropertyInfo._Value = context.StringValue("QueryDeviceDesiredProperty.Data.List["+ i +"].Value");
				desiredPropertyInfo.Name = context.StringValue("QueryDeviceDesiredProperty.Data.List["+ i +"].Name");
				desiredPropertyInfo.Version = context.LongValue("QueryDeviceDesiredProperty.Data.List["+ i +"].Version");

				data_list.Add(desiredPropertyInfo);
			}
			data.List = data_list;
			queryDeviceDesiredPropertyResponse.Data = data;
        
			return queryDeviceDesiredPropertyResponse;
        }
    }
}
