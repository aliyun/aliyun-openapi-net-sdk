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
using Aliyun.Acs.aegis.Model.V20161111;

namespace Aliyun.Acs.aegis.Transform.V20161111
{
    public class DescribeStratetyDetailResponseUnmarshaller
    {
        public static DescribeStratetyDetailResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeStratetyDetailResponse describeStratetyDetailResponse = new DescribeStratetyDetailResponse();

			describeStratetyDetailResponse.HttpResponse = context.HttpResponse;
			describeStratetyDetailResponse.RequestId = context.StringValue("DescribeStratetyDetail.RequestId");

			DescribeStratetyDetailResponse.DescribeStratetyDetail_Strategy strategy = new DescribeStratetyDetailResponse.DescribeStratetyDetail_Strategy();
			strategy.CycleDays = context.IntegerValue("DescribeStratetyDetail.Strategy.CycleDays");
			strategy.Name = context.StringValue("DescribeStratetyDetail.Strategy.Name");
			strategy.Id = context.IntegerValue("DescribeStratetyDetail.Strategy.Id");
			strategy.CycleStartTime = context.IntegerValue("DescribeStratetyDetail.Strategy.CycleStartTime");
			strategy.Type = context.IntegerValue("DescribeStratetyDetail.Strategy.Type");

			List<DescribeStratetyDetailResponse.DescribeStratetyDetail_Strategy.DescribeStratetyDetail_RiskTypeWhiteListQueryResult> strategy_riskTypeWhiteListQueryResultList = new List<DescribeStratetyDetailResponse.DescribeStratetyDetail_Strategy.DescribeStratetyDetail_RiskTypeWhiteListQueryResult>();
			for (int i = 0; i < context.Length("DescribeStratetyDetail.Strategy.RiskTypeWhiteListQueryResultList.Length"); i++) {
				DescribeStratetyDetailResponse.DescribeStratetyDetail_Strategy.DescribeStratetyDetail_RiskTypeWhiteListQueryResult riskTypeWhiteListQueryResult = new DescribeStratetyDetailResponse.DescribeStratetyDetail_Strategy.DescribeStratetyDetail_RiskTypeWhiteListQueryResult();
				riskTypeWhiteListQueryResult.TypeName = context.StringValue("DescribeStratetyDetail.Strategy.RiskTypeWhiteListQueryResultList["+ i +"].TypeName");
				riskTypeWhiteListQueryResult.Alias = context.StringValue("DescribeStratetyDetail.Strategy.RiskTypeWhiteListQueryResultList["+ i +"].Alias");
				riskTypeWhiteListQueryResult.On = context.BooleanValue("DescribeStratetyDetail.Strategy.RiskTypeWhiteListQueryResultList["+ i +"].On");

				List<DescribeStratetyDetailResponse.DescribeStratetyDetail_Strategy.DescribeStratetyDetail_RiskTypeWhiteListQueryResult.DescribeStratetyDetail_SubType> riskTypeWhiteListQueryResult_subTypes = new List<DescribeStratetyDetailResponse.DescribeStratetyDetail_Strategy.DescribeStratetyDetail_RiskTypeWhiteListQueryResult.DescribeStratetyDetail_SubType>();
				for (int j = 0; j < context.Length("DescribeStratetyDetail.Strategy.RiskTypeWhiteListQueryResultList["+ i +"].SubTypes.Length"); j++) {
					DescribeStratetyDetailResponse.DescribeStratetyDetail_Strategy.DescribeStratetyDetail_RiskTypeWhiteListQueryResult.DescribeStratetyDetail_SubType subType = new DescribeStratetyDetailResponse.DescribeStratetyDetail_Strategy.DescribeStratetyDetail_RiskTypeWhiteListQueryResult.DescribeStratetyDetail_SubType();
					subType.TypeName = context.StringValue("DescribeStratetyDetail.Strategy.RiskTypeWhiteListQueryResultList["+ i +"].SubTypes["+ j +"].TypeName");
					subType.Alias = context.StringValue("DescribeStratetyDetail.Strategy.RiskTypeWhiteListQueryResultList["+ i +"].SubTypes["+ j +"].Alias");
					subType.On = context.BooleanValue("DescribeStratetyDetail.Strategy.RiskTypeWhiteListQueryResultList["+ i +"].SubTypes["+ j +"].On");

					riskTypeWhiteListQueryResult_subTypes.Add(subType);
				}
				riskTypeWhiteListQueryResult.SubTypes = riskTypeWhiteListQueryResult_subTypes;

				strategy_riskTypeWhiteListQueryResultList.Add(riskTypeWhiteListQueryResult);
			}
			strategy.RiskTypeWhiteListQueryResultList = strategy_riskTypeWhiteListQueryResultList;
			describeStratetyDetailResponse.Strategy = strategy;
        
			return describeStratetyDetailResponse;
        }
    }
}
