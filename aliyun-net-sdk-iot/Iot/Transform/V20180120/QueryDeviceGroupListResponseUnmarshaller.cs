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
        public static QueryDeviceGroupListResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryDeviceGroupListResponse queryDeviceGroupListResponse = new QueryDeviceGroupListResponse();

			queryDeviceGroupListResponse.HttpResponse = _ctx.HttpResponse;
			queryDeviceGroupListResponse.RequestId = _ctx.StringValue("QueryDeviceGroupList.RequestId");
			queryDeviceGroupListResponse.Success = _ctx.BooleanValue("QueryDeviceGroupList.Success");
			queryDeviceGroupListResponse.Code = _ctx.StringValue("QueryDeviceGroupList.Code");
			queryDeviceGroupListResponse.ErrorMessage = _ctx.StringValue("QueryDeviceGroupList.ErrorMessage");
			queryDeviceGroupListResponse.CurrentPage = _ctx.IntegerValue("QueryDeviceGroupList.CurrentPage");
			queryDeviceGroupListResponse.PageCount = _ctx.IntegerValue("QueryDeviceGroupList.PageCount");
			queryDeviceGroupListResponse.PageSize = _ctx.IntegerValue("QueryDeviceGroupList.PageSize");
			queryDeviceGroupListResponse.Total = _ctx.IntegerValue("QueryDeviceGroupList.Total");

			List<QueryDeviceGroupListResponse.QueryDeviceGroupList_GroupInfo> queryDeviceGroupListResponse_data = new List<QueryDeviceGroupListResponse.QueryDeviceGroupList_GroupInfo>();
			for (int i = 0; i < _ctx.Length("QueryDeviceGroupList.Data.Length"); i++) {
				QueryDeviceGroupListResponse.QueryDeviceGroupList_GroupInfo groupInfo = new QueryDeviceGroupListResponse.QueryDeviceGroupList_GroupInfo();
				groupInfo.GroupId = _ctx.StringValue("QueryDeviceGroupList.Data["+ i +"].GroupId");
				groupInfo.UtcCreate = _ctx.StringValue("QueryDeviceGroupList.Data["+ i +"].UtcCreate");
				groupInfo.GroupName = _ctx.StringValue("QueryDeviceGroupList.Data["+ i +"].GroupName");
				groupInfo.GroupDesc = _ctx.StringValue("QueryDeviceGroupList.Data["+ i +"].GroupDesc");
				groupInfo.GroupType = _ctx.StringValue("QueryDeviceGroupList.Data["+ i +"].GroupType");

				queryDeviceGroupListResponse_data.Add(groupInfo);
			}
			queryDeviceGroupListResponse.Data = queryDeviceGroupListResponse_data;
        
			return queryDeviceGroupListResponse;
        }
    }
}
