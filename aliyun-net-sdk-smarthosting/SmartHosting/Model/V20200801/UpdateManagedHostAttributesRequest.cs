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
using Aliyun.Acs.SmartHosting.Transform;
using Aliyun.Acs.SmartHosting.Transform.V20200801;

namespace Aliyun.Acs.SmartHosting.Model.V20200801
{
    public class UpdateManagedHostAttributesRequest : RpcAcsRequest<UpdateManagedHostAttributesResponse>
    {
        public UpdateManagedHostAttributesRequest()
            : base("SmartHosting", "2020-08-01", "UpdateManagedHostAttributes", "smarthosting", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private long? resourceOwnerId;

		private string mode;

		private string resourceOwnerAccount;

		private string ownerAccount;

		private string managedHostId;

		private long? ownerId;

		private string managedHostName;

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

		public string Mode
		{
			get
			{
				return mode;
			}
			set	
			{
				mode = value;
				DictionaryUtil.Add(QueryParameters, "Mode", value);
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

		public string ManagedHostId
		{
			get
			{
				return managedHostId;
			}
			set	
			{
				managedHostId = value;
				DictionaryUtil.Add(QueryParameters, "ManagedHostId", value);
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

		public string ManagedHostName
		{
			get
			{
				return managedHostName;
			}
			set	
			{
				managedHostName = value;
				DictionaryUtil.Add(QueryParameters, "ManagedHostName", value);
			}
		}

        public override UpdateManagedHostAttributesResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return UpdateManagedHostAttributesResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
