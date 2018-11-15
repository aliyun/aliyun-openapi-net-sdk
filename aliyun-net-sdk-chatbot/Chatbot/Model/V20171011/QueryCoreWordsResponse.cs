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

namespace Aliyun.Acs.Chatbot.Model.V20171011
{
	public class QueryCoreWordsResponse : AcsResponse
	{

		private string requestId;

		private int? pageNumber;

		private int? pageSize;

		private int? totalCount;

		private List<QueryCoreWords_CoreWord> coreWords;

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

		public int? PageNumber
		{
			get
			{
				return pageNumber;
			}
			set	
			{
				pageNumber = value;
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

		public List<QueryCoreWords_CoreWord> CoreWords
		{
			get
			{
				return coreWords;
			}
			set	
			{
				coreWords = value;
			}
		}

		public class QueryCoreWords_CoreWord
		{

			private string coreWordCode;

			private string coreWordName;

			private string modifyTime;

			private string createTime;

			private List<string> synonyms;

			public string CoreWordCode
			{
				get
				{
					return coreWordCode;
				}
				set	
				{
					coreWordCode = value;
				}
			}

			public string CoreWordName
			{
				get
				{
					return coreWordName;
				}
				set	
				{
					coreWordName = value;
				}
			}

			public string ModifyTime
			{
				get
				{
					return modifyTime;
				}
				set	
				{
					modifyTime = value;
				}
			}

			public string CreateTime
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

			public List<string> Synonyms
			{
				get
				{
					return synonyms;
				}
				set	
				{
					synonyms = value;
				}
			}
		}
	}
}