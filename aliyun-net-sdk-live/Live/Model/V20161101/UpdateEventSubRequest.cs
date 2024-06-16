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
using Aliyun.Acs.live.Transform;
using Aliyun.Acs.live.Transform.V20161101;

namespace Aliyun.Acs.live.Model.V20161101
{
    public class UpdateEventSubRequest : RpcAcsRequest<UpdateEventSubResponse>
    {
        public UpdateEventSubRequest()
            : base("live", "2016-11-01", "UpdateEventSub", "live", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.live.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.live.Endpoint.endpointRegionalType, null);
            }
			Protocol = ProtocolType.HTTPS;
			Method = MethodType.POST;
        }

		private string subscribeId;

		private List<string> userss = new List<string>(){ };

		private string appId;

		private string callbackUrl;

		private string channelId;

		private List<string> eventss = new List<string>(){ };

		[JsonProperty(PropertyName = "SubscribeId")]
		public string SubscribeId
		{
			get
			{
				return subscribeId;
			}
			set	
			{
				subscribeId = value;
				DictionaryUtil.Add(QueryParameters, "SubscribeId", value);
			}
		}

		[JsonProperty(PropertyName = "Users")]
		public List<string> Userss
		{
			get
			{
				return userss;
			}

			set
			{
				userss = value;
			}
		}

		[JsonProperty(PropertyName = "AppId")]
		public string AppId
		{
			get
			{
				return appId;
			}
			set	
			{
				appId = value;
				DictionaryUtil.Add(QueryParameters, "AppId", value);
			}
		}

		[JsonProperty(PropertyName = "CallbackUrl")]
		public string CallbackUrl
		{
			get
			{
				return callbackUrl;
			}
			set	
			{
				callbackUrl = value;
				DictionaryUtil.Add(QueryParameters, "CallbackUrl", value);
			}
		}

		[JsonProperty(PropertyName = "ChannelId")]
		public string ChannelId
		{
			get
			{
				return channelId;
			}
			set	
			{
				channelId = value;
				DictionaryUtil.Add(QueryParameters, "ChannelId", value);
			}
		}

		[JsonProperty(PropertyName = "Events")]
		public List<string> Eventss
		{
			get
			{
				return eventss;
			}

			set
			{
				eventss = value;
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override UpdateEventSubResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return UpdateEventSubResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
