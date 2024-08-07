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
using Aliyun.Acs.quickbi_public.Transform.V20220101;

namespace Aliyun.Acs.quickbi_public.Model.V20220101
{
    public class QueryDataRequest : RpcAcsRequest<QueryDataResponse>
    {
        public QueryDataRequest()
            : base("quickbi-public", "2022-01-01", "QueryData", "2.2.0", "openAPI")
        {
			Method = MethodType.POST;
        }

		private string returnFields;

		private string conditions;

		private string userId;

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

		public string UserId
		{
			get
			{
				return userId;
			}
			set	
			{
				userId = value;
				DictionaryUtil.Add(QueryParameters, "UserId", value);
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

        public override QueryDataResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return QueryDataResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
