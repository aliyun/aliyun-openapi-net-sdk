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
using Aliyun.Acs.scdn;
using Aliyun.Acs.scdn.Transform;
using Aliyun.Acs.scdn.Transform.V20171115;

namespace Aliyun.Acs.scdn.Model.V20171115
{
    public class RefreshScdnObjectCachesRequest : RpcAcsRequest<RefreshScdnObjectCachesResponse>
    {
        public RefreshScdnObjectCachesRequest()
            : base("scdn", "2017-11-15", "RefreshScdnObjectCaches")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string objectPath;

		private long? ownerId;

		private string securityToken;

		private string objectType;

		public string ObjectPath
		{
			get
			{
				return objectPath;
			}
			set	
			{
				objectPath = value;
				DictionaryUtil.Add(QueryParameters, "ObjectPath", value);
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

		public string SecurityToken
		{
			get
			{
				return securityToken;
			}
			set	
			{
				securityToken = value;
				DictionaryUtil.Add(QueryParameters, "SecurityToken", value);
			}
		}

		public string ObjectType
		{
			get
			{
				return objectType;
			}
			set	
			{
				objectType = value;
				DictionaryUtil.Add(QueryParameters, "ObjectType", value);
			}
		}

        public override RefreshScdnObjectCachesResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return RefreshScdnObjectCachesResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
