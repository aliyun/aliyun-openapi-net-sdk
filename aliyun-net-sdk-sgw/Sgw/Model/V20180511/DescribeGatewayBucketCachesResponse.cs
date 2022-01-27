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

namespace Aliyun.Acs.sgw.Model.V20180511
{
	public class DescribeGatewayBucketCachesResponse : AcsResponse
	{

		private int? totalCount;

		private string requestId;

		private string message;

		private int? pageSize;

		private int? pageNumber;

		private string code;

		private bool? success;

		private List<DescribeGatewayBucketCaches_BucketCache> bucketCaches;

		[JsonProperty(PropertyName = "TotalCount")]
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

		[JsonProperty(PropertyName = "RequestId")]
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

		[JsonProperty(PropertyName = "Message")]
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

		[JsonProperty(PropertyName = "PageSize")]
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

		[JsonProperty(PropertyName = "PageNumber")]
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

		[JsonProperty(PropertyName = "Code")]
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

		[JsonProperty(PropertyName = "Success")]
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

		[JsonProperty(PropertyName = "BucketCaches")]
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

			private string vpcId;

			private string type;

			private string mountPoint;

			private string gatewayId;

			private string cacheMode;

			private string protocol;

			private string gatewayName;

			private string cacheStats;

			private string shareName;

			private string regionId;

			private string vpcCidr;

			private string bucketName;

			private string category;

			private string location;

			[JsonProperty(PropertyName = "VpcId")]
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

			[JsonProperty(PropertyName = "Type")]
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

			[JsonProperty(PropertyName = "MountPoint")]
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

			[JsonProperty(PropertyName = "GatewayId")]
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

			[JsonProperty(PropertyName = "CacheMode")]
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

			[JsonProperty(PropertyName = "Protocol")]
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

			[JsonProperty(PropertyName = "GatewayName")]
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

			[JsonProperty(PropertyName = "CacheStats")]
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

			[JsonProperty(PropertyName = "ShareName")]
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

			[JsonProperty(PropertyName = "RegionId")]
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

			[JsonProperty(PropertyName = "VpcCidr")]
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

			[JsonProperty(PropertyName = "BucketName")]
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

			[JsonProperty(PropertyName = "Category")]
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

			[JsonProperty(PropertyName = "Location")]
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
		}
	}
}
