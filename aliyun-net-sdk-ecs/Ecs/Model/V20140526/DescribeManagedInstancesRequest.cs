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
using Aliyun.Acs.Ecs.Transform;
using Aliyun.Acs.Ecs.Transform.V20140526;

namespace Aliyun.Acs.Ecs.Model.V20140526
{
    public class DescribeManagedInstancesRequest : RpcAcsRequest<DescribeManagedInstancesResponse>
    {
        public DescribeManagedInstancesRequest()
            : base("Ecs", "2014-05-26", "DescribeManagedInstances", "ecs", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Ecs.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Ecs.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private long? resourceOwnerId;

		private long? pageNumber;

		private long? pageSize;

		private string resourceOwnerAccount;

		private string ownerAccount;

		private string osType;

		private long? ownerId;

		private string instanceName;

		private List<string> instanceIds = new List<string>(){ };

		private string instanceIp;

		private string activationId;

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

		public long? PageNumber
		{
			get
			{
				return pageNumber;
			}
			set	
			{
				pageNumber = value;
				DictionaryUtil.Add(QueryParameters, "PageNumber", value.ToString());
			}
		}

		public long? PageSize
		{
			get
			{
				return pageSize;
			}
			set	
			{
				pageSize = value;
				DictionaryUtil.Add(QueryParameters, "PageSize", value.ToString());
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

		public string OsType
		{
			get
			{
				return osType;
			}
			set	
			{
				osType = value;
				DictionaryUtil.Add(QueryParameters, "OsType", value);
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

		public string InstanceName
		{
			get
			{
				return instanceName;
			}
			set	
			{
				instanceName = value;
				DictionaryUtil.Add(QueryParameters, "InstanceName", value);
			}
		}

		public List<string> InstanceIds
		{
			get
			{
				return instanceIds;
			}

			set
			{
				instanceIds = value;
				for (int i = 0; i < instanceIds.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"InstanceId." + (i + 1) , instanceIds[i]);
				}
			}
		}

		public string InstanceIp
		{
			get
			{
				return instanceIp;
			}
			set	
			{
				instanceIp = value;
				DictionaryUtil.Add(QueryParameters, "InstanceIp", value);
			}
		}

		public string ActivationId
		{
			get
			{
				return activationId;
			}
			set	
			{
				activationId = value;
				DictionaryUtil.Add(QueryParameters, "ActivationId", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override DescribeManagedInstancesResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DescribeManagedInstancesResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
