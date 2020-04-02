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

namespace Aliyun.Acs.linkedmall.Model.V20180116
{
	public class InitApplyRefundResponse : AcsResponse
	{

		private string requestId;

		private string code;

		private string message;

		private string subLmOrderId;

		private InitApplyRefund_InitApplyRefundData initApplyRefundData;

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

		public string Code
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

		public string SubLmOrderId
		{
			get
			{
				return subLmOrderId;
			}
			set	
			{
				subLmOrderId = value;
			}
		}

		public InitApplyRefund_InitApplyRefundData InitApplyRefundData
		{
			get
			{
				return initApplyRefundData;
			}
			set	
			{
				initApplyRefundData = value;
			}
		}

		public class InitApplyRefund_InitApplyRefundData
		{

			private int? bizClaimType;

			private bool? mainOrderRefund;

			private List<InitApplyRefund_RefundReasonListItem> refundReasonList;

			private InitApplyRefund_MaxRefundFeeData maxRefundFeeData;

			public int? BizClaimType
			{
				get
				{
					return bizClaimType;
				}
				set	
				{
					bizClaimType = value;
				}
			}

			public bool? MainOrderRefund
			{
				get
				{
					return mainOrderRefund;
				}
				set	
				{
					mainOrderRefund = value;
				}
			}

			public List<InitApplyRefund_RefundReasonListItem> RefundReasonList
			{
				get
				{
					return refundReasonList;
				}
				set	
				{
					refundReasonList = value;
				}
			}

			public InitApplyRefund_MaxRefundFeeData MaxRefundFeeData
			{
				get
				{
					return maxRefundFeeData;
				}
				set	
				{
					maxRefundFeeData = value;
				}
			}

			public class InitApplyRefund_RefundReasonListItem
			{

				private long? reasonTextId;

				private string reasonTips;

				private bool? proofRequired;

				private bool? refundDescRequired;

				public long? ReasonTextId
				{
					get
					{
						return reasonTextId;
					}
					set	
					{
						reasonTextId = value;
					}
				}

				public string ReasonTips
				{
					get
					{
						return reasonTips;
					}
					set	
					{
						reasonTips = value;
					}
				}

				public bool? ProofRequired
				{
					get
					{
						return proofRequired;
					}
					set	
					{
						proofRequired = value;
					}
				}

				public bool? RefundDescRequired
				{
					get
					{
						return refundDescRequired;
					}
					set	
					{
						refundDescRequired = value;
					}
				}
			}

			public class InitApplyRefund_MaxRefundFeeData
			{

				private int? maxRefundFee;

				private int? minRefundFee;

				public int? MaxRefundFee
				{
					get
					{
						return maxRefundFee;
					}
					set	
					{
						maxRefundFee = value;
					}
				}

				public int? MinRefundFee
				{
					get
					{
						return minRefundFee;
					}
					set	
					{
						minRefundFee = value;
					}
				}
			}
		}
	}
}
