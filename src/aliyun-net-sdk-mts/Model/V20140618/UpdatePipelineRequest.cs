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
using Aliyun.Acs.Mts.Transform.V20140618;

namespace Aliyun.Acs.Mts.Model.V20140618
{
    public class UpdatePipelineRequest : RpcAcsRequest<UpdatePipelineResponse>
    {
        public UpdatePipelineRequest()
            : base("Mts", "2014-06-18", "UpdatePipeline")
        {
        }

		private long? _ownerId;

		private string _resourceOwnerAccount;

		private long? _resourceOwnerId;

		private string _pipelineId;

		private string _name;

		private string _state;

		private string _notifyConfig;

		private string _role;

		private string _ownerAccount;

		public long? OwnerId
		{
			get
			{
				return _ownerId;
			}
			set	
			{
				_ownerId = value;
				DictionaryUtil.Add(QueryParameters, "OwnerId", value.ToString());
			}
		}

		public string ResourceOwnerAccount
		{
			get
			{
				return _resourceOwnerAccount;
			}
			set	
			{
				_resourceOwnerAccount = value;
				DictionaryUtil.Add(QueryParameters, "ResourceOwnerAccount", value);
			}
		}

		public long? ResourceOwnerId
		{
			get
			{
				return _resourceOwnerId;
			}
			set	
			{
				_resourceOwnerId = value;
				DictionaryUtil.Add(QueryParameters, "ResourceOwnerId", value.ToString());
			}
		}

		public string PipelineId
		{
			get
			{
				return _pipelineId;
			}
			set	
			{
				_pipelineId = value;
				DictionaryUtil.Add(QueryParameters, "PipelineId", value);
			}
		}

		public string Name
		{
			get
			{
				return _name;
			}
			set	
			{
				_name = value;
				DictionaryUtil.Add(QueryParameters, "Name", value);
			}
		}

		public string State
		{
			get
			{
				return _state;
			}
			set	
			{
				_state = value;
				DictionaryUtil.Add(QueryParameters, "State", value);
			}
		}

		public string NotifyConfig
		{
			get
			{
				return _notifyConfig;
			}
			set	
			{
				_notifyConfig = value;
				DictionaryUtil.Add(QueryParameters, "NotifyConfig", value);
			}
		}

		public string Role
		{
			get
			{
				return _role;
			}
			set	
			{
				_role = value;
				DictionaryUtil.Add(QueryParameters, "Role", value);
			}
		}

		public string OwnerAccount
		{
			get
			{
				return _ownerAccount;
			}
			set	
			{
				_ownerAccount = value;
				DictionaryUtil.Add(QueryParameters, "OwnerAccount", value);
			}
		}

        public override UpdatePipelineResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return UpdatePipelineResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}