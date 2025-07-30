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
using Aliyun.Acs.R_kvstore.Transform;
using Aliyun.Acs.R_kvstore.Transform.V20150101;

namespace Aliyun.Acs.R_kvstore.Model.V20150101
{
    public class ModifyInstanceConfigRequest : RpcAcsRequest<ModifyInstanceConfigResponse>
    {
        public ModifyInstanceConfigRequest()
            : base("R-kvstore", "2015-01-01", "ModifyInstanceConfig", "redisa", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.R_kvstore.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.R_kvstore.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private long? resourceOwnerId;

		private string paramSemisyncReplTimeout;

		private string paramNoLooseSentinelPasswordFreeCommands;

		private string paramNoLooseSentinelPasswordFreeAccess;

		private string paramReplMode;

		private string securityToken;

		private string paramNoLooseSentinelEnabled;

		private string resourceOwnerAccount;

		private string ownerAccount;

		private string paramSentinelCompatEnable;

		private long? ownerId;

		private string instanceId;

		private string config;

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

		public string ParamSemisyncReplTimeout
		{
			get
			{
				return paramSemisyncReplTimeout;
			}
			set	
			{
				paramSemisyncReplTimeout = value;
				DictionaryUtil.Add(QueryParameters, "ParamSemisyncReplTimeout", value);
			}
		}

		public string ParamNoLooseSentinelPasswordFreeCommands
		{
			get
			{
				return paramNoLooseSentinelPasswordFreeCommands;
			}
			set	
			{
				paramNoLooseSentinelPasswordFreeCommands = value;
				DictionaryUtil.Add(QueryParameters, "ParamNoLooseSentinelPasswordFreeCommands", value);
			}
		}

		public string ParamNoLooseSentinelPasswordFreeAccess
		{
			get
			{
				return paramNoLooseSentinelPasswordFreeAccess;
			}
			set	
			{
				paramNoLooseSentinelPasswordFreeAccess = value;
				DictionaryUtil.Add(QueryParameters, "ParamNoLooseSentinelPasswordFreeAccess", value);
			}
		}

		public string ParamReplMode
		{
			get
			{
				return paramReplMode;
			}
			set	
			{
				paramReplMode = value;
				DictionaryUtil.Add(QueryParameters, "ParamReplMode", value);
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

		public string ParamNoLooseSentinelEnabled
		{
			get
			{
				return paramNoLooseSentinelEnabled;
			}
			set	
			{
				paramNoLooseSentinelEnabled = value;
				DictionaryUtil.Add(QueryParameters, "ParamNoLooseSentinelEnabled", value);
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

		public string ParamSentinelCompatEnable
		{
			get
			{
				return paramSentinelCompatEnable;
			}
			set	
			{
				paramSentinelCompatEnable = value;
				DictionaryUtil.Add(QueryParameters, "ParamSentinelCompatEnable", value);
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

		public string InstanceId
		{
			get
			{
				return instanceId;
			}
			set	
			{
				instanceId = value;
				DictionaryUtil.Add(QueryParameters, "InstanceId", value);
			}
		}

		public string Config
		{
			get
			{
				return config;
			}
			set	
			{
				config = value;
				DictionaryUtil.Add(QueryParameters, "Config", value);
			}
		}

        public override ModifyInstanceConfigResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ModifyInstanceConfigResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
