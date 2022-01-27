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
using Aliyun.Acs.quickbi_public.Model.V20200730;

namespace Aliyun.Acs.quickbi_public.Transform.V20200730
{
    public class QueryDataServiceResponseUnmarshaller
    {
        public static QueryDataServiceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryDataServiceResponse queryDataServiceResponse = new QueryDataServiceResponse();

			queryDataServiceResponse.HttpResponse = _ctx.HttpResponse;
			queryDataServiceResponse.RequestId = _ctx.StringValue("QueryDataService.RequestId");
			queryDataServiceResponse.Success = _ctx.BooleanValue("QueryDataService.Success");

			QueryDataServiceResponse.QueryDataService_Result result = new QueryDataServiceResponse.QueryDataService_Result();
			result.Sql = _ctx.StringValue("QueryDataService.Result.Sql");

			List<Dictionary<string, string>> result_values = new List<Dictionary<string, string>>();
			for (int i = 0; i < _ctx.Length("QueryDataService.Result.Values.Length"); i++) {
				Dictionary<string, string> tmp = new Dictionary<string, string>() { };
				foreach (var _item in _ctx.ResponseDictionary){
					string prefix = "QueryDataService.Result.Values["+ i +"].";
					if (_item.Key.IndexOf(prefix) == 0){
						tmp.Add(_item.Key.Substring(prefix.Length), _item.Value);
					}
				}
				if (tmp.Count > 0){
					result_values.Add(tmp);
				}
			}
			result.Values = result_values;

			List<QueryDataServiceResponse.QueryDataService_Result.QueryDataService_HeadersItem> result_headers = new List<QueryDataServiceResponse.QueryDataService_Result.QueryDataService_HeadersItem>();
			for (int i = 0; i < _ctx.Length("QueryDataService.Result.Headers.Length"); i++) {
				QueryDataServiceResponse.QueryDataService_Result.QueryDataService_HeadersItem headersItem = new QueryDataServiceResponse.QueryDataService_Result.QueryDataService_HeadersItem();
				headersItem.Label = _ctx.StringValue("QueryDataService.Result.Headers["+ i +"].Label");
				headersItem.Type = _ctx.StringValue("QueryDataService.Result.Headers["+ i +"].Type");
				headersItem.DataType = _ctx.StringValue("QueryDataService.Result.Headers["+ i +"].DataType");
				headersItem.Column = _ctx.StringValue("QueryDataService.Result.Headers["+ i +"].Column");
				headersItem.Aggregator = _ctx.StringValue("QueryDataService.Result.Headers["+ i +"].Aggregator");
				headersItem.Granularity = _ctx.StringValue("QueryDataService.Result.Headers["+ i +"].Granularity");

				result_headers.Add(headersItem);
			}
			result.Headers = result_headers;
			queryDataServiceResponse.Result = result;
        
			return queryDataServiceResponse;
        }
    }
}
