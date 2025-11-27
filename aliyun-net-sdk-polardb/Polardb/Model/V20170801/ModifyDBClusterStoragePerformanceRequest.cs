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
using Aliyun.Acs.polardb.Transform;
using Aliyun.Acs.polardb.Transform.V20170801;

namespace Aliyun.Acs.polardb.Model.V20170801
{
    public class ModifyDBClusterStoragePerformanceRequest : RpcAcsRequest<ModifyDBClusterStoragePerformanceResponse>
    {
        public ModifyDBClusterStoragePerformanceRequest()
            : base("polardb", "2017-08-01", "ModifyDBClusterStoragePerformance", "polardb", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.polardb.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.polardb.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private long? resourceOwnerId;

		private string clientToken;

		private string storageType;

		private string dBClusterId;

		private string burstingEnabled;

		private int? provisionedIops;

		private string modifyType;

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

		public string StorageType
		{
			get
			{
				return storageType;
			}
			set	
			{
				storageType = value;
				DictionaryUtil.Add(QueryParameters, "StorageType", value);
			}
		}

		public string DBClusterId
		{
			get
			{
				return dBClusterId;
			}
			set	
			{
				dBClusterId = value;
				DictionaryUtil.Add(QueryParameters, "DBClusterId", value);
			}
		}

		public string BurstingEnabled
		{
			get
			{
				return burstingEnabled;
			}
			set	
			{
				burstingEnabled = value;
				DictionaryUtil.Add(QueryParameters, "BurstingEnabled", value);
			}
		}

		public int? ProvisionedIops
		{
			get
			{
				return provisionedIops;
			}
			set	
			{
				provisionedIops = value;
				DictionaryUtil.Add(QueryParameters, "ProvisionedIops", value.ToString());
			}
		}

		public string ModifyType
		{
			get
			{
				return modifyType;
			}
			set	
			{
				modifyType = value;
				DictionaryUtil.Add(QueryParameters, "ModifyType", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override ModifyDBClusterStoragePerformanceResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ModifyDBClusterStoragePerformanceResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
