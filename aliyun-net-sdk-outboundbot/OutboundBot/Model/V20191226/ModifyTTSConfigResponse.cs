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
	public class ModifyTTSConfigResponse : AcsResponse
	{

		private string code;

		private int? httpStatusCode;

		private string message;

		private string requestId;

		private bool? success;

		private ModifyTTSConfig_TTSConfig tTSConfig;

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

		public ModifyTTSConfig_TTSConfig TTSConfig
		{
			get
			{
				return tTSConfig;
			}
			set	
			{
				tTSConfig = value;
			}
		}

		public class ModifyTTSConfig_TTSConfig
		{

			private string instanceId;

			private string scriptId;

			private string speechRate;

			private string tTSConfigId;

			private string voice;

			private string volume;

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

			public string SpeechRate
			{
				get
				{
					return speechRate;
				}
				set	
				{
					speechRate = value;
				}
			}

			public string TTSConfigId
			{
				get
				{
					return tTSConfigId;
				}
				set	
				{
					tTSConfigId = value;
				}
			}

			public string Voice
			{
				get
				{
					return voice;
				}
				set	
				{
					voice = value;
				}
			}

			public string Volume
			{
				get
				{
					return volume;
				}
				set	
				{
					volume = value;
				}
			}
		}
	}
}
