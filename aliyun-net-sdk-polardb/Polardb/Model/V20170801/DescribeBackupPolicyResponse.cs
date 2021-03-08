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

namespace Aliyun.Acs.polardb.Model.V20170801
{
	public class DescribeBackupPolicyResponse : AcsResponse
	{

		private string preferredBackupPeriod;

		private string dataLevel1BackupRetentionPeriod;

		private string requestId;

		private string backupRetentionPolicyOnClusterDeletion;

		private string preferredBackupTime;

		private string backupFrequency;

		private string preferredNextBackupTime;

		private int? backupRetentionPeriod;

		private string dataLevel2BackupRetentionPeriod;

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

		public string DataLevel1BackupRetentionPeriod
		{
			get
			{
				return dataLevel1BackupRetentionPeriod;
			}
			set	
			{
				dataLevel1BackupRetentionPeriod = value;
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

		public string BackupRetentionPolicyOnClusterDeletion
		{
			get
			{
				return backupRetentionPolicyOnClusterDeletion;
			}
			set	
			{
				backupRetentionPolicyOnClusterDeletion = value;
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

		public string BackupFrequency
		{
			get
			{
				return backupFrequency;
			}
			set	
			{
				backupFrequency = value;
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

		public int? BackupRetentionPeriod
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

		public string DataLevel2BackupRetentionPeriod
		{
			get
			{
				return dataLevel2BackupRetentionPeriod;
			}
			set	
			{
				dataLevel2BackupRetentionPeriod = value;
			}
		}
	}
}
