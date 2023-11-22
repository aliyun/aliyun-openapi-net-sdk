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

		private string archVersion;

		private long? resourceOwnerId;

		private string resourceGroupId;

		private string logSpec;

		private string securityToken;

		private int? tsdbNum;

		private string primaryVSwitchId;

		private int? solrNum;

		private string instanceStorage;

		private long? ownerId;

		private int? lindormNum;

		private string vSwitchId;

		private int? streamNum;

		private int? logSingleStorage;

		private string zoneId;

		private string arbiterZoneId;

		private string pricingCycle;

		private string multiZoneCombination;

		private string tsdbSpec;

		private string primaryZoneId;

		private string filestoreSpec;

		private string duration;

		private string diskCategory;

		private string lindormSpec;

		private int? coldStorage;

		private int? logNum;

		private string standbyVSwitchId;

		private string solrSpec;

		private string logDiskCategory;

		private int? coreSingleStorage;

		private string standbyZoneId;

		private string resourceOwnerAccount;

		private string ownerAccount;

		private string instanceAlias;

		private int? filestoreNum;

		private string streamSpec;

		private string coreSpec;

		private string vPCId;

		private string payType;

		private string arbiterVSwitchId;

		public string ArchVersion
		{
			get
			{
				return archVersion;
			}
			set	
			{
				archVersion = value;
				DictionaryUtil.Add(QueryParameters, "ArchVersion", value);
			}
		}

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

		public string LogSpec
		{
			get
			{
				return logSpec;
			}
			set	
			{
				logSpec = value;
				DictionaryUtil.Add(QueryParameters, "LogSpec", value);
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

		public string PrimaryVSwitchId
		{
			get
			{
				return primaryVSwitchId;
			}
			set	
			{
				primaryVSwitchId = value;
				DictionaryUtil.Add(QueryParameters, "PrimaryVSwitchId", value);
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

		public int? StreamNum
		{
			get
			{
				return streamNum;
			}
			set	
			{
				streamNum = value;
				DictionaryUtil.Add(QueryParameters, "StreamNum", value.ToString());
			}
		}

		public int? LogSingleStorage
		{
			get
			{
				return logSingleStorage;
			}
			set	
			{
				logSingleStorage = value;
				DictionaryUtil.Add(QueryParameters, "LogSingleStorage", value.ToString());
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

		public string ArbiterZoneId
		{
			get
			{
				return arbiterZoneId;
			}
			set	
			{
				arbiterZoneId = value;
				DictionaryUtil.Add(QueryParameters, "ArbiterZoneId", value);
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

		public string MultiZoneCombination
		{
			get
			{
				return multiZoneCombination;
			}
			set	
			{
				multiZoneCombination = value;
				DictionaryUtil.Add(QueryParameters, "MultiZoneCombination", value);
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

		public string PrimaryZoneId
		{
			get
			{
				return primaryZoneId;
			}
			set	
			{
				primaryZoneId = value;
				DictionaryUtil.Add(QueryParameters, "PrimaryZoneId", value);
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

		public int? LogNum
		{
			get
			{
				return logNum;
			}
			set	
			{
				logNum = value;
				DictionaryUtil.Add(QueryParameters, "LogNum", value.ToString());
			}
		}

		public string StandbyVSwitchId
		{
			get
			{
				return standbyVSwitchId;
			}
			set	
			{
				standbyVSwitchId = value;
				DictionaryUtil.Add(QueryParameters, "StandbyVSwitchId", value);
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

		public string LogDiskCategory
		{
			get
			{
				return logDiskCategory;
			}
			set	
			{
				logDiskCategory = value;
				DictionaryUtil.Add(QueryParameters, "LogDiskCategory", value);
			}
		}

		public int? CoreSingleStorage
		{
			get
			{
				return coreSingleStorage;
			}
			set	
			{
				coreSingleStorage = value;
				DictionaryUtil.Add(QueryParameters, "CoreSingleStorage", value.ToString());
			}
		}

		public string StandbyZoneId
		{
			get
			{
				return standbyZoneId;
			}
			set	
			{
				standbyZoneId = value;
				DictionaryUtil.Add(QueryParameters, "StandbyZoneId", value);
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

		public string StreamSpec
		{
			get
			{
				return streamSpec;
			}
			set	
			{
				streamSpec = value;
				DictionaryUtil.Add(QueryParameters, "StreamSpec", value);
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

		public string ArbiterVSwitchId
		{
			get
			{
				return arbiterVSwitchId;
			}
			set	
			{
				arbiterVSwitchId = value;
				DictionaryUtil.Add(QueryParameters, "ArbiterVSwitchId", value);
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
