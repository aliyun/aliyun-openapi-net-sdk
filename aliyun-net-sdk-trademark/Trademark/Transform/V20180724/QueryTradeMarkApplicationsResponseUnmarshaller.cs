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
    public class QueryTradeMarkApplicationsResponseUnmarshaller
    {
        public static QueryTradeMarkApplicationsResponse Unmarshall(UnmarshallerContext context)
        {
			QueryTradeMarkApplicationsResponse queryTradeMarkApplicationsResponse = new QueryTradeMarkApplicationsResponse();

			queryTradeMarkApplicationsResponse.HttpResponse = context.HttpResponse;
			queryTradeMarkApplicationsResponse.RequestId = context.StringValue("QueryTradeMarkApplications.RequestId");
			queryTradeMarkApplicationsResponse.TotalItemNum = context.IntegerValue("QueryTradeMarkApplications.TotalItemNum");
			queryTradeMarkApplicationsResponse.CurrentPageNum = context.IntegerValue("QueryTradeMarkApplications.CurrentPageNum");
			queryTradeMarkApplicationsResponse.PageSize = context.IntegerValue("QueryTradeMarkApplications.PageSize");
			queryTradeMarkApplicationsResponse.TotalPageNum = context.IntegerValue("QueryTradeMarkApplications.TotalPageNum");

			List<QueryTradeMarkApplicationsResponse.QueryTradeMarkApplications_TmProduces> queryTradeMarkApplicationsResponse_data = new List<QueryTradeMarkApplicationsResponse.QueryTradeMarkApplications_TmProduces>();
			for (int i = 0; i < context.Length("QueryTradeMarkApplications.Data.Length"); i++) {
				QueryTradeMarkApplicationsResponse.QueryTradeMarkApplications_TmProduces tmProduces = new QueryTradeMarkApplicationsResponse.QueryTradeMarkApplications_TmProduces();
				tmProduces.BizId = context.StringValue("QueryTradeMarkApplications.Data["+ i +"].BizId");
				tmProduces.OrderId = context.StringValue("QueryTradeMarkApplications.Data["+ i +"].OrderId");
				tmProduces.MaterialName = context.StringValue("QueryTradeMarkApplications.Data["+ i +"].MaterialName");
				tmProduces.TmIcon = context.StringValue("QueryTradeMarkApplications.Data["+ i +"].TmIcon");
				tmProduces.TmName = context.StringValue("QueryTradeMarkApplications.Data["+ i +"].TmName");
				tmProduces.TmNumber = context.StringValue("QueryTradeMarkApplications.Data["+ i +"].TmNumber");
				tmProduces.CreateTime = context.LongValue("QueryTradeMarkApplications.Data["+ i +"].CreateTime");
				tmProduces.Type = context.IntegerValue("QueryTradeMarkApplications.Data["+ i +"].Type");
				tmProduces.Status = context.IntegerValue("QueryTradeMarkApplications.Data["+ i +"].Status");
				tmProduces.UserId = context.StringValue("QueryTradeMarkApplications.Data["+ i +"].UserId");
				tmProduces.OrderPrice = context.FloatValue("QueryTradeMarkApplications.Data["+ i +"].OrderPrice");
				tmProduces.MaterialId = context.LongValue("QueryTradeMarkApplications.Data["+ i +"].MaterialId");
				tmProduces.LoaUrl = context.StringValue("QueryTradeMarkApplications.Data["+ i +"].LoaUrl");
				tmProduces.Note = context.StringValue("QueryTradeMarkApplications.Data["+ i +"].Note");
				tmProduces.UpdateTime = context.LongValue("QueryTradeMarkApplications.Data["+ i +"].UpdateTime");
				tmProduces.SupplementStatus = context.IntegerValue("QueryTradeMarkApplications.Data["+ i +"].SupplementStatus");
				tmProduces.SupplementId = context.LongValue("QueryTradeMarkApplications.Data["+ i +"].SupplementId");
				tmProduces.TotalPrice = context.FloatValue("QueryTradeMarkApplications.Data["+ i +"].TotalPrice");
				tmProduces.ServicePrice = context.FloatValue("QueryTradeMarkApplications.Data["+ i +"].ServicePrice");

				List<string> tmProduces_flags = new List<string>();
				for (int j = 0; j < context.Length("QueryTradeMarkApplications.Data["+ i +"].Flags.Length"); j++) {
					tmProduces_flags.Add(context.StringValue("QueryTradeMarkApplications.Data["+ i +"].Flags["+ j +"]"));
				}
				tmProduces.Flags = tmProduces_flags;

				QueryTradeMarkApplicationsResponse.QueryTradeMarkApplications_TmProduces.QueryTradeMarkApplications_FirstClassification firstClassification = new QueryTradeMarkApplicationsResponse.QueryTradeMarkApplications_TmProduces.QueryTradeMarkApplications_FirstClassification();
				firstClassification.ClassificationCode = context.StringValue("QueryTradeMarkApplications.Data["+ i +"].FirstClassification.ClassificationCode");
				firstClassification.ClassificationName = context.StringValue("QueryTradeMarkApplications.Data["+ i +"].FirstClassification.ClassificationName");
				tmProduces.FirstClassification = firstClassification;

				QueryTradeMarkApplicationsResponse.QueryTradeMarkApplications_TmProduces.QueryTradeMarkApplications_RenewResponse renewResponse = new QueryTradeMarkApplicationsResponse.QueryTradeMarkApplications_TmProduces.QueryTradeMarkApplications_RenewResponse();
				renewResponse.Name = context.StringValue("QueryTradeMarkApplications.Data["+ i +"].RenewResponse.Name");
				renewResponse.EngName = context.StringValue("QueryTradeMarkApplications.Data["+ i +"].RenewResponse.EngName");
				renewResponse.Address = context.StringValue("QueryTradeMarkApplications.Data["+ i +"].RenewResponse.Address");
				renewResponse.EngAddress = context.StringValue("QueryTradeMarkApplications.Data["+ i +"].RenewResponse.EngAddress");
				renewResponse.RegisterTime = context.LongValue("QueryTradeMarkApplications.Data["+ i +"].RenewResponse.RegisterTime");
				renewResponse.SubmitSbjtime = context.LongValue("QueryTradeMarkApplications.Data["+ i +"].RenewResponse.SubmitSbjtime");
				tmProduces.RenewResponse = renewResponse;

				List<QueryTradeMarkApplicationsResponse.QueryTradeMarkApplications_TmProduces.QueryTradeMarkApplications_ThirdClassifications> tmProduces_thirdClassification = new List<QueryTradeMarkApplicationsResponse.QueryTradeMarkApplications_TmProduces.QueryTradeMarkApplications_ThirdClassifications>();
				for (int j = 0; j < context.Length("QueryTradeMarkApplications.Data["+ i +"].ThirdClassification.Length"); j++) {
					QueryTradeMarkApplicationsResponse.QueryTradeMarkApplications_TmProduces.QueryTradeMarkApplications_ThirdClassifications thirdClassifications = new QueryTradeMarkApplicationsResponse.QueryTradeMarkApplications_TmProduces.QueryTradeMarkApplications_ThirdClassifications();
					thirdClassifications.ClassificationCode = context.StringValue("QueryTradeMarkApplications.Data["+ i +"].ThirdClassification["+ j +"].ClassificationCode");
					thirdClassifications.ClassificationName = context.StringValue("QueryTradeMarkApplications.Data["+ i +"].ThirdClassification["+ j +"].ClassificationName");

					tmProduces_thirdClassification.Add(thirdClassifications);
				}
				tmProduces.ThirdClassification = tmProduces_thirdClassification;

				queryTradeMarkApplicationsResponse_data.Add(tmProduces);
			}
			queryTradeMarkApplicationsResponse.Data = queryTradeMarkApplicationsResponse_data;
        
			return queryTradeMarkApplicationsResponse;
        }
    }
}
