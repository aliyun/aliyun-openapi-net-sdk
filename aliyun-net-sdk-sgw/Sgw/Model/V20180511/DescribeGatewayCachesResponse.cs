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
	public class DescribeGatewayCachesResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private string code;

		private string message;

		private List<DescribeGatewayCaches_Cache> caches;

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

			private long? sizeInGB;

			private long? iops;

			private string cacheId;

			private string cacheType;

			private bool? isUsed;

			private string localFilePath;

			private string renewURL;

			private long? expiredTime;

			private int? expireStatus;

			private string performanceLevel;

			private string buyURL;

			private string subscriptionInstanceId;

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
		}
	}
}
