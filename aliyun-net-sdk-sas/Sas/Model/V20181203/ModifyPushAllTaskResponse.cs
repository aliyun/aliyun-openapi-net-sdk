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

namespace Aliyun.Acs.Sas.Model.V20181203
{
	public class ModifyPushAllTaskResponse : AcsResponse
	{

		private string requestId;

		private ModifyPushAllTask_PushTaskRsp pushTaskRsp;

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

		public ModifyPushAllTask_PushTaskRsp PushTaskRsp
		{
			get
			{
				return pushTaskRsp;
			}
			set	
			{
				pushTaskRsp = value;
			}
		}

		public class ModifyPushAllTask_PushTaskRsp
		{

			private List<ModifyPushAllTask_PushTaskResult> pushTaskResultList;

			public List<ModifyPushAllTask_PushTaskResult> PushTaskResultList
			{
				get
				{
					return pushTaskResultList;
				}
				set	
				{
					pushTaskResultList = value;
				}
			}

			public class ModifyPushAllTask_PushTaskResult
			{

				private string uuid;

				private long? groupId;

				private bool? success;

				private string region;

				private string instanceName;

				private bool? online;

				private string message;

				private string ip;

				private string osVersion;

				private string instanceId;

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

				public long? GroupId
				{
					get
					{
						return groupId;
					}
					set	
					{
						groupId = value;
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

				public string Region
				{
					get
					{
						return region;
					}
					set	
					{
						region = value;
					}
				}

				public string InstanceName
				{
					get
					{
						return instanceName;
					}
					set	
					{
						instanceName = value;
					}
				}

				public bool? Online
				{
					get
					{
						return online;
					}
					set	
					{
						online = value;
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

				public string Ip
				{
					get
					{
						return ip;
					}
					set	
					{
						ip = value;
					}
				}

				public string OsVersion
				{
					get
					{
						return osVersion;
					}
					set	
					{
						osVersion = value;
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
			}
		}
	}
}
