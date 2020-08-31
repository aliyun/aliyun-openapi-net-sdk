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

using Aliyun.Acs.Core;

namespace Aliyun.Acs.Config.Model.V20190108
{
	public class GetResourceComplianceTimelineResponse : AcsResponse
	{

		private string requestId;

		private GetResourceComplianceTimeline_ResourceComplianceTimeline resourceComplianceTimeline;

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

		public GetResourceComplianceTimeline_ResourceComplianceTimeline ResourceComplianceTimeline
		{
			get
			{
				return resourceComplianceTimeline;
			}
			set	
			{
				resourceComplianceTimeline = value;
			}
		}

		public class GetResourceComplianceTimeline_ResourceComplianceTimeline
		{

			private int? limit;

			private long? totalCount;

			private string nextToken;

			private List<GetResourceComplianceTimeline_ComplianceListItem> complianceList;

			public int? Limit
			{
				get
				{
					return limit;
				}
				set	
				{
					limit = value;
				}
			}

			public long? TotalCount
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

			public List<GetResourceComplianceTimeline_ComplianceListItem> ComplianceList
			{
				get
				{
					return complianceList;
				}
				set	
				{
					complianceList = value;
				}
			}

			public class GetResourceComplianceTimeline_ComplianceListItem
			{

				private string accountId;

				private string availabilityZone;

				private long? captureTime;

				private string configuration;

				private string configurationDiff;

				private string region;

				private long? resourceCreateTime;

				private string resourceId;

				private string resourceName;

				private string resourceStatus;

				private string resourceType;

				private string tags;

				public string AccountId
				{
					get
					{
						return accountId;
					}
					set	
					{
						accountId = value;
					}
				}

				public string AvailabilityZone
				{
					get
					{
						return availabilityZone;
					}
					set	
					{
						availabilityZone = value;
					}
				}

				public long? CaptureTime
				{
					get
					{
						return captureTime;
					}
					set	
					{
						captureTime = value;
					}
				}

				public string Configuration
				{
					get
					{
						return configuration;
					}
					set	
					{
						configuration = value;
					}
				}

				public string ConfigurationDiff
				{
					get
					{
						return configurationDiff;
					}
					set	
					{
						configurationDiff = value;
					}
				}

				public string Region
				{
					get
					{
						return region;
					}
					set	
					{
						region = value;
					}
				}

				public long? ResourceCreateTime
				{
					get
					{
						return resourceCreateTime;
					}
					set	
					{
						resourceCreateTime = value;
					}
				}

				public string ResourceId
				{
					get
					{
						return resourceId;
					}
					set	
					{
						resourceId = value;
					}
				}

				public string ResourceName
				{
					get
					{
						return resourceName;
					}
					set	
					{
						resourceName = value;
					}
				}

				public string ResourceStatus
				{
					get
					{
						return resourceStatus;
					}
					set	
					{
						resourceStatus = value;
					}
				}

				public string ResourceType
				{
					get
					{
						return resourceType;
					}
					set	
					{
						resourceType = value;
					}
				}

				public string Tags
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
			}
		}
	}
}
