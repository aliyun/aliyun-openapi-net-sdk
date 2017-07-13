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
using Aliyun.Acs.vod.Transform;
using Aliyun.Acs.vod.Transform.V20170321;
using System.Collections.Generic;

namespace Aliyun.Acs.vod.Model.V20170321
{
    public class SetMessageCallbackRequest : RpcAcsRequest<SetMessageCallbackResponse>
    {
        public SetMessageCallbackRequest()
            : base("vod", "2017-03-21", "SetMessageCallback")
        {
        }

		private string eventTypeList;

		private string accessKeyId;

		private string resourceOwnerAccount;

		private string callbackURL;

		private string callbackSwitch;

		private string callbackType;

		private string action;

		private string resourceOwnerId;

		private string ownerAccount;

		private string ownerId;

		public string EventTypeList
		{
			get
			{
				return eventTypeList;
			}
			set	
			{
				eventTypeList = value;
				DictionaryUtil.Add(QueryParameters, "EventTypeList", value);
			}
		}

		public string AccessKeyId
		{
			get
			{
				return accessKeyId;
			}
			set	
			{
				accessKeyId = value;
				DictionaryUtil.Add(QueryParameters, "AccessKeyId", value);
			}
		}

		public string ResourceOwnerAccount
		{
			get
			{
				return resourceOwnerAccount;
			}
			set	
			{
				resourceOwnerAccount = value;
				DictionaryUtil.Add(QueryParameters, "ResourceOwnerAccount", value);
			}
		}

		public string CallbackURL
		{
			get
			{
				return callbackURL;
			}
			set	
			{
				callbackURL = value;
				DictionaryUtil.Add(QueryParameters, "CallbackURL", value);
			}
		}

		public string CallbackSwitch
		{
			get
			{
				return callbackSwitch;
			}
			set	
			{
				callbackSwitch = value;
				DictionaryUtil.Add(QueryParameters, "CallbackSwitch", value);
			}
		}

		public string CallbackType
		{
			get
			{
				return callbackType;
			}
			set	
			{
				callbackType = value;
				DictionaryUtil.Add(QueryParameters, "CallbackType", value);
			}
		}

		public string Action
		{
			get
			{
				return action;
			}
			set	
			{
				action = value;
				DictionaryUtil.Add(QueryParameters, "Action", value);
			}
		}

		public string ResourceOwnerId
		{
			get
			{
				return resourceOwnerId;
			}
			set	
			{
				resourceOwnerId = value;
				DictionaryUtil.Add(QueryParameters, "ResourceOwnerId", value);
			}
		}

		public string OwnerAccount
		{
			get
			{
				return ownerAccount;
			}
			set	
			{
				ownerAccount = value;
				DictionaryUtil.Add(QueryParameters, "OwnerAccount", value);
			}
		}

		public string OwnerId
		{
			get
			{
				return ownerId;
			}
			set	
			{
				ownerId = value;
				DictionaryUtil.Add(QueryParameters, "OwnerId", value);
			}
		}

        public override SetMessageCallbackResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return SetMessageCallbackResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}