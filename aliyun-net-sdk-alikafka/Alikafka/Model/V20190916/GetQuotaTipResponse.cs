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

namespace Aliyun.Acs.alikafka.Model.V20190916
{
	public class GetQuotaTipResponse : AcsResponse
	{

		private int? code;

		private string message;

		private string requestId;

		private bool? success;

		private GetQuotaTip_QuotaData quotaData;

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

		public GetQuotaTip_QuotaData QuotaData
		{
			get
			{
				return quotaData;
			}
			set	
			{
				quotaData = value;
			}
		}

		public class GetQuotaTip_QuotaData
		{

			private int? topicNumOfBuy;

			private int? topicQuota;

			private int? topicLeft;

			private int? topicUsed;

			private int? partitionNumOfBuy;

			private int? partitionQuata;

			private int? partitionLeft;

			private int? partitionUsed;

			private int? groupLeft;

			private int? groupUsed;

			private int? isPartitionBuy;

			public int? TopicNumOfBuy
			{
				get
				{
					return topicNumOfBuy;
				}
				set	
				{
					topicNumOfBuy = value;
				}
			}

			public int? TopicQuota
			{
				get
				{
					return topicQuota;
				}
				set	
				{
					topicQuota = value;
				}
			}

			public int? TopicLeft
			{
				get
				{
					return topicLeft;
				}
				set	
				{
					topicLeft = value;
				}
			}

			public int? TopicUsed
			{
				get
				{
					return topicUsed;
				}
				set	
				{
					topicUsed = value;
				}
			}

			public int? PartitionNumOfBuy
			{
				get
				{
					return partitionNumOfBuy;
				}
				set	
				{
					partitionNumOfBuy = value;
				}
			}

			public int? PartitionQuata
			{
				get
				{
					return partitionQuata;
				}
				set	
				{
					partitionQuata = value;
				}
			}

			public int? PartitionLeft
			{
				get
				{
					return partitionLeft;
				}
				set	
				{
					partitionLeft = value;
				}
			}

			public int? PartitionUsed
			{
				get
				{
					return partitionUsed;
				}
				set	
				{
					partitionUsed = value;
				}
			}

			public int? GroupLeft
			{
				get
				{
					return groupLeft;
				}
				set	
				{
					groupLeft = value;
				}
			}

			public int? GroupUsed
			{
				get
				{
					return groupUsed;
				}
				set	
				{
					groupUsed = value;
				}
			}

			public int? IsPartitionBuy
			{
				get
				{
					return isPartitionBuy;
				}
				set	
				{
					isPartitionBuy = value;
				}
			}
		}
	}
}
