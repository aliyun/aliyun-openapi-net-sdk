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
using Aliyun.Acs.Vpc.Transform;
using Aliyun.Acs.Vpc.Transform.V20160428;

namespace Aliyun.Acs.Vpc.Model.V20160428
{
    public class ModifyExpressCloudConnectionAttributeRequest : RpcAcsRequest<ModifyExpressCloudConnectionAttributeResponse>
    {
        public ModifyExpressCloudConnectionAttributeRequest()
            : base("Vpc", "2016-04-28", "ModifyExpressCloudConnectionAttribute", "vpc", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Vpc.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Vpc.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private long? resourceOwnerId;

		private string description;

		private string eccId;

		private string resourceOwnerAccount;

		private string ownerAccount;

		private string ceIp;

		private string bgpAs;

		private string peIp;

		private long? ownerId;

		private string name;

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

		public string Description
		{
			get
			{
				return description;
			}
			set	
			{
				description = value;
				DictionaryUtil.Add(QueryParameters, "Description", value);
			}
		}

		public string EccId
		{
			get
			{
				return eccId;
			}
			set	
			{
				eccId = value;
				DictionaryUtil.Add(QueryParameters, "EccId", value);
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

		public string CeIp
		{
			get
			{
				return ceIp;
			}
			set	
			{
				ceIp = value;
				DictionaryUtil.Add(QueryParameters, "CeIp", value);
			}
		}

		public string BgpAs
		{
			get
			{
				return bgpAs;
			}
			set	
			{
				bgpAs = value;
				DictionaryUtil.Add(QueryParameters, "BgpAs", value);
			}
		}

		public string PeIp
		{
			get
			{
				return peIp;
			}
			set	
			{
				peIp = value;
				DictionaryUtil.Add(QueryParameters, "PeIp", value);
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

        public override ModifyExpressCloudConnectionAttributeResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ModifyExpressCloudConnectionAttributeResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
