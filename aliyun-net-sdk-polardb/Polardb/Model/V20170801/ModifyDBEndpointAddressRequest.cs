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
using Aliyun.Acs.polardb.Transform;
using Aliyun.Acs.polardb.Transform.V20170801;

namespace Aliyun.Acs.polardb.Model.V20170801
{
    public class ModifyDBEndpointAddressRequest : RpcAcsRequest<ModifyDBEndpointAddressResponse>
    {
        public ModifyDBEndpointAddressRequest()
            : base("polardb", "2017-08-01", "ModifyDBEndpointAddress", "polardb", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.polardb.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.polardb.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private long? resourceOwnerId;

		private string connectionStringPrefix;

		private string dBEndpointId;

		private string privateZoneName;

		private string privateZoneAddressPrefix;

		private string resourceOwnerAccount;

		private string dBClusterId;

		private string ownerAccount;

		private long? ownerId;

		private string port;

		private string netType;

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

		public string ConnectionStringPrefix
		{
			get
			{
				return connectionStringPrefix;
			}
			set	
			{
				connectionStringPrefix = value;
				DictionaryUtil.Add(QueryParameters, "ConnectionStringPrefix", value);
			}
		}

		public string DBEndpointId
		{
			get
			{
				return dBEndpointId;
			}
			set	
			{
				dBEndpointId = value;
				DictionaryUtil.Add(QueryParameters, "DBEndpointId", value);
			}
		}

		public string PrivateZoneName
		{
			get
			{
				return privateZoneName;
			}
			set	
			{
				privateZoneName = value;
				DictionaryUtil.Add(QueryParameters, "PrivateZoneName", value);
			}
		}

		public string PrivateZoneAddressPrefix
		{
			get
			{
				return privateZoneAddressPrefix;
			}
			set	
			{
				privateZoneAddressPrefix = value;
				DictionaryUtil.Add(QueryParameters, "PrivateZoneAddressPrefix", value);
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

		public string DBClusterId
		{
			get
			{
				return dBClusterId;
			}
			set	
			{
				dBClusterId = value;
				DictionaryUtil.Add(QueryParameters, "DBClusterId", value);
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

		public string Port
		{
			get
			{
				return port;
			}
			set	
			{
				port = value;
				DictionaryUtil.Add(QueryParameters, "Port", value);
			}
		}

		public string NetType
		{
			get
			{
				return netType;
			}
			set	
			{
				netType = value;
				DictionaryUtil.Add(QueryParameters, "NetType", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override ModifyDBEndpointAddressResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ModifyDBEndpointAddressResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
