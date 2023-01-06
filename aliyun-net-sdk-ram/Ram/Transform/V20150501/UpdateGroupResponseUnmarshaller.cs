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
using Aliyun.Acs.Ram.Model.V20150501;

namespace Aliyun.Acs.Ram.Transform.V20150501
{
    public class UpdateGroupResponseUnmarshaller
    {
        public static UpdateGroupResponse Unmarshall(UnmarshallerContext _ctx)
        {
			UpdateGroupResponse updateGroupResponse = new UpdateGroupResponse();

			updateGroupResponse.HttpResponse = _ctx.HttpResponse;
			updateGroupResponse.RequestId = _ctx.StringValue("UpdateGroup.RequestId");

			UpdateGroupResponse.UpdateGroup_Group group = new UpdateGroupResponse.UpdateGroup_Group();
			group.GroupId = _ctx.StringValue("UpdateGroup.Group.GroupId");
			group.UpdateDate = _ctx.StringValue("UpdateGroup.Group.UpdateDate");
			group.GroupName = _ctx.StringValue("UpdateGroup.Group.GroupName");
			group.Comments = _ctx.StringValue("UpdateGroup.Group.Comments");
			group.CreateDate = _ctx.StringValue("UpdateGroup.Group.CreateDate");
			updateGroupResponse.Group = group;
        
			return updateGroupResponse;
        }
    }
}
