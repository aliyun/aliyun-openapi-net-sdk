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
using Aliyun.Acs.CCC.Model.V20170705;

namespace Aliyun.Acs.CCC.Transform.V20170705
{
    public class ListTrunksOfSkillGroupResponseUnmarshaller
    {
        public static ListTrunksOfSkillGroupResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListTrunksOfSkillGroupResponse listTrunksOfSkillGroupResponse = new ListTrunksOfSkillGroupResponse();

			listTrunksOfSkillGroupResponse.HttpResponse = _ctx.HttpResponse;
			listTrunksOfSkillGroupResponse.RequestId = _ctx.StringValue("ListTrunksOfSkillGroup.RequestId");
			listTrunksOfSkillGroupResponse.Success = _ctx.BooleanValue("ListTrunksOfSkillGroup.Success");
			listTrunksOfSkillGroupResponse.Code = _ctx.StringValue("ListTrunksOfSkillGroup.Code");
			listTrunksOfSkillGroupResponse.Message = _ctx.StringValue("ListTrunksOfSkillGroup.Message");
			listTrunksOfSkillGroupResponse.HttpStatusCode = _ctx.IntegerValue("ListTrunksOfSkillGroup.HttpStatusCode");

			List<ListTrunksOfSkillGroupResponse.ListTrunksOfSkillGroup_TrunkConfig> listTrunksOfSkillGroupResponse_trunkConfigs = new List<ListTrunksOfSkillGroupResponse.ListTrunksOfSkillGroup_TrunkConfig>();
			for (int i = 0; i < _ctx.Length("ListTrunksOfSkillGroup.TrunkConfigs.Length"); i++) {
				ListTrunksOfSkillGroupResponse.ListTrunksOfSkillGroup_TrunkConfig trunkConfig = new ListTrunksOfSkillGroupResponse.ListTrunksOfSkillGroup_TrunkConfig();
				trunkConfig.ProviderName = _ctx.StringValue("ListTrunksOfSkillGroup.TrunkConfigs["+ i +"].ProviderName");
				trunkConfig.Primary = _ctx.BooleanValue("ListTrunksOfSkillGroup.TrunkConfigs["+ i +"].Primary");

				listTrunksOfSkillGroupResponse_trunkConfigs.Add(trunkConfig);
			}
			listTrunksOfSkillGroupResponse.TrunkConfigs = listTrunksOfSkillGroupResponse_trunkConfigs;
        
			return listTrunksOfSkillGroupResponse;
        }
    }
}
