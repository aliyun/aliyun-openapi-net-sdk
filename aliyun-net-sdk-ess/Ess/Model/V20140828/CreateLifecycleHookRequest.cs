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
using Aliyun.Acs.Ess.Transform;
using Aliyun.Acs.Ess.Transform.V20140828;

namespace Aliyun.Acs.Ess.Model.V20140828
{
    public class CreateLifecycleHookRequest : RpcAcsRequest<CreateLifecycleHookResponse>
    {
        public CreateLifecycleHookRequest()
            : base("Ess", "2014-08-28", "CreateLifecycleHook", "ess", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string defaultResult;

		private int? heartbeatTimeout;

		private string scalingGroupId;

		private string lifecycleTransition;

		private string lifecycleHookName;

		private string notificationArn;

		private string resourceOwnerAccount;

		private string ownerAccount;

		private string notificationMetadata;

		private long? ownerId;

		public string DefaultResult
		{
			get
			{
				return defaultResult;
			}
			set	
			{
				defaultResult = value;
				DictionaryUtil.Add(QueryParameters, "DefaultResult", value);
			}
		}

		public int? HeartbeatTimeout
		{
			get
			{
				return heartbeatTimeout;
			}
			set	
			{
				heartbeatTimeout = value;
				DictionaryUtil.Add(QueryParameters, "HeartbeatTimeout", value.ToString());
			}
		}

		public string ScalingGroupId
		{
			get
			{
				return scalingGroupId;
			}
			set	
			{
				scalingGroupId = value;
				DictionaryUtil.Add(QueryParameters, "ScalingGroupId", value);
			}
		}

		public string LifecycleTransition
		{
			get
			{
				return lifecycleTransition;
			}
			set	
			{
				lifecycleTransition = value;
				DictionaryUtil.Add(QueryParameters, "LifecycleTransition", value);
			}
		}

		public string LifecycleHookName
		{
			get
			{
				return lifecycleHookName;
			}
			set	
			{
				lifecycleHookName = value;
				DictionaryUtil.Add(QueryParameters, "LifecycleHookName", value);
			}
		}

		public string NotificationArn
		{
			get
			{
				return notificationArn;
			}
			set	
			{
				notificationArn = value;
				DictionaryUtil.Add(QueryParameters, "NotificationArn", value);
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

		public string NotificationMetadata
		{
			get
			{
				return notificationMetadata;
			}
			set	
			{
				notificationMetadata = value;
				DictionaryUtil.Add(QueryParameters, "NotificationMetadata", value);
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

        public override CreateLifecycleHookResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateLifecycleHookResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
