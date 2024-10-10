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
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Push.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Push.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private int? androidNotificationBarType;

		private string deviceType;

		private string pushTime;

		private int? sendSpeed;

		private string iOSRemindBody;

		private bool? trim;

		private string androidPopupTitle;

		private string iOSApnsEnv;

		private int? androidNotificationBarPriority;

		private string expireTime;

		private string androidImageUrl;

		private string androidVivoReceiptId;

		private string iOSNotificationCategory;

		private string androidXiaomiBigPictureUrl;

		private string harmonyCategory;

		private bool? iOSRemind;

		private string iOSNotificationThreadId;

		private int? androidHuaweiTargetUserType;

		private string androidMessageHuaweiUrgency;

		private string iOSInterruptionLevel;

		private string androidExtParameters;

		private int? iOSBadge;

		private bool? iOSBadgeAutoIncrement;

		private string androidOpenType;

		private string harmonyRemindTitle;

		private string androidBadgeClass;

		private int? smsDelaySecs;

		private int? androidRenderStyle;

		private string iOSExtParameters;

		private string androidXiaomiImageUrl;

		private string smsTemplateName;

		private string harmonyUri;

		private string harmonyExtParameters;

		private string androidBigPictureUrl;

		private bool? iOSSilentNotification;

		private string harmonyNotificationSlotType;

		private string androidBigTitle;

		private string androidNotificationChannel;

		private bool? androidRemind;

		private string androidActivity;

		private string smsSignName;

		private int? androidNotificationNotifyId;

		private long? appKey;

		private string targetValue;

		private int? harmonyBadgeSetNum;

		private string androidXiaoMiNotifyTitle;

		private int? smsSendPolicy;

		private string body;

		private string androidNotificationHuaweiChannel;

		private string androidPopupActivity;

		private int? harmonyNotifyId;

		private string harmonyRenderStyle;

		private string androidMessageVivoCategory;

		private string androidNotifyType;

		private string androidMessageHuaweiCategory;

		private string iOSMusic;

		private bool? iOSMutableContent;

		private int? androidHonorTargetUserType;

		private string harmonyRemindBody;

		private string androidNotificationVivoChannel;

		private string androidNotificationXiaomiChannel;

		private string harmonyAction;

		private bool? storeOffline;

		private double? iOSRelevanceScore;

		private string smsParams;

		private int? androidVivoPushMode;

		private string androidInboxBody;

		private string jobKey;

		private string harmonyReceiptId;

		private string androidOpenUrl;

		private int? androidBadgeSetNum;

		private string androidXiaoMiNotifyBody;

		private string iOSSubtitle;

		private bool? harmonyRemind;

		private string androidMusic;

		private bool? harmonyExtensionPush;

		private string iOSNotificationCollapseId;

		private string pushType;

		private string harmonyExtensionExtraData;

		private string harmonyImageUrl;

		private string androidBigBody;

		private string title;

		private int? harmonyBadgeAddNum;

		private bool? harmonyTestMessage;

		private int? androidBadgeAddNum;

		private string androidHuaweiReceiptId;

		private string androidNotificationHonorChannel;

		private int? androidTargetUserType;

		private string androidPopupBody;

		private string androidNotificationGroup;

		private string sendChannels;

		private string harmonyActionType;

		private string target;

		private string harmonyInboxContent;

		private string androidXiaoMiActivity;

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

		public bool? Trim
		{
			get
			{
				return trim;
			}
			set	
			{
				trim = value;
				DictionaryUtil.Add(QueryParameters, "Trim", value.ToString());
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

		public string AndroidImageUrl
		{
			get
			{
				return androidImageUrl;
			}
			set	
			{
				androidImageUrl = value;
				DictionaryUtil.Add(QueryParameters, "AndroidImageUrl", value);
			}
		}

		public string AndroidVivoReceiptId
		{
			get
			{
				return androidVivoReceiptId;
			}
			set	
			{
				androidVivoReceiptId = value;
				DictionaryUtil.Add(QueryParameters, "AndroidVivoReceiptId", value);
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

		public string AndroidXiaomiBigPictureUrl
		{
			get
			{
				return androidXiaomiBigPictureUrl;
			}
			set	
			{
				androidXiaomiBigPictureUrl = value;
				DictionaryUtil.Add(QueryParameters, "AndroidXiaomiBigPictureUrl", value);
			}
		}

		public string HarmonyCategory
		{
			get
			{
				return harmonyCategory;
			}
			set	
			{
				harmonyCategory = value;
				DictionaryUtil.Add(QueryParameters, "HarmonyCategory", value);
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

		public string IOSNotificationThreadId
		{
			get
			{
				return iOSNotificationThreadId;
			}
			set	
			{
				iOSNotificationThreadId = value;
				DictionaryUtil.Add(QueryParameters, "iOSNotificationThreadId", value);
			}
		}

		public int? AndroidHuaweiTargetUserType
		{
			get
			{
				return androidHuaweiTargetUserType;
			}
			set	
			{
				androidHuaweiTargetUserType = value;
				DictionaryUtil.Add(QueryParameters, "AndroidHuaweiTargetUserType", value.ToString());
			}
		}

		public string AndroidMessageHuaweiUrgency
		{
			get
			{
				return androidMessageHuaweiUrgency;
			}
			set	
			{
				androidMessageHuaweiUrgency = value;
				DictionaryUtil.Add(QueryParameters, "AndroidMessageHuaweiUrgency", value);
			}
		}

		public string IOSInterruptionLevel
		{
			get
			{
				return iOSInterruptionLevel;
			}
			set	
			{
				iOSInterruptionLevel = value;
				DictionaryUtil.Add(QueryParameters, "iOSInterruptionLevel", value);
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

		public string HarmonyRemindTitle
		{
			get
			{
				return harmonyRemindTitle;
			}
			set	
			{
				harmonyRemindTitle = value;
				DictionaryUtil.Add(QueryParameters, "HarmonyRemindTitle", value);
			}
		}

		public string AndroidBadgeClass
		{
			get
			{
				return androidBadgeClass;
			}
			set	
			{
				androidBadgeClass = value;
				DictionaryUtil.Add(QueryParameters, "AndroidBadgeClass", value);
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

		public int? AndroidRenderStyle
		{
			get
			{
				return androidRenderStyle;
			}
			set	
			{
				androidRenderStyle = value;
				DictionaryUtil.Add(QueryParameters, "AndroidRenderStyle", value.ToString());
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

		public string AndroidXiaomiImageUrl
		{
			get
			{
				return androidXiaomiImageUrl;
			}
			set	
			{
				androidXiaomiImageUrl = value;
				DictionaryUtil.Add(QueryParameters, "AndroidXiaomiImageUrl", value);
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

		public string HarmonyUri
		{
			get
			{
				return harmonyUri;
			}
			set	
			{
				harmonyUri = value;
				DictionaryUtil.Add(QueryParameters, "HarmonyUri", value);
			}
		}

		public string HarmonyExtParameters
		{
			get
			{
				return harmonyExtParameters;
			}
			set	
			{
				harmonyExtParameters = value;
				DictionaryUtil.Add(QueryParameters, "HarmonyExtParameters", value);
			}
		}

		public string AndroidBigPictureUrl
		{
			get
			{
				return androidBigPictureUrl;
			}
			set	
			{
				androidBigPictureUrl = value;
				DictionaryUtil.Add(QueryParameters, "AndroidBigPictureUrl", value);
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

		public string HarmonyNotificationSlotType
		{
			get
			{
				return harmonyNotificationSlotType;
			}
			set	
			{
				harmonyNotificationSlotType = value;
				DictionaryUtil.Add(QueryParameters, "HarmonyNotificationSlotType", value);
			}
		}

		public string AndroidBigTitle
		{
			get
			{
				return androidBigTitle;
			}
			set	
			{
				androidBigTitle = value;
				DictionaryUtil.Add(QueryParameters, "AndroidBigTitle", value);
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

		public int? HarmonyBadgeSetNum
		{
			get
			{
				return harmonyBadgeSetNum;
			}
			set	
			{
				harmonyBadgeSetNum = value;
				DictionaryUtil.Add(QueryParameters, "HarmonyBadgeSetNum", value.ToString());
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

		public int? HarmonyNotifyId
		{
			get
			{
				return harmonyNotifyId;
			}
			set	
			{
				harmonyNotifyId = value;
				DictionaryUtil.Add(QueryParameters, "HarmonyNotifyId", value.ToString());
			}
		}

		public string HarmonyRenderStyle
		{
			get
			{
				return harmonyRenderStyle;
			}
			set	
			{
				harmonyRenderStyle = value;
				DictionaryUtil.Add(QueryParameters, "HarmonyRenderStyle", value);
			}
		}

		public string AndroidMessageVivoCategory
		{
			get
			{
				return androidMessageVivoCategory;
			}
			set	
			{
				androidMessageVivoCategory = value;
				DictionaryUtil.Add(QueryParameters, "AndroidMessageVivoCategory", value);
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

		public string AndroidMessageHuaweiCategory
		{
			get
			{
				return androidMessageHuaweiCategory;
			}
			set	
			{
				androidMessageHuaweiCategory = value;
				DictionaryUtil.Add(QueryParameters, "AndroidMessageHuaweiCategory", value);
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

		public int? AndroidHonorTargetUserType
		{
			get
			{
				return androidHonorTargetUserType;
			}
			set	
			{
				androidHonorTargetUserType = value;
				DictionaryUtil.Add(QueryParameters, "AndroidHonorTargetUserType", value.ToString());
			}
		}

		public string HarmonyRemindBody
		{
			get
			{
				return harmonyRemindBody;
			}
			set	
			{
				harmonyRemindBody = value;
				DictionaryUtil.Add(QueryParameters, "HarmonyRemindBody", value);
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

		public string HarmonyAction
		{
			get
			{
				return harmonyAction;
			}
			set	
			{
				harmonyAction = value;
				DictionaryUtil.Add(QueryParameters, "HarmonyAction", value);
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

		public double? IOSRelevanceScore
		{
			get
			{
				return iOSRelevanceScore;
			}
			set	
			{
				iOSRelevanceScore = value;
				DictionaryUtil.Add(QueryParameters, "iOSRelevanceScore", value.ToString());
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

		public int? AndroidVivoPushMode
		{
			get
			{
				return androidVivoPushMode;
			}
			set	
			{
				androidVivoPushMode = value;
				DictionaryUtil.Add(QueryParameters, "AndroidVivoPushMode", value.ToString());
			}
		}

		public string AndroidInboxBody
		{
			get
			{
				return androidInboxBody;
			}
			set	
			{
				androidInboxBody = value;
				DictionaryUtil.Add(QueryParameters, "AndroidInboxBody", value);
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

		public string HarmonyReceiptId
		{
			get
			{
				return harmonyReceiptId;
			}
			set	
			{
				harmonyReceiptId = value;
				DictionaryUtil.Add(QueryParameters, "HarmonyReceiptId", value);
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

		public int? AndroidBadgeSetNum
		{
			get
			{
				return androidBadgeSetNum;
			}
			set	
			{
				androidBadgeSetNum = value;
				DictionaryUtil.Add(QueryParameters, "AndroidBadgeSetNum", value.ToString());
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

		public bool? HarmonyRemind
		{
			get
			{
				return harmonyRemind;
			}
			set	
			{
				harmonyRemind = value;
				DictionaryUtil.Add(QueryParameters, "HarmonyRemind", value.ToString());
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

		public bool? HarmonyExtensionPush
		{
			get
			{
				return harmonyExtensionPush;
			}
			set	
			{
				harmonyExtensionPush = value;
				DictionaryUtil.Add(QueryParameters, "HarmonyExtensionPush", value.ToString());
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

		public string HarmonyExtensionExtraData
		{
			get
			{
				return harmonyExtensionExtraData;
			}
			set	
			{
				harmonyExtensionExtraData = value;
				DictionaryUtil.Add(QueryParameters, "HarmonyExtensionExtraData", value);
			}
		}

		public string HarmonyImageUrl
		{
			get
			{
				return harmonyImageUrl;
			}
			set	
			{
				harmonyImageUrl = value;
				DictionaryUtil.Add(QueryParameters, "HarmonyImageUrl", value);
			}
		}

		public string AndroidBigBody
		{
			get
			{
				return androidBigBody;
			}
			set	
			{
				androidBigBody = value;
				DictionaryUtil.Add(QueryParameters, "AndroidBigBody", value);
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

		public int? HarmonyBadgeAddNum
		{
			get
			{
				return harmonyBadgeAddNum;
			}
			set	
			{
				harmonyBadgeAddNum = value;
				DictionaryUtil.Add(QueryParameters, "HarmonyBadgeAddNum", value.ToString());
			}
		}

		public bool? HarmonyTestMessage
		{
			get
			{
				return harmonyTestMessage;
			}
			set	
			{
				harmonyTestMessage = value;
				DictionaryUtil.Add(QueryParameters, "HarmonyTestMessage", value.ToString());
			}
		}

		public int? AndroidBadgeAddNum
		{
			get
			{
				return androidBadgeAddNum;
			}
			set	
			{
				androidBadgeAddNum = value;
				DictionaryUtil.Add(QueryParameters, "AndroidBadgeAddNum", value.ToString());
			}
		}

		public string AndroidHuaweiReceiptId
		{
			get
			{
				return androidHuaweiReceiptId;
			}
			set	
			{
				androidHuaweiReceiptId = value;
				DictionaryUtil.Add(QueryParameters, "AndroidHuaweiReceiptId", value);
			}
		}

		public string AndroidNotificationHonorChannel
		{
			get
			{
				return androidNotificationHonorChannel;
			}
			set	
			{
				androidNotificationHonorChannel = value;
				DictionaryUtil.Add(QueryParameters, "AndroidNotificationHonorChannel", value);
			}
		}

		public int? AndroidTargetUserType
		{
			get
			{
				return androidTargetUserType;
			}
			set	
			{
				androidTargetUserType = value;
				DictionaryUtil.Add(QueryParameters, "AndroidTargetUserType", value.ToString());
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

		public string AndroidNotificationGroup
		{
			get
			{
				return androidNotificationGroup;
			}
			set	
			{
				androidNotificationGroup = value;
				DictionaryUtil.Add(QueryParameters, "AndroidNotificationGroup", value);
			}
		}

		public string SendChannels
		{
			get
			{
				return sendChannels;
			}
			set	
			{
				sendChannels = value;
				DictionaryUtil.Add(QueryParameters, "SendChannels", value);
			}
		}

		public string HarmonyActionType
		{
			get
			{
				return harmonyActionType;
			}
			set	
			{
				harmonyActionType = value;
				DictionaryUtil.Add(QueryParameters, "HarmonyActionType", value);
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

		public string HarmonyInboxContent
		{
			get
			{
				return harmonyInboxContent;
			}
			set	
			{
				harmonyInboxContent = value;
				DictionaryUtil.Add(QueryParameters, "HarmonyInboxContent", value);
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

        public override PushResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return PushResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
