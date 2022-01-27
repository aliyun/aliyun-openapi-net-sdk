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
using Aliyun.Acs.Rds.Transform;
using Aliyun.Acs.Rds.Transform.V20140815;

namespace Aliyun.Acs.Rds.Model.V20140815
{
    public class ModifyDBProxyEndpointAddressRequest : RpcAcsRequest<ModifyDBProxyEndpointAddressResponse>
    {
        public ModifyDBProxyEndpointAddressRequest()
            : base("Rds", "2014-08-15", "ModifyDBProxyEndpointAddress", "rds", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Rds.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Rds.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private long? resourceOwnerId;

		private string dBProxyConnectStringNetType;

		private string dBInstanceId;

		private string dBProxyNewConnectStringPort;

		private string resourceOwnerAccount;

		private long? ownerId;

		private string dBProxyEndpointId;

		private string dBProxyNewConnectString;

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

		public string DBProxyConnectStringNetType
		{
			get
			{
				return dBProxyConnectStringNetType;
			}
			set	
			{
				dBProxyConnectStringNetType = value;
				DictionaryUtil.Add(QueryParameters, "DBProxyConnectStringNetType", value);
			}
		}

		public string DBInstanceId
		{
			get
			{
				return dBInstanceId;
			}
			set	
			{
				dBInstanceId = value;
				DictionaryUtil.Add(QueryParameters, "DBInstanceId", value);
			}
		}

		public string DBProxyNewConnectStringPort
		{
			get
			{
				return dBProxyNewConnectStringPort;
			}
			set	
			{
				dBProxyNewConnectStringPort = value;
				DictionaryUtil.Add(QueryParameters, "DBProxyNewConnectStringPort", value);
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

		public string DBProxyEndpointId
		{
			get
			{
				return dBProxyEndpointId;
			}
			set	
			{
				dBProxyEndpointId = value;
				DictionaryUtil.Add(QueryParameters, "DBProxyEndpointId", value);
			}
		}

		public string DBProxyNewConnectString
		{
			get
			{
				return dBProxyNewConnectString;
			}
			set	
			{
				dBProxyNewConnectString = value;
				DictionaryUtil.Add(QueryParameters, "DBProxyNewConnectString", value);
			}
		}

        public override ModifyDBProxyEndpointAddressResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ModifyDBProxyEndpointAddressResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
