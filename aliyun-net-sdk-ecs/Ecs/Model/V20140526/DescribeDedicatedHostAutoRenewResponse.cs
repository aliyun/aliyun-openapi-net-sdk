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

namespace Aliyun.Acs.Ecs.Model.V20140526
{
	public class DescribeDedicatedHostAutoRenewResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeDedicatedHostAutoRenew_DedicatedHostRenewAttribute> dedicatedHostRenewAttributes;

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

		public List<DescribeDedicatedHostAutoRenew_DedicatedHostRenewAttribute> DedicatedHostRenewAttributes
		{
			get
			{
				return dedicatedHostRenewAttributes;
			}
			set	
			{
				dedicatedHostRenewAttributes = value;
			}
		}

		public class DescribeDedicatedHostAutoRenew_DedicatedHostRenewAttribute
		{

			private string dedicatedHostId;

			private bool? autoRenewEnabled;

			private int? duration;

			private string periodUnit;

			private string renewalStatus;

			public string DedicatedHostId
			{
				get
				{
					return dedicatedHostId;
				}
				set	
				{
					dedicatedHostId = value;
				}
			}

			public bool? AutoRenewEnabled
			{
				get
				{
					return autoRenewEnabled;
				}
				set	
				{
					autoRenewEnabled = value;
				}
			}

			public int? Duration
			{
				get
				{
					return duration;
				}
				set	
				{
					duration = value;
				}
			}

			public string PeriodUnit
			{
				get
				{
					return periodUnit;
				}
				set	
				{
					periodUnit = value;
				}
			}

			public string RenewalStatus
			{
				get
				{
					return renewalStatus;
				}
				set	
				{
					renewalStatus = value;
				}
			}
		}
	}
}
