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

namespace Aliyun.Acs.VoiceNavigator.Model.V20180612
{
	public class DescribeStatisticalDataResponse : AcsResponse
	{

		private string requestId;

		private long? resolvedQuestionTotalNum;

		private long? conversationTotalNum;

		private string totalResolutionRate;

		private string totalValidAnswerRate;

		private string totalDialoguePassRate;

		private string totalKnowledgeHitRate;

		private List<DescribeStatisticalData_StatisticalDataReport> statisticalDataReports;

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

		public long? ResolvedQuestionTotalNum
		{
			get
			{
				return resolvedQuestionTotalNum;
			}
			set	
			{
				resolvedQuestionTotalNum = value;
			}
		}

		public long? ConversationTotalNum
		{
			get
			{
				return conversationTotalNum;
			}
			set	
			{
				conversationTotalNum = value;
			}
		}

		public string TotalResolutionRate
		{
			get
			{
				return totalResolutionRate;
			}
			set	
			{
				totalResolutionRate = value;
			}
		}

		public string TotalValidAnswerRate
		{
			get
			{
				return totalValidAnswerRate;
			}
			set	
			{
				totalValidAnswerRate = value;
			}
		}

		public string TotalDialoguePassRate
		{
			get
			{
				return totalDialoguePassRate;
			}
			set	
			{
				totalDialoguePassRate = value;
			}
		}

		public string TotalKnowledgeHitRate
		{
			get
			{
				return totalKnowledgeHitRate;
			}
			set	
			{
				totalKnowledgeHitRate = value;
			}
		}

		public List<DescribeStatisticalData_StatisticalDataReport> StatisticalDataReports
		{
			get
			{
				return statisticalDataReports;
			}
			set	
			{
				statisticalDataReports = value;
			}
		}

		public class DescribeStatisticalData_StatisticalDataReport
		{

			private string statisticalDate;

			private int? resolvedQuestionNum;

			private int? totalConversationNum;

			private string resolutionRate;

			private string validAnswerRate;

			private string dialoguePassRate;

			private string knowledgeHitRate;

			public string StatisticalDate
			{
				get
				{
					return statisticalDate;
				}
				set	
				{
					statisticalDate = value;
				}
			}

			public int? ResolvedQuestionNum
			{
				get
				{
					return resolvedQuestionNum;
				}
				set	
				{
					resolvedQuestionNum = value;
				}
			}

			public int? TotalConversationNum
			{
				get
				{
					return totalConversationNum;
				}
				set	
				{
					totalConversationNum = value;
				}
			}

			public string ResolutionRate
			{
				get
				{
					return resolutionRate;
				}
				set	
				{
					resolutionRate = value;
				}
			}

			public string ValidAnswerRate
			{
				get
				{
					return validAnswerRate;
				}
				set	
				{
					validAnswerRate = value;
				}
			}

			public string DialoguePassRate
			{
				get
				{
					return dialoguePassRate;
				}
				set	
				{
					dialoguePassRate = value;
				}
			}

			public string KnowledgeHitRate
			{
				get
				{
					return knowledgeHitRate;
				}
				set	
				{
					knowledgeHitRate = value;
				}
			}
		}
	}
}
