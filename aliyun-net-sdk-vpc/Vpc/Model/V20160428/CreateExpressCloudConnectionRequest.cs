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
    public class CreateExpressCloudConnectionRequest : RpcAcsRequest<CreateExpressCloudConnectionResponse>
    {
        public CreateExpressCloudConnectionRequest()
            : base("Vpc", "2016-04-28", "CreateExpressCloudConnection", "vpc", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Vpc.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Vpc.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private long? resourceOwnerId;

		private string portType;

		private string description;

		private string redundantEccId;

		private string peerLocation;

		private string resourceOwnerAccount;

		private int? bandwidth;

		private string ownerAccount;

		private string peerCity;

		private string iDCardNo;

		private long? ownerId;

		private string contactMail;

		private string contactTel;

		private string idcSP;

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

		public string PortType
		{
			get
			{
				return portType;
			}
			set	
			{
				portType = value;
				DictionaryUtil.Add(QueryParameters, "PortType", value);
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

		public string RedundantEccId
		{
			get
			{
				return redundantEccId;
			}
			set	
			{
				redundantEccId = value;
				DictionaryUtil.Add(QueryParameters, "RedundantEccId", value);
			}
		}

		public string PeerLocation
		{
			get
			{
				return peerLocation;
			}
			set	
			{
				peerLocation = value;
				DictionaryUtil.Add(QueryParameters, "PeerLocation", value);
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

		public int? Bandwidth
		{
			get
			{
				return bandwidth;
			}
			set	
			{
				bandwidth = value;
				DictionaryUtil.Add(QueryParameters, "Bandwidth", value.ToString());
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

		public string PeerCity
		{
			get
			{
				return peerCity;
			}
			set	
			{
				peerCity = value;
				DictionaryUtil.Add(QueryParameters, "PeerCity", value);
			}
		}

		public string IDCardNo
		{
			get
			{
				return iDCardNo;
			}
			set	
			{
				iDCardNo = value;
				DictionaryUtil.Add(QueryParameters, "IDCardNo", value);
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

		public string ContactMail
		{
			get
			{
				return contactMail;
			}
			set	
			{
				contactMail = value;
				DictionaryUtil.Add(QueryParameters, "ContactMail", value);
			}
		}

		public string ContactTel
		{
			get
			{
				return contactTel;
			}
			set	
			{
				contactTel = value;
				DictionaryUtil.Add(QueryParameters, "ContactTel", value);
			}
		}

		public string IdcSP
		{
			get
			{
				return idcSP;
			}
			set	
			{
				idcSP = value;
				DictionaryUtil.Add(QueryParameters, "IdcSP", value);
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

        public override CreateExpressCloudConnectionResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateExpressCloudConnectionResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
