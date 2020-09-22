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
using Aliyun.Acs.vs.Transform;
using Aliyun.Acs.vs.Transform.V20181212;

namespace Aliyun.Acs.vs.Model.V20181212
{
    public class ModifyParentPlatformRequest : RpcAcsRequest<ModifyParentPlatformResponse>
    {
        public ModifyParentPlatformRequest()
            : base("vs", "2018-12-12", "ModifyParentPlatform", "vs", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string gbId;

		private bool? clientAuth;

		private string description;

		private bool? autoStart;

		private string id;

		private string clientPassword;

		private string ip;

		private long? ownerId;

		private long? port;

		private string name;

		private string clientUsername;

		public string GbId
		{
			get
			{
				return gbId;
			}
			set	
			{
				gbId = value;
				DictionaryUtil.Add(QueryParameters, "GbId", value);
			}
		}

		public bool? ClientAuth
		{
			get
			{
				return clientAuth;
			}
			set	
			{
				clientAuth = value;
				DictionaryUtil.Add(QueryParameters, "ClientAuth", value.ToString());
			}
		}

		public string Description
		{
			get
			{
				return description;
			}
			set	
			{
				description = value;
				DictionaryUtil.Add(QueryParameters, "Description", value);
			}
		}

		public bool? AutoStart
		{
			get
			{
				return autoStart;
			}
			set	
			{
				autoStart = value;
				DictionaryUtil.Add(QueryParameters, "AutoStart", value.ToString());
			}
		}

		public string Id
		{
			get
			{
				return id;
			}
			set	
			{
				id = value;
				DictionaryUtil.Add(QueryParameters, "Id", value);
			}
		}

		public string ClientPassword
		{
			get
			{
				return clientPassword;
			}
			set	
			{
				clientPassword = value;
				DictionaryUtil.Add(QueryParameters, "ClientPassword", value);
			}
		}

		public string Ip
		{
			get
			{
				return ip;
			}
			set	
			{
				ip = value;
				DictionaryUtil.Add(QueryParameters, "Ip", value);
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

		public long? Port
		{
			get
			{
				return port;
			}
			set	
			{
				port = value;
				DictionaryUtil.Add(QueryParameters, "Port", value.ToString());
			}
		}

		public string Name
		{
			get
			{
				return name;
			}
			set	
			{
				name = value;
				DictionaryUtil.Add(QueryParameters, "Name", value);
			}
		}

		public string ClientUsername
		{
			get
			{
				return clientUsername;
			}
			set	
			{
				clientUsername = value;
				DictionaryUtil.Add(QueryParameters, "ClientUsername", value);
			}
		}

        public override ModifyParentPlatformResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ModifyParentPlatformResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
