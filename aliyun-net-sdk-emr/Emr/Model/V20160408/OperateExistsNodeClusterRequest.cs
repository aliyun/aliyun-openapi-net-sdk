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
    public class OperateExistsNodeClusterRequest : RpcAcsRequest<OperateExistsNodeClusterResponse>
    {
        public OperateExistsNodeClusterRequest()
            : base("Emr", "2016-04-08", "OperateExistsNodeCluster", "emr", "openAPI")
        {
        }

		private long? resourceOwnerId;

		private string logPath;

		private List<string> masterInstanceIdLists;

		private bool? ioOptimized;

		private string securityGroupId;

		private bool? easEnable;

		private bool? isResize;

		private string depositType;

		private string accessKeyId;

		private string machineType;

		private string regionId;

		private bool? useLocalMetaDb;

		private string emrVer;

		private int? period;

		private string clusterId;

		private string vSwitchId;

		private string clusterType;

		private List<string> optionSoftWareLists;

		private List<string> instanceIdLists;

		private string vpcId;

		private string netType;

		private string name;

		private string zoneId;

		private string chargeType;

		private string operateType;

		private bool? highAvailabilityEnable;

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

		public string LogPath
		{
			get
			{
				return logPath;
			}
			set	
			{
				logPath = value;
				DictionaryUtil.Add(QueryParameters, "LogPath", value);
			}
		}

		public List<string> MasterInstanceIdLists
		{
			get
			{
				return masterInstanceIdLists;
			}

			set
			{
				masterInstanceIdLists = value;
				for (int i = 0; i < masterInstanceIdLists.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"MasterInstanceIdList." + (i + 1) , masterInstanceIdLists[i]);
				}
			}
		}

		public bool? IoOptimized
		{
			get
			{
				return ioOptimized;
			}
			set	
			{
				ioOptimized = value;
				DictionaryUtil.Add(QueryParameters, "IoOptimized", value.ToString());
			}
		}

		public string SecurityGroupId
		{
			get
			{
				return securityGroupId;
			}
			set	
			{
				securityGroupId = value;
				DictionaryUtil.Add(QueryParameters, "SecurityGroupId", value);
			}
		}

		public bool? EasEnable
		{
			get
			{
				return easEnable;
			}
			set	
			{
				easEnable = value;
				DictionaryUtil.Add(QueryParameters, "EasEnable", value.ToString());
			}
		}

		public bool? IsResize
		{
			get
			{
				return isResize;
			}
			set	
			{
				isResize = value;
				DictionaryUtil.Add(QueryParameters, "IsResize", value.ToString());
			}
		}

		public string DepositType
		{
			get
			{
				return depositType;
			}
			set	
			{
				depositType = value;
				DictionaryUtil.Add(QueryParameters, "DepositType", value);
			}
		}

		public string AccessKeyId
		{
			get
			{
				return accessKeyId;
			}
			set	
			{
				accessKeyId = value;
				DictionaryUtil.Add(QueryParameters, "AccessKeyId", value);
			}
		}

		public string MachineType
		{
			get
			{
				return machineType;
			}
			set	
			{
				machineType = value;
				DictionaryUtil.Add(QueryParameters, "MachineType", value);
			}
		}

		public string RegionId
		{
			get
			{
				return regionId;
			}
			set	
			{
				regionId = value;
				DictionaryUtil.Add(QueryParameters, "RegionId", value);
			}
		}

		public bool? UseLocalMetaDb
		{
			get
			{
				return useLocalMetaDb;
			}
			set	
			{
				useLocalMetaDb = value;
				DictionaryUtil.Add(QueryParameters, "UseLocalMetaDb", value.ToString());
			}
		}

		public string EmrVer
		{
			get
			{
				return emrVer;
			}
			set	
			{
				emrVer = value;
				DictionaryUtil.Add(QueryParameters, "EmrVer", value);
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

		public string ClusterType
		{
			get
			{
				return clusterType;
			}
			set	
			{
				clusterType = value;
				DictionaryUtil.Add(QueryParameters, "ClusterType", value);
			}
		}

		public List<string> OptionSoftWareLists
		{
			get
			{
				return optionSoftWareLists;
			}

			set
			{
				optionSoftWareLists = value;
				for (int i = 0; i < optionSoftWareLists.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"OptionSoftWareList." + (i + 1) , optionSoftWareLists[i]);
				}
			}
		}

		public List<string> InstanceIdLists
		{
			get
			{
				return instanceIdLists;
			}

			set
			{
				instanceIdLists = value;
				for (int i = 0; i < instanceIdLists.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"InstanceIdList." + (i + 1) , instanceIdLists[i]);
				}
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

		public string Name
		{
			get
			{
				return name;
			}
			set	
			{
				name = value;
				DictionaryUtil.Add(QueryParameters, "Name", value);
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

		public string ChargeType
		{
			get
			{
				return chargeType;
			}
			set	
			{
				chargeType = value;
				DictionaryUtil.Add(QueryParameters, "ChargeType", value);
			}
		}

		public string OperateType
		{
			get
			{
				return operateType;
			}
			set	
			{
				operateType = value;
				DictionaryUtil.Add(QueryParameters, "OperateType", value);
			}
		}

		public bool? HighAvailabilityEnable
		{
			get
			{
				return highAvailabilityEnable;
			}
			set	
			{
				highAvailabilityEnable = value;
				DictionaryUtil.Add(QueryParameters, "HighAvailabilityEnable", value.ToString());
			}
		}

        public override OperateExistsNodeClusterResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return OperateExistsNodeClusterResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
