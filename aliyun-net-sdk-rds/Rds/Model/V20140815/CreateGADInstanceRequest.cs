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
using Newtonsoft.Json;

using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.Rds;
using Aliyun.Acs.Rds.Transform;
using Aliyun.Acs.Rds.Transform.V20140815;

namespace Aliyun.Acs.Rds.Model.V20140815
{
    public class CreateGADInstanceRequest : RpcAcsRequest<CreateGADInstanceResponse>
    {
        public CreateGADInstanceRequest()
            : base("Rds", "2014-08-15", "CreateGADInstance")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Rds.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Rds.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string description;

		private string centralRdsDtsAdminAccount;

		private string centralRegionId;

		private string resourceGroupId;

		private List<string> tags = new List<string>(){ };

		private List<long?> unitNodes = new List<long?>(){ };

		private string dBList;

		private string centralDBInstanceId;

		private string centralRdsDtsAdminPassword;

		[JsonProperty(PropertyName = "Description")]
		public string Description
		{
			get
			{
				return description;
			}
			set	
			{
				description = value;
				DictionaryUtil.Add(QueryParameters, "Description", value);
			}
		}

		[JsonProperty(PropertyName = "CentralRdsDtsAdminAccount")]
		public string CentralRdsDtsAdminAccount
		{
			get
			{
				return centralRdsDtsAdminAccount;
			}
			set	
			{
				centralRdsDtsAdminAccount = value;
				DictionaryUtil.Add(QueryParameters, "CentralRdsDtsAdminAccount", value);
			}
		}

		[JsonProperty(PropertyName = "CentralRegionId")]
		public string CentralRegionId
		{
			get
			{
				return centralRegionId;
			}
			set	
			{
				centralRegionId = value;
				DictionaryUtil.Add(QueryParameters, "CentralRegionId", value);
			}
		}

		[JsonProperty(PropertyName = "ResourceGroupId")]
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

		[JsonProperty(PropertyName = "Tag")]
		public List<string> Tags
		{
			get
			{
				return tags;
			}

			set
			{
				tags = value;
				if(tags != null)
				{
					for (int depth1 = 0; depth1 < tags.Count; depth1++)
					{
						DictionaryUtil.Add(QueryParameters,"Tag." + (depth1 + 1), tags[depth1]);
						DictionaryUtil.Add(QueryParameters,"Tag." + (depth1 + 1), tags[depth1]);
					}
				}
			}
		}

		[JsonProperty(PropertyName = "UnitNode")]
		public List<long?> UnitNodes
		{
			get
			{
				return unitNodes;
			}

			set
			{
				unitNodes = value;
				if(unitNodes != null)
				{
					for (int depth1 = 0; depth1 < unitNodes.Count; depth1++)
					{
						DictionaryUtil.Add(QueryParameters,"UnitNode." + (depth1 + 1), unitNodes[depth1]);
						DictionaryUtil.Add(QueryParameters,"UnitNode." + (depth1 + 1), unitNodes[depth1]);
						DictionaryUtil.Add(QueryParameters,"UnitNode." + (depth1 + 1), unitNodes[depth1]);
						DictionaryUtil.Add(QueryParameters,"UnitNode." + (depth1 + 1), unitNodes[depth1]);
						DictionaryUtil.Add(QueryParameters,"UnitNode." + (depth1 + 1), unitNodes[depth1]);
						DictionaryUtil.Add(QueryParameters,"UnitNode." + (depth1 + 1), unitNodes[depth1]);
						DictionaryUtil.Add(QueryParameters,"UnitNode." + (depth1 + 1), unitNodes[depth1]);
						DictionaryUtil.Add(QueryParameters,"UnitNode." + (depth1 + 1), unitNodes[depth1]);
						DictionaryUtil.Add(QueryParameters,"UnitNode." + (depth1 + 1), unitNodes[depth1]);
						DictionaryUtil.Add(QueryParameters,"UnitNode." + (depth1 + 1), unitNodes[depth1]);
						DictionaryUtil.Add(QueryParameters,"UnitNode." + (depth1 + 1), unitNodes[depth1]);
						DictionaryUtil.Add(QueryParameters,"UnitNode." + (depth1 + 1), unitNodes[depth1]);
						DictionaryUtil.Add(QueryParameters,"UnitNode." + (depth1 + 1), unitNodes[depth1]);
						DictionaryUtil.Add(QueryParameters,"UnitNode." + (depth1 + 1), unitNodes[depth1]);
						DictionaryUtil.Add(QueryParameters,"UnitNode." + (depth1 + 1), unitNodes[depth1]);
						DictionaryUtil.Add(QueryParameters,"UnitNode." + (depth1 + 1), unitNodes[depth1]);
					}
				}
			}
		}

		[JsonProperty(PropertyName = "DBList")]
		public string DBList
		{
			get
			{
				return dBList;
			}
			set	
			{
				dBList = value;
				DictionaryUtil.Add(QueryParameters, "DBList", value);
			}
		}

		[JsonProperty(PropertyName = "CentralDBInstanceId")]
		public string CentralDBInstanceId
		{
			get
			{
				return centralDBInstanceId;
			}
			set	
			{
				centralDBInstanceId = value;
				DictionaryUtil.Add(QueryParameters, "CentralDBInstanceId", value);
			}
		}

		[JsonProperty(PropertyName = "CentralRdsDtsAdminPassword")]
		public string CentralRdsDtsAdminPassword
		{
			get
			{
				return centralRdsDtsAdminPassword;
			}
			set	
			{
				centralRdsDtsAdminPassword = value;
				DictionaryUtil.Add(QueryParameters, "CentralRdsDtsAdminPassword", value);
			}
		}

		public class Tag
		{

			private string value_;

			private string key;

			[JsonProperty(PropertyName = "Value")]
			public string Value_
			{
				get
				{
					return value_;
				}
				set	
				{
					value_ = value;
				}
			}

			[JsonProperty(PropertyName = "Key")]
			public string Key
			{
				get
				{
					return key;
				}
				set	
				{
					key = value;
				}
			}
		}

		public class UnitNode
		{

			private long? dBInstanceStorage;

			private string zoneIDSlave1;

			private string zoneIDSlave2;

			private string engineVersion;

			private string dbInstanceClass;

			private string securityIPList;

			private string vSwitchID;

			private string regionID;

			private string engine;

			private string dtsInstanceClass;

			private string vpcID;

			private string zoneID;

			private string dBInstanceDescription;

			private string dBInstanceStorageType;

			private string payType;

			private string dtsConflict;

			[JsonProperty(PropertyName = "DBInstanceStorage")]
			public long? DBInstanceStorage
			{
				get
				{
					return dBInstanceStorage;
				}
				set	
				{
					dBInstanceStorage = value;
				}
			}

			[JsonProperty(PropertyName = "ZoneIDSlave1")]
			public string ZoneIDSlave1
			{
				get
				{
					return zoneIDSlave1;
				}
				set	
				{
					zoneIDSlave1 = value;
				}
			}

			[JsonProperty(PropertyName = "ZoneIDSlave2")]
			public string ZoneIDSlave2
			{
				get
				{
					return zoneIDSlave2;
				}
				set	
				{
					zoneIDSlave2 = value;
				}
			}

			[JsonProperty(PropertyName = "EngineVersion")]
			public string EngineVersion
			{
				get
				{
					return engineVersion;
				}
				set	
				{
					engineVersion = value;
				}
			}

			[JsonProperty(PropertyName = "DbInstanceClass")]
			public string DbInstanceClass
			{
				get
				{
					return dbInstanceClass;
				}
				set	
				{
					dbInstanceClass = value;
				}
			}

			[JsonProperty(PropertyName = "SecurityIPList")]
			public string SecurityIPList
			{
				get
				{
					return securityIPList;
				}
				set	
				{
					securityIPList = value;
				}
			}

			[JsonProperty(PropertyName = "VSwitchID")]
			public string VSwitchID
			{
				get
				{
					return vSwitchID;
				}
				set	
				{
					vSwitchID = value;
				}
			}

			[JsonProperty(PropertyName = "RegionID")]
			public string RegionID
			{
				get
				{
					return regionID;
				}
				set	
				{
					regionID = value;
				}
			}

			[JsonProperty(PropertyName = "Engine")]
			public string Engine
			{
				get
				{
					return engine;
				}
				set	
				{
					engine = value;
				}
			}

			[JsonProperty(PropertyName = "DtsInstanceClass")]
			public string DtsInstanceClass
			{
				get
				{
					return dtsInstanceClass;
				}
				set	
				{
					dtsInstanceClass = value;
				}
			}

			[JsonProperty(PropertyName = "VpcID")]
			public string VpcID
			{
				get
				{
					return vpcID;
				}
				set	
				{
					vpcID = value;
				}
			}

			[JsonProperty(PropertyName = "ZoneID")]
			public string ZoneID
			{
				get
				{
					return zoneID;
				}
				set	
				{
					zoneID = value;
				}
			}

			[JsonProperty(PropertyName = "DBInstanceDescription")]
			public string DBInstanceDescription
			{
				get
				{
					return dBInstanceDescription;
				}
				set	
				{
					dBInstanceDescription = value;
				}
			}

			[JsonProperty(PropertyName = "DBInstanceStorageType")]
			public string DBInstanceStorageType
			{
				get
				{
					return dBInstanceStorageType;
				}
				set	
				{
					dBInstanceStorageType = value;
				}
			}

			[JsonProperty(PropertyName = "PayType")]
			public string PayType
			{
				get
				{
					return payType;
				}
				set	
				{
					payType = value;
				}
			}

			[JsonProperty(PropertyName = "DtsConflict")]
			public string DtsConflict
			{
				get
				{
					return dtsConflict;
				}
				set	
				{
					dtsConflict = value;
				}
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override CreateGADInstanceResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateGADInstanceResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
