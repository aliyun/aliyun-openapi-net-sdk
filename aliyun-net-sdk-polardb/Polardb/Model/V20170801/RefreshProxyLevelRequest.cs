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
using Aliyun.Acs.polardb;
using Aliyun.Acs.polardb.Transform;
using Aliyun.Acs.polardb.Transform.V20170801;

namespace Aliyun.Acs.polardb.Model.V20170801
{
    public class RefreshProxyLevelRequest : RpcAcsRequest<RefreshProxyLevelResponse>
    {
        public RefreshProxyLevelRequest()
            : base("polardb", "2017-08-01", "RefreshProxyLevel")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.polardb.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.polardb.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private long? resourceOwnerId;

		private string plannedEndTime;

		private string proxyTargetClass;

		private string resourceOwnerAccount;

		private string dBClusterId;

		private string ownerAccount;

		private long? ownerId;

		private string plannedStartTime;

		private bool? fromTimeService;

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

		public string PlannedEndTime
		{
			get
			{
				return plannedEndTime;
			}
			set	
			{
				plannedEndTime = value;
				DictionaryUtil.Add(QueryParameters, "PlannedEndTime", value);
			}
		}

		public string ProxyTargetClass
		{
			get
			{
				return proxyTargetClass;
			}
			set	
			{
				proxyTargetClass = value;
				DictionaryUtil.Add(QueryParameters, "ProxyTargetClass", value);
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

		public string PlannedStartTime
		{
			get
			{
				return plannedStartTime;
			}
			set	
			{
				plannedStartTime = value;
				DictionaryUtil.Add(QueryParameters, "PlannedStartTime", value);
			}
		}

		public bool? FromTimeService
		{
			get
			{
				return fromTimeService;
			}
			set	
			{
				fromTimeService = value;
				DictionaryUtil.Add(QueryParameters, "FromTimeService", value.ToString());
			}
		}

        public override RefreshProxyLevelResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return RefreshProxyLevelResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
