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

namespace Aliyun.Acs.Dbs.Model.V20190306
{
	public class DescribeBackupPlanBillingResponse : AcsResponse
	{

		private bool? success;

		private string errCode;

		private string errMessage;

		private int? httpStatusCode;

		private string requestId;

		private DescribeBackupPlanBilling_Item item;

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

		public string ErrCode
		{
			get
			{
				return errCode;
			}
			set	
			{
				errCode = value;
			}
		}

		public string ErrMessage
		{
			get
			{
				return errMessage;
			}
			set	
			{
				errMessage = value;
			}
		}

		public int? HttpStatusCode
		{
			get
			{
				return httpStatusCode;
			}
			set	
			{
				httpStatusCode = value;
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

		public DescribeBackupPlanBilling_Item Item
		{
			get
			{
				return item;
			}
			set	
			{
				item = value;
			}
		}

		public class DescribeBackupPlanBilling_Item
		{

			private string buySpec;

			private string buyChargeType;

			private long? buyExpiredTimestamp;

			private long? totalFreeBytes;

			private long? paiedBytes;

			private long? usedFullBytes;

			private long? usedIncrementBytes;

			private long? quotaStartTimestamp;

			private long? quotaEndTimestamp;

			private long? buyCreateTimestamp;

			private long? fullStorageSize;

			private long? contStorageSize;

			private bool? isExpired;

			private bool? isFreeBytesUnlimited;

			public string BuySpec
			{
				get
				{
					return buySpec;
				}
				set	
				{
					buySpec = value;
				}
			}

			public string BuyChargeType
			{
				get
				{
					return buyChargeType;
				}
				set	
				{
					buyChargeType = value;
				}
			}

			public long? BuyExpiredTimestamp
			{
				get
				{
					return buyExpiredTimestamp;
				}
				set	
				{
					buyExpiredTimestamp = value;
				}
			}

			public long? TotalFreeBytes
			{
				get
				{
					return totalFreeBytes;
				}
				set	
				{
					totalFreeBytes = value;
				}
			}

			public long? PaiedBytes
			{
				get
				{
					return paiedBytes;
				}
				set	
				{
					paiedBytes = value;
				}
			}

			public long? UsedFullBytes
			{
				get
				{
					return usedFullBytes;
				}
				set	
				{
					usedFullBytes = value;
				}
			}

			public long? UsedIncrementBytes
			{
				get
				{
					return usedIncrementBytes;
				}
				set	
				{
					usedIncrementBytes = value;
				}
			}

			public long? QuotaStartTimestamp
			{
				get
				{
					return quotaStartTimestamp;
				}
				set	
				{
					quotaStartTimestamp = value;
				}
			}

			public long? QuotaEndTimestamp
			{
				get
				{
					return quotaEndTimestamp;
				}
				set	
				{
					quotaEndTimestamp = value;
				}
			}

			public long? BuyCreateTimestamp
			{
				get
				{
					return buyCreateTimestamp;
				}
				set	
				{
					buyCreateTimestamp = value;
				}
			}

			public long? FullStorageSize
			{
				get
				{
					return fullStorageSize;
				}
				set	
				{
					fullStorageSize = value;
				}
			}

			public long? ContStorageSize
			{
				get
				{
					return contStorageSize;
				}
				set	
				{
					contStorageSize = value;
				}
			}

			public bool? IsExpired
			{
				get
				{
					return isExpired;
				}
				set	
				{
					isExpired = value;
				}
			}

			public bool? IsFreeBytesUnlimited
			{
				get
				{
					return isFreeBytesUnlimited;
				}
				set	
				{
					isFreeBytesUnlimited = value;
				}
			}
		}
	}
}
