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
	public class GetResourceConfigurationTimelineResponse : AcsResponse
	{

		private string requestId;

		private GetResourceConfigurationTimeline_ResourceConfigurationTimeline resourceConfigurationTimeline;

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

		public GetResourceConfigurationTimeline_ResourceConfigurationTimeline ResourceConfigurationTimeline
		{
			get
			{
				return resourceConfigurationTimeline;
			}
			set	
			{
				resourceConfigurationTimeline = value;
			}
		}

		public class GetResourceConfigurationTimeline_ResourceConfigurationTimeline
		{

			private string nextToken;

			private int? limit;

			private long? totalCount;

			private List<GetResourceConfigurationTimeline_ConfigurationListItem> configurationList;

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

			public List<GetResourceConfigurationTimeline_ConfigurationListItem> ConfigurationList
			{
				get
				{
					return configurationList;
				}
				set	
				{
					configurationList = value;
				}
			}

			public class GetResourceConfigurationTimeline_ConfigurationListItem
			{

				private long? accountId;

				private string availabilityZone;

				private string captureTime;

				private string configurationDiff;

				private string region;

				private string relationship;

				private string relationshipDiff;

				private string resourceCreateTime;

				private string resourceId;

				private string resourceName;

				private string resourceType;

				private string tags;

				private string resourceEventType;

				public long? AccountId
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

				public string CaptureTime
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

				public string Relationship
				{
					get
					{
						return relationship;
					}
					set	
					{
						relationship = value;
					}
				}

				public string RelationshipDiff
				{
					get
					{
						return relationshipDiff;
					}
					set	
					{
						relationshipDiff = value;
					}
				}

				public string ResourceCreateTime
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

				public string ResourceEventType
				{
					get
					{
						return resourceEventType;
					}
					set	
					{
						resourceEventType = value;
					}
				}
			}
		}
	}
}
