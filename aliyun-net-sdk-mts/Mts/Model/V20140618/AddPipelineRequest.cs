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
using Aliyun.Acs.Mts.Transform;
using Aliyun.Acs.Mts.Transform.V20140618;
using System.Collections.Generic;

namespace Aliyun.Acs.Mts.Model.V20140618
{
    public class AddPipelineRequest : RpcAcsRequest<AddPipelineResponse>
    {
        public AddPipelineRequest()
            : base("Mts", "2014-06-18", "AddPipeline", "mts", "openAPI")
        {
        }

		private long? resourceOwnerId;

		private string role;

		private string resourceOwnerAccount;

		private string ownerAccount;

		private string name;

		private string action;

		private string notifyConfig;

		private long? ownerId;

		private long? speedLevel;

		private string speed;

		private string accessKeyId;

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

		public string Role
		{
			get
			{
				return role;
			}
			set	
			{
				role = value;
				DictionaryUtil.Add(QueryParameters, "Role", value);
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

		public string Name
		{
			get
			{
				return name;
			}
			set	
			{
				name = value;
				DictionaryUtil.Add(QueryParameters, "Name", value);
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

		public string NotifyConfig
		{
			get
			{
				return notifyConfig;
			}
			set	
			{
				notifyConfig = value;
				DictionaryUtil.Add(QueryParameters, "NotifyConfig", value);
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

		public long? SpeedLevel
		{
			get
			{
				return speedLevel;
			}
			set	
			{
				speedLevel = value;
				DictionaryUtil.Add(QueryParameters, "SpeedLevel", value.ToString());
			}
		}

		public string Speed
		{
			get
			{
				return speed;
			}
			set	
			{
				speed = value;
				DictionaryUtil.Add(QueryParameters, "Speed", value);
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

        public override AddPipelineResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return AddPipelineResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}