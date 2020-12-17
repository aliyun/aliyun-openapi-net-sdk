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
    public class ListRulesResponseUnmarshaller
    {
        public static ListRulesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListRulesResponse listRulesResponse = new ListRulesResponse();

			listRulesResponse.HttpResponse = _ctx.HttpResponse;
			listRulesResponse.RequestId = _ctx.StringValue("ListRules.RequestId");
			listRulesResponse.Success = _ctx.BooleanValue("ListRules.Success");
			listRulesResponse.Code = _ctx.StringValue("ListRules.Code");
			listRulesResponse.Message = _ctx.StringValue("ListRules.Message");
			listRulesResponse.Count = _ctx.IntegerValue("ListRules.Count");
			listRulesResponse.PageSize = _ctx.IntegerValue("ListRules.PageSize");
			listRulesResponse.PageNumber = _ctx.IntegerValue("ListRules.PageNumber");

			List<ListRulesResponse.ListRules_Rule> listRulesResponse_data = new List<ListRulesResponse.ListRules_Rule>();
			for (int i = 0; i < _ctx.Length("ListRules.Data.Length"); i++) {
				ListRulesResponse.ListRules_Rule rule = new ListRulesResponse.ListRules_Rule();
				rule.Name = _ctx.StringValue("ListRules.Data["+ i +"].Name");
				rule.Type = _ctx.IntegerValue("ListRules.Data["+ i +"].Type");
				rule.Comments = _ctx.StringValue("ListRules.Data["+ i +"].Comments");
				rule.CreateTime = _ctx.StringValue("ListRules.Data["+ i +"].CreateTime");
				rule.TypeName = _ctx.StringValue("ListRules.Data["+ i +"].TypeName");
				rule.RuleType = _ctx.IntegerValue("ListRules.Data["+ i +"].RuleType");
				rule.Rid = _ctx.LongValue("ListRules.Data["+ i +"].Rid");

				List<string> rule_businessCategoryNameList = new List<string>();
				for (int j = 0; j < _ctx.Length("ListRules.Data["+ i +"].BusinessCategoryNameList.Length"); j++) {
					rule_businessCategoryNameList.Add(_ctx.StringValue("ListRules.Data["+ i +"].BusinessCategoryNameList["+ j +"]"));
				}
				rule.BusinessCategoryNameList = rule_businessCategoryNameList;

				listRulesResponse_data.Add(rule);
			}
			listRulesResponse.Data = listRulesResponse_data;
        
			return listRulesResponse;
        }
    }
}
