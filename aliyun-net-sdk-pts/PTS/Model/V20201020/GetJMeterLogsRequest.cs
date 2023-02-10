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
using Aliyun.Acs.PTS;
using Aliyun.Acs.PTS.Transform;
using Aliyun.Acs.PTS.Transform.V20201020;

namespace Aliyun.Acs.PTS.Model.V20201020
{
    public class GetJMeterLogsRequest : RpcAcsRequest<GetJMeterLogsResponse>
    {
        public GetJMeterLogsRequest()
            : base("PTS", "2020-10-20", "GetJMeterLogs")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.PTS.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.PTS.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private int? agentIndex;

		private string reportId;

		private string level;

		private long? endTime;

		private long? beginTime;

		private string thread;

		private int? pageNumber;

		private int? pageSize;

		private string keyword;

		public int? AgentIndex
		{
			get
			{
				return agentIndex;
			}
			set	
			{
				agentIndex = value;
				DictionaryUtil.Add(QueryParameters, "AgentIndex", value.ToString());
			}
		}

		public string ReportId
		{
			get
			{
				return reportId;
			}
			set	
			{
				reportId = value;
				DictionaryUtil.Add(QueryParameters, "ReportId", value);
			}
		}

		public string Level
		{
			get
			{
				return level;
			}
			set	
			{
				level = value;
				DictionaryUtil.Add(QueryParameters, "Level", value);
			}
		}

		public long? EndTime
		{
			get
			{
				return endTime;
			}
			set	
			{
				endTime = value;
				DictionaryUtil.Add(QueryParameters, "EndTime", value.ToString());
			}
		}

		public long? BeginTime
		{
			get
			{
				return beginTime;
			}
			set	
			{
				beginTime = value;
				DictionaryUtil.Add(QueryParameters, "BeginTime", value.ToString());
			}
		}

		public string Thread
		{
			get
			{
				return thread;
			}
			set	
			{
				thread = value;
				DictionaryUtil.Add(QueryParameters, "Thread", value);
			}
		}

		public int? PageNumber
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

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override GetJMeterLogsResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return GetJMeterLogsResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
