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
	public class GetInstanceResponse : AcsResponse
	{

		private string requestId;

		private string errorCode;

		private string errorMessage;

		private bool? success;

		private GetInstance_Instance instance;

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

		[JsonProperty(PropertyName = "Instance")]
		public GetInstance_Instance Instance
		{
			get
			{
				return instance;
			}
			set	
			{
				instance = value;
			}
		}

		public class GetInstance_Instance
		{

			private string vpcId;

			private string databaseUser;

			private string dbaId;

			private int? useDsql;

			private int? port;

			private string ecsInstanceId;

			private string envType;

			private string sid;

			private string safeRuleId;

			private string dbaNickName;

			private int? queryTimeout;

			private string instanceSource;

			private string host;

			private string state;

			private string dataLinkName;

			private int? exportTimeout;

			private string instanceId;

			private string instanceType;

			private string databasePassword;

			private string instanceAlias;

			private int? ddlOnline;

			private string ecsRegion;

			private List<string> ownerIdList;

			private List<string> ownerNameList;

			[JsonProperty(PropertyName = "VpcId")]
			public string VpcId
			{
				get
				{
					return vpcId;
				}
				set	
				{
					vpcId = value;
				}
			}

			[JsonProperty(PropertyName = "DatabaseUser")]
			public string DatabaseUser
			{
				get
				{
					return databaseUser;
				}
				set	
				{
					databaseUser = value;
				}
			}

			[JsonProperty(PropertyName = "DbaId")]
			public string DbaId
			{
				get
				{
					return dbaId;
				}
				set	
				{
					dbaId = value;
				}
			}

			[JsonProperty(PropertyName = "UseDsql")]
			public int? UseDsql
			{
				get
				{
					return useDsql;
				}
				set	
				{
					useDsql = value;
				}
			}

			[JsonProperty(PropertyName = "Port")]
			public int? Port
			{
				get
				{
					return port;
				}
				set	
				{
					port = value;
				}
			}

			[JsonProperty(PropertyName = "EcsInstanceId")]
			public string EcsInstanceId
			{
				get
				{
					return ecsInstanceId;
				}
				set	
				{
					ecsInstanceId = value;
				}
			}

			[JsonProperty(PropertyName = "EnvType")]
			public string EnvType
			{
				get
				{
					return envType;
				}
				set	
				{
					envType = value;
				}
			}

			[JsonProperty(PropertyName = "Sid")]
			public string Sid
			{
				get
				{
					return sid;
				}
				set	
				{
					sid = value;
				}
			}

			[JsonProperty(PropertyName = "SafeRuleId")]
			public string SafeRuleId
			{
				get
				{
					return safeRuleId;
				}
				set	
				{
					safeRuleId = value;
				}
			}

			[JsonProperty(PropertyName = "DbaNickName")]
			public string DbaNickName
			{
				get
				{
					return dbaNickName;
				}
				set	
				{
					dbaNickName = value;
				}
			}

			[JsonProperty(PropertyName = "QueryTimeout")]
			public int? QueryTimeout
			{
				get
				{
					return queryTimeout;
				}
				set	
				{
					queryTimeout = value;
				}
			}

			[JsonProperty(PropertyName = "InstanceSource")]
			public string InstanceSource
			{
				get
				{
					return instanceSource;
				}
				set	
				{
					instanceSource = value;
				}
			}

			[JsonProperty(PropertyName = "Host")]
			public string Host
			{
				get
				{
					return host;
				}
				set	
				{
					host = value;
				}
			}

			[JsonProperty(PropertyName = "State")]
			public string State
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

			[JsonProperty(PropertyName = "DataLinkName")]
			public string DataLinkName
			{
				get
				{
					return dataLinkName;
				}
				set	
				{
					dataLinkName = value;
				}
			}

			[JsonProperty(PropertyName = "ExportTimeout")]
			public int? ExportTimeout
			{
				get
				{
					return exportTimeout;
				}
				set	
				{
					exportTimeout = value;
				}
			}

			[JsonProperty(PropertyName = "InstanceId")]
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

			[JsonProperty(PropertyName = "InstanceType")]
			public string InstanceType
			{
				get
				{
					return instanceType;
				}
				set	
				{
					instanceType = value;
				}
			}

			[JsonProperty(PropertyName = "DatabasePassword")]
			public string DatabasePassword
			{
				get
				{
					return databasePassword;
				}
				set	
				{
					databasePassword = value;
				}
			}

			[JsonProperty(PropertyName = "InstanceAlias")]
			public string InstanceAlias
			{
				get
				{
					return instanceAlias;
				}
				set	
				{
					instanceAlias = value;
				}
			}

			[JsonProperty(PropertyName = "DdlOnline")]
			public int? DdlOnline
			{
				get
				{
					return ddlOnline;
				}
				set	
				{
					ddlOnline = value;
				}
			}

			[JsonProperty(PropertyName = "EcsRegion")]
			public string EcsRegion
			{
				get
				{
					return ecsRegion;
				}
				set	
				{
					ecsRegion = value;
				}
			}

			[JsonProperty(PropertyName = "OwnerIdList")]
			public List<string> OwnerIdList
			{
				get
				{
					return ownerIdList;
				}
				set	
				{
					ownerIdList = value;
				}
			}

			[JsonProperty(PropertyName = "OwnerNameList")]
			public List<string> OwnerNameList
			{
				get
				{
					return ownerNameList;
				}
				set	
				{
					ownerNameList = value;
				}
			}
		}
	}
}
