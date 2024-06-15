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

namespace Aliyun.Acs.polardbx.Model.V20200202
{
	public class UpdateBackupPolicyResponse : AcsResponse
	{

		private string message;

		private string requestId;

		private bool? success;

		private List<UpdateBackupPolicy_Account> data;

		public string Message
		{
			get
			{
				return message;
			}
			set	
			{
				message = value;
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

		public List<UpdateBackupPolicy_Account> Data
		{
			get
			{
				return data;
			}
			set	
			{
				data = value;
			}
		}

		public class UpdateBackupPolicy_Account
		{

			private int? logLocalRetentionSpace;

			private string dBInstanceName;

			private string backupWay;

			private string backupPeriod;

			private int? forceCleanOnHighSpaceUsage;

			private string backupType;

			private int? localLogRetention;

			private int? removeLogRetention;

			private string backupPlanBegin;

			private int? backupSetRetention;

			private int? isEnabled;

			private int? coldDataBackupInterval;

			private int? coldDataBackupRetention;

			private int? localLogRetentionNumber;

			private bool? isCrossRegionDataBackupEnabled;

			private bool? isCrossRegionLogBackupEnabled;

			private string destCrossRegion;

			private int? crossRegionDataBackupRetention;

			private int? crossRegionLogBackupRetention;

			public int? LogLocalRetentionSpace
			{
				get
				{
					return logLocalRetentionSpace;
				}
				set	
				{
					logLocalRetentionSpace = value;
				}
			}

			public string DBInstanceName
			{
				get
				{
					return dBInstanceName;
				}
				set	
				{
					dBInstanceName = value;
				}
			}

			public string BackupWay
			{
				get
				{
					return backupWay;
				}
				set	
				{
					backupWay = value;
				}
			}

			public string BackupPeriod
			{
				get
				{
					return backupPeriod;
				}
				set	
				{
					backupPeriod = value;
				}
			}

			public int? ForceCleanOnHighSpaceUsage
			{
				get
				{
					return forceCleanOnHighSpaceUsage;
				}
				set	
				{
					forceCleanOnHighSpaceUsage = value;
				}
			}

			public string BackupType
			{
				get
				{
					return backupType;
				}
				set	
				{
					backupType = value;
				}
			}

			public int? LocalLogRetention
			{
				get
				{
					return localLogRetention;
				}
				set	
				{
					localLogRetention = value;
				}
			}

			public int? RemoveLogRetention
			{
				get
				{
					return removeLogRetention;
				}
				set	
				{
					removeLogRetention = value;
				}
			}

			public string BackupPlanBegin
			{
				get
				{
					return backupPlanBegin;
				}
				set	
				{
					backupPlanBegin = value;
				}
			}

			public int? BackupSetRetention
			{
				get
				{
					return backupSetRetention;
				}
				set	
				{
					backupSetRetention = value;
				}
			}

			public int? IsEnabled
			{
				get
				{
					return isEnabled;
				}
				set	
				{
					isEnabled = value;
				}
			}

			public int? ColdDataBackupInterval
			{
				get
				{
					return coldDataBackupInterval;
				}
				set	
				{
					coldDataBackupInterval = value;
				}
			}

			public int? ColdDataBackupRetention
			{
				get
				{
					return coldDataBackupRetention;
				}
				set	
				{
					coldDataBackupRetention = value;
				}
			}

			public int? LocalLogRetentionNumber
			{
				get
				{
					return localLogRetentionNumber;
				}
				set	
				{
					localLogRetentionNumber = value;
				}
			}

			public bool? IsCrossRegionDataBackupEnabled
			{
				get
				{
					return isCrossRegionDataBackupEnabled;
				}
				set	
				{
					isCrossRegionDataBackupEnabled = value;
				}
			}

			public bool? IsCrossRegionLogBackupEnabled
			{
				get
				{
					return isCrossRegionLogBackupEnabled;
				}
				set	
				{
					isCrossRegionLogBackupEnabled = value;
				}
			}

			public string DestCrossRegion
			{
				get
				{
					return destCrossRegion;
				}
				set	
				{
					destCrossRegion = value;
				}
			}

			public int? CrossRegionDataBackupRetention
			{
				get
				{
					return crossRegionDataBackupRetention;
				}
				set	
				{
					crossRegionDataBackupRetention = value;
				}
			}

			public int? CrossRegionLogBackupRetention
			{
				get
				{
					return crossRegionLogBackupRetention;
				}
				set	
				{
					crossRegionLogBackupRetention = value;
				}
			}
		}
	}
}
