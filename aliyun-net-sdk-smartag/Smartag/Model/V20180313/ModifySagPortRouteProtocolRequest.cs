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
    public class ModifySagPortRouteProtocolRequest : RpcAcsRequest<ModifySagPortRouteProtocolResponse>
    {
        public ModifySagPortRouteProtocolRequest()
            : base("Smartag", "2018-03-13", "ModifySagPortRouteProtocol", "smartag", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
        }

		private long? resourceOwnerId;

		private string remoteIp;

		private string vlan;

		private string remoteAs;

		private string routeProtocol;

		private string resourceOwnerAccount;

		private string ownerAccount;

		private long? ownerId;

		private string smartAGId;

		private string smartAGSn;

		private string portName;

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

		public string RemoteIp
		{
			get
			{
				return remoteIp;
			}
			set	
			{
				remoteIp = value;
				DictionaryUtil.Add(QueryParameters, "RemoteIp", value);
			}
		}

		public string Vlan
		{
			get
			{
				return vlan;
			}
			set	
			{
				vlan = value;
				DictionaryUtil.Add(QueryParameters, "Vlan", value);
			}
		}

		public string RemoteAs
		{
			get
			{
				return remoteAs;
			}
			set	
			{
				remoteAs = value;
				DictionaryUtil.Add(QueryParameters, "RemoteAs", value);
			}
		}

		public string RouteProtocol
		{
			get
			{
				return routeProtocol;
			}
			set	
			{
				routeProtocol = value;
				DictionaryUtil.Add(QueryParameters, "RouteProtocol", value);
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

		public string PortName
		{
			get
			{
				return portName;
			}
			set	
			{
				portName = value;
				DictionaryUtil.Add(QueryParameters, "PortName", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override ModifySagPortRouteProtocolResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ModifySagPortRouteProtocolResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
