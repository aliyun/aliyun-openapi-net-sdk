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
	public class QueryRefundApplicationDetailResponse : AcsResponse
	{

		private string requestId;

		private string code;

		private string message;

		private QueryRefundApplicationDetail_RefundApplicationDetail refundApplicationDetail;

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

		public QueryRefundApplicationDetail_RefundApplicationDetail RefundApplicationDetail
		{
			get
			{
				return refundApplicationDetail;
			}
			set	
			{
				refundApplicationDetail = value;
			}
		}

		public class QueryRefundApplicationDetail_RefundApplicationDetail
		{

			private int? bizClaimType;

			private int? orderLogisticsStatus;

			private int? disputeStatus;

			private int? returnGoodLogisticsStatus;

			private string lmOrderId;

			private string subLmOrderId;

			private int? disputeType;

			private long? refundFee;

			private long? realRefundFee;

			private int? returnGoodCount;

			private string disputeDesc;

			private string sellerAgreeMsg;

			private string sellerRefuseAgreementMessage;

			private string applyDisputeDesc;

			private string disputeCreateTime;

			private string disputeEndTime;

			private long? disputeId;

			private string refunderAddress;

			private string refunderName;

			private string refunderTel;

			private string refunderZipCode;

			private string sellerRefuseReason;

			private QueryRefundApplicationDetail_MaxRefundFeeData maxRefundFeeData;

			private QueryRefundApplicationDetail_ApplyReasonText applyReasonText;

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

			public int? OrderLogisticsStatus
			{
				get
				{
					return orderLogisticsStatus;
				}
				set	
				{
					orderLogisticsStatus = value;
				}
			}

			public int? DisputeStatus
			{
				get
				{
					return disputeStatus;
				}
				set	
				{
					disputeStatus = value;
				}
			}

			public int? ReturnGoodLogisticsStatus
			{
				get
				{
					return returnGoodLogisticsStatus;
				}
				set	
				{
					returnGoodLogisticsStatus = value;
				}
			}

			public string LmOrderId
			{
				get
				{
					return lmOrderId;
				}
				set	
				{
					lmOrderId = value;
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

			public int? DisputeType
			{
				get
				{
					return disputeType;
				}
				set	
				{
					disputeType = value;
				}
			}

			public long? RefundFee
			{
				get
				{
					return refundFee;
				}
				set	
				{
					refundFee = value;
				}
			}

			public long? RealRefundFee
			{
				get
				{
					return realRefundFee;
				}
				set	
				{
					realRefundFee = value;
				}
			}

			public int? ReturnGoodCount
			{
				get
				{
					return returnGoodCount;
				}
				set	
				{
					returnGoodCount = value;
				}
			}

			public string DisputeDesc
			{
				get
				{
					return disputeDesc;
				}
				set	
				{
					disputeDesc = value;
				}
			}

			public string SellerAgreeMsg
			{
				get
				{
					return sellerAgreeMsg;
				}
				set	
				{
					sellerAgreeMsg = value;
				}
			}

			public string SellerRefuseAgreementMessage
			{
				get
				{
					return sellerRefuseAgreementMessage;
				}
				set	
				{
					sellerRefuseAgreementMessage = value;
				}
			}

			public string ApplyDisputeDesc
			{
				get
				{
					return applyDisputeDesc;
				}
				set	
				{
					applyDisputeDesc = value;
				}
			}

			public string DisputeCreateTime
			{
				get
				{
					return disputeCreateTime;
				}
				set	
				{
					disputeCreateTime = value;
				}
			}

			public string DisputeEndTime
			{
				get
				{
					return disputeEndTime;
				}
				set	
				{
					disputeEndTime = value;
				}
			}

			public long? DisputeId
			{
				get
				{
					return disputeId;
				}
				set	
				{
					disputeId = value;
				}
			}

			public string RefunderAddress
			{
				get
				{
					return refunderAddress;
				}
				set	
				{
					refunderAddress = value;
				}
			}

			public string RefunderName
			{
				get
				{
					return refunderName;
				}
				set	
				{
					refunderName = value;
				}
			}

			public string RefunderTel
			{
				get
				{
					return refunderTel;
				}
				set	
				{
					refunderTel = value;
				}
			}

			public string RefunderZipCode
			{
				get
				{
					return refunderZipCode;
				}
				set	
				{
					refunderZipCode = value;
				}
			}

			public string SellerRefuseReason
			{
				get
				{
					return sellerRefuseReason;
				}
				set	
				{
					sellerRefuseReason = value;
				}
			}

			public QueryRefundApplicationDetail_MaxRefundFeeData MaxRefundFeeData
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

			public QueryRefundApplicationDetail_ApplyReasonText ApplyReasonText
			{
				get
				{
					return applyReasonText;
				}
				set	
				{
					applyReasonText = value;
				}
			}

			public class QueryRefundApplicationDetail_MaxRefundFeeData
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

			public class QueryRefundApplicationDetail_ApplyReasonText
			{

				private long? reasonTextId;

				private string reasonTips;

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
			}
		}
	}
}
