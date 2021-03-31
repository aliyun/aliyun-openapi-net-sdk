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
        public static DescribeElasticityAssurancesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeElasticityAssurancesResponse describeElasticityAssurancesResponse = new DescribeElasticityAssurancesResponse();

			describeElasticityAssurancesResponse.HttpResponse = _ctx.HttpResponse;
			describeElasticityAssurancesResponse.RequestId = _ctx.StringValue("DescribeElasticityAssurances.RequestId");
			describeElasticityAssurancesResponse.NextToken = _ctx.StringValue("DescribeElasticityAssurances.NextToken");
			describeElasticityAssurancesResponse.MaxResults = _ctx.IntegerValue("DescribeElasticityAssurances.MaxResults");
			describeElasticityAssurancesResponse.TotalCount = _ctx.IntegerValue("DescribeElasticityAssurances.TotalCount");

			List<DescribeElasticityAssurancesResponse.DescribeElasticityAssurances_ElasticityAssuranceItem> describeElasticityAssurancesResponse_elasticityAssuranceSet = new List<DescribeElasticityAssurancesResponse.DescribeElasticityAssurances_ElasticityAssuranceItem>();
			for (int i = 0; i < _ctx.Length("DescribeElasticityAssurances.ElasticityAssuranceSet.Length"); i++) {
				DescribeElasticityAssurancesResponse.DescribeElasticityAssurances_ElasticityAssuranceItem elasticityAssuranceItem = new DescribeElasticityAssurancesResponse.DescribeElasticityAssurances_ElasticityAssuranceItem();
				elasticityAssuranceItem.PrivatePoolOptionsId = _ctx.StringValue("DescribeElasticityAssurances.ElasticityAssuranceSet["+ i +"].PrivatePoolOptionsId");
				elasticityAssuranceItem.PrivatePoolOptionsName = _ctx.StringValue("DescribeElasticityAssurances.ElasticityAssuranceSet["+ i +"].PrivatePoolOptionsName");
				elasticityAssuranceItem.Description = _ctx.StringValue("DescribeElasticityAssurances.ElasticityAssuranceSet["+ i +"].Description");
				elasticityAssuranceItem.RegionId = _ctx.StringValue("DescribeElasticityAssurances.ElasticityAssuranceSet["+ i +"].RegionId");
				elasticityAssuranceItem.PrivatePoolOptionsMatchCriteria = _ctx.StringValue("DescribeElasticityAssurances.ElasticityAssuranceSet["+ i +"].PrivatePoolOptionsMatchCriteria");
				elasticityAssuranceItem.UsedAssuranceTimes = _ctx.IntegerValue("DescribeElasticityAssurances.ElasticityAssuranceSet["+ i +"].UsedAssuranceTimes");
				elasticityAssuranceItem.TotalAssuranceTimes = _ctx.StringValue("DescribeElasticityAssurances.ElasticityAssuranceSet["+ i +"].TotalAssuranceTimes");
				elasticityAssuranceItem.Status = _ctx.StringValue("DescribeElasticityAssurances.ElasticityAssuranceSet["+ i +"].Status");
				elasticityAssuranceItem.StartTime = _ctx.StringValue("DescribeElasticityAssurances.ElasticityAssuranceSet["+ i +"].StartTime");
				elasticityAssuranceItem.EndTime = _ctx.StringValue("DescribeElasticityAssurances.ElasticityAssuranceSet["+ i +"].EndTime");
				elasticityAssuranceItem.LatestStartTime = _ctx.StringValue("DescribeElasticityAssurances.ElasticityAssuranceSet["+ i +"].LatestStartTime");
				elasticityAssuranceItem.ResourceGroupId = _ctx.StringValue("DescribeElasticityAssurances.ElasticityAssuranceSet["+ i +"].ResourceGroupId");

				List<DescribeElasticityAssurancesResponse.DescribeElasticityAssurances_ElasticityAssuranceItem.DescribeElasticityAssurances_AllocatedResource> elasticityAssuranceItem_allocatedResources = new List<DescribeElasticityAssurancesResponse.DescribeElasticityAssurances_ElasticityAssuranceItem.DescribeElasticityAssurances_AllocatedResource>();
				for (int j = 0; j < _ctx.Length("DescribeElasticityAssurances.ElasticityAssuranceSet["+ i +"].AllocatedResources.Length"); j++) {
					DescribeElasticityAssurancesResponse.DescribeElasticityAssurances_ElasticityAssuranceItem.DescribeElasticityAssurances_AllocatedResource allocatedResource = new DescribeElasticityAssurancesResponse.DescribeElasticityAssurances_ElasticityAssuranceItem.DescribeElasticityAssurances_AllocatedResource();
					allocatedResource.ZoneId = _ctx.StringValue("DescribeElasticityAssurances.ElasticityAssuranceSet["+ i +"].AllocatedResources["+ j +"].zoneId");
					allocatedResource.InstanceType = _ctx.StringValue("DescribeElasticityAssurances.ElasticityAssuranceSet["+ i +"].AllocatedResources["+ j +"].InstanceType");
					allocatedResource.TotalAmount = _ctx.IntegerValue("DescribeElasticityAssurances.ElasticityAssuranceSet["+ i +"].AllocatedResources["+ j +"].TotalAmount");
					allocatedResource.UsedAmount = _ctx.IntegerValue("DescribeElasticityAssurances.ElasticityAssuranceSet["+ i +"].AllocatedResources["+ j +"].UsedAmount");

					elasticityAssuranceItem_allocatedResources.Add(allocatedResource);
				}
				elasticityAssuranceItem.AllocatedResources = elasticityAssuranceItem_allocatedResources;

				List<DescribeElasticityAssurancesResponse.DescribeElasticityAssurances_ElasticityAssuranceItem.DescribeElasticityAssurances_Tag> elasticityAssuranceItem_tags = new List<DescribeElasticityAssurancesResponse.DescribeElasticityAssurances_ElasticityAssuranceItem.DescribeElasticityAssurances_Tag>();
				for (int j = 0; j < _ctx.Length("DescribeElasticityAssurances.ElasticityAssuranceSet["+ i +"].Tags.Length"); j++) {
					DescribeElasticityAssurancesResponse.DescribeElasticityAssurances_ElasticityAssuranceItem.DescribeElasticityAssurances_Tag tag = new DescribeElasticityAssurancesResponse.DescribeElasticityAssurances_ElasticityAssuranceItem.DescribeElasticityAssurances_Tag();
					tag.TagKey = _ctx.StringValue("DescribeElasticityAssurances.ElasticityAssuranceSet["+ i +"].Tags["+ j +"].TagKey");
					tag.TagValue = _ctx.StringValue("DescribeElasticityAssurances.ElasticityAssuranceSet["+ i +"].Tags["+ j +"].TagValue");

					elasticityAssuranceItem_tags.Add(tag);
				}
				elasticityAssuranceItem.Tags = elasticityAssuranceItem_tags;

				describeElasticityAssurancesResponse_elasticityAssuranceSet.Add(elasticityAssuranceItem);
			}
			describeElasticityAssurancesResponse.ElasticityAssuranceSet = describeElasticityAssurancesResponse_elasticityAssuranceSet;
        
			return describeElasticityAssurancesResponse;
        }
    }
}
