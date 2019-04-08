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
    public class QueryDeviceListByDeviceGroupResponseUnmarshaller
    {
        public static QueryDeviceListByDeviceGroupResponse Unmarshall(UnmarshallerContext context)
        {
			QueryDeviceListByDeviceGroupResponse queryDeviceListByDeviceGroupResponse = new QueryDeviceListByDeviceGroupResponse();

			queryDeviceListByDeviceGroupResponse.HttpResponse = context.HttpResponse;
			queryDeviceListByDeviceGroupResponse.RequestId = context.StringValue("QueryDeviceListByDeviceGroup.RequestId");
			queryDeviceListByDeviceGroupResponse.Success = context.BooleanValue("QueryDeviceListByDeviceGroup.Success");
			queryDeviceListByDeviceGroupResponse.Code = context.StringValue("QueryDeviceListByDeviceGroup.Code");
			queryDeviceListByDeviceGroupResponse.ErrorMessage = context.StringValue("QueryDeviceListByDeviceGroup.ErrorMessage");
			queryDeviceListByDeviceGroupResponse.Page = context.IntegerValue("QueryDeviceListByDeviceGroup.Page");
			queryDeviceListByDeviceGroupResponse.PageSize = context.IntegerValue("QueryDeviceListByDeviceGroup.PageSize");
			queryDeviceListByDeviceGroupResponse.PageCount = context.IntegerValue("QueryDeviceListByDeviceGroup.PageCount");
			queryDeviceListByDeviceGroupResponse.Total = context.IntegerValue("QueryDeviceListByDeviceGroup.Total");

			List<QueryDeviceListByDeviceGroupResponse.QueryDeviceListByDeviceGroup_SimpleDeviceInfo> queryDeviceListByDeviceGroupResponse_data = new List<QueryDeviceListByDeviceGroupResponse.QueryDeviceListByDeviceGroup_SimpleDeviceInfo>();
			for (int i = 0; i < context.Length("QueryDeviceListByDeviceGroup.Data.Length"); i++) {
				QueryDeviceListByDeviceGroupResponse.QueryDeviceListByDeviceGroup_SimpleDeviceInfo simpleDeviceInfo = new QueryDeviceListByDeviceGroupResponse.QueryDeviceListByDeviceGroup_SimpleDeviceInfo();
				simpleDeviceInfo.ProductName = context.StringValue("QueryDeviceListByDeviceGroup.Data["+ i +"].ProductName");
				simpleDeviceInfo.ProductKey = context.StringValue("QueryDeviceListByDeviceGroup.Data["+ i +"].ProductKey");
				simpleDeviceInfo.DeviceName = context.StringValue("QueryDeviceListByDeviceGroup.Data["+ i +"].DeviceName");
				simpleDeviceInfo.IotId = context.StringValue("QueryDeviceListByDeviceGroup.Data["+ i +"].IotId");

				queryDeviceListByDeviceGroupResponse_data.Add(simpleDeviceInfo);
			}
			queryDeviceListByDeviceGroupResponse.Data = queryDeviceListByDeviceGroupResponse_data;
        
			return queryDeviceListByDeviceGroupResponse;
        }
    }
}
