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
using Aliyun.Acs.UniMkt.Model.V20181212;

namespace Aliyun.Acs.UniMkt.Transform.V20181212
{
    public class QueryTaskRuleLimitResponseUnmarshaller
    {
        public static QueryTaskRuleLimitResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryTaskRuleLimitResponse queryTaskRuleLimitResponse = new QueryTaskRuleLimitResponse();

			queryTaskRuleLimitResponse.HttpResponse = _ctx.HttpResponse;
			queryTaskRuleLimitResponse.Code = _ctx.IntegerValue("QueryTaskRuleLimit.Code");
			queryTaskRuleLimitResponse.Success = _ctx.BooleanValue("QueryTaskRuleLimit.Success");
			queryTaskRuleLimitResponse.ErrorMsg = _ctx.StringValue("QueryTaskRuleLimit.ErrorMsg");
			queryTaskRuleLimitResponse.RequestId = _ctx.StringValue("QueryTaskRuleLimit.RequestId");

			List<Dictionary<string, string>> queryTaskRuleLimitResponse_data = new List<Dictionary<string, string>>();
			for (int i = 0; i < _ctx.Length("QueryTaskRuleLimit.Data.Length"); i++) {
				Dictionary<string, string> tmp = new Dictionary<string, string>() { };
				foreach (var _item in _ctx.ResponseDictionary){
					string prefix = "QueryTaskRuleLimit.Data["+ i +"].";
					if (_item.Key.IndexOf(prefix) == 0){
						tmp.Add(_item.Key.Substring(prefix.Length), _item.Value);
					}
				}
				if (tmp.Count > 0){
					queryTaskRuleLimitResponse_data.Add(tmp);
				}
			}
			queryTaskRuleLimitResponse.Data = queryTaskRuleLimitResponse_data;
        
			return queryTaskRuleLimitResponse;
        }
    }
}
