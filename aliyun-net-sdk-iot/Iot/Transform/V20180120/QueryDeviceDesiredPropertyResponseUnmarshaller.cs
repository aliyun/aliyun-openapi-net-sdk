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
        public static QueryDeviceDesiredPropertyResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryDeviceDesiredPropertyResponse queryDeviceDesiredPropertyResponse = new QueryDeviceDesiredPropertyResponse();

			queryDeviceDesiredPropertyResponse.HttpResponse = _ctx.HttpResponse;
			queryDeviceDesiredPropertyResponse.RequestId = _ctx.StringValue("QueryDeviceDesiredProperty.RequestId");
			queryDeviceDesiredPropertyResponse.Success = _ctx.BooleanValue("QueryDeviceDesiredProperty.Success");
			queryDeviceDesiredPropertyResponse.Code = _ctx.StringValue("QueryDeviceDesiredProperty.Code");
			queryDeviceDesiredPropertyResponse.ErrorMessage = _ctx.StringValue("QueryDeviceDesiredProperty.ErrorMessage");

			QueryDeviceDesiredPropertyResponse.QueryDeviceDesiredProperty_Data data = new QueryDeviceDesiredPropertyResponse.QueryDeviceDesiredProperty_Data();

			List<QueryDeviceDesiredPropertyResponse.QueryDeviceDesiredProperty_Data.QueryDeviceDesiredProperty_DesiredPropertyInfo> data_list = new List<QueryDeviceDesiredPropertyResponse.QueryDeviceDesiredProperty_Data.QueryDeviceDesiredProperty_DesiredPropertyInfo>();
			for (int i = 0; i < _ctx.Length("QueryDeviceDesiredProperty.Data.List.Length"); i++) {
				QueryDeviceDesiredPropertyResponse.QueryDeviceDesiredProperty_Data.QueryDeviceDesiredProperty_DesiredPropertyInfo desiredPropertyInfo = new QueryDeviceDesiredPropertyResponse.QueryDeviceDesiredProperty_Data.QueryDeviceDesiredProperty_DesiredPropertyInfo();
				desiredPropertyInfo.Unit = _ctx.StringValue("QueryDeviceDesiredProperty.Data.List["+ i +"].Unit");
				desiredPropertyInfo.Identifier = _ctx.StringValue("QueryDeviceDesiredProperty.Data.List["+ i +"].Identifier");
				desiredPropertyInfo.DataType = _ctx.StringValue("QueryDeviceDesiredProperty.Data.List["+ i +"].DataType");
				desiredPropertyInfo.Time = _ctx.StringValue("QueryDeviceDesiredProperty.Data.List["+ i +"].Time");
				desiredPropertyInfo._Value = _ctx.StringValue("QueryDeviceDesiredProperty.Data.List["+ i +"].Value");
				desiredPropertyInfo.Name = _ctx.StringValue("QueryDeviceDesiredProperty.Data.List["+ i +"].Name");
				desiredPropertyInfo.Version = _ctx.LongValue("QueryDeviceDesiredProperty.Data.List["+ i +"].Version");

				data_list.Add(desiredPropertyInfo);
			}
			data.List = data_list;
			queryDeviceDesiredPropertyResponse.Data = data;
        
			return queryDeviceDesiredPropertyResponse;
        }
    }
}
