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
    public class ListUserAnalyzersResponseUnmarshaller
    {
        public static ListUserAnalyzersResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListUserAnalyzersResponse listUserAnalyzersResponse = new ListUserAnalyzersResponse();

			listUserAnalyzersResponse.HttpResponse = _ctx.HttpResponse;
			listUserAnalyzersResponse.TotalCount = _ctx.IntegerValue("ListUserAnalyzers.totalCount");
			listUserAnalyzersResponse.RequestId = _ctx.StringValue("ListUserAnalyzers.requestId");

			List<ListUserAnalyzersResponse.ListUserAnalyzers_ResultItem> listUserAnalyzersResponse_result = new List<ListUserAnalyzersResponse.ListUserAnalyzers_ResultItem>();
			for (int i = 0; i < _ctx.Length("ListUserAnalyzers.Result.Length"); i++) {
				ListUserAnalyzersResponse.ListUserAnalyzers_ResultItem resultItem = new ListUserAnalyzersResponse.ListUserAnalyzers_ResultItem();
				resultItem.Created = _ctx.IntegerValue("ListUserAnalyzers.Result["+ i +"].created");
				resultItem.Available = _ctx.BooleanValue("ListUserAnalyzers.Result["+ i +"].available");
				resultItem.Name = _ctx.StringValue("ListUserAnalyzers.Result["+ i +"].name");
				resultItem.Updated = _ctx.IntegerValue("ListUserAnalyzers.Result["+ i +"].updated");
				resultItem.Id = _ctx.StringValue("ListUserAnalyzers.Result["+ i +"].id");
				resultItem.Business = _ctx.StringValue("ListUserAnalyzers.Result["+ i +"].business");

				List<ListUserAnalyzersResponse.ListUserAnalyzers_ResultItem.ListUserAnalyzers_DictsItem> resultItem_dicts = new List<ListUserAnalyzersResponse.ListUserAnalyzers_ResultItem.ListUserAnalyzers_DictsItem>();
				for (int j = 0; j < _ctx.Length("ListUserAnalyzers.Result["+ i +"].Dicts.Length"); j++) {
					ListUserAnalyzersResponse.ListUserAnalyzers_ResultItem.ListUserAnalyzers_DictsItem dictsItem = new ListUserAnalyzersResponse.ListUserAnalyzers_ResultItem.ListUserAnalyzers_DictsItem();
					dictsItem.Created = _ctx.IntegerValue("ListUserAnalyzers.Result["+ i +"].Dicts["+ j +"].created");
					dictsItem.EntriesCount = _ctx.IntegerValue("ListUserAnalyzers.Result["+ i +"].Dicts["+ j +"].entriesCount");
					dictsItem.Type = _ctx.StringValue("ListUserAnalyzers.Result["+ i +"].Dicts["+ j +"].type");
					dictsItem.EntriesLimit = _ctx.IntegerValue("ListUserAnalyzers.Result["+ i +"].Dicts["+ j +"].entriesLimit");
					dictsItem.Available = _ctx.BooleanValue("ListUserAnalyzers.Result["+ i +"].Dicts["+ j +"].available");
					dictsItem.Updated = _ctx.IntegerValue("ListUserAnalyzers.Result["+ i +"].Dicts["+ j +"].updated");
					dictsItem.Id = _ctx.StringValue("ListUserAnalyzers.Result["+ i +"].Dicts["+ j +"].id");

					resultItem_dicts.Add(dictsItem);
				}
				resultItem.Dicts = resultItem_dicts;

				listUserAnalyzersResponse_result.Add(resultItem);
			}
			listUserAnalyzersResponse.Result = listUserAnalyzersResponse_result;
        
			return listUserAnalyzersResponse;
        }
    }
}
