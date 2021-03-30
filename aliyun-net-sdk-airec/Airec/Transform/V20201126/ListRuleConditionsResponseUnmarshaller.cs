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
    public class ListRuleConditionsResponseUnmarshaller
    {
        public static ListRuleConditionsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListRuleConditionsResponse listRuleConditionsResponse = new ListRuleConditionsResponse();

			listRuleConditionsResponse.HttpResponse = _ctx.HttpResponse;
			listRuleConditionsResponse.RequestId = _ctx.StringValue("ListRuleConditions.requestId");
			listRuleConditionsResponse.Code = _ctx.StringValue("ListRuleConditions.code");
			listRuleConditionsResponse.Message = _ctx.StringValue("ListRuleConditions.message");

			List<ListRuleConditionsResponse.ListRuleConditions_ResultItem> listRuleConditionsResponse_result = new List<ListRuleConditionsResponse.ListRuleConditions_ResultItem>();
			for (int i = 0; i < _ctx.Length("ListRuleConditions.Result.Length"); i++) {
				ListRuleConditionsResponse.ListRuleConditions_ResultItem resultItem = new ListRuleConditionsResponse.ListRuleConditions_ResultItem();
				resultItem.SelectType = _ctx.StringValue("ListRuleConditions.Result["+ i +"].selectType");
				resultItem.SelectValue = _ctx.StringValue("ListRuleConditions.Result["+ i +"].selectValue");
				resultItem.SelectionOperation = _ctx.StringValue("ListRuleConditions.Result["+ i +"].selectionOperation");

				listRuleConditionsResponse_result.Add(resultItem);
			}
			listRuleConditionsResponse.Result = listRuleConditionsResponse_result;
        
			return listRuleConditionsResponse;
        }
    }
}
