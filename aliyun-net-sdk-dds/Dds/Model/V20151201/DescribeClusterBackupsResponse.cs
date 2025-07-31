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

namespace Aliyun.Acs.Dds.Model.V20151201
{
	public class DescribeClusterBackupsResponse : AcsResponse
	{

		private string requestId;

		private int? maxResults;

		private int? pageNumber;

		private int? pageSize;

		private List<DescribeClusterBackups_ClusterBackup> clusterBackups;

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

		public int? MaxResults
		{
			get
			{
				return maxResults;
			}
			set	
			{
				maxResults = value;
			}
		}

		public int? PageNumber
		{
			get
			{
				return pageNumber;
			}
			set	
			{
				pageNumber = value;
			}
		}

		public int? PageSize
		{
			get
			{
				return pageSize;
			}
			set	
			{
				pageSize = value;
			}
		}

		public List<DescribeClusterBackups_ClusterBackup> ClusterBackups
		{
			get
			{
				return clusterBackups;
			}
			set	
			{
				clusterBackups = value;
			}
		}

		public class DescribeClusterBackups_ClusterBackup
		{

			private int? isAvail;

			private string clusterBackupId;

			private string clusterBackupStatus;

			private string clusterBackupStartTime;

			private string clusterBackupSize;

			private string clusterBackupEndTime;

			private string clusterBackupMode;

			private string progress;

			private string attachLogStatus;

			private string engineVersion;

			private string backupExpireTime;

			private List<DescribeClusterBackups_Backup> backups;

			private DescribeClusterBackups_ExtraInfo extraInfo;

			public int? IsAvail
			{
				get
				{
					return isAvail;
				}
				set	
				{
					isAvail = value;
				}
			}

			public string ClusterBackupId
			{
				get
				{
					return clusterBackupId;
				}
				set	
				{
					clusterBackupId = value;
				}
			}

			public string ClusterBackupStatus
			{
				get
				{
					return clusterBackupStatus;
				}
				set	
				{
					clusterBackupStatus = value;
				}
			}

			public string ClusterBackupStartTime
			{
				get
				{
					return clusterBackupStartTime;
				}
				set	
				{
					clusterBackupStartTime = value;
				}
			}

			public string ClusterBackupSize
			{
				get
				{
					return clusterBackupSize;
				}
				set	
				{
					clusterBackupSize = value;
				}
			}

			public string ClusterBackupEndTime
			{
				get
				{
					return clusterBackupEndTime;
				}
				set	
				{
					clusterBackupEndTime = value;
				}
			}

			public string ClusterBackupMode
			{
				get
				{
					return clusterBackupMode;
				}
				set	
				{
					clusterBackupMode = value;
				}
			}

			public string Progress
			{
				get
				{
					return progress;
				}
				set	
				{
					progress = value;
				}
			}

			public string AttachLogStatus
			{
				get
				{
					return attachLogStatus;
				}
				set	
				{
					attachLogStatus = value;
				}
			}

			public string EngineVersion
			{
				get
				{
					return engineVersion;
				}
				set	
				{
					engineVersion = value;
				}
			}

			public string BackupExpireTime
			{
				get
				{
					return backupExpireTime;
				}
				set	
				{
					backupExpireTime = value;
				}
			}

			public List<DescribeClusterBackups_Backup> Backups
			{
				get
				{
					return backups;
				}
				set	
				{
					backups = value;
				}
			}

			public DescribeClusterBackups_ExtraInfo ExtraInfo
			{
				get
				{
					return extraInfo;
				}
				set	
				{
					extraInfo = value;
				}
			}

			public class DescribeClusterBackups_Backup
			{

				private string backupId;

				private string instanceName;

				private string backupDownloadURL;

				private string backupIntranetDownloadURL;

				private string backupStartTime;

				private string backupEndTime;

				private string backupSize;

				private string isAvail;

				private string backupStatus;

				private string backupName;

				private DescribeClusterBackups_ExtraInfo1 extraInfo1;

				public string BackupId
				{
					get
					{
						return backupId;
					}
					set	
					{
						backupId = value;
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

				public string BackupDownloadURL
				{
					get
					{
						return backupDownloadURL;
					}
					set	
					{
						backupDownloadURL = value;
					}
				}

				public string BackupIntranetDownloadURL
				{
					get
					{
						return backupIntranetDownloadURL;
					}
					set	
					{
						backupIntranetDownloadURL = value;
					}
				}

				public string BackupStartTime
				{
					get
					{
						return backupStartTime;
					}
					set	
					{
						backupStartTime = value;
					}
				}

				public string BackupEndTime
				{
					get
					{
						return backupEndTime;
					}
					set	
					{
						backupEndTime = value;
					}
				}

				public string BackupSize
				{
					get
					{
						return backupSize;
					}
					set	
					{
						backupSize = value;
					}
				}

				public string IsAvail
				{
					get
					{
						return isAvail;
					}
					set	
					{
						isAvail = value;
					}
				}

				public string BackupStatus
				{
					get
					{
						return backupStatus;
					}
					set	
					{
						backupStatus = value;
					}
				}

				public string BackupName
				{
					get
					{
						return backupName;
					}
					set	
					{
						backupName = value;
					}
				}

				public DescribeClusterBackups_ExtraInfo1 ExtraInfo1
				{
					get
					{
						return extraInfo1;
					}
					set	
					{
						extraInfo1 = value;
					}
				}

				public class DescribeClusterBackups_ExtraInfo1
				{

					private string nodeId;

					private string storageSize;

					private string instanceClass;

					private string nodeType;

					public string NodeId
					{
						get
						{
							return nodeId;
						}
						set	
						{
							nodeId = value;
						}
					}

					public string StorageSize
					{
						get
						{
							return storageSize;
						}
						set	
						{
							storageSize = value;
						}
					}

					public string InstanceClass
					{
						get
						{
							return instanceClass;
						}
						set	
						{
							instanceClass = value;
						}
					}

					public string NodeType
					{
						get
						{
							return nodeType;
						}
						set	
						{
							nodeType = value;
						}
					}
				}
			}

			public class DescribeClusterBackups_ExtraInfo
			{

				private string registryFromHistory;

				public string RegistryFromHistory
				{
					get
					{
						return registryFromHistory;
					}
					set	
					{
						registryFromHistory = value;
					}
				}
			}
		}
	}
}
