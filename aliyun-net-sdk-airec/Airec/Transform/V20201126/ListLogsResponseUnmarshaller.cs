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
    public class ListLogsResponseUnmarshaller
    {
        public static ListLogsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListLogsResponse listLogsResponse = new ListLogsResponse();

			listLogsResponse.HttpResponse = _ctx.HttpResponse;
			listLogsResponse.RequestId = _ctx.StringValue("ListLogs.requestId");
			listLogsResponse.Code = _ctx.StringValue("ListLogs.code");
			listLogsResponse.Message = _ctx.StringValue("ListLogs.message");

			List<Dictionary<string, string>> listLogsResponse_result = new List<Dictionary<string, string>>();
			for (int i = 0; i < _ctx.Length("ListLogs.Result.Length"); i++) {
				Dictionary<string, string> tmp = new Dictionary<string, string>() { };
				foreach (var _item in _ctx.ResponseDictionary){
					string prefix = "ListLogs.Result["+ i +"].";
					if (_item.Key.IndexOf(prefix) == 0){
						tmp.Add(_item.Key.Substring(prefix.Length), _item.Value);
					}
				}
				if (tmp.Count > 0){
					listLogsResponse_result.Add(tmp);
				}
			}
			listLogsResponse.Result = listLogsResponse_result;

			ListLogsResponse.ListLogs_Headers headers = new ListLogsResponse.ListLogs_Headers();
			headers.XTotalCount = _ctx.IntegerValue("ListLogs.Headers.X-Total-Count");
			listLogsResponse.Headers = headers;
        
			return listLogsResponse;
        }
    }
}
