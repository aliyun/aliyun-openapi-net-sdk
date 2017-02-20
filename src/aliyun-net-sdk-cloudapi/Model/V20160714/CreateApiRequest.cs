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
using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.CloudAPI.Transform.V20160714;

namespace Aliyun.Acs.CloudAPI.Model.V20160714
{
    public class CreateApiRequest : RpcAcsRequest<CreateApiResponse>
    {
        public CreateApiRequest()
            : base("CloudAPI", "2016-07-14", "CreateApi")
        {
        }

		private string _groupId;

		private string _apiName;

		private string _visibility;

		private string _description;

		private string _authType;

		private string _requestConfig;

		private string _serviceConfig;

		private string _requestParameters;

		private string _systemParameters;

		private string _constantParameters;

		private string _serviceParameters;

		private string _serviceParametersMap;

		private string _resultType;

		private string _resultSample;

		private string _failResultSample;

		private string _errorCodeSamples;

		public string GroupId
		{
			get
			{
				return _groupId;
			}
			set	
			{
				_groupId = value;
				DictionaryUtil.Add(QueryParameters, "GroupId", value);
			}
		}

		public string ApiName
		{
			get
			{
				return _apiName;
			}
			set	
			{
				_apiName = value;
				DictionaryUtil.Add(QueryParameters, "ApiName", value);
			}
		}

		public string Visibility
		{
			get
			{
				return _visibility;
			}
			set	
			{
				_visibility = value;
				DictionaryUtil.Add(QueryParameters, "Visibility", value);
			}
		}

		public string Description
		{
			get
			{
				return _description;
			}
			set	
			{
				_description = value;
				DictionaryUtil.Add(QueryParameters, "Description", value);
			}
		}

		public string AuthType
		{
			get
			{
				return _authType;
			}
			set	
			{
				_authType = value;
				DictionaryUtil.Add(QueryParameters, "AuthType", value);
			}
		}

		public string RequestConfig
		{
			get
			{
				return _requestConfig;
			}
			set	
			{
				_requestConfig = value;
				DictionaryUtil.Add(QueryParameters, "RequestConfig", value);
			}
		}

		public string ServiceConfig
		{
			get
			{
				return _serviceConfig;
			}
			set	
			{
				_serviceConfig = value;
				DictionaryUtil.Add(QueryParameters, "ServiceConfig", value);
			}
		}

		public string RequestParameters
		{
			get
			{
				return _requestParameters;
			}
			set	
			{
				_requestParameters = value;
				DictionaryUtil.Add(QueryParameters, "RequestParameters", value);
			}
		}

		public string SystemParameters
		{
			get
			{
				return _systemParameters;
			}
			set	
			{
				_systemParameters = value;
				DictionaryUtil.Add(QueryParameters, "SystemParameters", value);
			}
		}

		public string ConstantParameters
		{
			get
			{
				return _constantParameters;
			}
			set	
			{
				_constantParameters = value;
				DictionaryUtil.Add(QueryParameters, "ConstantParameters", value);
			}
		}

		public string ServiceParameters
		{
			get
			{
				return _serviceParameters;
			}
			set	
			{
				_serviceParameters = value;
				DictionaryUtil.Add(QueryParameters, "ServiceParameters", value);
			}
		}

		public string ServiceParametersMap
		{
			get
			{
				return _serviceParametersMap;
			}
			set	
			{
				_serviceParametersMap = value;
				DictionaryUtil.Add(QueryParameters, "ServiceParametersMap", value);
			}
		}

		public string ResultType
		{
			get
			{
				return _resultType;
			}
			set	
			{
				_resultType = value;
				DictionaryUtil.Add(QueryParameters, "ResultType", value);
			}
		}

		public string ResultSample
		{
			get
			{
				return _resultSample;
			}
			set	
			{
				_resultSample = value;
				DictionaryUtil.Add(QueryParameters, "ResultSample", value);
			}
		}

		public string FailResultSample
		{
			get
			{
				return _failResultSample;
			}
			set	
			{
				_failResultSample = value;
				DictionaryUtil.Add(QueryParameters, "FailResultSample", value);
			}
		}

		public string ErrorCodeSamples
		{
			get
			{
				return _errorCodeSamples;
			}
			set	
			{
				_errorCodeSamples = value;
				DictionaryUtil.Add(QueryParameters, "ErrorCodeSamples", value);
			}
		}

        public override CreateApiResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return CreateApiResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}