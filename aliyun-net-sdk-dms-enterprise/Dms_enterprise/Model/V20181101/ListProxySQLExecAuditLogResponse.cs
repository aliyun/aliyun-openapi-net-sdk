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

namespace Aliyun.Acs.dms_enterprise.Model.V20181101
{
	public class ListProxySQLExecAuditLogResponse : AcsResponse
	{

		private long? totalCount;

		private string requestId;

		private string errorCode;

		private string errorMessage;

		private bool? success;

		private List<ListProxySQLExecAuditLog_ProxySQLExecAuditLog> proxySQLExecAuditLogList;

		[JsonProperty(PropertyName = "TotalCount")]
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

		[JsonProperty(PropertyName = "ErrorCode")]
		public string ErrorCode
		{
			get
			{
				return errorCode;
			}
			set	
			{
				errorCode = value;
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

		[JsonProperty(PropertyName = "Success")]
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

		[JsonProperty(PropertyName = "ProxySQLExecAuditLogList")]
		public List<ListProxySQLExecAuditLog_ProxySQLExecAuditLog> ProxySQLExecAuditLogList
		{
			get
			{
				return proxySQLExecAuditLogList;
			}
			set	
			{
				proxySQLExecAuditLogList = value;
			}
		}

		public class ListProxySQLExecAuditLog_ProxySQLExecAuditLog
		{

			private string opTime;

			private string userName;

			private long? userId;

			private string instanceName;

			private long? instanceId;

			private string schemaName;

			private string sQLType;

			private string sQL;

			private string execState;

			private long? affectRows;

			private long? elapsedTime;

			private string remark;

			[JsonProperty(PropertyName = "OpTime")]
			public string OpTime
			{
				get
				{
					return opTime;
				}
				set	
				{
					opTime = value;
				}
			}

			[JsonProperty(PropertyName = "UserName")]
			public string UserName
			{
				get
				{
					return userName;
				}
				set	
				{
					userName = value;
				}
			}

			[JsonProperty(PropertyName = "UserId")]
			public long? UserId
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

			[JsonProperty(PropertyName = "InstanceName")]
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

			[JsonProperty(PropertyName = "InstanceId")]
			public long? InstanceId
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

			[JsonProperty(PropertyName = "SchemaName")]
			public string SchemaName
			{
				get
				{
					return schemaName;
				}
				set	
				{
					schemaName = value;
				}
			}

			[JsonProperty(PropertyName = "SQLType")]
			public string SQLType
			{
				get
				{
					return sQLType;
				}
				set	
				{
					sQLType = value;
				}
			}

			[JsonProperty(PropertyName = "SQL")]
			public string SQL
			{
				get
				{
					return sQL;
				}
				set	
				{
					sQL = value;
				}
			}

			[JsonProperty(PropertyName = "ExecState")]
			public string ExecState
			{
				get
				{
					return execState;
				}
				set	
				{
					execState = value;
				}
			}

			[JsonProperty(PropertyName = "AffectRows")]
			public long? AffectRows
			{
				get
				{
					return affectRows;
				}
				set	
				{
					affectRows = value;
				}
			}

			[JsonProperty(PropertyName = "ElapsedTime")]
			public long? ElapsedTime
			{
				get
				{
					return elapsedTime;
				}
				set	
				{
					elapsedTime = value;
				}
			}

			[JsonProperty(PropertyName = "Remark")]
			public string Remark
			{
				get
				{
					return remark;
				}
				set	
				{
					remark = value;
				}
			}
		}
	}
}
