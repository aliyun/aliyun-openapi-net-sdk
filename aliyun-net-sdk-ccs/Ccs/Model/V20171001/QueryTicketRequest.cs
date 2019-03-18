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
using Aliyun.Acs.Ccs.Transform;
using Aliyun.Acs.Ccs.Transform.V20171001;

namespace Aliyun.Acs.Ccs.Model.V20171001
{
    public class QueryTicketRequest : RpcAcsRequest<QueryTicketResponse>
    {
        public QueryTicketRequest()
            : base("Ccs", "2017-10-01", "QueryTicket", "ccs", "openAPI")
        {
        }

		private string stage;

		private int? pageSize;

		private string creatorId;

		private string endTime;

		private string startTime;

		private int? pageNum;

		private string type;

		private string ccsInstanceId;

		public string Stage
		{
			get
			{
				return stage;
			}
			set	
			{
				stage = value;
				DictionaryUtil.Add(QueryParameters, "Stage", value);
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

		public string CreatorId
		{
			get
			{
				return creatorId;
			}
			set	
			{
				creatorId = value;
				DictionaryUtil.Add(QueryParameters, "CreatorId", value);
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

		public string Type
		{
			get
			{
				return type;
			}
			set	
			{
				type = value;
				DictionaryUtil.Add(QueryParameters, "Type", value);
			}
		}

		public string CcsInstanceId
		{
			get
			{
				return ccsInstanceId;
			}
			set	
			{
				ccsInstanceId = value;
				DictionaryUtil.Add(QueryParameters, "CcsInstanceId", value);
			}
		}

        public override QueryTicketResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return QueryTicketResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
