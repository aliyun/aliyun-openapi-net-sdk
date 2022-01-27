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
using Aliyun.Acs.dataworks_public;
using Aliyun.Acs.dataworks_public.Transform;
using Aliyun.Acs.dataworks_public.Transform.V20200518;

namespace Aliyun.Acs.dataworks_public.Model.V20200518
{
    public class UpdateDataServiceApiRequest : RpcAcsRequest<UpdateDataServiceApiResponse>
    {
        public UpdateDataServiceApiRequest()
            : base("dataworks-public", "2020-05-18", "UpdateDataServiceApi")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.dataworks_public.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.dataworks_public.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string scriptDetails;

		private int? requestMethod;

		private string apiPath;

		private string wizardDetails;

		private int? visibleRange;

		private string apiDescription;

		private int? timeout;

		private string registrationDetails;

		private long? tenantId;

		private string protocols;

		private long? projectId;

		private long? apiId;

		private int? responseContentType;

		public string ScriptDetails
		{
			get
			{
				return scriptDetails;
			}
			set	
			{
				scriptDetails = value;
				DictionaryUtil.Add(BodyParameters, "ScriptDetails", value);
			}
		}

		public int? RequestMethod
		{
			get
			{
				return requestMethod;
			}
			set	
			{
				requestMethod = value;
				DictionaryUtil.Add(BodyParameters, "RequestMethod", value.ToString());
			}
		}

		public string ApiPath
		{
			get
			{
				return apiPath;
			}
			set	
			{
				apiPath = value;
				DictionaryUtil.Add(BodyParameters, "ApiPath", value);
			}
		}

		public string WizardDetails
		{
			get
			{
				return wizardDetails;
			}
			set	
			{
				wizardDetails = value;
				DictionaryUtil.Add(BodyParameters, "WizardDetails", value);
			}
		}

		public int? VisibleRange
		{
			get
			{
				return visibleRange;
			}
			set	
			{
				visibleRange = value;
				DictionaryUtil.Add(BodyParameters, "VisibleRange", value.ToString());
			}
		}

		public string ApiDescription
		{
			get
			{
				return apiDescription;
			}
			set	
			{
				apiDescription = value;
				DictionaryUtil.Add(BodyParameters, "ApiDescription", value);
			}
		}

		public int? Timeout
		{
			get
			{
				return timeout;
			}
			set	
			{
				timeout = value;
				DictionaryUtil.Add(BodyParameters, "Timeout", value.ToString());
			}
		}

		public string RegistrationDetails
		{
			get
			{
				return registrationDetails;
			}
			set	
			{
				registrationDetails = value;
				DictionaryUtil.Add(BodyParameters, "RegistrationDetails", value);
			}
		}

		public long? TenantId
		{
			get
			{
				return tenantId;
			}
			set	
			{
				tenantId = value;
				DictionaryUtil.Add(BodyParameters, "TenantId", value.ToString());
			}
		}

		public string Protocols
		{
			get
			{
				return protocols;
			}
			set	
			{
				protocols = value;
				DictionaryUtil.Add(BodyParameters, "Protocols", value);
			}
		}

		public long? ProjectId
		{
			get
			{
				return projectId;
			}
			set	
			{
				projectId = value;
				DictionaryUtil.Add(BodyParameters, "ProjectId", value.ToString());
			}
		}

		public long? ApiId
		{
			get
			{
				return apiId;
			}
			set	
			{
				apiId = value;
				DictionaryUtil.Add(BodyParameters, "ApiId", value.ToString());
			}
		}

		public int? ResponseContentType
		{
			get
			{
				return responseContentType;
			}
			set	
			{
				responseContentType = value;
				DictionaryUtil.Add(BodyParameters, "ResponseContentType", value.ToString());
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override UpdateDataServiceApiResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return UpdateDataServiceApiResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
