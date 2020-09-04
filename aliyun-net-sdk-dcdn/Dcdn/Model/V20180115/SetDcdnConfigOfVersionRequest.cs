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
using Aliyun.Acs.dcdn;
using Aliyun.Acs.dcdn.Transform;
using Aliyun.Acs.dcdn.Transform.V20180115;

namespace Aliyun.Acs.dcdn.Model.V20180115
{
    public class SetDcdnConfigOfVersionRequest : RpcAcsRequest<SetDcdnConfigOfVersionResponse>
    {
        public SetDcdnConfigOfVersionRequest()
            : base("dcdn", "2018-01-15", "SetDcdnConfigOfVersion")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string versionId;

		private string securityToken;

		private string functionName;

		private string functionArgs;

		private string ownerAccount;

		private long? ownerId;

		private long? functionId;

		private string configId;

		public string VersionId
		{
			get
			{
				return versionId;
			}
			set	
			{
				versionId = value;
				DictionaryUtil.Add(QueryParameters, "VersionId", value);
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

		public string FunctionName
		{
			get
			{
				return functionName;
			}
			set	
			{
				functionName = value;
				DictionaryUtil.Add(QueryParameters, "FunctionName", value);
			}
		}

		public string FunctionArgs
		{
			get
			{
				return functionArgs;
			}
			set	
			{
				functionArgs = value;
				DictionaryUtil.Add(QueryParameters, "FunctionArgs", value);
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

		public long? FunctionId
		{
			get
			{
				return functionId;
			}
			set	
			{
				functionId = value;
				DictionaryUtil.Add(QueryParameters, "FunctionId", value.ToString());
			}
		}

		public string ConfigId
		{
			get
			{
				return configId;
			}
			set	
			{
				configId = value;
				DictionaryUtil.Add(QueryParameters, "ConfigId", value);
			}
		}

        public override SetDcdnConfigOfVersionResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return SetDcdnConfigOfVersionResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
