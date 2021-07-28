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
using Aliyun.Acs.retailcloud.Transform;
using Aliyun.Acs.retailcloud.Transform.V20180313;

namespace Aliyun.Acs.retailcloud.Model.V20180313
{
    public class CreateClusterRequest : RpcAcsRequest<CreateClusterResponse>
    {
        public CreateClusterRequest()
            : base("retailcloud", "2018-03-13", "CreateCluster", "retailcloud", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.retailcloud.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.retailcloud.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string businessCode;

		private bool? createWithLogIntegration;

		private List<string> vswitchidss = new List<string>(){ };

		private int? cloudMonitorFlags;

		private string clusterEnvType;

		private bool? createWithArmsIntegration;

		private string keyPair;

		private string clusterTitle;

		private string podCIDR;

		private long? clusterId;

		private string clusterType;

		private string password;

		private int? snatEntry;

		private string netPlug;

		private string vpcId;

		private string regionName;

		private bool? privateZone;

		private string serviceCIDR;

		private int? publicSlb;

		public string BusinessCode
		{
			get
			{
				return businessCode;
			}
			set	
			{
				businessCode = value;
				DictionaryUtil.Add(QueryParameters, "BusinessCode", value);
			}
		}

		public bool? CreateWithLogIntegration
		{
			get
			{
				return createWithLogIntegration;
			}
			set	
			{
				createWithLogIntegration = value;
				DictionaryUtil.Add(QueryParameters, "CreateWithLogIntegration", value.ToString());
			}
		}

		public List<string> Vswitchidss
		{
			get
			{
				return vswitchidss;
			}

			set
			{
				vswitchidss = value;
				for (int i = 0; i < vswitchidss.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"Vswitchids." + (i + 1) , vswitchidss[i]);
				}
			}
		}

		public int? CloudMonitorFlags
		{
			get
			{
				return cloudMonitorFlags;
			}
			set	
			{
				cloudMonitorFlags = value;
				DictionaryUtil.Add(QueryParameters, "CloudMonitorFlags", value.ToString());
			}
		}

		public string ClusterEnvType
		{
			get
			{
				return clusterEnvType;
			}
			set	
			{
				clusterEnvType = value;
				DictionaryUtil.Add(QueryParameters, "ClusterEnvType", value);
			}
		}

		public bool? CreateWithArmsIntegration
		{
			get
			{
				return createWithArmsIntegration;
			}
			set	
			{
				createWithArmsIntegration = value;
				DictionaryUtil.Add(QueryParameters, "CreateWithArmsIntegration", value.ToString());
			}
		}

		public string KeyPair
		{
			get
			{
				return keyPair;
			}
			set	
			{
				keyPair = value;
				DictionaryUtil.Add(QueryParameters, "KeyPair", value);
			}
		}

		public string ClusterTitle
		{
			get
			{
				return clusterTitle;
			}
			set	
			{
				clusterTitle = value;
				DictionaryUtil.Add(QueryParameters, "ClusterTitle", value);
			}
		}

		public string PodCIDR
		{
			get
			{
				return podCIDR;
			}
			set	
			{
				podCIDR = value;
				DictionaryUtil.Add(QueryParameters, "PodCIDR", value);
			}
		}

		public long? ClusterId
		{
			get
			{
				return clusterId;
			}
			set	
			{
				clusterId = value;
				DictionaryUtil.Add(QueryParameters, "ClusterId", value.ToString());
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

		public string Password
		{
			get
			{
				return password;
			}
			set	
			{
				password = value;
				DictionaryUtil.Add(QueryParameters, "Password", value);
			}
		}

		public int? SnatEntry
		{
			get
			{
				return snatEntry;
			}
			set	
			{
				snatEntry = value;
				DictionaryUtil.Add(QueryParameters, "SnatEntry", value.ToString());
			}
		}

		public string NetPlug
		{
			get
			{
				return netPlug;
			}
			set	
			{
				netPlug = value;
				DictionaryUtil.Add(QueryParameters, "NetPlug", value);
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

		public string RegionName
		{
			get
			{
				return regionName;
			}
			set	
			{
				regionName = value;
				DictionaryUtil.Add(QueryParameters, "RegionName", value);
			}
		}

		public bool? PrivateZone
		{
			get
			{
				return privateZone;
			}
			set	
			{
				privateZone = value;
				DictionaryUtil.Add(QueryParameters, "PrivateZone", value.ToString());
			}
		}

		public string ServiceCIDR
		{
			get
			{
				return serviceCIDR;
			}
			set	
			{
				serviceCIDR = value;
				DictionaryUtil.Add(QueryParameters, "ServiceCIDR", value);
			}
		}

		public int? PublicSlb
		{
			get
			{
				return publicSlb;
			}
			set	
			{
				publicSlb = value;
				DictionaryUtil.Add(QueryParameters, "PublicSlb", value.ToString());
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override CreateClusterResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateClusterResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
