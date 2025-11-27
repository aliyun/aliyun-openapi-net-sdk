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

namespace Aliyun.Acs.quickbi_public.Model.V20220101
{
	public class GetDataSourceConnectionInfoResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private GetDataSourceConnectionInfo_Result result;

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

		public GetDataSourceConnectionInfo_Result Result
		{
			get
			{
				return result;
			}
			set	
			{
				result = value;
			}
		}

		public class GetDataSourceConnectionInfo_Result
		{

			private string address;

			private string authLevel;

			private string creatorId;

			private string dsId;

			private string dsType;

			private string dsVersion;

			private string instance;

			private string instanceId;

			private string modifyUser;

			private bool? noSasl;

			private string parentDsType;

			private string port;

			private string project;

			private string schema;

			private string showName;

			private string workspaceId;

			public string Address
			{
				get
				{
					return address;
				}
				set	
				{
					address = value;
				}
			}

			public string AuthLevel
			{
				get
				{
					return authLevel;
				}
				set	
				{
					authLevel = value;
				}
			}

			public string CreatorId
			{
				get
				{
					return creatorId;
				}
				set	
				{
					creatorId = value;
				}
			}

			public string DsId
			{
				get
				{
					return dsId;
				}
				set	
				{
					dsId = value;
				}
			}

			public string DsType
			{
				get
				{
					return dsType;
				}
				set	
				{
					dsType = value;
				}
			}

			public string DsVersion
			{
				get
				{
					return dsVersion;
				}
				set	
				{
					dsVersion = value;
				}
			}

			public string Instance
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

			public string ModifyUser
			{
				get
				{
					return modifyUser;
				}
				set	
				{
					modifyUser = value;
				}
			}

			public bool? NoSasl
			{
				get
				{
					return noSasl;
				}
				set	
				{
					noSasl = value;
				}
			}

			public string ParentDsType
			{
				get
				{
					return parentDsType;
				}
				set	
				{
					parentDsType = value;
				}
			}

			public string Port
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

			public string Project
			{
				get
				{
					return project;
				}
				set	
				{
					project = value;
				}
			}

			public string Schema
			{
				get
				{
					return schema;
				}
				set	
				{
					schema = value;
				}
			}

			public string ShowName
			{
				get
				{
					return showName;
				}
				set	
				{
					showName = value;
				}
			}

			public string WorkspaceId
			{
				get
				{
					return workspaceId;
				}
				set	
				{
					workspaceId = value;
				}
			}
		}
	}
}
