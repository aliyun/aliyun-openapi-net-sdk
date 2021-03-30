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
using Aliyun.Acs.Airec.Model.V20201126;

namespace Aliyun.Acs.Airec.Transform.V20201126
{
    public class ListRulesResponseUnmarshaller
    {
        public static ListRulesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListRulesResponse listRulesResponse = new ListRulesResponse();

			listRulesResponse.HttpResponse = _ctx.HttpResponse;
			listRulesResponse.RequestId = _ctx.StringValue("ListRules.requestId");
			listRulesResponse.Code = _ctx.StringValue("ListRules.code");
			listRulesResponse.Message = _ctx.StringValue("ListRules.message");

			List<ListRulesResponse.ListRules_ResultItem> listRulesResponse_result = new List<ListRulesResponse.ListRules_ResultItem>();
			for (int i = 0; i < _ctx.Length("ListRules.Result.Length"); i++) {
				ListRulesResponse.ListRules_ResultItem resultItem = new ListRulesResponse.ListRules_ResultItem();
				resultItem.GmtCreate = _ctx.StringValue("ListRules.Result["+ i +"].gmtCreate");
				resultItem.GmtModified = _ctx.StringValue("ListRules.Result["+ i +"].gmtModified");
				resultItem.RuleId = _ctx.StringValue("ListRules.Result["+ i +"].ruleId");
				resultItem.Status = _ctx.StringValue("ListRules.Result["+ i +"].status");

				listRulesResponse_result.Add(resultItem);
			}
			listRulesResponse.Result = listRulesResponse_result;
        
			return listRulesResponse;
        }
    }
}
