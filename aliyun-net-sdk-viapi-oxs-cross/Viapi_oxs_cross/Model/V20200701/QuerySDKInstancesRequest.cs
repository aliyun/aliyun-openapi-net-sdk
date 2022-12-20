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
using Aliyun.Acs.viapi_oxs_cross;
using Aliyun.Acs.viapi_oxs_cross.Transform;
using Aliyun.Acs.viapi_oxs_cross.Transform.V20200701;

namespace Aliyun.Acs.viapi_oxs_cross.Model.V20200701
{
    public class QuerySDKInstancesRequest : RpcAcsRequest<QuerySDKInstancesResponse>
    {
        public QuerySDKInstancesRequest()
            : base("viapi-oxs-cross", "2020-07-01", "QuerySDKInstances")
        {
			Method = MethodType.POST;
        }

		private string codeList;

		private int? pageNumber;

		private string createdBeforeDate;

		private string createdAfterDate;

		private int? pageSize;

		private string pk;

		public string CodeList
		{
			get
			{
				return codeList;
			}
			set	
			{
				codeList = value;
				DictionaryUtil.Add(QueryParameters, "CodeList", value);
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
				DictionaryUtil.Add(QueryParameters, "PageNumber", value.ToString());
			}
		}

		public string CreatedBeforeDate
		{
			get
			{
				return createdBeforeDate;
			}
			set	
			{
				createdBeforeDate = value;
				DictionaryUtil.Add(QueryParameters, "CreatedBeforeDate", value);
			}
		}

		public string CreatedAfterDate
		{
			get
			{
				return createdAfterDate;
			}
			set	
			{
				createdAfterDate = value;
				DictionaryUtil.Add(QueryParameters, "CreatedAfterDate", value);
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
				DictionaryUtil.Add(QueryParameters, "PageSize", value.ToString());
			}
		}

		public string Pk
		{
			get
			{
				return pk;
			}
			set	
			{
				pk = value;
				DictionaryUtil.Add(QueryParameters, "Pk", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override QuerySDKInstancesResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return QuerySDKInstancesResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
