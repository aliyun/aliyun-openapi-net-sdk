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
        public static QueryCostUnitResourceResponse Unmarshall(UnmarshallerContext context)
        {
			QueryCostUnitResourceResponse queryCostUnitResourceResponse = new QueryCostUnitResourceResponse();

			queryCostUnitResourceResponse.HttpResponse = context.HttpResponse;
			queryCostUnitResourceResponse.RequestId = context.StringValue("QueryCostUnitResource.RequestId");
			queryCostUnitResourceResponse.Success = context.BooleanValue("QueryCostUnitResource.Success");
			queryCostUnitResourceResponse.Code = context.StringValue("QueryCostUnitResource.Code");
			queryCostUnitResourceResponse.Message = context.StringValue("QueryCostUnitResource.Message");

			QueryCostUnitResourceResponse.QueryCostUnitResource_Data data = new QueryCostUnitResourceResponse.QueryCostUnitResource_Data();
			data.PageNum = context.IntegerValue("QueryCostUnitResource.Data.PageNum");
			data.PageSize = context.IntegerValue("QueryCostUnitResource.Data.PageSize");
			data.TotalCount = context.IntegerValue("QueryCostUnitResource.Data.TotalCount");

			QueryCostUnitResourceResponse.QueryCostUnitResource_Data.QueryCostUnitResource_CostUnit costUnit = new QueryCostUnitResourceResponse.QueryCostUnitResource_Data.QueryCostUnitResource_CostUnit();
			costUnit.OwnerUid = context.LongValue("QueryCostUnitResource.Data.CostUnit.OwnerUid");
			costUnit.ParentUnitId = context.LongValue("QueryCostUnitResource.Data.CostUnit.ParentUnitId");
			costUnit.UnitId = context.LongValue("QueryCostUnitResource.Data.CostUnit.UnitId");
			costUnit.UnitName = context.StringValue("QueryCostUnitResource.Data.CostUnit.UnitName");
			data.CostUnit = costUnit;

			QueryCostUnitResourceResponse.QueryCostUnitResource_Data.QueryCostUnitResource_CostUnitStatisInfo costUnitStatisInfo = new QueryCostUnitResourceResponse.QueryCostUnitResource_Data.QueryCostUnitResource_CostUnitStatisInfo();
			costUnitStatisInfo.ResourceCount = context.LongValue("QueryCostUnitResource.Data.CostUnitStatisInfo.ResourceCount");
			costUnitStatisInfo.ResourceGroupCount = context.LongValue("QueryCostUnitResource.Data.CostUnitStatisInfo.ResourceGroupCount");
			costUnitStatisInfo.SubUnitCount = context.LongValue("QueryCostUnitResource.Data.CostUnitStatisInfo.SubUnitCount");
			costUnitStatisInfo.UserCount = context.LongValue("QueryCostUnitResource.Data.CostUnitStatisInfo.UserCount");
			costUnitStatisInfo.TotalResourceCount = context.LongValue("QueryCostUnitResource.Data.CostUnitStatisInfo.TotalResourceCount");
			costUnitStatisInfo.TotalUserCount = context.LongValue("QueryCostUnitResource.Data.CostUnitStatisInfo.TotalUserCount");
			costUnitStatisInfo.TotalResourceGroupCount = context.LongValue("QueryCostUnitResource.Data.CostUnitStatisInfo.TotalResourceGroupCount");
			data.CostUnitStatisInfo = costUnitStatisInfo;

			List<QueryCostUnitResourceResponse.QueryCostUnitResource_Data.QueryCostUnitResource_ResourceInstanceList> data_resourceInstanceDtoList = new List<QueryCostUnitResourceResponse.QueryCostUnitResource_Data.QueryCostUnitResource_ResourceInstanceList>();
			for (int i = 0; i < context.Length("QueryCostUnitResource.Data.ResourceInstanceDtoList.Length"); i++) {
				QueryCostUnitResourceResponse.QueryCostUnitResource_Data.QueryCostUnitResource_ResourceInstanceList resourceInstanceList = new QueryCostUnitResourceResponse.QueryCostUnitResource_Data.QueryCostUnitResource_ResourceInstanceList();
				resourceInstanceList.ResourceUserId = context.LongValue("QueryCostUnitResource.Data.ResourceInstanceDtoList["+ i +"].ResourceUserId");
				resourceInstanceList.ResourceId = context.LongValue("QueryCostUnitResource.Data.ResourceInstanceDtoList["+ i +"].ResourceId");
				resourceInstanceList.CommodityCode = context.StringValue("QueryCostUnitResource.Data.ResourceInstanceDtoList["+ i +"].CommodityCode");
				resourceInstanceList.ResourceUserName = context.StringValue("QueryCostUnitResource.Data.ResourceInstanceDtoList["+ i +"].ResourceUserName");
				resourceInstanceList.CommodityName = context.StringValue("QueryCostUnitResource.Data.ResourceInstanceDtoList["+ i +"].CommodityName");
				resourceInstanceList.ResourceGroup = context.StringValue("QueryCostUnitResource.Data.ResourceInstanceDtoList["+ i +"].ResourceGroup");
				resourceInstanceList.ResourceTag = context.StringValue("QueryCostUnitResource.Data.ResourceInstanceDtoList["+ i +"].ResourceTag");
				resourceInstanceList.ResourceNick = context.StringValue("QueryCostUnitResource.Data.ResourceInstanceDtoList["+ i +"].ResourceNick");
				resourceInstanceList.ResourceType = context.StringValue("QueryCostUnitResource.Data.ResourceInstanceDtoList["+ i +"].ResourceType");
				resourceInstanceList.ResourceStatus = context.StringValue("QueryCostUnitResource.Data.ResourceInstanceDtoList["+ i +"].ResourceStatus");
				resourceInstanceList.RelatedResources = context.StringValue("QueryCostUnitResource.Data.ResourceInstanceDtoList["+ i +"].RelatedResources");
				resourceInstanceList.ApportionCode = context.StringValue("QueryCostUnitResource.Data.ResourceInstanceDtoList["+ i +"].ApportionCode");
				resourceInstanceList.ApportionName = context.StringValue("QueryCostUnitResource.Data.ResourceInstanceDtoList["+ i +"].ApportionName");

				data_resourceInstanceDtoList.Add(resourceInstanceList);
			}
			data.ResourceInstanceDtoList = data_resourceInstanceDtoList;
			queryCostUnitResourceResponse.Data = data;
        
			return queryCostUnitResourceResponse;
        }
    }
}
