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
    public class UpdateK8sApplicationConfigRequest : RoaAcsRequest<UpdateK8sApplicationConfigResponse>
    {
        public UpdateK8sApplicationConfigRequest()
            : base("Edas", "2017-08-01", "UpdateK8sApplicationConfig", "Edas", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Edas.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Edas.Endpoint.endpointRegionalType, null);
            }
			UriPattern = "/pop/v5/k8s/acs/k8s_app_configuration";
			Method = MethodType.PUT;
        }

		private string memoryRequest;

		private string appId;

		private string cpuRequest;

		private string memoryLimit;

		private string clusterId;

		private string cpuLimit;

		private string mcpuLimit;

		private string mcpuRequest;

		private int? timeout;

		public string MemoryRequest
		{
			get
			{
				return memoryRequest;
			}
			set	
			{
				memoryRequest = value;
				DictionaryUtil.Add(QueryParameters, "MemoryRequest", value);
			}
		}

		public string AppId
		{
			get
			{
				return appId;
			}
			set	
			{
				appId = value;
				DictionaryUtil.Add(QueryParameters, "AppId", value);
			}
		}

		public string CpuRequest
		{
			get
			{
				return cpuRequest;
			}
			set	
			{
				cpuRequest = value;
				DictionaryUtil.Add(QueryParameters, "CpuRequest", value);
			}
		}

		public string MemoryLimit
		{
			get
			{
				return memoryLimit;
			}
			set	
			{
				memoryLimit = value;
				DictionaryUtil.Add(QueryParameters, "MemoryLimit", value);
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
				DictionaryUtil.Add(QueryParameters, "ClusterId", value);
			}
		}

		public string CpuLimit
		{
			get
			{
				return cpuLimit;
			}
			set	
			{
				cpuLimit = value;
				DictionaryUtil.Add(QueryParameters, "CpuLimit", value);
			}
		}

		public string McpuLimit
		{
			get
			{
				return mcpuLimit;
			}
			set	
			{
				mcpuLimit = value;
				DictionaryUtil.Add(QueryParameters, "McpuLimit", value);
			}
		}

		public string McpuRequest
		{
			get
			{
				return mcpuRequest;
			}
			set	
			{
				mcpuRequest = value;
				DictionaryUtil.Add(QueryParameters, "McpuRequest", value);
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
				DictionaryUtil.Add(QueryParameters, "Timeout", value.ToString());
			}
		}

        public override UpdateK8sApplicationConfigResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return UpdateK8sApplicationConfigResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
