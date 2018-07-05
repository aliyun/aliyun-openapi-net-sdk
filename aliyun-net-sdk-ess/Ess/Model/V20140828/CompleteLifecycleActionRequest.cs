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
using Aliyun.Acs.Ess.Transform;
using Aliyun.Acs.Ess.Transform.V20140828;
using System.Collections.Generic;

namespace Aliyun.Acs.Ess.Model.V20140828
{
    public class CompleteLifecycleActionRequest : RpcAcsRequest<CompleteLifecycleActionResponse>
    {
        public CompleteLifecycleActionRequest()
            : base("Ess", "2014-08-28", "CompleteLifecycleAction", "ESS", "openAPI")
        {
        }

		private string lifecycleActionToken;

		private string resourceOwnerAccount;

		private string lifecycleHookId;

		private string ownerAccount;

		private string action;

		private long? ownerId;

		private string lifecycleActionResult;

		private string accessKeyId;

		public string LifecycleActionToken
		{
			get
			{
				return lifecycleActionToken;
			}
			set	
			{
				lifecycleActionToken = value;
				DictionaryUtil.Add(QueryParameters, "LifecycleActionToken", value);
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

		public string LifecycleHookId
		{
			get
			{
				return lifecycleHookId;
			}
			set	
			{
				lifecycleHookId = value;
				DictionaryUtil.Add(QueryParameters, "LifecycleHookId", value);
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

		public string LifecycleActionResult
		{
			get
			{
				return lifecycleActionResult;
			}
			set	
			{
				lifecycleActionResult = value;
				DictionaryUtil.Add(QueryParameters, "LifecycleActionResult", value);
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

        public override CompleteLifecycleActionResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return CompleteLifecycleActionResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}