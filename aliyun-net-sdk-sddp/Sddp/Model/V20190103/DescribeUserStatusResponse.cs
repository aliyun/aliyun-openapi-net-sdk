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

namespace Aliyun.Acs.Sddp.Model.V20190103
{
	public class DescribeUserStatusResponse : AcsResponse
	{

		private string requestId;

		private DescribeUserStatus_UserStatus userStatus;

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

		public DescribeUserStatus_UserStatus UserStatus
		{
			get
			{
				return userStatus;
			}
			set	
			{
				userStatus = value;
			}
		}

		public class DescribeUserStatus_UserStatus
		{

			private bool? authed;

			private bool? buyed;

			private bool? ossBucketSet;

			private bool? odpsSet;

			private bool? rdsSet;

			private string authProductList;

			private string accessKeyId;

			private bool? trail;

			private int? instanceStatus;

			private string instanceId;

			private int? remainDays;

			private bool? renewStatus;

			private int? instanceNum;

			private int? useInstanceNum;

			private long? ossSize;

			private long? useOssSize;

			private string chargeType;

			private int? labStatus;

			private string version;

			private int? dbAuditStatus;

			private bool? assetScanned;

			private bool? auditUpgradeStatus;

			private long? sensitiveTable;

			private long? sensitiveObject;

			private long? datamaskColumns;

			private long? alarmCount;

			private long? divulgeCount;

			private string displayTime;

			private long? totalDataMaskColumns;

			private long? dataMaskTasks;

			private long? dataMaskColumns;

			private long? sensitiveTables;

			private long? sensitiveObjects;

			private long? incSensitiveTables;

			private long? incSensitiveObjects;

			private string sensitiveTop;

			private long? dlpTotalCount;

			private long? dlpCount;

			private string sensitiveTotalTop;

			public bool? Authed
			{
				get
				{
					return authed;
				}
				set	
				{
					authed = value;
				}
			}

			public bool? Buyed
			{
				get
				{
					return buyed;
				}
				set	
				{
					buyed = value;
				}
			}

			public bool? OssBucketSet
			{
				get
				{
					return ossBucketSet;
				}
				set	
				{
					ossBucketSet = value;
				}
			}

			public bool? OdpsSet
			{
				get
				{
					return odpsSet;
				}
				set	
				{
					odpsSet = value;
				}
			}

			public bool? RdsSet
			{
				get
				{
					return rdsSet;
				}
				set	
				{
					rdsSet = value;
				}
			}

			public string AuthProductList
			{
				get
				{
					return authProductList;
				}
				set	
				{
					authProductList = value;
				}
			}

			public string AccessKeyId
			{
				get
				{
					return accessKeyId;
				}
				set	
				{
					accessKeyId = value;
				}
			}

			public bool? Trail
			{
				get
				{
					return trail;
				}
				set	
				{
					trail = value;
				}
			}

			public int? InstanceStatus
			{
				get
				{
					return instanceStatus;
				}
				set	
				{
					instanceStatus = value;
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

			public int? RemainDays
			{
				get
				{
					return remainDays;
				}
				set	
				{
					remainDays = value;
				}
			}

			public bool? RenewStatus
			{
				get
				{
					return renewStatus;
				}
				set	
				{
					renewStatus = value;
				}
			}

			public int? InstanceNum
			{
				get
				{
					return instanceNum;
				}
				set	
				{
					instanceNum = value;
				}
			}

			public int? UseInstanceNum
			{
				get
				{
					return useInstanceNum;
				}
				set	
				{
					useInstanceNum = value;
				}
			}

			public long? OssSize
			{
				get
				{
					return ossSize;
				}
				set	
				{
					ossSize = value;
				}
			}

			public long? UseOssSize
			{
				get
				{
					return useOssSize;
				}
				set	
				{
					useOssSize = value;
				}
			}

			public string ChargeType
			{
				get
				{
					return chargeType;
				}
				set	
				{
					chargeType = value;
				}
			}

			public int? LabStatus
			{
				get
				{
					return labStatus;
				}
				set	
				{
					labStatus = value;
				}
			}

			public string Version
			{
				get
				{
					return version;
				}
				set	
				{
					version = value;
				}
			}

			public int? DbAuditStatus
			{
				get
				{
					return dbAuditStatus;
				}
				set	
				{
					dbAuditStatus = value;
				}
			}

			public bool? AssetScanned
			{
				get
				{
					return assetScanned;
				}
				set	
				{
					assetScanned = value;
				}
			}

			public bool? AuditUpgradeStatus
			{
				get
				{
					return auditUpgradeStatus;
				}
				set	
				{
					auditUpgradeStatus = value;
				}
			}

			public long? SensitiveTable
			{
				get
				{
					return sensitiveTable;
				}
				set	
				{
					sensitiveTable = value;
				}
			}

			public long? SensitiveObject
			{
				get
				{
					return sensitiveObject;
				}
				set	
				{
					sensitiveObject = value;
				}
			}

			public long? DatamaskColumns
			{
				get
				{
					return datamaskColumns;
				}
				set	
				{
					datamaskColumns = value;
				}
			}

			public long? AlarmCount
			{
				get
				{
					return alarmCount;
				}
				set	
				{
					alarmCount = value;
				}
			}

			public long? DivulgeCount
			{
				get
				{
					return divulgeCount;
				}
				set	
				{
					divulgeCount = value;
				}
			}

			public string DisplayTime
			{
				get
				{
					return displayTime;
				}
				set	
				{
					displayTime = value;
				}
			}

			public long? TotalDataMaskColumns
			{
				get
				{
					return totalDataMaskColumns;
				}
				set	
				{
					totalDataMaskColumns = value;
				}
			}

			public long? DataMaskTasks
			{
				get
				{
					return dataMaskTasks;
				}
				set	
				{
					dataMaskTasks = value;
				}
			}

			public long? DataMaskColumns
			{
				get
				{
					return dataMaskColumns;
				}
				set	
				{
					dataMaskColumns = value;
				}
			}

			public long? SensitiveTables
			{
				get
				{
					return sensitiveTables;
				}
				set	
				{
					sensitiveTables = value;
				}
			}

			public long? SensitiveObjects
			{
				get
				{
					return sensitiveObjects;
				}
				set	
				{
					sensitiveObjects = value;
				}
			}

			public long? IncSensitiveTables
			{
				get
				{
					return incSensitiveTables;
				}
				set	
				{
					incSensitiveTables = value;
				}
			}

			public long? IncSensitiveObjects
			{
				get
				{
					return incSensitiveObjects;
				}
				set	
				{
					incSensitiveObjects = value;
				}
			}

			public string SensitiveTop
			{
				get
				{
					return sensitiveTop;
				}
				set	
				{
					sensitiveTop = value;
				}
			}

			public long? DlpTotalCount
			{
				get
				{
					return dlpTotalCount;
				}
				set	
				{
					dlpTotalCount = value;
				}
			}

			public long? DlpCount
			{
				get
				{
					return dlpCount;
				}
				set	
				{
					dlpCount = value;
				}
			}

			public string SensitiveTotalTop
			{
				get
				{
					return sensitiveTotalTop;
				}
				set	
				{
					sensitiveTotalTop = value;
				}
			}
		}
	}
}
