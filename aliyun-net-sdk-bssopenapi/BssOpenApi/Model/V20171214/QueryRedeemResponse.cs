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

namespace Aliyun.Acs.BssOpenApi.Model.V20171214
{
	public class QueryRedeemResponse : AcsResponse
	{

		private string code;

		private string message;

		private string requestId;

		private bool? success;

		private QueryRedeem_Data data;

		[JsonProperty(PropertyName = "Code")]
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

		[JsonProperty(PropertyName = "Message")]
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

		[JsonProperty(PropertyName = "RequestId")]
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

		[JsonProperty(PropertyName = "Success")]
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

		[JsonProperty(PropertyName = "Data")]
		public QueryRedeem_Data Data
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

		public class QueryRedeem_Data
		{

			private long? pageNum;

			private long? pageSize;

			private long? totalCount;

			private List<QueryRedeem_RedeemItem> redeem;

			[JsonProperty(PropertyName = "PageNum")]
			public long? PageNum
			{
				get
				{
					return pageNum;
				}
				set	
				{
					pageNum = value;
				}
			}

			[JsonProperty(PropertyName = "PageSize")]
			public long? PageSize
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

			[JsonProperty(PropertyName = "TotalCount")]
			public long? TotalCount
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

			[JsonProperty(PropertyName = "Redeem")]
			public List<QueryRedeem_RedeemItem> Redeem
			{
				get
				{
					return redeem;
				}
				set	
				{
					redeem = value;
				}
			}

			public class QueryRedeem_RedeemItem
			{

				private string expiryTime;

				private string grantedTime;

				private string status;

				private string specification;

				private string nominalValue;

				private string effectiveTime;

				private string redeemId;

				private string redeemNo;

				private string applicableProducts;

				private string balance;

				[JsonProperty(PropertyName = "ExpiryTime")]
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

				[JsonProperty(PropertyName = "GrantedTime")]
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

				[JsonProperty(PropertyName = "Status")]
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

				[JsonProperty(PropertyName = "Specification")]
				public string Specification
				{
					get
					{
						return specification;
					}
					set	
					{
						specification = value;
					}
				}

				[JsonProperty(PropertyName = "NominalValue")]
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

				[JsonProperty(PropertyName = "EffectiveTime")]
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

				[JsonProperty(PropertyName = "RedeemId")]
				public string RedeemId
				{
					get
					{
						return redeemId;
					}
					set	
					{
						redeemId = value;
					}
				}

				[JsonProperty(PropertyName = "RedeemNo")]
				public string RedeemNo
				{
					get
					{
						return redeemNo;
					}
					set	
					{
						redeemNo = value;
					}
				}

				[JsonProperty(PropertyName = "ApplicableProducts")]
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

				[JsonProperty(PropertyName = "Balance")]
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
			}
		}
	}
}
