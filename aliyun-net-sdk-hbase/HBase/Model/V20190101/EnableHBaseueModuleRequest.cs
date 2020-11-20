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
    public class EnableHBaseueModuleRequest : RpcAcsRequest<EnableHBaseueModuleResponse>
    {
        public EnableHBaseueModuleRequest()
            : base("HBase", "2019-01-01", "EnableHBaseueModule", "hbase", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.HBase.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.HBase.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string clientToken;

		private string moduleTypeName;

		private string hbaseueClusterId;

		private string bdsId;

		private string moduleClusterName;

		private int? autoRenewPeriod;

		private int? period;

		private int? diskSize;

		private string masterInstanceType;

		private string diskType;

		private string vswitchId;

		private string periodUnit;

		private string coreInstanceType;

		private string vpcId;

		private int? nodeCount;

		private string zoneId;

		private string payType;

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

		public string ModuleTypeName
		{
			get
			{
				return moduleTypeName;
			}
			set	
			{
				moduleTypeName = value;
				DictionaryUtil.Add(QueryParameters, "ModuleTypeName", value);
			}
		}

		public string HbaseueClusterId
		{
			get
			{
				return hbaseueClusterId;
			}
			set	
			{
				hbaseueClusterId = value;
				DictionaryUtil.Add(QueryParameters, "HbaseueClusterId", value);
			}
		}

		public string BdsId
		{
			get
			{
				return bdsId;
			}
			set	
			{
				bdsId = value;
				DictionaryUtil.Add(QueryParameters, "BdsId", value);
			}
		}

		public string ModuleClusterName
		{
			get
			{
				return moduleClusterName;
			}
			set	
			{
				moduleClusterName = value;
				DictionaryUtil.Add(QueryParameters, "ModuleClusterName", value);
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

		public int? DiskSize
		{
			get
			{
				return diskSize;
			}
			set	
			{
				diskSize = value;
				DictionaryUtil.Add(QueryParameters, "DiskSize", value.ToString());
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

		public string DiskType
		{
			get
			{
				return diskType;
			}
			set	
			{
				diskType = value;
				DictionaryUtil.Add(QueryParameters, "DiskType", value);
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

		public int? NodeCount
		{
			get
			{
				return nodeCount;
			}
			set	
			{
				nodeCount = value;
				DictionaryUtil.Add(QueryParameters, "NodeCount", value.ToString());
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

        public override EnableHBaseueModuleResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return EnableHBaseueModuleResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
