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
    public class QueryDynamicGroupDevicesResponseUnmarshaller
    {
        public static QueryDynamicGroupDevicesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryDynamicGroupDevicesResponse queryDynamicGroupDevicesResponse = new QueryDynamicGroupDevicesResponse();

			queryDynamicGroupDevicesResponse.HttpResponse = _ctx.HttpResponse;
			queryDynamicGroupDevicesResponse.RequestId = _ctx.StringValue("QueryDynamicGroupDevices.RequestId");
			queryDynamicGroupDevicesResponse.Success = _ctx.BooleanValue("QueryDynamicGroupDevices.Success");
			queryDynamicGroupDevicesResponse.Code = _ctx.StringValue("QueryDynamicGroupDevices.Code");
			queryDynamicGroupDevicesResponse.ErrorMessage = _ctx.StringValue("QueryDynamicGroupDevices.ErrorMessage");
			queryDynamicGroupDevicesResponse.Page = _ctx.IntegerValue("QueryDynamicGroupDevices.Page");
			queryDynamicGroupDevicesResponse.PageSize = _ctx.IntegerValue("QueryDynamicGroupDevices.PageSize");
			queryDynamicGroupDevicesResponse.PageCount = _ctx.IntegerValue("QueryDynamicGroupDevices.PageCount");
			queryDynamicGroupDevicesResponse.Total = _ctx.IntegerValue("QueryDynamicGroupDevices.Total");
			queryDynamicGroupDevicesResponse.NextToken = _ctx.StringValue("QueryDynamicGroupDevices.NextToken");

			List<QueryDynamicGroupDevicesResponse.QueryDynamicGroupDevices_SimpleDeviceInfo> queryDynamicGroupDevicesResponse_data = new List<QueryDynamicGroupDevicesResponse.QueryDynamicGroupDevices_SimpleDeviceInfo>();
			for (int i = 0; i < _ctx.Length("QueryDynamicGroupDevices.Data.Length"); i++) {
				QueryDynamicGroupDevicesResponse.QueryDynamicGroupDevices_SimpleDeviceInfo simpleDeviceInfo = new QueryDynamicGroupDevicesResponse.QueryDynamicGroupDevices_SimpleDeviceInfo();
				simpleDeviceInfo.ProductName = _ctx.StringValue("QueryDynamicGroupDevices.Data["+ i +"].ProductName");
				simpleDeviceInfo.ProductKey = _ctx.StringValue("QueryDynamicGroupDevices.Data["+ i +"].ProductKey");
				simpleDeviceInfo.DeviceName = _ctx.StringValue("QueryDynamicGroupDevices.Data["+ i +"].DeviceName");
				simpleDeviceInfo.CategoryKey = _ctx.StringValue("QueryDynamicGroupDevices.Data["+ i +"].CategoryKey");
				simpleDeviceInfo.NodeType = _ctx.IntegerValue("QueryDynamicGroupDevices.Data["+ i +"].NodeType");
				simpleDeviceInfo.Status = _ctx.StringValue("QueryDynamicGroupDevices.Data["+ i +"].Status");
				simpleDeviceInfo.IotId = _ctx.StringValue("QueryDynamicGroupDevices.Data["+ i +"].IotId");
				simpleDeviceInfo.ActiveTime = _ctx.StringValue("QueryDynamicGroupDevices.Data["+ i +"].ActiveTime");
				simpleDeviceInfo.UtcActiveTime = _ctx.StringValue("QueryDynamicGroupDevices.Data["+ i +"].UtcActiveTime");
				simpleDeviceInfo.LastOnlineTime = _ctx.StringValue("QueryDynamicGroupDevices.Data["+ i +"].LastOnlineTime");
				simpleDeviceInfo.UtcLastOnlineTime = _ctx.StringValue("QueryDynamicGroupDevices.Data["+ i +"].UtcLastOnlineTime");
				simpleDeviceInfo.Nickname = _ctx.StringValue("QueryDynamicGroupDevices.Data["+ i +"].Nickname");

				queryDynamicGroupDevicesResponse_data.Add(simpleDeviceInfo);
			}
			queryDynamicGroupDevicesResponse.Data = queryDynamicGroupDevicesResponse_data;
        
			return queryDynamicGroupDevicesResponse;
        }
    }
}
