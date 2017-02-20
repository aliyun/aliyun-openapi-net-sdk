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
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.Push.Transform.V20160801;

namespace Aliyun.Acs.Push.Model.V20160801
{
    public class PushRequest : RpcAcsRequest<PushResponse>
    {
        public PushRequest()
            : base("Push", "2016-08-01", "Push")
        {
        }

		private long? _appKey;

		private string _target;

		private string _targetValue;

		private string _pushType;

		private string _deviceType;

		private string _title;

		private string _body;

		private string _pushTime;

		private string _expireTime;

		private bool? _storeOffline;

		private string _batchNumber;

		private string _androidNotifyType;

		private string _androidOpenType;

		private string _androidActivity;

		private string _androidOpenUrl;

		private string _androidXiaoMiActivity;

		private string _androidXiaoMiNotifyTitle;

		private string _androidXiaoMiNotifyBody;

		private string _androidMusic;

		private int? _androidNotificationBarType;

		private int? _androidNotificationBarPriority;

		private string _androidExtParameters;

		private string _iOsApnsEnv;

		private bool? _iOsRemind;

		private string _iOsRemindBody;

		private string _iOsMusic;

		private int? _iOsBadge;

		private bool? _iOsSilentNotification;

		private string _iOsSubtitle;

		private string _iOsNotificationCategory;

		private bool? _iOsMutableContent;

		private string _iOsExtParameters;

		public long? AppKey
		{
			get
			{
				return _appKey;
			}
			set	
			{
				_appKey = value;
				DictionaryUtil.Add(QueryParameters, "AppKey", value.ToString());
			}
		}

		public string Target
		{
			get
			{
				return _target;
			}
			set	
			{
				_target = value;
				DictionaryUtil.Add(QueryParameters, "Target", value);
			}
		}

		public string TargetValue
		{
			get
			{
				return _targetValue;
			}
			set	
			{
				_targetValue = value;
				DictionaryUtil.Add(QueryParameters, "TargetValue", value);
			}
		}

		public string PushType
		{
			get
			{
				return _pushType;
			}
			set	
			{
				_pushType = value;
				DictionaryUtil.Add(QueryParameters, "PushType", value);
			}
		}

		public string DeviceType
		{
			get
			{
				return _deviceType;
			}
			set	
			{
				_deviceType = value;
				DictionaryUtil.Add(QueryParameters, "DeviceType", value);
			}
		}

		public string Title
		{
			get
			{
				return _title;
			}
			set	
			{
				_title = value;
				DictionaryUtil.Add(QueryParameters, "Title", value);
			}
		}

		public string Body
		{
			get
			{
				return _body;
			}
			set	
			{
				_body = value;
				DictionaryUtil.Add(QueryParameters, "Body", value);
			}
		}

		public string PushTime
		{
			get
			{
				return _pushTime;
			}
			set	
			{
				_pushTime = value;
				DictionaryUtil.Add(QueryParameters, "PushTime", value);
			}
		}

		public string ExpireTime
		{
			get
			{
				return _expireTime;
			}
			set	
			{
				_expireTime = value;
				DictionaryUtil.Add(QueryParameters, "ExpireTime", value);
			}
		}

		public bool? StoreOffline
		{
			get
			{
				return _storeOffline;
			}
			set	
			{
				_storeOffline = value;
				DictionaryUtil.Add(QueryParameters, "StoreOffline", value.ToString());
			}
		}

		public string BatchNumber
		{
			get
			{
				return _batchNumber;
			}
			set	
			{
				_batchNumber = value;
				DictionaryUtil.Add(QueryParameters, "BatchNumber", value);
			}
		}

		public string AndroidNotifyType
		{
			get
			{
				return _androidNotifyType;
			}
			set	
			{
				_androidNotifyType = value;
				DictionaryUtil.Add(QueryParameters, "AndroidNotifyType", value);
			}
		}

		public string AndroidOpenType
		{
			get
			{
				return _androidOpenType;
			}
			set	
			{
				_androidOpenType = value;
				DictionaryUtil.Add(QueryParameters, "AndroidOpenType", value);
			}
		}

		public string AndroidActivity
		{
			get
			{
				return _androidActivity;
			}
			set	
			{
				_androidActivity = value;
				DictionaryUtil.Add(QueryParameters, "AndroidActivity", value);
			}
		}

		public string AndroidOpenUrl
		{
			get
			{
				return _androidOpenUrl;
			}
			set	
			{
				_androidOpenUrl = value;
				DictionaryUtil.Add(QueryParameters, "AndroidOpenUrl", value);
			}
		}

		public string AndroidXiaoMiActivity
		{
			get
			{
				return _androidXiaoMiActivity;
			}
			set	
			{
				_androidXiaoMiActivity = value;
				DictionaryUtil.Add(QueryParameters, "AndroidXiaoMiActivity", value);
			}
		}

		public string AndroidXiaoMiNotifyTitle
		{
			get
			{
				return _androidXiaoMiNotifyTitle;
			}
			set	
			{
				_androidXiaoMiNotifyTitle = value;
				DictionaryUtil.Add(QueryParameters, "AndroidXiaoMiNotifyTitle", value);
			}
		}

		public string AndroidXiaoMiNotifyBody
		{
			get
			{
				return _androidXiaoMiNotifyBody;
			}
			set	
			{
				_androidXiaoMiNotifyBody = value;
				DictionaryUtil.Add(QueryParameters, "AndroidXiaoMiNotifyBody", value);
			}
		}

		public string AndroidMusic
		{
			get
			{
				return _androidMusic;
			}
			set	
			{
				_androidMusic = value;
				DictionaryUtil.Add(QueryParameters, "AndroidMusic", value);
			}
		}

		public int? AndroidNotificationBarType
		{
			get
			{
				return _androidNotificationBarType;
			}
			set	
			{
				_androidNotificationBarType = value;
				DictionaryUtil.Add(QueryParameters, "AndroidNotificationBarType", value.ToString());
			}
		}

		public int? AndroidNotificationBarPriority
		{
			get
			{
				return _androidNotificationBarPriority;
			}
			set	
			{
				_androidNotificationBarPriority = value;
				DictionaryUtil.Add(QueryParameters, "AndroidNotificationBarPriority", value.ToString());
			}
		}

		public string AndroidExtParameters
		{
			get
			{
				return _androidExtParameters;
			}
			set	
			{
				_androidExtParameters = value;
				DictionaryUtil.Add(QueryParameters, "AndroidExtParameters", value);
			}
		}

		public string IosApnsEnv
		{
			get
			{
				return _iOsApnsEnv;
			}
			set	
			{
				_iOsApnsEnv = value;
				DictionaryUtil.Add(QueryParameters, "iOSApnsEnv", value);
			}
		}

		public bool? IosRemind
		{
			get
			{
				return _iOsRemind;
			}
			set	
			{
				_iOsRemind = value;
				DictionaryUtil.Add(QueryParameters, "iOSRemind", value.ToString());
			}
		}

		public string IosRemindBody
		{
			get
			{
				return _iOsRemindBody;
			}
			set	
			{
				_iOsRemindBody = value;
				DictionaryUtil.Add(QueryParameters, "iOSRemindBody", value);
			}
		}

		public string IosMusic
		{
			get
			{
				return _iOsMusic;
			}
			set	
			{
				_iOsMusic = value;
				DictionaryUtil.Add(QueryParameters, "iOSMusic", value);
			}
		}

		public int? IosBadge
		{
			get
			{
				return _iOsBadge;
			}
			set	
			{
				_iOsBadge = value;
				DictionaryUtil.Add(QueryParameters, "iOSBadge", value.ToString());
			}
		}

		public bool? IosSilentNotification
		{
			get
			{
				return _iOsSilentNotification;
			}
			set	
			{
				_iOsSilentNotification = value;
				DictionaryUtil.Add(QueryParameters, "iOSSilentNotification", value.ToString());
			}
		}

		public string IosSubtitle
		{
			get
			{
				return _iOsSubtitle;
			}
			set	
			{
				_iOsSubtitle = value;
				DictionaryUtil.Add(QueryParameters, "iOSSubtitle", value);
			}
		}

		public string IosNotificationCategory
		{
			get
			{
				return _iOsNotificationCategory;
			}
			set	
			{
				_iOsNotificationCategory = value;
				DictionaryUtil.Add(QueryParameters, "iOSNotificationCategory", value);
			}
		}

		public bool? IosMutableContent
		{
			get
			{
				return _iOsMutableContent;
			}
			set	
			{
				_iOsMutableContent = value;
				DictionaryUtil.Add(QueryParameters, "iOSMutableContent", value.ToString());
			}
		}

		public string IosExtParameters
		{
			get
			{
				return _iOsExtParameters;
			}
			set	
			{
				_iOsExtParameters = value;
				DictionaryUtil.Add(QueryParameters, "iOSExtParameters", value);
			}
		}

        public override PushResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return PushResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}