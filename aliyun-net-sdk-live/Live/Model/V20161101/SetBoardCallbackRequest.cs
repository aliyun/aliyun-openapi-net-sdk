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
using Aliyun.Acs.live.Transform;
using Aliyun.Acs.live.Transform.V20161101;

namespace Aliyun.Acs.live.Model.V20161101
{
    public class SetBoardCallbackRequest : RpcAcsRequest<SetBoardCallbackResponse>
    {
        public SetBoardCallbackRequest()
            : base("live", "2016-11-01", "SetBoardCallback", "live", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.live.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.live.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string authKey;

		private int? callbackEnable;

		private string callbackEvents;

		private long? ownerId;

		private string callbackUri;

		private string appId;

		private string authSwitch;

		public string AuthKey
		{
			get
			{
				return authKey;
			}
			set	
			{
				authKey = value;
				DictionaryUtil.Add(QueryParameters, "AuthKey", value);
			}
		}

		public int? CallbackEnable
		{
			get
			{
				return callbackEnable;
			}
			set	
			{
				callbackEnable = value;
				DictionaryUtil.Add(QueryParameters, "CallbackEnable", value.ToString());
			}
		}

		public string CallbackEvents
		{
			get
			{
				return callbackEvents;
			}
			set	
			{
				callbackEvents = value;
				DictionaryUtil.Add(QueryParameters, "CallbackEvents", value);
			}
		}

		public long? OwnerId
		{
			get
			{
				return ownerId;
			}
			set	
			{
				ownerId = value;
				DictionaryUtil.Add(QueryParameters, "OwnerId", value.ToString());
			}
		}

		public string CallbackUri
		{
			get
			{
				return callbackUri;
			}
			set	
			{
				callbackUri = value;
				DictionaryUtil.Add(QueryParameters, "CallbackUri", value);
			}
		}

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

		public string AuthSwitch
		{
			get
			{
				return authSwitch;
			}
			set	
			{
				authSwitch = value;
				DictionaryUtil.Add(QueryParameters, "AuthSwitch", value);
			}
		}

        public override SetBoardCallbackResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return SetBoardCallbackResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
