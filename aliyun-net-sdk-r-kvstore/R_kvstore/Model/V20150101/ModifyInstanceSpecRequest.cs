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
using Aliyun.Acs.R_kvstore.Transform;
using Aliyun.Acs.R_kvstore.Transform.V20150101;

namespace Aliyun.Acs.R_kvstore.Model.V20150101
{
    public class ModifyInstanceSpecRequest : RpcAcsRequest<ModifyInstanceSpecResponse>
    {
        public ModifyInstanceSpecRequest()
            : base("R-kvstore", "2015-01-01", "ModifyInstanceSpec", "redisa", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.R_kvstore.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.R_kvstore.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private long? resourceOwnerId;

		private string nodeType;

		private string clientToken;

		private int? slaveReadOnlyCount;

		private string couponNo;

		private int? storage;

		private string instanceClass;

		private string storageType;

		private string securityToken;

		private string effectiveTime;

		private string sourceBiz;

		private string businessInfo;

		private int? shardCount;

		private bool? autoPay;

		private string majorVersion;

		private string resourceOwnerAccount;

		private string ownerAccount;

		private long? ownerId;

		private bool? forceTrans;

		private string instanceId;

		private int? readOnlyCount;

		private bool? forceUpgrade;

		private int? slaveReplicaCount;

		private string orderType;

		private int? replicaCount;

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

		public string NodeType
		{
			get
			{
				return nodeType;
			}
			set	
			{
				nodeType = value;
				DictionaryUtil.Add(QueryParameters, "NodeType", value);
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

		public int? SlaveReadOnlyCount
		{
			get
			{
				return slaveReadOnlyCount;
			}
			set	
			{
				slaveReadOnlyCount = value;
				DictionaryUtil.Add(QueryParameters, "SlaveReadOnlyCount", value.ToString());
			}
		}

		public string CouponNo
		{
			get
			{
				return couponNo;
			}
			set	
			{
				couponNo = value;
				DictionaryUtil.Add(QueryParameters, "CouponNo", value);
			}
		}

		public int? Storage
		{
			get
			{
				return storage;
			}
			set	
			{
				storage = value;
				DictionaryUtil.Add(QueryParameters, "Storage", value.ToString());
			}
		}

		public string InstanceClass
		{
			get
			{
				return instanceClass;
			}
			set	
			{
				instanceClass = value;
				DictionaryUtil.Add(QueryParameters, "InstanceClass", value);
			}
		}

		public string StorageType
		{
			get
			{
				return storageType;
			}
			set	
			{
				storageType = value;
				DictionaryUtil.Add(QueryParameters, "StorageType", value);
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

		public string SourceBiz
		{
			get
			{
				return sourceBiz;
			}
			set	
			{
				sourceBiz = value;
				DictionaryUtil.Add(QueryParameters, "SourceBiz", value);
			}
		}

		public string BusinessInfo
		{
			get
			{
				return businessInfo;
			}
			set	
			{
				businessInfo = value;
				DictionaryUtil.Add(QueryParameters, "BusinessInfo", value);
			}
		}

		public int? ShardCount
		{
			get
			{
				return shardCount;
			}
			set	
			{
				shardCount = value;
				DictionaryUtil.Add(QueryParameters, "ShardCount", value.ToString());
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

		public string MajorVersion
		{
			get
			{
				return majorVersion;
			}
			set	
			{
				majorVersion = value;
				DictionaryUtil.Add(QueryParameters, "MajorVersion", value);
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

		public bool? ForceTrans
		{
			get
			{
				return forceTrans;
			}
			set	
			{
				forceTrans = value;
				DictionaryUtil.Add(QueryParameters, "ForceTrans", value.ToString());
			}
		}

		public string InstanceId
		{
			get
			{
				return instanceId;
			}
			set	
			{
				instanceId = value;
				DictionaryUtil.Add(QueryParameters, "InstanceId", value);
			}
		}

		public int? ReadOnlyCount
		{
			get
			{
				return readOnlyCount;
			}
			set	
			{
				readOnlyCount = value;
				DictionaryUtil.Add(QueryParameters, "ReadOnlyCount", value.ToString());
			}
		}

		public bool? ForceUpgrade
		{
			get
			{
				return forceUpgrade;
			}
			set	
			{
				forceUpgrade = value;
				DictionaryUtil.Add(QueryParameters, "ForceUpgrade", value.ToString());
			}
		}

		public int? SlaveReplicaCount
		{
			get
			{
				return slaveReplicaCount;
			}
			set	
			{
				slaveReplicaCount = value;
				DictionaryUtil.Add(QueryParameters, "SlaveReplicaCount", value.ToString());
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

		public int? ReplicaCount
		{
			get
			{
				return replicaCount;
			}
			set	
			{
				replicaCount = value;
				DictionaryUtil.Add(QueryParameters, "ReplicaCount", value.ToString());
			}
		}

        public override ModifyInstanceSpecResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ModifyInstanceSpecResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
