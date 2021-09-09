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
using Aliyun.Acs.companyreg.Model.V20190508;

namespace Aliyun.Acs.companyreg.Transform.V20190508
{
    public class QueryBookkeepingCommoditiesResponseUnmarshaller
    {
        public static QueryBookkeepingCommoditiesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryBookkeepingCommoditiesResponse queryBookkeepingCommoditiesResponse = new QueryBookkeepingCommoditiesResponse();

			queryBookkeepingCommoditiesResponse.HttpResponse = _ctx.HttpResponse;
			queryBookkeepingCommoditiesResponse.RequestId = _ctx.StringValue("QueryBookkeepingCommodities.RequestId");

			List<QueryBookkeepingCommoditiesResponse.QueryBookkeepingCommodities_BookkeepingCommodity> queryBookkeepingCommoditiesResponse_data = new List<QueryBookkeepingCommoditiesResponse.QueryBookkeepingCommodities_BookkeepingCommodity>();
			for (int i = 0; i < _ctx.Length("QueryBookkeepingCommodities.Data.Length"); i++) {
				QueryBookkeepingCommoditiesResponse.QueryBookkeepingCommodities_BookkeepingCommodity bookkeepingCommodity = new QueryBookkeepingCommoditiesResponse.QueryBookkeepingCommodities_BookkeepingCommodity();
				bookkeepingCommodity.TopOrgCode = _ctx.StringValue("QueryBookkeepingCommodities.Data["+ i +"].TopOrgCode");
				bookkeepingCommodity.CommodityCode = _ctx.StringValue("QueryBookkeepingCommodities.Data["+ i +"].CommodityCode");
				bookkeepingCommodity.CommodityName = _ctx.StringValue("QueryBookkeepingCommodities.Data["+ i +"].CommodityName");
				bookkeepingCommodity.SpecCode = _ctx.StringValue("QueryBookkeepingCommodities.Data["+ i +"].SpecCode");
				bookkeepingCommodity.PackageVersionCode = _ctx.StringValue("QueryBookkeepingCommodities.Data["+ i +"].PackageVersionCode");
				bookkeepingCommodity.PackageVersionValue = _ctx.StringValue("QueryBookkeepingCommodities.Data["+ i +"].PackageVersionValue");
				bookkeepingCommodity.PackageVersionName = _ctx.StringValue("QueryBookkeepingCommodities.Data["+ i +"].PackageVersionName");
				bookkeepingCommodity.CityModuleCode = _ctx.StringValue("QueryBookkeepingCommodities.Data["+ i +"].CityModuleCode");
				bookkeepingCommodity.CityModuleValue = _ctx.StringValue("QueryBookkeepingCommodities.Data["+ i +"].CityModuleValue");
				bookkeepingCommodity.CityModuleName = _ctx.StringValue("QueryBookkeepingCommodities.Data["+ i +"].CityModuleName");
				bookkeepingCommodity.OrdTimeCode = _ctx.StringValue("QueryBookkeepingCommodities.Data["+ i +"].OrdTimeCode");
				bookkeepingCommodity.OrdTimeValue = _ctx.StringValue("QueryBookkeepingCommodities.Data["+ i +"].OrdTimeValue");
				bookkeepingCommodity.OrdTimeName = _ctx.StringValue("QueryBookkeepingCommodities.Data["+ i +"].OrdTimeName");
				bookkeepingCommodity.TopOrgName = _ctx.StringValue("QueryBookkeepingCommodities.Data["+ i +"].TopOrgName");
				bookkeepingCommodity.ServiceModuleCode = _ctx.StringValue("QueryBookkeepingCommodities.Data["+ i +"].ServiceModuleCode");
				bookkeepingCommodity.ServiceModuleValue = _ctx.StringValue("QueryBookkeepingCommodities.Data["+ i +"].ServiceModuleValue");
				bookkeepingCommodity.ServiceModuleName = _ctx.StringValue("QueryBookkeepingCommodities.Data["+ i +"].ServiceModuleName");
				bookkeepingCommodity.AreaType = _ctx.StringValue("QueryBookkeepingCommodities.Data["+ i +"].AreaType");

				queryBookkeepingCommoditiesResponse_data.Add(bookkeepingCommodity);
			}
			queryBookkeepingCommoditiesResponse.Data = queryBookkeepingCommoditiesResponse_data;
        
			return queryBookkeepingCommoditiesResponse;
        }
    }
}
