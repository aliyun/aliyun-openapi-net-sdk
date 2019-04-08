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
    public class QueryDeviceGroupByDeviceResponseUnmarshaller
    {
        public static QueryDeviceGroupByDeviceResponse Unmarshall(UnmarshallerContext context)
        {
			QueryDeviceGroupByDeviceResponse queryDeviceGroupByDeviceResponse = new QueryDeviceGroupByDeviceResponse();

			queryDeviceGroupByDeviceResponse.HttpResponse = context.HttpResponse;
			queryDeviceGroupByDeviceResponse.RequestId = context.StringValue("QueryDeviceGroupByDevice.RequestId");
			queryDeviceGroupByDeviceResponse.Success = context.BooleanValue("QueryDeviceGroupByDevice.Success");
			queryDeviceGroupByDeviceResponse.Code = context.StringValue("QueryDeviceGroupByDevice.Code");
			queryDeviceGroupByDeviceResponse.ErrorMessage = context.StringValue("QueryDeviceGroupByDevice.ErrorMessage");

			List<QueryDeviceGroupByDeviceResponse.QueryDeviceGroupByDevice_GroupInfo> queryDeviceGroupByDeviceResponse_groupInfos = new List<QueryDeviceGroupByDeviceResponse.QueryDeviceGroupByDevice_GroupInfo>();
			for (int i = 0; i < context.Length("QueryDeviceGroupByDevice.GroupInfos.Length"); i++) {
				QueryDeviceGroupByDeviceResponse.QueryDeviceGroupByDevice_GroupInfo groupInfo = new QueryDeviceGroupByDeviceResponse.QueryDeviceGroupByDevice_GroupInfo();
				groupInfo.GroupId = context.StringValue("QueryDeviceGroupByDevice.GroupInfos["+ i +"].GroupId");
				groupInfo.GroupName = context.StringValue("QueryDeviceGroupByDevice.GroupInfos["+ i +"].GroupName");
				groupInfo.UtcCreate = context.StringValue("QueryDeviceGroupByDevice.GroupInfos["+ i +"].UtcCreate");
				groupInfo.GroupDesc = context.StringValue("QueryDeviceGroupByDevice.GroupInfos["+ i +"].GroupDesc");

				queryDeviceGroupByDeviceResponse_groupInfos.Add(groupInfo);
			}
			queryDeviceGroupByDeviceResponse.GroupInfos = queryDeviceGroupByDeviceResponse_groupInfos;
        
			return queryDeviceGroupByDeviceResponse;
        }
    }
}
