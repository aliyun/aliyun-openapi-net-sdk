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
using Aliyun.Acs.viapi.Transform;
using Aliyun.Acs.viapi.Transform.V20230117;

namespace Aliyun.Acs.viapi.Model.V20230117
{
    public class QueryAsyncJobListRequest : RpcAcsRequest<QueryAsyncJobListResponse>
    {
        public QueryAsyncJobListRequest()
            : base("viapi", "2023-01-17", "QueryAsyncJobList", "viapi", "openAPI")
        {
			Method = MethodType.POST;
        }

		private string startTime;

		private string pageNum;

		private string jobId;

		private string popApiName;

		private string pageSize;

		private string popProduct;

		private string endTime;

		private string status;

		public string StartTime
		{
			get
			{
				return startTime;
			}
			set	
			{
				startTime = value;
				DictionaryUtil.Add(BodyParameters, "StartTime", value);
			}
		}

		public string PageNum
		{
			get
			{
				return pageNum;
			}
			set	
			{
				pageNum = value;
				DictionaryUtil.Add(BodyParameters, "PageNum", value);
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
				DictionaryUtil.Add(BodyParameters, "JobId", value);
			}
		}

		public string PopApiName
		{
			get
			{
				return popApiName;
			}
			set	
			{
				popApiName = value;
				DictionaryUtil.Add(BodyParameters, "PopApiName", value);
			}
		}

		public string PageSize
		{
			get
			{
				return pageSize;
			}
			set	
			{
				pageSize = value;
				DictionaryUtil.Add(BodyParameters, "PageSize", value);
			}
		}

		public string PopProduct
		{
			get
			{
				return popProduct;
			}
			set	
			{
				popProduct = value;
				DictionaryUtil.Add(BodyParameters, "PopProduct", value);
			}
		}

		public string EndTime
		{
			get
			{
				return endTime;
			}
			set	
			{
				endTime = value;
				DictionaryUtil.Add(BodyParameters, "EndTime", value);
			}
		}

		public string Status
		{
			get
			{
				return status;
			}
			set	
			{
				status = value;
				DictionaryUtil.Add(BodyParameters, "Status", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override QueryAsyncJobListResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return QueryAsyncJobListResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
