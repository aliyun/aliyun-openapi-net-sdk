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
using Aliyun.Acs.Push.Transform.V20150827;
using System.Collections.Generic;

namespace Aliyun.Acs.Push.Model.V20150827
{
    public class PushRequest : RpcAcsRequest<PushResponse>
    {
        public PushRequest()
            : base("Push", "2015-08-27", "Push")
        {
        }

		private long? appKey;

		private string target;

		private string targetValue;

		private int? type;

		private int? deviceType;

		private string title;

		private string body;

		private string summary;

		private int? timeOut;

		private bool? remind;

		private bool? storeOffline;

		private string androidActivity;

		private string xiaomiActivity;

		private string androidOpenUrl;

		private string androidExtParameters;

		private string androidOpenType;

		private string androidMusic;

		private string batchNumber;

		private string iOSMusic;

		private string iOSBadge;

		private string iOSTitle;

		private string iOSSubtitle;

		private string iOSNotificationCategory;

		private bool? iOSMutableContent;

		private string iOSExtParameters;

		private string pushTime;

		private string apnsEnv;

		private string expireTime;

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

		public int? Type
		{
			get
			{
				return type;
			}
			set	
			{
				type = value;
				DictionaryUtil.Add(QueryParameters, "Type", value.ToString());
			}
		}

		public int? DeviceType
		{
			get
			{
				return deviceType;
			}
			set	
			{
				deviceType = value;
				DictionaryUtil.Add(QueryParameters, "DeviceType", value.ToString());
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

		public string Summary
		{
			get
			{
				return summary;
			}
			set	
			{
				summary = value;
				DictionaryUtil.Add(QueryParameters, "Summary", value);
			}
		}

		public int? TimeOut
		{
			get
			{
				return timeOut;
			}
			set	
			{
				timeOut = value;
				DictionaryUtil.Add(QueryParameters, "TimeOut", value.ToString());
			}
		}

		public bool? Remind
		{
			get
			{
				return remind;
			}
			set	
			{
				remind = value;
				DictionaryUtil.Add(QueryParameters, "Remind", value.ToString());
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

		public string XiaomiActivity
		{
			get
			{
				return xiaomiActivity;
			}
			set	
			{
				xiaomiActivity = value;
				DictionaryUtil.Add(QueryParameters, "XiaomiActivity", value);
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

		public string IOSBadge
		{
			get
			{
				return iOSBadge;
			}
			set	
			{
				iOSBadge = value;
				DictionaryUtil.Add(QueryParameters, "iOSBadge", value);
			}
		}

		public string IOSTitle
		{
			get
			{
				return iOSTitle;
			}
			set	
			{
				iOSTitle = value;
				DictionaryUtil.Add(QueryParameters, "iOSTitle", value);
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

		public string ApnsEnv
		{
			get
			{
				return apnsEnv;
			}
			set	
			{
				apnsEnv = value;
				DictionaryUtil.Add(QueryParameters, "ApnsEnv", value);
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

        public override PushResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return PushResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}