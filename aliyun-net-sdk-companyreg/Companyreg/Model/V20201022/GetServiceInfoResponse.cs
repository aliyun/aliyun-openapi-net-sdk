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

namespace Aliyun.Acs.companyreg.Model.V20201022
{
	public class GetServiceInfoResponse : AcsResponse
	{

		private string requestId;

		private string openingPeriod;

		private string currentPeriod;

		private long? systemTime;

		private bool? isClearedTrialData;

		private string name;

		private string openingBalanceStatus;

		private GetServiceInfo_InvoiceCheckControlledInfo invoiceCheckControlledInfo;

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

		public string OpeningPeriod
		{
			get
			{
				return openingPeriod;
			}
			set	
			{
				openingPeriod = value;
			}
		}

		public string CurrentPeriod
		{
			get
			{
				return currentPeriod;
			}
			set	
			{
				currentPeriod = value;
			}
		}

		public long? SystemTime
		{
			get
			{
				return systemTime;
			}
			set	
			{
				systemTime = value;
			}
		}

		public bool? IsClearedTrialData
		{
			get
			{
				return isClearedTrialData;
			}
			set	
			{
				isClearedTrialData = value;
			}
		}

		public string Name
		{
			get
			{
				return name;
			}
			set	
			{
				name = value;
			}
		}

		public string OpeningBalanceStatus
		{
			get
			{
				return openingBalanceStatus;
			}
			set	
			{
				openingBalanceStatus = value;
			}
		}

		public GetServiceInfo_InvoiceCheckControlledInfo InvoiceCheckControlledInfo
		{
			get
			{
				return invoiceCheckControlledInfo;
			}
			set	
			{
				invoiceCheckControlledInfo = value;
			}
		}

		public class GetServiceInfo_InvoiceCheckControlledInfo
		{

			private int? monthCheckCount;

			private int? monthLimitCount;

			private int? trialLimitCount;

			private bool? isControlledByLimit;

			public int? MonthCheckCount
			{
				get
				{
					return monthCheckCount;
				}
				set	
				{
					monthCheckCount = value;
				}
			}

			public int? MonthLimitCount
			{
				get
				{
					return monthLimitCount;
				}
				set	
				{
					monthLimitCount = value;
				}
			}

			public int? TrialLimitCount
			{
				get
				{
					return trialLimitCount;
				}
				set	
				{
					trialLimitCount = value;
				}
			}

			public bool? IsControlledByLimit
			{
				get
				{
					return isControlledByLimit;
				}
				set	
				{
					isControlledByLimit = value;
				}
			}
		}
	}
}
