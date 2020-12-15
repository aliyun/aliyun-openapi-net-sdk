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
using Aliyun.Acs.Rds.Transform;
using Aliyun.Acs.Rds.Transform.V20140815;

namespace Aliyun.Acs.Rds.Model.V20140815
{
    public class ModifyDasInstanceConfigRequest : RpcAcsRequest<ModifyDasInstanceConfigResponse>
    {
        public ModifyDasInstanceConfigRequest()
            : base("Rds", "2014-08-15", "ModifyDasInstanceConfig", "rds", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Rds.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Rds.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private long? resourceOwnerId;

		private string clientToken;

		private string dBInstanceId;

		private string resourceOwnerAccount;

		private long? ownerId;

		private int? storageUpperBound;

		private int? storageThreshold;

		private string storageAutoScale;

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

		public string DBInstanceId
		{
			get
			{
				return dBInstanceId;
			}
			set	
			{
				dBInstanceId = value;
				DictionaryUtil.Add(QueryParameters, "DBInstanceId", value);
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

		public int? StorageUpperBound
		{
			get
			{
				return storageUpperBound;
			}
			set	
			{
				storageUpperBound = value;
				DictionaryUtil.Add(QueryParameters, "StorageUpperBound", value.ToString());
			}
		}

		public int? StorageThreshold
		{
			get
			{
				return storageThreshold;
			}
			set	
			{
				storageThreshold = value;
				DictionaryUtil.Add(QueryParameters, "StorageThreshold", value.ToString());
			}
		}

		public string StorageAutoScale
		{
			get
			{
				return storageAutoScale;
			}
			set	
			{
				storageAutoScale = value;
				DictionaryUtil.Add(QueryParameters, "StorageAutoScale", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override ModifyDasInstanceConfigResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ModifyDasInstanceConfigResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
