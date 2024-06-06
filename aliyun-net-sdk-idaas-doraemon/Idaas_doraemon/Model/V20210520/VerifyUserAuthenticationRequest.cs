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
using Aliyun.Acs.idaas_doraemon.Transform;
using Aliyun.Acs.idaas_doraemon.Transform.V20210520;

namespace Aliyun.Acs.idaas_doraemon.Model.V20210520
{
    public class VerifyUserAuthenticationRequest : RpcAcsRequest<VerifyUserAuthenticationResponse>
    {
        public VerifyUserAuthenticationRequest()
            : base("idaas-doraemon", "2021-05-20", "VerifyUserAuthentication", "idaasauth", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.idaas_doraemon.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.idaas_doraemon.Endpoint.endpointRegionalType, null);
            }
			Protocol = ProtocolType.HTTPS;
			Method = MethodType.POST;
        }

		private string logParams;

		private string clientExtendParamsJson;

		private string userId;

		private string logTag;

		private string serverExtendParamsJson;

		private string requireBindHashBase64;

		private string authenticationContext;

		private string requireChallengeBase64;

		private string authenticatorType;

		private string clientExtendParamsJsonSign;

		private string userSourceIp;

		private string applicationExternalId;

		public string LogParams
		{
			get
			{
				return logParams;
			}
			set	
			{
				logParams = value;
				DictionaryUtil.Add(QueryParameters, "LogParams", value);
			}
		}

		public string ClientExtendParamsJson
		{
			get
			{
				return clientExtendParamsJson;
			}
			set	
			{
				clientExtendParamsJson = value;
				DictionaryUtil.Add(QueryParameters, "ClientExtendParamsJson", value);
			}
		}

		public string UserId
		{
			get
			{
				return userId;
			}
			set	
			{
				userId = value;
				DictionaryUtil.Add(QueryParameters, "UserId", value);
			}
		}

		public string LogTag
		{
			get
			{
				return logTag;
			}
			set	
			{
				logTag = value;
				DictionaryUtil.Add(QueryParameters, "LogTag", value);
			}
		}

		public string ServerExtendParamsJson
		{
			get
			{
				return serverExtendParamsJson;
			}
			set	
			{
				serverExtendParamsJson = value;
				DictionaryUtil.Add(QueryParameters, "ServerExtendParamsJson", value);
			}
		}

		public string RequireBindHashBase64
		{
			get
			{
				return requireBindHashBase64;
			}
			set	
			{
				requireBindHashBase64 = value;
				DictionaryUtil.Add(QueryParameters, "RequireBindHashBase64", value);
			}
		}

		public string AuthenticationContext
		{
			get
			{
				return authenticationContext;
			}
			set	
			{
				authenticationContext = value;
				DictionaryUtil.Add(QueryParameters, "AuthenticationContext", value);
			}
		}

		public string RequireChallengeBase64
		{
			get
			{
				return requireChallengeBase64;
			}
			set	
			{
				requireChallengeBase64 = value;
				DictionaryUtil.Add(QueryParameters, "RequireChallengeBase64", value);
			}
		}

		public string AuthenticatorType
		{
			get
			{
				return authenticatorType;
			}
			set	
			{
				authenticatorType = value;
				DictionaryUtil.Add(QueryParameters, "AuthenticatorType", value);
			}
		}

		public string ClientExtendParamsJsonSign
		{
			get
			{
				return clientExtendParamsJsonSign;
			}
			set	
			{
				clientExtendParamsJsonSign = value;
				DictionaryUtil.Add(QueryParameters, "ClientExtendParamsJsonSign", value);
			}
		}

		public string UserSourceIp
		{
			get
			{
				return userSourceIp;
			}
			set	
			{
				userSourceIp = value;
				DictionaryUtil.Add(QueryParameters, "UserSourceIp", value);
			}
		}

		public string ApplicationExternalId
		{
			get
			{
				return applicationExternalId;
			}
			set	
			{
				applicationExternalId = value;
				DictionaryUtil.Add(QueryParameters, "ApplicationExternalId", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override VerifyUserAuthenticationResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return VerifyUserAuthenticationResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
