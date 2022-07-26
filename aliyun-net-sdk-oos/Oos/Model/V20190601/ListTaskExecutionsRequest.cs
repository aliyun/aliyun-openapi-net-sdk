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
using Newtonsoft.Json;

using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.oos.Transform;
using Aliyun.Acs.oos.Transform.V20190601;

namespace Aliyun.Acs.oos.Model.V20190601
{
    public class ListTaskExecutionsRequest : RpcAcsRequest<ListTaskExecutionsResponse>
    {
        public ListTaskExecutionsRequest()
            : base("oos", "2019-06-01", "ListTaskExecutions", "oos", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.oos.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.oos.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string taskName;

		private bool? includeChildTaskExecution;

		private string executionId;

		private string parentTaskExecutionId;

		private string nextToken;

		private string endDateBefore;

		private string sortOrder;

		private string startDateAfter;

		private string startDateBefore;

		private string endDateAfter;

		private int? maxResults;

		private string taskExecutionId;

		private string sortField;

		private string taskAction;

		private string status;

		[JsonProperty(PropertyName = "TaskName")]
		public string TaskName
		{
			get
			{
				return taskName;
			}
			set	
			{
				taskName = value;
				DictionaryUtil.Add(QueryParameters, "TaskName", value);
			}
		}

		[JsonProperty(PropertyName = "IncludeChildTaskExecution")]
		public bool? IncludeChildTaskExecution
		{
			get
			{
				return includeChildTaskExecution;
			}
			set	
			{
				includeChildTaskExecution = value;
				DictionaryUtil.Add(QueryParameters, "IncludeChildTaskExecution", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "ExecutionId")]
		public string ExecutionId
		{
			get
			{
				return executionId;
			}
			set	
			{
				executionId = value;
				DictionaryUtil.Add(QueryParameters, "ExecutionId", value);
			}
		}

		[JsonProperty(PropertyName = "ParentTaskExecutionId")]
		public string ParentTaskExecutionId
		{
			get
			{
				return parentTaskExecutionId;
			}
			set	
			{
				parentTaskExecutionId = value;
				DictionaryUtil.Add(QueryParameters, "ParentTaskExecutionId", value);
			}
		}

		[JsonProperty(PropertyName = "NextToken")]
		public string NextToken
		{
			get
			{
				return nextToken;
			}
			set	
			{
				nextToken = value;
				DictionaryUtil.Add(QueryParameters, "NextToken", value);
			}
		}

		[JsonProperty(PropertyName = "EndDateBefore")]
		public string EndDateBefore
		{
			get
			{
				return endDateBefore;
			}
			set	
			{
				endDateBefore = value;
				DictionaryUtil.Add(QueryParameters, "EndDateBefore", value);
			}
		}

		[JsonProperty(PropertyName = "SortOrder")]
		public string SortOrder
		{
			get
			{
				return sortOrder;
			}
			set	
			{
				sortOrder = value;
				DictionaryUtil.Add(QueryParameters, "SortOrder", value);
			}
		}

		[JsonProperty(PropertyName = "StartDateAfter")]
		public string StartDateAfter
		{
			get
			{
				return startDateAfter;
			}
			set	
			{
				startDateAfter = value;
				DictionaryUtil.Add(QueryParameters, "StartDateAfter", value);
			}
		}

		[JsonProperty(PropertyName = "StartDateBefore")]
		public string StartDateBefore
		{
			get
			{
				return startDateBefore;
			}
			set	
			{
				startDateBefore = value;
				DictionaryUtil.Add(QueryParameters, "StartDateBefore", value);
			}
		}

		[JsonProperty(PropertyName = "EndDateAfter")]
		public string EndDateAfter
		{
			get
			{
				return endDateAfter;
			}
			set	
			{
				endDateAfter = value;
				DictionaryUtil.Add(QueryParameters, "EndDateAfter", value);
			}
		}

		[JsonProperty(PropertyName = "MaxResults")]
		public int? MaxResults
		{
			get
			{
				return maxResults;
			}
			set	
			{
				maxResults = value;
				DictionaryUtil.Add(QueryParameters, "MaxResults", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "TaskExecutionId")]
		public string TaskExecutionId
		{
			get
			{
				return taskExecutionId;
			}
			set	
			{
				taskExecutionId = value;
				DictionaryUtil.Add(QueryParameters, "TaskExecutionId", value);
			}
		}

		[JsonProperty(PropertyName = "SortField")]
		public string SortField
		{
			get
			{
				return sortField;
			}
			set	
			{
				sortField = value;
				DictionaryUtil.Add(QueryParameters, "SortField", value);
			}
		}

		[JsonProperty(PropertyName = "TaskAction")]
		public string TaskAction
		{
			get
			{
				return taskAction;
			}
			set	
			{
				taskAction = value;
				DictionaryUtil.Add(QueryParameters, "TaskAction", value);
			}
		}

		[JsonProperty(PropertyName = "Status")]
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

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override ListTaskExecutionsResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ListTaskExecutionsResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
