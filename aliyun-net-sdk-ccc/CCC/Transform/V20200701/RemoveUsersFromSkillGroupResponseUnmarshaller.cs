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
using Aliyun.Acs.CCC.Model.V20200701;

namespace Aliyun.Acs.CCC.Transform.V20200701
{
    public class RemoveUsersFromSkillGroupResponseUnmarshaller
    {
        public static RemoveUsersFromSkillGroupResponse Unmarshall(UnmarshallerContext _ctx)
        {
			RemoveUsersFromSkillGroupResponse removeUsersFromSkillGroupResponse = new RemoveUsersFromSkillGroupResponse();

			removeUsersFromSkillGroupResponse.HttpResponse = _ctx.HttpResponse;
			removeUsersFromSkillGroupResponse.Code = _ctx.StringValue("RemoveUsersFromSkillGroup.Code");
			removeUsersFromSkillGroupResponse.HttpStatusCode = _ctx.IntegerValue("RemoveUsersFromSkillGroup.HttpStatusCode");
			removeUsersFromSkillGroupResponse.Message = _ctx.StringValue("RemoveUsersFromSkillGroup.Message");
			removeUsersFromSkillGroupResponse.RequestId = _ctx.StringValue("RemoveUsersFromSkillGroup.RequestId");
        
			return removeUsersFromSkillGroupResponse;
        }
    }
}
