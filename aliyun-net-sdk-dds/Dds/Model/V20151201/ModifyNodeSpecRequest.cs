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
using Aliyun.Acs.Dds;
using Aliyun.Acs.Dds.Transform;
using Aliyun.Acs.Dds.Transform.V20151201;

namespace Aliyun.Acs.Dds.Model.V20151201
{
    public class ModifyNodeSpecRequest : RpcAcsRequest<ModifyNodeSpecResponse>
    {
        public ModifyNodeSpecRequest()
            : base("Dds", "2015-12-01", "ModifyNodeSpec")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Dds.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Dds.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private long? resourceOwnerId;

		private string clientToken;

		private int? readonlyReplicas;

		private string nodeClass;

		private string securityToken;

		private string effectiveTime;

		private string dBInstanceId;

		private string nodeId;

		private bool? autoPay;

		private string fromApp;

		private string resourceOwnerAccount;

		private int? nodeStorage;

		private string ownerAccount;

		private long? ownerId;

		private string orderType;

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

		public string ClientToken
		{
			get
			{
				return clientToken;
			}
			set	
			{
				clientToken = value;
				DictionaryUtil.Add(QueryParameters, "ClientToken", value);
			}
		}

		public int? ReadonlyReplicas
		{
			get
			{
				return readonlyReplicas;
			}
			set	
			{
				readonlyReplicas = value;
				DictionaryUtil.Add(QueryParameters, "ReadonlyReplicas", value.ToString());
			}
		}

		public string NodeClass
		{
			get
			{
				return nodeClass;
			}
			set	
			{
				nodeClass = value;
				DictionaryUtil.Add(QueryParameters, "NodeClass", value);
			}
		}

		public string SecurityToken
		{
			get
			{
				return securityToken;
			}
			set	
			{
				securityToken = value;
				DictionaryUtil.Add(QueryParameters, "SecurityToken", value);
			}
		}

		public string EffectiveTime
		{
			get
			{
				return effectiveTime;
			}
			set	
			{
				effectiveTime = value;
				DictionaryUtil.Add(QueryParameters, "EffectiveTime", value);
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

		public string NodeId
		{
			get
			{
				return nodeId;
			}
			set	
			{
				nodeId = value;
				DictionaryUtil.Add(QueryParameters, "NodeId", value);
			}
		}

		public bool? AutoPay
		{
			get
			{
				return autoPay;
			}
			set	
			{
				autoPay = value;
				DictionaryUtil.Add(QueryParameters, "AutoPay", value.ToString());
			}
		}

		public string FromApp
		{
			get
			{
				return fromApp;
			}
			set	
			{
				fromApp = value;
				DictionaryUtil.Add(QueryParameters, "FromApp", value);
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

		public int? NodeStorage
		{
			get
			{
				return nodeStorage;
			}
			set	
			{
				nodeStorage = value;
				DictionaryUtil.Add(QueryParameters, "NodeStorage", value.ToString());
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

		public string OrderType
		{
			get
			{
				return orderType;
			}
			set	
			{
				orderType = value;
				DictionaryUtil.Add(QueryParameters, "OrderType", value);
			}
		}

        public override ModifyNodeSpecResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ModifyNodeSpecResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
