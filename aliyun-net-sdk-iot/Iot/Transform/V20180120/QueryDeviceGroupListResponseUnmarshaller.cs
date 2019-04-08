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
    public class QueryDeviceGroupListResponseUnmarshaller
    {
        public static QueryDeviceGroupListResponse Unmarshall(UnmarshallerContext context)
        {
			QueryDeviceGroupListResponse queryDeviceGroupListResponse = new QueryDeviceGroupListResponse();

			queryDeviceGroupListResponse.HttpResponse = context.HttpResponse;
			queryDeviceGroupListResponse.RequestId = context.StringValue("QueryDeviceGroupList.RequestId");
			queryDeviceGroupListResponse.Success = context.BooleanValue("QueryDeviceGroupList.Success");
			queryDeviceGroupListResponse.Code = context.StringValue("QueryDeviceGroupList.Code");
			queryDeviceGroupListResponse.ErrorMessage = context.StringValue("QueryDeviceGroupList.ErrorMessage");
			queryDeviceGroupListResponse.CurrentPage = context.IntegerValue("QueryDeviceGroupList.CurrentPage");
			queryDeviceGroupListResponse.PageCount = context.IntegerValue("QueryDeviceGroupList.PageCount");
			queryDeviceGroupListResponse.PageSize = context.IntegerValue("QueryDeviceGroupList.PageSize");
			queryDeviceGroupListResponse.Total = context.IntegerValue("QueryDeviceGroupList.Total");

			List<QueryDeviceGroupListResponse.QueryDeviceGroupList_GroupInfo> queryDeviceGroupListResponse_data = new List<QueryDeviceGroupListResponse.QueryDeviceGroupList_GroupInfo>();
			for (int i = 0; i < context.Length("QueryDeviceGroupList.Data.Length"); i++) {
				QueryDeviceGroupListResponse.QueryDeviceGroupList_GroupInfo groupInfo = new QueryDeviceGroupListResponse.QueryDeviceGroupList_GroupInfo();
				groupInfo.GroupId = context.StringValue("QueryDeviceGroupList.Data["+ i +"].GroupId");
				groupInfo.UtcCreate = context.StringValue("QueryDeviceGroupList.Data["+ i +"].UtcCreate");
				groupInfo.GroupName = context.StringValue("QueryDeviceGroupList.Data["+ i +"].GroupName");
				groupInfo.GroupDesc = context.StringValue("QueryDeviceGroupList.Data["+ i +"].GroupDesc");

				queryDeviceGroupListResponse_data.Add(groupInfo);
			}
			queryDeviceGroupListResponse.Data = queryDeviceGroupListResponse_data;
        
			return queryDeviceGroupListResponse;
        }
    }
}
