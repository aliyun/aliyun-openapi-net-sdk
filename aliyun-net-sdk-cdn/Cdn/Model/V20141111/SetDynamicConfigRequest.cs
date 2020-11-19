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
using Aliyun.Acs.Cdn;
using Aliyun.Acs.Cdn.Transform;
using Aliyun.Acs.Cdn.Transform.V20141111;

namespace Aliyun.Acs.Cdn.Model.V20141111
{
    public class SetDynamicConfigRequest : RpcAcsRequest<SetDynamicConfigResponse>
    {
        public SetDynamicConfigRequest()
            : base("Cdn", "2014-11-11", "SetDynamicConfig")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Cdn.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Cdn.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string dynamicOrigin;

		private string staticType;

		private string securityToken;

		private string staticUri;

		private string domainName;

		private string staticPath;

		private string dynamicCacheControl;

		private long? ownerId;

		public string DynamicOrigin
		{
			get
			{
				return dynamicOrigin;
			}
			set	
			{
				dynamicOrigin = value;
				DictionaryUtil.Add(QueryParameters, "DynamicOrigin", value);
			}
		}

		public string StaticType
		{
			get
			{
				return staticType;
			}
			set	
			{
				staticType = value;
				DictionaryUtil.Add(QueryParameters, "StaticType", value);
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

		public string StaticUri
		{
			get
			{
				return staticUri;
			}
			set	
			{
				staticUri = value;
				DictionaryUtil.Add(QueryParameters, "StaticUri", value);
			}
		}

		public string DomainName
		{
			get
			{
				return domainName;
			}
			set	
			{
				domainName = value;
				DictionaryUtil.Add(QueryParameters, "DomainName", value);
			}
		}

		public string StaticPath
		{
			get
			{
				return staticPath;
			}
			set	
			{
				staticPath = value;
				DictionaryUtil.Add(QueryParameters, "StaticPath", value);
			}
		}

		public string DynamicCacheControl
		{
			get
			{
				return dynamicCacheControl;
			}
			set	
			{
				dynamicCacheControl = value;
				DictionaryUtil.Add(QueryParameters, "DynamicCacheControl", value);
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

        public override SetDynamicConfigResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return SetDynamicConfigResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
