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

namespace Aliyun.Acs.Sas.Model.V20181203
{
	public class DescribeAffectedMaliciousFileImagesResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeAffectedMaliciousFileImages_AffectedMaliciousFileImage> affectedMaliciousFileImagesResponse;

		private DescribeAffectedMaliciousFileImages_PageInfo pageInfo;

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

		public List<DescribeAffectedMaliciousFileImages_AffectedMaliciousFileImage> AffectedMaliciousFileImagesResponse
		{
			get
			{
				return affectedMaliciousFileImagesResponse;
			}
			set	
			{
				affectedMaliciousFileImagesResponse = value;
			}
		}

		public DescribeAffectedMaliciousFileImages_PageInfo PageInfo
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

		public class DescribeAffectedMaliciousFileImages_AffectedMaliciousFileImage
		{

			private string layer;

			private long? firstScanTimestamp;

			private long? latestScanTimestamp;

			private long? latestVerifyTimestamp;

			private string maliciousMd5;

			private int? status;

			private string level;

			private string imageUuid;

			private string filePath;

			private string digest;

			private string repoRegionId;

			private string repoInstanceId;

			private string repoId;

			private string repoName;

			private string _namespace;

			private string tag;

			public string Layer
			{
				get
				{
					return layer;
				}
				set	
				{
					layer = value;
				}
			}

			public long? FirstScanTimestamp
			{
				get
				{
					return firstScanTimestamp;
				}
				set	
				{
					firstScanTimestamp = value;
				}
			}

			public long? LatestScanTimestamp
			{
				get
				{
					return latestScanTimestamp;
				}
				set	
				{
					latestScanTimestamp = value;
				}
			}

			public long? LatestVerifyTimestamp
			{
				get
				{
					return latestVerifyTimestamp;
				}
				set	
				{
					latestVerifyTimestamp = value;
				}
			}

			public string MaliciousMd5
			{
				get
				{
					return maliciousMd5;
				}
				set	
				{
					maliciousMd5 = value;
				}
			}

			public int? Status
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

			public string Level
			{
				get
				{
					return level;
				}
				set	
				{
					level = value;
				}
			}

			public string ImageUuid
			{
				get
				{
					return imageUuid;
				}
				set	
				{
					imageUuid = value;
				}
			}

			public string FilePath
			{
				get
				{
					return filePath;
				}
				set	
				{
					filePath = value;
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

			public string RepoRegionId
			{
				get
				{
					return repoRegionId;
				}
				set	
				{
					repoRegionId = value;
				}
			}

			public string RepoInstanceId
			{
				get
				{
					return repoInstanceId;
				}
				set	
				{
					repoInstanceId = value;
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

			public string _Namespace
			{
				get
				{
					return _namespace;
				}
				set	
				{
					_namespace = value;
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
		}

		public class DescribeAffectedMaliciousFileImages_PageInfo
		{

			private int? count;

			private int? pageSize;

			private int? totalCount;

			private int? currentPage;

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
		}
	}
}
