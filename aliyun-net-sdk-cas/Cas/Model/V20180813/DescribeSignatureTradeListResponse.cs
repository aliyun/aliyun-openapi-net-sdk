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

namespace Aliyun.Acs.cas.Model.V20180813
{
	public class DescribeSignatureTradeListResponse : AcsResponse
	{

		private string requestId;

		private int? currentPage;

		private int? showSize;

		private int? totalCount;

		private List<DescribeSignatureTradeList_Trade> tradeList;

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

		public int? CurrentPage
		{
			get
			{
				return currentPage;
			}
			set	
			{
				currentPage = value;
			}
		}

		public int? ShowSize
		{
			get
			{
				return showSize;
			}
			set	
			{
				showSize = value;
			}
		}

		public int? TotalCount
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

		public List<DescribeSignatureTradeList_Trade> TradeList
		{
			get
			{
				return tradeList;
			}
			set	
			{
				tradeList = value;
			}
		}

		public class DescribeSignatureTradeList_Trade
		{

			private long? id;

			private string docTitle;

			private string transactionId;

			private string peopleName;

			private long? createTime;

			private int? signStatus;

			private int? signMode;

			private string docId;

			private string peopleId;

			public long? Id
			{
				get
				{
					return id;
				}
				set	
				{
					id = value;
				}
			}

			public string DocTitle
			{
				get
				{
					return docTitle;
				}
				set	
				{
					docTitle = value;
				}
			}

			public string TransactionId
			{
				get
				{
					return transactionId;
				}
				set	
				{
					transactionId = value;
				}
			}

			public string PeopleName
			{
				get
				{
					return peopleName;
				}
				set	
				{
					peopleName = value;
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

			public int? SignStatus
			{
				get
				{
					return signStatus;
				}
				set	
				{
					signStatus = value;
				}
			}

			public int? SignMode
			{
				get
				{
					return signMode;
				}
				set	
				{
					signMode = value;
				}
			}

			public string DocId
			{
				get
				{
					return docId;
				}
				set	
				{
					docId = value;
				}
			}

			public string PeopleId
			{
				get
				{
					return peopleId;
				}
				set	
				{
					peopleId = value;
				}
			}
		}
	}
}
