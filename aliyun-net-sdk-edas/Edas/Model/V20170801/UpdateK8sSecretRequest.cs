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
using Aliyun.Acs.Edas.Transform;
using Aliyun.Acs.Edas.Transform.V20170801;

namespace Aliyun.Acs.Edas.Model.V20170801
{
    public class UpdateK8sSecretRequest : RoaAcsRequest<UpdateK8sSecretResponse>
    {
        public UpdateK8sSecretRequest()
            : base("Edas", "2017-08-01", "UpdateK8sSecret", "Edas", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Edas.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Edas.Endpoint.endpointRegionalType, null);
            }
			UriPattern = "/pop/v5/k8s/acs/k8s_secret";
			Method = MethodType.PUT;
        }

		private string data;

		private string name;

		private string _namespace;

		private string clusterId;

		private string certId;

		private string type;

		private string certRegionId;

		public string Data
		{
			get
			{
				return data;
			}
			set	
			{
				data = value;
				DictionaryUtil.Add(BodyParameters, "Data", value);
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
				DictionaryUtil.Add(BodyParameters, "Name", value);
			}
		}

		public string _Namespace
		{
			get
			{
				return _namespace;
			}
			set	
			{
				_namespace = value;
				DictionaryUtil.Add(BodyParameters, "Namespace", value);
			}
		}

		public string ClusterId
		{
			get
			{
				return clusterId;
			}
			set	
			{
				clusterId = value;
				DictionaryUtil.Add(BodyParameters, "ClusterId", value);
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
				DictionaryUtil.Add(BodyParameters, "CertId", value);
			}
		}

		public string Type
		{
			get
			{
				return type;
			}
			set	
			{
				type = value;
				DictionaryUtil.Add(BodyParameters, "Type", value);
			}
		}

		public string CertRegionId
		{
			get
			{
				return certRegionId;
			}
			set	
			{
				certRegionId = value;
				DictionaryUtil.Add(BodyParameters, "CertRegionId", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override UpdateK8sSecretResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return UpdateK8sSecretResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
