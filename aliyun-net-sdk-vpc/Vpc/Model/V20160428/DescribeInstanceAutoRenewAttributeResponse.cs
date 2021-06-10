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

namespace Aliyun.Acs.Vpc.Model.V20160428
{
	public class DescribeInstanceAutoRenewAttributeResponse : AcsResponse
	{

		private string requestId;

		private string totalCount;

		private string pageSize;

		private string pageNumber;

		private List<DescribeInstanceAutoRenewAttribute_InstanceRenewAttribute> instanceRenewAttributes;

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

		public string TotalCount
		{
			get
			{
				return totalCount;
			}
			set	
			{
				totalCount = value;
			}
		}

		public string PageSize
		{
			get
			{
				return pageSize;
			}
			set	
			{
				pageSize = value;
			}
		}

		public string PageNumber
		{
			get
			{
				return pageNumber;
			}
			set	
			{
				pageNumber = value;
			}
		}

		public List<DescribeInstanceAutoRenewAttribute_InstanceRenewAttribute> InstanceRenewAttributes
		{
			get
			{
				return instanceRenewAttributes;
			}
			set	
			{
				instanceRenewAttributes = value;
			}
		}

		public class DescribeInstanceAutoRenewAttribute_InstanceRenewAttribute
		{

			private string instanceId;

			private string renewalStatus;

			private int? duration;

			private string pricingCycle;

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

			public string PricingCycle
			{
				get
				{
					return pricingCycle;
				}
				set	
				{
					pricingCycle = value;
				}
			}
		}
	}
}
