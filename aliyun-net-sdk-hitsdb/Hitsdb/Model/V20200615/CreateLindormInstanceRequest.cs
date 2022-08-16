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
using Aliyun.Acs.hitsdb.Transform;
using Aliyun.Acs.hitsdb.Transform.V20200615;

namespace Aliyun.Acs.hitsdb.Model.V20200615
{
    public class CreateLindormInstanceRequest : RpcAcsRequest<CreateLindormInstanceResponse>
    {
        public CreateLindormInstanceRequest()
            : base("hitsdb", "2020-06-15", "CreateLindormInstance", "hitsdb", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.hitsdb.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.hitsdb.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private long? resourceOwnerId;

		private string tsdbSpec;

		private string filestoreSpec;

		private string duration;

		private string resourceGroupId;

		private string securityToken;

		private int? tsdbNum;

		private string diskCategory;

		private string lindormSpec;

		private int? solrNum;

		private int? coldStorage;

		private string instanceStorage;

		private string solrSpec;

		private string resourceOwnerAccount;

		private string ownerAccount;

		private string instanceAlias;

		private int? filestoreNum;

		private long? ownerId;

		private int? lindormNum;

		private string coreSpec;

		private string vSwitchId;

		private string vPCId;

		private string zoneId;

		private string payType;

		private string pricingCycle;

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

		public string TsdbSpec
		{
			get
			{
				return tsdbSpec;
			}
			set	
			{
				tsdbSpec = value;
				DictionaryUtil.Add(QueryParameters, "TsdbSpec", value);
			}
		}

		public string FilestoreSpec
		{
			get
			{
				return filestoreSpec;
			}
			set	
			{
				filestoreSpec = value;
				DictionaryUtil.Add(QueryParameters, "FilestoreSpec", value);
			}
		}

		public string Duration
		{
			get
			{
				return duration;
			}
			set	
			{
				duration = value;
				DictionaryUtil.Add(QueryParameters, "Duration", value);
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

		public int? TsdbNum
		{
			get
			{
				return tsdbNum;
			}
			set	
			{
				tsdbNum = value;
				DictionaryUtil.Add(QueryParameters, "TsdbNum", value.ToString());
			}
		}

		public string DiskCategory
		{
			get
			{
				return diskCategory;
			}
			set	
			{
				diskCategory = value;
				DictionaryUtil.Add(QueryParameters, "DiskCategory", value);
			}
		}

		public string LindormSpec
		{
			get
			{
				return lindormSpec;
			}
			set	
			{
				lindormSpec = value;
				DictionaryUtil.Add(QueryParameters, "LindormSpec", value);
			}
		}

		public int? SolrNum
		{
			get
			{
				return solrNum;
			}
			set	
			{
				solrNum = value;
				DictionaryUtil.Add(QueryParameters, "SolrNum", value.ToString());
			}
		}

		public int? ColdStorage
		{
			get
			{
				return coldStorage;
			}
			set	
			{
				coldStorage = value;
				DictionaryUtil.Add(QueryParameters, "ColdStorage", value.ToString());
			}
		}

		public string InstanceStorage
		{
			get
			{
				return instanceStorage;
			}
			set	
			{
				instanceStorage = value;
				DictionaryUtil.Add(QueryParameters, "InstanceStorage", value);
			}
		}

		public string SolrSpec
		{
			get
			{
				return solrSpec;
			}
			set	
			{
				solrSpec = value;
				DictionaryUtil.Add(QueryParameters, "SolrSpec", value);
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

		public string InstanceAlias
		{
			get
			{
				return instanceAlias;
			}
			set	
			{
				instanceAlias = value;
				DictionaryUtil.Add(QueryParameters, "InstanceAlias", value);
			}
		}

		public int? FilestoreNum
		{
			get
			{
				return filestoreNum;
			}
			set	
			{
				filestoreNum = value;
				DictionaryUtil.Add(QueryParameters, "FilestoreNum", value.ToString());
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

		public int? LindormNum
		{
			get
			{
				return lindormNum;
			}
			set	
			{
				lindormNum = value;
				DictionaryUtil.Add(QueryParameters, "LindormNum", value.ToString());
			}
		}

		public string CoreSpec
		{
			get
			{
				return coreSpec;
			}
			set	
			{
				coreSpec = value;
				DictionaryUtil.Add(QueryParameters, "CoreSpec", value);
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

		public string PricingCycle
		{
			get
			{
				return pricingCycle;
			}
			set	
			{
				pricingCycle = value;
				DictionaryUtil.Add(QueryParameters, "PricingCycle", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override CreateLindormInstanceResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateLindormInstanceResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
