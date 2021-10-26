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
using Aliyun.Acs.quickbi_public.Transform;
using Aliyun.Acs.quickbi_public.Transform.V20200730;

namespace Aliyun.Acs.quickbi_public.Model.V20200730
{
    public class QueryDataServiceRequest : RpcAcsRequest<QueryDataServiceResponse>
    {
        public QueryDataServiceRequest()
            : base("quickbi-public", "2020-07-30", "QueryDataService", "quickbi", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.quickbi_public.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.quickbi_public.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string returnFields;

		private string conditions;

		private string apiId;

		public string ReturnFields
		{
			get
			{
				return returnFields;
			}
			set	
			{
				returnFields = value;
				DictionaryUtil.Add(QueryParameters, "ReturnFields", value);
			}
		}

		public string Conditions
		{
			get
			{
				return conditions;
			}
			set	
			{
				conditions = value;
				DictionaryUtil.Add(QueryParameters, "Conditions", value);
			}
		}

		public string ApiId
		{
			get
			{
				return apiId;
			}
			set	
			{
				apiId = value;
				DictionaryUtil.Add(QueryParameters, "ApiId", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override QueryDataServiceResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return QueryDataServiceResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
