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

namespace Aliyun.Acs.Push.Model.V20160801
{
	public class QueryAppInfoResponse : AcsResponse
	{

		private AppInfo_ appInfo;

		public AppInfo_ AppInfo
		{
			get
			{
				return appInfo;
			}
			set	
			{
				appInfo = value;
			}
		}

		public class AppInfo_{

			private long? appKey;

			private string appId;

			private string pushAppId;

			private string appName;

			private string description;

			private int? industryId;

			private int? androidStatus;

			private int? iOSStatus;

			private long? deviceCount;

			private int? appStatus;

			private int? status;

			private Extension_ extension;

			public long? AppKey
			{
				get
				{
					return appKey;
				}
				set	
				{
					appKey = value;
				}
			}

			public string AppId
			{
				get
				{
					return appId;
				}
				set	
				{
					appId = value;
				}
			}

			public string PushAppId
			{
				get
				{
					return pushAppId;
				}
				set	
				{
					pushAppId = value;
				}
			}

			public string AppName
			{
				get
				{
					return appName;
				}
				set	
				{
					appName = value;
				}
			}

			public string Description
			{
				get
				{
					return description;
				}
				set	
				{
					description = value;
				}
			}

			public int? IndustryId
			{
				get
				{
					return industryId;
				}
				set	
				{
					industryId = value;
				}
			}

			public int? AndroidStatus
			{
				get
				{
					return androidStatus;
				}
				set	
				{
					androidStatus = value;
				}
			}

			public int? IOSStatus
			{
				get
				{
					return iOSStatus;
				}
				set	
				{
					iOSStatus = value;
				}
			}

			public long? DeviceCount
			{
				get
				{
					return deviceCount;
				}
				set	
				{
					deviceCount = value;
				}
			}

			public int? AppStatus
			{
				get
				{
					return appStatus;
				}
				set	
				{
					appStatus = value;
				}
			}

			public int? Status
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

			public Extension_ Extension
			{
				get
				{
					return extension;
				}
				set	
				{
					extension = value;
				}
			}

			public class Extension_{

				private string xmAppSecretKey;

				private string hwAppKey;

				private string hwAppSecretKey;

				public string XmAppSecretKey
				{
					get
					{
						return xmAppSecretKey;
					}
					set	
					{
						xmAppSecretKey = value;
					}
				}

				public string HwAppKey
				{
					get
					{
						return hwAppKey;
					}
					set	
					{
						hwAppKey = value;
					}
				}

				public string HwAppSecretKey
				{
					get
					{
						return hwAppSecretKey;
					}
					set	
					{
						hwAppSecretKey = value;
					}
				}
			}
		}
	}
}