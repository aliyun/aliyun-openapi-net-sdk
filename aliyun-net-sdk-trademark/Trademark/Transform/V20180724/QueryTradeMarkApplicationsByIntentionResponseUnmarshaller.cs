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
using Aliyun.Acs.Trademark.Model.V20180724;

namespace Aliyun.Acs.Trademark.Transform.V20180724
{
    public class QueryTradeMarkApplicationsByIntentionResponseUnmarshaller
    {
        public static QueryTradeMarkApplicationsByIntentionResponse Unmarshall(UnmarshallerContext context)
        {
			QueryTradeMarkApplicationsByIntentionResponse queryTradeMarkApplicationsByIntentionResponse = new QueryTradeMarkApplicationsByIntentionResponse();

			queryTradeMarkApplicationsByIntentionResponse.HttpResponse = context.HttpResponse;
			queryTradeMarkApplicationsByIntentionResponse.RequestId = context.StringValue("QueryTradeMarkApplicationsByIntention.RequestId");
			queryTradeMarkApplicationsByIntentionResponse.TotalItemNum = context.IntegerValue("QueryTradeMarkApplicationsByIntention.TotalItemNum");
			queryTradeMarkApplicationsByIntentionResponse.CurrentPageNum = context.IntegerValue("QueryTradeMarkApplicationsByIntention.CurrentPageNum");
			queryTradeMarkApplicationsByIntentionResponse.PageSize = context.IntegerValue("QueryTradeMarkApplicationsByIntention.PageSize");
			queryTradeMarkApplicationsByIntentionResponse.TotalPageNum = context.IntegerValue("QueryTradeMarkApplicationsByIntention.TotalPageNum");

			List<QueryTradeMarkApplicationsByIntentionResponse.QueryTradeMarkApplicationsByIntention_TmProduces> queryTradeMarkApplicationsByIntentionResponse_data = new List<QueryTradeMarkApplicationsByIntentionResponse.QueryTradeMarkApplicationsByIntention_TmProduces>();
			for (int i = 0; i < context.Length("QueryTradeMarkApplicationsByIntention.Data.Length"); i++) {
				QueryTradeMarkApplicationsByIntentionResponse.QueryTradeMarkApplicationsByIntention_TmProduces tmProduces = new QueryTradeMarkApplicationsByIntentionResponse.QueryTradeMarkApplicationsByIntention_TmProduces();
				tmProduces.BizId = context.StringValue("QueryTradeMarkApplicationsByIntention.Data["+ i +"].BizId");
				tmProduces.MaterialName = context.StringValue("QueryTradeMarkApplicationsByIntention.Data["+ i +"].MaterialName");
				tmProduces.TmIcon = context.StringValue("QueryTradeMarkApplicationsByIntention.Data["+ i +"].TmIcon");
				tmProduces.TmName = context.StringValue("QueryTradeMarkApplicationsByIntention.Data["+ i +"].TmName");
				tmProduces.TmNumber = context.StringValue("QueryTradeMarkApplicationsByIntention.Data["+ i +"].TmNumber");
				tmProduces.CreateTime = context.LongValue("QueryTradeMarkApplicationsByIntention.Data["+ i +"].CreateTime");
				tmProduces.Type = context.IntegerValue("QueryTradeMarkApplicationsByIntention.Data["+ i +"].Type");
				tmProduces.Status = context.IntegerValue("QueryTradeMarkApplicationsByIntention.Data["+ i +"].Status");
				tmProduces.OrderPrice = context.FloatValue("QueryTradeMarkApplicationsByIntention.Data["+ i +"].OrderPrice");
				tmProduces.MaterialId = context.StringValue("QueryTradeMarkApplicationsByIntention.Data["+ i +"].MaterialId");
				tmProduces.LoaUrl = context.StringValue("QueryTradeMarkApplicationsByIntention.Data["+ i +"].LoaUrl");
				tmProduces.Note = context.StringValue("QueryTradeMarkApplicationsByIntention.Data["+ i +"].Note");
				tmProduces.UpdateTime = context.LongValue("QueryTradeMarkApplicationsByIntention.Data["+ i +"].UpdateTime");
				tmProduces.SupplementStatus = context.IntegerValue("QueryTradeMarkApplicationsByIntention.Data["+ i +"].SupplementStatus");
				tmProduces.SupplementId = context.LongValue("QueryTradeMarkApplicationsByIntention.Data["+ i +"].SupplementId");
				tmProduces.TotalPrice = context.FloatValue("QueryTradeMarkApplicationsByIntention.Data["+ i +"].TotalPrice");
				tmProduces.ServicePrice = context.FloatValue("QueryTradeMarkApplicationsByIntention.Data["+ i +"].ServicePrice");

				QueryTradeMarkApplicationsByIntentionResponse.QueryTradeMarkApplicationsByIntention_TmProduces.QueryTradeMarkApplicationsByIntention_FirstClassification firstClassification = new QueryTradeMarkApplicationsByIntentionResponse.QueryTradeMarkApplicationsByIntention_TmProduces.QueryTradeMarkApplicationsByIntention_FirstClassification();
				firstClassification.ClassificationCode = context.StringValue("QueryTradeMarkApplicationsByIntention.Data["+ i +"].FirstClassification.ClassificationCode");
				firstClassification.ClassificationName = context.StringValue("QueryTradeMarkApplicationsByIntention.Data["+ i +"].FirstClassification.ClassificationName");
				tmProduces.FirstClassification = firstClassification;

				List<QueryTradeMarkApplicationsByIntentionResponse.QueryTradeMarkApplicationsByIntention_TmProduces.QueryTradeMarkApplicationsByIntention_ThirdClassifications> tmProduces_thirdClassification = new List<QueryTradeMarkApplicationsByIntentionResponse.QueryTradeMarkApplicationsByIntention_TmProduces.QueryTradeMarkApplicationsByIntention_ThirdClassifications>();
				for (int j = 0; j < context.Length("QueryTradeMarkApplicationsByIntention.Data["+ i +"].ThirdClassification.Length"); j++) {
					QueryTradeMarkApplicationsByIntentionResponse.QueryTradeMarkApplicationsByIntention_TmProduces.QueryTradeMarkApplicationsByIntention_ThirdClassifications thirdClassifications = new QueryTradeMarkApplicationsByIntentionResponse.QueryTradeMarkApplicationsByIntention_TmProduces.QueryTradeMarkApplicationsByIntention_ThirdClassifications();
					thirdClassifications.ClassificationCode = context.StringValue("QueryTradeMarkApplicationsByIntention.Data["+ i +"].ThirdClassification["+ j +"].ClassificationCode");
					thirdClassifications.ClassificationName = context.StringValue("QueryTradeMarkApplicationsByIntention.Data["+ i +"].ThirdClassification["+ j +"].ClassificationName");

					tmProduces_thirdClassification.Add(thirdClassifications);
				}
				tmProduces.ThirdClassification = tmProduces_thirdClassification;

				queryTradeMarkApplicationsByIntentionResponse_data.Add(tmProduces);
			}
			queryTradeMarkApplicationsByIntentionResponse.Data = queryTradeMarkApplicationsByIntentionResponse_data;
        
			return queryTradeMarkApplicationsByIntentionResponse;
        }
    }
}
