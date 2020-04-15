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
    public class QueryIntentionPriceResponseUnmarshaller
    {
        public static QueryIntentionPriceResponse Unmarshall(UnmarshallerContext context)
        {
			QueryIntentionPriceResponse queryIntentionPriceResponse = new QueryIntentionPriceResponse();

			queryIntentionPriceResponse.HttpResponse = context.HttpResponse;
			queryIntentionPriceResponse.RequestId = context.StringValue("QueryIntentionPrice.RequestId");
			queryIntentionPriceResponse.TotalItemNum = context.IntegerValue("QueryIntentionPrice.TotalItemNum");
			queryIntentionPriceResponse.CurrentPageNum = context.IntegerValue("QueryIntentionPrice.CurrentPageNum");
			queryIntentionPriceResponse.PageSize = context.IntegerValue("QueryIntentionPrice.PageSize");
			queryIntentionPriceResponse.TotalPageNum = context.IntegerValue("QueryIntentionPrice.TotalPageNum");

			List<QueryIntentionPriceResponse.QueryIntentionPrice_TmProduces> queryIntentionPriceResponse_data = new List<QueryIntentionPriceResponse.QueryIntentionPrice_TmProduces>();
			for (int i = 0; i < context.Length("QueryIntentionPrice.Data.Length"); i++) {
				QueryIntentionPriceResponse.QueryIntentionPrice_TmProduces tmProduces = new QueryIntentionPriceResponse.QueryIntentionPrice_TmProduces();
				tmProduces.BizId = context.StringValue("QueryIntentionPrice.Data["+ i +"].BizId");
				tmProduces.MaterialName = context.StringValue("QueryIntentionPrice.Data["+ i +"].MaterialName");
				tmProduces.TmIcon = context.StringValue("QueryIntentionPrice.Data["+ i +"].TmIcon");
				tmProduces.TmName = context.StringValue("QueryIntentionPrice.Data["+ i +"].TmName");
				tmProduces.TmNumber = context.StringValue("QueryIntentionPrice.Data["+ i +"].TmNumber");
				tmProduces.CreateTime = context.LongValue("QueryIntentionPrice.Data["+ i +"].CreateTime");
				tmProduces.Type = context.IntegerValue("QueryIntentionPrice.Data["+ i +"].Type");
				tmProduces.Status = context.IntegerValue("QueryIntentionPrice.Data["+ i +"].Status");
				tmProduces.OrderPrice = context.FloatValue("QueryIntentionPrice.Data["+ i +"].OrderPrice");
				tmProduces.MaterialId = context.StringValue("QueryIntentionPrice.Data["+ i +"].MaterialId");
				tmProduces.LoaUrl = context.StringValue("QueryIntentionPrice.Data["+ i +"].LoaUrl");
				tmProduces.Note = context.StringValue("QueryIntentionPrice.Data["+ i +"].Note");
				tmProduces.UpdateTime = context.LongValue("QueryIntentionPrice.Data["+ i +"].UpdateTime");
				tmProduces.SupplementStatus = context.IntegerValue("QueryIntentionPrice.Data["+ i +"].SupplementStatus");
				tmProduces.SupplementId = context.LongValue("QueryIntentionPrice.Data["+ i +"].SupplementId");
				tmProduces.TotalPrice = context.FloatValue("QueryIntentionPrice.Data["+ i +"].TotalPrice");
				tmProduces.ServicePrice = context.FloatValue("QueryIntentionPrice.Data["+ i +"].ServicePrice");

				QueryIntentionPriceResponse.QueryIntentionPrice_TmProduces.QueryIntentionPrice_FirstClassification firstClassification = new QueryIntentionPriceResponse.QueryIntentionPrice_TmProduces.QueryIntentionPrice_FirstClassification();
				firstClassification.ClassificationCode = context.StringValue("QueryIntentionPrice.Data["+ i +"].FirstClassification.ClassificationCode");
				firstClassification.ClassificationName = context.StringValue("QueryIntentionPrice.Data["+ i +"].FirstClassification.ClassificationName");
				tmProduces.FirstClassification = firstClassification;

				List<QueryIntentionPriceResponse.QueryIntentionPrice_TmProduces.QueryIntentionPrice_ThirdClassifications> tmProduces_thirdClassification = new List<QueryIntentionPriceResponse.QueryIntentionPrice_TmProduces.QueryIntentionPrice_ThirdClassifications>();
				for (int j = 0; j < context.Length("QueryIntentionPrice.Data["+ i +"].ThirdClassification.Length"); j++) {
					QueryIntentionPriceResponse.QueryIntentionPrice_TmProduces.QueryIntentionPrice_ThirdClassifications thirdClassifications = new QueryIntentionPriceResponse.QueryIntentionPrice_TmProduces.QueryIntentionPrice_ThirdClassifications();
					thirdClassifications.ClassificationCode = context.StringValue("QueryIntentionPrice.Data["+ i +"].ThirdClassification["+ j +"].ClassificationCode");
					thirdClassifications.ClassificationName = context.StringValue("QueryIntentionPrice.Data["+ i +"].ThirdClassification["+ j +"].ClassificationName");

					tmProduces_thirdClassification.Add(thirdClassifications);
				}
				tmProduces.ThirdClassification = tmProduces_thirdClassification;

				queryIntentionPriceResponse_data.Add(tmProduces);
			}
			queryIntentionPriceResponse.Data = queryIntentionPriceResponse_data;
        
			return queryIntentionPriceResponse;
        }
    }
}
