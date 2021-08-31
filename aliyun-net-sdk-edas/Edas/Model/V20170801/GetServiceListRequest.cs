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
    public class GetServiceListRequest : RoaAcsRequest<GetServiceListResponse>
    {
        public GetServiceListRequest()
            : base("Edas", "2017-08-01", "GetServiceList", "Edas", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Edas.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Edas.Endpoint.endpointRegionalType, null);
            }
			UriPattern = "/pop/sp/api/mseForOam/getServiceList";
			Method = MethodType.POST;
        }

		private string serviceType;

		private string side;

		private string origin;

		private string searchType;

		private string _namespace;

		private string region;

		private string searchValue;

		public string ServiceType
		{
			get
			{
				return serviceType;
			}
			set	
			{
				serviceType = value;
				DictionaryUtil.Add(QueryParameters, "serviceType", value);
			}
		}

		public string Side
		{
			get
			{
				return side;
			}
			set	
			{
				side = value;
				DictionaryUtil.Add(QueryParameters, "side", value);
			}
		}

		public string Origin
		{
			get
			{
				return origin;
			}
			set	
			{
				origin = value;
				DictionaryUtil.Add(QueryParameters, "origin", value);
			}
		}

		public string SearchType
		{
			get
			{
				return searchType;
			}
			set	
			{
				searchType = value;
				DictionaryUtil.Add(QueryParameters, "searchType", value);
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
				DictionaryUtil.Add(QueryParameters, "namespace", value);
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
				DictionaryUtil.Add(QueryParameters, "region", value);
			}
		}

		public string SearchValue
		{
			get
			{
				return searchValue;
			}
			set	
			{
				searchValue = value;
				DictionaryUtil.Add(QueryParameters, "searchValue", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override GetServiceListResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return GetServiceListResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
