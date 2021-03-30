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
    public class ListRankingModelsResponseUnmarshaller
    {
        public static ListRankingModelsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListRankingModelsResponse listRankingModelsResponse = new ListRankingModelsResponse();

			listRankingModelsResponse.HttpResponse = _ctx.HttpResponse;
			listRankingModelsResponse.Code = _ctx.StringValue("ListRankingModels.code");
			listRankingModelsResponse.Message = _ctx.StringValue("ListRankingModels.message");
			listRankingModelsResponse.RequestId = _ctx.StringValue("ListRankingModels.requestId");

			List<ListRankingModelsResponse.ListRankingModels_ResultItem> listRankingModelsResponse_result = new List<ListRankingModelsResponse.ListRankingModels_ResultItem>();
			for (int i = 0; i < _ctx.Length("ListRankingModels.Result.Length"); i++) {
				ListRankingModelsResponse.ListRankingModels_ResultItem resultItem = new ListRankingModelsResponse.ListRankingModels_ResultItem();
				resultItem.GmtCreate = _ctx.StringValue("ListRankingModels.Result["+ i +"].gmtCreate");
				resultItem.GmtModified = _ctx.StringValue("ListRankingModels.Result["+ i +"].gmtModified");
				resultItem.Meta = _ctx.StringValue("ListRankingModels.Result["+ i +"].meta");
				resultItem.RankingModelId = _ctx.StringValue("ListRankingModels.Result["+ i +"].rankingModelId");

				listRankingModelsResponse_result.Add(resultItem);
			}
			listRankingModelsResponse.Result = listRankingModelsResponse_result;
        
			return listRankingModelsResponse;
        }
    }
}
