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
using System.Collections.Generic;
using Newtonsoft.Json;
using Aliyun.Acs.Core;

namespace Aliyun.Acs.Ecs.Model.V20140526
{
	public class DescribeElasticityAssurancesResponse : AcsResponse
	{

		private string nextToken;

		private string requestId;

		private int? totalCount;

		private int? maxResults;

		private List<DescribeElasticityAssurances_ElasticityAssuranceItem> elasticityAssuranceSet;

		public string NextToken
		{
			get
			{
				return nextToken;
			}
			set	
			{
				nextToken = value;
			}
		}

		public string RequestId
		{
			get
			{
				return requestId;
			}
			set	
			{
				requestId = value;
			}
		}

		public int? TotalCount
		{
			get
			{
				return totalCount;
			}
			set	
			{
				totalCount = value;
			}
		}

		public int? MaxResults
		{
			get
			{
				return maxResults;
			}
			set	
			{
				maxResults = value;
			}
		}

		public List<DescribeElasticityAssurances_ElasticityAssuranceItem> ElasticityAssuranceSet
		{
			get
			{
				return elasticityAssuranceSet;
			}
			set	
			{
				elasticityAssuranceSet = value;
			}
		}

		public class DescribeElasticityAssurances_ElasticityAssuranceItem
		{

			private string status;

			private string privatePoolOptionsMatchCriteria;

			private string privatePoolOptionsId;

			private int? usedAssuranceTimes;

			private string latestStartTime;

			private string privatePoolOptionsName;

			private string regionId;

			private string endTime;

			private string startTime;

			private string description;

			private string resourceGroupId;

			private string totalAssuranceTimes;

			private List<DescribeElasticityAssurances_AllocatedResource> allocatedResources;

			private List<DescribeElasticityAssurances_Tag> tags;

			public string Status
			{
				get
				{
					return status;
				}
				set	
				{
					status = value;
				}
			}

			public string PrivatePoolOptionsMatchCriteria
			{
				get
				{
					return privatePoolOptionsMatchCriteria;
				}
				set	
				{
					privatePoolOptionsMatchCriteria = value;
				}
			}

			public string PrivatePoolOptionsId
			{
				get
				{
					return privatePoolOptionsId;
				}
				set	
				{
					privatePoolOptionsId = value;
				}
			}

			public int? UsedAssuranceTimes
			{
				get
				{
					return usedAssuranceTimes;
				}
				set	
				{
					usedAssuranceTimes = value;
				}
			}

			public string LatestStartTime
			{
				get
				{
					return latestStartTime;
				}
				set	
				{
					latestStartTime = value;
				}
			}

			public string PrivatePoolOptionsName
			{
				get
				{
					return privatePoolOptionsName;
				}
				set	
				{
					privatePoolOptionsName = value;
				}
			}

			public string RegionId
			{
				get
				{
					return regionId;
				}
				set	
				{
					regionId = value;
				}
			}

			public string EndTime
			{
				get
				{
					return endTime;
				}
				set	
				{
					endTime = value;
				}
			}

			public string StartTime
			{
				get
				{
					return startTime;
				}
				set	
				{
					startTime = value;
				}
			}

			public string Description
			{
				get
				{
					return description;
				}
				set	
				{
					description = value;
				}
			}

			public string ResourceGroupId
			{
				get
				{
					return resourceGroupId;
				}
				set	
				{
					resourceGroupId = value;
				}
			}

			public string TotalAssuranceTimes
			{
				get
				{
					return totalAssuranceTimes;
				}
				set	
				{
					totalAssuranceTimes = value;
				}
			}

			public List<DescribeElasticityAssurances_AllocatedResource> AllocatedResources
			{
				get
				{
					return allocatedResources;
				}
				set	
				{
					allocatedResources = value;
				}
			}

			public List<DescribeElasticityAssurances_Tag> Tags
			{
				get
				{
					return tags;
				}
				set	
				{
					tags = value;
				}
			}

			public class DescribeElasticityAssurances_AllocatedResource
			{

				private int? usedAmount;

				private int? totalAmount;

				private string zoneId;

				private string instanceType;

				public int? UsedAmount
				{
					get
					{
						return usedAmount;
					}
					set	
					{
						usedAmount = value;
					}
				}

				public int? TotalAmount
				{
					get
					{
						return totalAmount;
					}
					set	
					{
						totalAmount = value;
					}
				}

				public string ZoneId
				{
					get
					{
						return zoneId;
					}
					set	
					{
						zoneId = value;
					}
				}

				public string InstanceType
				{
					get
					{
						return instanceType;
					}
					set	
					{
						instanceType = value;
					}
				}
			}

			public class DescribeElasticityAssurances_Tag
			{

				private string tagValue;

				private string tagKey;

				public string TagValue
				{
					get
					{
						return tagValue;
					}
					set	
					{
						tagValue = value;
					}
				}

				public string TagKey
				{
					get
					{
						return tagKey;
					}
					set	
					{
						tagKey = value;
					}
				}
			}
		}
	}
}
