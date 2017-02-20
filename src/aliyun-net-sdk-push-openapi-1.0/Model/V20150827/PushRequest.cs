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
using Aliyun.Acs.Push.Transform.V20150827;

namespace Aliyun.Acs.Push.Model.V20150827
{
    public class PushRequest : RpcAcsRequest<PushResponse>
    {
        public PushRequest()
            : base("Push", "2015-08-27", "Push")
        {
        }

		private long? _appKey;

		private string _target;

		private string _targetValue;

		private int? _type;

		private int? _deviceType;

		private string _title;

		private string _body;

		private string _summary;

		private int? _timeOut;

		private bool? _remind;

		private bool? _storeOffline;

		private string _androidActivity;

		private string _xiaomiActivity;

		private string _androidOpenUrl;

		private string _androidExtParameters;

		private string _androidOpenType;

		private string _androidMusic;

		private string _batchNumber;

		private string _iOsMusic;

		private string _iOsBadge;

		private string _iOsTitle;

		private string _iOsSubtitle;

		private string _iOsNotificationCategory;

		private bool? _iOsMutableContent;

		private string _iOsExtParameters;

		private string _pushTime;

		private string _apnsEnv;

		private string _expireTime;

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

		public int? Type
		{
			get
			{
				return _type;
			}
			set	
			{
				_type = value;
				DictionaryUtil.Add(QueryParameters, "Type", value.ToString());
			}
		}

		public int? DeviceType
		{
			get
			{
				return _deviceType;
			}
			set	
			{
				_deviceType = value;
				DictionaryUtil.Add(QueryParameters, "DeviceType", value.ToString());
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

		public string Summary
		{
			get
			{
				return _summary;
			}
			set	
			{
				_summary = value;
				DictionaryUtil.Add(QueryParameters, "Summary", value);
			}
		}

		public int? TimeOut
		{
			get
			{
				return _timeOut;
			}
			set	
			{
				_timeOut = value;
				DictionaryUtil.Add(QueryParameters, "TimeOut", value.ToString());
			}
		}

		public bool? Remind
		{
			get
			{
				return _remind;
			}
			set	
			{
				_remind = value;
				DictionaryUtil.Add(QueryParameters, "Remind", value.ToString());
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

		public string XiaomiActivity
		{
			get
			{
				return _xiaomiActivity;
			}
			set	
			{
				_xiaomiActivity = value;
				DictionaryUtil.Add(QueryParameters, "XiaomiActivity", value);
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

		public string IosBadge
		{
			get
			{
				return _iOsBadge;
			}
			set	
			{
				_iOsBadge = value;
				DictionaryUtil.Add(QueryParameters, "iOSBadge", value);
			}
		}

		public string IosTitle
		{
			get
			{
				return _iOsTitle;
			}
			set	
			{
				_iOsTitle = value;
				DictionaryUtil.Add(QueryParameters, "iOSTitle", value);
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

		public string ApnsEnv
		{
			get
			{
				return _apnsEnv;
			}
			set	
			{
				_apnsEnv = value;
				DictionaryUtil.Add(QueryParameters, "ApnsEnv", value);
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

        public override PushResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return PushResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}