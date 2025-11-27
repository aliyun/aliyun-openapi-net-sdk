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
using Aliyun.Acs.Mts.Transform;
using Aliyun.Acs.Mts.Transform.V20140618;

namespace Aliyun.Acs.Mts.Model.V20140618
{
    public class QueryCopyrightJobRequest : RpcAcsRequest<QueryCopyrightJobResponse>
    {
        public QueryCopyrightJobRequest()
            : base("Mts", "2014-06-18", "QueryCopyrightJob", "mts", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Mts.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Mts.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private long? level;

		private long? pageNumber;

		private long? createTimeEnd;

		private string jobId;

		private long? pageSize;

		private long? createTimeStart;

		public long? Level
		{
			get
			{
				return level;
			}
			set	
			{
				level = value;
				DictionaryUtil.Add(QueryParameters, "Level", value.ToString());
			}
		}

		public long? PageNumber
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

		public long? CreateTimeEnd
		{
			get
			{
				return createTimeEnd;
			}
			set	
			{
				createTimeEnd = value;
				DictionaryUtil.Add(QueryParameters, "CreateTimeEnd", value.ToString());
			}
		}

		public string JobId
		{
			get
			{
				return jobId;
			}
			set	
			{
				jobId = value;
				DictionaryUtil.Add(QueryParameters, "JobId", value);
			}
		}

		public long? PageSize
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

		public long? CreateTimeStart
		{
			get
			{
				return createTimeStart;
			}
			set	
			{
				createTimeStart = value;
				DictionaryUtil.Add(QueryParameters, "CreateTimeStart", value.ToString());
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override QueryCopyrightJobResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return QueryCopyrightJobResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
