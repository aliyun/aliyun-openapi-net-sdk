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
using Aliyun.Acs.companyreg.Transform;
using Aliyun.Acs.companyreg.Transform.V20190508;

namespace Aliyun.Acs.companyreg.Model.V20190508
{
    public class QueryTradeIntentionUserListRequest : RpcAcsRequest<QueryTradeIntentionUserListResponse>
    {
        public QueryTradeIntentionUserListRequest()
            : base("companyreg", "2019-05-08", "QueryTradeIntentionUserList", "companyreg", "openAPI")
        {
        }

		private int? area;

		private int? pageNum;

		private int? type;

		private int? pageSize;

		private string bizId;

		private long? end;

		private long? begin;

		private int? status;

		public int? Area
		{
			get
			{
				return area;
			}
			set	
			{
				area = value;
				DictionaryUtil.Add(QueryParameters, "Area", value.ToString());
			}
		}

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

		public int? Type
		{
			get
			{
				return type;
			}
			set	
			{
				type = value;
				DictionaryUtil.Add(QueryParameters, "Type", value.ToString());
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

		public string BizId
		{
			get
			{
				return bizId;
			}
			set	
			{
				bizId = value;
				DictionaryUtil.Add(QueryParameters, "BizId", value);
			}
		}

		public long? End
		{
			get
			{
				return end;
			}
			set	
			{
				end = value;
				DictionaryUtil.Add(QueryParameters, "End", value.ToString());
			}
		}

		public long? Begin
		{
			get
			{
				return begin;
			}
			set	
			{
				begin = value;
				DictionaryUtil.Add(QueryParameters, "Begin", value.ToString());
			}
		}

		public int? Status
		{
			get
			{
				return status;
			}
			set	
			{
				status = value;
				DictionaryUtil.Add(QueryParameters, "Status", value.ToString());
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override QueryTradeIntentionUserListResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return QueryTradeIntentionUserListResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
