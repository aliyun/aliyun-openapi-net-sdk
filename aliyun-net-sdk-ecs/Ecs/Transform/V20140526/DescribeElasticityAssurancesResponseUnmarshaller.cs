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
    public class DescribeElasticityAssurancesResponseUnmarshaller
    {
        public static DescribeElasticityAssurancesResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeElasticityAssurancesResponse describeElasticityAssurancesResponse = new DescribeElasticityAssurancesResponse();

			describeElasticityAssurancesResponse.HttpResponse = context.HttpResponse;
			describeElasticityAssurancesResponse.RequestId = context.StringValue("DescribeElasticityAssurances.RequestId");
			describeElasticityAssurancesResponse.NextToken = context.StringValue("DescribeElasticityAssurances.NextToken");
			describeElasticityAssurancesResponse.MaxResults = context.IntegerValue("DescribeElasticityAssurances.MaxResults");
			describeElasticityAssurancesResponse.TotalCount = context.IntegerValue("DescribeElasticityAssurances.TotalCount");

			List<DescribeElasticityAssurancesResponse.DescribeElasticityAssurances_ElasticityAssuranceItem> describeElasticityAssurancesResponse_elasticityAssuranceSet = new List<DescribeElasticityAssurancesResponse.DescribeElasticityAssurances_ElasticityAssuranceItem>();
			for (int i = 0; i < context.Length("DescribeElasticityAssurances.ElasticityAssuranceSet.Length"); i++) {
				DescribeElasticityAssurancesResponse.DescribeElasticityAssurances_ElasticityAssuranceItem elasticityAssuranceItem = new DescribeElasticityAssurancesResponse.DescribeElasticityAssurances_ElasticityAssuranceItem();
				elasticityAssuranceItem.PrivatePoolOptionsId = context.StringValue("DescribeElasticityAssurances.ElasticityAssuranceSet["+ i +"].PrivatePoolOptionsId");
				elasticityAssuranceItem.PrivatePoolOptionsName = context.StringValue("DescribeElasticityAssurances.ElasticityAssuranceSet["+ i +"].PrivatePoolOptionsName");
				elasticityAssuranceItem.Description = context.StringValue("DescribeElasticityAssurances.ElasticityAssuranceSet["+ i +"].Description");
				elasticityAssuranceItem.RegionId = context.StringValue("DescribeElasticityAssurances.ElasticityAssuranceSet["+ i +"].RegionId");
				elasticityAssuranceItem.PrivatePoolOptionsMatchCriteria = context.StringValue("DescribeElasticityAssurances.ElasticityAssuranceSet["+ i +"].PrivatePoolOptionsMatchCriteria");
				elasticityAssuranceItem.UsedAssuranceTimes = context.IntegerValue("DescribeElasticityAssurances.ElasticityAssuranceSet["+ i +"].UsedAssuranceTimes");
				elasticityAssuranceItem.TotalAssuranceTimes = context.StringValue("DescribeElasticityAssurances.ElasticityAssuranceSet["+ i +"].TotalAssuranceTimes");
				elasticityAssuranceItem.Status = context.StringValue("DescribeElasticityAssurances.ElasticityAssuranceSet["+ i +"].Status");
				elasticityAssuranceItem.StartTime = context.StringValue("DescribeElasticityAssurances.ElasticityAssuranceSet["+ i +"].StartTime");
				elasticityAssuranceItem.EndTime = context.StringValue("DescribeElasticityAssurances.ElasticityAssuranceSet["+ i +"].EndTime");
				elasticityAssuranceItem.LatestStartTime = context.StringValue("DescribeElasticityAssurances.ElasticityAssuranceSet["+ i +"].LatestStartTime");

				List<DescribeElasticityAssurancesResponse.DescribeElasticityAssurances_ElasticityAssuranceItem.DescribeElasticityAssurances_AllocatedResource> elasticityAssuranceItem_allocatedResources = new List<DescribeElasticityAssurancesResponse.DescribeElasticityAssurances_ElasticityAssuranceItem.DescribeElasticityAssurances_AllocatedResource>();
				for (int j = 0; j < context.Length("DescribeElasticityAssurances.ElasticityAssuranceSet["+ i +"].AllocatedResources.Length"); j++) {
					DescribeElasticityAssurancesResponse.DescribeElasticityAssurances_ElasticityAssuranceItem.DescribeElasticityAssurances_AllocatedResource allocatedResource = new DescribeElasticityAssurancesResponse.DescribeElasticityAssurances_ElasticityAssuranceItem.DescribeElasticityAssurances_AllocatedResource();
					allocatedResource.ZoneId = context.StringValue("DescribeElasticityAssurances.ElasticityAssuranceSet["+ i +"].AllocatedResources["+ j +"].zoneId");
					allocatedResource.InstanceType = context.StringValue("DescribeElasticityAssurances.ElasticityAssuranceSet["+ i +"].AllocatedResources["+ j +"].InstanceType");
					allocatedResource.TotalAmount = context.IntegerValue("DescribeElasticityAssurances.ElasticityAssuranceSet["+ i +"].AllocatedResources["+ j +"].TotalAmount");
					allocatedResource.UsedAmount = context.IntegerValue("DescribeElasticityAssurances.ElasticityAssuranceSet["+ i +"].AllocatedResources["+ j +"].UsedAmount");

					elasticityAssuranceItem_allocatedResources.Add(allocatedResource);
				}
				elasticityAssuranceItem.AllocatedResources = elasticityAssuranceItem_allocatedResources;

				describeElasticityAssurancesResponse_elasticityAssuranceSet.Add(elasticityAssuranceItem);
			}
			describeElasticityAssurancesResponse.ElasticityAssuranceSet = describeElasticityAssurancesResponse_elasticityAssuranceSet;
        
			return describeElasticityAssurancesResponse;
        }
    }
}
