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
    public class ListRecentViewReportsRequest : RpcAcsRequest<ListRecentViewReportsResponse>
    {
        public ListRecentViewReportsRequest()
            : base("quickbi-public", "2022-01-01", "ListRecentViewReports", "2.2.0", "openAPI")
        {
			Method = MethodType.POST;
        }

		private int? offsetDay;

		private string userId;

		private int? pageSize;

		private string keyword;

		private string queryMode;

		private string treeType;

		public int? OffsetDay
		{
			get
			{
				return offsetDay;
			}
			set	
			{
				offsetDay = value;
				DictionaryUtil.Add(QueryParameters, "OffsetDay", value.ToString());
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

		public string QueryMode
		{
			get
			{
				return queryMode;
			}
			set	
			{
				queryMode = value;
				DictionaryUtil.Add(QueryParameters, "QueryMode", value);
			}
		}

		public string TreeType
		{
			get
			{
				return treeType;
			}
			set	
			{
				treeType = value;
				DictionaryUtil.Add(QueryParameters, "TreeType", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override ListRecentViewReportsResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ListRecentViewReportsResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
