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
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.Push;
using Aliyun.Acs.Push.Transform;
using Aliyun.Acs.Push.Transform.V20160801;

namespace Aliyun.Acs.Push.Model.V20160801
{
    public class PushRequest : RpcAcsRequest<PushResponse>
    {
        public PushRequest()
            : base("Push", "2016-08-01", "Push")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private int? androidNotificationBarType;

		private int? smsSendPolicy;

		private string body;

		private string deviceType;

		private string pushTime;

		private int? sendSpeed;

		private string androidNotificationHuaweiChannel;

		private string androidPopupActivity;

		private string iOSRemindBody;

		private string androidNotifyType;

		private string androidPopupTitle;

		private string iOSMusic;

		private string iOSApnsEnv;

		private bool? iOSMutableContent;

		private int? androidNotificationBarPriority;

		private string expireTime;

		private string androidNotificationVivoChannel;

		private string iOSNotificationCategory;

		private string androidNotificationXiaomiChannel;

		private bool? storeOffline;

		private string smsParams;

		private string jobKey;

		private string androidOpenUrl;

		private string androidXiaoMiNotifyBody;

		private string iOSSubtitle;

		private bool? iOSRemind;

		private string androidMusic;

		private string iOSNotificationCollapseId;

		private string pushType;

		private string androidExtParameters;

		private int? iOSBadge;

		private bool? iOSBadgeAutoIncrement;

		private string androidOpenType;

		private string title;

		private int? smsDelaySecs;

		private string iOSExtParameters;

		private string smsTemplateName;

		private string androidPopupBody;

		private bool? iOSSilentNotification;

		private string target;

		private string androidNotificationChannel;

		private bool? androidRemind;

		private string androidActivity;

		private string smsSignName;

		private int? androidNotificationNotifyId;

		private long? appKey;

		private string targetValue;

		private string androidXiaoMiActivity;

		private string androidXiaoMiNotifyTitle;

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

		public int? SmsSendPolicy
		{
			get
			{
				return smsSendPolicy;
			}
			set	
			{
				smsSendPolicy = value;
				DictionaryUtil.Add(QueryParameters, "SmsSendPolicy", value.ToString());
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

		public int? SendSpeed
		{
			get
			{
				return sendSpeed;
			}
			set	
			{
				sendSpeed = value;
				DictionaryUtil.Add(QueryParameters, "SendSpeed", value.ToString());
			}
		}

		public string AndroidNotificationHuaweiChannel
		{
			get
			{
				return androidNotificationHuaweiChannel;
			}
			set	
			{
				androidNotificationHuaweiChannel = value;
				DictionaryUtil.Add(QueryParameters, "AndroidNotificationHuaweiChannel", value);
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

		public string AndroidNotificationVivoChannel
		{
			get
			{
				return androidNotificationVivoChannel;
			}
			set	
			{
				androidNotificationVivoChannel = value;
				DictionaryUtil.Add(QueryParameters, "AndroidNotificationVivoChannel", value);
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

		public string AndroidNotificationXiaomiChannel
		{
			get
			{
				return androidNotificationXiaomiChannel;
			}
			set	
			{
				androidNotificationXiaomiChannel = value;
				DictionaryUtil.Add(QueryParameters, "AndroidNotificationXiaomiChannel", value);
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

		public string SmsParams
		{
			get
			{
				return smsParams;
			}
			set	
			{
				smsParams = value;
				DictionaryUtil.Add(QueryParameters, "SmsParams", value);
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

		public string IOSNotificationCollapseId
		{
			get
			{
				return iOSNotificationCollapseId;
			}
			set	
			{
				iOSNotificationCollapseId = value;
				DictionaryUtil.Add(QueryParameters, "iOSNotificationCollapseId", value);
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

		public bool? IOSBadgeAutoIncrement
		{
			get
			{
				return iOSBadgeAutoIncrement;
			}
			set	
			{
				iOSBadgeAutoIncrement = value;
				DictionaryUtil.Add(QueryParameters, "iOSBadgeAutoIncrement", value.ToString());
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

		public int? SmsDelaySecs
		{
			get
			{
				return smsDelaySecs;
			}
			set	
			{
				smsDelaySecs = value;
				DictionaryUtil.Add(QueryParameters, "SmsDelaySecs", value.ToString());
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

		public string SmsTemplateName
		{
			get
			{
				return smsTemplateName;
			}
			set	
			{
				smsTemplateName = value;
				DictionaryUtil.Add(QueryParameters, "SmsTemplateName", value);
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

		public string AndroidNotificationChannel
		{
			get
			{
				return androidNotificationChannel;
			}
			set	
			{
				androidNotificationChannel = value;
				DictionaryUtil.Add(QueryParameters, "AndroidNotificationChannel", value);
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

		public string SmsSignName
		{
			get
			{
				return smsSignName;
			}
			set	
			{
				smsSignName = value;
				DictionaryUtil.Add(QueryParameters, "SmsSignName", value);
			}
		}

		public int? AndroidNotificationNotifyId
		{
			get
			{
				return androidNotificationNotifyId;
			}
			set	
			{
				androidNotificationNotifyId = value;
				DictionaryUtil.Add(QueryParameters, "AndroidNotificationNotifyId", value.ToString());
			}
		}

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

        public override PushResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return PushResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
