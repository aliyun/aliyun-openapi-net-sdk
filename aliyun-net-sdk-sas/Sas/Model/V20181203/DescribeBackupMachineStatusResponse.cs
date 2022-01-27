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
	public class DescribeBackupMachineStatusResponse : AcsResponse
	{

		private string requestId;

		private DescribeBackupMachineStatus_BackupMachineStatus backupMachineStatus;

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

		public DescribeBackupMachineStatus_BackupMachineStatus BackupMachineStatus
		{
			get
			{
				return backupMachineStatus;
			}
			set	
			{
				backupMachineStatus = value;
			}
		}

		public class DescribeBackupMachineStatus_BackupMachineStatus
		{

			private string uuid;

			private string clientStatus;

			private int? savedBackupCount;

			private string errorCode;

			private string clientId;

			private string clientVersion;

			private string vaultId;

			private string status;

			private string regionId;

			private string instanceId;

			private string requestId;

			private string jobs;

			private List<DescribeBackupMachineStatus_BackupErrorMsg> errorList;

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

			public int? SavedBackupCount
			{
				get
				{
					return savedBackupCount;
				}
				set	
				{
					savedBackupCount = value;
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

			public string ClientId
			{
				get
				{
					return clientId;
				}
				set	
				{
					clientId = value;
				}
			}

			public string ClientVersion
			{
				get
				{
					return clientVersion;
				}
				set	
				{
					clientVersion = value;
				}
			}

			public string VaultId
			{
				get
				{
					return vaultId;
				}
				set	
				{
					vaultId = value;
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

			public string Jobs
			{
				get
				{
					return jobs;
				}
				set	
				{
					jobs = value;
				}
			}

			public List<DescribeBackupMachineStatus_BackupErrorMsg> ErrorList
			{
				get
				{
					return errorList;
				}
				set	
				{
					errorList = value;
				}
			}

			public class DescribeBackupMachineStatus_BackupErrorMsg
			{

				private string key;

				private string path;

				private string errorStatus;

				private string errorCode;

				private string errorType;

				private string errorMsg;

				private long? errorTime;

				private string errorFile;

				private string errorFileUrl;

				private string requestId;

				public string Key
				{
					get
					{
						return key;
					}
					set	
					{
						key = value;
					}
				}

				public string Path
				{
					get
					{
						return path;
					}
					set	
					{
						path = value;
					}
				}

				public string ErrorStatus
				{
					get
					{
						return errorStatus;
					}
					set	
					{
						errorStatus = value;
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

				public string ErrorType
				{
					get
					{
						return errorType;
					}
					set	
					{
						errorType = value;
					}
				}

				public string ErrorMsg
				{
					get
					{
						return errorMsg;
					}
					set	
					{
						errorMsg = value;
					}
				}

				public long? ErrorTime
				{
					get
					{
						return errorTime;
					}
					set	
					{
						errorTime = value;
					}
				}

				public string ErrorFile
				{
					get
					{
						return errorFile;
					}
					set	
					{
						errorFile = value;
					}
				}

				public string ErrorFileUrl
				{
					get
					{
						return errorFileUrl;
					}
					set	
					{
						errorFileUrl = value;
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
			}
		}
	}
}
