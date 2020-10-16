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
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private List<PushTask> pushTasks = new List<PushTask>(){ };

		private long? appKey;

		public List<PushTask> PushTasks
		{
			get
			{
				return pushTasks;
			}

			set
			{
				pushTasks = value;
				for (int i = 0; i < pushTasks.Count; i++)
				{
					DictionaryUtil.Add(BodyParameters,"PushTask." + (i + 1) + ".AndroidNotificationBarType", pushTasks[i].AndroidNotificationBarType);
					DictionaryUtil.Add(BodyParameters,"PushTask." + (i + 1) + ".AndroidExtParameters", pushTasks[i].AndroidExtParameters);
					DictionaryUtil.Add(BodyParameters,"PushTask." + (i + 1) + ".iOSBadge", pushTasks[i].IOSBadge);
					DictionaryUtil.Add(BodyParameters,"PushTask." + (i + 1) + ".iOSBadgeAutoIncrement", pushTasks[i].IOSBadgeAutoIncrement);
					DictionaryUtil.Add(BodyParameters,"PushTask." + (i + 1) + ".AndroidOpenType", pushTasks[i].AndroidOpenType);
					DictionaryUtil.Add(BodyParameters,"PushTask." + (i + 1) + ".Title", pushTasks[i].Title);
					DictionaryUtil.Add(BodyParameters,"PushTask." + (i + 1) + ".Body", pushTasks[i].Body);
					DictionaryUtil.Add(BodyParameters,"PushTask." + (i + 1) + ".DeviceType", pushTasks[i].DeviceType);
					DictionaryUtil.Add(BodyParameters,"PushTask." + (i + 1) + ".PushTime", pushTasks[i].PushTime);
					DictionaryUtil.Add(BodyParameters,"PushTask." + (i + 1) + ".SendSpeed", pushTasks[i].SendSpeed);
					DictionaryUtil.Add(BodyParameters,"PushTask." + (i + 1) + ".AndroidNotificationHuaweiChannel", pushTasks[i].AndroidNotificationHuaweiChannel);
					DictionaryUtil.Add(BodyParameters,"PushTask." + (i + 1) + ".AndroidPopupActivity", pushTasks[i].AndroidPopupActivity);
					DictionaryUtil.Add(BodyParameters,"PushTask." + (i + 1) + ".iOSRemindBody", pushTasks[i].IOSRemindBody);
					DictionaryUtil.Add(BodyParameters,"PushTask." + (i + 1) + ".iOSExtParameters", pushTasks[i].IOSExtParameters);
					DictionaryUtil.Add(BodyParameters,"PushTask." + (i + 1) + ".AndroidNotifyType", pushTasks[i].AndroidNotifyType);
					DictionaryUtil.Add(BodyParameters,"PushTask." + (i + 1) + ".AndroidPopupTitle", pushTasks[i].AndroidPopupTitle);
					DictionaryUtil.Add(BodyParameters,"PushTask." + (i + 1) + ".iOSMusic", pushTasks[i].IOSMusic);
					DictionaryUtil.Add(BodyParameters,"PushTask." + (i + 1) + ".iOSApnsEnv", pushTasks[i].IOSApnsEnv);
					DictionaryUtil.Add(BodyParameters,"PushTask." + (i + 1) + ".iOSMutableContent", pushTasks[i].IOSMutableContent);
					DictionaryUtil.Add(BodyParameters,"PushTask." + (i + 1) + ".AndroidNotificationBarPriority", pushTasks[i].AndroidNotificationBarPriority);
					DictionaryUtil.Add(BodyParameters,"PushTask." + (i + 1) + ".ExpireTime", pushTasks[i].ExpireTime);
					DictionaryUtil.Add(BodyParameters,"PushTask." + (i + 1) + ".AndroidNotificationVivoChannel", pushTasks[i].AndroidNotificationVivoChannel);
					DictionaryUtil.Add(BodyParameters,"PushTask." + (i + 1) + ".AndroidPopupBody", pushTasks[i].AndroidPopupBody);
					DictionaryUtil.Add(BodyParameters,"PushTask." + (i + 1) + ".iOSNotificationCategory", pushTasks[i].IOSNotificationCategory);
					DictionaryUtil.Add(BodyParameters,"PushTask." + (i + 1) + ".AndroidNotificationXiaomiChannel", pushTasks[i].AndroidNotificationXiaomiChannel);
					DictionaryUtil.Add(BodyParameters,"PushTask." + (i + 1) + ".StoreOffline", pushTasks[i].StoreOffline);
					DictionaryUtil.Add(BodyParameters,"PushTask." + (i + 1) + ".iOSSilentNotification", pushTasks[i].IOSSilentNotification);
					DictionaryUtil.Add(BodyParameters,"PushTask." + (i + 1) + ".JobKey", pushTasks[i].JobKey);
					DictionaryUtil.Add(BodyParameters,"PushTask." + (i + 1) + ".Target", pushTasks[i].Target);
					DictionaryUtil.Add(BodyParameters,"PushTask." + (i + 1) + ".AndroidOpenUrl", pushTasks[i].AndroidOpenUrl);
					DictionaryUtil.Add(BodyParameters,"PushTask." + (i + 1) + ".AndroidNotificationChannel", pushTasks[i].AndroidNotificationChannel);
					DictionaryUtil.Add(BodyParameters,"PushTask." + (i + 1) + ".AndroidRemind", pushTasks[i].AndroidRemind);
					DictionaryUtil.Add(BodyParameters,"PushTask." + (i + 1) + ".AndroidActivity", pushTasks[i].AndroidActivity);
					DictionaryUtil.Add(BodyParameters,"PushTask." + (i + 1) + ".AndroidXiaoMiNotifyBody", pushTasks[i].AndroidXiaoMiNotifyBody);
					DictionaryUtil.Add(BodyParameters,"PushTask." + (i + 1) + ".iOSSubtitle", pushTasks[i].IOSSubtitle);
					DictionaryUtil.Add(BodyParameters,"PushTask." + (i + 1) + ".iOSRemind", pushTasks[i].IOSRemind);
					DictionaryUtil.Add(BodyParameters,"PushTask." + (i + 1) + ".AndroidNotificationNotifyId", pushTasks[i].AndroidNotificationNotifyId);
					DictionaryUtil.Add(BodyParameters,"PushTask." + (i + 1) + ".TargetValue", pushTasks[i].TargetValue);
					DictionaryUtil.Add(BodyParameters,"PushTask." + (i + 1) + ".AndroidMusic", pushTasks[i].AndroidMusic);
					DictionaryUtil.Add(BodyParameters,"PushTask." + (i + 1) + ".AndroidXiaoMiActivity", pushTasks[i].AndroidXiaoMiActivity);
					DictionaryUtil.Add(BodyParameters,"PushTask." + (i + 1) + ".AndroidXiaoMiNotifyTitle", pushTasks[i].AndroidXiaoMiNotifyTitle);
					DictionaryUtil.Add(BodyParameters,"PushTask." + (i + 1) + ".iOSNotificationCollapseId", pushTasks[i].IOSNotificationCollapseId);
					DictionaryUtil.Add(BodyParameters,"PushTask." + (i + 1) + ".PushType", pushTasks[i].PushType);
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

			private string androidExtParameters;

			private int? iOSBadge;

			private bool? iOSBadgeAutoIncrement;

			private string androidOpenType;

			private string title;

			private string body;

			private string deviceType;

			private string pushTime;

			private int? sendSpeed;

			private string androidNotificationHuaweiChannel;

			private string androidPopupActivity;

			private string iOSRemindBody;

			private string iOSExtParameters;

			private string androidNotifyType;

			private string androidPopupTitle;

			private string iOSMusic;

			private string iOSApnsEnv;

			private bool? iOSMutableContent;

			private int? androidNotificationBarPriority;

			private string expireTime;

			private string androidNotificationVivoChannel;

			private string androidPopupBody;

			private string iOSNotificationCategory;

			private string androidNotificationXiaomiChannel;

			private bool? storeOffline;

			private bool? iOSSilentNotification;

			private string jobKey;

			private string target;

			private string androidOpenUrl;

			private string androidNotificationChannel;

			private bool? androidRemind;

			private string androidActivity;

			private string androidXiaoMiNotifyBody;

			private string iOSSubtitle;

			private bool? iOSRemind;

			private int? androidNotificationNotifyId;

			private string targetValue;

			private string androidMusic;

			private string androidXiaoMiActivity;

			private string androidXiaoMiNotifyTitle;

			private string iOSNotificationCollapseId;

			private string pushType;

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
		}

        public override MassPushResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return MassPushResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
