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
	public class DescribeVersionConfigResponse : AcsResponse
	{

		private string requestId;

		private int? assetLevel;

		private int? avdsFlag;

		private long? createTime;

		private int? flag;

		private string instanceId;

		private bool? isSasOpening;

		private int? isTrialVersion;

		private int? logCapacity;

		private int? logTime;

		private long? releaseTime;

		private int? sasLog;

		private int? sasScreen;

		private int? version;

		private int? userDefinedAlarms;

		private int? webLock;

		private long? webLockAuthCount;

		private long? appWhiteListAuthCount;

		private int? appWhiteList;

		private long? slsCapacity;

		private long? gmtCreate;

		private long? lastInstanceReleaseTime;

		private bool? isOverBalance;

		private long? lastTrailEndTime;

		private long? honeypotCapacity;

		private long? imageScanCapacity;

		private int? vmCores;

		private bool? isPaidUser;

		private int? highestVersion;

		private int? mVAuthCount;

		private int? mVUnusedAuthCount;

		private int? allowPartialBuy;

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

		public int? AssetLevel
		{
			get
			{
				return assetLevel;
			}
			set	
			{
				assetLevel = value;
			}
		}

		public int? AvdsFlag
		{
			get
			{
				return avdsFlag;
			}
			set	
			{
				avdsFlag = value;
			}
		}

		public long? CreateTime
		{
			get
			{
				return createTime;
			}
			set	
			{
				createTime = value;
			}
		}

		public int? Flag
		{
			get
			{
				return flag;
			}
			set	
			{
				flag = value;
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

		public bool? IsSasOpening
		{
			get
			{
				return isSasOpening;
			}
			set	
			{
				isSasOpening = value;
			}
		}

		public int? IsTrialVersion
		{
			get
			{
				return isTrialVersion;
			}
			set	
			{
				isTrialVersion = value;
			}
		}

		public int? LogCapacity
		{
			get
			{
				return logCapacity;
			}
			set	
			{
				logCapacity = value;
			}
		}

		public int? LogTime
		{
			get
			{
				return logTime;
			}
			set	
			{
				logTime = value;
			}
		}

		public long? ReleaseTime
		{
			get
			{
				return releaseTime;
			}
			set	
			{
				releaseTime = value;
			}
		}

		public int? SasLog
		{
			get
			{
				return sasLog;
			}
			set	
			{
				sasLog = value;
			}
		}

		public int? SasScreen
		{
			get
			{
				return sasScreen;
			}
			set	
			{
				sasScreen = value;
			}
		}

		public int? Version
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

		public int? UserDefinedAlarms
		{
			get
			{
				return userDefinedAlarms;
			}
			set	
			{
				userDefinedAlarms = value;
			}
		}

		public int? WebLock
		{
			get
			{
				return webLock;
			}
			set	
			{
				webLock = value;
			}
		}

		public long? WebLockAuthCount
		{
			get
			{
				return webLockAuthCount;
			}
			set	
			{
				webLockAuthCount = value;
			}
		}

		public long? AppWhiteListAuthCount
		{
			get
			{
				return appWhiteListAuthCount;
			}
			set	
			{
				appWhiteListAuthCount = value;
			}
		}

		public int? AppWhiteList
		{
			get
			{
				return appWhiteList;
			}
			set	
			{
				appWhiteList = value;
			}
		}

		public long? SlsCapacity
		{
			get
			{
				return slsCapacity;
			}
			set	
			{
				slsCapacity = value;
			}
		}

		public long? GmtCreate
		{
			get
			{
				return gmtCreate;
			}
			set	
			{
				gmtCreate = value;
			}
		}

		public long? LastInstanceReleaseTime
		{
			get
			{
				return lastInstanceReleaseTime;
			}
			set	
			{
				lastInstanceReleaseTime = value;
			}
		}

		public bool? IsOverBalance
		{
			get
			{
				return isOverBalance;
			}
			set	
			{
				isOverBalance = value;
			}
		}

		public long? LastTrailEndTime
		{
			get
			{
				return lastTrailEndTime;
			}
			set	
			{
				lastTrailEndTime = value;
			}
		}

		public long? HoneypotCapacity
		{
			get
			{
				return honeypotCapacity;
			}
			set	
			{
				honeypotCapacity = value;
			}
		}

		public long? ImageScanCapacity
		{
			get
			{
				return imageScanCapacity;
			}
			set	
			{
				imageScanCapacity = value;
			}
		}

		public int? VmCores
		{
			get
			{
				return vmCores;
			}
			set	
			{
				vmCores = value;
			}
		}

		public bool? IsPaidUser
		{
			get
			{
				return isPaidUser;
			}
			set	
			{
				isPaidUser = value;
			}
		}

		public int? HighestVersion
		{
			get
			{
				return highestVersion;
			}
			set	
			{
				highestVersion = value;
			}
		}

		public int? MVAuthCount
		{
			get
			{
				return mVAuthCount;
			}
			set	
			{
				mVAuthCount = value;
			}
		}

		public int? MVUnusedAuthCount
		{
			get
			{
				return mVUnusedAuthCount;
			}
			set	
			{
				mVUnusedAuthCount = value;
			}
		}

		public int? AllowPartialBuy
		{
			get
			{
				return allowPartialBuy;
			}
			set	
			{
				allowPartialBuy = value;
			}
		}
	}
}
