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
using Aliyun.Acs.dataworks_public.Model.V20200518;

namespace Aliyun.Acs.dataworks_public.Transform.V20200518
{
    public class GetDataServiceGroupResponseUnmarshaller
    {
        public static GetDataServiceGroupResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetDataServiceGroupResponse getDataServiceGroupResponse = new GetDataServiceGroupResponse();

			getDataServiceGroupResponse.HttpResponse = _ctx.HttpResponse;
			getDataServiceGroupResponse.RequestId = _ctx.StringValue("GetDataServiceGroup.RequestId");

			GetDataServiceGroupResponse.GetDataServiceGroup_Group group = new GetDataServiceGroupResponse.GetDataServiceGroup_Group();
			group.TenantId = _ctx.LongValue("GetDataServiceGroup.Group.TenantId");
			group.ProjectId = _ctx.LongValue("GetDataServiceGroup.Group.ProjectId");
			group.GroupId = _ctx.StringValue("GetDataServiceGroup.Group.GroupId");
			group.ApiGatewayGroupId = _ctx.StringValue("GetDataServiceGroup.Group.ApiGatewayGroupId");
			group.GroupName = _ctx.StringValue("GetDataServiceGroup.Group.GroupName");
			group.Description = _ctx.StringValue("GetDataServiceGroup.Group.Description");
			group.CreatedTime = _ctx.StringValue("GetDataServiceGroup.Group.CreatedTime");
			group.ModifiedTime = _ctx.StringValue("GetDataServiceGroup.Group.ModifiedTime");
			group.CreatorId = _ctx.StringValue("GetDataServiceGroup.Group.CreatorId");
			getDataServiceGroupResponse.Group = group;
        
			return getDataServiceGroupResponse;
        }
    }
}
