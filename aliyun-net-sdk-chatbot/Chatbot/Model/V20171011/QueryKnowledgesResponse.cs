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
	public class QueryKnowledgesResponse : AcsResponse
	{

		private string requestId;

		private int? pageNumber;

		private int? pageSize;

		private int? totalCount;

		private List<QueryKnowledges_Knowledge> knowledges;

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

		public List<QueryKnowledges_Knowledge> Knowledges
		{
			get
			{
				return knowledges;
			}
			set	
			{
				knowledges = value;
			}
		}

		public class QueryKnowledges_Knowledge
		{

			private long? knowledgeId;

			private string modifyTime;

			private string modifyUserName;

			private string createTime;

			private string createUserName;

			private long? categoryId;

			private int? knowledgeStatus;

			private string knowledgeTitle;

			private string startDate;

			private string endDate;

			private string version;

			private List<string> coreWords;

			public long? KnowledgeId
			{
				get
				{
					return knowledgeId;
				}
				set	
				{
					knowledgeId = value;
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

			public string ModifyUserName
			{
				get
				{
					return modifyUserName;
				}
				set	
				{
					modifyUserName = value;
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

			public string CreateUserName
			{
				get
				{
					return createUserName;
				}
				set	
				{
					createUserName = value;
				}
			}

			public long? CategoryId
			{
				get
				{
					return categoryId;
				}
				set	
				{
					categoryId = value;
				}
			}

			public int? KnowledgeStatus
			{
				get
				{
					return knowledgeStatus;
				}
				set	
				{
					knowledgeStatus = value;
				}
			}

			public string KnowledgeTitle
			{
				get
				{
					return knowledgeTitle;
				}
				set	
				{
					knowledgeTitle = value;
				}
			}

			public string StartDate
			{
				get
				{
					return startDate;
				}
				set	
				{
					startDate = value;
				}
			}

			public string EndDate
			{
				get
				{
					return endDate;
				}
				set	
				{
					endDate = value;
				}
			}

			public string Version
			{
				get
				{
					return version;
				}
				set	
				{
					version = value;
				}
			}

			public List<string> CoreWords
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
		}
	}
}