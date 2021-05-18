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
using Aliyun.Acs.EHPC;
using Aliyun.Acs.EHPC.Transform;
using Aliyun.Acs.EHPC.Transform.V20180412;

namespace Aliyun.Acs.EHPC.Model.V20180412
{
    public class AddNodesRequest : RpcAcsRequest<AddNodesResponse>
    {
        public AddNodesRequest()
            : base("EHPC", "2018-04-12", "AddNodes")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.EHPC.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.EHPC.Endpoint.endpointRegionalType, null);
            }
        }

		private string imageId;

		private string systemDiskLevel;

		private string clientToken;

		private bool? allocatePublicAddress;

		private int? internetMaxBandWidthOut;

		private string jobQueue;

		private string imageOwnerAlias;

		private string systemDiskType;

		private int? minCount;

		private int? systemDiskSize;

		private string instanceType;

		private string hostNamePrefix;

		private string computeSpotPriceLimit;

		private int? autoRenewPeriod;

		private int? period;

		private int? count;

		private string clusterId;

		private string computeSpotStrategy;

		private string hostNameSuffix;

		private string vSwitchId;

		private string periodUnit;

		private bool? computeEnableHt;

		private string autoRenew;

		private string ecsChargeType;

		private string internetChargeType;

		private string createMode;

		private string zoneId;

		private int? internetMaxBandWidthIn;

		public string ImageId
		{
			get
			{
				return imageId;
			}
			set	
			{
				imageId = value;
				DictionaryUtil.Add(QueryParameters, "ImageId", value);
			}
		}

		public string SystemDiskLevel
		{
			get
			{
				return systemDiskLevel;
			}
			set	
			{
				systemDiskLevel = value;
				DictionaryUtil.Add(QueryParameters, "SystemDiskLevel", value);
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

		public bool? AllocatePublicAddress
		{
			get
			{
				return allocatePublicAddress;
			}
			set	
			{
				allocatePublicAddress = value;
				DictionaryUtil.Add(QueryParameters, "AllocatePublicAddress", value.ToString());
			}
		}

		public int? InternetMaxBandWidthOut
		{
			get
			{
				return internetMaxBandWidthOut;
			}
			set	
			{
				internetMaxBandWidthOut = value;
				DictionaryUtil.Add(QueryParameters, "InternetMaxBandWidthOut", value.ToString());
			}
		}

		public string JobQueue
		{
			get
			{
				return jobQueue;
			}
			set	
			{
				jobQueue = value;
				DictionaryUtil.Add(QueryParameters, "JobQueue", value);
			}
		}

		public string ImageOwnerAlias
		{
			get
			{
				return imageOwnerAlias;
			}
			set	
			{
				imageOwnerAlias = value;
				DictionaryUtil.Add(QueryParameters, "ImageOwnerAlias", value);
			}
		}

		public string SystemDiskType
		{
			get
			{
				return systemDiskType;
			}
			set	
			{
				systemDiskType = value;
				DictionaryUtil.Add(QueryParameters, "SystemDiskType", value);
			}
		}

		public int? MinCount
		{
			get
			{
				return minCount;
			}
			set	
			{
				minCount = value;
				DictionaryUtil.Add(QueryParameters, "MinCount", value.ToString());
			}
		}

		public int? SystemDiskSize
		{
			get
			{
				return systemDiskSize;
			}
			set	
			{
				systemDiskSize = value;
				DictionaryUtil.Add(QueryParameters, "SystemDiskSize", value.ToString());
			}
		}

		public string InstanceType
		{
			get
			{
				return instanceType;
			}
			set	
			{
				instanceType = value;
				DictionaryUtil.Add(QueryParameters, "InstanceType", value);
			}
		}

		public string HostNamePrefix
		{
			get
			{
				return hostNamePrefix;
			}
			set	
			{
				hostNamePrefix = value;
				DictionaryUtil.Add(QueryParameters, "HostNamePrefix", value);
			}
		}

		public string ComputeSpotPriceLimit
		{
			get
			{
				return computeSpotPriceLimit;
			}
			set	
			{
				computeSpotPriceLimit = value;
				DictionaryUtil.Add(QueryParameters, "ComputeSpotPriceLimit", value);
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

		public int? Count
		{
			get
			{
				return count;
			}
			set	
			{
				count = value;
				DictionaryUtil.Add(QueryParameters, "Count", value.ToString());
			}
		}

		public string ClusterId
		{
			get
			{
				return clusterId;
			}
			set	
			{
				clusterId = value;
				DictionaryUtil.Add(QueryParameters, "ClusterId", value);
			}
		}

		public string ComputeSpotStrategy
		{
			get
			{
				return computeSpotStrategy;
			}
			set	
			{
				computeSpotStrategy = value;
				DictionaryUtil.Add(QueryParameters, "ComputeSpotStrategy", value);
			}
		}

		public string HostNameSuffix
		{
			get
			{
				return hostNameSuffix;
			}
			set	
			{
				hostNameSuffix = value;
				DictionaryUtil.Add(QueryParameters, "HostNameSuffix", value);
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

		public bool? ComputeEnableHt
		{
			get
			{
				return computeEnableHt;
			}
			set	
			{
				computeEnableHt = value;
				DictionaryUtil.Add(QueryParameters, "ComputeEnableHt", value.ToString());
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

		public string EcsChargeType
		{
			get
			{
				return ecsChargeType;
			}
			set	
			{
				ecsChargeType = value;
				DictionaryUtil.Add(QueryParameters, "EcsChargeType", value);
			}
		}

		public string InternetChargeType
		{
			get
			{
				return internetChargeType;
			}
			set	
			{
				internetChargeType = value;
				DictionaryUtil.Add(QueryParameters, "InternetChargeType", value);
			}
		}

		public string CreateMode
		{
			get
			{
				return createMode;
			}
			set	
			{
				createMode = value;
				DictionaryUtil.Add(QueryParameters, "CreateMode", value);
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

		public int? InternetMaxBandWidthIn
		{
			get
			{
				return internetMaxBandWidthIn;
			}
			set	
			{
				internetMaxBandWidthIn = value;
				DictionaryUtil.Add(QueryParameters, "InternetMaxBandWidthIn", value.ToString());
			}
		}

        public override AddNodesResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return AddNodesResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
