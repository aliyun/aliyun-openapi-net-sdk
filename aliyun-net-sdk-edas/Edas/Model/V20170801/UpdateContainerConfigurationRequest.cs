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
    public class UpdateContainerConfigurationRequest : RoaAcsRequest<UpdateContainerConfigurationResponse>
    {
        public UpdateContainerConfigurationRequest()
            : base("Edas", "2017-08-01", "UpdateContainerConfiguration", "Edas", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Edas.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Edas.Endpoint.endpointRegionalType, null);
            }
			UriPattern = "/pop/v5/app/container_config";
			Method = MethodType.POST;
        }

		private bool? useBodyEncoding;

		private int? maxThreads;

		private string uRIEncoding;

		private string appId;

		private string groupId;

		private int? httpPort;

		private string contextPath;

		public bool? UseBodyEncoding
		{
			get
			{
				return useBodyEncoding;
			}
			set	
			{
				useBodyEncoding = value;
				DictionaryUtil.Add(QueryParameters, "UseBodyEncoding", value.ToString());
			}
		}

		public int? MaxThreads
		{
			get
			{
				return maxThreads;
			}
			set	
			{
				maxThreads = value;
				DictionaryUtil.Add(QueryParameters, "MaxThreads", value.ToString());
			}
		}

		public string URIEncoding
		{
			get
			{
				return uRIEncoding;
			}
			set	
			{
				uRIEncoding = value;
				DictionaryUtil.Add(QueryParameters, "URIEncoding", value);
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

		public int? HttpPort
		{
			get
			{
				return httpPort;
			}
			set	
			{
				httpPort = value;
				DictionaryUtil.Add(QueryParameters, "HttpPort", value.ToString());
			}
		}

		public string ContextPath
		{
			get
			{
				return contextPath;
			}
			set	
			{
				contextPath = value;
				DictionaryUtil.Add(QueryParameters, "ContextPath", value);
			}
		}

        public override UpdateContainerConfigurationResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return UpdateContainerConfigurationResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
