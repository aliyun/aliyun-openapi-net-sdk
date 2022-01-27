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

namespace Aliyun.Acs.OpenSearch.Model.V20171225
{
	public class ListInterventionDictionaryEntriesResponse : AcsResponse
	{

		private string requestId;

		private int? totalCount;

		private List<ListInterventionDictionaryEntries_WordItem> result;

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

		public List<ListInterventionDictionaryEntries_WordItem> Result
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

		public class ListInterventionDictionaryEntries_WordItem
		{

			private string cmd;

			private string word;

			private long? created;

			private long? updated;

			private string status;

			private string relevance;

			private List<ListInterventionDictionaryEntries_Token> tokens;

			public string Cmd
			{
				get
				{
					return cmd;
				}
				set	
				{
					cmd = value;
				}
			}

			public string Word
			{
				get
				{
					return word;
				}
				set	
				{
					word = value;
				}
			}

			public long? Created
			{
				get
				{
					return created;
				}
				set	
				{
					created = value;
				}
			}

			public long? Updated
			{
				get
				{
					return updated;
				}
				set	
				{
					updated = value;
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

			public string Relevance
			{
				get
				{
					return relevance;
				}
				set	
				{
					relevance = value;
				}
			}

			public List<ListInterventionDictionaryEntries_Token> Tokens
			{
				get
				{
					return tokens;
				}
				set	
				{
					tokens = value;
				}
			}

			public class ListInterventionDictionaryEntries_Token
			{

				private string tag;

				private string token;

				private int? order;

				private string tagLabel;

				public string Tag
				{
					get
					{
						return tag;
					}
					set	
					{
						tag = value;
					}
				}

				public string Token
				{
					get
					{
						return token;
					}
					set	
					{
						token = value;
					}
				}

				public int? Order
				{
					get
					{
						return order;
					}
					set	
					{
						order = value;
					}
				}

				public string TagLabel
				{
					get
					{
						return tagLabel;
					}
					set	
					{
						tagLabel = value;
					}
				}
			}
		}
	}
}
