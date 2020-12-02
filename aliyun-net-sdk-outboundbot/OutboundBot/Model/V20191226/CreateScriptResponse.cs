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

namespace Aliyun.Acs.OutboundBot.Model.V20191226
{
	public class CreateScriptResponse : AcsResponse
	{

		private string code;

		private int? httpStatusCode;

		private string message;

		private string requestId;

		private bool? success;

		private string chatbotId;

		private CreateScript_Script script;

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

		public string ChatbotId
		{
			get
			{
				return chatbotId;
			}
			set	
			{
				chatbotId = value;
			}
		}

		public CreateScript_Script Script
		{
			get
			{
				return script;
			}
			set	
			{
				script = value;
			}
		}

		public class CreateScript_Script
		{

			private string debugStatus;

			private string industry;

			private bool? isDebugDrafted;

			private bool? isDrafted;

			private string scene;

			private string scriptDescription;

			private string scriptId;

			private string scriptName;

			private string status;

			private long? updateTime;

			public string DebugStatus
			{
				get
				{
					return debugStatus;
				}
				set	
				{
					debugStatus = value;
				}
			}

			public string Industry
			{
				get
				{
					return industry;
				}
				set	
				{
					industry = value;
				}
			}

			public bool? IsDebugDrafted
			{
				get
				{
					return isDebugDrafted;
				}
				set	
				{
					isDebugDrafted = value;
				}
			}

			public bool? IsDrafted
			{
				get
				{
					return isDrafted;
				}
				set	
				{
					isDrafted = value;
				}
			}

			public string Scene
			{
				get
				{
					return scene;
				}
				set	
				{
					scene = value;
				}
			}

			public string ScriptDescription
			{
				get
				{
					return scriptDescription;
				}
				set	
				{
					scriptDescription = value;
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

			public string ScriptName
			{
				get
				{
					return scriptName;
				}
				set	
				{
					scriptName = value;
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

			public long? UpdateTime
			{
				get
				{
					return updateTime;
				}
				set	
				{
					updateTime = value;
				}
			}
		}
	}
}
