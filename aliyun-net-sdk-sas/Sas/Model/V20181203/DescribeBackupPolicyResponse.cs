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

namespace Aliyun.Acs.Sas.Model.V20181203
{
	public class DescribeBackupPolicyResponse : AcsResponse
	{

		private string requestId;

		private DescribeBackupPolicy_BackupPolicyDetail backupPolicyDetail;

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

		public DescribeBackupPolicy_BackupPolicyDetail BackupPolicyDetail
		{
			get
			{
				return backupPolicyDetail;
			}
			set	
			{
				backupPolicyDetail = value;
			}
		}

		public class DescribeBackupPolicy_BackupPolicyDetail
		{

			private long? id;

			private string name;

			private string policy;

			private string policyVersion;

			private string regionId;

			private string status;

			private string clientStatus;

			private List<string> uuidList;

			public long? Id
			{
				get
				{
					return id;
				}
				set	
				{
					id = value;
				}
			}

			public string Name
			{
				get
				{
					return name;
				}
				set	
				{
					name = value;
				}
			}

			public string Policy
			{
				get
				{
					return policy;
				}
				set	
				{
					policy = value;
				}
			}

			public string PolicyVersion
			{
				get
				{
					return policyVersion;
				}
				set	
				{
					policyVersion = value;
				}
			}

			public string RegionId
			{
				get
				{
					return regionId;
				}
				set	
				{
					regionId = value;
				}
			}

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

			public string ClientStatus
			{
				get
				{
					return clientStatus;
				}
				set	
				{
					clientStatus = value;
				}
			}

			public List<string> UuidList
			{
				get
				{
					return uuidList;
				}
				set	
				{
					uuidList = value;
				}
			}
		}
	}
}
