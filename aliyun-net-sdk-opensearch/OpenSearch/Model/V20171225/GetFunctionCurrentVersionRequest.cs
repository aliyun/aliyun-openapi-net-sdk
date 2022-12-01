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
    public class GetFunctionCurrentVersionRequest : RoaAcsRequest<GetFunctionCurrentVersionResponse>
    {
        public GetFunctionCurrentVersionRequest()
            : base("OpenSearch", "2017-12-25", "GetFunctionCurrentVersion")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.OpenSearch.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.OpenSearch.Endpoint.endpointRegionalType, null);
            }
			UriPattern = "/v4/openapi/functions/[functionName]/current-version";
			Method = MethodType.GET;
        }

		private string modelType;

		private string functionName;

		private string domain;

		private string functionType;

		private string category;

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

		public string Domain
		{
			get
			{
				return domain;
			}
			set	
			{
				domain = value;
				DictionaryUtil.Add(QueryParameters, "domain", value);
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

		public string Category
		{
			get
			{
				return category;
			}
			set	
			{
				category = value;
				DictionaryUtil.Add(QueryParameters, "category", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override GetFunctionCurrentVersionResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return GetFunctionCurrentVersionResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
