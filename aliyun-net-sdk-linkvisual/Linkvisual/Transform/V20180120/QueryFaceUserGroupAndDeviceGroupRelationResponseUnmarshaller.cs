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
    public class QueryFaceUserGroupAndDeviceGroupRelationResponseUnmarshaller
    {
        public static QueryFaceUserGroupAndDeviceGroupRelationResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryFaceUserGroupAndDeviceGroupRelationResponse queryFaceUserGroupAndDeviceGroupRelationResponse = new QueryFaceUserGroupAndDeviceGroupRelationResponse();

			queryFaceUserGroupAndDeviceGroupRelationResponse.HttpResponse = _ctx.HttpResponse;
			queryFaceUserGroupAndDeviceGroupRelationResponse.Code = _ctx.StringValue("QueryFaceUserGroupAndDeviceGroupRelation.Code");
			queryFaceUserGroupAndDeviceGroupRelationResponse.RequestId = _ctx.StringValue("QueryFaceUserGroupAndDeviceGroupRelation.RequestId");
			queryFaceUserGroupAndDeviceGroupRelationResponse.ErrorMessage = _ctx.StringValue("QueryFaceUserGroupAndDeviceGroupRelation.ErrorMessage");
			queryFaceUserGroupAndDeviceGroupRelationResponse.Success = _ctx.BooleanValue("QueryFaceUserGroupAndDeviceGroupRelation.Success");

			QueryFaceUserGroupAndDeviceGroupRelationResponse.QueryFaceUserGroupAndDeviceGroupRelation_Data data = new QueryFaceUserGroupAndDeviceGroupRelationResponse.QueryFaceUserGroupAndDeviceGroupRelation_Data();
			data.DeviceGroupId = _ctx.StringValue("QueryFaceUserGroupAndDeviceGroupRelation.Data.DeviceGroupId");
			data.ControlId = _ctx.StringValue("QueryFaceUserGroupAndDeviceGroupRelation.Data.ControlId");
			data.ModifiedTime = _ctx.StringValue("QueryFaceUserGroupAndDeviceGroupRelation.Data.ModifiedTime");
			data.ControlType = _ctx.StringValue("QueryFaceUserGroupAndDeviceGroupRelation.Data.ControlType");
			data.UserGroupId = _ctx.StringValue("QueryFaceUserGroupAndDeviceGroupRelation.Data.UserGroupId");
			queryFaceUserGroupAndDeviceGroupRelationResponse.Data = data;
        
			return queryFaceUserGroupAndDeviceGroupRelationResponse;
        }
    }
}
