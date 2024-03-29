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
    public class EvaluateRegionResourceRequest : RpcAcsRequest<EvaluateRegionResourceResponse>
    {
        public EvaluateRegionResourceRequest()
            : base("polardb", "2017-08-01", "EvaluateRegionResource", "polardb", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.polardb.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.polardb.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private long? resourceOwnerId;

		private string dBInstanceConnType;

		private string resourceGroupId;

		private string dBNodeClass;

		private string dispenseMode;

		private string resourceOwnerAccount;

		private string ownerAccount;

		private long? ownerId;

		private string needMaxScaleLink;

		private string dBType;

		private string dBVersion;

		private string subDomain;

		private string zoneId;

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

		public string DBInstanceConnType
		{
			get
			{
				return dBInstanceConnType;
			}
			set	
			{
				dBInstanceConnType = value;
				DictionaryUtil.Add(QueryParameters, "DBInstanceConnType", value);
			}
		}

		public string ResourceGroupId
		{
			get
			{
				return resourceGroupId;
			}
			set	
			{
				resourceGroupId = value;
				DictionaryUtil.Add(QueryParameters, "ResourceGroupId", value);
			}
		}

		public string DBNodeClass
		{
			get
			{
				return dBNodeClass;
			}
			set	
			{
				dBNodeClass = value;
				DictionaryUtil.Add(QueryParameters, "DBNodeClass", value);
			}
		}

		public string DispenseMode
		{
			get
			{
				return dispenseMode;
			}
			set	
			{
				dispenseMode = value;
				DictionaryUtil.Add(QueryParameters, "DispenseMode", value);
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

		public string NeedMaxScaleLink
		{
			get
			{
				return needMaxScaleLink;
			}
			set	
			{
				needMaxScaleLink = value;
				DictionaryUtil.Add(QueryParameters, "NeedMaxScaleLink", value);
			}
		}

		public string DBType
		{
			get
			{
				return dBType;
			}
			set	
			{
				dBType = value;
				DictionaryUtil.Add(QueryParameters, "DBType", value);
			}
		}

		public string DBVersion
		{
			get
			{
				return dBVersion;
			}
			set	
			{
				dBVersion = value;
				DictionaryUtil.Add(QueryParameters, "DBVersion", value);
			}
		}

		public string SubDomain
		{
			get
			{
				return subDomain;
			}
			set	
			{
				subDomain = value;
				DictionaryUtil.Add(QueryParameters, "SubDomain", value);
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

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override EvaluateRegionResourceResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return EvaluateRegionResourceResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
