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
using Aliyun.Acs.Edas.Transform;
using Aliyun.Acs.Edas.Transform.V20170801;

namespace Aliyun.Acs.Edas.Model.V20170801
{
    public class BindK8sSlbRequest : RoaAcsRequest<BindK8sSlbResponse>
    {
        public BindK8sSlbRequest()
            : base("Edas", "2017-08-01", "BindK8sSlb", "Edas", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Edas.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Edas.Endpoint.endpointRegionalType, null);
            }
			UriPattern = "/pop/v5/k8s/acs/k8s_slb_binding";
			Method = MethodType.POST;
        }

		private string scheduler;

		private string servicePortInfos;

		private string slbId;

		private string slbProtocol;

		private string port;

		private string appId;

		private string specification;

		private string clusterId;

		private string type;

		private string targetPort;

		public string Scheduler
		{
			get
			{
				return scheduler;
			}
			set	
			{
				scheduler = value;
				DictionaryUtil.Add(QueryParameters, "Scheduler", value);
			}
		}

		public string ServicePortInfos
		{
			get
			{
				return servicePortInfos;
			}
			set	
			{
				servicePortInfos = value;
				DictionaryUtil.Add(QueryParameters, "ServicePortInfos", value);
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

		public string SlbProtocol
		{
			get
			{
				return slbProtocol;
			}
			set	
			{
				slbProtocol = value;
				DictionaryUtil.Add(QueryParameters, "SlbProtocol", value);
			}
		}

		public string Port
		{
			get
			{
				return port;
			}
			set	
			{
				port = value;
				DictionaryUtil.Add(QueryParameters, "Port", value);
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

		public string Specification
		{
			get
			{
				return specification;
			}
			set	
			{
				specification = value;
				DictionaryUtil.Add(QueryParameters, "Specification", value);
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

		public string Type
		{
			get
			{
				return type;
			}
			set	
			{
				type = value;
				DictionaryUtil.Add(QueryParameters, "Type", value);
			}
		}

		public string TargetPort
		{
			get
			{
				return targetPort;
			}
			set	
			{
				targetPort = value;
				DictionaryUtil.Add(QueryParameters, "TargetPort", value);
			}
		}

        public override BindK8sSlbResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return BindK8sSlbResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
