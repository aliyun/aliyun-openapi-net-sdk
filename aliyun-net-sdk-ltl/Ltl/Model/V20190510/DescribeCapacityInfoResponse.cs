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

namespace Aliyun.Acs.ltl.Model.V20190510
{
	public class DescribeCapacityInfoResponse : AcsResponse
	{

		private int? code;

		private string message;

		private string requestId;

		private bool? success;

		private DescribeCapacityInfo_Data data;

		[JsonProperty(PropertyName = "Code")]
		public int? Code
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

		[JsonProperty(PropertyName = "Data")]
		public DescribeCapacityInfo_Data Data
		{
			get
			{
				return data;
			}
			set	
			{
				data = value;
			}
		}

		public class DescribeCapacityInfo_Data
		{

			private long? countQuota;

			private long? capacityQuota;

			private long? usedCount;

			private long? usedCapacity;

			private long? memberUsedCapacity;

			private long? memberUsedCount;

			[JsonProperty(PropertyName = "CountQuota")]
			public long? CountQuota
			{
				get
				{
					return countQuota;
				}
				set	
				{
					countQuota = value;
				}
			}

			[JsonProperty(PropertyName = "CapacityQuota")]
			public long? CapacityQuota
			{
				get
				{
					return capacityQuota;
				}
				set	
				{
					capacityQuota = value;
				}
			}

			[JsonProperty(PropertyName = "UsedCount")]
			public long? UsedCount
			{
				get
				{
					return usedCount;
				}
				set	
				{
					usedCount = value;
				}
			}

			[JsonProperty(PropertyName = "UsedCapacity")]
			public long? UsedCapacity
			{
				get
				{
					return usedCapacity;
				}
				set	
				{
					usedCapacity = value;
				}
			}

			[JsonProperty(PropertyName = "MemberUsedCapacity")]
			public long? MemberUsedCapacity
			{
				get
				{
					return memberUsedCapacity;
				}
				set	
				{
					memberUsedCapacity = value;
				}
			}

			[JsonProperty(PropertyName = "MemberUsedCount")]
			public long? MemberUsedCount
			{
				get
				{
					return memberUsedCount;
				}
				set	
				{
					memberUsedCount = value;
				}
			}
		}
	}
}
