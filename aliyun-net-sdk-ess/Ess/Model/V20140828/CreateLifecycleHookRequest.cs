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
    public class CreateLifecycleHookRequest : RpcAcsRequest<CreateLifecycleHookResponse>
    {
        public CreateLifecycleHookRequest()
            : base("Ess", "2014-08-28", "CreateLifecycleHook", "ess", "openAPI")
        {
        }

		private string defaultResult;

		private string resourceOwnerAccount;

		private int? heartbeatTimeout;

		private string scalingGroupId;

		private string ownerAccount;

		private string notificationMetadata;

		private long? ownerId;

		private string lifecycleTransition;

		private string accessKeyId;

		private string lifecycleHookName;

		private string notificationArn;

		private string action;

		private List<LifecycleHook> lifecycleHooks;

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

		public List<LifecycleHook> LifecycleHooks
		{
			get
			{
				return lifecycleHooks;
			}

			set
			{
				lifecycleHooks = value;
				for (int i = 0; i < lifecycleHooks.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"LifecycleHook." + (i + 1) + ".LifecycleHookName", lifecycleHooks[i].LifecycleHookName);
					DictionaryUtil.Add(QueryParameters,"LifecycleHook." + (i + 1) + ".LifecycleTransition", lifecycleHooks[i].LifecycleTransition);
					DictionaryUtil.Add(QueryParameters,"LifecycleHook." + (i + 1) + ".DefaultResult", lifecycleHooks[i].DefaultResult);
					DictionaryUtil.Add(QueryParameters,"LifecycleHook." + (i + 1) + ".HeartbeatTimeout", lifecycleHooks[i].HeartbeatTimeout);
					DictionaryUtil.Add(QueryParameters,"LifecycleHook." + (i + 1) + ".NotificationMetadata", lifecycleHooks[i].NotificationMetadata);
					DictionaryUtil.Add(QueryParameters,"LifecycleHook." + (i + 1) + ".NotificationArn", lifecycleHooks[i].NotificationArn);
				}
			}
		}

		public class LifecycleHook
		{

			private string lifecycleHookName;

			private string lifecycleTransition;

			private string defaultResult;

			private int? heartbeatTimeout;

			private string notificationMetadata;

			private string notificationArn;

			public string LifecycleHookName
			{
				get
				{
					return lifecycleHookName;
				}
				set	
				{
					lifecycleHookName = value;
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
				}
			}

			public string DefaultResult
			{
				get
				{
					return defaultResult;
				}
				set	
				{
					defaultResult = value;
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
				}
			}
		}

        public override CreateLifecycleHookResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return CreateLifecycleHookResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}