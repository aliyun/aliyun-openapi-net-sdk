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
    public class AddMediaWorkflowRequest : RpcAcsRequest<AddMediaWorkflowResponse>
    {
        public AddMediaWorkflowRequest()
            : base("Mts", "2014-06-18", "AddMediaWorkflow", "mts", "openAPI")
        {
        }

		private long? resourceOwnerId;

		private string resourceOwnerAccount;

		private string topology;

		private string ownerAccount;

		private string name;

		private string action;

		private long? ownerId;

		private string accessKeyId;

		private string triggerMode;

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

		public string Topology
		{
			get
			{
				return topology;
			}
			set	
			{
				topology = value;
				DictionaryUtil.Add(QueryParameters, "Topology", value);
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

		public string TriggerMode
		{
			get
			{
				return triggerMode;
			}
			set	
			{
				triggerMode = value;
				DictionaryUtil.Add(QueryParameters, "TriggerMode", value);
			}
		}

        public override AddMediaWorkflowResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return AddMediaWorkflowResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}