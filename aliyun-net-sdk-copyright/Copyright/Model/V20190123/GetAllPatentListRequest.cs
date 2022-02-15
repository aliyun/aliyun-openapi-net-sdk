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
using Aliyun.Acs.Copyright;
using Aliyun.Acs.Copyright.Transform;
using Aliyun.Acs.Copyright.Transform.V20190123;

namespace Aliyun.Acs.Copyright.Model.V20190123
{
    public class GetAllPatentListRequest : RpcAcsRequest<GetAllPatentListResponse>
    {
        public GetAllPatentListRequest()
            : base("Copyright", "2019-01-23", "GetAllPatentList")
        {
			Method = MethodType.POST;
        }

		private int? pageNum;

		private long? startPayDate;

		private string patentStatus;

		private int? soldType;

		private long? endPayDate;

		private string pageSize;

		private string keyword;

		public int? PageNum
		{
			get
			{
				return pageNum;
			}
			set	
			{
				pageNum = value;
				DictionaryUtil.Add(QueryParameters, "PageNum", value.ToString());
			}
		}

		public long? StartPayDate
		{
			get
			{
				return startPayDate;
			}
			set	
			{
				startPayDate = value;
				DictionaryUtil.Add(QueryParameters, "StartPayDate", value.ToString());
			}
		}

		public string PatentStatus
		{
			get
			{
				return patentStatus;
			}
			set	
			{
				patentStatus = value;
				DictionaryUtil.Add(QueryParameters, "PatentStatus", value);
			}
		}

		public int? SoldType
		{
			get
			{
				return soldType;
			}
			set	
			{
				soldType = value;
				DictionaryUtil.Add(QueryParameters, "SoldType", value.ToString());
			}
		}

		public long? EndPayDate
		{
			get
			{
				return endPayDate;
			}
			set	
			{
				endPayDate = value;
				DictionaryUtil.Add(QueryParameters, "EndPayDate", value.ToString());
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
				DictionaryUtil.Add(QueryParameters, "PageSize", value);
			}
		}

		public string Keyword
		{
			get
			{
				return keyword;
			}
			set	
			{
				keyword = value;
				DictionaryUtil.Add(QueryParameters, "Keyword", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override GetAllPatentListResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return GetAllPatentListResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
