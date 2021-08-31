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
    public class AddServiceTimeConfigRequest : RoaAcsRequest<AddServiceTimeConfigResponse>
    {
        public AddServiceTimeConfigRequest()
            : base("Edas", "2017-08-01", "AddServiceTimeConfig", "Edas", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Edas.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Edas.Endpoint.endpointRegionalType, null);
            }
			UriPattern = "/pop/sp/api/timeout/add";
			Method = MethodType.POST;
        }

		private string path;

		private string serviceType;

		private string consumerAppId;

		private string appId;

		private string serviceVersion;

		private string _namespace;

		private string serviceName;

		private string source;

		private string region;

		private string serviceGroup;

		private string consumerAppName;

		private string timeout;

		public string Path
		{
			get
			{
				return path;
			}
			set	
			{
				path = value;
				DictionaryUtil.Add(QueryParameters, "Path", value);
			}
		}

		public string ServiceType
		{
			get
			{
				return serviceType;
			}
			set	
			{
				serviceType = value;
				DictionaryUtil.Add(QueryParameters, "ServiceType", value);
			}
		}

		public string ConsumerAppId
		{
			get
			{
				return consumerAppId;
			}
			set	
			{
				consumerAppId = value;
				DictionaryUtil.Add(QueryParameters, "ConsumerAppId", value);
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

		public string Source
		{
			get
			{
				return source;
			}
			set	
			{
				source = value;
				DictionaryUtil.Add(QueryParameters, "Source", value);
			}
		}

		public string Region
		{
			get
			{
				return region;
			}
			set	
			{
				region = value;
				DictionaryUtil.Add(QueryParameters, "Region", value);
			}
		}

		public string ServiceGroup
		{
			get
			{
				return serviceGroup;
			}
			set	
			{
				serviceGroup = value;
				DictionaryUtil.Add(QueryParameters, "ServiceGroup", value);
			}
		}

		public string ConsumerAppName
		{
			get
			{
				return consumerAppName;
			}
			set	
			{
				consumerAppName = value;
				DictionaryUtil.Add(QueryParameters, "ConsumerAppName", value);
			}
		}

		public string Timeout
		{
			get
			{
				return timeout;
			}
			set	
			{
				timeout = value;
				DictionaryUtil.Add(QueryParameters, "Timeout", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override AddServiceTimeConfigResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return AddServiceTimeConfigResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
