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
using Aliyun.Acs.cloudesl.Model.V20200201;

namespace Aliyun.Acs.cloudesl.Transform.V20200201
{
    public class DescribePlanogramRailsResponseUnmarshaller
    {
        public static DescribePlanogramRailsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribePlanogramRailsResponse describePlanogramRailsResponse = new DescribePlanogramRailsResponse();

			describePlanogramRailsResponse.HttpResponse = _ctx.HttpResponse;
			describePlanogramRailsResponse.DynamicMessage = _ctx.StringValue("DescribePlanogramRails.DynamicMessage");
			describePlanogramRailsResponse.RequestId = _ctx.StringValue("DescribePlanogramRails.RequestId");
			describePlanogramRailsResponse.Success = _ctx.BooleanValue("DescribePlanogramRails.Success");
			describePlanogramRailsResponse.ErrorMessage = _ctx.StringValue("DescribePlanogramRails.ErrorMessage");
			describePlanogramRailsResponse.ErrorCode = _ctx.StringValue("DescribePlanogramRails.ErrorCode");
			describePlanogramRailsResponse.Message = _ctx.StringValue("DescribePlanogramRails.Message");
			describePlanogramRailsResponse.PageNumber = _ctx.IntegerValue("DescribePlanogramRails.PageNumber");
			describePlanogramRailsResponse.DynamicCode = _ctx.StringValue("DescribePlanogramRails.DynamicCode");
			describePlanogramRailsResponse.StoreId = _ctx.StringValue("DescribePlanogramRails.StoreId");
			describePlanogramRailsResponse.TotalCount = _ctx.IntegerValue("DescribePlanogramRails.TotalCount");
			describePlanogramRailsResponse.Code = _ctx.StringValue("DescribePlanogramRails.Code");
			describePlanogramRailsResponse.PageSize = _ctx.IntegerValue("DescribePlanogramRails.PageSize");

			List<DescribePlanogramRailsResponse.DescribePlanogramRails_PlanogramRailInfo> describePlanogramRailsResponse_planogramRailInfos = new List<DescribePlanogramRailsResponse.DescribePlanogramRails_PlanogramRailInfo>();
			for (int i = 0; i < _ctx.Length("DescribePlanogramRails.PlanogramRailInfos.Length"); i++) {
				DescribePlanogramRailsResponse.DescribePlanogramRails_PlanogramRailInfo planogramRailInfo = new DescribePlanogramRailsResponse.DescribePlanogramRails_PlanogramRailInfo();
				planogramRailInfo.Shelf = _ctx.StringValue("DescribePlanogramRails.PlanogramRailInfos["+ i +"].Shelf");
				planogramRailInfo.RailCode = _ctx.StringValue("DescribePlanogramRails.PlanogramRailInfos["+ i +"].RailCode");
				planogramRailInfo.Layer = _ctx.IntegerValue("DescribePlanogramRails.PlanogramRailInfos["+ i +"].Layer");
				planogramRailInfo.GapUnit = _ctx.IntegerValue("DescribePlanogramRails.PlanogramRailInfos["+ i +"].GapUnit");

				describePlanogramRailsResponse_planogramRailInfos.Add(planogramRailInfo);
			}
			describePlanogramRailsResponse.PlanogramRailInfos = describePlanogramRailsResponse_planogramRailInfos;
        
			return describePlanogramRailsResponse;
        }
    }
}
