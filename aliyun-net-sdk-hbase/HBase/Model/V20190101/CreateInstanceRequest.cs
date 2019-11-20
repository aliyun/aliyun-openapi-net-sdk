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
using Aliyun.Acs.HBase.Transform;
using Aliyun.Acs.HBase.Transform.V20190101;

namespace Aliyun.Acs.HBase.Model.V20190101
{
    public class CreateInstanceRequest : RpcAcsRequest<CreateInstanceResponse>
    {
        public CreateInstanceRequest()
            : base("HBase", "2019-01-01", "CreateInstance", "hbase", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
        }

		private string clusterName;

		private string dbInstanceConnType;

		private string engineVersion;

		private string depMode;

		private string backupId;

		private string dbInstanceType;

		private string vSwitchId;

		private string securityIPList;

		private string autoRenew;

		private string netType;

		private string zoneId;

		private string coreDiskType;

		private string pricingCycle;

		private string coreInstanceQuantity;

		private string duration;

		private string engine;

		private string restoreTime;

		private string srcDBInstanceId;

		private string masterInstanceType;

		private string coldStorageSize;

		private string coreDiskQuantity;

		private string isColdStorage;

		private string coreInstanceType;

		private string coreDiskSize;

		private string vpcId;

		private string dbType;

		private string payType;

		public string ClusterName
		{
			get
			{
				return clusterName;
			}
			set	
			{
				clusterName = value;
				DictionaryUtil.Add(QueryParameters, "ClusterName", value);
			}
		}

		public string DbInstanceConnType
		{
			get
			{
				return dbInstanceConnType;
			}
			set	
			{
				dbInstanceConnType = value;
				DictionaryUtil.Add(QueryParameters, "DbInstanceConnType", value);
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
				DictionaryUtil.Add(QueryParameters, "EngineVersion", value);
			}
		}

		public string DepMode
		{
			get
			{
				return depMode;
			}
			set	
			{
				depMode = value;
				DictionaryUtil.Add(QueryParameters, "DepMode", value);
			}
		}

		public string BackupId
		{
			get
			{
				return backupId;
			}
			set	
			{
				backupId = value;
				DictionaryUtil.Add(QueryParameters, "BackupId", value);
			}
		}

		public string DbInstanceType
		{
			get
			{
				return dbInstanceType;
			}
			set	
			{
				dbInstanceType = value;
				DictionaryUtil.Add(QueryParameters, "DbInstanceType", value);
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

		public string SecurityIPList
		{
			get
			{
				return securityIPList;
			}
			set	
			{
				securityIPList = value;
				DictionaryUtil.Add(QueryParameters, "SecurityIPList", value);
			}
		}

		public string AutoRenew
		{
			get
			{
				return autoRenew;
			}
			set	
			{
				autoRenew = value;
				DictionaryUtil.Add(QueryParameters, "AutoRenew", value);
			}
		}

		public string NetType
		{
			get
			{
				return netType;
			}
			set	
			{
				netType = value;
				DictionaryUtil.Add(QueryParameters, "NetType", value);
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

		public string CoreDiskType
		{
			get
			{
				return coreDiskType;
			}
			set	
			{
				coreDiskType = value;
				DictionaryUtil.Add(QueryParameters, "CoreDiskType", value);
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

		public string CoreInstanceQuantity
		{
			get
			{
				return coreInstanceQuantity;
			}
			set	
			{
				coreInstanceQuantity = value;
				DictionaryUtil.Add(QueryParameters, "CoreInstanceQuantity", value);
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

		public string Engine
		{
			get
			{
				return engine;
			}
			set	
			{
				engine = value;
				DictionaryUtil.Add(QueryParameters, "Engine", value);
			}
		}

		public string RestoreTime
		{
			get
			{
				return restoreTime;
			}
			set	
			{
				restoreTime = value;
				DictionaryUtil.Add(QueryParameters, "RestoreTime", value);
			}
		}

		public string SrcDBInstanceId
		{
			get
			{
				return srcDBInstanceId;
			}
			set	
			{
				srcDBInstanceId = value;
				DictionaryUtil.Add(QueryParameters, "SrcDBInstanceId", value);
			}
		}

		public string MasterInstanceType
		{
			get
			{
				return masterInstanceType;
			}
			set	
			{
				masterInstanceType = value;
				DictionaryUtil.Add(QueryParameters, "MasterInstanceType", value);
			}
		}

		public string ColdStorageSize
		{
			get
			{
				return coldStorageSize;
			}
			set	
			{
				coldStorageSize = value;
				DictionaryUtil.Add(QueryParameters, "ColdStorageSize", value);
			}
		}

		public string CoreDiskQuantity
		{
			get
			{
				return coreDiskQuantity;
			}
			set	
			{
				coreDiskQuantity = value;
				DictionaryUtil.Add(QueryParameters, "CoreDiskQuantity", value);
			}
		}

		public string IsColdStorage
		{
			get
			{
				return isColdStorage;
			}
			set	
			{
				isColdStorage = value;
				DictionaryUtil.Add(QueryParameters, "IsColdStorage", value);
			}
		}

		public string CoreInstanceType
		{
			get
			{
				return coreInstanceType;
			}
			set	
			{
				coreInstanceType = value;
				DictionaryUtil.Add(QueryParameters, "CoreInstanceType", value);
			}
		}

		public string CoreDiskSize
		{
			get
			{
				return coreDiskSize;
			}
			set	
			{
				coreDiskSize = value;
				DictionaryUtil.Add(QueryParameters, "CoreDiskSize", value);
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

		public string DbType
		{
			get
			{
				return dbType;
			}
			set	
			{
				dbType = value;
				DictionaryUtil.Add(QueryParameters, "DbType", value);
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

        public override CreateInstanceResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateInstanceResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
