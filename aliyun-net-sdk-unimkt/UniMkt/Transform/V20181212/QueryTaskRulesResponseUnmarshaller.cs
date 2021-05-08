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
    public class QueryTaskRulesResponseUnmarshaller
    {
        public static QueryTaskRulesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryTaskRulesResponse queryTaskRulesResponse = new QueryTaskRulesResponse();

			queryTaskRulesResponse.HttpResponse = _ctx.HttpResponse;
			queryTaskRulesResponse.RequestId = _ctx.StringValue("QueryTaskRules.RequestId");
			queryTaskRulesResponse.Code = _ctx.IntegerValue("QueryTaskRules.Code");
			queryTaskRulesResponse.Success = _ctx.BooleanValue("QueryTaskRules.Success");
			queryTaskRulesResponse.ErrorMessage = _ctx.StringValue("QueryTaskRules.ErrorMessage");

			List<QueryTaskRulesResponse.QueryTaskRules_DataItem> queryTaskRulesResponse_data = new List<QueryTaskRulesResponse.QueryTaskRules_DataItem>();
			for (int i = 0; i < _ctx.Length("QueryTaskRules.Data.Length"); i++) {
				QueryTaskRulesResponse.QueryTaskRules_DataItem dataItem = new QueryTaskRulesResponse.QueryTaskRules_DataItem();
				dataItem.Id = _ctx.IntegerValue("QueryTaskRules.Data["+ i +"].Id");
				dataItem.TaskId = _ctx.LongValue("QueryTaskRules.Data["+ i +"].TaskId");
				dataItem.Type = _ctx.IntegerValue("QueryTaskRules.Data["+ i +"].Type");
				dataItem.Content = _ctx.StringValue("QueryTaskRules.Data["+ i +"].Content");

				queryTaskRulesResponse_data.Add(dataItem);
			}
			queryTaskRulesResponse.Data = queryTaskRulesResponse_data;
        
			return queryTaskRulesResponse;
        }
    }
}
