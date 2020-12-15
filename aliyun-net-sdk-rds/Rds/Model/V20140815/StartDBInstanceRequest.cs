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
    public class StartDBInstanceRequest : RpcAcsRequest<StartDBInstanceResponse>
    {
        public StartDBInstanceRequest()
            : base("Rds", "2014-08-15", "StartDBInstance", "rds", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Rds.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Rds.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private long? resourceOwnerId;

		private string specifiedTime;

		private string targetDedicatedHostIdForSlave;

		private string engineVersion;

		private int? storage;

		private string effectiveTime;

		private int? dBInstanceTransType;

		private string targetDedicatedHostIdForMaster;

		private string dBInstanceId;

		private string dedicatedHostGroupId;

		private string resourceOwnerAccount;

		private long? ownerId;

		private string targetDBInstanceClass;

		private string vSwitchId;

		private string targetDedicatedHostIdForLog;

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

		public string SpecifiedTime
		{
			get
			{
				return specifiedTime;
			}
			set	
			{
				specifiedTime = value;
				DictionaryUtil.Add(QueryParameters, "SpecifiedTime", value);
			}
		}

		public string TargetDedicatedHostIdForSlave
		{
			get
			{
				return targetDedicatedHostIdForSlave;
			}
			set	
			{
				targetDedicatedHostIdForSlave = value;
				DictionaryUtil.Add(QueryParameters, "TargetDedicatedHostIdForSlave", value);
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

		public int? DBInstanceTransType
		{
			get
			{
				return dBInstanceTransType;
			}
			set	
			{
				dBInstanceTransType = value;
				DictionaryUtil.Add(QueryParameters, "DBInstanceTransType", value.ToString());
			}
		}

		public string TargetDedicatedHostIdForMaster
		{
			get
			{
				return targetDedicatedHostIdForMaster;
			}
			set	
			{
				targetDedicatedHostIdForMaster = value;
				DictionaryUtil.Add(QueryParameters, "TargetDedicatedHostIdForMaster", value);
			}
		}

		public string DBInstanceId
		{
			get
			{
				return dBInstanceId;
			}
			set	
			{
				dBInstanceId = value;
				DictionaryUtil.Add(QueryParameters, "DBInstanceId", value);
			}
		}

		public string DedicatedHostGroupId
		{
			get
			{
				return dedicatedHostGroupId;
			}
			set	
			{
				dedicatedHostGroupId = value;
				DictionaryUtil.Add(QueryParameters, "DedicatedHostGroupId", value);
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

		public string TargetDBInstanceClass
		{
			get
			{
				return targetDBInstanceClass;
			}
			set	
			{
				targetDBInstanceClass = value;
				DictionaryUtil.Add(QueryParameters, "TargetDBInstanceClass", value);
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

		public string TargetDedicatedHostIdForLog
		{
			get
			{
				return targetDedicatedHostIdForLog;
			}
			set	
			{
				targetDedicatedHostIdForLog = value;
				DictionaryUtil.Add(QueryParameters, "TargetDedicatedHostIdForLog", value);
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

        public override StartDBInstanceResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return StartDBInstanceResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
