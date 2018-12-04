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
using Aliyun.Acs.Core;
using System.Collections.Generic;

namespace Aliyun.Acs.Baas.Model.V20180731
{
	public class QueryBlockResponse : AcsResponse
	{

		private string requestId;

		private QueryBlock_Result result;

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

		public QueryBlock_Result Result
		{
			get
			{
				return result;
			}
			set	
			{
				result = value;
			}
		}

		public class QueryBlock_Result
		{

			private string alias;

			private string blockHash;

			private string rootTxHash;

			private int? height;

			private string previousHash;

			private long? createTime;

			private int? transactionSize;

			private string transSummaryList;

			public string Alias
			{
				get
				{
					return alias;
				}
				set	
				{
					alias = value;
				}
			}

			public string BlockHash
			{
				get
				{
					return blockHash;
				}
				set	
				{
					blockHash = value;
				}
			}

			public string RootTxHash
			{
				get
				{
					return rootTxHash;
				}
				set	
				{
					rootTxHash = value;
				}
			}

			public int? Height
			{
				get
				{
					return height;
				}
				set	
				{
					height = value;
				}
			}

			public string PreviousHash
			{
				get
				{
					return previousHash;
				}
				set	
				{
					previousHash = value;
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

			public int? TransactionSize
			{
				get
				{
					return transactionSize;
				}
				set	
				{
					transactionSize = value;
				}
			}

			public string TransSummaryList
			{
				get
				{
					return transSummaryList;
				}
				set	
				{
					transSummaryList = value;
				}
			}
		}
	}
}