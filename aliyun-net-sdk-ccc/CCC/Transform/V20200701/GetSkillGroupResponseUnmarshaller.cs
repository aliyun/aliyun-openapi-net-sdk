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
    public class GetSkillGroupResponseUnmarshaller
    {
        public static GetSkillGroupResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetSkillGroupResponse getSkillGroupResponse = new GetSkillGroupResponse();

			getSkillGroupResponse.HttpResponse = _ctx.HttpResponse;
			getSkillGroupResponse.Code = _ctx.StringValue("GetSkillGroup.Code");
			getSkillGroupResponse.HttpStatusCode = _ctx.IntegerValue("GetSkillGroup.HttpStatusCode");
			getSkillGroupResponse.Message = _ctx.StringValue("GetSkillGroup.Message");
			getSkillGroupResponse.RequestId = _ctx.StringValue("GetSkillGroup.RequestId");

			GetSkillGroupResponse.GetSkillGroup_Data data = new GetSkillGroupResponse.GetSkillGroup_Data();
			data.DisplayName = _ctx.StringValue("GetSkillGroup.Data.DisplayName");
			data.InstanceId = _ctx.StringValue("GetSkillGroup.Data.InstanceId");
			data.Name = _ctx.StringValue("GetSkillGroup.Data.Name");
			data.Description = _ctx.StringValue("GetSkillGroup.Data.Description");
			data.SkillGroupId = _ctx.StringValue("GetSkillGroup.Data.SkillGroupId");
			getSkillGroupResponse.Data = data;
        
			return getSkillGroupResponse;
        }
    }
}
