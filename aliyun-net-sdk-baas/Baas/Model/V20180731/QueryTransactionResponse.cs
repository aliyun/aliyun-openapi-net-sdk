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
	public class QueryTransactionResponse : AcsResponse
	{

		private string requestId;

		private QueryTransaction_Result result;

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

		public QueryTransaction_Result Result
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

		public class QueryTransaction_Result
		{

			private string hash;

			private long? blockHeight;

			private int? blockVersion;

			private long? createTime;

			private int? category;

			private int? type;

			private int? referenceCount;

			private string content;

			private string contentHash;

			private string keyWrap;

			private string nonce;

			private string keyName;

			private QueryTransaction_ReferenceList referenceList;

			public string Hash
			{
				get
				{
					return hash;
				}
				set	
				{
					hash = value;
				}
			}

			public long? BlockHeight
			{
				get
				{
					return blockHeight;
				}
				set	
				{
					blockHeight = value;
				}
			}

			public int? BlockVersion
			{
				get
				{
					return blockVersion;
				}
				set	
				{
					blockVersion = value;
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

			public int? Category
			{
				get
				{
					return category;
				}
				set	
				{
					category = value;
				}
			}

			public int? Type
			{
				get
				{
					return type;
				}
				set	
				{
					type = value;
				}
			}

			public int? ReferenceCount
			{
				get
				{
					return referenceCount;
				}
				set	
				{
					referenceCount = value;
				}
			}

			public string Content
			{
				get
				{
					return content;
				}
				set	
				{
					content = value;
				}
			}

			public string ContentHash
			{
				get
				{
					return contentHash;
				}
				set	
				{
					contentHash = value;
				}
			}

			public string KeyWrap
			{
				get
				{
					return keyWrap;
				}
				set	
				{
					keyWrap = value;
				}
			}

			public string Nonce
			{
				get
				{
					return nonce;
				}
				set	
				{
					nonce = value;
				}
			}

			public string KeyName
			{
				get
				{
					return keyName;
				}
				set	
				{
					keyName = value;
				}
			}

			public QueryTransaction_ReferenceList ReferenceList
			{
				get
				{
					return referenceList;
				}
				set	
				{
					referenceList = value;
				}
			}

			public class QueryTransaction_ReferenceList
			{

				private int? type;

				private int? length;

				private string data;

				public int? Type
				{
					get
					{
						return type;
					}
					set	
					{
						type = value;
					}
				}

				public int? Length
				{
					get
					{
						return length;
					}
					set	
					{
						length = value;
					}
				}

				public string Data
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
			}
		}
	}
}