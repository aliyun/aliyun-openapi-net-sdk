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
	public class ListScriptRecordingResponse : AcsResponse
	{

		private int? httpStatusCode;

		private string requestId;

		private bool? success;

		private string code;

		private string message;

		private int? pageSize;

		private int? pageNumber;

		private long? totalCount;

		private List<ListScriptRecording_ScriptRecording> scriptRecordings;

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

		public long? TotalCount
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

		public List<ListScriptRecording_ScriptRecording> ScriptRecordings
		{
			get
			{
				return scriptRecordings;
			}
			set	
			{
				scriptRecordings = value;
			}
		}

		public class ListScriptRecording_ScriptRecording
		{

			private string recordingContent;

			private int? state;

			private string storageUuid;

			private string stateExtend;

			private string instanceId;

			private long? gmtModified;

			private string scriptId;

			private string uuid;

			private long? gmtUpload;

			private int? recordingDuration;

			private string recordingName;

			private long? gmtCreate;

			private string innerId;

			public string RecordingContent
			{
				get
				{
					return recordingContent;
				}
				set	
				{
					recordingContent = value;
				}
			}

			public int? State
			{
				get
				{
					return state;
				}
				set	
				{
					state = value;
				}
			}

			public string StorageUuid
			{
				get
				{
					return storageUuid;
				}
				set	
				{
					storageUuid = value;
				}
			}

			public string StateExtend
			{
				get
				{
					return stateExtend;
				}
				set	
				{
					stateExtend = value;
				}
			}

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

			public long? GmtModified
			{
				get
				{
					return gmtModified;
				}
				set	
				{
					gmtModified = value;
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

			public string Uuid
			{
				get
				{
					return uuid;
				}
				set	
				{
					uuid = value;
				}
			}

			public long? GmtUpload
			{
				get
				{
					return gmtUpload;
				}
				set	
				{
					gmtUpload = value;
				}
			}

			public int? RecordingDuration
			{
				get
				{
					return recordingDuration;
				}
				set	
				{
					recordingDuration = value;
				}
			}

			public string RecordingName
			{
				get
				{
					return recordingName;
				}
				set	
				{
					recordingName = value;
				}
			}

			public long? GmtCreate
			{
				get
				{
					return gmtCreate;
				}
				set	
				{
					gmtCreate = value;
				}
			}

			public string InnerId
			{
				get
				{
					return innerId;
				}
				set	
				{
					innerId = value;
				}
			}
		}
	}
}
