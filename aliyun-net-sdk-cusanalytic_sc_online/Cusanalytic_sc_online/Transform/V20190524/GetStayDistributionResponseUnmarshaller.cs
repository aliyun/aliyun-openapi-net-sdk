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
using Aliyun.Acs.cusanalytic_sc_online.Model.V20190524;

namespace Aliyun.Acs.cusanalytic_sc_online.Transform.V20190524
{
    public class GetStayDistributionResponseUnmarshaller
    {
        public static GetStayDistributionResponse Unmarshall(UnmarshallerContext context)
        {
			GetStayDistributionResponse getStayDistributionResponse = new GetStayDistributionResponse();

			getStayDistributionResponse.HttpResponse = context.HttpResponse;
			getStayDistributionResponse.StoreId = context.LongValue("GetStayDistribution.StoreId");
			getStayDistributionResponse.ErrorMsg = context.StringValue("GetStayDistribution.ErrorMsg");
			getStayDistributionResponse.LocationId = context.LongValue("GetStayDistribution.LocationId");
			getStayDistributionResponse.Success = context.BooleanValue("GetStayDistribution.Success");

			List<GetStayDistributionResponse.GetStayDistribution_StayDistributionItem> getStayDistributionResponse_stayDistributionItems = new List<GetStayDistributionResponse.GetStayDistribution_StayDistributionItem>();
			for (int i = 0; i < context.Length("GetStayDistribution.StayDistributionItems.Length"); i++) {
				GetStayDistributionResponse.GetStayDistribution_StayDistributionItem stayDistributionItem = new GetStayDistributionResponse.GetStayDistribution_StayDistributionItem();
				stayDistributionItem.EndTs = context.LongValue("GetStayDistribution.StayDistributionItems["+ i +"].EndTs");
				stayDistributionItem.Count = context.IntegerValue("GetStayDistribution.StayDistributionItems["+ i +"].Count");
				stayDistributionItem.StartTs = context.LongValue("GetStayDistribution.StayDistributionItems["+ i +"].StartTs");

				getStayDistributionResponse_stayDistributionItems.Add(stayDistributionItem);
			}
			getStayDistributionResponse.StayDistributionItems = getStayDistributionResponse_stayDistributionItems;
        
			return getStayDistributionResponse;
        }
    }
}
