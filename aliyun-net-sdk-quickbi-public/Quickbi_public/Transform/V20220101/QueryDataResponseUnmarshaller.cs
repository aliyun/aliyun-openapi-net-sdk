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
using Aliyun.Acs.quickbi_public.Model.V20220101;

namespace Aliyun.Acs.quickbi_public.Transform.V20220101
{
    public class QueryDataResponseUnmarshaller
    {
        public static QueryDataResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryDataResponse queryDataResponse = new QueryDataResponse();

			queryDataResponse.HttpResponse = _ctx.HttpResponse;
			queryDataResponse.RequestId = _ctx.StringValue("QueryData.RequestId");
			queryDataResponse.Success = _ctx.BooleanValue("QueryData.Success");

			QueryDataResponse.QueryData_Result result = new QueryDataResponse.QueryData_Result();
			result.Sql = _ctx.StringValue("QueryData.Result.Sql");

			List<Dictionary<string, string>> result_values = new List<Dictionary<string, string>>();
			for (int i = 0; i < _ctx.Length("QueryData.Result.Values.Length"); i++) {
				Dictionary<string, string> tmp = new Dictionary<string, string>() { };
				foreach (var _item in _ctx.ResponseDictionary){
					string prefix = "QueryData.Result.Values["+ i +"].";
					if (_item.Key.IndexOf(prefix) == 0){
						tmp.Add(_item.Key.Substring(prefix.Length), _item.Value);
					}
				}
				if (tmp.Count > 0){
					result_values.Add(tmp);
				}
			}
			result.Values = result_values;

			List<QueryDataResponse.QueryData_Result.QueryData_HeadersItem> result_headers = new List<QueryDataResponse.QueryData_Result.QueryData_HeadersItem>();
			for (int i = 0; i < _ctx.Length("QueryData.Result.Headers.Length"); i++) {
				QueryDataResponse.QueryData_Result.QueryData_HeadersItem headersItem = new QueryDataResponse.QueryData_Result.QueryData_HeadersItem();
				headersItem.Aggregator = _ctx.StringValue("QueryData.Result.Headers["+ i +"].Aggregator");
				headersItem.Column = _ctx.StringValue("QueryData.Result.Headers["+ i +"].Column");
				headersItem.DataType = _ctx.StringValue("QueryData.Result.Headers["+ i +"].DataType");
				headersItem.Granularity = _ctx.StringValue("QueryData.Result.Headers["+ i +"].Granularity");
				headersItem.Label = _ctx.StringValue("QueryData.Result.Headers["+ i +"].Label");
				headersItem.Type = _ctx.StringValue("QueryData.Result.Headers["+ i +"].Type");

				result_headers.Add(headersItem);
			}
			result.Headers = result_headers;
			queryDataResponse.Result = result;
        
			return queryDataResponse;
        }
    }
}
