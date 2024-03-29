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
using Newtonsoft.Json;
using Aliyun.Acs.Core;

namespace Aliyun.Acs.OutboundBot.Model.V20191226
{
	public class DescribeGlobalQuestionResponse : AcsResponse
	{

		private int? httpStatusCode;

		private string code;

		private string message;

		private string requestId;

		private bool? success;

		private DescribeGlobalQuestion_GlobalQuestion globalQuestion;

		public int? HttpStatusCode
		{
			get
			{
				return httpStatusCode;
			}
			set	
			{
				httpStatusCode = value;
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

		public bool? Success
		{
			get
			{
				return success;
			}
			set	
			{
				success = value;
			}
		}

		public DescribeGlobalQuestion_GlobalQuestion GlobalQuestion
		{
			get
			{
				return globalQuestion;
			}
			set	
			{
				globalQuestion = value;
			}
		}

		public class DescribeGlobalQuestion_GlobalQuestion
		{

			private string globalQuestionId;

			private string answers;

			private string globalQuestionType;

			private string globalQuestionName;

			private string questions;

			private string scriptId;

			public string GlobalQuestionId
			{
				get
				{
					return globalQuestionId;
				}
				set	
				{
					globalQuestionId = value;
				}
			}

			public string Answers
			{
				get
				{
					return answers;
				}
				set	
				{
					answers = value;
				}
			}

			public string GlobalQuestionType
			{
				get
				{
					return globalQuestionType;
				}
				set	
				{
					globalQuestionType = value;
				}
			}

			public string GlobalQuestionName
			{
				get
				{
					return globalQuestionName;
				}
				set	
				{
					globalQuestionName = value;
				}
			}

			public string Questions
			{
				get
				{
					return questions;
				}
				set	
				{
					questions = value;
				}
			}

			public string ScriptId
			{
				get
				{
					return scriptId;
				}
				set	
				{
					scriptId = value;
				}
			}
		}
	}
}
