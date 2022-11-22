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
    public class UpgradeLindormInstanceRequest : RpcAcsRequest<UpgradeLindormInstanceResponse>
    {
        public UpgradeLindormInstanceRequest()
            : base("hitsdb", "2020-06-15", "UpgradeLindormInstance", "hitsdb", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.hitsdb.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.hitsdb.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private long? resourceOwnerId;

		private int? phoenixCoreNum;

		private string phoenixCoreSpec;

		private string upgradeType;

		private string tsdbSpec;

		private string filestoreSpec;

		private string logSpec;

		private string securityToken;

		private int? tsdbNum;

		private string lindormSpec;

		private int? solrNum;

		private int? coldStorage;

		private int? logNum;

		private string solrSpec;

		private int? coreSingleStorage;

		private string resourceOwnerAccount;

		private string ownerAccount;

		private int? filestoreNum;

		private long? ownerId;

		private int? lindormNum;

		private int? ltsCoreNum;

		private string instanceId;

		private string ltsCoreSpec;

		private int? clusterStorage;

		private int? logSingleStorage;

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

		public int? PhoenixCoreNum
		{
			get
			{
				return phoenixCoreNum;
			}
			set	
			{
				phoenixCoreNum = value;
				DictionaryUtil.Add(QueryParameters, "PhoenixCoreNum", value.ToString());
			}
		}

		public string PhoenixCoreSpec
		{
			get
			{
				return phoenixCoreSpec;
			}
			set	
			{
				phoenixCoreSpec = value;
				DictionaryUtil.Add(QueryParameters, "PhoenixCoreSpec", value);
			}
		}

		public string UpgradeType
		{
			get
			{
				return upgradeType;
			}
			set	
			{
				upgradeType = value;
				DictionaryUtil.Add(QueryParameters, "UpgradeType", value);
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

		public int? LtsCoreNum
		{
			get
			{
				return ltsCoreNum;
			}
			set	
			{
				ltsCoreNum = value;
				DictionaryUtil.Add(QueryParameters, "LtsCoreNum", value.ToString());
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

		public string LtsCoreSpec
		{
			get
			{
				return ltsCoreSpec;
			}
			set	
			{
				ltsCoreSpec = value;
				DictionaryUtil.Add(QueryParameters, "LtsCoreSpec", value);
			}
		}

		public int? ClusterStorage
		{
			get
			{
				return clusterStorage;
			}
			set	
			{
				clusterStorage = value;
				DictionaryUtil.Add(QueryParameters, "ClusterStorage", value.ToString());
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

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override UpgradeLindormInstanceResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return UpgradeLindormInstanceResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
