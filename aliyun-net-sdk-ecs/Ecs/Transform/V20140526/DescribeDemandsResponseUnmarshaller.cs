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
using Aliyun.Acs.Ecs.Model.V20140526;

namespace Aliyun.Acs.Ecs.Transform.V20140526
{
    public class DescribeDemandsResponseUnmarshaller
    {
        public static DescribeDemandsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeDemandsResponse describeDemandsResponse = new DescribeDemandsResponse();

			describeDemandsResponse.HttpResponse = context.HttpResponse;
			describeDemandsResponse.RequestId = context.StringValue("DescribeDemands.RequestId");
			describeDemandsResponse.TotalCount = context.IntegerValue("DescribeDemands.TotalCount");
			describeDemandsResponse.PageNumber = context.IntegerValue("DescribeDemands.PageNumber");
			describeDemandsResponse.PageSize = context.IntegerValue("DescribeDemands.PageSize");
			describeDemandsResponse.RegionId = context.StringValue("DescribeDemands.RegionId");

			List<DescribeDemandsResponse.DescribeDemands_Demand> describeDemandsResponse_demands = new List<DescribeDemandsResponse.DescribeDemands_Demand>();
			for (int i = 0; i < context.Length("DescribeDemands.Demands.Length"); i++) {
				DescribeDemandsResponse.DescribeDemands_Demand demand = new DescribeDemandsResponse.DescribeDemands_Demand();
				demand.ZoneId = context.StringValue("DescribeDemands.Demands["+ i +"].ZoneId");
				demand.DemandTime = context.StringValue("DescribeDemands.Demands["+ i +"].DemandTime");
				demand.InstanceTypeFamily = context.StringValue("DescribeDemands.Demands["+ i +"].InstanceTypeFamily");
				demand.DemandId = context.StringValue("DescribeDemands.Demands["+ i +"].DemandId");
				demand.DemandName = context.StringValue("DescribeDemands.Demands["+ i +"].DemandName");
				demand.Comment = context.StringValue("DescribeDemands.Demands["+ i +"].Comment");
				demand.DemandDescription = context.StringValue("DescribeDemands.Demands["+ i +"].DemandDescription");
				demand.InstanceType = context.StringValue("DescribeDemands.Demands["+ i +"].InstanceType");
				demand.InstanceChargeType = context.StringValue("DescribeDemands.Demands["+ i +"].InstanceChargeType");
				demand.Period = context.IntegerValue("DescribeDemands.Demands["+ i +"].Period");
				demand.PeriodUnit = context.StringValue("DescribeDemands.Demands["+ i +"].PeriodUnit");
				demand.StartTime = context.StringValue("DescribeDemands.Demands["+ i +"].StartTime");
				demand.EndTime = context.StringValue("DescribeDemands.Demands["+ i +"].EndTime");
				demand.DemandStatus = context.StringValue("DescribeDemands.Demands["+ i +"].DemandStatus");
				demand.TotalAmount = context.IntegerValue("DescribeDemands.Demands["+ i +"].TotalAmount");
				demand.AvailableAmount = context.IntegerValue("DescribeDemands.Demands["+ i +"].AvailableAmount");
				demand.UsedAmount = context.IntegerValue("DescribeDemands.Demands["+ i +"].UsedAmount");
				demand.DeliveringAmount = context.IntegerValue("DescribeDemands.Demands["+ i +"].DeliveringAmount");

				List<DescribeDemandsResponse.DescribeDemands_Demand.DescribeDemands_SupplyInfo> demand_supplyInfos = new List<DescribeDemandsResponse.DescribeDemands_Demand.DescribeDemands_SupplyInfo>();
				for (int j = 0; j < context.Length("DescribeDemands.Demands["+ i +"].SupplyInfos.Length"); j++) {
					DescribeDemandsResponse.DescribeDemands_Demand.DescribeDemands_SupplyInfo supplyInfo = new DescribeDemandsResponse.DescribeDemands_Demand.DescribeDemands_SupplyInfo();
					supplyInfo.Amount = context.IntegerValue("DescribeDemands.Demands["+ i +"].SupplyInfos["+ j +"].Amount");
					supplyInfo.SupplyStatus = context.StringValue("DescribeDemands.Demands["+ i +"].SupplyInfos["+ j +"].SupplyStatus");
					supplyInfo.SupplyStartTime = context.StringValue("DescribeDemands.Demands["+ i +"].SupplyInfos["+ j +"].SupplyStartTime");
					supplyInfo.SupplyEndTime = context.StringValue("DescribeDemands.Demands["+ i +"].SupplyInfos["+ j +"].SupplyEndTime");

					demand_supplyInfos.Add(supplyInfo);
				}
				demand.SupplyInfos = demand_supplyInfos;

				describeDemandsResponse_demands.Add(demand);
			}
			describeDemandsResponse.Demands = describeDemandsResponse_demands;
        
			return describeDemandsResponse;
        }
    }
}
