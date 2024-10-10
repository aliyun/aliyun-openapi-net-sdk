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
    public class MassPushRequest : RpcAcsRequest<MassPushResponse>
    {
        public MassPushRequest()
            : base("Push", "2016-08-01", "MassPush")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Push.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Push.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private List<int?> pushTasks = new List<int?>(){ };

		private long? appKey;

		public List<int?> PushTasks
		{
			get
			{
				return pushTasks;
			}

			set
			{
				pushTasks = value;
				if(pushTasks != null)
				{
					for (int depth1 = 0; depth1 < pushTasks.Count; depth1++)
					{
						DictionaryUtil.Add(BodyParameters,"PushTask." + (depth1 + 1), pushTasks[depth1]);
						DictionaryUtil.Add(BodyParameters,"PushTask." + (depth1 + 1), pushTasks[depth1]);
						DictionaryUtil.Add(BodyParameters,"PushTask." + (depth1 + 1), pushTasks[depth1]);
						DictionaryUtil.Add(BodyParameters,"PushTask." + (depth1 + 1), pushTasks[depth1]);
						DictionaryUtil.Add(BodyParameters,"PushTask." + (depth1 + 1), pushTasks[depth1]);
						DictionaryUtil.Add(BodyParameters,"PushTask." + (depth1 + 1), pushTasks[depth1]);
						DictionaryUtil.Add(BodyParameters,"PushTask." + (depth1 + 1), pushTasks[depth1]);
						DictionaryUtil.Add(BodyParameters,"PushTask." + (depth1 + 1), pushTasks[depth1]);
						DictionaryUtil.Add(BodyParameters,"PushTask." + (depth1 + 1), pushTasks[depth1]);
						DictionaryUtil.Add(BodyParameters,"PushTask." + (depth1 + 1), pushTasks[depth1]);
						DictionaryUtil.Add(BodyParameters,"PushTask." + (depth1 + 1), pushTasks[depth1]);
						DictionaryUtil.Add(BodyParameters,"PushTask." + (depth1 + 1), pushTasks[depth1]);
						DictionaryUtil.Add(BodyParameters,"PushTask." + (depth1 + 1), pushTasks[depth1]);
						DictionaryUtil.Add(BodyParameters,"PushTask." + (depth1 + 1), pushTasks[depth1]);
						DictionaryUtil.Add(BodyParameters,"PushTask." + (depth1 + 1), pushTasks[depth1]);
						DictionaryUtil.Add(BodyParameters,"PushTask." + (depth1 + 1), pushTasks[depth1]);
						DictionaryUtil.Add(BodyParameters,"PushTask." + (depth1 + 1), pushTasks[depth1]);
						DictionaryUtil.Add(BodyParameters,"PushTask." + (depth1 + 1), pushTasks[depth1]);
						DictionaryUtil.Add(BodyParameters,"PushTask." + (depth1 + 1), pushTasks[depth1]);
						DictionaryUtil.Add(BodyParameters,"PushTask." + (depth1 + 1), pushTasks[depth1]);
						DictionaryUtil.Add(BodyParameters,"PushTask." + (depth1 + 1), pushTasks[depth1]);
						DictionaryUtil.Add(BodyParameters,"PushTask." + (depth1 + 1), pushTasks[depth1]);
						DictionaryUtil.Add(BodyParameters,"PushTask." + (depth1 + 1), pushTasks[depth1]);
						DictionaryUtil.Add(BodyParameters,"PushTask." + (depth1 + 1), pushTasks[depth1]);
						DictionaryUtil.Add(BodyParameters,"PushTask." + (depth1 + 1), pushTasks[depth1]);
						DictionaryUtil.Add(BodyParameters,"PushTask." + (depth1 + 1), pushTasks[depth1]);
						DictionaryUtil.Add(BodyParameters,"PushTask." + (depth1 + 1), pushTasks[depth1]);
						DictionaryUtil.Add(BodyParameters,"PushTask." + (depth1 + 1), pushTasks[depth1]);
						DictionaryUtil.Add(BodyParameters,"PushTask." + (depth1 + 1), pushTasks[depth1]);
						DictionaryUtil.Add(BodyParameters,"PushTask." + (depth1 + 1), pushTasks[depth1]);
						DictionaryUtil.Add(BodyParameters,"PushTask." + (depth1 + 1), pushTasks[depth1]);
						DictionaryUtil.Add(BodyParameters,"PushTask." + (depth1 + 1), pushTasks[depth1]);
						DictionaryUtil.Add(BodyParameters,"PushTask." + (depth1 + 1), pushTasks[depth1]);
						DictionaryUtil.Add(BodyParameters,"PushTask." + (depth1 + 1), pushTasks[depth1]);
						DictionaryUtil.Add(BodyParameters,"PushTask." + (depth1 + 1), pushTasks[depth1]);
						DictionaryUtil.Add(BodyParameters,"PushTask." + (depth1 + 1), pushTasks[depth1]);
						DictionaryUtil.Add(BodyParameters,"PushTask." + (depth1 + 1), pushTasks[depth1]);
						DictionaryUtil.Add(BodyParameters,"PushTask." + (depth1 + 1), pushTasks[depth1]);
						DictionaryUtil.Add(BodyParameters,"PushTask." + (depth1 + 1), pushTasks[depth1]);
						DictionaryUtil.Add(BodyParameters,"PushTask." + (depth1 + 1), pushTasks[depth1]);
						DictionaryUtil.Add(BodyParameters,"PushTask." + (depth1 + 1), pushTasks[depth1]);
						DictionaryUtil.Add(BodyParameters,"PushTask." + (depth1 + 1), pushTasks[depth1]);
						DictionaryUtil.Add(BodyParameters,"PushTask." + (depth1 + 1), pushTasks[depth1]);
						DictionaryUtil.Add(BodyParameters,"PushTask." + (depth1 + 1), pushTasks[depth1]);
						DictionaryUtil.Add(BodyParameters,"PushTask." + (depth1 + 1), pushTasks[depth1]);
						DictionaryUtil.Add(BodyParameters,"PushTask." + (depth1 + 1), pushTasks[depth1]);
						DictionaryUtil.Add(BodyParameters,"PushTask." + (depth1 + 1), pushTasks[depth1]);
						DictionaryUtil.Add(BodyParameters,"PushTask." + (depth1 + 1), pushTasks[depth1]);
						DictionaryUtil.Add(BodyParameters,"PushTask." + (depth1 + 1), pushTasks[depth1]);
						DictionaryUtil.Add(BodyParameters,"PushTask." + (depth1 + 1), pushTasks[depth1]);
						DictionaryUtil.Add(BodyParameters,"PushTask." + (depth1 + 1), pushTasks[depth1]);
						DictionaryUtil.Add(BodyParameters,"PushTask." + (depth1 + 1), pushTasks[depth1]);
						DictionaryUtil.Add(BodyParameters,"PushTask." + (depth1 + 1), pushTasks[depth1]);
						DictionaryUtil.Add(BodyParameters,"PushTask." + (depth1 + 1), pushTasks[depth1]);
						DictionaryUtil.Add(BodyParameters,"PushTask." + (depth1 + 1), pushTasks[depth1]);
						DictionaryUtil.Add(BodyParameters,"PushTask." + (depth1 + 1), pushTasks[depth1]);
						DictionaryUtil.Add(BodyParameters,"PushTask." + (depth1 + 1), pushTasks[depth1]);
						DictionaryUtil.Add(BodyParameters,"PushTask." + (depth1 + 1), pushTasks[depth1]);
						DictionaryUtil.Add(BodyParameters,"PushTask." + (depth1 + 1), pushTasks[depth1]);
						DictionaryUtil.Add(BodyParameters,"PushTask." + (depth1 + 1), pushTasks[depth1]);
						DictionaryUtil.Add(BodyParameters,"PushTask." + (depth1 + 1), pushTasks[depth1]);
						DictionaryUtil.Add(BodyParameters,"PushTask." + (depth1 + 1), pushTasks[depth1]);
						DictionaryUtil.Add(BodyParameters,"PushTask." + (depth1 + 1), pushTasks[depth1]);
						DictionaryUtil.Add(BodyParameters,"PushTask." + (depth1 + 1), pushTasks[depth1]);
						DictionaryUtil.Add(BodyParameters,"PushTask." + (depth1 + 1), pushTasks[depth1]);
						DictionaryUtil.Add(BodyParameters,"PushTask." + (depth1 + 1), pushTasks[depth1]);
						DictionaryUtil.Add(BodyParameters,"PushTask." + (depth1 + 1), pushTasks[depth1]);
						DictionaryUtil.Add(BodyParameters,"PushTask." + (depth1 + 1), pushTasks[depth1]);
						DictionaryUtil.Add(BodyParameters,"PushTask." + (depth1 + 1), pushTasks[depth1]);
						DictionaryUtil.Add(BodyParameters,"PushTask." + (depth1 + 1), pushTasks[depth1]);
						DictionaryUtil.Add(BodyParameters,"PushTask." + (depth1 + 1), pushTasks[depth1]);
						DictionaryUtil.Add(BodyParameters,"PushTask." + (depth1 + 1), pushTasks[depth1]);
						DictionaryUtil.Add(BodyParameters,"PushTask." + (depth1 + 1), pushTasks[depth1]);
						DictionaryUtil.Add(BodyParameters,"PushTask." + (depth1 + 1), pushTasks[depth1]);
						DictionaryUtil.Add(BodyParameters,"PushTask." + (depth1 + 1), pushTasks[depth1]);
						DictionaryUtil.Add(BodyParameters,"PushTask." + (depth1 + 1), pushTasks[depth1]);
						DictionaryUtil.Add(BodyParameters,"PushTask." + (depth1 + 1), pushTasks[depth1]);
						DictionaryUtil.Add(BodyParameters,"PushTask." + (depth1 + 1), pushTasks[depth1]);
						DictionaryUtil.Add(BodyParameters,"PushTask." + (depth1 + 1), pushTasks[depth1]);
						DictionaryUtil.Add(BodyParameters,"PushTask." + (depth1 + 1), pushTasks[depth1]);
						DictionaryUtil.Add(BodyParameters,"PushTask." + (depth1 + 1), pushTasks[depth1]);
						DictionaryUtil.Add(BodyParameters,"PushTask." + (depth1 + 1), pushTasks[depth1]);
						DictionaryUtil.Add(BodyParameters,"PushTask." + (depth1 + 1), pushTasks[depth1]);
						DictionaryUtil.Add(BodyParameters,"PushTask." + (depth1 + 1), pushTasks[depth1]);
						DictionaryUtil.Add(BodyParameters,"PushTask." + (depth1 + 1), pushTasks[depth1]);
						DictionaryUtil.Add(BodyParameters,"PushTask." + (depth1 + 1), pushTasks[depth1]);
						DictionaryUtil.Add(BodyParameters,"PushTask." + (depth1 + 1), pushTasks[depth1]);
						DictionaryUtil.Add(BodyParameters,"PushTask." + (depth1 + 1), pushTasks[depth1]);
						DictionaryUtil.Add(BodyParameters,"PushTask." + (depth1 + 1), pushTasks[depth1]);
					}
				}
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

		public class PushTask
		{

			private int? androidNotificationBarType;

			private string body;

			private string deviceType;

			private string pushTime;

			private int? sendSpeed;

			private string androidNotificationHuaweiChannel;

			private string androidPopupActivity;

			private int? harmonyNotifyId;

			private string harmonyRenderStyle;

			private string iOSRemindBody;

			private bool? trim;

			private string androidMessageVivoCategory;

			private string androidNotifyType;

			private string androidPopupTitle;

			private string androidMessageHuaweiCategory;

			private string iOSMusic;

			private string iOSApnsEnv;

			private bool? iOSMutableContent;

			private int? androidNotificationBarPriority;

			private string expireTime;

			private string androidImageUrl;

			private int? androidHonorTargetUserType;

			private string harmonyRemindBody;

			private string androidNotificationVivoChannel;

			private string androidVivoReceiptId;

			private string iOSNotificationCategory;

			private string androidNotificationXiaomiChannel;

			private string harmonyAction;

			private bool? storeOffline;

			private double? iOSRelevanceScore;

			private int? androidVivoPushMode;

			private string androidInboxBody;

			private string jobKey;

			private string harmonyReceiptId;

			private string androidOpenUrl;

			private int? androidBadgeSetNum;

			private string androidXiaoMiNotifyBody;

			private string iOSSubtitle;

			private string androidXiaomiBigPictureUrl;

			private string harmonyCategory;

			private bool? iOSRemind;

			private string iOSNotificationThreadId;

			private int? androidHuaweiTargetUserType;

			private bool? harmonyRemind;

			private string androidMusic;

			private bool? harmonyExtensionPush;

			private string iOSNotificationCollapseId;

			private string androidMessageHuaweiUrgency;

			private string pushType;

			private string iOSInterruptionLevel;

			private string harmonyExtensionExtraData;

			private string androidExtParameters;

			private string harmonyImageUrl;

			private int? iOSBadge;

			private string androidBigBody;

			private bool? iOSBadgeAutoIncrement;

			private string androidOpenType;

			private string harmonyRemindTitle;

			private string title;

			private string androidBadgeClass;

			private int? harmonyBadgeAddNum;

			private bool? harmonyTestMessage;

			private string androidRenderStyle;

			private string iOSExtParameters;

			private int? androidBadgeAddNum;

			private string androidHuaweiReceiptId;

			private string androidNotificationHonorChannel;

			private string androidXiaomiImageUrl;

			private int? androidTargetUserType;

			private string harmonyUri;

			private string androidPopupBody;

			private string harmonyExtParameters;

			private string androidBigPictureUrl;

			private bool? iOSSilentNotification;

			private string androidNotificationGroup;

			private string sendChannels;

			private string harmonyActionType;

			private string target;

			private string harmonyNotificationSlotType;

			private string androidBigTitle;

			private string androidNotificationChannel;

			private bool? androidRemind;

			private string harmonyInboxContent;

			private string androidActivity;

			private int? androidNotificationNotifyId;

			private string targetValue;

			private int? harmonyBadgeSetNum;

			private string androidXiaoMiNotifyTitle;

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

			public int? SendSpeed
			{
				get
				{
					return sendSpeed;
				}
				set	
				{
					sendSpeed = value;
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

			public bool? Trim
			{
				get
				{
					return trim;
				}
				set	
				{
					trim = value;
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

			public string AndroidPopupTitle
			{
				get
				{
					return androidPopupTitle;
				}
				set	
				{
					androidPopupTitle = value;
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

			public string AndroidImageUrl
			{
				get
				{
					return androidImageUrl;
				}
				set	
				{
					androidImageUrl = value;
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

			public string AndroidNotificationXiaomiChannel
			{
				get
				{
					return androidNotificationXiaomiChannel;
				}
				set	
				{
					androidNotificationXiaomiChannel = value;
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

			public double? IOSRelevanceScore
			{
				get
				{
					return iOSRelevanceScore;
				}
				set	
				{
					iOSRelevanceScore = value;
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

			public int? AndroidBadgeSetNum
			{
				get
				{
					return androidBadgeSetNum;
				}
				set	
				{
					androidBadgeSetNum = value;
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

			public string AndroidXiaomiBigPictureUrl
			{
				get
				{
					return androidXiaomiBigPictureUrl;
				}
				set	
				{
					androidXiaomiBigPictureUrl = value;
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

			public string IOSNotificationThreadId
			{
				get
				{
					return iOSNotificationThreadId;
				}
				set	
				{
					iOSNotificationThreadId = value;
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

			public bool? HarmonyExtensionPush
			{
				get
				{
					return harmonyExtensionPush;
				}
				set	
				{
					harmonyExtensionPush = value;
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

			public string IOSInterruptionLevel
			{
				get
				{
					return iOSInterruptionLevel;
				}
				set	
				{
					iOSInterruptionLevel = value;
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

			public string HarmonyImageUrl
			{
				get
				{
					return harmonyImageUrl;
				}
				set	
				{
					harmonyImageUrl = value;
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

			public string AndroidBigBody
			{
				get
				{
					return androidBigBody;
				}
				set	
				{
					androidBigBody = value;
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

			public string HarmonyRemindTitle
			{
				get
				{
					return harmonyRemindTitle;
				}
				set	
				{
					harmonyRemindTitle = value;
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

			public string AndroidBadgeClass
			{
				get
				{
					return androidBadgeClass;
				}
				set	
				{
					androidBadgeClass = value;
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
				}
			}

			public string AndroidRenderStyle
			{
				get
				{
					return androidRenderStyle;
				}
				set	
				{
					androidRenderStyle = value;
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

			public int? AndroidBadgeAddNum
			{
				get
				{
					return androidBadgeAddNum;
				}
				set	
				{
					androidBadgeAddNum = value;
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

			public string HarmonyNotificationSlotType
			{
				get
				{
					return harmonyNotificationSlotType;
				}
				set	
				{
					harmonyNotificationSlotType = value;
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

			public int? AndroidNotificationNotifyId
			{
				get
				{
					return androidNotificationNotifyId;
				}
				set	
				{
					androidNotificationNotifyId = value;
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

			public int? HarmonyBadgeSetNum
			{
				get
				{
					return harmonyBadgeSetNum;
				}
				set	
				{
					harmonyBadgeSetNum = value;
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
		}

        public override MassPushResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return MassPushResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
