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
using Aliyun.Acs.Rds.Transform;
using Aliyun.Acs.Rds.Transform.V20140815;

namespace Aliyun.Acs.Rds.Model.V20140815
{
    public class CreateGadInstanceMemberRequest : RpcAcsRequest<CreateGadInstanceMemberResponse>
    {
        public CreateGadInstanceMemberRequest()
            : base("Rds", "2014-08-15", "CreateGadInstanceMember", "rds", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Rds.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Rds.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string dBList;

		private string centralDBInstanceId;

		private string centralRdsDtsAdminPassword;

		private string centralRdsDtsAdminAccount;

		private string centralRegionId;

		private string gadInstanceId;

		private List<UnitNode> unitNodes = new List<UnitNode>(){ };

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

		public string GadInstanceId
		{
			get
			{
				return gadInstanceId;
			}
			set	
			{
				gadInstanceId = value;
				DictionaryUtil.Add(QueryParameters, "GadInstanceId", value);
			}
		}

		public List<UnitNode> UnitNodes
		{
			get
			{
				return unitNodes;
			}

			set
			{
				unitNodes = value;
				for (int i = 0; i < unitNodes.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"UnitNode." + (i + 1) + ".DBInstanceStorage", unitNodes[i].DBInstanceStorage);
					DictionaryUtil.Add(QueryParameters,"UnitNode." + (i + 1) + ".ZoneIDSlave1", unitNodes[i].ZoneIDSlave1);
					DictionaryUtil.Add(QueryParameters,"UnitNode." + (i + 1) + ".ZoneIDSlave2", unitNodes[i].ZoneIDSlave2);
					DictionaryUtil.Add(QueryParameters,"UnitNode." + (i + 1) + ".EngineVersion", unitNodes[i].EngineVersion);
					DictionaryUtil.Add(QueryParameters,"UnitNode." + (i + 1) + ".DbInstanceClass", unitNodes[i].DbInstanceClass);
					DictionaryUtil.Add(QueryParameters,"UnitNode." + (i + 1) + ".VSwitchID", unitNodes[i].VSwitchID);
					DictionaryUtil.Add(QueryParameters,"UnitNode." + (i + 1) + ".SecurityIPList", unitNodes[i].SecurityIPList);
					DictionaryUtil.Add(QueryParameters,"UnitNode." + (i + 1) + ".RegionID", unitNodes[i].RegionID);
					DictionaryUtil.Add(QueryParameters,"UnitNode." + (i + 1) + ".Engine", unitNodes[i].Engine);
					DictionaryUtil.Add(QueryParameters,"UnitNode." + (i + 1) + ".DtsInstanceClass", unitNodes[i].DtsInstanceClass);
					DictionaryUtil.Add(QueryParameters,"UnitNode." + (i + 1) + ".VpcID", unitNodes[i].VpcID);
					DictionaryUtil.Add(QueryParameters,"UnitNode." + (i + 1) + ".ZoneID", unitNodes[i].ZoneID);
					DictionaryUtil.Add(QueryParameters,"UnitNode." + (i + 1) + ".DBInstanceDescription", unitNodes[i].DBInstanceDescription);
					DictionaryUtil.Add(QueryParameters,"UnitNode." + (i + 1) + ".DtsConflict", unitNodes[i].DtsConflict);
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

			private string vSwitchID;

			private string securityIPList;

			private string regionID;

			private string engine;

			private string dtsInstanceClass;

			private string vpcID;

			private string zoneID;

			private string dBInstanceDescription;

			private string dtsConflict;

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

        public override CreateGadInstanceMemberResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateGadInstanceMemberResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
