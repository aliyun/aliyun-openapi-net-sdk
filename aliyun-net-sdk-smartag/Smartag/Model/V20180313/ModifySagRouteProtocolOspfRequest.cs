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
using Aliyun.Acs.Smartag.Transform;
using Aliyun.Acs.Smartag.Transform.V20180313;

namespace Aliyun.Acs.Smartag.Model.V20180313
{
    public class ModifySagRouteProtocolOspfRequest : RpcAcsRequest<ModifySagRouteProtocolOspfResponse>
    {
        public ModifySagRouteProtocolOspfRequest()
            : base("Smartag", "2018-03-13", "ModifySagRouteProtocolOspf", "smartag", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
        }

		private long? resourceOwnerId;

		private string authenticationType;

		private string password;

		private int? areaId;

		private string resourceOwnerAccount;

		private string ownerAccount;

		private long? ownerId;

		private int? md5KeyId;

		private string routerId;

		private string smartAGId;

		private string smartAGSn;

		private int? deadTime;

		private string md5Key;

		private int? helloTime;

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

		public string AuthenticationType
		{
			get
			{
				return authenticationType;
			}
			set	
			{
				authenticationType = value;
				DictionaryUtil.Add(QueryParameters, "AuthenticationType", value);
			}
		}

		public string Password
		{
			get
			{
				return password;
			}
			set	
			{
				password = value;
				DictionaryUtil.Add(QueryParameters, "Password", value);
			}
		}

		public int? AreaId
		{
			get
			{
				return areaId;
			}
			set	
			{
				areaId = value;
				DictionaryUtil.Add(QueryParameters, "AreaId", value.ToString());
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

		public int? Md5KeyId
		{
			get
			{
				return md5KeyId;
			}
			set	
			{
				md5KeyId = value;
				DictionaryUtil.Add(QueryParameters, "Md5KeyId", value.ToString());
			}
		}

		public string RouterId
		{
			get
			{
				return routerId;
			}
			set	
			{
				routerId = value;
				DictionaryUtil.Add(QueryParameters, "RouterId", value);
			}
		}

		public string SmartAGId
		{
			get
			{
				return smartAGId;
			}
			set	
			{
				smartAGId = value;
				DictionaryUtil.Add(QueryParameters, "SmartAGId", value);
			}
		}

		public string SmartAGSn
		{
			get
			{
				return smartAGSn;
			}
			set	
			{
				smartAGSn = value;
				DictionaryUtil.Add(QueryParameters, "SmartAGSn", value);
			}
		}

		public int? DeadTime
		{
			get
			{
				return deadTime;
			}
			set	
			{
				deadTime = value;
				DictionaryUtil.Add(QueryParameters, "DeadTime", value.ToString());
			}
		}

		public string Md5Key
		{
			get
			{
				return md5Key;
			}
			set	
			{
				md5Key = value;
				DictionaryUtil.Add(QueryParameters, "Md5Key", value);
			}
		}

		public int? HelloTime
		{
			get
			{
				return helloTime;
			}
			set	
			{
				helloTime = value;
				DictionaryUtil.Add(QueryParameters, "HelloTime", value.ToString());
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override ModifySagRouteProtocolOspfResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ModifySagRouteProtocolOspfResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
