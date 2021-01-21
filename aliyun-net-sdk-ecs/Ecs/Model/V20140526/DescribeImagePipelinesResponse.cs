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
	public class DescribeImagePipelinesResponse : AcsResponse
	{

		private string requestId;

		private int? totalCount;

		private string nextToken;

		private int? maxResults;

		private List<DescribeImagePipelines_ImagePipelineSet> imagePipeline;

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

		public List<DescribeImagePipelines_ImagePipelineSet> ImagePipeline
		{
			get
			{
				return imagePipeline;
			}
			set	
			{
				imagePipeline = value;
			}
		}

		public class DescribeImagePipelines_ImagePipelineSet
		{

			private string creationTime;

			private string imagePipelineId;

			private string name;

			private string description;

			private string baseImageType;

			private string baseImage;

			private string imageName;

			private string vSwitchId;

			private string instanceType;

			private int? internetMaxBandwidthOut;

			private int? systemDiskSize;

			private bool? deleteInstanceOnFailure;

			private string buildContent;

			private string resourceGroupId;

			private List<DescribeImagePipelines_Tag> tags;

			private List<string> addAccounts;

			private List<string> toRegionIds;

			public string CreationTime
			{
				get
				{
					return creationTime;
				}
				set	
				{
					creationTime = value;
				}
			}

			public string ImagePipelineId
			{
				get
				{
					return imagePipelineId;
				}
				set	
				{
					imagePipelineId = value;
				}
			}

			public string Name
			{
				get
				{
					return name;
				}
				set	
				{
					name = value;
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

			public string BaseImageType
			{
				get
				{
					return baseImageType;
				}
				set	
				{
					baseImageType = value;
				}
			}

			public string BaseImage
			{
				get
				{
					return baseImage;
				}
				set	
				{
					baseImage = value;
				}
			}

			public string ImageName
			{
				get
				{
					return imageName;
				}
				set	
				{
					imageName = value;
				}
			}

			public string VSwitchId
			{
				get
				{
					return vSwitchId;
				}
				set	
				{
					vSwitchId = value;
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

			public int? InternetMaxBandwidthOut
			{
				get
				{
					return internetMaxBandwidthOut;
				}
				set	
				{
					internetMaxBandwidthOut = value;
				}
			}

			public int? SystemDiskSize
			{
				get
				{
					return systemDiskSize;
				}
				set	
				{
					systemDiskSize = value;
				}
			}

			public bool? DeleteInstanceOnFailure
			{
				get
				{
					return deleteInstanceOnFailure;
				}
				set	
				{
					deleteInstanceOnFailure = value;
				}
			}

			public string BuildContent
			{
				get
				{
					return buildContent;
				}
				set	
				{
					buildContent = value;
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

			public List<DescribeImagePipelines_Tag> Tags
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

			public List<string> AddAccounts
			{
				get
				{
					return addAccounts;
				}
				set	
				{
					addAccounts = value;
				}
			}

			public List<string> ToRegionIds
			{
				get
				{
					return toRegionIds;
				}
				set	
				{
					toRegionIds = value;
				}
			}

			public class DescribeImagePipelines_Tag
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
