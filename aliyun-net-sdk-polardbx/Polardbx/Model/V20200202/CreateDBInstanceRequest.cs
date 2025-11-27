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
using Aliyun.Acs.polardbx.Transform;
using Aliyun.Acs.polardbx.Transform.V20200202;

namespace Aliyun.Acs.polardbx.Model.V20200202
{
    public class CreateDBInstanceRequest : RpcAcsRequest<CreateDBInstanceResponse>
    {
        public CreateDBInstanceRequest()
            : base("polardbx", "2020-02-02", "CreateDBInstance", "polardbx", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.polardbx.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.polardbx.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string networkType;

		private string engineVersion;

		private string tertiaryZone;

		private string cnClass;

		private string resourceGroupId;

		private string dBNodeClass;

		private string secondaryZone;

		private string period;

		private bool? isReadDBInstance;

		private string vSwitchId;

		private bool? autoRenew;

		private string zoneId;

		private string cNNodeCount;

		private string primaryDBInstanceName;

		private string topologyType;

		private string clientToken;

		private bool? isColumnarReadDBInstance;

		private string dNNodeCount;

		private int? dBNodeCount;

		private string dnClass;

		private int? usedTime;

		private string dnStorageSpace;

		private string primaryZone;

		private string series;

		private string vPCId;

		private string payType;

		public string NetworkType
		{
			get
			{
				return networkType;
			}
			set	
			{
				networkType = value;
				DictionaryUtil.Add(QueryParameters, "NetworkType", value);
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

		public string TertiaryZone
		{
			get
			{
				return tertiaryZone;
			}
			set	
			{
				tertiaryZone = value;
				DictionaryUtil.Add(QueryParameters, "TertiaryZone", value);
			}
		}

		public string CnClass
		{
			get
			{
				return cnClass;
			}
			set	
			{
				cnClass = value;
				DictionaryUtil.Add(QueryParameters, "CnClass", value);
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

		public string SecondaryZone
		{
			get
			{
				return secondaryZone;
			}
			set	
			{
				secondaryZone = value;
				DictionaryUtil.Add(QueryParameters, "SecondaryZone", value);
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

		public bool? IsReadDBInstance
		{
			get
			{
				return isReadDBInstance;
			}
			set	
			{
				isReadDBInstance = value;
				DictionaryUtil.Add(QueryParameters, "IsReadDBInstance", value.ToString());
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

		public bool? AutoRenew
		{
			get
			{
				return autoRenew;
			}
			set	
			{
				autoRenew = value;
				DictionaryUtil.Add(QueryParameters, "AutoRenew", value.ToString());
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

		public string CNNodeCount
		{
			get
			{
				return cNNodeCount;
			}
			set	
			{
				cNNodeCount = value;
				DictionaryUtil.Add(QueryParameters, "CNNodeCount", value);
			}
		}

		public string PrimaryDBInstanceName
		{
			get
			{
				return primaryDBInstanceName;
			}
			set	
			{
				primaryDBInstanceName = value;
				DictionaryUtil.Add(QueryParameters, "PrimaryDBInstanceName", value);
			}
		}

		public string TopologyType
		{
			get
			{
				return topologyType;
			}
			set	
			{
				topologyType = value;
				DictionaryUtil.Add(QueryParameters, "TopologyType", value);
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

		public bool? IsColumnarReadDBInstance
		{
			get
			{
				return isColumnarReadDBInstance;
			}
			set	
			{
				isColumnarReadDBInstance = value;
				DictionaryUtil.Add(QueryParameters, "IsColumnarReadDBInstance", value.ToString());
			}
		}

		public string DNNodeCount
		{
			get
			{
				return dNNodeCount;
			}
			set	
			{
				dNNodeCount = value;
				DictionaryUtil.Add(QueryParameters, "DNNodeCount", value);
			}
		}

		public int? DBNodeCount
		{
			get
			{
				return dBNodeCount;
			}
			set	
			{
				dBNodeCount = value;
				DictionaryUtil.Add(QueryParameters, "DBNodeCount", value.ToString());
			}
		}

		public string DnClass
		{
			get
			{
				return dnClass;
			}
			set	
			{
				dnClass = value;
				DictionaryUtil.Add(QueryParameters, "DnClass", value);
			}
		}

		public int? UsedTime
		{
			get
			{
				return usedTime;
			}
			set	
			{
				usedTime = value;
				DictionaryUtil.Add(QueryParameters, "UsedTime", value.ToString());
			}
		}

		public string DnStorageSpace
		{
			get
			{
				return dnStorageSpace;
			}
			set	
			{
				dnStorageSpace = value;
				DictionaryUtil.Add(QueryParameters, "DnStorageSpace", value);
			}
		}

		public string PrimaryZone
		{
			get
			{
				return primaryZone;
			}
			set	
			{
				primaryZone = value;
				DictionaryUtil.Add(QueryParameters, "PrimaryZone", value);
			}
		}

		public string Series
		{
			get
			{
				return series;
			}
			set	
			{
				series = value;
				DictionaryUtil.Add(QueryParameters, "Series", value);
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

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override CreateDBInstanceResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateDBInstanceResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
