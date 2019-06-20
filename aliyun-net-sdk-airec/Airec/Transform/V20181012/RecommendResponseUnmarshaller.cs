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
using Aliyun.Acs.Airec.Model.V20181012;

namespace Aliyun.Acs.Airec.Transform.V20181012
{
    public class RecommendResponseUnmarshaller
    {
        public static RecommendResponse Unmarshall(UnmarshallerContext context)
        {
			RecommendResponse recommendResponse = new RecommendResponse();

			recommendResponse.HttpResponse = context.HttpResponse;
			recommendResponse.RequestId = context.StringValue("Recommend.RequestId");
			recommendResponse.Code = context.StringValue("Recommend.Code");
			recommendResponse.Message = context.StringValue("Recommend.Message");

			List<RecommendResponse.Recommend_ResultItem> recommendResponse_result = new List<RecommendResponse.Recommend_ResultItem>();
			for (int i = 0; i < context.Length("Recommend.Result.Length"); i++) {
				RecommendResponse.Recommend_ResultItem resultItem = new RecommendResponse.Recommend_ResultItem();
				resultItem.TraceId = context.StringValue("Recommend.Result["+ i +"].TraceId");
				resultItem.ItemId = context.StringValue("Recommend.Result["+ i +"].ItemId");
				resultItem.ItemType = context.StringValue("Recommend.Result["+ i +"].ItemType");
				resultItem.MatchInfo = context.StringValue("Recommend.Result["+ i +"].MatchInfo");
				resultItem.Weight = context.FloatValue("Recommend.Result["+ i +"].Weight");
				resultItem.Position = context.IntegerValue("Recommend.Result["+ i +"].Position");
				resultItem.TraceInfo = context.StringValue("Recommend.Result["+ i +"].TraceInfo");

				recommendResponse_result.Add(resultItem);
			}
			recommendResponse.Result = recommendResponse_result;
        
			return recommendResponse;
        }
    }
}
