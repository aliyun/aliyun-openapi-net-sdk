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

namespace Aliyun.Acs.cloud_siem.Model.V20220616
{
	public class DescribeUserBuyStatusResponse : AcsResponse
	{

		private string requestId;

		private DescribeUserBuyStatus_Data data;

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

		public DescribeUserBuyStatus_Data Data
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

		public class DescribeUserBuyStatus_Data
		{

			private long? masterUserId;

			private string masterUserName;

			private long? mainUserId;

			private string mainUserName;

			private long? subUserId;

			private string subUserName;

			private int? capacity;

			private string sasInstanceId;

			private bool? canBuy;

			private long? endTime;

			private long? durationDays;

			public long? MasterUserId
			{
				get
				{
					return masterUserId;
				}
				set	
				{
					masterUserId = value;
				}
			}

			public string MasterUserName
			{
				get
				{
					return masterUserName;
				}
				set	
				{
					masterUserName = value;
				}
			}

			public long? MainUserId
			{
				get
				{
					return mainUserId;
				}
				set	
				{
					mainUserId = value;
				}
			}

			public string MainUserName
			{
				get
				{
					return mainUserName;
				}
				set	
				{
					mainUserName = value;
				}
			}

			public long? SubUserId
			{
				get
				{
					return subUserId;
				}
				set	
				{
					subUserId = value;
				}
			}

			public string SubUserName
			{
				get
				{
					return subUserName;
				}
				set	
				{
					subUserName = value;
				}
			}

			public int? Capacity
			{
				get
				{
					return capacity;
				}
				set	
				{
					capacity = value;
				}
			}

			public string SasInstanceId
			{
				get
				{
					return sasInstanceId;
				}
				set	
				{
					sasInstanceId = value;
				}
			}

			public bool? CanBuy
			{
				get
				{
					return canBuy;
				}
				set	
				{
					canBuy = value;
				}
			}

			public long? EndTime
			{
				get
				{
					return endTime;
				}
				set	
				{
					endTime = value;
				}
			}

			public long? DurationDays
			{
				get
				{
					return durationDays;
				}
				set	
				{
					durationDays = value;
				}
			}
		}
	}
}
