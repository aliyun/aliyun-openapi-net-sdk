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
using Aliyun.Acs.Core;
using System.Collections.Generic;

namespace Aliyun.Acs.scdn.Model.V20171115
{
	public class DescribeScdnServiceResponse : AcsResponse
	{

		private string requestId;

		private string instanceId;

		private string openTime;

		private string endTime;

		private string protectType;

		private string protectTypeValue;

		private string bandwidth;

		private string ccProtection;

		private string dDoSBasic;

		private string domainCount;

		private string elasticProtection;

		private string bandwidthValue;

		private string ccProtectionValue;

		private string dDoSBasicValue;

		private string domainCountValue;

		private string elasticProtectionValue;

		private string priceType;

		private string pricingCycle;

		private List<DescribeScdnService_LockReason> operationLocks;

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

		public string OpenTime
		{
			get
			{
				return openTime;
			}
			set	
			{
				openTime = value;
			}
		}

		public string EndTime
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

		public string ProtectType
		{
			get
			{
				return protectType;
			}
			set	
			{
				protectType = value;
			}
		}

		public string ProtectTypeValue
		{
			get
			{
				return protectTypeValue;
			}
			set	
			{
				protectTypeValue = value;
			}
		}

		public string Bandwidth
		{
			get
			{
				return bandwidth;
			}
			set	
			{
				bandwidth = value;
			}
		}

		public string CcProtection
		{
			get
			{
				return ccProtection;
			}
			set	
			{
				ccProtection = value;
			}
		}

		public string DDoSBasic
		{
			get
			{
				return dDoSBasic;
			}
			set	
			{
				dDoSBasic = value;
			}
		}

		public string DomainCount
		{
			get
			{
				return domainCount;
			}
			set	
			{
				domainCount = value;
			}
		}

		public string ElasticProtection
		{
			get
			{
				return elasticProtection;
			}
			set	
			{
				elasticProtection = value;
			}
		}

		public string BandwidthValue
		{
			get
			{
				return bandwidthValue;
			}
			set	
			{
				bandwidthValue = value;
			}
		}

		public string CcProtectionValue
		{
			get
			{
				return ccProtectionValue;
			}
			set	
			{
				ccProtectionValue = value;
			}
		}

		public string DDoSBasicValue
		{
			get
			{
				return dDoSBasicValue;
			}
			set	
			{
				dDoSBasicValue = value;
			}
		}

		public string DomainCountValue
		{
			get
			{
				return domainCountValue;
			}
			set	
			{
				domainCountValue = value;
			}
		}

		public string ElasticProtectionValue
		{
			get
			{
				return elasticProtectionValue;
			}
			set	
			{
				elasticProtectionValue = value;
			}
		}

		public string PriceType
		{
			get
			{
				return priceType;
			}
			set	
			{
				priceType = value;
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

		public List<DescribeScdnService_LockReason> OperationLocks
		{
			get
			{
				return operationLocks;
			}
			set	
			{
				operationLocks = value;
			}
		}

		public class DescribeScdnService_LockReason
		{

			private string lockReason;

			public string LockReason
			{
				get
				{
					return lockReason;
				}
				set	
				{
					lockReason = value;
				}
			}
		}
	}
}