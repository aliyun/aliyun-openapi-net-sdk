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
using Aliyun.Acs.Slb.Transform;
using Aliyun.Acs.Slb.Transform.V20140515;

namespace Aliyun.Acs.Slb.Model.V20140515
{
    public class SetTLSCipherPolicyAttributeRequest : RpcAcsRequest<SetTLSCipherPolicyAttributeResponse>
    {
        public SetTLSCipherPolicyAttributeRequest()
            : base("Slb", "2014-05-15", "SetTLSCipherPolicyAttribute", "slb", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Slb.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Slb.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string access_key_id;

		private long? resourceOwnerId;

		private string tLSCipherPolicyId;

		private List<string> cipherss = new List<string>(){ };

		private List<string> tLSVersionss = new List<string>(){ };

		private string resourceOwnerAccount;

		private string ownerAccount;

		private long? ownerId;

		private string name;

		public string Access_key_id
		{
			get
			{
				return access_key_id;
			}
			set	
			{
				access_key_id = value;
				DictionaryUtil.Add(QueryParameters, "access_key_id", value);
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

		public string TLSCipherPolicyId
		{
			get
			{
				return tLSCipherPolicyId;
			}
			set	
			{
				tLSCipherPolicyId = value;
				DictionaryUtil.Add(QueryParameters, "TLSCipherPolicyId", value);
			}
		}

		public List<string> Cipherss
		{
			get
			{
				return cipherss;
			}

			set
			{
				cipherss = value;
				for (int i = 0; i < cipherss.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"Ciphers." + (i + 1) , cipherss[i]);
				}
			}
		}

		public List<string> TLSVersionss
		{
			get
			{
				return tLSVersionss;
			}

			set
			{
				tLSVersionss = value;
				for (int i = 0; i < tLSVersionss.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"TLSVersions." + (i + 1) , tLSVersionss[i]);
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

        public override SetTLSCipherPolicyAttributeResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return SetTLSCipherPolicyAttributeResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
