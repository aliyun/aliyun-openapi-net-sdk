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
    public class ApplyNodesRequest : RpcAcsRequest<ApplyNodesResponse>
    {
        public ApplyNodesRequest()
            : base("EHPC", "2018-04-12", "ApplyNodes")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.EHPC.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.EHPC.Endpoint.endpointRegionalType, null);
            }
        }

		private string imageId;

		private int? memory;

		private string systemDiskLevel;

		private bool? allocatePublicAddress;

		private int? internetMaxBandWidthOut;

		private string resourceAmountType;

		private bool? strictResourceProvision;

		private string systemDiskType;

		private int? cores;

		private int? systemDiskSize;

		private List<ZoneInfos> zoneInfoss = new List<ZoneInfos>(){ };

		private string hostNamePrefix;

		private float? computeSpotPriceLimit;

		private string clusterId;

		private string computeSpotStrategy;

		private string hostNameSuffix;

		private string priorityStrategy;

		private string instanceFamilyLevel;

		private string internetChargeType;

		private List<InstanceTypeModel> instanceTypeModels = new List<InstanceTypeModel>(){ };

		private int? internetMaxBandWidthIn;

		private int? targetCapacity;

		private bool? strictSatisfiedTargetCapacity;

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

		public int? Memory
		{
			get
			{
				return memory;
			}
			set	
			{
				memory = value;
				DictionaryUtil.Add(QueryParameters, "Memory", value.ToString());
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

		public string ResourceAmountType
		{
			get
			{
				return resourceAmountType;
			}
			set	
			{
				resourceAmountType = value;
				DictionaryUtil.Add(QueryParameters, "ResourceAmountType", value);
			}
		}

		public bool? StrictResourceProvision
		{
			get
			{
				return strictResourceProvision;
			}
			set	
			{
				strictResourceProvision = value;
				DictionaryUtil.Add(QueryParameters, "StrictResourceProvision", value.ToString());
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

		public int? Cores
		{
			get
			{
				return cores;
			}
			set	
			{
				cores = value;
				DictionaryUtil.Add(QueryParameters, "Cores", value.ToString());
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

		public List<ZoneInfos> ZoneInfoss
		{
			get
			{
				return zoneInfoss;
			}

			set
			{
				zoneInfoss = value;
				for (int i = 0; i < zoneInfoss.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"ZoneInfos." + (i + 1) + ".VSwitchId", zoneInfoss[i].VSwitchId);
					DictionaryUtil.Add(QueryParameters,"ZoneInfos." + (i + 1) + ".ZoneId", zoneInfoss[i].ZoneId);
				}
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

		public float? ComputeSpotPriceLimit
		{
			get
			{
				return computeSpotPriceLimit;
			}
			set	
			{
				computeSpotPriceLimit = value;
				DictionaryUtil.Add(QueryParameters, "ComputeSpotPriceLimit", value.ToString());
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

		public string PriorityStrategy
		{
			get
			{
				return priorityStrategy;
			}
			set	
			{
				priorityStrategy = value;
				DictionaryUtil.Add(QueryParameters, "PriorityStrategy", value);
			}
		}

		public string InstanceFamilyLevel
		{
			get
			{
				return instanceFamilyLevel;
			}
			set	
			{
				instanceFamilyLevel = value;
				DictionaryUtil.Add(QueryParameters, "InstanceFamilyLevel", value);
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

		public List<InstanceTypeModel> InstanceTypeModels
		{
			get
			{
				return instanceTypeModels;
			}

			set
			{
				instanceTypeModels = value;
				for (int i = 0; i < instanceTypeModels.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"InstanceTypeModel." + (i + 1) + ".MaxPrice", instanceTypeModels[i].MaxPrice);
					DictionaryUtil.Add(QueryParameters,"InstanceTypeModel." + (i + 1) + ".TargetImageId", instanceTypeModels[i].TargetImageId);
					DictionaryUtil.Add(QueryParameters,"InstanceTypeModel." + (i + 1) + ".InstanceType", instanceTypeModels[i].InstanceType);
				}
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

		public int? TargetCapacity
		{
			get
			{
				return targetCapacity;
			}
			set	
			{
				targetCapacity = value;
				DictionaryUtil.Add(QueryParameters, "TargetCapacity", value.ToString());
			}
		}

		public bool? StrictSatisfiedTargetCapacity
		{
			get
			{
				return strictSatisfiedTargetCapacity;
			}
			set	
			{
				strictSatisfiedTargetCapacity = value;
				DictionaryUtil.Add(QueryParameters, "StrictSatisfiedTargetCapacity", value.ToString());
			}
		}

		public class ZoneInfos
		{

			private string vSwitchId;

			private string zoneId;

			public string VSwitchId
			{
				get
				{
					return vSwitchId;
				}
				set	
				{
					vSwitchId = value;
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
				}
			}
		}

		public class InstanceTypeModel
		{

			private float? maxPrice;

			private string targetImageId;

			private string instanceType;

			public float? MaxPrice
			{
				get
				{
					return maxPrice;
				}
				set	
				{
					maxPrice = value;
				}
			}

			public string TargetImageId
			{
				get
				{
					return targetImageId;
				}
				set	
				{
					targetImageId = value;
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
				}
			}
		}

        public override ApplyNodesResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ApplyNodesResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
