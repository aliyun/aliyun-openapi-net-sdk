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
using Aliyun.Acs.OpenSearch;
using Aliyun.Acs.OpenSearch.Transform;
using Aliyun.Acs.OpenSearch.Transform.V20171225;

namespace Aliyun.Acs.OpenSearch.Model.V20171225
{
    public class ListAppsRequest : RoaAcsRequest<ListAppsResponse>
    {
        public ListAppsRequest()
            : base("OpenSearch", "2017-12-25", "ListApps")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.OpenSearch.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.OpenSearch.Endpoint.endpointRegionalType, null);
            }
			UriPattern = "/v4/openapi/apps";
			Method = MethodType.GET;
        }

		private int? size;

		private int? page;

		private bool? group;

		public int? Size
		{
			get
			{
				return size;
			}
			set	
			{
				size = value;
				DictionaryUtil.Add(QueryParameters, "size", value.ToString());
			}
		}

		public int? Page
		{
			get
			{
				return page;
			}
			set	
			{
				page = value;
				DictionaryUtil.Add(QueryParameters, "page", value.ToString());
			}
		}

		public bool? Group
		{
			get
			{
				return group;
			}
			set	
			{
				group = value;
				DictionaryUtil.Add(QueryParameters, "group", value.ToString());
			}
		}

        public override ListAppsResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ListAppsResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
