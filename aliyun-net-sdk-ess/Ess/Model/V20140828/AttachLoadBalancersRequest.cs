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
    public class AttachLoadBalancersRequest : RpcAcsRequest<AttachLoadBalancersResponse>
    {
        public AttachLoadBalancersRequest()
            : base("Ess", "2014-08-28", "AttachLoadBalancers", "ess", "openAPI")
        {
        }

		private List<string> loadBalancers;

		private string resourceOwnerAccount;

		private string scalingGroupId;

		private string action;

		private bool? forceAttach;

		private long? ownerId;

		private string accessKeyId;

		public List<string> LoadBalancers
		{
			get
			{
				return loadBalancers;
			}

			set
			{
				loadBalancers = value;
				for (int i = 0; i < loadBalancers.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"LoadBalancer." + (i + 1) , loadBalancers[i]);
				}
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

		public bool? ForceAttach
		{
			get
			{
				return forceAttach;
			}
			set	
			{
				forceAttach = value;
				DictionaryUtil.Add(QueryParameters, "ForceAttach", value.ToString());
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

        public override AttachLoadBalancersResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return AttachLoadBalancersResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}