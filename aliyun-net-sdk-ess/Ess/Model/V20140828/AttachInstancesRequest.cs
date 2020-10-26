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
    public class AttachInstancesRequest : RpcAcsRequest<AttachInstancesResponse>
    {
        public AttachInstancesRequest()
            : base("Ess", "2014-08-28", "AttachInstances", "ess", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private int? loadBalancerWeight6;

		private int? loadBalancerWeight11;

		private int? loadBalancerWeight7;

		private int? loadBalancerWeight12;

		private long? resourceOwnerId;

		private int? loadBalancerWeight8;

		private int? loadBalancerWeight9;

		private int? loadBalancerWeight10;

		private int? loadBalancerWeight2;

		private int? loadBalancerWeight15;

		private int? loadBalancerWeight3;

		private int? loadBalancerWeight16;

		private int? loadBalancerWeight4;

		private int? loadBalancerWeight13;

		private int? loadBalancerWeight5;

		private int? loadBalancerWeight14;

		private int? loadBalancerWeight1;

		private string instanceId1;

		private int? loadBalancerWeight20;

		private string instanceId3;

		private string instanceId2;

		private string instanceId5;

		private string instanceId4;

		private string instanceId7;

		private string instanceId6;

		private string instanceId9;

		private string instanceId8;

		private long? ownerId;

		private int? loadBalancerWeight19;

		private int? loadBalancerWeight17;

		private int? loadBalancerWeight18;

		private string instanceId10;

		private string instanceId12;

		private string instanceId11;

		private string scalingGroupId;

		private string instanceId20;

		private string resourceOwnerAccount;

		private string ownerAccount;

		private bool? entrusted;

		private string instanceId18;

		private string instanceId17;

		private string instanceId19;

		private string instanceId14;

		private string instanceId13;

		private string instanceId16;

		private string instanceId15;

		public int? LoadBalancerWeight6
		{
			get
			{
				return loadBalancerWeight6;
			}
			set	
			{
				loadBalancerWeight6 = value;
				DictionaryUtil.Add(QueryParameters, "LoadBalancerWeight.6", value.ToString());
			}
		}

		public int? LoadBalancerWeight11
		{
			get
			{
				return loadBalancerWeight11;
			}
			set	
			{
				loadBalancerWeight11 = value;
				DictionaryUtil.Add(QueryParameters, "LoadBalancerWeight.11", value.ToString());
			}
		}

		public int? LoadBalancerWeight7
		{
			get
			{
				return loadBalancerWeight7;
			}
			set	
			{
				loadBalancerWeight7 = value;
				DictionaryUtil.Add(QueryParameters, "LoadBalancerWeight.7", value.ToString());
			}
		}

		public int? LoadBalancerWeight12
		{
			get
			{
				return loadBalancerWeight12;
			}
			set	
			{
				loadBalancerWeight12 = value;
				DictionaryUtil.Add(QueryParameters, "LoadBalancerWeight.12", value.ToString());
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

		public int? LoadBalancerWeight8
		{
			get
			{
				return loadBalancerWeight8;
			}
			set	
			{
				loadBalancerWeight8 = value;
				DictionaryUtil.Add(QueryParameters, "LoadBalancerWeight.8", value.ToString());
			}
		}

		public int? LoadBalancerWeight9
		{
			get
			{
				return loadBalancerWeight9;
			}
			set	
			{
				loadBalancerWeight9 = value;
				DictionaryUtil.Add(QueryParameters, "LoadBalancerWeight.9", value.ToString());
			}
		}

		public int? LoadBalancerWeight10
		{
			get
			{
				return loadBalancerWeight10;
			}
			set	
			{
				loadBalancerWeight10 = value;
				DictionaryUtil.Add(QueryParameters, "LoadBalancerWeight.10", value.ToString());
			}
		}

		public int? LoadBalancerWeight2
		{
			get
			{
				return loadBalancerWeight2;
			}
			set	
			{
				loadBalancerWeight2 = value;
				DictionaryUtil.Add(QueryParameters, "LoadBalancerWeight.2", value.ToString());
			}
		}

		public int? LoadBalancerWeight15
		{
			get
			{
				return loadBalancerWeight15;
			}
			set	
			{
				loadBalancerWeight15 = value;
				DictionaryUtil.Add(QueryParameters, "LoadBalancerWeight.15", value.ToString());
			}
		}

		public int? LoadBalancerWeight3
		{
			get
			{
				return loadBalancerWeight3;
			}
			set	
			{
				loadBalancerWeight3 = value;
				DictionaryUtil.Add(QueryParameters, "LoadBalancerWeight.3", value.ToString());
			}
		}

		public int? LoadBalancerWeight16
		{
			get
			{
				return loadBalancerWeight16;
			}
			set	
			{
				loadBalancerWeight16 = value;
				DictionaryUtil.Add(QueryParameters, "LoadBalancerWeight.16", value.ToString());
			}
		}

		public int? LoadBalancerWeight4
		{
			get
			{
				return loadBalancerWeight4;
			}
			set	
			{
				loadBalancerWeight4 = value;
				DictionaryUtil.Add(QueryParameters, "LoadBalancerWeight.4", value.ToString());
			}
		}

		public int? LoadBalancerWeight13
		{
			get
			{
				return loadBalancerWeight13;
			}
			set	
			{
				loadBalancerWeight13 = value;
				DictionaryUtil.Add(QueryParameters, "LoadBalancerWeight.13", value.ToString());
			}
		}

		public int? LoadBalancerWeight5
		{
			get
			{
				return loadBalancerWeight5;
			}
			set	
			{
				loadBalancerWeight5 = value;
				DictionaryUtil.Add(QueryParameters, "LoadBalancerWeight.5", value.ToString());
			}
		}

		public int? LoadBalancerWeight14
		{
			get
			{
				return loadBalancerWeight14;
			}
			set	
			{
				loadBalancerWeight14 = value;
				DictionaryUtil.Add(QueryParameters, "LoadBalancerWeight.14", value.ToString());
			}
		}

		public int? LoadBalancerWeight1
		{
			get
			{
				return loadBalancerWeight1;
			}
			set	
			{
				loadBalancerWeight1 = value;
				DictionaryUtil.Add(QueryParameters, "LoadBalancerWeight.1", value.ToString());
			}
		}

		public string InstanceId1
		{
			get
			{
				return instanceId1;
			}
			set	
			{
				instanceId1 = value;
				DictionaryUtil.Add(QueryParameters, "InstanceId.1", value);
			}
		}

		public int? LoadBalancerWeight20
		{
			get
			{
				return loadBalancerWeight20;
			}
			set	
			{
				loadBalancerWeight20 = value;
				DictionaryUtil.Add(QueryParameters, "LoadBalancerWeight.20", value.ToString());
			}
		}

		public string InstanceId3
		{
			get
			{
				return instanceId3;
			}
			set	
			{
				instanceId3 = value;
				DictionaryUtil.Add(QueryParameters, "InstanceId.3", value);
			}
		}

		public string InstanceId2
		{
			get
			{
				return instanceId2;
			}
			set	
			{
				instanceId2 = value;
				DictionaryUtil.Add(QueryParameters, "InstanceId.2", value);
			}
		}

		public string InstanceId5
		{
			get
			{
				return instanceId5;
			}
			set	
			{
				instanceId5 = value;
				DictionaryUtil.Add(QueryParameters, "InstanceId.5", value);
			}
		}

		public string InstanceId4
		{
			get
			{
				return instanceId4;
			}
			set	
			{
				instanceId4 = value;
				DictionaryUtil.Add(QueryParameters, "InstanceId.4", value);
			}
		}

		public string InstanceId7
		{
			get
			{
				return instanceId7;
			}
			set	
			{
				instanceId7 = value;
				DictionaryUtil.Add(QueryParameters, "InstanceId.7", value);
			}
		}

		public string InstanceId6
		{
			get
			{
				return instanceId6;
			}
			set	
			{
				instanceId6 = value;
				DictionaryUtil.Add(QueryParameters, "InstanceId.6", value);
			}
		}

		public string InstanceId9
		{
			get
			{
				return instanceId9;
			}
			set	
			{
				instanceId9 = value;
				DictionaryUtil.Add(QueryParameters, "InstanceId.9", value);
			}
		}

		public string InstanceId8
		{
			get
			{
				return instanceId8;
			}
			set	
			{
				instanceId8 = value;
				DictionaryUtil.Add(QueryParameters, "InstanceId.8", value);
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

		public int? LoadBalancerWeight19
		{
			get
			{
				return loadBalancerWeight19;
			}
			set	
			{
				loadBalancerWeight19 = value;
				DictionaryUtil.Add(QueryParameters, "LoadBalancerWeight.19", value.ToString());
			}
		}

		public int? LoadBalancerWeight17
		{
			get
			{
				return loadBalancerWeight17;
			}
			set	
			{
				loadBalancerWeight17 = value;
				DictionaryUtil.Add(QueryParameters, "LoadBalancerWeight.17", value.ToString());
			}
		}

		public int? LoadBalancerWeight18
		{
			get
			{
				return loadBalancerWeight18;
			}
			set	
			{
				loadBalancerWeight18 = value;
				DictionaryUtil.Add(QueryParameters, "LoadBalancerWeight.18", value.ToString());
			}
		}

		public string InstanceId10
		{
			get
			{
				return instanceId10;
			}
			set	
			{
				instanceId10 = value;
				DictionaryUtil.Add(QueryParameters, "InstanceId.10", value);
			}
		}

		public string InstanceId12
		{
			get
			{
				return instanceId12;
			}
			set	
			{
				instanceId12 = value;
				DictionaryUtil.Add(QueryParameters, "InstanceId.12", value);
			}
		}

		public string InstanceId11
		{
			get
			{
				return instanceId11;
			}
			set	
			{
				instanceId11 = value;
				DictionaryUtil.Add(QueryParameters, "InstanceId.11", value);
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

		public string InstanceId20
		{
			get
			{
				return instanceId20;
			}
			set	
			{
				instanceId20 = value;
				DictionaryUtil.Add(QueryParameters, "InstanceId.20", value);
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

		public bool? Entrusted
		{
			get
			{
				return entrusted;
			}
			set	
			{
				entrusted = value;
				DictionaryUtil.Add(QueryParameters, "Entrusted", value.ToString());
			}
		}

		public string InstanceId18
		{
			get
			{
				return instanceId18;
			}
			set	
			{
				instanceId18 = value;
				DictionaryUtil.Add(QueryParameters, "InstanceId.18", value);
			}
		}

		public string InstanceId17
		{
			get
			{
				return instanceId17;
			}
			set	
			{
				instanceId17 = value;
				DictionaryUtil.Add(QueryParameters, "InstanceId.17", value);
			}
		}

		public string InstanceId19
		{
			get
			{
				return instanceId19;
			}
			set	
			{
				instanceId19 = value;
				DictionaryUtil.Add(QueryParameters, "InstanceId.19", value);
			}
		}

		public string InstanceId14
		{
			get
			{
				return instanceId14;
			}
			set	
			{
				instanceId14 = value;
				DictionaryUtil.Add(QueryParameters, "InstanceId.14", value);
			}
		}

		public string InstanceId13
		{
			get
			{
				return instanceId13;
			}
			set	
			{
				instanceId13 = value;
				DictionaryUtil.Add(QueryParameters, "InstanceId.13", value);
			}
		}

		public string InstanceId16
		{
			get
			{
				return instanceId16;
			}
			set	
			{
				instanceId16 = value;
				DictionaryUtil.Add(QueryParameters, "InstanceId.16", value);
			}
		}

		public string InstanceId15
		{
			get
			{
				return instanceId15;
			}
			set	
			{
				instanceId15 = value;
				DictionaryUtil.Add(QueryParameters, "InstanceId.15", value);
			}
		}

        public override AttachInstancesResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return AttachInstancesResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
