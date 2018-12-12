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
using Aliyun.Acs.Core;
using System.Collections.Generic;

namespace Aliyun.Acs.Smartag.Model.V20180313
{
	public class DescribeSmartAccessGatewayHaResponse : AcsResponse
	{

		private string requestId;

		private string deviceLevelBackupState;

		private string deviceLevelBackupType;

		private string mainDeviceId;

		private string backupDeviceId;

		private string linkLevelBackupState;

		private string linkLevelBackupType;

		private string mainLinkId;

		private string backupLinkId;

		private string smartAGId;

		private string mainLinkState;

		private string backupLinkState;

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

		public string DeviceLevelBackupState
		{
			get
			{
				return deviceLevelBackupState;
			}
			set	
			{
				deviceLevelBackupState = value;
			}
		}

		public string DeviceLevelBackupType
		{
			get
			{
				return deviceLevelBackupType;
			}
			set	
			{
				deviceLevelBackupType = value;
			}
		}

		public string MainDeviceId
		{
			get
			{
				return mainDeviceId;
			}
			set	
			{
				mainDeviceId = value;
			}
		}

		public string BackupDeviceId
		{
			get
			{
				return backupDeviceId;
			}
			set	
			{
				backupDeviceId = value;
			}
		}

		public string LinkLevelBackupState
		{
			get
			{
				return linkLevelBackupState;
			}
			set	
			{
				linkLevelBackupState = value;
			}
		}

		public string LinkLevelBackupType
		{
			get
			{
				return linkLevelBackupType;
			}
			set	
			{
				linkLevelBackupType = value;
			}
		}

		public string MainLinkId
		{
			get
			{
				return mainLinkId;
			}
			set	
			{
				mainLinkId = value;
			}
		}

		public string BackupLinkId
		{
			get
			{
				return backupLinkId;
			}
			set	
			{
				backupLinkId = value;
			}
		}

		public string SmartAGId
		{
			get
			{
				return smartAGId;
			}
			set	
			{
				smartAGId = value;
			}
		}

		public string MainLinkState
		{
			get
			{
				return mainLinkState;
			}
			set	
			{
				mainLinkState = value;
			}
		}

		public string BackupLinkState
		{
			get
			{
				return backupLinkState;
			}
			set	
			{
				backupLinkState = value;
			}
		}
	}
}