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
        public static DescribeDemandsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDemandsResponse describeDemandsResponse = new DescribeDemandsResponse();

			describeDemandsResponse.HttpResponse = _ctx.HttpResponse;
			describeDemandsResponse.RequestId = _ctx.StringValue("DescribeDemands.RequestId");
			describeDemandsResponse.TotalCount = _ctx.IntegerValue("DescribeDemands.TotalCount");
			describeDemandsResponse.PageNumber = _ctx.IntegerValue("DescribeDemands.PageNumber");
			describeDemandsResponse.PageSize = _ctx.IntegerValue("DescribeDemands.PageSize");
			describeDemandsResponse.RegionId = _ctx.StringValue("DescribeDemands.RegionId");

			List<DescribeDemandsResponse.DescribeDemands_Demand> describeDemandsResponse_demands = new List<DescribeDemandsResponse.DescribeDemands_Demand>();
			for (int i = 0; i < _ctx.Length("DescribeDemands.Demands.Length"); i++) {
				DescribeDemandsResponse.DescribeDemands_Demand demand = new DescribeDemandsResponse.DescribeDemands_Demand();
				demand.ZoneId = _ctx.StringValue("DescribeDemands.Demands["+ i +"].ZoneId");
				demand.DemandTime = _ctx.StringValue("DescribeDemands.Demands["+ i +"].DemandTime");
				demand.InstanceTypeFamily = _ctx.StringValue("DescribeDemands.Demands["+ i +"].InstanceTypeFamily");
				demand.DemandId = _ctx.StringValue("DescribeDemands.Demands["+ i +"].DemandId");
				demand.DemandName = _ctx.StringValue("DescribeDemands.Demands["+ i +"].DemandName");
				demand.Comment = _ctx.StringValue("DescribeDemands.Demands["+ i +"].Comment");
				demand.DemandDescription = _ctx.StringValue("DescribeDemands.Demands["+ i +"].DemandDescription");
				demand.InstanceType = _ctx.StringValue("DescribeDemands.Demands["+ i +"].InstanceType");
				demand.InstanceChargeType = _ctx.StringValue("DescribeDemands.Demands["+ i +"].InstanceChargeType");
				demand.Period = _ctx.IntegerValue("DescribeDemands.Demands["+ i +"].Period");
				demand.PeriodUnit = _ctx.StringValue("DescribeDemands.Demands["+ i +"].PeriodUnit");
				demand.StartTime = _ctx.StringValue("DescribeDemands.Demands["+ i +"].StartTime");
				demand.EndTime = _ctx.StringValue("DescribeDemands.Demands["+ i +"].EndTime");
				demand.DemandStatus = _ctx.StringValue("DescribeDemands.Demands["+ i +"].DemandStatus");
				demand.TotalAmount = _ctx.IntegerValue("DescribeDemands.Demands["+ i +"].TotalAmount");
				demand.AvailableAmount = _ctx.IntegerValue("DescribeDemands.Demands["+ i +"].AvailableAmount");
				demand.UsedAmount = _ctx.IntegerValue("DescribeDemands.Demands["+ i +"].UsedAmount");
				demand.DeliveringAmount = _ctx.IntegerValue("DescribeDemands.Demands["+ i +"].DeliveringAmount");

				List<DescribeDemandsResponse.DescribeDemands_Demand.DescribeDemands_SupplyInfo> demand_supplyInfos = new List<DescribeDemandsResponse.DescribeDemands_Demand.DescribeDemands_SupplyInfo>();
				for (int j = 0; j < _ctx.Length("DescribeDemands.Demands["+ i +"].SupplyInfos.Length"); j++) {
					DescribeDemandsResponse.DescribeDemands_Demand.DescribeDemands_SupplyInfo supplyInfo = new DescribeDemandsResponse.DescribeDemands_Demand.DescribeDemands_SupplyInfo();
					supplyInfo.Amount = _ctx.IntegerValue("DescribeDemands.Demands["+ i +"].SupplyInfos["+ j +"].Amount");
					supplyInfo.SupplyStatus = _ctx.StringValue("DescribeDemands.Demands["+ i +"].SupplyInfos["+ j +"].SupplyStatus");
					supplyInfo.SupplyStartTime = _ctx.StringValue("DescribeDemands.Demands["+ i +"].SupplyInfos["+ j +"].SupplyStartTime");
					supplyInfo.SupplyEndTime = _ctx.StringValue("DescribeDemands.Demands["+ i +"].SupplyInfos["+ j +"].SupplyEndTime");

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
