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

namespace Aliyun.Acs.imageprocess.Model.V20200320
{
	public class RunMedQAResponse : AcsResponse
	{

		private string message;

		private string requestId;

		private string code;

		private RunMedQA_Data data;

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

		public RunMedQA_Data Data
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

		public class RunMedQA_Data
		{

			private string reports;

			private string questionType;

			private string answerType;

			private string question;

			private string sessionId;

			private List<string> options;

			public string Reports
			{
				get
				{
					return reports;
				}
				set	
				{
					reports = value;
				}
			}

			public string QuestionType
			{
				get
				{
					return questionType;
				}
				set	
				{
					questionType = value;
				}
			}

			public string AnswerType
			{
				get
				{
					return answerType;
				}
				set	
				{
					answerType = value;
				}
			}

			public string Question
			{
				get
				{
					return question;
				}
				set	
				{
					question = value;
				}
			}

			public string SessionId
			{
				get
				{
					return sessionId;
				}
				set	
				{
					sessionId = value;
				}
			}

			public List<string> Options
			{
				get
				{
					return options;
				}
				set	
				{
					options = value;
				}
			}
		}
	}
}
