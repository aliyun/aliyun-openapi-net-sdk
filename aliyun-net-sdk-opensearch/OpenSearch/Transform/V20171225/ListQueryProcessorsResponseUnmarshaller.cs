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
    public class ListQueryProcessorsResponseUnmarshaller
    {
        public static ListQueryProcessorsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListQueryProcessorsResponse listQueryProcessorsResponse = new ListQueryProcessorsResponse();

			listQueryProcessorsResponse.HttpResponse = _ctx.HttpResponse;
			listQueryProcessorsResponse.RequestId = _ctx.StringValue("ListQueryProcessors.requestId");

			List<ListQueryProcessorsResponse.ListQueryProcessors_ResultItem> listQueryProcessorsResponse_result = new List<ListQueryProcessorsResponse.ListQueryProcessors_ResultItem>();
			for (int i = 0; i < _ctx.Length("ListQueryProcessors.Result.Length"); i++) {
				ListQueryProcessorsResponse.ListQueryProcessors_ResultItem resultItem = new ListQueryProcessorsResponse.ListQueryProcessors_ResultItem();
				resultItem.Name = _ctx.StringValue("ListQueryProcessors.Result["+ i +"].name");
				resultItem.Active = _ctx.BooleanValue("ListQueryProcessors.Result["+ i +"].active");
				resultItem.Domain = _ctx.StringValue("ListQueryProcessors.Result["+ i +"].domain");
				resultItem.Created = _ctx.IntegerValue("ListQueryProcessors.Result["+ i +"].created");
				resultItem.Updated = _ctx.IntegerValue("ListQueryProcessors.Result["+ i +"].updated");

				List<string> resultItem_indexes = new List<string>();
				for (int j = 0; j < _ctx.Length("ListQueryProcessors.Result["+ i +"].Indexes.Length"); j++) {
					resultItem_indexes.Add(_ctx.StringValue("ListQueryProcessors.Result["+ i +"].Indexes["+ j +"]"));
				}
				resultItem.Indexes = resultItem_indexes;

				List<Dictionary<string, string>> resultItem_processors = new List<Dictionary<string, string>>();
				for (int j = 0; j < _ctx.Length("ListQueryProcessors.Result["+ i +"].Processors.Length"); j++) {
					Dictionary<string, string> tmp = new Dictionary<string, string>() { };
					foreach (var _item in _ctx.ResponseDictionary){
						string prefix = "ListQueryProcessors.Result["+ i +"].Processors["+ j +"].";
						if (_item.Key.IndexOf(prefix) == 0){
							tmp.Add(_item.Key.Substring(prefix.Length), _item.Value);
						}
					}
					if (tmp.Count > 0){
						resultItem_processors.Add(tmp);
					}
				}
				resultItem.Processors = resultItem_processors;

				listQueryProcessorsResponse_result.Add(resultItem);
			}
			listQueryProcessorsResponse.Result = listQueryProcessorsResponse_result;
        
			return listQueryProcessorsResponse;
        }
    }
}
