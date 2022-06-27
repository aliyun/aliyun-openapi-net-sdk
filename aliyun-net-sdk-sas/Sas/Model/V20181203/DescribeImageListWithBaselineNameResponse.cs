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

namespace Aliyun.Acs.Sas.Model.V20181203
{
	public class DescribeImageListWithBaselineNameResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeImageListWithBaselineName_ImageInfosItem> imageInfos;

		private DescribeImageListWithBaselineName_PageInfo pageInfo;

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

		public List<DescribeImageListWithBaselineName_ImageInfosItem> ImageInfos
		{
			get
			{
				return imageInfos;
			}
			set	
			{
				imageInfos = value;
			}
		}

		public DescribeImageListWithBaselineName_PageInfo PageInfo
		{
			get
			{
				return pageInfo;
			}
			set	
			{
				pageInfo = value;
			}
		}

		public class DescribeImageListWithBaselineName_ImageInfosItem
		{

			private int? middleRiskImage;

			private string endpoints;

			private string riskStatus;

			private long? imageCreate;

			private string digest;

			private string tag;

			private long? imageUpdate;

			private string instanceId;

			private int? lowRiskImage;

			private string repoType;

			private string regionId;

			private string uuid;

			private int? imageSize;

			private string repoId;

			private int? totalItemCount;

			private int? highRiskImage;

			private int? noRiskImage;

			private string imageId;

			private string repoName;

			private string repoNamespace;

			public int? MiddleRiskImage
			{
				get
				{
					return middleRiskImage;
				}
				set	
				{
					middleRiskImage = value;
				}
			}

			public string Endpoints
			{
				get
				{
					return endpoints;
				}
				set	
				{
					endpoints = value;
				}
			}

			public string RiskStatus
			{
				get
				{
					return riskStatus;
				}
				set	
				{
					riskStatus = value;
				}
			}

			public long? ImageCreate
			{
				get
				{
					return imageCreate;
				}
				set	
				{
					imageCreate = value;
				}
			}

			public string Digest
			{
				get
				{
					return digest;
				}
				set	
				{
					digest = value;
				}
			}

			public string Tag
			{
				get
				{
					return tag;
				}
				set	
				{
					tag = value;
				}
			}

			public long? ImageUpdate
			{
				get
				{
					return imageUpdate;
				}
				set	
				{
					imageUpdate = value;
				}
			}

			public string InstanceId
			{
				get
				{
					return instanceId;
				}
				set	
				{
					instanceId = value;
				}
			}

			public int? LowRiskImage
			{
				get
				{
					return lowRiskImage;
				}
				set	
				{
					lowRiskImage = value;
				}
			}

			public string RepoType
			{
				get
				{
					return repoType;
				}
				set	
				{
					repoType = value;
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

			public string Uuid
			{
				get
				{
					return uuid;
				}
				set	
				{
					uuid = value;
				}
			}

			public int? ImageSize
			{
				get
				{
					return imageSize;
				}
				set	
				{
					imageSize = value;
				}
			}

			public string RepoId
			{
				get
				{
					return repoId;
				}
				set	
				{
					repoId = value;
				}
			}

			public int? TotalItemCount
			{
				get
				{
					return totalItemCount;
				}
				set	
				{
					totalItemCount = value;
				}
			}

			public int? HighRiskImage
			{
				get
				{
					return highRiskImage;
				}
				set	
				{
					highRiskImage = value;
				}
			}

			public int? NoRiskImage
			{
				get
				{
					return noRiskImage;
				}
				set	
				{
					noRiskImage = value;
				}
			}

			public string ImageId
			{
				get
				{
					return imageId;
				}
				set	
				{
					imageId = value;
				}
			}

			public string RepoName
			{
				get
				{
					return repoName;
				}
				set	
				{
					repoName = value;
				}
			}

			public string RepoNamespace
			{
				get
				{
					return repoNamespace;
				}
				set	
				{
					repoNamespace = value;
				}
			}
		}

		public class DescribeImageListWithBaselineName_PageInfo
		{

			private int? currentPage;

			private int? pageSize;

			private int? totalCount;

			private int? count;

			public int? CurrentPage
			{
				get
				{
					return currentPage;
				}
				set	
				{
					currentPage = value;
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

			public int? Count
			{
				get
				{
					return count;
				}
				set	
				{
					count = value;
				}
			}
		}
	}
}
