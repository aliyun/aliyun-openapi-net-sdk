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
using Aliyun.Acs.Cms.Transform;
using Aliyun.Acs.Cms.Transform.V20180308;

namespace Aliyun.Acs.Cms.Model.V20180308
{
    public class QueryMonitorDataRequest : RpcAcsRequest<QueryMonitorDataResponse>
    {
        public QueryMonitorDataRequest()
            : base("Cms", "2018-03-08", "QueryMonitorData", "cms", "openAPI")
        {
        }

		private string cursor;

		private string period;

		private int? length;

		private string endTime;

		private string startTime;

		private string type;

		private string metricName;

		private string taskId;

		public string Cursor
		{
			get
			{
				return cursor;
			}
			set	
			{
				cursor = value;
				DictionaryUtil.Add(QueryParameters, "Cursor", value);
			}
		}

		public string Period
		{
			get
			{
				return period;
			}
			set	
			{
				period = value;
				DictionaryUtil.Add(QueryParameters, "Period", value);
			}
		}

		public int? Length
		{
			get
			{
				return length;
			}
			set	
			{
				length = value;
				DictionaryUtil.Add(QueryParameters, "Length", value.ToString());
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

		public string MetricName
		{
			get
			{
				return metricName;
			}
			set	
			{
				metricName = value;
				DictionaryUtil.Add(QueryParameters, "metricName", value);
			}
		}

		public string TaskId
		{
			get
			{
				return taskId;
			}
			set	
			{
				taskId = value;
				DictionaryUtil.Add(QueryParameters, "TaskId", value);
			}
		}

        public override QueryMonitorDataResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return QueryMonitorDataResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
