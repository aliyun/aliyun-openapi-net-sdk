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
using Aliyun.Acs.adb.Transform;
using Aliyun.Acs.adb.Transform.V20211201;

namespace Aliyun.Acs.adb.Model.V20211201
{
    public class CreateDBClusterRequest : RpcAcsRequest<CreateDBClusterResponse>
    {
        public CreateDBClusterRequest()
            : base("adb", "2021-12-01", "CreateDBCluster", "ads", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.adb.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.adb.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string dBClusterDescription;

		private bool? enableDefaultResourcePool;

		private string storageResource;

		private string dBClusterNetworkType;

		private string period;

		private string dBClusterVersion;

		private string usedTime;

		private string vSwitchId;

		private string vPCId;

		private string zoneId;

		private string computeResource;

		private string payType;

		public string DBClusterDescription
		{
			get
			{
				return dBClusterDescription;
			}
			set	
			{
				dBClusterDescription = value;
				DictionaryUtil.Add(QueryParameters, "DBClusterDescription", value);
			}
		}

		public bool? EnableDefaultResourcePool
		{
			get
			{
				return enableDefaultResourcePool;
			}
			set	
			{
				enableDefaultResourcePool = value;
				DictionaryUtil.Add(QueryParameters, "EnableDefaultResourcePool", value.ToString());
			}
		}

		public string StorageResource
		{
			get
			{
				return storageResource;
			}
			set	
			{
				storageResource = value;
				DictionaryUtil.Add(QueryParameters, "StorageResource", value);
			}
		}

		public string DBClusterNetworkType
		{
			get
			{
				return dBClusterNetworkType;
			}
			set	
			{
				dBClusterNetworkType = value;
				DictionaryUtil.Add(QueryParameters, "DBClusterNetworkType", value);
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

		public string DBClusterVersion
		{
			get
			{
				return dBClusterVersion;
			}
			set	
			{
				dBClusterVersion = value;
				DictionaryUtil.Add(QueryParameters, "DBClusterVersion", value);
			}
		}

		public string UsedTime
		{
			get
			{
				return usedTime;
			}
			set	
			{
				usedTime = value;
				DictionaryUtil.Add(QueryParameters, "UsedTime", value);
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

		public string ComputeResource
		{
			get
			{
				return computeResource;
			}
			set	
			{
				computeResource = value;
				DictionaryUtil.Add(QueryParameters, "ComputeResource", value);
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

        public override CreateDBClusterResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateDBClusterResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
