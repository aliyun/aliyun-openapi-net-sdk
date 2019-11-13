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
using Aliyun.Acs.adb.Transform;
using Aliyun.Acs.adb.Transform.V20190315;

namespace Aliyun.Acs.adb.Model.V20190315
{
    public class CreateDBClusterRequest : RpcAcsRequest<CreateDBClusterResponse>
    {
        public CreateDBClusterRequest()
            : base("adb", "2019-03-15", "CreateDBCluster", "ads", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
        }

		private long? resourceOwnerId;

		private string dBClusterDescription;

		private string clientToken;

		private string dBClusterCategory;

		private string dBClusterNetworkType;

		private string period;

		private string resourceOwnerAccount;

		private string ownerAccount;

		private string dBClusterVersion;

		private string dBClusterClass;

		private long? ownerId;

		private string dBNodeGroupCount;

		private string usedTime;

		private string vSwitchId;

		private string dBNodeStorage;

		private string vPCId;

		private string zoneId;

		private string payType;

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

		public string DBClusterDescription
		{
			get
			{
				return dBClusterDescription;
			}
			set	
			{
				dBClusterDescription = value;
				DictionaryUtil.Add(QueryParameters, "DBClusterDescription", value);
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

		public string DBClusterCategory
		{
			get
			{
				return dBClusterCategory;
			}
			set	
			{
				dBClusterCategory = value;
				DictionaryUtil.Add(QueryParameters, "DBClusterCategory", value);
			}
		}

		public string DBClusterNetworkType
		{
			get
			{
				return dBClusterNetworkType;
			}
			set	
			{
				dBClusterNetworkType = value;
				DictionaryUtil.Add(QueryParameters, "DBClusterNetworkType", value);
			}
		}

		public string Period
		{
			get
			{
				return period;
			}
			set	
			{
				period = value;
				DictionaryUtil.Add(QueryParameters, "Period", value);
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

		public string DBClusterVersion
		{
			get
			{
				return dBClusterVersion;
			}
			set	
			{
				dBClusterVersion = value;
				DictionaryUtil.Add(QueryParameters, "DBClusterVersion", value);
			}
		}

		public string DBClusterClass
		{
			get
			{
				return dBClusterClass;
			}
			set	
			{
				dBClusterClass = value;
				DictionaryUtil.Add(QueryParameters, "DBClusterClass", value);
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

		public string DBNodeGroupCount
		{
			get
			{
				return dBNodeGroupCount;
			}
			set	
			{
				dBNodeGroupCount = value;
				DictionaryUtil.Add(QueryParameters, "DBNodeGroupCount", value);
			}
		}

		public string UsedTime
		{
			get
			{
				return usedTime;
			}
			set	
			{
				usedTime = value;
				DictionaryUtil.Add(QueryParameters, "UsedTime", value);
			}
		}

		public string VSwitchId
		{
			get
			{
				return vSwitchId;
			}
			set	
			{
				vSwitchId = value;
				DictionaryUtil.Add(QueryParameters, "VSwitchId", value);
			}
		}

		public string DBNodeStorage
		{
			get
			{
				return dBNodeStorage;
			}
			set	
			{
				dBNodeStorage = value;
				DictionaryUtil.Add(QueryParameters, "DBNodeStorage", value);
			}
		}

		public string VPCId
		{
			get
			{
				return vPCId;
			}
			set	
			{
				vPCId = value;
				DictionaryUtil.Add(QueryParameters, "VPCId", value);
			}
		}

		public string ZoneId
		{
			get
			{
				return zoneId;
			}
			set	
			{
				zoneId = value;
				DictionaryUtil.Add(QueryParameters, "ZoneId", value);
			}
		}

		public string PayType
		{
			get
			{
				return payType;
			}
			set	
			{
				payType = value;
				DictionaryUtil.Add(QueryParameters, "PayType", value);
			}
		}

        public override CreateDBClusterResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateDBClusterResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
