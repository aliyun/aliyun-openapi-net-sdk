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
    public class QueryDevicePropertyStatusResponseUnmarshaller
    {
        public static QueryDevicePropertyStatusResponse Unmarshall(UnmarshallerContext context)
        {
			QueryDevicePropertyStatusResponse queryDevicePropertyStatusResponse = new QueryDevicePropertyStatusResponse();

			queryDevicePropertyStatusResponse.HttpResponse = context.HttpResponse;
			queryDevicePropertyStatusResponse.RequestId = context.StringValue("QueryDevicePropertyStatus.RequestId");
			queryDevicePropertyStatusResponse.Success = context.BooleanValue("QueryDevicePropertyStatus.Success");
			queryDevicePropertyStatusResponse.Code = context.StringValue("QueryDevicePropertyStatus.Code");
			queryDevicePropertyStatusResponse.ErrorMessage = context.StringValue("QueryDevicePropertyStatus.ErrorMessage");

			QueryDevicePropertyStatusResponse.QueryDevicePropertyStatus_Data data = new QueryDevicePropertyStatusResponse.QueryDevicePropertyStatus_Data();

			List<QueryDevicePropertyStatusResponse.QueryDevicePropertyStatus_Data.QueryDevicePropertyStatus_PropertyStatusInfo> data_list = new List<QueryDevicePropertyStatusResponse.QueryDevicePropertyStatus_Data.QueryDevicePropertyStatus_PropertyStatusInfo>();
			for (int i = 0; i < context.Length("QueryDevicePropertyStatus.Data.List.Length"); i++) {
				QueryDevicePropertyStatusResponse.QueryDevicePropertyStatus_Data.QueryDevicePropertyStatus_PropertyStatusInfo propertyStatusInfo = new QueryDevicePropertyStatusResponse.QueryDevicePropertyStatus_Data.QueryDevicePropertyStatus_PropertyStatusInfo();
				propertyStatusInfo.Unit = context.StringValue("QueryDevicePropertyStatus.Data.List["+ i +"].Unit");
				propertyStatusInfo.Identifier = context.StringValue("QueryDevicePropertyStatus.Data.List["+ i +"].Identifier");
				propertyStatusInfo.DataType = context.StringValue("QueryDevicePropertyStatus.Data.List["+ i +"].DataType");
				propertyStatusInfo.Time = context.StringValue("QueryDevicePropertyStatus.Data.List["+ i +"].Time");
				propertyStatusInfo._Value = context.StringValue("QueryDevicePropertyStatus.Data.List["+ i +"].Value");
				propertyStatusInfo.Name = context.StringValue("QueryDevicePropertyStatus.Data.List["+ i +"].Name");

				data_list.Add(propertyStatusInfo);
			}
			data.List = data_list;
			queryDevicePropertyStatusResponse.Data = data;
        
			return queryDevicePropertyStatusResponse;
        }
    }
}
