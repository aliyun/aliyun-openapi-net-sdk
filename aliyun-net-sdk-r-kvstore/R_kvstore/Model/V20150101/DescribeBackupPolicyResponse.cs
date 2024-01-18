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

namespace Aliyun.Acs.R_kvstore.Model.V20150101
{
	public class DescribeBackupPolicyResponse : AcsResponse
	{

		private string backupRetentionPeriod;

		private string requestId;

		private string preferredBackupPeriod;

		private string preferredNextBackupTime;

		private string preferredBackupTime;

		private int? enableBackupLog;

		private string dbsInstance;

		private DescribeBackupPolicy_AccessDeniedDetail accessDeniedDetail;

		public string BackupRetentionPeriod
		{
			get
			{
				return backupRetentionPeriod;
			}
			set	
			{
				backupRetentionPeriod = value;
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

		public string PreferredBackupPeriod
		{
			get
			{
				return preferredBackupPeriod;
			}
			set	
			{
				preferredBackupPeriod = value;
			}
		}

		public string PreferredNextBackupTime
		{
			get
			{
				return preferredNextBackupTime;
			}
			set	
			{
				preferredNextBackupTime = value;
			}
		}

		public string PreferredBackupTime
		{
			get
			{
				return preferredBackupTime;
			}
			set	
			{
				preferredBackupTime = value;
			}
		}

		public int? EnableBackupLog
		{
			get
			{
				return enableBackupLog;
			}
			set	
			{
				enableBackupLog = value;
			}
		}

		public string DbsInstance
		{
			get
			{
				return dbsInstance;
			}
			set	
			{
				dbsInstance = value;
			}
		}

		public DescribeBackupPolicy_AccessDeniedDetail AccessDeniedDetail
		{
			get
			{
				return accessDeniedDetail;
			}
			set	
			{
				accessDeniedDetail = value;
			}
		}

		public class DescribeBackupPolicy_AccessDeniedDetail
		{

			private string authAction;

			private string authPrincipalDisplayName;

			private string authPrincipalOwnerId;

			private string authPrincipalType;

			private string encodedDiagnosticMessage;

			private string noPermissionType;

			private string policyType;

			public string AuthAction
			{
				get
				{
					return authAction;
				}
				set	
				{
					authAction = value;
				}
			}

			public string AuthPrincipalDisplayName
			{
				get
				{
					return authPrincipalDisplayName;
				}
				set	
				{
					authPrincipalDisplayName = value;
				}
			}

			public string AuthPrincipalOwnerId
			{
				get
				{
					return authPrincipalOwnerId;
				}
				set	
				{
					authPrincipalOwnerId = value;
				}
			}

			public string AuthPrincipalType
			{
				get
				{
					return authPrincipalType;
				}
				set	
				{
					authPrincipalType = value;
				}
			}

			public string EncodedDiagnosticMessage
			{
				get
				{
					return encodedDiagnosticMessage;
				}
				set	
				{
					encodedDiagnosticMessage = value;
				}
			}

			public string NoPermissionType
			{
				get
				{
					return noPermissionType;
				}
				set	
				{
					noPermissionType = value;
				}
			}

			public string PolicyType
			{
				get
				{
					return policyType;
				}
				set	
				{
					policyType = value;
				}
			}
		}
	}
}
