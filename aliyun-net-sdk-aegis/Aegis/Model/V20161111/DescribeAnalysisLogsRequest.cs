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
using Aliyun.Acs.aegis.Transform;
using Aliyun.Acs.aegis.Transform.V20161111;

namespace Aliyun.Acs.aegis.Model.V20161111
{
    public class DescribeAnalysisLogsRequest : RpcAcsRequest<DescribeAnalysisLogsResponse>
    {
        public DescribeAnalysisLogsRequest()
            : base("aegis", "2016-11-11", "DescribeAnalysisLogs", "vipaegis", "openAPI")
        {
        }

		private string sourceIp;

		private string query;

		private int? pageSize;

		private int? from;

		private int? currentPage;

		private int? to;

		private bool? reverse;

		public string SourceIp
		{
			get
			{
				return sourceIp;
			}
			set	
			{
				sourceIp = value;
				DictionaryUtil.Add(QueryParameters, "SourceIp", value);
			}
		}

		public string Query
		{
			get
			{
				return query;
			}
			set	
			{
				query = value;
				DictionaryUtil.Add(QueryParameters, "Query", value);
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

		public int? From
		{
			get
			{
				return from;
			}
			set	
			{
				from = value;
				DictionaryUtil.Add(QueryParameters, "From", value.ToString());
			}
		}

		public int? CurrentPage
		{
			get
			{
				return currentPage;
			}
			set	
			{
				currentPage = value;
				DictionaryUtil.Add(QueryParameters, "CurrentPage", value.ToString());
			}
		}

		public int? To
		{
			get
			{
				return to;
			}
			set	
			{
				to = value;
				DictionaryUtil.Add(QueryParameters, "To", value.ToString());
			}
		}

		public bool? Reverse
		{
			get
			{
				return reverse;
			}
			set	
			{
				reverse = value;
				DictionaryUtil.Add(QueryParameters, "Reverse", value.ToString());
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override DescribeAnalysisLogsResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DescribeAnalysisLogsResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
