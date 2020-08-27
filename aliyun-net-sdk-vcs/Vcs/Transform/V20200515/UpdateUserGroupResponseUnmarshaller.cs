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
using Aliyun.Acs.Vcs.Model.V20200515;

namespace Aliyun.Acs.Vcs.Transform.V20200515
{
    public class UpdateUserGroupResponseUnmarshaller
    {
        public static UpdateUserGroupResponse Unmarshall(UnmarshallerContext context)
        {
			UpdateUserGroupResponse updateUserGroupResponse = new UpdateUserGroupResponse();

			updateUserGroupResponse.HttpResponse = context.HttpResponse;
			updateUserGroupResponse.Code = context.StringValue("UpdateUserGroup.Code");
			updateUserGroupResponse.Message = context.StringValue("UpdateUserGroup.Message");
			updateUserGroupResponse.RequestId = context.StringValue("UpdateUserGroup.RequestId");

			UpdateUserGroupResponse.UpdateUserGroup_Data data = new UpdateUserGroupResponse.UpdateUserGroup_Data();
			data.UserGroupId = context.LongValue("UpdateUserGroup.Data.UserGroupId");
			data.IsvSubId = context.StringValue("UpdateUserGroup.Data.IsvSubId");
			data.UserGroupName = context.StringValue("UpdateUserGroup.Data.UserGroupName");
			data.UserCount = context.LongValue("UpdateUserGroup.Data.UserCount");
			data.ParentUserGroupId = context.StringValue("UpdateUserGroup.Data.ParentUserGroupId");
			updateUserGroupResponse.Data = data;
        
			return updateUserGroupResponse;
        }
    }
}
