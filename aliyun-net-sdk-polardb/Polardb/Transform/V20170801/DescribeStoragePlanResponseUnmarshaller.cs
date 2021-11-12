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
using Aliyun.Acs.polardb.Model.V20170801;

namespace Aliyun.Acs.polardb.Transform.V20170801
{
    public class DescribeStoragePlanResponseUnmarshaller
    {
        public static DescribeStoragePlanResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeStoragePlanResponse describeStoragePlanResponse = new DescribeStoragePlanResponse();

			describeStoragePlanResponse.HttpResponse = _ctx.HttpResponse;
			describeStoragePlanResponse.RequestId = _ctx.StringValue("DescribeStoragePlan.RequestId");
			describeStoragePlanResponse.TotalRecordCount = _ctx.LongValue("DescribeStoragePlan.TotalRecordCount");
			describeStoragePlanResponse.PageSize = _ctx.LongValue("DescribeStoragePlan.PageSize");
			describeStoragePlanResponse.PageNumber = _ctx.LongValue("DescribeStoragePlan.PageNumber");

			List<DescribeStoragePlanResponse.DescribeStoragePlan_DescribeStoragePlanResponses> describeStoragePlanResponse_items = new List<DescribeStoragePlanResponse.DescribeStoragePlan_DescribeStoragePlanResponses>();
			for (int i = 0; i < _ctx.Length("DescribeStoragePlan.Items.Length"); i++) {
				DescribeStoragePlanResponse.DescribeStoragePlan_DescribeStoragePlanResponses describeStoragePlanResponses = new DescribeStoragePlanResponse.DescribeStoragePlan_DescribeStoragePlanResponses();
				describeStoragePlanResponses.ProdCode = _ctx.StringValue("DescribeStoragePlan.Items["+ i +"].ProdCode");
				describeStoragePlanResponses.AliUid = _ctx.StringValue("DescribeStoragePlan.Items["+ i +"].AliUid");
				describeStoragePlanResponses.CommodityCode = _ctx.StringValue("DescribeStoragePlan.Items["+ i +"].CommodityCode");
				describeStoragePlanResponses.TemplateName = _ctx.StringValue("DescribeStoragePlan.Items["+ i +"].TemplateName");
				describeStoragePlanResponses.StorageType = _ctx.StringValue("DescribeStoragePlan.Items["+ i +"].StorageType");
				describeStoragePlanResponses.Status = _ctx.StringValue("DescribeStoragePlan.Items["+ i +"].Status");
				describeStoragePlanResponses.StartTimes = _ctx.StringValue("DescribeStoragePlan.Items["+ i +"].StartTimes");
				describeStoragePlanResponses.EndTimes = _ctx.StringValue("DescribeStoragePlan.Items["+ i +"].EndTimes");
				describeStoragePlanResponses.PurchaseTimes = _ctx.StringValue("DescribeStoragePlan.Items["+ i +"].PurchaseTimes");
				describeStoragePlanResponses.InstanceId = _ctx.StringValue("DescribeStoragePlan.Items["+ i +"].InstanceId");
				describeStoragePlanResponses.InitCapacityViewValue = _ctx.StringValue("DescribeStoragePlan.Items["+ i +"].InitCapacityViewValue");
				describeStoragePlanResponses.InitCapaCityViewUnit = _ctx.StringValue("DescribeStoragePlan.Items["+ i +"].InitCapaCityViewUnit");
				describeStoragePlanResponses.PeriodCapacityViewValue = _ctx.StringValue("DescribeStoragePlan.Items["+ i +"].PeriodCapacityViewValue");
				describeStoragePlanResponses.PeriodCapaCityViewUnit = _ctx.StringValue("DescribeStoragePlan.Items["+ i +"].PeriodCapaCityViewUnit");
				describeStoragePlanResponses.PeriodTime = _ctx.StringValue("DescribeStoragePlan.Items["+ i +"].PeriodTime");

				describeStoragePlanResponse_items.Add(describeStoragePlanResponses);
			}
			describeStoragePlanResponse.Items = describeStoragePlanResponse_items;
        
			return describeStoragePlanResponse;
        }
    }
}
