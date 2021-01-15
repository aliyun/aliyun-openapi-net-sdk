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
			listUserAnalyzersResponse.RequestId = _ctx.StringValue("ListUserAnalyzers.requestId");
			listUserAnalyzersResponse.TotalCount = _ctx.IntegerValue("ListUserAnalyzers.totalCount");

			List<ListUserAnalyzersResponse.ListUserAnalyzers_ResultItem> listUserAnalyzersResponse_result = new List<ListUserAnalyzersResponse.ListUserAnalyzers_ResultItem>();
			for (int i = 0; i < _ctx.Length("ListUserAnalyzers.Result.Length"); i++) {
				ListUserAnalyzersResponse.ListUserAnalyzers_ResultItem resultItem = new ListUserAnalyzersResponse.ListUserAnalyzers_ResultItem();
				resultItem.Id = _ctx.StringValue("ListUserAnalyzers.Result["+ i +"].id");
				resultItem.Name = _ctx.StringValue("ListUserAnalyzers.Result["+ i +"].name");
				resultItem.Business = _ctx.StringValue("ListUserAnalyzers.Result["+ i +"].business");
				resultItem.Available = _ctx.BooleanValue("ListUserAnalyzers.Result["+ i +"].available");
				resultItem.Created = _ctx.IntegerValue("ListUserAnalyzers.Result["+ i +"].created");
				resultItem.Updated = _ctx.IntegerValue("ListUserAnalyzers.Result["+ i +"].updated");

				List<ListUserAnalyzersResponse.ListUserAnalyzers_ResultItem.ListUserAnalyzers_DictsItem> resultItem_dicts = new List<ListUserAnalyzersResponse.ListUserAnalyzers_ResultItem.ListUserAnalyzers_DictsItem>();
				for (int j = 0; j < _ctx.Length("ListUserAnalyzers.Result["+ i +"].Dicts.Length"); j++) {
					ListUserAnalyzersResponse.ListUserAnalyzers_ResultItem.ListUserAnalyzers_DictsItem dictsItem = new ListUserAnalyzersResponse.ListUserAnalyzers_ResultItem.ListUserAnalyzers_DictsItem();
					dictsItem.Id = _ctx.StringValue("ListUserAnalyzers.Result["+ i +"].Dicts["+ j +"].id");
					dictsItem.Type = _ctx.StringValue("ListUserAnalyzers.Result["+ i +"].Dicts["+ j +"].type");
					dictsItem.EntriesLimit = _ctx.IntegerValue("ListUserAnalyzers.Result["+ i +"].Dicts["+ j +"].entriesLimit");
					dictsItem.EntriesCount = _ctx.IntegerValue("ListUserAnalyzers.Result["+ i +"].Dicts["+ j +"].entriesCount");
					dictsItem.Available = _ctx.BooleanValue("ListUserAnalyzers.Result["+ i +"].Dicts["+ j +"].available");
					dictsItem.Created = _ctx.IntegerValue("ListUserAnalyzers.Result["+ i +"].Dicts["+ j +"].created");
					dictsItem.Updated = _ctx.IntegerValue("ListUserAnalyzers.Result["+ i +"].Dicts["+ j +"].updated");

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
