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

namespace Aliyun.Acs.Rds.Model.V20140815
{
	public class ModifyInstanceCrossBackupPolicyResponse : AcsResponse
	{

		private string storageOwner;

		private string backupEnabled;

		private string storageType;

		private string regionId;

		private string logBackupEnabled;

		private string requestId;

		private int? retentType;

		private string endpoint;

		private string crossBackupRegion;

		private string crossBackupType;

		private int? retention;

		private string dBInstanceId;

		[JsonProperty(PropertyName = "StorageOwner")]
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

		[JsonProperty(PropertyName = "BackupEnabled")]
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

		[JsonProperty(PropertyName = "StorageType")]
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

		[JsonProperty(PropertyName = "RegionId")]
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

		[JsonProperty(PropertyName = "LogBackupEnabled")]
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

		[JsonProperty(PropertyName = "RequestId")]
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

		[JsonProperty(PropertyName = "RetentType")]
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

		[JsonProperty(PropertyName = "Endpoint")]
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

		[JsonProperty(PropertyName = "CrossBackupRegion")]
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

		[JsonProperty(PropertyName = "CrossBackupType")]
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

		[JsonProperty(PropertyName = "Retention")]
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

		[JsonProperty(PropertyName = "DBInstanceId")]
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
	}
}
