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
using Aliyun.Acs.Ims.Model.V20190815;

namespace Aliyun.Acs.Ims.Transform.V20190815
{
    public class CreateGroupResponseUnmarshaller
    {
        public static CreateGroupResponse Unmarshall(UnmarshallerContext _ctx)
        {
			CreateGroupResponse createGroupResponse = new CreateGroupResponse();

			createGroupResponse.HttpResponse = _ctx.HttpResponse;
			createGroupResponse.RequestId = _ctx.StringValue("CreateGroup.RequestId");

			CreateGroupResponse.CreateGroup_Group group = new CreateGroupResponse.CreateGroup_Group();
			group.DisplayName = _ctx.StringValue("CreateGroup.Group.DisplayName");
			group.GroupPrincipalName = _ctx.StringValue("CreateGroup.Group.GroupPrincipalName");
			group.GroupId = _ctx.StringValue("CreateGroup.Group.GroupId");
			group.UpdateDate = _ctx.StringValue("CreateGroup.Group.UpdateDate");
			group.GroupName = _ctx.StringValue("CreateGroup.Group.GroupName");
			group.Comments = _ctx.StringValue("CreateGroup.Group.Comments");
			group.CreateDate = _ctx.StringValue("CreateGroup.Group.CreateDate");
			createGroupResponse.Group = group;
        
			return createGroupResponse;
        }
    }
}
