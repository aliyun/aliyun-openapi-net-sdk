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

namespace Aliyun.Acs.scdn.Model.V20171115
{
	public class DescribeScdnServiceResponse : AcsResponse
	{

		private string domainCountValue;

		private string dDoSBasicValue;

		private string changingAffectTime;

		private string ccProtection;

		private string currentDomainCount;

		private string pricingCycle;

		private string openTime;

		private string changingChargeType;

		private string requestId;

		private string currentBandwidthValue;

		private string bandwidth;

		private string domainCount;

		private string protectTypeValue;

		private string currentBandwidth;

		private string priceType;

		private string ccProtectionValue;

		private string currentDDoSBasic;

		private string protectType;

		private string currentElasticProtection;

		private string currentElasticProtectionValue;

		private string instanceId;

		private string currentProtectType;

		private string elasticProtection;

		private string endTime;

		private string currentDDoSBasicValue;

		private string bandwidthValue;

		private string dDoSBasic;

		private string currentDomainCountValue;

		private string elasticProtectionValue;

		private string currentCcProtection;

		private string internetChargeType;

		private string currentProtectTypeValue;

		private string currentCcProtectionValue;

		private List<DescribeScdnService_LockReason> operationLocks;

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

		public string ChangingAffectTime
		{
			get
			{
				return changingAffectTime;
			}
			set	
			{
				changingAffectTime = value;
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

		public string CurrentDomainCount
		{
			get
			{
				return currentDomainCount;
			}
			set	
			{
				currentDomainCount = value;
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

		public string ChangingChargeType
		{
			get
			{
				return changingChargeType;
			}
			set	
			{
				changingChargeType = value;
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

		public string CurrentBandwidthValue
		{
			get
			{
				return currentBandwidthValue;
			}
			set	
			{
				currentBandwidthValue = value;
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

		public string CurrentBandwidth
		{
			get
			{
				return currentBandwidth;
			}
			set	
			{
				currentBandwidth = value;
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

		public string CurrentDDoSBasic
		{
			get
			{
				return currentDDoSBasic;
			}
			set	
			{
				currentDDoSBasic = value;
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

		public string CurrentElasticProtection
		{
			get
			{
				return currentElasticProtection;
			}
			set	
			{
				currentElasticProtection = value;
			}
		}

		public string CurrentElasticProtectionValue
		{
			get
			{
				return currentElasticProtectionValue;
			}
			set	
			{
				currentElasticProtectionValue = value;
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

		public string CurrentProtectType
		{
			get
			{
				return currentProtectType;
			}
			set	
			{
				currentProtectType = value;
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

		public string CurrentDDoSBasicValue
		{
			get
			{
				return currentDDoSBasicValue;
			}
			set	
			{
				currentDDoSBasicValue = value;
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

		public string CurrentDomainCountValue
		{
			get
			{
				return currentDomainCountValue;
			}
			set	
			{
				currentDomainCountValue = value;
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

		public string CurrentCcProtection
		{
			get
			{
				return currentCcProtection;
			}
			set	
			{
				currentCcProtection = value;
			}
		}

		public string InternetChargeType
		{
			get
			{
				return internetChargeType;
			}
			set	
			{
				internetChargeType = value;
			}
		}

		public string CurrentProtectTypeValue
		{
			get
			{
				return currentProtectTypeValue;
			}
			set	
			{
				currentProtectTypeValue = value;
			}
		}

		public string CurrentCcProtectionValue
		{
			get
			{
				return currentCcProtectionValue;
			}
			set	
			{
				currentCcProtectionValue = value;
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
