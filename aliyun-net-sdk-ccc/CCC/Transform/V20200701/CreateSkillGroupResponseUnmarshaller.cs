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
    public class CreateSkillGroupResponseUnmarshaller
    {
        public static CreateSkillGroupResponse Unmarshall(UnmarshallerContext _ctx)
        {
			CreateSkillGroupResponse createSkillGroupResponse = new CreateSkillGroupResponse();

			createSkillGroupResponse.HttpResponse = _ctx.HttpResponse;
			createSkillGroupResponse.Code = _ctx.StringValue("CreateSkillGroup.Code");
			createSkillGroupResponse.HttpStatusCode = _ctx.IntegerValue("CreateSkillGroup.HttpStatusCode");
			createSkillGroupResponse.Message = _ctx.StringValue("CreateSkillGroup.Message");
			createSkillGroupResponse.RequestId = _ctx.StringValue("CreateSkillGroup.RequestId");

			CreateSkillGroupResponse.CreateSkillGroup_Data data = new CreateSkillGroupResponse.CreateSkillGroup_Data();
			data.Description = _ctx.StringValue("CreateSkillGroup.Data.Description");
			data.InstanceId = _ctx.StringValue("CreateSkillGroup.Data.InstanceId");
			data.Name = _ctx.StringValue("CreateSkillGroup.Data.Name");
			data.SkillGroupId = _ctx.StringValue("CreateSkillGroup.Data.SkillGroupId");
			createSkillGroupResponse.Data = data;
        
			return createSkillGroupResponse;
        }
    }
}
