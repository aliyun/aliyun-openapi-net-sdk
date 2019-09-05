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
using Aliyun.Acs.CloudAPI.Transform;
using Aliyun.Acs.CloudAPI.Transform.V20160714;

namespace Aliyun.Acs.CloudAPI.Model.V20160714
{
    public class CreateApiRequest : RpcAcsRequest<CreateApiResponse>
    {
        public CreateApiRequest()
            : base("CloudAPI", "2016-07-14", "CreateApi", "apigateway", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
        }

		private string webSocketApiType;

		private string errorCodeSamples;

		private string appCodeAuthType;

		private string description;

		private bool? disableInternet;

		private string constantParameters;

		private string authType;

		private string allowSignatureMethod;

		private string serviceParameters;

		private string failResultSample;

		private string systemParameters;

		private string serviceParametersMap;

		private string securityToken;

		private string openIdConnectConfig;

		private string requestParameters;

		private string resultDescriptions;

		private string visibility;

		private string groupId;

		private string serviceConfig;

		private string resultType;

		private string apiName;

		private string resultSample;

		private bool? forceNonceCheck;

		private string requestConfig;

		private string resultBodyModel;

		public string WebSocketApiType
		{
			get
			{
				return webSocketApiType;
			}
			set	
			{
				webSocketApiType = value;
				DictionaryUtil.Add(QueryParameters, "WebSocketApiType", value);
			}
		}

		public string ErrorCodeSamples
		{
			get
			{
				return errorCodeSamples;
			}
			set	
			{
				errorCodeSamples = value;
				DictionaryUtil.Add(QueryParameters, "ErrorCodeSamples", value);
			}
		}

		public string AppCodeAuthType
		{
			get
			{
				return appCodeAuthType;
			}
			set	
			{
				appCodeAuthType = value;
				DictionaryUtil.Add(QueryParameters, "AppCodeAuthType", value);
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

		public bool? DisableInternet
		{
			get
			{
				return disableInternet;
			}
			set	
			{
				disableInternet = value;
				DictionaryUtil.Add(QueryParameters, "DisableInternet", value.ToString());
			}
		}

		public string ConstantParameters
		{
			get
			{
				return constantParameters;
			}
			set	
			{
				constantParameters = value;
				DictionaryUtil.Add(QueryParameters, "ConstantParameters", value);
			}
		}

		public string AuthType
		{
			get
			{
				return authType;
			}
			set	
			{
				authType = value;
				DictionaryUtil.Add(QueryParameters, "AuthType", value);
			}
		}

		public string AllowSignatureMethod
		{
			get
			{
				return allowSignatureMethod;
			}
			set	
			{
				allowSignatureMethod = value;
				DictionaryUtil.Add(QueryParameters, "AllowSignatureMethod", value);
			}
		}

		public string ServiceParameters
		{
			get
			{
				return serviceParameters;
			}
			set	
			{
				serviceParameters = value;
				DictionaryUtil.Add(QueryParameters, "ServiceParameters", value);
			}
		}

		public string FailResultSample
		{
			get
			{
				return failResultSample;
			}
			set	
			{
				failResultSample = value;
				DictionaryUtil.Add(QueryParameters, "FailResultSample", value);
			}
		}

		public string SystemParameters
		{
			get
			{
				return systemParameters;
			}
			set	
			{
				systemParameters = value;
				DictionaryUtil.Add(QueryParameters, "SystemParameters", value);
			}
		}

		public string ServiceParametersMap
		{
			get
			{
				return serviceParametersMap;
			}
			set	
			{
				serviceParametersMap = value;
				DictionaryUtil.Add(QueryParameters, "ServiceParametersMap", value);
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

		public string OpenIdConnectConfig
		{
			get
			{
				return openIdConnectConfig;
			}
			set	
			{
				openIdConnectConfig = value;
				DictionaryUtil.Add(QueryParameters, "OpenIdConnectConfig", value);
			}
		}

		public string RequestParameters
		{
			get
			{
				return requestParameters;
			}
			set	
			{
				requestParameters = value;
				DictionaryUtil.Add(QueryParameters, "RequestParameters", value);
			}
		}

		public string ResultDescriptions
		{
			get
			{
				return resultDescriptions;
			}
			set	
			{
				resultDescriptions = value;
				DictionaryUtil.Add(QueryParameters, "ResultDescriptions", value);
			}
		}

		public string Visibility
		{
			get
			{
				return visibility;
			}
			set	
			{
				visibility = value;
				DictionaryUtil.Add(QueryParameters, "Visibility", value);
			}
		}

		public string GroupId
		{
			get
			{
				return groupId;
			}
			set	
			{
				groupId = value;
				DictionaryUtil.Add(QueryParameters, "GroupId", value);
			}
		}

		public string ServiceConfig
		{
			get
			{
				return serviceConfig;
			}
			set	
			{
				serviceConfig = value;
				DictionaryUtil.Add(QueryParameters, "ServiceConfig", value);
			}
		}

		public string ResultType
		{
			get
			{
				return resultType;
			}
			set	
			{
				resultType = value;
				DictionaryUtil.Add(QueryParameters, "ResultType", value);
			}
		}

		public string ApiName
		{
			get
			{
				return apiName;
			}
			set	
			{
				apiName = value;
				DictionaryUtil.Add(QueryParameters, "ApiName", value);
			}
		}

		public string ResultSample
		{
			get
			{
				return resultSample;
			}
			set	
			{
				resultSample = value;
				DictionaryUtil.Add(QueryParameters, "ResultSample", value);
			}
		}

		public bool? ForceNonceCheck
		{
			get
			{
				return forceNonceCheck;
			}
			set	
			{
				forceNonceCheck = value;
				DictionaryUtil.Add(QueryParameters, "ForceNonceCheck", value.ToString());
			}
		}

		public string RequestConfig
		{
			get
			{
				return requestConfig;
			}
			set	
			{
				requestConfig = value;
				DictionaryUtil.Add(QueryParameters, "RequestConfig", value);
			}
		}

		public string ResultBodyModel
		{
			get
			{
				return resultBodyModel;
			}
			set	
			{
				resultBodyModel = value;
				DictionaryUtil.Add(QueryParameters, "ResultBodyModel", value);
			}
		}

        public override CreateApiResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateApiResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
