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
using Aliyun.Acs.Ccs.Transform;
using Aliyun.Acs.Ccs.Transform.V20171001;
using System.Collections.Generic;

namespace Aliyun.Acs.Ccs.Model.V20171001
{
    public class QueryHotlineRecordRequest : RpcAcsRequest<QueryHotlineRecordResponse>
    {
        public QueryHotlineRecordRequest()
            : base("Ccs", "2017-10-01", "QueryHotlineRecord", "ccs", "openAPI")
        {
        }

		private string agentId;

		private long? maxTalkDuration;

		private string groupId;

		private string endTime;

		private string startTime;

		private int? pageNum;

		private string satisfaction;

		private long? minTalkDuratoin;

		private string categoryIds;

		private string visitorProvince;

		private int? pageSize;

		private string callType;

		private string ccsInstanceId;

		private string visitorPhone;

		private string visitorId;

		private string status;

		public string AgentId
		{
			get
			{
				return agentId;
			}
			set	
			{
				agentId = value;
				DictionaryUtil.Add(QueryParameters, "AgentId", value);
			}
		}

		public long? MaxTalkDuration
		{
			get
			{
				return maxTalkDuration;
			}
			set	
			{
				maxTalkDuration = value;
				DictionaryUtil.Add(QueryParameters, "MaxTalkDuration", value.ToString());
			}
		}

		public string GroupId
		{
			get
			{
				return groupId;
			}
			set	
			{
				groupId = value;
				DictionaryUtil.Add(QueryParameters, "GroupId", value);
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

		public string Satisfaction
		{
			get
			{
				return satisfaction;
			}
			set	
			{
				satisfaction = value;
				DictionaryUtil.Add(QueryParameters, "Satisfaction", value);
			}
		}

		public long? MinTalkDuratoin
		{
			get
			{
				return minTalkDuratoin;
			}
			set	
			{
				minTalkDuratoin = value;
				DictionaryUtil.Add(QueryParameters, "MinTalkDuratoin", value.ToString());
			}
		}

		public string CategoryIds
		{
			get
			{
				return categoryIds;
			}
			set	
			{
				categoryIds = value;
				DictionaryUtil.Add(QueryParameters, "CategoryIds", value);
			}
		}

		public string VisitorProvince
		{
			get
			{
				return visitorProvince;
			}
			set	
			{
				visitorProvince = value;
				DictionaryUtil.Add(QueryParameters, "VisitorProvince", value);
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

		public string CallType
		{
			get
			{
				return callType;
			}
			set	
			{
				callType = value;
				DictionaryUtil.Add(QueryParameters, "CallType", value);
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

		public string VisitorPhone
		{
			get
			{
				return visitorPhone;
			}
			set	
			{
				visitorPhone = value;
				DictionaryUtil.Add(QueryParameters, "VisitorPhone", value);
			}
		}

		public string VisitorId
		{
			get
			{
				return visitorId;
			}
			set	
			{
				visitorId = value;
				DictionaryUtil.Add(QueryParameters, "VisitorId", value);
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
				DictionaryUtil.Add(QueryParameters, "Status", value);
			}
		}

        public override QueryHotlineRecordResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return QueryHotlineRecordResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}