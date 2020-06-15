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

namespace Aliyun.Acs.waf_openapi.Model.V20190910
{
	public class DescribeInstanceInfosResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeInstanceInfos_InstanceInfo> instanceInfos;

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

		public List<DescribeInstanceInfos_InstanceInfo> InstanceInfos
		{
			get
			{
				return instanceInfos;
			}
			set	
			{
				instanceInfos = value;
			}
		}

		public class DescribeInstanceInfos_InstanceInfo
		{

			private int? inDebt;

			private string instanceId;

			private int? payType;

			private long? endDate;

			private int? remainDay;

			private string region;

			private int? trial;

			private int? status;

			private string subscriptionType;

			public int? InDebt
			{
				get
				{
					return inDebt;
				}
				set	
				{
					inDebt = value;
				}
			}

			public string InstanceId
			{
				get
				{
					return instanceId;
				}
				set	
				{
					instanceId = value;
				}
			}

			public int? PayType
			{
				get
				{
					return payType;
				}
				set	
				{
					payType = value;
				}
			}

			public long? EndDate
			{
				get
				{
					return endDate;
				}
				set	
				{
					endDate = value;
				}
			}

			public int? RemainDay
			{
				get
				{
					return remainDay;
				}
				set	
				{
					remainDay = value;
				}
			}

			public string Region
			{
				get
				{
					return region;
				}
				set	
				{
					region = value;
				}
			}

			public int? Trial
			{
				get
				{
					return trial;
				}
				set	
				{
					trial = value;
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

			public string SubscriptionType
			{
				get
				{
					return subscriptionType;
				}
				set	
				{
					subscriptionType = value;
				}
			}
		}
	}
}
