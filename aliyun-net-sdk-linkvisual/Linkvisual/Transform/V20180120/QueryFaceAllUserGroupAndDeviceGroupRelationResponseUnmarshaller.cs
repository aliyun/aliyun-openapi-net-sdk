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
using Aliyun.Acs.Linkvisual.Model.V20180120;

namespace Aliyun.Acs.Linkvisual.Transform.V20180120
{
    public class QueryFaceAllUserGroupAndDeviceGroupRelationResponseUnmarshaller
    {
        public static QueryFaceAllUserGroupAndDeviceGroupRelationResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryFaceAllUserGroupAndDeviceGroupRelationResponse queryFaceAllUserGroupAndDeviceGroupRelationResponse = new QueryFaceAllUserGroupAndDeviceGroupRelationResponse();

			queryFaceAllUserGroupAndDeviceGroupRelationResponse.HttpResponse = _ctx.HttpResponse;
			queryFaceAllUserGroupAndDeviceGroupRelationResponse.Code = _ctx.StringValue("QueryFaceAllUserGroupAndDeviceGroupRelation.Code");
			queryFaceAllUserGroupAndDeviceGroupRelationResponse.RequestId = _ctx.StringValue("QueryFaceAllUserGroupAndDeviceGroupRelation.RequestId");
			queryFaceAllUserGroupAndDeviceGroupRelationResponse.ErrorMessage = _ctx.StringValue("QueryFaceAllUserGroupAndDeviceGroupRelation.ErrorMessage");
			queryFaceAllUserGroupAndDeviceGroupRelationResponse.Success = _ctx.BooleanValue("QueryFaceAllUserGroupAndDeviceGroupRelation.Success");

			QueryFaceAllUserGroupAndDeviceGroupRelationResponse.QueryFaceAllUserGroupAndDeviceGroupRelation_Data data = new QueryFaceAllUserGroupAndDeviceGroupRelationResponse.QueryFaceAllUserGroupAndDeviceGroupRelation_Data();
			data.PageSize = _ctx.IntegerValue("QueryFaceAllUserGroupAndDeviceGroupRelation.Data.PageSize");
			data.Total = _ctx.IntegerValue("QueryFaceAllUserGroupAndDeviceGroupRelation.Data.Total");
			data.Page = _ctx.IntegerValue("QueryFaceAllUserGroupAndDeviceGroupRelation.Data.Page");

			List<QueryFaceAllUserGroupAndDeviceGroupRelationResponse.QueryFaceAllUserGroupAndDeviceGroupRelation_Data.QueryFaceAllUserGroupAndDeviceGroupRelation_ListItem> data_list = new List<QueryFaceAllUserGroupAndDeviceGroupRelationResponse.QueryFaceAllUserGroupAndDeviceGroupRelation_Data.QueryFaceAllUserGroupAndDeviceGroupRelation_ListItem>();
			for (int i = 0; i < _ctx.Length("QueryFaceAllUserGroupAndDeviceGroupRelation.Data.List.Length"); i++) {
				QueryFaceAllUserGroupAndDeviceGroupRelationResponse.QueryFaceAllUserGroupAndDeviceGroupRelation_Data.QueryFaceAllUserGroupAndDeviceGroupRelation_ListItem listItem = new QueryFaceAllUserGroupAndDeviceGroupRelationResponse.QueryFaceAllUserGroupAndDeviceGroupRelation_Data.QueryFaceAllUserGroupAndDeviceGroupRelation_ListItem();
				listItem.DeviceGroupId = _ctx.StringValue("QueryFaceAllUserGroupAndDeviceGroupRelation.Data.List["+ i +"].DeviceGroupId");
				listItem.ControlId = _ctx.StringValue("QueryFaceAllUserGroupAndDeviceGroupRelation.Data.List["+ i +"].ControlId");
				listItem.ModifiedTime = _ctx.StringValue("QueryFaceAllUserGroupAndDeviceGroupRelation.Data.List["+ i +"].ModifiedTime");
				listItem.ControlType = _ctx.StringValue("QueryFaceAllUserGroupAndDeviceGroupRelation.Data.List["+ i +"].ControlType");
				listItem.UserGroupId = _ctx.StringValue("QueryFaceAllUserGroupAndDeviceGroupRelation.Data.List["+ i +"].UserGroupId");

				data_list.Add(listItem);
			}
			data.List = data_list;
			queryFaceAllUserGroupAndDeviceGroupRelationResponse.Data = data;
        
			return queryFaceAllUserGroupAndDeviceGroupRelationResponse;
        }
    }
}
