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
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.Push.Transform;
using Aliyun.Acs.Push.Transform.V20160801;
using System.Collections.Generic;

namespace Aliyun.Acs.Push.Model.V20160801
{
    public class PushRequest : RpcAcsRequest<PushResponse>
    {
        public PushRequest()
            : base("Push", "2016-08-01", "Push")
        {
        }

		private long? appKey;

		private string target;

		private string targetValue;

		private string pushType;

		private string deviceType;

		private string title;

		private string body;

		private string jobKey;

		private string pushTime;

		private string expireTime;

		private bool? storeOffline;

		private string batchNumber;

		private string androidNotifyType;

		private string androidOpenType;

		private string androidActivity;

		private string androidOpenUrl;

		private string androidXiaoMiActivity;

		private string androidXiaoMiNotifyTitle;

		private string androidXiaoMiNotifyBody;

		private string androidPopupActivity;

		private string androidPopupTitle;

		private string androidPopupBody;

		private string androidMusic;

		private int? androidNotificationBarType;

		private int? androidNotificationBarPriority;

		private string androidExtParameters;

		private bool? androidRemind;

		private string iOSApnsEnv;

		private bool? iOSRemind;

		private string iOSRemindBody;

		private string iOSMusic;

		private int? iOSBadge;

		private bool? iOSSilentNotification;

		private string iOSSubtitle;

		private string iOSNotificationCategory;

		private bool? iOSMutableContent;

		private string iOSExtParameters;

		public long? AppKey
		{
			get
			{
				return appKey;
			}
			set	
			{
				appKey = value;
				DictionaryUtil.Add(QueryParameters, "AppKey", value.ToString());
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
				DictionaryUtil.Add(QueryParameters, "Target", value);
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
				DictionaryUtil.Add(QueryParameters, "TargetValue", value);
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
				DictionaryUtil.Add(QueryParameters, "PushType", value);
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
				DictionaryUtil.Add(QueryParameters, "DeviceType", value);
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
				DictionaryUtil.Add(QueryParameters, "Title", value);
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
				DictionaryUtil.Add(QueryParameters, "Body", value);
			}
		}

		public string JobKey
		{
			get
			{
				return jobKey;
			}
			set
			{
				jobKey = value;
				DictionaryUtil.Add(QueryParameters, "JobKey", value);
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
				DictionaryUtil.Add(QueryParameters, "PushTime", value);
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
				DictionaryUtil.Add(QueryParameters, "ExpireTime", value);
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
				DictionaryUtil.Add(QueryParameters, "StoreOffline", value.ToString());
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
				DictionaryUtil.Add(QueryParameters, "BatchNumber", value);
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
				DictionaryUtil.Add(QueryParameters, "AndroidNotifyType", value);
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
				DictionaryUtil.Add(QueryParameters, "AndroidOpenType", value);
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
				DictionaryUtil.Add(QueryParameters, "AndroidActivity", value);
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
				DictionaryUtil.Add(QueryParameters, "AndroidOpenUrl", value);
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
				DictionaryUtil.Add(QueryParameters, "AndroidXiaoMiActivity", value);
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
				DictionaryUtil.Add(QueryParameters, "AndroidXiaoMiNotifyTitle", value);
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
				DictionaryUtil.Add(QueryParameters, "AndroidXiaoMiNotifyBody", value);
			}
		}

		public string AndroidPopupActivity
		{
			get
			{
				return androidPopupActivity;
			}
			set
			{
				androidPopupActivity = value;
				DictionaryUtil.Add(QueryParameters, "AndroidPopupActivity", value);
			}
		}

		public string AndroidPopupTitle
		{
			get
			{
				return androidPopupTitle;
			}
			set
			{
				androidPopupTitle = value;
				DictionaryUtil.Add(QueryParameters, "AndroidPopupTitle", value);
			}
		}

		public string AndroidPopupBody
		{
			get
			{
				return androidPopupBody;
			}
			set
			{
				androidPopupBody = value;
				DictionaryUtil.Add(QueryParameters, "AndroidPopupBody", value);
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
				DictionaryUtil.Add(QueryParameters, "AndroidMusic", value);
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
				DictionaryUtil.Add(QueryParameters, "AndroidNotificationBarType", value.ToString());
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
				DictionaryUtil.Add(QueryParameters, "AndroidNotificationBarPriority", value.ToString());
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
				DictionaryUtil.Add(QueryParameters, "AndroidExtParameters", value);
			}
		}

		public bool? AndroidRemind
		{
			get
			{
				return androidRemind;
			}
			set
			{
				androidRemind = value;
				DictionaryUtil.Add(QueryParameters, "AndroidRemind", value.ToString());
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
				DictionaryUtil.Add(QueryParameters, "iOSApnsEnv", value);
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
				DictionaryUtil.Add(QueryParameters, "iOSRemind", value.ToString());
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
				DictionaryUtil.Add(QueryParameters, "iOSRemindBody", value);
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
				DictionaryUtil.Add(QueryParameters, "iOSMusic", value);
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
				DictionaryUtil.Add(QueryParameters, "iOSBadge", value.ToString());
			}
		}

		public bool? IOSSilentNotification
		{
			get
			{
				return iOSSilentNotification;
			}
			set	
			{
				iOSSilentNotification = value;
				DictionaryUtil.Add(QueryParameters, "iOSSilentNotification", value.ToString());
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
				DictionaryUtil.Add(QueryParameters, "iOSSubtitle", value);
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
				DictionaryUtil.Add(QueryParameters, "iOSNotificationCategory", value);
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
				DictionaryUtil.Add(QueryParameters, "iOSMutableContent", value.ToString());
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
				DictionaryUtil.Add(QueryParameters, "iOSExtParameters", value);
			}
		}

        public override PushResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return PushResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
