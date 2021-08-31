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
    public class ImportK8sClusterRequest : RoaAcsRequest<ImportK8sClusterResponse>
    {
        public ImportK8sClusterRequest()
            : base("Edas", "2017-08-01", "ImportK8sCluster", "Edas", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Edas.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Edas.Endpoint.endpointRegionalType, null);
            }
			UriPattern = "/pop/v5/import_k8s_cluster";
			Method = MethodType.POST;
        }

		private int? mode;

		private bool? enableAsm;

		private string namespaceId;

		private string clusterId;

		public int? Mode
		{
			get
			{
				return mode;
			}
			set	
			{
				mode = value;
				DictionaryUtil.Add(QueryParameters, "Mode", value.ToString());
			}
		}

		public bool? EnableAsm
		{
			get
			{
				return enableAsm;
			}
			set	
			{
				enableAsm = value;
				DictionaryUtil.Add(QueryParameters, "EnableAsm", value.ToString());
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

        public override ImportK8sClusterResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ImportK8sClusterResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
