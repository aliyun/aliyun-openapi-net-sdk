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
    public class RecommendResponseUnmarshaller
    {
        public static RecommendResponse Unmarshall(UnmarshallerContext _ctx)
        {
			RecommendResponse recommendResponse = new RecommendResponse();

			recommendResponse.HttpResponse = _ctx.HttpResponse;
			recommendResponse.Code = _ctx.StringValue("Recommend.code");
			recommendResponse.Message = _ctx.StringValue("Recommend.message");
			recommendResponse.RequestId = _ctx.StringValue("Recommend.requestId");

			List<RecommendResponse.Recommend_ResultItem> recommendResponse_result = new List<RecommendResponse.Recommend_ResultItem>();
			for (int i = 0; i < _ctx.Length("Recommend.Result.Length"); i++) {
				RecommendResponse.Recommend_ResultItem resultItem = new RecommendResponse.Recommend_ResultItem();
				resultItem.ItemId = _ctx.StringValue("Recommend.Result["+ i +"].itemId");
				resultItem.ItemType = _ctx.StringValue("Recommend.Result["+ i +"].itemType");
				resultItem.MatchInfo = _ctx.StringValue("Recommend.Result["+ i +"].matchInfo");
				resultItem.Position = _ctx.IntegerValue("Recommend.Result["+ i +"].position");
				resultItem.TraceId = _ctx.StringValue("Recommend.Result["+ i +"].traceId");
				resultItem.TraceInfo = _ctx.StringValue("Recommend.Result["+ i +"].traceInfo");
				resultItem.Weight = _ctx.FloatValue("Recommend.Result["+ i +"].weight");

				recommendResponse_result.Add(resultItem);
			}
			recommendResponse.Result = recommendResponse_result;
        
			return recommendResponse;
        }
    }
}
