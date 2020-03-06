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
using Aliyun.Acs.cloudesl.Model.V20190801;

namespace Aliyun.Acs.cloudesl.Transform.V20190801
{
    public class DescribePlanogramRailsResponseUnmarshaller
    {
        public static DescribePlanogramRailsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribePlanogramRailsResponse describePlanogramRailsResponse = new DescribePlanogramRailsResponse();

			describePlanogramRailsResponse.HttpResponse = context.HttpResponse;
			describePlanogramRailsResponse.DynamicMessage = context.StringValue("DescribePlanogramRails.DynamicMessage");
			describePlanogramRailsResponse.RequestId = context.StringValue("DescribePlanogramRails.RequestId");
			describePlanogramRailsResponse.Success = context.BooleanValue("DescribePlanogramRails.Success");
			describePlanogramRailsResponse.ErrorMessage = context.StringValue("DescribePlanogramRails.ErrorMessage");
			describePlanogramRailsResponse.ErrorCode = context.StringValue("DescribePlanogramRails.ErrorCode");
			describePlanogramRailsResponse.Message = context.StringValue("DescribePlanogramRails.Message");
			describePlanogramRailsResponse.PageNumber = context.IntegerValue("DescribePlanogramRails.PageNumber");
			describePlanogramRailsResponse.DynamicCode = context.StringValue("DescribePlanogramRails.DynamicCode");
			describePlanogramRailsResponse.StoreId = context.StringValue("DescribePlanogramRails.StoreId");
			describePlanogramRailsResponse.TotalCount = context.IntegerValue("DescribePlanogramRails.TotalCount");
			describePlanogramRailsResponse.Code = context.StringValue("DescribePlanogramRails.Code");
			describePlanogramRailsResponse.PageSize = context.IntegerValue("DescribePlanogramRails.PageSize");

			List<DescribePlanogramRailsResponse.DescribePlanogramRails_PlanogramRailInfo> describePlanogramRailsResponse_planogramRailInfos = new List<DescribePlanogramRailsResponse.DescribePlanogramRails_PlanogramRailInfo>();
			for (int i = 0; i < context.Length("DescribePlanogramRails.PlanogramRailInfos.Length"); i++) {
				DescribePlanogramRailsResponse.DescribePlanogramRails_PlanogramRailInfo planogramRailInfo = new DescribePlanogramRailsResponse.DescribePlanogramRails_PlanogramRailInfo();
				planogramRailInfo.Shelf = context.StringValue("DescribePlanogramRails.PlanogramRailInfos["+ i +"].Shelf");
				planogramRailInfo.RailCode = context.StringValue("DescribePlanogramRails.PlanogramRailInfos["+ i +"].RailCode");
				planogramRailInfo.Layer = context.StringValue("DescribePlanogramRails.PlanogramRailInfos["+ i +"].Layer");
				planogramRailInfo.GapUnit = context.IntegerValue("DescribePlanogramRails.PlanogramRailInfos["+ i +"].GapUnit");

				describePlanogramRailsResponse_planogramRailInfos.Add(planogramRailInfo);
			}
			describePlanogramRailsResponse.PlanogramRailInfos = describePlanogramRailsResponse_planogramRailInfos;
        
			return describePlanogramRailsResponse;
        }
    }
}
