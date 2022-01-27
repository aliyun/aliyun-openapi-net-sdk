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
	public class DescribeImagePipelinesResponse : AcsResponse
	{

		private string nextToken;

		private string requestId;

		private int? totalCount;

		private int? maxResults;

		private List<DescribeImagePipelines_ImagePipelineSet> imagePipeline;

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

			private bool? deleteInstanceOnFailure;

			private string instanceType;

			private int? internetMaxBandwidthOut;

			private string imagePipelineId;

			private string vSwitchId;

			private int? systemDiskSize;

			private string description;

			private string baseImage;

			private string resourceGroupId;

			private string imageName;

			private string baseImageType;

			private string name;

			private string buildContent;

			private List<DescribeImagePipelines_Tag> tags;

			private List<string> toRegionIds;

			private List<string> addAccounts;

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

			public class DescribeImagePipelines_Tag
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
