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
    public class QueryContentListResponseUnmarshaller
    {
        public static QueryContentListResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryContentListResponse queryContentListResponse = new QueryContentListResponse();

			queryContentListResponse.HttpResponse = _ctx.HttpResponse;
			queryContentListResponse.Code = _ctx.IntegerValue("QueryContentList.Code");
			queryContentListResponse.ErrorMsg = _ctx.StringValue("QueryContentList.ErrorMsg");
			queryContentListResponse.RequestId = _ctx.StringValue("QueryContentList.RequestId");
			queryContentListResponse.Success = _ctx.BooleanValue("QueryContentList.Success");

			List<Dictionary<string, string>> queryContentListResponse_data = new List<Dictionary<string, string>>();
			for (int i = 0; i < _ctx.Length("QueryContentList.Data.Length"); i++) {
				Dictionary<string, string> tmp = new Dictionary<string, string>() { };
				foreach (var _item in _ctx.ResponseDictionary){
					string prefix = "QueryContentList.Data["+ i +"].";
					if (_item.Key.IndexOf(prefix) == 0){
						tmp.Add(_item.Key.Substring(prefix.Length), _item.Value);
					}
				}
				if (tmp.Count > 0){
					queryContentListResponse_data.Add(tmp);
				}
			}
			queryContentListResponse.Data = queryContentListResponse_data;
        
			return queryContentListResponse;
        }
    }
}
