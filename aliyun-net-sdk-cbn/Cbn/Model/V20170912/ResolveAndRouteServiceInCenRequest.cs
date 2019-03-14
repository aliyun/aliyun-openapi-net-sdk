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
using Aliyun.Acs.Cbn.Transform;
using Aliyun.Acs.Cbn.Transform.V20170912;

namespace Aliyun.Acs.Cbn.Model.V20170912
{
    public class ResolveAndRouteServiceInCenRequest : RpcAcsRequest<ResolveAndRouteServiceInCenResponse>
    {
        public ResolveAndRouteServiceInCenRequest()
            : base("Cbn", "2017-09-12", "ResolveAndRouteServiceInCen", "cbn", "openAPI")
        {
        }

		private long? resourceOwnerId;

		private string resourceOwnerAccount;

		private string clientToken;

		private string cenId;

		private string ownerAccount;

		private string host;

		private string hostRegionId;

		private string action;

		private string accessRegionId;

		private long? ownerId;

		private long? updateInterval;

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

		public string CenId
		{
			get
			{
				return cenId;
			}
			set	
			{
				cenId = value;
				DictionaryUtil.Add(QueryParameters, "CenId", value);
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

		public string Host
		{
			get
			{
				return host;
			}
			set	
			{
				host = value;
				DictionaryUtil.Add(QueryParameters, "Host", value);
			}
		}

		public string HostRegionId
		{
			get
			{
				return hostRegionId;
			}
			set	
			{
				hostRegionId = value;
				DictionaryUtil.Add(QueryParameters, "HostRegionId", value);
			}
		}

		public string Action
		{
			get
			{
				return action;
			}
			set	
			{
				action = value;
				DictionaryUtil.Add(QueryParameters, "Action", value);
			}
		}

		public string AccessRegionId
		{
			get
			{
				return accessRegionId;
			}
			set	
			{
				accessRegionId = value;
				DictionaryUtil.Add(QueryParameters, "AccessRegionId", value);
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

		public long? UpdateInterval
		{
			get
			{
				return updateInterval;
			}
			set	
			{
				updateInterval = value;
				DictionaryUtil.Add(QueryParameters, "UpdateInterval", value.ToString());
			}
		}

        public override ResolveAndRouteServiceInCenResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ResolveAndRouteServiceInCenResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
