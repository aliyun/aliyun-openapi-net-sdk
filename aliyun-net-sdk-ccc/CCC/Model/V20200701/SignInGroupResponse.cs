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

namespace Aliyun.Acs.CCC.Model.V20200701
{
	public class SignInGroupResponse : AcsResponse
	{

		private string code;

		private int? httpStatusCode;

		private string message;

		private string requestId;

		private List<string> _params;

		private SignInGroup_Data data;

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

		public List<string> _Params
		{
			get
			{
				return _params;
			}
			set	
			{
				_params = value;
			}
		}

		public SignInGroup_Data Data
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

		public class SignInGroup_Data
		{

			private string breakCode;

			private string deviceId;

			private string extension;

			private string instanceId;

			private string jobId;

			private bool? outboundScenario;

			private string userId;

			private string userState;

			private string workMode;

			private List<string> signedSkillGroupIdList;

			public string BreakCode
			{
				get
				{
					return breakCode;
				}
				set	
				{
					breakCode = value;
				}
			}

			public string DeviceId
			{
				get
				{
					return deviceId;
				}
				set	
				{
					deviceId = value;
				}
			}

			public string Extension
			{
				get
				{
					return extension;
				}
				set	
				{
					extension = value;
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

			public string JobId
			{
				get
				{
					return jobId;
				}
				set	
				{
					jobId = value;
				}
			}

			public bool? OutboundScenario
			{
				get
				{
					return outboundScenario;
				}
				set	
				{
					outboundScenario = value;
				}
			}

			public string UserId
			{
				get
				{
					return userId;
				}
				set	
				{
					userId = value;
				}
			}

			public string UserState
			{
				get
				{
					return userState;
				}
				set	
				{
					userState = value;
				}
			}

			public string WorkMode
			{
				get
				{
					return workMode;
				}
				set	
				{
					workMode = value;
				}
			}

			public List<string> SignedSkillGroupIdList
			{
				get
				{
					return signedSkillGroupIdList;
				}
				set	
				{
					signedSkillGroupIdList = value;
				}
			}
		}
	}
}
