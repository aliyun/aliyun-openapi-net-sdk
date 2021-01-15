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
    public class ListFirstRanksResponseUnmarshaller
    {
        public static ListFirstRanksResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListFirstRanksResponse listFirstRanksResponse = new ListFirstRanksResponse();

			listFirstRanksResponse.HttpResponse = _ctx.HttpResponse;
			listFirstRanksResponse.RequestId = _ctx.StringValue("ListFirstRanks.requestId");

			List<ListFirstRanksResponse.ListFirstRanks_FirstRankItem> listFirstRanksResponse_result = new List<ListFirstRanksResponse.ListFirstRanks_FirstRankItem>();
			for (int i = 0; i < _ctx.Length("ListFirstRanks.Result.Length"); i++) {
				ListFirstRanksResponse.ListFirstRanks_FirstRankItem firstRankItem = new ListFirstRanksResponse.ListFirstRanks_FirstRankItem();
				firstRankItem.Name = _ctx.StringValue("ListFirstRanks.Result["+ i +"].name");
				firstRankItem.Description = _ctx.StringValue("ListFirstRanks.Result["+ i +"].description");
				firstRankItem.Active = _ctx.BooleanValue("ListFirstRanks.Result["+ i +"].active");
				firstRankItem.Created = _ctx.IntegerValue("ListFirstRanks.Result["+ i +"].created");
				firstRankItem.Updated = _ctx.IntegerValue("ListFirstRanks.Result["+ i +"].updated");

				List<ListFirstRanksResponse.ListFirstRanks_FirstRankItem.ListFirstRanks_MetaItem> firstRankItem_meta = new List<ListFirstRanksResponse.ListFirstRanks_FirstRankItem.ListFirstRanks_MetaItem>();
				for (int j = 0; j < _ctx.Length("ListFirstRanks.Result["+ i +"].Meta.Length"); j++) {
					ListFirstRanksResponse.ListFirstRanks_FirstRankItem.ListFirstRanks_MetaItem metaItem = new ListFirstRanksResponse.ListFirstRanks_FirstRankItem.ListFirstRanks_MetaItem();
					metaItem.Attribute = _ctx.StringValue("ListFirstRanks.Result["+ i +"].Meta["+ j +"].attribute");
					metaItem.Arg = _ctx.StringValue("ListFirstRanks.Result["+ i +"].Meta["+ j +"].arg");
					metaItem.Weight = _ctx.IntegerValue("ListFirstRanks.Result["+ i +"].Meta["+ j +"].weight");

					firstRankItem_meta.Add(metaItem);
				}
				firstRankItem.Meta = firstRankItem_meta;

				listFirstRanksResponse_result.Add(firstRankItem);
			}
			listFirstRanksResponse.Result = listFirstRanksResponse_result;
        
			return listFirstRanksResponse;
        }
    }
}
