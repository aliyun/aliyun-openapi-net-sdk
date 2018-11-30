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
    public class RegisterMediaRequest : RpcAcsRequest<RegisterMediaResponse>
    {
        public RegisterMediaRequest()
            : base("vod", "2017-03-21", "RegisterMedia")
        {
        }

		private string userData;

		private long? resourceOwnerId;

		private string templateGroupId;

		private string resourceOwnerAccount;

		private string action;

		private long? ownerId;

		private string registerMetadatas;

		private string workFlowId;

		private string accessKeyId;

		public string UserData
		{
			get
			{
				return userData;
			}
			set	
			{
				userData = value;
				DictionaryUtil.Add(QueryParameters, "UserData", value);
			}
		}

		public long? ResourceOwnerId
		{
			get
			{
				return resourceOwnerId;
			}
			set	
			{
				resourceOwnerId = value;
				DictionaryUtil.Add(QueryParameters, "ResourceOwnerId", value.ToString());
			}
		}

		public string TemplateGroupId
		{
			get
			{
				return templateGroupId;
			}
			set	
			{
				templateGroupId = value;
				DictionaryUtil.Add(QueryParameters, "TemplateGroupId", value);
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

		public string RegisterMetadatas
		{
			get
			{
				return registerMetadatas;
			}
			set	
			{
				registerMetadatas = value;
				DictionaryUtil.Add(QueryParameters, "RegisterMetadatas", value);
			}
		}

		public string WorkFlowId
		{
			get
			{
				return workFlowId;
			}
			set	
			{
				workFlowId = value;
				DictionaryUtil.Add(QueryParameters, "WorkFlowId", value);
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

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override RegisterMediaResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return RegisterMediaResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}