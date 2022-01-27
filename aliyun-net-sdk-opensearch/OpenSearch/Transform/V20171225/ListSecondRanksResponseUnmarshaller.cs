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
    public class ListSecondRanksResponseUnmarshaller
    {
        public static ListSecondRanksResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListSecondRanksResponse listSecondRanksResponse = new ListSecondRanksResponse();

			listSecondRanksResponse.HttpResponse = _ctx.HttpResponse;
			listSecondRanksResponse.RequestId = _ctx.StringValue("ListSecondRanks.requestId");
			listSecondRanksResponse.TotalCount = _ctx.IntegerValue("ListSecondRanks.totalCount");

			List<ListSecondRanksResponse.ListSecondRanks_ResultItem> listSecondRanksResponse_result = new List<ListSecondRanksResponse.ListSecondRanks_ResultItem>();
			for (int i = 0; i < _ctx.Length("ListSecondRanks.Result.Length"); i++) {
				ListSecondRanksResponse.ListSecondRanks_ResultItem resultItem = new ListSecondRanksResponse.ListSecondRanks_ResultItem();
				resultItem.Id = _ctx.StringValue("ListSecondRanks.Result["+ i +"].id");
				resultItem.Name = _ctx.StringValue("ListSecondRanks.Result["+ i +"].name");
				resultItem.Meta = _ctx.StringValue("ListSecondRanks.Result["+ i +"].meta");
				resultItem.Active = _ctx.BooleanValue("ListSecondRanks.Result["+ i +"].active");
				resultItem.Description = _ctx.StringValue("ListSecondRanks.Result["+ i +"].description");
				resultItem.Created = _ctx.IntegerValue("ListSecondRanks.Result["+ i +"].created");
				resultItem.Updated = _ctx.IntegerValue("ListSecondRanks.Result["+ i +"].updated");
				resultItem.IsDefault = _ctx.StringValue("ListSecondRanks.Result["+ i +"].isDefault");
				resultItem.IsSys = _ctx.StringValue("ListSecondRanks.Result["+ i +"].isSys");

				listSecondRanksResponse_result.Add(resultItem);
			}
			listSecondRanksResponse.Result = listSecondRanksResponse_result;
        
			return listSecondRanksResponse;
        }
    }
}
