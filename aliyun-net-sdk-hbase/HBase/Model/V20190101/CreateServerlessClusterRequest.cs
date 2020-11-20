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
    public class CreateServerlessClusterRequest : RpcAcsRequest<CreateServerlessClusterResponse>
    {
        public CreateServerlessClusterRequest()
            : base("HBase", "2019-01-01", "CreateServerlessCluster", "hbase", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.HBase.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.HBase.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string clusterName;

		private string clientToken;

		private string engineVersion;

		private string engine;

		private int? autoRenewPeriod;

		private int? period;

		private string vSwitchId;

		private string periodUnit;

		private int? serverlessCapability;

		private string vpcId;

		private string zoneId;

		private int? serverlessStorage;

		private string payType;

		private string serverlessSpec;

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

		public int? ServerlessCapability
		{
			get
			{
				return serverlessCapability;
			}
			set	
			{
				serverlessCapability = value;
				DictionaryUtil.Add(QueryParameters, "ServerlessCapability", value.ToString());
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

		public int? ServerlessStorage
		{
			get
			{
				return serverlessStorage;
			}
			set	
			{
				serverlessStorage = value;
				DictionaryUtil.Add(QueryParameters, "ServerlessStorage", value.ToString());
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

		public string ServerlessSpec
		{
			get
			{
				return serverlessSpec;
			}
			set	
			{
				serverlessSpec = value;
				DictionaryUtil.Add(QueryParameters, "ServerlessSpec", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override CreateServerlessClusterResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateServerlessClusterResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
