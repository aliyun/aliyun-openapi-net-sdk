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

namespace Aliyun.Acs.Copyright.Model.V20190123
{
	public class DescribeUserProduceResponse : AcsResponse
	{

		private string bizId;

		private string bizType;

		private string endTime;

		private string errorCode;

		private string errorMsg;

		private string extInfo;

		private string intentionBizId;

		private string orderId;

		private string orderPrice;

		private string partnerCode;

		private string requestId;

		private string solutionBizId;

		private string startTime;

		private int? status;

		private bool? success;

		private string userId;

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

		public string BizType
		{
			get
			{
				return bizType;
			}
			set	
			{
				bizType = value;
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

		public string ErrorCode
		{
			get
			{
				return errorCode;
			}
			set	
			{
				errorCode = value;
			}
		}

		public string ErrorMsg
		{
			get
			{
				return errorMsg;
			}
			set	
			{
				errorMsg = value;
			}
		}

		public string ExtInfo
		{
			get
			{
				return extInfo;
			}
			set	
			{
				extInfo = value;
			}
		}

		public string IntentionBizId
		{
			get
			{
				return intentionBizId;
			}
			set	
			{
				intentionBizId = value;
			}
		}

		public string OrderId
		{
			get
			{
				return orderId;
			}
			set	
			{
				orderId = value;
			}
		}

		public string OrderPrice
		{
			get
			{
				return orderPrice;
			}
			set	
			{
				orderPrice = value;
			}
		}

		public string PartnerCode
		{
			get
			{
				return partnerCode;
			}
			set	
			{
				partnerCode = value;
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

		public string SolutionBizId
		{
			get
			{
				return solutionBizId;
			}
			set	
			{
				solutionBizId = value;
			}
		}

		public string StartTime
		{
			get
			{
				return startTime;
			}
			set	
			{
				startTime = value;
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

		public bool? Success
		{
			get
			{
				return success;
			}
			set	
			{
				success = value;
			}
		}

		public string UserId
		{
			get
			{
				return userId;
			}
			set	
			{
				userId = value;
			}
		}
	}
}
