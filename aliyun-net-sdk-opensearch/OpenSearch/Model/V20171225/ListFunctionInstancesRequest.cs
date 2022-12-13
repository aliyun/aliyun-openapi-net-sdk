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
    public class ListFunctionInstancesRequest : RoaAcsRequest<ListFunctionInstancesResponse>
    {
        public ListFunctionInstancesRequest()
            : base("OpenSearch", "2017-12-25", "ListFunctionInstances")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.OpenSearch.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.OpenSearch.Endpoint.endpointRegionalType, null);
            }
			UriPattern = "/v4/openapi/app-groups/[appGroupIdentity]/functions/[functionName]/instances";
			Method = MethodType.GET;
        }

		private string output;

		private string modelType;

		private string functionName;

		private int? pageSize;

		private string functionType;

		private string source;

		private string appGroupIdentity;

		private int? pageNumber;

		public string Output
		{
			get
			{
				return output;
			}
			set	
			{
				output = value;
				DictionaryUtil.Add(QueryParameters, "output", value);
			}
		}

		public string ModelType
		{
			get
			{
				return modelType;
			}
			set	
			{
				modelType = value;
				DictionaryUtil.Add(QueryParameters, "modelType", value);
			}
		}

		public string FunctionName
		{
			get
			{
				return functionName;
			}
			set	
			{
				functionName = value;
				DictionaryUtil.Add(PathParameters, "functionName", value);
			}
		}

		public int? PageSize
		{
			get
			{
				return pageSize;
			}
			set	
			{
				pageSize = value;
				DictionaryUtil.Add(QueryParameters, "pageSize", value.ToString());
			}
		}

		public string FunctionType
		{
			get
			{
				return functionType;
			}
			set	
			{
				functionType = value;
				DictionaryUtil.Add(QueryParameters, "functionType", value);
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
				DictionaryUtil.Add(QueryParameters, "source", value);
			}
		}

		public string AppGroupIdentity
		{
			get
			{
				return appGroupIdentity;
			}
			set	
			{
				appGroupIdentity = value;
				DictionaryUtil.Add(PathParameters, "appGroupIdentity", value);
			}
		}

		public int? PageNumber
		{
			get
			{
				return pageNumber;
			}
			set	
			{
				pageNumber = value;
				DictionaryUtil.Add(QueryParameters, "pageNumber", value.ToString());
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override ListFunctionInstancesResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ListFunctionInstancesResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
