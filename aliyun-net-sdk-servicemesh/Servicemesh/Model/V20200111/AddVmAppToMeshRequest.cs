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
using Aliyun.Acs.servicemesh.Transform;
using Aliyun.Acs.servicemesh.Transform.V20200111;

namespace Aliyun.Acs.servicemesh.Model.V20200111
{
    public class AddVmAppToMeshRequest : RpcAcsRequest<AddVmAppToMeshResponse>
    {
        public AddVmAppToMeshRequest()
            : base("servicemesh", "2020-01-11", "AddVmAppToMesh", "servicemesh", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.servicemesh.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.servicemesh.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string serviceAccount;

		private string annotations;

		private string ports;

		private string serviceMeshId;

		private string serviceName;

		private string ips;

		private string labels;

		private string _namespace;

		private bool? force;

		public string ServiceAccount
		{
			get
			{
				return serviceAccount;
			}
			set	
			{
				serviceAccount = value;
				DictionaryUtil.Add(QueryParameters, "ServiceAccount", value);
			}
		}

		public string Annotations
		{
			get
			{
				return annotations;
			}
			set	
			{
				annotations = value;
				DictionaryUtil.Add(QueryParameters, "Annotations", value);
			}
		}

		public string Ports
		{
			get
			{
				return ports;
			}
			set	
			{
				ports = value;
				DictionaryUtil.Add(QueryParameters, "Ports", value);
			}
		}

		public string ServiceMeshId
		{
			get
			{
				return serviceMeshId;
			}
			set	
			{
				serviceMeshId = value;
				DictionaryUtil.Add(QueryParameters, "ServiceMeshId", value);
			}
		}

		public string ServiceName
		{
			get
			{
				return serviceName;
			}
			set	
			{
				serviceName = value;
				DictionaryUtil.Add(QueryParameters, "ServiceName", value);
			}
		}

		public string Ips
		{
			get
			{
				return ips;
			}
			set	
			{
				ips = value;
				DictionaryUtil.Add(QueryParameters, "Ips", value);
			}
		}

		public string Labels
		{
			get
			{
				return labels;
			}
			set	
			{
				labels = value;
				DictionaryUtil.Add(QueryParameters, "Labels", value);
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
				DictionaryUtil.Add(QueryParameters, "Namespace", value);
			}
		}

		public bool? Force
		{
			get
			{
				return force;
			}
			set	
			{
				force = value;
				DictionaryUtil.Add(QueryParameters, "Force", value.ToString());
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override AddVmAppToMeshResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return AddVmAppToMeshResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
