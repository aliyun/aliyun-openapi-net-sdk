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
using Aliyun.Acs.adb.Transform.V20190315;

namespace Aliyun.Acs.adb.Model.V20190315
{
    public class ModifyDBClusterRequest : RpcAcsRequest<ModifyDBClusterResponse>
    {
        public ModifyDBClusterRequest()
            : base("adb", "2019-03-15", "ModifyDBCluster", "ads", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.adb.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.adb.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private long? resourceOwnerId;

		private string mode;

		private string storageResource;

		private string dBNodeClass;

		private string dBClusterCategory;

		private string resourceOwnerAccount;

		private string dBClusterId;

		private string ownerAccount;

		private long? ownerId;

		private string dBNodeGroupCount;

		private string dBNodeStorage;

		private string executorCount;

		private string modifyType;

		private string computeResource;

		private int? elasticIOResource;

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

		public string Mode
		{
			get
			{
				return mode;
			}
			set	
			{
				mode = value;
				DictionaryUtil.Add(QueryParameters, "Mode", value);
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

		public string DBNodeClass
		{
			get
			{
				return dBNodeClass;
			}
			set	
			{
				dBNodeClass = value;
				DictionaryUtil.Add(QueryParameters, "DBNodeClass", value);
			}
		}

		public string DBClusterCategory
		{
			get
			{
				return dBClusterCategory;
			}
			set	
			{
				dBClusterCategory = value;
				DictionaryUtil.Add(QueryParameters, "DBClusterCategory", value);
			}
		}

		public string ResourceOwnerAccount
		{
			get
			{
				return resourceOwnerAccount;
			}
			set	
			{
				resourceOwnerAccount = value;
				DictionaryUtil.Add(QueryParameters, "ResourceOwnerAccount", value);
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

		public string OwnerAccount
		{
			get
			{
				return ownerAccount;
			}
			set	
			{
				ownerAccount = value;
				DictionaryUtil.Add(QueryParameters, "OwnerAccount", value);
			}
		}

		public long? OwnerId
		{
			get
			{
				return ownerId;
			}
			set	
			{
				ownerId = value;
				DictionaryUtil.Add(QueryParameters, "OwnerId", value.ToString());
			}
		}

		public string DBNodeGroupCount
		{
			get
			{
				return dBNodeGroupCount;
			}
			set	
			{
				dBNodeGroupCount = value;
				DictionaryUtil.Add(QueryParameters, "DBNodeGroupCount", value);
			}
		}

		public string DBNodeStorage
		{
			get
			{
				return dBNodeStorage;
			}
			set	
			{
				dBNodeStorage = value;
				DictionaryUtil.Add(QueryParameters, "DBNodeStorage", value);
			}
		}

		public string ExecutorCount
		{
			get
			{
				return executorCount;
			}
			set	
			{
				executorCount = value;
				DictionaryUtil.Add(QueryParameters, "ExecutorCount", value);
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

		public int? ElasticIOResource
		{
			get
			{
				return elasticIOResource;
			}
			set	
			{
				elasticIOResource = value;
				DictionaryUtil.Add(QueryParameters, "ElasticIOResource", value.ToString());
			}
		}

        public override ModifyDBClusterResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ModifyDBClusterResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
