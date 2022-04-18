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

			private long? useOssSize;

			private int? useInstanceNum;

			private int? instanceNum;

			private string chargeType;

			private long? incSensitiveTables;

			private bool? auditUpgradeStatus;

			private long? dataMaskTasks;

			private bool? authed;

			private int? labStatus;

			private string version;

			private bool? odpsSet;

			private bool? ossBucketSet;

			private long? sensitiveTable;

			private int? remainDays;

			private long? totalDataMaskColumns;

			private long? datamaskColumns;

			private string authProductList;

			private bool? trail;

			private long? divulgeCount;

			private bool? rdsSet;

			private int? dbAuditStatus;

			private bool? renewStatus;

			private long? sensitiveObjects;

			private long? dataMaskColumns;

			private long? dlpTotalCount;

			private long? sensitiveObject;

			private long? dlpCount;

			private string instanceId;

			private string accessKeyId;

			private long? ossSize;

			private string sensitiveTotalTop;

			private long? sensitiveTables;

			private string sensitiveTop;

			private bool? purchased;

			private bool? buyed;

			private long? incSensitiveObjects;

			private int? instanceStatus;

			private bool? assetScanned;

			private long? alarmCount;

			private string displayTime;

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

			public bool? Purchased
			{
				get
				{
					return purchased;
				}
				set	
				{
					purchased = value;
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
		}
	}
}
