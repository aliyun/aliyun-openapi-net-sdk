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
using Aliyun.Acs.sae.Transform;
using Aliyun.Acs.sae.Transform.V20190506;

namespace Aliyun.Acs.sae.Model.V20190506
{
    public class CreateIngressRequest : RoaAcsRequest<CreateIngressResponse>
    {
        public CreateIngressRequest()
            : base("sae", "2019-05-06", "CreateIngress", "serverless", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.sae.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.sae.Endpoint.endpointRegionalType, null);
            }
			UriPattern = "/pop/v1/sam/ingress/Ingress";
			Method = MethodType.POST;
        }

		private int? listenerPort;

		private string slbId;

		private string namespaceId;

		private string description;

		private string rules;

		private string certId;

		private string defaultRule;

		public int? ListenerPort
		{
			get
			{
				return listenerPort;
			}
			set	
			{
				listenerPort = value;
				DictionaryUtil.Add(QueryParameters, "ListenerPort", value.ToString());
			}
		}

		public string SlbId
		{
			get
			{
				return slbId;
			}
			set	
			{
				slbId = value;
				DictionaryUtil.Add(QueryParameters, "SlbId", value);
			}
		}

		public string NamespaceId
		{
			get
			{
				return namespaceId;
			}
			set	
			{
				namespaceId = value;
				DictionaryUtil.Add(QueryParameters, "NamespaceId", value);
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

		public string Rules
		{
			get
			{
				return rules;
			}
			set	
			{
				rules = value;
				DictionaryUtil.Add(BodyParameters, "Rules", value);
			}
		}

		public string CertId
		{
			get
			{
				return certId;
			}
			set	
			{
				certId = value;
				DictionaryUtil.Add(QueryParameters, "CertId", value);
			}
		}

		public string DefaultRule
		{
			get
			{
				return defaultRule;
			}
			set	
			{
				defaultRule = value;
				DictionaryUtil.Add(QueryParameters, "DefaultRule", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override CreateIngressResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateIngressResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
