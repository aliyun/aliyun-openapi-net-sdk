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

namespace Aliyun.Acs.dt_oc_info.Model.V20220829
{
	public class GetOcIpTrademarkResponse : AcsResponse
	{

		private string code;

		private bool? success;

		private string message;

		private int? totalNum;

		private int? pageIndex;

		private int? pageNum;

		private string requestId;

		private List<GetOcIpTrademark_DataItem> data;

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

		public int? TotalNum
		{
			get
			{
				return totalNum;
			}
			set	
			{
				totalNum = value;
			}
		}

		public int? PageIndex
		{
			get
			{
				return pageIndex;
			}
			set	
			{
				pageIndex = value;
			}
		}

		public int? PageNum
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

		public List<GetOcIpTrademark_DataItem> Data
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

		public class GetOcIpTrademark_DataItem
		{

			private string entName;

			private string trademarkName;

			private string regNum;

			private string trademarkType;

			private string trademarkForm;

			private string trademarkStatus;

			private string applyDate;

			private string imageUrl;

			private string typeName;

			private string period;

			private string agent;

			private string regPubNo;

			private string regPubDate;

			private string firstPubNo;

			private string firstPubDate;

			public string EntName
			{
				get
				{
					return entName;
				}
				set	
				{
					entName = value;
				}
			}

			public string TrademarkName
			{
				get
				{
					return trademarkName;
				}
				set	
				{
					trademarkName = value;
				}
			}

			public string RegNum
			{
				get
				{
					return regNum;
				}
				set	
				{
					regNum = value;
				}
			}

			public string TrademarkType
			{
				get
				{
					return trademarkType;
				}
				set	
				{
					trademarkType = value;
				}
			}

			public string TrademarkForm
			{
				get
				{
					return trademarkForm;
				}
				set	
				{
					trademarkForm = value;
				}
			}

			public string TrademarkStatus
			{
				get
				{
					return trademarkStatus;
				}
				set	
				{
					trademarkStatus = value;
				}
			}

			public string ApplyDate
			{
				get
				{
					return applyDate;
				}
				set	
				{
					applyDate = value;
				}
			}

			public string ImageUrl
			{
				get
				{
					return imageUrl;
				}
				set	
				{
					imageUrl = value;
				}
			}

			public string TypeName
			{
				get
				{
					return typeName;
				}
				set	
				{
					typeName = value;
				}
			}

			public string Period
			{
				get
				{
					return period;
				}
				set	
				{
					period = value;
				}
			}

			public string Agent
			{
				get
				{
					return agent;
				}
				set	
				{
					agent = value;
				}
			}

			public string RegPubNo
			{
				get
				{
					return regPubNo;
				}
				set	
				{
					regPubNo = value;
				}
			}

			public string RegPubDate
			{
				get
				{
					return regPubDate;
				}
				set	
				{
					regPubDate = value;
				}
			}

			public string FirstPubNo
			{
				get
				{
					return firstPubNo;
				}
				set	
				{
					firstPubNo = value;
				}
			}

			public string FirstPubDate
			{
				get
				{
					return firstPubDate;
				}
				set	
				{
					firstPubDate = value;
				}
			}
		}
	}
}
