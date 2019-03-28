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

namespace Aliyun.Acs.Ecs.Model.V20140526
{
	public class DescribeLaunchTemplatesResponse : AcsResponse
	{

		private string requestId;

		private int? totalCount;

		private int? pageNumber;

		private int? pageSize;

		private List<DescribeLaunchTemplates_LaunchTemplateSet> launchTemplateSets;

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

		public int? PageNumber
		{
			get
			{
				return pageNumber;
			}
			set	
			{
				pageNumber = value;
			}
		}

		public int? PageSize
		{
			get
			{
				return pageSize;
			}
			set	
			{
				pageSize = value;
			}
		}

		public List<DescribeLaunchTemplates_LaunchTemplateSet> LaunchTemplateSets
		{
			get
			{
				return launchTemplateSets;
			}
			set	
			{
				launchTemplateSets = value;
			}
		}

		public class DescribeLaunchTemplates_LaunchTemplateSet
		{

			private string createTime;

			private string modifiedTime;

			private string launchTemplateId;

			private string launchTemplateName;

			private long? defaultVersionNumber;

			private long? latestVersionNumber;

			private string createdBy;

			private string resourceGroupId;

			private List<DescribeLaunchTemplates_Tag> tags;

			public string CreateTime
			{
				get
				{
					return createTime;
				}
				set	
				{
					createTime = value;
				}
			}

			public string ModifiedTime
			{
				get
				{
					return modifiedTime;
				}
				set	
				{
					modifiedTime = value;
				}
			}

			public string LaunchTemplateId
			{
				get
				{
					return launchTemplateId;
				}
				set	
				{
					launchTemplateId = value;
				}
			}

			public string LaunchTemplateName
			{
				get
				{
					return launchTemplateName;
				}
				set	
				{
					launchTemplateName = value;
				}
			}

			public long? DefaultVersionNumber
			{
				get
				{
					return defaultVersionNumber;
				}
				set	
				{
					defaultVersionNumber = value;
				}
			}

			public long? LatestVersionNumber
			{
				get
				{
					return latestVersionNumber;
				}
				set	
				{
					latestVersionNumber = value;
				}
			}

			public string CreatedBy
			{
				get
				{
					return createdBy;
				}
				set	
				{
					createdBy = value;
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

			public List<DescribeLaunchTemplates_Tag> Tags
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

			public class DescribeLaunchTemplates_Tag
			{

				private string tagKey;

				private string tagValue;

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
			}
		}
	}
}
