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
    public class ListInterventionDictionaryEntriesResponseUnmarshaller
    {
        public static ListInterventionDictionaryEntriesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListInterventionDictionaryEntriesResponse listInterventionDictionaryEntriesResponse = new ListInterventionDictionaryEntriesResponse();

			listInterventionDictionaryEntriesResponse.HttpResponse = _ctx.HttpResponse;
			listInterventionDictionaryEntriesResponse.RequestId = _ctx.StringValue("ListInterventionDictionaryEntries.requestId");
			listInterventionDictionaryEntriesResponse.TotalCount = _ctx.IntegerValue("ListInterventionDictionaryEntries.totalCount");

			List<ListInterventionDictionaryEntriesResponse.ListInterventionDictionaryEntries_WordItem> listInterventionDictionaryEntriesResponse_result = new List<ListInterventionDictionaryEntriesResponse.ListInterventionDictionaryEntries_WordItem>();
			for (int i = 0; i < _ctx.Length("ListInterventionDictionaryEntries.Result.Length"); i++) {
				ListInterventionDictionaryEntriesResponse.ListInterventionDictionaryEntries_WordItem wordItem = new ListInterventionDictionaryEntriesResponse.ListInterventionDictionaryEntries_WordItem();
				wordItem.Cmd = _ctx.StringValue("ListInterventionDictionaryEntries.Result["+ i +"].cmd");
				wordItem.Word = _ctx.StringValue("ListInterventionDictionaryEntries.Result["+ i +"].word");
				wordItem.Created = _ctx.LongValue("ListInterventionDictionaryEntries.Result["+ i +"].created");
				wordItem.Updated = _ctx.LongValue("ListInterventionDictionaryEntries.Result["+ i +"].updated");
				wordItem.Status = _ctx.StringValue("ListInterventionDictionaryEntries.Result["+ i +"].status");
				wordItem.Relevance = _ctx.StringValue("ListInterventionDictionaryEntries.Result["+ i +"].relevance");

				List<ListInterventionDictionaryEntriesResponse.ListInterventionDictionaryEntries_WordItem.ListInterventionDictionaryEntries_Token> wordItem_tokens = new List<ListInterventionDictionaryEntriesResponse.ListInterventionDictionaryEntries_WordItem.ListInterventionDictionaryEntries_Token>();
				for (int j = 0; j < _ctx.Length("ListInterventionDictionaryEntries.Result["+ i +"].Tokens.Length"); j++) {
					ListInterventionDictionaryEntriesResponse.ListInterventionDictionaryEntries_WordItem.ListInterventionDictionaryEntries_Token token = new ListInterventionDictionaryEntriesResponse.ListInterventionDictionaryEntries_WordItem.ListInterventionDictionaryEntries_Token();
					token.Tag = _ctx.StringValue("ListInterventionDictionaryEntries.Result["+ i +"].Tokens["+ j +"].tag");
					token.Token = _ctx.StringValue("ListInterventionDictionaryEntries.Result["+ i +"].Tokens["+ j +"].token");
					token.Order = _ctx.IntegerValue("ListInterventionDictionaryEntries.Result["+ i +"].Tokens["+ j +"].order");
					token.TagLabel = _ctx.StringValue("ListInterventionDictionaryEntries.Result["+ i +"].Tokens["+ j +"].tagLabel");

					wordItem_tokens.Add(token);
				}
				wordItem.Tokens = wordItem_tokens;

				listInterventionDictionaryEntriesResponse_result.Add(wordItem);
			}
			listInterventionDictionaryEntriesResponse.Result = listInterventionDictionaryEntriesResponse_result;
        
			return listInterventionDictionaryEntriesResponse;
        }
    }
}
