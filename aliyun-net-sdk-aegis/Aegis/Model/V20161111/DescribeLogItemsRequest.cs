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
    public class DescribeLogItemsRequest : RpcAcsRequest<DescribeLogItemsResponse>
    {
        public DescribeLogItemsRequest()
            : base("aegis", "2016-11-11", "DescribeLogItems", "vipaegis", "openAPI")
        {
        }

		private int? loginOffset;

		private int? processSnapshotOffset;

		private int? portSnapshotOffset;

		private string query;

		private string endTime;

		private string currentPage;

		private int? networkOffset;

		private string startTime;

		private int? accountSnapshotOffset;

		private int? processOffset;

		private string sourceIp;

		private int? crackOffset;

		private string pageSize;

		public int? LoginOffset
		{
			get
			{
				return loginOffset;
			}
			set	
			{
				loginOffset = value;
				DictionaryUtil.Add(QueryParameters, "LoginOffset", value.ToString());
			}
		}

		public int? ProcessSnapshotOffset
		{
			get
			{
				return processSnapshotOffset;
			}
			set	
			{
				processSnapshotOffset = value;
				DictionaryUtil.Add(QueryParameters, "ProcessSnapshotOffset", value.ToString());
			}
		}

		public int? PortSnapshotOffset
		{
			get
			{
				return portSnapshotOffset;
			}
			set	
			{
				portSnapshotOffset = value;
				DictionaryUtil.Add(QueryParameters, "PortSnapshotOffset", value.ToString());
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

		public string EndTime
		{
			get
			{
				return endTime;
			}
			set	
			{
				endTime = value;
				DictionaryUtil.Add(QueryParameters, "EndTime", value);
			}
		}

		public string CurrentPage
		{
			get
			{
				return currentPage;
			}
			set	
			{
				currentPage = value;
				DictionaryUtil.Add(QueryParameters, "CurrentPage", value);
			}
		}

		public int? NetworkOffset
		{
			get
			{
				return networkOffset;
			}
			set	
			{
				networkOffset = value;
				DictionaryUtil.Add(QueryParameters, "NetworkOffset", value.ToString());
			}
		}

		public string StartTime
		{
			get
			{
				return startTime;
			}
			set	
			{
				startTime = value;
				DictionaryUtil.Add(QueryParameters, "StartTime", value);
			}
		}

		public int? AccountSnapshotOffset
		{
			get
			{
				return accountSnapshotOffset;
			}
			set	
			{
				accountSnapshotOffset = value;
				DictionaryUtil.Add(QueryParameters, "AccountSnapshotOffset", value.ToString());
			}
		}

		public int? ProcessOffset
		{
			get
			{
				return processOffset;
			}
			set	
			{
				processOffset = value;
				DictionaryUtil.Add(QueryParameters, "ProcessOffset", value.ToString());
			}
		}

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

		public int? CrackOffset
		{
			get
			{
				return crackOffset;
			}
			set	
			{
				crackOffset = value;
				DictionaryUtil.Add(QueryParameters, "CrackOffset", value.ToString());
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

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override DescribeLogItemsResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DescribeLogItemsResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
