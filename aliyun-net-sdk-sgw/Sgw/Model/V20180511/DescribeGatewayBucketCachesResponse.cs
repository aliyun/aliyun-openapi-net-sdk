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

namespace Aliyun.Acs.sgw.Model.V20180511
{
	public class DescribeGatewayBucketCachesResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private string code;

		private string message;

		private int? totalCount;

		private int? pageNumber;

		private int? pageSize;

		private List<DescribeGatewayBucketCaches_BucketCache> bucketCaches;

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

		public bool? Success
		{
			get
			{
				return success;
			}
			set	
			{
				success = value;
			}
		}

		public string Code
		{
			get
			{
				return code;
			}
			set	
			{
				code = value;
			}
		}

		public string Message
		{
			get
			{
				return message;
			}
			set	
			{
				message = value;
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

		public List<DescribeGatewayBucketCaches_BucketCache> BucketCaches
		{
			get
			{
				return bucketCaches;
			}
			set	
			{
				bucketCaches = value;
			}
		}

		public class DescribeGatewayBucketCaches_BucketCache
		{

			private string gatewayId;

			private string gatewayName;

			private string regionId;

			private string location;

			private string category;

			private string type;

			private string bucketName;

			private string protocol;

			private string cacheMode;

			private string cacheStats;

			private string shareName;

			private string vpcId;

			private string vpcCidr;

			private string mountPoint;

			public string GatewayId
			{
				get
				{
					return gatewayId;
				}
				set	
				{
					gatewayId = value;
				}
			}

			public string GatewayName
			{
				get
				{
					return gatewayName;
				}
				set	
				{
					gatewayName = value;
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

			public string Location
			{
				get
				{
					return location;
				}
				set	
				{
					location = value;
				}
			}

			public string Category
			{
				get
				{
					return category;
				}
				set	
				{
					category = value;
				}
			}

			public string Type
			{
				get
				{
					return type;
				}
				set	
				{
					type = value;
				}
			}

			public string BucketName
			{
				get
				{
					return bucketName;
				}
				set	
				{
					bucketName = value;
				}
			}

			public string Protocol
			{
				get
				{
					return protocol;
				}
				set	
				{
					protocol = value;
				}
			}

			public string CacheMode
			{
				get
				{
					return cacheMode;
				}
				set	
				{
					cacheMode = value;
				}
			}

			public string CacheStats
			{
				get
				{
					return cacheStats;
				}
				set	
				{
					cacheStats = value;
				}
			}

			public string ShareName
			{
				get
				{
					return shareName;
				}
				set	
				{
					shareName = value;
				}
			}

			public string VpcId
			{
				get
				{
					return vpcId;
				}
				set	
				{
					vpcId = value;
				}
			}

			public string VpcCidr
			{
				get
				{
					return vpcCidr;
				}
				set	
				{
					vpcCidr = value;
				}
			}

			public string MountPoint
			{
				get
				{
					return mountPoint;
				}
				set	
				{
					mountPoint = value;
				}
			}
		}
	}
}
