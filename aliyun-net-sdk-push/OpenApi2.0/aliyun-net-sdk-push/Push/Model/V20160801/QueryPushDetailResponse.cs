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
	public class QueryPushDetailResponse : AcsResponse
	{

		private long? appKey;

		private string target;

		private string targetValue;

		private string pushType;

		private string deviceType;

		private string title;

		private string body;

		private string pushTime;

		private string expireTime;

		private int? antiHarassStartTime;

		private int? antiHarassDuration;

		private bool? storeOffline;

		private string batchNumber;

		private string provinceId;

		private string iOSApnsEnv;

		private bool? iOSRemind;

		private string iOSRemindBody;

		private int? iOSBadge;

		private string iOSMusic;

		private string iOSSubtitle;

		private string iOSNotificationCategory;

		private bool? iOSMutableContent;

		private string iOSExtParameters;

		private string androidNotifyType;

		private string androidOpenType;

		private string androidActivity;

		private string androidMusic;

		private string androidOpenUrl;

		private string androidXiaoMiActivity;

		private string androidXiaoMiNotifyTitle;

		private string androidXiaoMiNotifyBody;

		private int? androidNotificationBarType;

		private int? androidNotificationBarPriority;

		private string androidExtParameters;

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

		public string Target
		{
			get
			{
				return target;
			}
			set	
			{
				target = value;
			}
		}

		public string TargetValue
		{
			get
			{
				return targetValue;
			}
			set	
			{
				targetValue = value;
			}
		}

		public string PushType
		{
			get
			{
				return pushType;
			}
			set	
			{
				pushType = value;
			}
		}

		public string DeviceType
		{
			get
			{
				return deviceType;
			}
			set	
			{
				deviceType = value;
			}
		}

		public string Title
		{
			get
			{
				return title;
			}
			set	
			{
				title = value;
			}
		}

		public string Body
		{
			get
			{
				return body;
			}
			set	
			{
				body = value;
			}
		}

		public string PushTime
		{
			get
			{
				return pushTime;
			}
			set	
			{
				pushTime = value;
			}
		}

		public string ExpireTime
		{
			get
			{
				return expireTime;
			}
			set	
			{
				expireTime = value;
			}
		}

		public int? AntiHarassStartTime
		{
			get
			{
				return antiHarassStartTime;
			}
			set	
			{
				antiHarassStartTime = value;
			}
		}

		public int? AntiHarassDuration
		{
			get
			{
				return antiHarassDuration;
			}
			set	
			{
				antiHarassDuration = value;
			}
		}

		public bool? StoreOffline
		{
			get
			{
				return storeOffline;
			}
			set	
			{
				storeOffline = value;
			}
		}

		public string BatchNumber
		{
			get
			{
				return batchNumber;
			}
			set	
			{
				batchNumber = value;
			}
		}

		public string ProvinceId
		{
			get
			{
				return provinceId;
			}
			set	
			{
				provinceId = value;
			}
		}

		public string IOSApnsEnv
		{
			get
			{
				return iOSApnsEnv;
			}
			set	
			{
				iOSApnsEnv = value;
			}
		}

		public bool? IOSRemind
		{
			get
			{
				return iOSRemind;
			}
			set	
			{
				iOSRemind = value;
			}
		}

		public string IOSRemindBody
		{
			get
			{
				return iOSRemindBody;
			}
			set	
			{
				iOSRemindBody = value;
			}
		}

		public int? IOSBadge
		{
			get
			{
				return iOSBadge;
			}
			set	
			{
				iOSBadge = value;
			}
		}

		public string IOSMusic
		{
			get
			{
				return iOSMusic;
			}
			set	
			{
				iOSMusic = value;
			}
		}

		public string IOSSubtitle
		{
			get
			{
				return iOSSubtitle;
			}
			set	
			{
				iOSSubtitle = value;
			}
		}

		public string IOSNotificationCategory
		{
			get
			{
				return iOSNotificationCategory;
			}
			set	
			{
				iOSNotificationCategory = value;
			}
		}

		public bool? IOSMutableContent
		{
			get
			{
				return iOSMutableContent;
			}
			set	
			{
				iOSMutableContent = value;
			}
		}

		public string IOSExtParameters
		{
			get
			{
				return iOSExtParameters;
			}
			set	
			{
				iOSExtParameters = value;
			}
		}

		public string AndroidNotifyType
		{
			get
			{
				return androidNotifyType;
			}
			set	
			{
				androidNotifyType = value;
			}
		}

		public string AndroidOpenType
		{
			get
			{
				return androidOpenType;
			}
			set	
			{
				androidOpenType = value;
			}
		}

		public string AndroidActivity
		{
			get
			{
				return androidActivity;
			}
			set	
			{
				androidActivity = value;
			}
		}

		public string AndroidMusic
		{
			get
			{
				return androidMusic;
			}
			set	
			{
				androidMusic = value;
			}
		}

		public string AndroidOpenUrl
		{
			get
			{
				return androidOpenUrl;
			}
			set	
			{
				androidOpenUrl = value;
			}
		}

		public string AndroidXiaoMiActivity
		{
			get
			{
				return androidXiaoMiActivity;
			}
			set	
			{
				androidXiaoMiActivity = value;
			}
		}

		public string AndroidXiaoMiNotifyTitle
		{
			get
			{
				return androidXiaoMiNotifyTitle;
			}
			set	
			{
				androidXiaoMiNotifyTitle = value;
			}
		}

		public string AndroidXiaoMiNotifyBody
		{
			get
			{
				return androidXiaoMiNotifyBody;
			}
			set	
			{
				androidXiaoMiNotifyBody = value;
			}
		}

		public int? AndroidNotificationBarType
		{
			get
			{
				return androidNotificationBarType;
			}
			set	
			{
				androidNotificationBarType = value;
			}
		}

		public int? AndroidNotificationBarPriority
		{
			get
			{
				return androidNotificationBarPriority;
			}
			set	
			{
				androidNotificationBarPriority = value;
			}
		}

		public string AndroidExtParameters
		{
			get
			{
				return androidExtParameters;
			}
			set	
			{
				androidExtParameters = value;
			}
		}
	}
}