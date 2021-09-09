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
using Aliyun.Acs.companyreg.Model.V20200306;

namespace Aliyun.Acs.companyreg.Transform.V20200306
{
    public class QueryCommodityConfigResponseUnmarshaller
    {
        public static QueryCommodityConfigResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryCommodityConfigResponse queryCommodityConfigResponse = new QueryCommodityConfigResponse();

			queryCommodityConfigResponse.HttpResponse = _ctx.HttpResponse;
			queryCommodityConfigResponse.RequestId = _ctx.StringValue("QueryCommodityConfig.RequestId");

			QueryCommodityConfigResponse.QueryCommodityConfig_Data data = new QueryCommodityConfigResponse.QueryCommodityConfig_Data();
			data.ProductLine = _ctx.StringValue("QueryCommodityConfig.Data.ProductLine");
			data.CommodityCode = _ctx.StringValue("QueryCommodityConfig.Data.CommodityCode");
			data.Description = _ctx.StringValue("QueryCommodityConfig.Data.Description");
			data.StartingPrice = _ctx.StringValue("QueryCommodityConfig.Data.StartingPrice");
			data.Type = _ctx.IntegerValue("QueryCommodityConfig.Data.Type");
			data.IconUrl = _ctx.StringValue("QueryCommodityConfig.Data.IconUrl");
			data.ProtocolUrl = _ctx.StringValue("QueryCommodityConfig.Data.ProtocolUrl");

			List<QueryCommodityConfigResponse.QueryCommodityConfig_Data.QueryCommodityConfig_CommodityModulesItem> data_commodityModules = new List<QueryCommodityConfigResponse.QueryCommodityConfig_Data.QueryCommodityConfig_CommodityModulesItem>();
			for (int i = 0; i < _ctx.Length("QueryCommodityConfig.Data.CommodityModules.Length"); i++) {
				QueryCommodityConfigResponse.QueryCommodityConfig_Data.QueryCommodityConfig_CommodityModulesItem commodityModulesItem = new QueryCommodityConfigResponse.QueryCommodityConfig_Data.QueryCommodityConfig_CommodityModulesItem();
				commodityModulesItem.ModuleCode = _ctx.StringValue("QueryCommodityConfig.Data.CommodityModules["+ i +"].ModuleCode");
				commodityModulesItem.ModuleName = _ctx.StringValue("QueryCommodityConfig.Data.CommodityModules["+ i +"].ModuleName");
				commodityModulesItem.ModuleDescription = _ctx.StringValue("QueryCommodityConfig.Data.CommodityModules["+ i +"].ModuleDescription");
				commodityModulesItem.ModuleType = _ctx.StringValue("QueryCommodityConfig.Data.CommodityModules["+ i +"].ModuleType");
				commodityModulesItem.ModuleTip = _ctx.StringValue("QueryCommodityConfig.Data.CommodityModules["+ i +"].ModuleTip");
				commodityModulesItem.LxModuleCode = _ctx.StringValue("QueryCommodityConfig.Data.CommodityModules["+ i +"].LxModuleCode");
				commodityModulesItem.ModuleValue = _ctx.StringValue("QueryCommodityConfig.Data.CommodityModules["+ i +"].ModuleValue");
				commodityModulesItem.ModuleUrl = _ctx.StringValue("QueryCommodityConfig.Data.CommodityModules["+ i +"].ModuleUrl");
				commodityModulesItem.SortNumber = _ctx.IntegerValue("QueryCommodityConfig.Data.CommodityModules["+ i +"].SortNumber");

				data_commodityModules.Add(commodityModulesItem);
			}
			data.CommodityModules = data_commodityModules;
			queryCommodityConfigResponse.Data = data;
        
			return queryCommodityConfigResponse;
        }
    }
}
