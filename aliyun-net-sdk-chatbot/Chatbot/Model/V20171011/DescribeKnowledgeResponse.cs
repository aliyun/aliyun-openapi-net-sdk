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
	public class DescribeKnowledgeResponse : AcsResponse
	{

		private string requestId;

		private string endDate;

		private string createUserName;

		private string knowledgeTitle;

		private int? version;

		private long? knowledgeId;

		private string modifyUserName;

		private string modifyTime;

		private string createTime;

		private int? knowledgeType;

		private long? categoryId;

		private string startDate;

		private int? knowledgeStatus;

		private List<DescribeKnowledge_Outline> outlines;

		private List<DescribeKnowledge_SimQuestion> simQuestions;

		private List<DescribeKnowledge_Solution> solutions;

		private List<string> keyWords;

		private List<string> coreWords;

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

		public int? Version
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

		public int? KnowledgeType
		{
			get
			{
				return knowledgeType;
			}
			set	
			{
				knowledgeType = value;
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

		public List<DescribeKnowledge_Outline> Outlines
		{
			get
			{
				return outlines;
			}
			set	
			{
				outlines = value;
			}
		}

		public List<DescribeKnowledge_SimQuestion> SimQuestions
		{
			get
			{
				return simQuestions;
			}
			set	
			{
				simQuestions = value;
			}
		}

		public List<DescribeKnowledge_Solution> Solutions
		{
			get
			{
				return solutions;
			}
			set	
			{
				solutions = value;
			}
		}

		public List<string> KeyWords
		{
			get
			{
				return keyWords;
			}
			set	
			{
				keyWords = value;
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

		public class DescribeKnowledge_Outline
		{

			private long? knowledgeId;

			private string title;

			private long? outlineId;

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

			public string Title
			{
				get
				{
					return title;
				}
				set	
				{
					title = value;
				}
			}

			public long? OutlineId
			{
				get
				{
					return outlineId;
				}
				set	
				{
					outlineId = value;
				}
			}
		}

		public class DescribeKnowledge_SimQuestion
		{

			private string modifyTime;

			private string createTime;

			private long? simQuestionId;

			private string title;

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

			public long? SimQuestionId
			{
				get
				{
					return simQuestionId;
				}
				set	
				{
					simQuestionId = value;
				}
			}

			public string Title
			{
				get
				{
					return title;
				}
				set	
				{
					title = value;
				}
			}
		}

		public class DescribeKnowledge_Solution
		{

			private string summary;

			private string modifyTime;

			private string createTime;

			private long? solutionId;

			private string content;

			private string plainText;

			private List<string> perspectiveIds;

			public string Summary
			{
				get
				{
					return summary;
				}
				set	
				{
					summary = value;
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

			public long? SolutionId
			{
				get
				{
					return solutionId;
				}
				set	
				{
					solutionId = value;
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

			public string PlainText
			{
				get
				{
					return plainText;
				}
				set	
				{
					plainText = value;
				}
			}

			public List<string> PerspectiveIds
			{
				get
				{
					return perspectiveIds;
				}
				set	
				{
					perspectiveIds = value;
				}
			}
		}
	}
}