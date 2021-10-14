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
    public class AddSkillGroupsToUserResponseUnmarshaller
    {
        public static AddSkillGroupsToUserResponse Unmarshall(UnmarshallerContext _ctx)
        {
			AddSkillGroupsToUserResponse addSkillGroupsToUserResponse = new AddSkillGroupsToUserResponse();

			addSkillGroupsToUserResponse.HttpResponse = _ctx.HttpResponse;
			addSkillGroupsToUserResponse.Code = _ctx.StringValue("AddSkillGroupsToUser.Code");
			addSkillGroupsToUserResponse.HttpStatusCode = _ctx.IntegerValue("AddSkillGroupsToUser.HttpStatusCode");
			addSkillGroupsToUserResponse.Message = _ctx.StringValue("AddSkillGroupsToUser.Message");
			addSkillGroupsToUserResponse.RequestId = _ctx.StringValue("AddSkillGroupsToUser.RequestId");

			List<string> addSkillGroupsToUserResponse_params = new List<string>();
			for (int i = 0; i < _ctx.Length("AddSkillGroupsToUser.Params.Length"); i++) {
				addSkillGroupsToUserResponse_params.Add(_ctx.StringValue("AddSkillGroupsToUser.Params["+ i +"]"));
			}
			addSkillGroupsToUserResponse._Params = addSkillGroupsToUserResponse_params;
        
			return addSkillGroupsToUserResponse;
        }
    }
}
