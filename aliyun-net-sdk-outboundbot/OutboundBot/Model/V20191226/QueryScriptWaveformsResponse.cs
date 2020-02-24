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
	public class QueryScriptWaveformsResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private string code;

		private string message;

		private int? httpStatusCode;

		private List<QueryScriptWaveforms_ScriptWaveform> scriptWaveforms;

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

		public List<QueryScriptWaveforms_ScriptWaveform> ScriptWaveforms
		{
			get
			{
				return scriptWaveforms;
			}
			set	
			{
				scriptWaveforms = value;
			}
		}

		public class QueryScriptWaveforms_ScriptWaveform
		{

			private string scriptWaveformId;

			private string scriptId;

			private string scriptContent;

			private string fileId;

			private string fileName;

			public string ScriptWaveformId
			{
				get
				{
					return scriptWaveformId;
				}
				set	
				{
					scriptWaveformId = value;
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

			public string FileId
			{
				get
				{
					return fileId;
				}
				set	
				{
					fileId = value;
				}
			}

			public string FileName
			{
				get
				{
					return fileName;
				}
				set	
				{
					fileName = value;
				}
			}
		}
	}
}
