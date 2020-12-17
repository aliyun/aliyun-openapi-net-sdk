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
using Aliyun.Acs.Qualitycheck.Model.V20190115;

namespace Aliyun.Acs.Qualitycheck.Transform.V20190115
{
    public class GetRuleCategoryResponseUnmarshaller
    {
        public static GetRuleCategoryResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetRuleCategoryResponse getRuleCategoryResponse = new GetRuleCategoryResponse();

			getRuleCategoryResponse.HttpResponse = _ctx.HttpResponse;
			getRuleCategoryResponse.RequestId = _ctx.StringValue("GetRuleCategory.RequestId");
			getRuleCategoryResponse.Success = _ctx.BooleanValue("GetRuleCategory.Success");
			getRuleCategoryResponse.Code = _ctx.StringValue("GetRuleCategory.Code");
			getRuleCategoryResponse.Message = _ctx.StringValue("GetRuleCategory.Message");

			List<GetRuleCategoryResponse.GetRuleCategory_RuleCountInfo> getRuleCategoryResponse_data = new List<GetRuleCategoryResponse.GetRuleCategory_RuleCountInfo>();
			for (int i = 0; i < _ctx.Length("GetRuleCategory.Data.Length"); i++) {
				GetRuleCategoryResponse.GetRuleCategory_RuleCountInfo ruleCountInfo = new GetRuleCategoryResponse.GetRuleCategory_RuleCountInfo();
				ruleCountInfo.Type = _ctx.IntegerValue("GetRuleCategory.Data["+ i +"].Type");
				ruleCountInfo.TypeName = _ctx.StringValue("GetRuleCategory.Data["+ i +"].TypeName");
				ruleCountInfo.Select = _ctx.BooleanValue("GetRuleCategory.Data["+ i +"].Select");

				getRuleCategoryResponse_data.Add(ruleCountInfo);
			}
			getRuleCategoryResponse.Data = getRuleCategoryResponse_data;
        
			return getRuleCategoryResponse;
        }
    }
}
