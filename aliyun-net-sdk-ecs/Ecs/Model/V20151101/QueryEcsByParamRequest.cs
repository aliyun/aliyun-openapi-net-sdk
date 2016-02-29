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
using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.Ecs.Transform;
using Aliyun.Acs.Ecs.Transform.V20151101;
using System.Collections.Generic;

namespace Aliyun.Acs.Ecs.Model.V20151101
{
    public class QueryEcsByParamRequest : RpcAcsRequest<QueryEcsByParamResponse>
    {
        public QueryEcsByParamRequest()
            : base("Ecs", "2015-11-01", "QueryEcsByParam")
        {
        }

		private string queryEcsParam;

		private int? pageNo;

		private int? pageSize;

		public string QueryEcsParam
		{
			get
			{
				return queryEcsParam;
			}
			set	
			{
				queryEcsParam = value;
				DictionaryUtil.Add(QueryParameters, "QueryEcsParam", value);
			}
		}

		public int? PageNo
		{
			get
			{
				return pageNo;
			}
			set	
			{
				pageNo = value;
				DictionaryUtil.Add(QueryParameters, "PageNo", value.ToString());
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

        public override QueryEcsByParamResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return QueryEcsByParamResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}