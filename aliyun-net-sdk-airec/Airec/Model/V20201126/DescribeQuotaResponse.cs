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

namespace Aliyun.Acs.Airec.Model.V20201126
{
	public class DescribeQuotaResponse : AcsResponse
	{

		private string code;

		private string message;

		private string requestId;

		private DescribeQuota_Result result;

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

		public DescribeQuota_Result Result
		{
			get
			{
				return result;
			}
			set	
			{
				result = value;
			}
		}

		public class DescribeQuota_Result
		{

			private int? currentQps;

			private long? itemCount;

			private long? itemCountUsed;

			private int? qps;

			private long? userCount;

			private long? userCountUsed;

			public int? CurrentQps
			{
				get
				{
					return currentQps;
				}
				set	
				{
					currentQps = value;
				}
			}

			public long? ItemCount
			{
				get
				{
					return itemCount;
				}
				set	
				{
					itemCount = value;
				}
			}

			public long? ItemCountUsed
			{
				get
				{
					return itemCountUsed;
				}
				set	
				{
					itemCountUsed = value;
				}
			}

			public int? Qps
			{
				get
				{
					return qps;
				}
				set	
				{
					qps = value;
				}
			}

			public long? UserCount
			{
				get
				{
					return userCount;
				}
				set	
				{
					userCount = value;
				}
			}

			public long? UserCountUsed
			{
				get
				{
					return userCountUsed;
				}
				set	
				{
					userCountUsed = value;
				}
			}
		}
	}
}
