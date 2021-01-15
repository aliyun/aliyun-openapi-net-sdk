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
using Aliyun.Acs.OpenSearch.Model.V20171225;

namespace Aliyun.Acs.OpenSearch.Transform.V20171225
{
    public class ListScheduledTasksResponseUnmarshaller
    {
        public static ListScheduledTasksResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListScheduledTasksResponse listScheduledTasksResponse = new ListScheduledTasksResponse();

			listScheduledTasksResponse.HttpResponse = _ctx.HttpResponse;
			listScheduledTasksResponse.RequestId = _ctx.StringValue("ListScheduledTasks.requestId");
			listScheduledTasksResponse.TotalCount = _ctx.LongValue("ListScheduledTasks.totalCount");

			List<Dictionary<string, string>> listScheduledTasksResponse_result = new List<Dictionary<string, string>>();
			for (int i = 0; i < _ctx.Length("ListScheduledTasks.Result.Length"); i++) {
				Dictionary<string, string> tmp = new Dictionary<string, string>() { };
				foreach (var _item in _ctx.ResponseDictionary){
					string prefix = "ListScheduledTasks.Result["+ i +"].";
					if (_item.Key.IndexOf(prefix) == 0){
						tmp.Add(_item.Key.Substring(prefix.Length), _item.Value);
					}
				}
				if (tmp.Count > 0){
					listScheduledTasksResponse_result.Add(tmp);
				}
			}
			listScheduledTasksResponse.Result = listScheduledTasksResponse_result;
        
			return listScheduledTasksResponse;
        }
    }
}
