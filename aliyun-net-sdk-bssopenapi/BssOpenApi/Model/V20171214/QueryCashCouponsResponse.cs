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

namespace Aliyun.Acs.BssOpenApi.Model.V20171214
{
	public class QueryCashCouponsResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private string code;

		private string message;

		private List<QueryCashCoupons_CashCoupon> data;

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

		public List<QueryCashCoupons_CashCoupon> Data
		{
			get
			{
				return data;
			}
			set	
			{
				data = value;
			}
		}

		public class QueryCashCoupons_CashCoupon
		{

			private long? cashCouponId;

			private string cashCouponNo;

			private string grantedTime;

			private string effectiveTime;

			private string expiryTime;

			private string applicableProducts;

			private string applicableScenarios;

			private string nominalValue;

			private string balance;

			private string status;

			public long? CashCouponId
			{
				get
				{
					return cashCouponId;
				}
				set	
				{
					cashCouponId = value;
				}
			}

			public string CashCouponNo
			{
				get
				{
					return cashCouponNo;
				}
				set	
				{
					cashCouponNo = value;
				}
			}

			public string GrantedTime
			{
				get
				{
					return grantedTime;
				}
				set	
				{
					grantedTime = value;
				}
			}

			public string EffectiveTime
			{
				get
				{
					return effectiveTime;
				}
				set	
				{
					effectiveTime = value;
				}
			}

			public string ExpiryTime
			{
				get
				{
					return expiryTime;
				}
				set	
				{
					expiryTime = value;
				}
			}

			public string ApplicableProducts
			{
				get
				{
					return applicableProducts;
				}
				set	
				{
					applicableProducts = value;
				}
			}

			public string ApplicableScenarios
			{
				get
				{
					return applicableScenarios;
				}
				set	
				{
					applicableScenarios = value;
				}
			}

			public string NominalValue
			{
				get
				{
					return nominalValue;
				}
				set	
				{
					nominalValue = value;
				}
			}

			public string Balance
			{
				get
				{
					return balance;
				}
				set	
				{
					balance = value;
				}
			}

			public string Status
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
		}
	}
}
