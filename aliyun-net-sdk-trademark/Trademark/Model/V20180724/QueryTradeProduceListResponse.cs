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

namespace Aliyun.Acs.Trademark.Model.V20180724
{
	public class QueryTradeProduceListResponse : AcsResponse
	{

		private string requestId;

		private int? totalItemNum;

		private int? currentPageNum;

		private int? pageSize;

		private int? totalPageNum;

		private List<QueryTradeProduceList_TradeProduces> data;

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

		public int? TotalItemNum
		{
			get
			{
				return totalItemNum;
			}
			set	
			{
				totalItemNum = value;
			}
		}

		public int? CurrentPageNum
		{
			get
			{
				return currentPageNum;
			}
			set	
			{
				currentPageNum = value;
			}
		}

		public int? PageSize
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

		public int? TotalPageNum
		{
			get
			{
				return totalPageNum;
			}
			set	
			{
				totalPageNum = value;
			}
		}

		public List<QueryTradeProduceList_TradeProduces> Data
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

		public class QueryTradeProduceList_TradeProduces
		{

			private string bizId;

			private string preOrderId;

			private int? preAmount;

			private int? finalAmount;

			private string registerNumber;

			private string classification;

			private string icon;

			private string operateNote;

			private int? buyerStatus;

			private string userId;

			private long? createTime;

			private long? updateTime;

			private bool? allowCancel;

			private int? failReason;

			private int? source;

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

			public string PreOrderId
			{
				get
				{
					return preOrderId;
				}
				set	
				{
					preOrderId = value;
				}
			}

			public int? PreAmount
			{
				get
				{
					return preAmount;
				}
				set	
				{
					preAmount = value;
				}
			}

			public int? FinalAmount
			{
				get
				{
					return finalAmount;
				}
				set	
				{
					finalAmount = value;
				}
			}

			public string RegisterNumber
			{
				get
				{
					return registerNumber;
				}
				set	
				{
					registerNumber = value;
				}
			}

			public string Classification
			{
				get
				{
					return classification;
				}
				set	
				{
					classification = value;
				}
			}

			public string Icon
			{
				get
				{
					return icon;
				}
				set	
				{
					icon = value;
				}
			}

			public string OperateNote
			{
				get
				{
					return operateNote;
				}
				set	
				{
					operateNote = value;
				}
			}

			public int? BuyerStatus
			{
				get
				{
					return buyerStatus;
				}
				set	
				{
					buyerStatus = value;
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

			public long? CreateTime
			{
				get
				{
					return createTime;
				}
				set	
				{
					createTime = value;
				}
			}

			public long? UpdateTime
			{
				get
				{
					return updateTime;
				}
				set	
				{
					updateTime = value;
				}
			}

			public bool? AllowCancel
			{
				get
				{
					return allowCancel;
				}
				set	
				{
					allowCancel = value;
				}
			}

			public int? FailReason
			{
				get
				{
					return failReason;
				}
				set	
				{
					failReason = value;
				}
			}

			public int? Source
			{
				get
				{
					return source;
				}
				set	
				{
					source = value;
				}
			}
		}
	}
}
