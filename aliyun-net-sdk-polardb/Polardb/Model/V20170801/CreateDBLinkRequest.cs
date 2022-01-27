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
    public class CreateDBLinkRequest : RpcAcsRequest<CreateDBLinkResponse>
    {
        public CreateDBLinkRequest()
            : base("polardb", "2017-08-01", "CreateDBLink", "polardb", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.polardb.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.polardb.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private long? resourceOwnerId;

		private string sourceDBName;

		private string clientToken;

		private string targetDBName;

		private string targetIp;

		private string dBLinkName;

		private string targetPort;

		private string resourceOwnerAccount;

		private string targetDBInstanceName;

		private string dBClusterId;

		private string ownerAccount;

		private string targetDBPasswd;

		private long? ownerId;

		private string targetDBAccount;

		private string vpcId;

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

		public string SourceDBName
		{
			get
			{
				return sourceDBName;
			}
			set	
			{
				sourceDBName = value;
				DictionaryUtil.Add(QueryParameters, "SourceDBName", value);
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

		public string TargetDBName
		{
			get
			{
				return targetDBName;
			}
			set	
			{
				targetDBName = value;
				DictionaryUtil.Add(QueryParameters, "TargetDBName", value);
			}
		}

		public string TargetIp
		{
			get
			{
				return targetIp;
			}
			set	
			{
				targetIp = value;
				DictionaryUtil.Add(QueryParameters, "TargetIp", value);
			}
		}

		public string DBLinkName
		{
			get
			{
				return dBLinkName;
			}
			set	
			{
				dBLinkName = value;
				DictionaryUtil.Add(QueryParameters, "DBLinkName", value);
			}
		}

		public string TargetPort
		{
			get
			{
				return targetPort;
			}
			set	
			{
				targetPort = value;
				DictionaryUtil.Add(QueryParameters, "TargetPort", value);
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

		public string TargetDBInstanceName
		{
			get
			{
				return targetDBInstanceName;
			}
			set	
			{
				targetDBInstanceName = value;
				DictionaryUtil.Add(QueryParameters, "TargetDBInstanceName", value);
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

		public string TargetDBPasswd
		{
			get
			{
				return targetDBPasswd;
			}
			set	
			{
				targetDBPasswd = value;
				DictionaryUtil.Add(QueryParameters, "TargetDBPasswd", value);
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

		public string TargetDBAccount
		{
			get
			{
				return targetDBAccount;
			}
			set	
			{
				targetDBAccount = value;
				DictionaryUtil.Add(QueryParameters, "TargetDBAccount", value);
			}
		}

		public string VpcId
		{
			get
			{
				return vpcId;
			}
			set	
			{
				vpcId = value;
				DictionaryUtil.Add(QueryParameters, "VpcId", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override CreateDBLinkResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateDBLinkResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
