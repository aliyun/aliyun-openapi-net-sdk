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
	public class ListDialogueFlowsResponse : AcsResponse
	{

		private string code;

		private int? httpStatusCode;

		private string message;

		private string requestId;

		private bool? success;

		private List<ListDialogueFlows_DialogueFlow> dialogueFlows;

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

		public List<ListDialogueFlows_DialogueFlow> DialogueFlows
		{
			get
			{
				return dialogueFlows;
			}
			set	
			{
				dialogueFlows = value;
			}
		}

		public class ListDialogueFlows_DialogueFlow
		{

			private string dialogueFlowDefinition;

			private string dialogueFlowId;

			private string dialogueFlowName;

			private string dialogueFlowType;

			private string scriptId;

			private string scriptVersion;

			public string DialogueFlowDefinition
			{
				get
				{
					return dialogueFlowDefinition;
				}
				set	
				{
					dialogueFlowDefinition = value;
				}
			}

			public string DialogueFlowId
			{
				get
				{
					return dialogueFlowId;
				}
				set	
				{
					dialogueFlowId = value;
				}
			}

			public string DialogueFlowName
			{
				get
				{
					return dialogueFlowName;
				}
				set	
				{
					dialogueFlowName = value;
				}
			}

			public string DialogueFlowType
			{
				get
				{
					return dialogueFlowType;
				}
				set	
				{
					dialogueFlowType = value;
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

			public string ScriptVersion
			{
				get
				{
					return scriptVersion;
				}
				set	
				{
					scriptVersion = value;
				}
			}
		}
	}
}
