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
using Newtonsoft.Json;

using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.mseap;
using Aliyun.Acs.mseap.Transform;
using Aliyun.Acs.mseap.Transform.V20210118;

namespace Aliyun.Acs.mseap.Model.V20210118
{
    public class SendNotificationForPartnerRequest : RpcAcsRequest<SendNotificationForPartnerResponse>
    {
        public SendNotificationForPartnerRequest()
            : base("mseap", "2021-01-18", "SendNotificationForPartner")
        {
			Protocol = ProtocolType.HTTPS;
			Method = MethodType.POST;
        }

		private string trackId;

		private List<string> smartSubChannels = new List<string>(){ };

		private string channelType;

		private string notifyType;

		private string notifycationEventType;

		private string sendTarget;

		private string bizId;

		private string paramMap;

		[JsonProperty(PropertyName = "TrackId")]
		public string TrackId
		{
			get
			{
				return trackId;
			}
			set	
			{
				trackId = value;
				DictionaryUtil.Add(QueryParameters, "TrackId", value);
			}
		}

		[JsonProperty(PropertyName = "SmartSubChannels")]
		public List<string> SmartSubChannels
		{
			get
			{
				return smartSubChannels;
			}

			set
			{
				smartSubChannels = value;
				if(smartSubChannels != null)
				{
					for (int depth1 = 0; depth1 < smartSubChannels.Count; depth1++)
					{
						DictionaryUtil.Add(QueryParameters,"SmartSubChannels." + (depth1 + 1), smartSubChannels[depth1]);
					}
				}
			}
		}

		[JsonProperty(PropertyName = "ChannelType")]
		public string ChannelType
		{
			get
			{
				return channelType;
			}
			set	
			{
				channelType = value;
				DictionaryUtil.Add(QueryParameters, "ChannelType", value);
			}
		}

		[JsonProperty(PropertyName = "NotifyType")]
		public string NotifyType
		{
			get
			{
				return notifyType;
			}
			set	
			{
				notifyType = value;
				DictionaryUtil.Add(QueryParameters, "NotifyType", value);
			}
		}

		[JsonProperty(PropertyName = "NotifycationEventType")]
		public string NotifycationEventType
		{
			get
			{
				return notifycationEventType;
			}
			set	
			{
				notifycationEventType = value;
				DictionaryUtil.Add(QueryParameters, "NotifycationEventType", value);
			}
		}

		[JsonProperty(PropertyName = "SendTarget")]
		public string SendTarget
		{
			get
			{
				return sendTarget;
			}
			set	
			{
				sendTarget = value;
				DictionaryUtil.Add(QueryParameters, "SendTarget", value);
			}
		}

		[JsonProperty(PropertyName = "BizId")]
		public string BizId
		{
			get
			{
				return bizId;
			}
			set	
			{
				bizId = value;
				DictionaryUtil.Add(QueryParameters, "BizId", value);
			}
		}

		[JsonProperty(PropertyName = "ParamMap")]
		public string ParamMap
		{
			get
			{
				return paramMap;
			}
			set	
			{
				paramMap = value;
				DictionaryUtil.Add(QueryParameters, "ParamMap", value.ToString());
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override SendNotificationForPartnerResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return SendNotificationForPartnerResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
