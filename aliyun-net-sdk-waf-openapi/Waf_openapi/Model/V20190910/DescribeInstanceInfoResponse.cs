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

namespace Aliyun.Acs.waf_openapi.Model.V20190910
{
	public class DescribeInstanceInfoResponse : AcsResponse
	{

		private string requestId;

		private DescribeInstanceInfo_InstanceInfo instanceInfo;

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

		public DescribeInstanceInfo_InstanceInfo InstanceInfo
		{
			get
			{
				return instanceInfo;
			}
			set	
			{
				instanceInfo = value;
			}
		}

		public class DescribeInstanceInfo_InstanceInfo
		{

			private int? status;

			private long? endDate;

			private string version;

			private int? remainDay;

			private string region;

			private int? payType;

			private int? inDebt;

			private string instanceId;

			private string subscriptionType;

			private int? trial;

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

			public string Version
			{
				get
				{
					return version;
				}
				set	
				{
					version = value;
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
		}
	}
}
