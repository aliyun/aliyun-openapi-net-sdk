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
	public class ModifyScriptVoiceConfigResponse : AcsResponse
	{

		private string code;

		private int? httpStatusCode;

		private string message;

		private string requestId;

		private bool? success;

		private ModifyScriptVoiceConfig_ScriptVoiceConfig scriptVoiceConfig;

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

		public ModifyScriptVoiceConfig_ScriptVoiceConfig ScriptVoiceConfig
		{
			get
			{
				return scriptVoiceConfig;
			}
			set	
			{
				scriptVoiceConfig = value;
			}
		}

		public class ModifyScriptVoiceConfig_ScriptVoiceConfig
		{

			private string instanceId;

			private string scriptContent;

			private string scriptId;

			private string scriptVoiceConfigId;

			private string scriptWaveformRelation;

			private string source;

			private string type;

			public string InstanceId
			{
				get
				{
					return instanceId;
				}
				set	
				{
					instanceId = value;
				}
			}

			public string ScriptContent
			{
				get
				{
					return scriptContent;
				}
				set	
				{
					scriptContent = value;
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

			public string ScriptVoiceConfigId
			{
				get
				{
					return scriptVoiceConfigId;
				}
				set	
				{
					scriptVoiceConfigId = value;
				}
			}

			public string ScriptWaveformRelation
			{
				get
				{
					return scriptWaveformRelation;
				}
				set	
				{
					scriptWaveformRelation = value;
				}
			}

			public string Source
			{
				get
				{
					return source;
				}
				set	
				{
					source = value;
				}
			}

			public string Type
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
		}
	}
}
