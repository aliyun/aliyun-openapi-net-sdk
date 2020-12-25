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
using Aliyun.Acs.Emr.Transform;
using Aliyun.Acs.Emr.Transform.V20160408;

namespace Aliyun.Acs.Emr.Model.V20160408
{
    public class ResizeClusterV2Request : RpcAcsRequest<ResizeClusterV2Response>
    {
        public ResizeClusterV2Request()
            : base("Emr", "2016-04-08", "ResizeClusterV2", "emr", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Emr.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Emr.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private bool? isOpenPublicIp;

		private bool? autoPayOrder;

		private string clusterId;

		private string vswitchId;

		private List<HostComponentInfo> hostComponentInfos = new List<HostComponentInfo>(){ };

		private List<HostGroup> hostGroups = new List<HostGroup>(){ };

		private List<PromotionInfo> promotionInfos = new List<PromotionInfo>(){ };

		public bool? IsOpenPublicIp
		{
			get
			{
				return isOpenPublicIp;
			}
			set	
			{
				isOpenPublicIp = value;
				DictionaryUtil.Add(QueryParameters, "IsOpenPublicIp", value.ToString());
			}
		}

		public bool? AutoPayOrder
		{
			get
			{
				return autoPayOrder;
			}
			set	
			{
				autoPayOrder = value;
				DictionaryUtil.Add(QueryParameters, "AutoPayOrder", value.ToString());
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

		public string VswitchId
		{
			get
			{
				return vswitchId;
			}
			set	
			{
				vswitchId = value;
				DictionaryUtil.Add(QueryParameters, "VswitchId", value);
			}
		}

		public List<HostComponentInfo> HostComponentInfos
		{
			get
			{
				return hostComponentInfos;
			}

			set
			{
				hostComponentInfos = value;
				for (int i = 0; i < hostComponentInfos.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"HostComponentInfo." + (i + 1) + ".HostName", hostComponentInfos[i].HostName);
					for (int j = 0; j < hostComponentInfos[i].ComponentNameLists.Count; j++)
					{
						DictionaryUtil.Add(QueryParameters,"HostComponentInfo." + (i + 1) + ".ComponentNameList." +(j + 1), hostComponentInfos[i].ComponentNameLists[j]);
					}
					DictionaryUtil.Add(QueryParameters,"HostComponentInfo." + (i + 1) + ".ServiceName", hostComponentInfos[i].ServiceName);
				}
			}
		}

		public List<HostGroup> HostGroups
		{
			get
			{
				return hostGroups;
			}

			set
			{
				hostGroups = value;
				for (int i = 0; i < hostGroups.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"HostGroup." + (i + 1) + ".Period", hostGroups[i].Period);
					DictionaryUtil.Add(QueryParameters,"HostGroup." + (i + 1) + ".SysDiskCapacity", hostGroups[i].SysDiskCapacity);
					DictionaryUtil.Add(QueryParameters,"HostGroup." + (i + 1) + ".HostKeyPairName", hostGroups[i].HostKeyPairName);
					DictionaryUtil.Add(QueryParameters,"HostGroup." + (i + 1) + ".DiskCapacity", hostGroups[i].DiskCapacity);
					DictionaryUtil.Add(QueryParameters,"HostGroup." + (i + 1) + ".SysDiskType", hostGroups[i].SysDiskType);
					DictionaryUtil.Add(QueryParameters,"HostGroup." + (i + 1) + ".ClusterId", hostGroups[i].ClusterId);
					DictionaryUtil.Add(QueryParameters,"HostGroup." + (i + 1) + ".DiskType", hostGroups[i].DiskType);
					DictionaryUtil.Add(QueryParameters,"HostGroup." + (i + 1) + ".HostGroupName", hostGroups[i].HostGroupName);
					DictionaryUtil.Add(QueryParameters,"HostGroup." + (i + 1) + ".VswitchId", hostGroups[i].VswitchId);
					DictionaryUtil.Add(QueryParameters,"HostGroup." + (i + 1) + ".DiskCount", hostGroups[i].DiskCount);
					DictionaryUtil.Add(QueryParameters,"HostGroup." + (i + 1) + ".AutoRenew", hostGroups[i].AutoRenew);
					DictionaryUtil.Add(QueryParameters,"HostGroup." + (i + 1) + ".HostGroupId", hostGroups[i].HostGroupId);
					DictionaryUtil.Add(QueryParameters,"HostGroup." + (i + 1) + ".NodeCount", hostGroups[i].NodeCount);
					DictionaryUtil.Add(QueryParameters,"HostGroup." + (i + 1) + ".InstanceType", hostGroups[i].InstanceType);
					DictionaryUtil.Add(QueryParameters,"HostGroup." + (i + 1) + ".Comment", hostGroups[i].Comment);
					DictionaryUtil.Add(QueryParameters,"HostGroup." + (i + 1) + ".ChargeType", hostGroups[i].ChargeType);
					DictionaryUtil.Add(QueryParameters,"HostGroup." + (i + 1) + ".CreateType", hostGroups[i].CreateType);
					DictionaryUtil.Add(QueryParameters,"HostGroup." + (i + 1) + ".HostPassword", hostGroups[i].HostPassword);
					DictionaryUtil.Add(QueryParameters,"HostGroup." + (i + 1) + ".HostGroupType", hostGroups[i].HostGroupType);
				}
			}
		}

		public List<PromotionInfo> PromotionInfos
		{
			get
			{
				return promotionInfos;
			}

			set
			{
				promotionInfos = value;
				for (int i = 0; i < promotionInfos.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"PromotionInfo." + (i + 1) + ".PromotionOptionCode", promotionInfos[i].PromotionOptionCode);
					DictionaryUtil.Add(QueryParameters,"PromotionInfo." + (i + 1) + ".ProductCode", promotionInfos[i].ProductCode);
					DictionaryUtil.Add(QueryParameters,"PromotionInfo." + (i + 1) + ".PromotionOptionNo", promotionInfos[i].PromotionOptionNo);
				}
			}
		}

		public class HostComponentInfo
		{

			private string hostName;

			private List<string> componentNameLists = new List<string>(){ };

			private string serviceName;

			public string HostName
			{
				get
				{
					return hostName;
				}
				set	
				{
					hostName = value;
				}
			}

			public List<string> ComponentNameLists
			{
				get
				{
					return componentNameLists;
				}
				set	
				{
					componentNameLists = value;
				}
			}

			public string ServiceName
			{
				get
				{
					return serviceName;
				}
				set	
				{
					serviceName = value;
				}
			}
		}

		public class HostGroup
		{

			private int? period;

			private int? sysDiskCapacity;

			private string hostKeyPairName;

			private int? diskCapacity;

			private string sysDiskType;

			private string clusterId;

			private string diskType;

			private string hostGroupName;

			private int? vswitchId;

			private int? diskCount;

			private bool? autoRenew;

			private string hostGroupId;

			private int? nodeCount;

			private string instanceType;

			private string comment;

			private string chargeType;

			private string createType;

			private string hostPassword;

			private string hostGroupType;

			public int? Period
			{
				get
				{
					return period;
				}
				set	
				{
					period = value;
				}
			}

			public int? SysDiskCapacity
			{
				get
				{
					return sysDiskCapacity;
				}
				set	
				{
					sysDiskCapacity = value;
				}
			}

			public string HostKeyPairName
			{
				get
				{
					return hostKeyPairName;
				}
				set	
				{
					hostKeyPairName = value;
				}
			}

			public int? DiskCapacity
			{
				get
				{
					return diskCapacity;
				}
				set	
				{
					diskCapacity = value;
				}
			}

			public string SysDiskType
			{
				get
				{
					return sysDiskType;
				}
				set	
				{
					sysDiskType = value;
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
				}
			}

			public string DiskType
			{
				get
				{
					return diskType;
				}
				set	
				{
					diskType = value;
				}
			}

			public string HostGroupName
			{
				get
				{
					return hostGroupName;
				}
				set	
				{
					hostGroupName = value;
				}
			}

			public int? VswitchId
			{
				get
				{
					return vswitchId;
				}
				set	
				{
					vswitchId = value;
				}
			}

			public int? DiskCount
			{
				get
				{
					return diskCount;
				}
				set	
				{
					diskCount = value;
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
				}
			}

			public string HostGroupId
			{
				get
				{
					return hostGroupId;
				}
				set	
				{
					hostGroupId = value;
				}
			}

			public int? NodeCount
			{
				get
				{
					return nodeCount;
				}
				set	
				{
					nodeCount = value;
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

			public string Comment
			{
				get
				{
					return comment;
				}
				set	
				{
					comment = value;
				}
			}

			public string ChargeType
			{
				get
				{
					return chargeType;
				}
				set	
				{
					chargeType = value;
				}
			}

			public string CreateType
			{
				get
				{
					return createType;
				}
				set	
				{
					createType = value;
				}
			}

			public string HostPassword
			{
				get
				{
					return hostPassword;
				}
				set	
				{
					hostPassword = value;
				}
			}

			public string HostGroupType
			{
				get
				{
					return hostGroupType;
				}
				set	
				{
					hostGroupType = value;
				}
			}
		}

		public class PromotionInfo
		{

			private string promotionOptionCode;

			private string productCode;

			private string promotionOptionNo;

			public string PromotionOptionCode
			{
				get
				{
					return promotionOptionCode;
				}
				set	
				{
					promotionOptionCode = value;
				}
			}

			public string ProductCode
			{
				get
				{
					return productCode;
				}
				set	
				{
					productCode = value;
				}
			}

			public string PromotionOptionNo
			{
				get
				{
					return promotionOptionNo;
				}
				set	
				{
					promotionOptionNo = value;
				}
			}
		}

        public override ResizeClusterV2Response GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ResizeClusterV2ResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
