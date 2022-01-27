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
	public class DescribeGatewayCachesResponse : AcsResponse
	{

		private string message;

		private string requestId;

		private string code;

		private bool? success;

		private List<DescribeGatewayCaches_Cache> caches;

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

		[JsonProperty(PropertyName = "Caches")]
		public List<DescribeGatewayCaches_Cache> Caches
		{
			get
			{
				return caches;
			}
			set	
			{
				caches = value;
			}
		}

		public class DescribeGatewayCaches_Cache
		{

			private string performanceLevel;

			private long? sizeInGB;

			private string buyURL;

			private long? iops;

			private string cacheId;

			private string cacheType;

			private bool? isUsed;

			private long? expiredTime;

			private string localFilePath;

			private string subscriptionInstanceId;

			private int? expireStatus;

			private string renewURL;

			[JsonProperty(PropertyName = "PerformanceLevel")]
			public string PerformanceLevel
			{
				get
				{
					return performanceLevel;
				}
				set	
				{
					performanceLevel = value;
				}
			}

			[JsonProperty(PropertyName = "SizeInGB")]
			public long? SizeInGB
			{
				get
				{
					return sizeInGB;
				}
				set	
				{
					sizeInGB = value;
				}
			}

			[JsonProperty(PropertyName = "BuyURL")]
			public string BuyURL
			{
				get
				{
					return buyURL;
				}
				set	
				{
					buyURL = value;
				}
			}

			[JsonProperty(PropertyName = "Iops")]
			public long? Iops
			{
				get
				{
					return iops;
				}
				set	
				{
					iops = value;
				}
			}

			[JsonProperty(PropertyName = "CacheId")]
			public string CacheId
			{
				get
				{
					return cacheId;
				}
				set	
				{
					cacheId = value;
				}
			}

			[JsonProperty(PropertyName = "CacheType")]
			public string CacheType
			{
				get
				{
					return cacheType;
				}
				set	
				{
					cacheType = value;
				}
			}

			[JsonProperty(PropertyName = "IsUsed")]
			public bool? IsUsed
			{
				get
				{
					return isUsed;
				}
				set	
				{
					isUsed = value;
				}
			}

			[JsonProperty(PropertyName = "ExpiredTime")]
			public long? ExpiredTime
			{
				get
				{
					return expiredTime;
				}
				set	
				{
					expiredTime = value;
				}
			}

			[JsonProperty(PropertyName = "LocalFilePath")]
			public string LocalFilePath
			{
				get
				{
					return localFilePath;
				}
				set	
				{
					localFilePath = value;
				}
			}

			[JsonProperty(PropertyName = "SubscriptionInstanceId")]
			public string SubscriptionInstanceId
			{
				get
				{
					return subscriptionInstanceId;
				}
				set	
				{
					subscriptionInstanceId = value;
				}
			}

			[JsonProperty(PropertyName = "ExpireStatus")]
			public int? ExpireStatus
			{
				get
				{
					return expireStatus;
				}
				set	
				{
					expireStatus = value;
				}
			}

			[JsonProperty(PropertyName = "RenewURL")]
			public string RenewURL
			{
				get
				{
					return renewURL;
				}
				set	
				{
					renewURL = value;
				}
			}
		}
	}
}
