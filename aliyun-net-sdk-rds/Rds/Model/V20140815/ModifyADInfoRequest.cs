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
using Newtonsoft.Json;

using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.Rds.Transform;
using Aliyun.Acs.Rds.Transform.V20140815;

namespace Aliyun.Acs.Rds.Model.V20140815
{
    public class ModifyADInfoRequest : RpcAcsRequest<ModifyADInfoResponse>
    {
        public ModifyADInfoRequest()
            : base("Rds", "2014-08-15", "ModifyADInfo", "rds", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Rds.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Rds.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private long? resourceOwnerId;

		private string aDAccountName;

		private string clientToken;

		private string dBInstanceId;

		private string aDDNS;

		private string resourceOwnerAccount;

		private string aDPassword;

		private long? ownerId;

		private string aDServerIpAddress;

		[JsonProperty(PropertyName = "ResourceOwnerId")]
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

		[JsonProperty(PropertyName = "ADAccountName")]
		public string ADAccountName
		{
			get
			{
				return aDAccountName;
			}
			set	
			{
				aDAccountName = value;
				DictionaryUtil.Add(QueryParameters, "ADAccountName", value);
			}
		}

		[JsonProperty(PropertyName = "ClientToken")]
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

		[JsonProperty(PropertyName = "DBInstanceId")]
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

		[JsonProperty(PropertyName = "ADDNS")]
		public string ADDNS
		{
			get
			{
				return aDDNS;
			}
			set	
			{
				aDDNS = value;
				DictionaryUtil.Add(QueryParameters, "ADDNS", value);
			}
		}

		[JsonProperty(PropertyName = "ResourceOwnerAccount")]
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

		[JsonProperty(PropertyName = "ADPassword")]
		public string ADPassword
		{
			get
			{
				return aDPassword;
			}
			set	
			{
				aDPassword = value;
				DictionaryUtil.Add(QueryParameters, "ADPassword", value);
			}
		}

		[JsonProperty(PropertyName = "OwnerId")]
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

		[JsonProperty(PropertyName = "ADServerIpAddress")]
		public string ADServerIpAddress
		{
			get
			{
				return aDServerIpAddress;
			}
			set	
			{
				aDServerIpAddress = value;
				DictionaryUtil.Add(QueryParameters, "ADServerIpAddress", value);
			}
		}

        public override ModifyADInfoResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ModifyADInfoResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
