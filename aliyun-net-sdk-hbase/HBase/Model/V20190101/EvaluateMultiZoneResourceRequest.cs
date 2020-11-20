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
    public class EvaluateMultiZoneResourceRequest : RpcAcsRequest<EvaluateMultiZoneResourceResponse>
    {
        public EvaluateMultiZoneResourceRequest()
            : base("HBase", "2019-01-01", "EvaluateMultiZoneResource", "hbase", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.HBase.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.HBase.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string archVersion;

		private string clusterName;

		private string engineVersion;

		private string logDiskType;

		private string primaryVSwitchId;

		private string logInstanceType;

		private int? autoRenewPeriod;

		private int? period;

		private int? logNodeCount;

		private string securityIPList;

		private string periodUnit;

		private string coreDiskType;

		private string arbiterZoneId;

		private string clientToken;

		private string multiZoneCombination;

		private string primaryZoneId;

		private string engine;

		private string standbyVSwitchId;

		private string standbyZoneId;

		private string masterInstanceType;

		private int? coreNodeCount;

		private int? logDiskSize;

		private string coreInstanceType;

		private int? coreDiskSize;

		private string vpcId;

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

		public string LogDiskType
		{
			get
			{
				return logDiskType;
			}
			set	
			{
				logDiskType = value;
				DictionaryUtil.Add(QueryParameters, "LogDiskType", value);
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

		public string LogInstanceType
		{
			get
			{
				return logInstanceType;
			}
			set	
			{
				logInstanceType = value;
				DictionaryUtil.Add(QueryParameters, "LogInstanceType", value);
			}
		}

		public int? AutoRenewPeriod
		{
			get
			{
				return autoRenewPeriod;
			}
			set	
			{
				autoRenewPeriod = value;
				DictionaryUtil.Add(QueryParameters, "AutoRenewPeriod", value.ToString());
			}
		}

		public int? Period
		{
			get
			{
				return period;
			}
			set	
			{
				period = value;
				DictionaryUtil.Add(QueryParameters, "Period", value.ToString());
			}
		}

		public int? LogNodeCount
		{
			get
			{
				return logNodeCount;
			}
			set	
			{
				logNodeCount = value;
				DictionaryUtil.Add(QueryParameters, "LogNodeCount", value.ToString());
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

		public string PeriodUnit
		{
			get
			{
				return periodUnit;
			}
			set	
			{
				periodUnit = value;
				DictionaryUtil.Add(QueryParameters, "PeriodUnit", value);
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

		public int? CoreNodeCount
		{
			get
			{
				return coreNodeCount;
			}
			set	
			{
				coreNodeCount = value;
				DictionaryUtil.Add(QueryParameters, "CoreNodeCount", value.ToString());
			}
		}

		public int? LogDiskSize
		{
			get
			{
				return logDiskSize;
			}
			set	
			{
				logDiskSize = value;
				DictionaryUtil.Add(QueryParameters, "LogDiskSize", value.ToString());
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

		public int? CoreDiskSize
		{
			get
			{
				return coreDiskSize;
			}
			set	
			{
				coreDiskSize = value;
				DictionaryUtil.Add(QueryParameters, "CoreDiskSize", value.ToString());
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

        public override EvaluateMultiZoneResourceResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return EvaluateMultiZoneResourceResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
