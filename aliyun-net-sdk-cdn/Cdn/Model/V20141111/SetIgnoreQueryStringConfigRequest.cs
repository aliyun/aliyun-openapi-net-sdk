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
    public class SetIgnoreQueryStringConfigRequest : RpcAcsRequest<SetIgnoreQueryStringConfigResponse>
    {
        public SetIgnoreQueryStringConfigRequest()
            : base("Cdn", "2014-11-11", "SetIgnoreQueryStringConfig")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Cdn.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Cdn.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string securityToken;

		private string enable;

		private string keepOssArgs;

		private string domainName;

		private long? ownerId;

		private string hashKeyArgs;

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

		public string Enable
		{
			get
			{
				return enable;
			}
			set	
			{
				enable = value;
				DictionaryUtil.Add(QueryParameters, "Enable", value);
			}
		}

		public string KeepOssArgs
		{
			get
			{
				return keepOssArgs;
			}
			set	
			{
				keepOssArgs = value;
				DictionaryUtil.Add(QueryParameters, "KeepOssArgs", value);
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

		public string HashKeyArgs
		{
			get
			{
				return hashKeyArgs;
			}
			set	
			{
				hashKeyArgs = value;
				DictionaryUtil.Add(QueryParameters, "HashKeyArgs", value);
			}
		}

        public override SetIgnoreQueryStringConfigResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return SetIgnoreQueryStringConfigResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
