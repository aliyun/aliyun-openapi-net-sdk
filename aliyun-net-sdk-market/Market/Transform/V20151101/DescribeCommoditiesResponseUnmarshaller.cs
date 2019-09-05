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
using Aliyun.Acs.Market.Model.V20151101;

namespace Aliyun.Acs.Market.Transform.V20151101
{
    public class DescribeCommoditiesResponseUnmarshaller
    {
        public static DescribeCommoditiesResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeCommoditiesResponse describeCommoditiesResponse = new DescribeCommoditiesResponse();

			describeCommoditiesResponse.HttpResponse = context.HttpResponse;
			describeCommoditiesResponse.RequestId = context.StringValue("DescribeCommodities.RequestId");
			describeCommoditiesResponse.Success = context.BooleanValue("DescribeCommodities.Success");

			DescribeCommoditiesResponse.DescribeCommodities_Data data = new DescribeCommoditiesResponse.DescribeCommodities_Data();
			data.TotalCount = context.LongValue("DescribeCommodities.Data.TotalCount");

			DescribeCommoditiesResponse.DescribeCommodities_Data.DescribeCommodities_Pageable pageable = new DescribeCommoditiesResponse.DescribeCommodities_Data.DescribeCommodities_Pageable();
			pageable.PageNumber = context.IntegerValue("DescribeCommodities.Data.Pageable.PageNumber");
			pageable.PageSize = context.IntegerValue("DescribeCommodities.Data.Pageable.PageSize");
			data.Pageable = pageable;

			List<DescribeCommoditiesResponse.DescribeCommodities_Data.DescribeCommodities_Commodity> data_commodities = new List<DescribeCommoditiesResponse.DescribeCommodities_Data.DescribeCommodities_Commodity>();
			for (int i = 0; i < context.Length("DescribeCommodities.Data.Commodities.Length"); i++) {
				DescribeCommoditiesResponse.DescribeCommodities_Data.DescribeCommodities_Commodity commodity = new DescribeCommoditiesResponse.DescribeCommodities_Data.DescribeCommodities_Commodity();
				commodity.CommodityId = context.StringValue("DescribeCommodities.Data.Commodities["+ i +"].CommodityId");
				commodity.Properties = context.StringValue("DescribeCommodities.Data.Commodities["+ i +"].Properties");
				commodity.ApplicationId = context.StringValue("DescribeCommodities.Data.Commodities["+ i +"].ApplicationId");

				data_commodities.Add(commodity);
			}
			data.Commodities = data_commodities;
			describeCommoditiesResponse.Data = data;
        
			return describeCommoditiesResponse;
        }
    }
}
