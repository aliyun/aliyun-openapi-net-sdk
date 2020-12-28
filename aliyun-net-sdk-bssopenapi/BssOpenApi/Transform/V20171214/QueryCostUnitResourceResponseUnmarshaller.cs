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
using Aliyun.Acs.BssOpenApi.Model.V20171214;

namespace Aliyun.Acs.BssOpenApi.Transform.V20171214
{
    public class QueryCostUnitResourceResponseUnmarshaller
    {
        public static QueryCostUnitResourceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryCostUnitResourceResponse queryCostUnitResourceResponse = new QueryCostUnitResourceResponse();

			queryCostUnitResourceResponse.HttpResponse = _ctx.HttpResponse;
			queryCostUnitResourceResponse.RequestId = _ctx.StringValue("QueryCostUnitResource.RequestId");
			queryCostUnitResourceResponse.Message = _ctx.StringValue("QueryCostUnitResource.Message");
			queryCostUnitResourceResponse.Code = _ctx.StringValue("QueryCostUnitResource.Code");
			queryCostUnitResourceResponse.Success = _ctx.BooleanValue("QueryCostUnitResource.Success");

			QueryCostUnitResourceResponse.QueryCostUnitResource_Data data = new QueryCostUnitResourceResponse.QueryCostUnitResource_Data();
			data.TotalCount = _ctx.IntegerValue("QueryCostUnitResource.Data.TotalCount");
			data.PageSize = _ctx.IntegerValue("QueryCostUnitResource.Data.PageSize");
			data.PageNum = _ctx.IntegerValue("QueryCostUnitResource.Data.PageNum");

			QueryCostUnitResourceResponse.QueryCostUnitResource_Data.QueryCostUnitResource_CostUnit costUnit = new QueryCostUnitResourceResponse.QueryCostUnitResource_Data.QueryCostUnitResource_CostUnit();
			costUnit.UnitId = _ctx.LongValue("QueryCostUnitResource.Data.CostUnit.UnitId");
			costUnit.ParentUnitId = _ctx.LongValue("QueryCostUnitResource.Data.CostUnit.ParentUnitId");
			costUnit.OwnerUid = _ctx.LongValue("QueryCostUnitResource.Data.CostUnit.OwnerUid");
			costUnit.UnitName = _ctx.StringValue("QueryCostUnitResource.Data.CostUnit.UnitName");
			data.CostUnit = costUnit;

			QueryCostUnitResourceResponse.QueryCostUnitResource_Data.QueryCostUnitResource_CostUnitStatisInfo costUnitStatisInfo = new QueryCostUnitResourceResponse.QueryCostUnitResource_Data.QueryCostUnitResource_CostUnitStatisInfo();
			costUnitStatisInfo.SubUnitCount = _ctx.LongValue("QueryCostUnitResource.Data.CostUnitStatisInfo.SubUnitCount");
			costUnitStatisInfo.TotalResourceGroupCount = _ctx.LongValue("QueryCostUnitResource.Data.CostUnitStatisInfo.TotalResourceGroupCount");
			costUnitStatisInfo.TotalResourceCount = _ctx.LongValue("QueryCostUnitResource.Data.CostUnitStatisInfo.TotalResourceCount");
			costUnitStatisInfo.UserCount = _ctx.LongValue("QueryCostUnitResource.Data.CostUnitStatisInfo.UserCount");
			costUnitStatisInfo.ResourceCount = _ctx.LongValue("QueryCostUnitResource.Data.CostUnitStatisInfo.ResourceCount");
			costUnitStatisInfo.TotalUserCount = _ctx.LongValue("QueryCostUnitResource.Data.CostUnitStatisInfo.TotalUserCount");
			costUnitStatisInfo.ResourceGroupCount = _ctx.LongValue("QueryCostUnitResource.Data.CostUnitStatisInfo.ResourceGroupCount");
			data.CostUnitStatisInfo = costUnitStatisInfo;

			List<QueryCostUnitResourceResponse.QueryCostUnitResource_Data.QueryCostUnitResource_ResourceInstanceList> data_resourceInstanceDtoList = new List<QueryCostUnitResourceResponse.QueryCostUnitResource_Data.QueryCostUnitResource_ResourceInstanceList>();
			for (int i = 0; i < _ctx.Length("QueryCostUnitResource.Data.ResourceInstanceDtoList.Length"); i++) {
				QueryCostUnitResourceResponse.QueryCostUnitResource_Data.QueryCostUnitResource_ResourceInstanceList resourceInstanceList = new QueryCostUnitResourceResponse.QueryCostUnitResource_Data.QueryCostUnitResource_ResourceInstanceList();
				resourceInstanceList.ResourceUserId = _ctx.LongValue("QueryCostUnitResource.Data.ResourceInstanceDtoList["+ i +"].ResourceUserId");
				resourceInstanceList.ResourceTag = _ctx.StringValue("QueryCostUnitResource.Data.ResourceInstanceDtoList["+ i +"].ResourceTag");
				resourceInstanceList.RelatedResources = _ctx.StringValue("QueryCostUnitResource.Data.ResourceInstanceDtoList["+ i +"].RelatedResources");
				resourceInstanceList.ApportionName = _ctx.StringValue("QueryCostUnitResource.Data.ResourceInstanceDtoList["+ i +"].ApportionName");
				resourceInstanceList.ResourceId = _ctx.StringValue("QueryCostUnitResource.Data.ResourceInstanceDtoList["+ i +"].ResourceId");
				resourceInstanceList.CommodityCode = _ctx.StringValue("QueryCostUnitResource.Data.ResourceInstanceDtoList["+ i +"].CommodityCode");
				resourceInstanceList.ResourceStatus = _ctx.StringValue("QueryCostUnitResource.Data.ResourceInstanceDtoList["+ i +"].ResourceStatus");
				resourceInstanceList.ResourceType = _ctx.StringValue("QueryCostUnitResource.Data.ResourceInstanceDtoList["+ i +"].ResourceType");
				resourceInstanceList.ResourceUserName = _ctx.StringValue("QueryCostUnitResource.Data.ResourceInstanceDtoList["+ i +"].ResourceUserName");
				resourceInstanceList.ResourceNick = _ctx.StringValue("QueryCostUnitResource.Data.ResourceInstanceDtoList["+ i +"].ResourceNick");
				resourceInstanceList.ResourceGroup = _ctx.StringValue("QueryCostUnitResource.Data.ResourceInstanceDtoList["+ i +"].ResourceGroup");
				resourceInstanceList.CommodityName = _ctx.StringValue("QueryCostUnitResource.Data.ResourceInstanceDtoList["+ i +"].CommodityName");
				resourceInstanceList.ApportionCode = _ctx.StringValue("QueryCostUnitResource.Data.ResourceInstanceDtoList["+ i +"].ApportionCode");

				data_resourceInstanceDtoList.Add(resourceInstanceList);
			}
			data.ResourceInstanceDtoList = data_resourceInstanceDtoList;
			queryCostUnitResourceResponse.Data = data;
        
			return queryCostUnitResourceResponse;
        }
    }
}
