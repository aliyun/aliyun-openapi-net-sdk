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
    public class DescribeDeploymentSetsResponseUnmarshaller
    {
        public static DescribeDeploymentSetsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDeploymentSetsResponse describeDeploymentSetsResponse = new DescribeDeploymentSetsResponse();

			describeDeploymentSetsResponse.HttpResponse = _ctx.HttpResponse;
			describeDeploymentSetsResponse.PageSize = _ctx.IntegerValue("DescribeDeploymentSets.PageSize");
			describeDeploymentSetsResponse.PageNumber = _ctx.IntegerValue("DescribeDeploymentSets.PageNumber");
			describeDeploymentSetsResponse.RequestId = _ctx.StringValue("DescribeDeploymentSets.RequestId");
			describeDeploymentSetsResponse.TotalCount = _ctx.IntegerValue("DescribeDeploymentSets.TotalCount");
			describeDeploymentSetsResponse.RegionId = _ctx.StringValue("DescribeDeploymentSets.RegionId");

			List<DescribeDeploymentSetsResponse.DescribeDeploymentSets_DeploymentSet> describeDeploymentSetsResponse_deploymentSets = new List<DescribeDeploymentSetsResponse.DescribeDeploymentSets_DeploymentSet>();
			for (int i = 0; i < _ctx.Length("DescribeDeploymentSets.DeploymentSets.Length"); i++) {
				DescribeDeploymentSetsResponse.DescribeDeploymentSets_DeploymentSet deploymentSet = new DescribeDeploymentSetsResponse.DescribeDeploymentSets_DeploymentSet();
				deploymentSet.CreationTime = _ctx.StringValue("DescribeDeploymentSets.DeploymentSets["+ i +"].CreationTime");
				deploymentSet.Strategy = _ctx.StringValue("DescribeDeploymentSets.DeploymentSets["+ i +"].Strategy");
				deploymentSet.DeploymentSetId = _ctx.StringValue("DescribeDeploymentSets.DeploymentSets["+ i +"].DeploymentSetId");
				deploymentSet.DeploymentStrategy = _ctx.StringValue("DescribeDeploymentSets.DeploymentSets["+ i +"].DeploymentStrategy");
				deploymentSet.DeploymentSetDescription = _ctx.StringValue("DescribeDeploymentSets.DeploymentSets["+ i +"].DeploymentSetDescription");
				deploymentSet.Domain = _ctx.StringValue("DescribeDeploymentSets.DeploymentSets["+ i +"].Domain");
				deploymentSet.GroupCount = _ctx.IntegerValue("DescribeDeploymentSets.DeploymentSets["+ i +"].GroupCount");
				deploymentSet.Granularity = _ctx.StringValue("DescribeDeploymentSets.DeploymentSets["+ i +"].Granularity");
				deploymentSet.DeploymentSetName = _ctx.StringValue("DescribeDeploymentSets.DeploymentSets["+ i +"].DeploymentSetName");
				deploymentSet.InstanceAmount = _ctx.IntegerValue("DescribeDeploymentSets.DeploymentSets["+ i +"].InstanceAmount");

				List<string> deploymentSet_instanceIds = new List<string>();
				for (int j = 0; j < _ctx.Length("DescribeDeploymentSets.DeploymentSets["+ i +"].InstanceIds.Length"); j++) {
					deploymentSet_instanceIds.Add(_ctx.StringValue("DescribeDeploymentSets.DeploymentSets["+ i +"].InstanceIds["+ j +"]"));
				}
				deploymentSet.InstanceIds = deploymentSet_instanceIds;

				List<DescribeDeploymentSetsResponse.DescribeDeploymentSets_DeploymentSet.DescribeDeploymentSets_Capacity> deploymentSet_capacities = new List<DescribeDeploymentSetsResponse.DescribeDeploymentSets_DeploymentSet.DescribeDeploymentSets_Capacity>();
				for (int j = 0; j < _ctx.Length("DescribeDeploymentSets.DeploymentSets["+ i +"].Capacities.Length"); j++) {
					DescribeDeploymentSetsResponse.DescribeDeploymentSets_DeploymentSet.DescribeDeploymentSets_Capacity capacity = new DescribeDeploymentSetsResponse.DescribeDeploymentSets_DeploymentSet.DescribeDeploymentSets_Capacity();
					capacity.ZoneId = _ctx.StringValue("DescribeDeploymentSets.DeploymentSets["+ i +"].Capacities["+ j +"].ZoneId");
					capacity.UsedAmount = _ctx.IntegerValue("DescribeDeploymentSets.DeploymentSets["+ i +"].Capacities["+ j +"].UsedAmount");
					capacity.AvailableAmount = _ctx.IntegerValue("DescribeDeploymentSets.DeploymentSets["+ i +"].Capacities["+ j +"].AvailableAmount");

					deploymentSet_capacities.Add(capacity);
				}
				deploymentSet.Capacities = deploymentSet_capacities;

				describeDeploymentSetsResponse_deploymentSets.Add(deploymentSet);
			}
			describeDeploymentSetsResponse.DeploymentSets = describeDeploymentSetsResponse_deploymentSets;
        
			return describeDeploymentSetsResponse;
        }
    }
}
