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
using Aliyun.Acs.Domain.Transform;
using Aliyun.Acs.Domain.Transform.V20180129;

namespace Aliyun.Acs.Domain.Model.V20180129
{
    public class SaveBatchTaskForTransferOutByAuthorizationCodeRequest : RpcAcsRequest<SaveBatchTaskForTransferOutByAuthorizationCodeResponse>
    {
        public SaveBatchTaskForTransferOutByAuthorizationCodeRequest()
            : base("Domain", "2018-01-29", "SaveBatchTaskForTransferOutByAuthorizationCode", "domain", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Domain.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Domain.Endpoint.endpointRegionalType, null);
            }
			Protocol = ProtocolType.HTTPS;
			Method = MethodType.POST;
        }

		private string _long;

		private List<string> transferOutParamLists = new List<string>(){ };

		private string userClientIp;

		[JsonProperty(PropertyName = "Long")]
		public string _Long
		{
			get
			{
				return _long;
			}
			set	
			{
				_long = value;
				DictionaryUtil.Add(QueryParameters, "Long", value);
			}
		}

		[JsonProperty(PropertyName = "TransferOutParamList")]
		public List<string> TransferOutParamLists
		{
			get
			{
				return transferOutParamLists;
			}

			set
			{
				transferOutParamLists = value;
				if(transferOutParamLists != null)
				{
					for (int depth1 = 0; depth1 < transferOutParamLists.Count; depth1++)
					{
						DictionaryUtil.Add(QueryParameters,"TransferOutParamList." + (depth1 + 1), transferOutParamLists[depth1]);
						DictionaryUtil.Add(QueryParameters,"TransferOutParamList." + (depth1 + 1), transferOutParamLists[depth1]);
					}
				}
			}
		}

		[JsonProperty(PropertyName = "UserClientIp")]
		public string UserClientIp
		{
			get
			{
				return userClientIp;
			}
			set	
			{
				userClientIp = value;
				DictionaryUtil.Add(QueryParameters, "UserClientIp", value);
			}
		}

		public class TransferOutParamList
		{

			private string authorizationCode;

			private string domainName;

			[JsonProperty(PropertyName = "AuthorizationCode")]
			public string AuthorizationCode
			{
				get
				{
					return authorizationCode;
				}
				set	
				{
					authorizationCode = value;
				}
			}

			[JsonProperty(PropertyName = "DomainName")]
			public string DomainName
			{
				get
				{
					return domainName;
				}
				set	
				{
					domainName = value;
				}
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override SaveBatchTaskForTransferOutByAuthorizationCodeResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return SaveBatchTaskForTransferOutByAuthorizationCodeResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
