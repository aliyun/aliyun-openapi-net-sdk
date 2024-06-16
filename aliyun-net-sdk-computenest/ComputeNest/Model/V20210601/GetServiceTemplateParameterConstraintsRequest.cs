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
using Aliyun.Acs.ComputeNest.Transform;
using Aliyun.Acs.ComputeNest.Transform.V20210601;

namespace Aliyun.Acs.ComputeNest.Model.V20210601
{
    public class GetServiceTemplateParameterConstraintsRequest : RpcAcsRequest<GetServiceTemplateParameterConstraintsResponse>
    {
        public GetServiceTemplateParameterConstraintsRequest()
            : base("ComputeNest", "2021-06-01", "GetServiceTemplateParameterConstraints", "computenest", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.ComputeNest.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.ComputeNest.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string clientToken;

		private bool? enablePrivateVpcConnection;

		private string templateName;

		private string serviceInstanceId;

		private string deployRegionId;

		private string specificationName;

		private string trialType;

		private string serviceVersion;

		private string serviceId;

		private List<string> parameterss = new List<string>(){ };

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

		public bool? EnablePrivateVpcConnection
		{
			get
			{
				return enablePrivateVpcConnection;
			}
			set	
			{
				enablePrivateVpcConnection = value;
				DictionaryUtil.Add(QueryParameters, "EnablePrivateVpcConnection", value.ToString());
			}
		}

		public string TemplateName
		{
			get
			{
				return templateName;
			}
			set	
			{
				templateName = value;
				DictionaryUtil.Add(QueryParameters, "TemplateName", value);
			}
		}

		public string ServiceInstanceId
		{
			get
			{
				return serviceInstanceId;
			}
			set	
			{
				serviceInstanceId = value;
				DictionaryUtil.Add(QueryParameters, "ServiceInstanceId", value);
			}
		}

		public string DeployRegionId
		{
			get
			{
				return deployRegionId;
			}
			set	
			{
				deployRegionId = value;
				DictionaryUtil.Add(QueryParameters, "DeployRegionId", value);
			}
		}

		public string SpecificationName
		{
			get
			{
				return specificationName;
			}
			set	
			{
				specificationName = value;
				DictionaryUtil.Add(QueryParameters, "SpecificationName", value);
			}
		}

		public string TrialType
		{
			get
			{
				return trialType;
			}
			set	
			{
				trialType = value;
				DictionaryUtil.Add(QueryParameters, "TrialType", value);
			}
		}

		public string ServiceVersion
		{
			get
			{
				return serviceVersion;
			}
			set	
			{
				serviceVersion = value;
				DictionaryUtil.Add(QueryParameters, "ServiceVersion", value);
			}
		}

		public string ServiceId
		{
			get
			{
				return serviceId;
			}
			set	
			{
				serviceId = value;
				DictionaryUtil.Add(QueryParameters, "ServiceId", value);
			}
		}

		public List<string> Parameterss
		{
			get
			{
				return parameterss;
			}

			set
			{
				parameterss = value;
				if(parameterss != null)
				{
					for (int depth1 = 0; depth1 < parameterss.Count; depth1++)
					{
						DictionaryUtil.Add(QueryParameters,"Parameters." + (depth1 + 1), parameterss[depth1]);
						DictionaryUtil.Add(QueryParameters,"Parameters." + (depth1 + 1), parameterss[depth1]);
					}
				}
			}
		}

		public class Parameters
		{

			private string parameterValue;

			private string parameterKey;

			public string ParameterValue
			{
				get
				{
					return parameterValue;
				}
				set	
				{
					parameterValue = value;
				}
			}

			public string ParameterKey
			{
				get
				{
					return parameterKey;
				}
				set	
				{
					parameterKey = value;
				}
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override GetServiceTemplateParameterConstraintsResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return GetServiceTemplateParameterConstraintsResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
