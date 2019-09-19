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

namespace Aliyun.Acs.companyreg.Model.V20190508
{
	public class GetCompanyRegOrderResponse : AcsResponse
	{

		private string requestId;

		private string bizId;

		private string companyName;

		private string bizStatus;

		private string bizInfo;

		private string supplementBizInfo;

		private string aliyunOrderId;

		private long? gmtModified;

		private float? orderAmount;

		private float? yunMarketOrderAmount;

		private long? gmtPaid;

		private string extend;

		private string bizStatusStage;

		private string platformName;

		private string inboundPhone;

		private string outboundPhone;

		private string bizSubCode;

		private List<GetCompanyRegOrder_BizOperation> operations;

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

		public string BizId
		{
			get
			{
				return bizId;
			}
			set	
			{
				bizId = value;
			}
		}

		public string CompanyName
		{
			get
			{
				return companyName;
			}
			set	
			{
				companyName = value;
			}
		}

		public string BizStatus
		{
			get
			{
				return bizStatus;
			}
			set	
			{
				bizStatus = value;
			}
		}

		public string BizInfo
		{
			get
			{
				return bizInfo;
			}
			set	
			{
				bizInfo = value;
			}
		}

		public string SupplementBizInfo
		{
			get
			{
				return supplementBizInfo;
			}
			set	
			{
				supplementBizInfo = value;
			}
		}

		public string AliyunOrderId
		{
			get
			{
				return aliyunOrderId;
			}
			set	
			{
				aliyunOrderId = value;
			}
		}

		public long? GmtModified
		{
			get
			{
				return gmtModified;
			}
			set	
			{
				gmtModified = value;
			}
		}

		public float? OrderAmount
		{
			get
			{
				return orderAmount;
			}
			set	
			{
				orderAmount = value;
			}
		}

		public float? YunMarketOrderAmount
		{
			get
			{
				return yunMarketOrderAmount;
			}
			set	
			{
				yunMarketOrderAmount = value;
			}
		}

		public long? GmtPaid
		{
			get
			{
				return gmtPaid;
			}
			set	
			{
				gmtPaid = value;
			}
		}

		public string Extend
		{
			get
			{
				return extend;
			}
			set	
			{
				extend = value;
			}
		}

		public string BizStatusStage
		{
			get
			{
				return bizStatusStage;
			}
			set	
			{
				bizStatusStage = value;
			}
		}

		public string PlatformName
		{
			get
			{
				return platformName;
			}
			set	
			{
				platformName = value;
			}
		}

		public string InboundPhone
		{
			get
			{
				return inboundPhone;
			}
			set	
			{
				inboundPhone = value;
			}
		}

		public string OutboundPhone
		{
			get
			{
				return outboundPhone;
			}
			set	
			{
				outboundPhone = value;
			}
		}

		public string BizSubCode
		{
			get
			{
				return bizSubCode;
			}
			set	
			{
				bizSubCode = value;
			}
		}

		public List<GetCompanyRegOrder_BizOperation> Operations
		{
			get
			{
				return operations;
			}
			set	
			{
				operations = value;
			}
		}

		public class GetCompanyRegOrder_BizOperation
		{

			private long? gmtAction;

			private string actionType;

			private string actionInfo;

			public long? GmtAction
			{
				get
				{
					return gmtAction;
				}
				set	
				{
					gmtAction = value;
				}
			}

			public string ActionType
			{
				get
				{
					return actionType;
				}
				set	
				{
					actionType = value;
				}
			}

			public string ActionInfo
			{
				get
				{
					return actionInfo;
				}
				set	
				{
					actionInfo = value;
				}
			}
		}
	}
}
