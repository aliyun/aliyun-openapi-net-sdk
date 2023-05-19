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

namespace Aliyun.Acs.OceanBasePro.Model.V20190901
{
	public class KillProcessListResponse : AcsResponse
	{

		private string requestId;

		private List<KillProcessList_DataItem> data;

		[JsonProperty(PropertyName = "RequestId")]
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

		[JsonProperty(PropertyName = "Data")]
		public List<KillProcessList_DataItem> Data
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

		public class KillProcessList_DataItem
		{

			private long? sessionId;

			private string serverIp;

			private string status;

			private string errorMessage;

			private string clientIp;

			private string tenantId;

			private string user;

			private string database;

			private string sqlText;

			private string command;

			private string executeTime;

			[JsonProperty(PropertyName = "SessionId")]
			public long? SessionId
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

			[JsonProperty(PropertyName = "ServerIp")]
			public string ServerIp
			{
				get
				{
					return serverIp;
				}
				set	
				{
					serverIp = value;
				}
			}

			[JsonProperty(PropertyName = "Status")]
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

			[JsonProperty(PropertyName = "ErrorMessage")]
			public string ErrorMessage
			{
				get
				{
					return errorMessage;
				}
				set	
				{
					errorMessage = value;
				}
			}

			[JsonProperty(PropertyName = "ClientIp")]
			public string ClientIp
			{
				get
				{
					return clientIp;
				}
				set	
				{
					clientIp = value;
				}
			}

			[JsonProperty(PropertyName = "TenantId")]
			public string TenantId
			{
				get
				{
					return tenantId;
				}
				set	
				{
					tenantId = value;
				}
			}

			[JsonProperty(PropertyName = "User")]
			public string User
			{
				get
				{
					return user;
				}
				set	
				{
					user = value;
				}
			}

			[JsonProperty(PropertyName = "Database")]
			public string Database
			{
				get
				{
					return database;
				}
				set	
				{
					database = value;
				}
			}

			[JsonProperty(PropertyName = "SqlText")]
			public string SqlText
			{
				get
				{
					return sqlText;
				}
				set	
				{
					sqlText = value;
				}
			}

			[JsonProperty(PropertyName = "Command")]
			public string Command
			{
				get
				{
					return command;
				}
				set	
				{
					command = value;
				}
			}

			[JsonProperty(PropertyName = "ExecuteTime")]
			public string ExecuteTime
			{
				get
				{
					return executeTime;
				}
				set	
				{
					executeTime = value;
				}
			}
		}
	}
}
