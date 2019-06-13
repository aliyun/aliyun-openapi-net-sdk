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

namespace Aliyun.Acs.Rds.Model.V20140815
{
	public class ModifyInstanceCrossBackupPolicyResponse : AcsResponse
	{

		private string requestId;

		private string dBInstanceId;

		private string regionId;

		private string crossBackupRegion;

		private string crossBackupType;

		private string backupEnabled;

		private string logBackupEnabled;

		private string storageOwner;

		private string storageType;

		private string endpoint;

		private int? retentType;

		private int? retention;

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

		public string DBInstanceId
		{
			get
			{
				return dBInstanceId;
			}
			set	
			{
				dBInstanceId = value;
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

		public string CrossBackupRegion
		{
			get
			{
				return crossBackupRegion;
			}
			set	
			{
				crossBackupRegion = value;
			}
		}

		public string CrossBackupType
		{
			get
			{
				return crossBackupType;
			}
			set	
			{
				crossBackupType = value;
			}
		}

		public string BackupEnabled
		{
			get
			{
				return backupEnabled;
			}
			set	
			{
				backupEnabled = value;
			}
		}

		public string LogBackupEnabled
		{
			get
			{
				return logBackupEnabled;
			}
			set	
			{
				logBackupEnabled = value;
			}
		}

		public string StorageOwner
		{
			get
			{
				return storageOwner;
			}
			set	
			{
				storageOwner = value;
			}
		}

		public string StorageType
		{
			get
			{
				return storageType;
			}
			set	
			{
				storageType = value;
			}
		}

		public string Endpoint
		{
			get
			{
				return endpoint;
			}
			set	
			{
				endpoint = value;
			}
		}

		public int? RetentType
		{
			get
			{
				return retentType;
			}
			set	
			{
				retentType = value;
			}
		}

		public int? Retention
		{
			get
			{
				return retention;
			}
			set	
			{
				retention = value;
			}
		}
	}
}
