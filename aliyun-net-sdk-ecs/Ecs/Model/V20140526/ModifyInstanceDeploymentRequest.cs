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
using Newtonsoft.Json;

using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.Ecs.Transform;
using Aliyun.Acs.Ecs.Transform.V20140526;

namespace Aliyun.Acs.Ecs.Model.V20140526
{
    public class ModifyInstanceDeploymentRequest : RpcAcsRequest<ModifyInstanceDeploymentResponse>
    {
        public ModifyInstanceDeploymentRequest()
            : base("Ecs", "2014-05-26", "ModifyInstanceDeployment", "ecs", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private long? resourceOwnerId;

		private int? deploymentSetGroupNo;

		private string dedicatedHostClusterId;

		private string instanceType;

		private string deploymentSetId;

		private string resourceOwnerAccount;

		private string ownerAccount;

		private string tenancy;

		private string dedicatedHostId;

		private long? ownerId;

		private string instanceId;

		private bool? force;

		private string migrationType;

		private string affinity;

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

		public int? DeploymentSetGroupNo
		{
			get
			{
				return deploymentSetGroupNo;
			}
			set	
			{
				deploymentSetGroupNo = value;
				DictionaryUtil.Add(QueryParameters, "DeploymentSetGroupNo", value.ToString());
			}
		}

		public string DedicatedHostClusterId
		{
			get
			{
				return dedicatedHostClusterId;
			}
			set	
			{
				dedicatedHostClusterId = value;
				DictionaryUtil.Add(QueryParameters, "DedicatedHostClusterId", value);
			}
		}

		public string InstanceType
		{
			get
			{
				return instanceType;
			}
			set	
			{
				instanceType = value;
				DictionaryUtil.Add(QueryParameters, "InstanceType", value);
			}
		}

		public string DeploymentSetId
		{
			get
			{
				return deploymentSetId;
			}
			set	
			{
				deploymentSetId = value;
				DictionaryUtil.Add(QueryParameters, "DeploymentSetId", value);
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

		public string Tenancy
		{
			get
			{
				return tenancy;
			}
			set	
			{
				tenancy = value;
				DictionaryUtil.Add(QueryParameters, "Tenancy", value);
			}
		}

		public string DedicatedHostId
		{
			get
			{
				return dedicatedHostId;
			}
			set	
			{
				dedicatedHostId = value;
				DictionaryUtil.Add(QueryParameters, "DedicatedHostId", value);
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

		public string InstanceId
		{
			get
			{
				return instanceId;
			}
			set	
			{
				instanceId = value;
				DictionaryUtil.Add(QueryParameters, "InstanceId", value);
			}
		}

		public bool? Force
		{
			get
			{
				return force;
			}
			set	
			{
				force = value;
				DictionaryUtil.Add(QueryParameters, "Force", value.ToString());
			}
		}

		public string MigrationType
		{
			get
			{
				return migrationType;
			}
			set	
			{
				migrationType = value;
				DictionaryUtil.Add(QueryParameters, "MigrationType", value);
			}
		}

		public string Affinity
		{
			get
			{
				return affinity;
			}
			set	
			{
				affinity = value;
				DictionaryUtil.Add(QueryParameters, "Affinity", value);
			}
		}

        public override ModifyInstanceDeploymentResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ModifyInstanceDeploymentResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
