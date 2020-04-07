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
    public class GetRoiRankingResponseUnmarshaller
    {
        public static GetRoiRankingResponse Unmarshall(UnmarshallerContext context)
        {
			GetRoiRankingResponse getRoiRankingResponse = new GetRoiRankingResponse();

			getRoiRankingResponse.HttpResponse = context.HttpResponse;
			getRoiRankingResponse.Msg = context.StringValue("GetRoiRanking.Msg");
			getRoiRankingResponse.Success = context.BooleanValue("GetRoiRanking.Success");

			List<GetRoiRankingResponse.GetRoiRanking_RoiRankingItem> getRoiRankingResponse_roiRankingItems = new List<GetRoiRankingResponse.GetRoiRanking_RoiRankingItem>();
			for (int i = 0; i < context.Length("GetRoiRanking.RoiRankingItems.Length"); i++) {
				GetRoiRankingResponse.GetRoiRanking_RoiRankingItem roiRankingItem = new GetRoiRankingResponse.GetRoiRanking_RoiRankingItem();
				roiRankingItem.LocationName = context.StringValue("GetRoiRanking.RoiRankingItems["+ i +"].LocationName");
				roiRankingItem.VisitorNum = context.IntegerValue("GetRoiRanking.RoiRankingItems["+ i +"].VisitorNum");

				getRoiRankingResponse_roiRankingItems.Add(roiRankingItem);
			}
			getRoiRankingResponse.RoiRankingItems = getRoiRankingResponse_roiRankingItems;
        
			return getRoiRankingResponse;
        }
    }
}
