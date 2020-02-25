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

namespace Aliyun.Acs.dms_enterprise.Model.V20181101
{
	public class ListInstancesResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private string errorMessage;

		private string errorCode;

		private long? totalCount;

		private List<ListInstances_Instance> instanceList;

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

		public List<ListInstances_Instance> InstanceList
		{
			get
			{
				return instanceList;
			}
			set	
			{
				instanceList = value;
			}
		}

		public class ListInstances_Instance
		{

			private string instanceId;

			private string instanceType;

			private string envType;

			private string host;

			private int? port;

			private string sid;

			private string instanceAlias;

			private string dataLinkName;

			private string dbaNickName;

			private string safeRuleId;

			private int? queryTimeout;

			private int? exportTimeout;

			private string state;

			private string dbaId;

			private int? ddlOnline;

			private int? useDsql;

			private string ecsInstanceId;

			private string vpcId;

			private string ecsRegion;

			private string databaseUser;

			private string databasePassword;

			private string instanceSource;

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
		}
	}
}
