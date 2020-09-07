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
    public class ListExecutionsRequest : RpcAcsRequest<ListExecutionsResponse>
    {
        public ListExecutionsRequest()
            : base("oos", "2019-06-01", "ListExecutions", "oos", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string executedBy;

		private bool? includeChildExecution;

		private string mode;

		private string executionId;

		private string ramRole;

		private string nextToken;

		private string templateName;

		private string endDateBefore;

		private string sortOrder;

		private string resourceId;

		private string startDateAfter;

		private string startDateBefore;

		private Dictionary<object,object> tags;

		private string parentExecutionId;

		private string endDateAfter;

		private int? maxResults;

		private string sortField;

		private string category;

		private string resourceTemplateName;

		private string status;

		public string ExecutedBy
		{
			get
			{
				return executedBy;
			}
			set	
			{
				executedBy = value;
				DictionaryUtil.Add(QueryParameters, "ExecutedBy", value);
			}
		}

		public bool? IncludeChildExecution
		{
			get
			{
				return includeChildExecution;
			}
			set	
			{
				includeChildExecution = value;
				DictionaryUtil.Add(QueryParameters, "IncludeChildExecution", value.ToString());
			}
		}

		public string Mode
		{
			get
			{
				return mode;
			}
			set	
			{
				mode = value;
				DictionaryUtil.Add(QueryParameters, "Mode", value);
			}
		}

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

		public string RamRole
		{
			get
			{
				return ramRole;
			}
			set	
			{
				ramRole = value;
				DictionaryUtil.Add(QueryParameters, "RamRole", value);
			}
		}

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

		public string TemplateName
		{
			get
			{
				return templateName;
			}
			set	
			{
				templateName = value;
				DictionaryUtil.Add(QueryParameters, "TemplateName", value);
			}
		}

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

		public string ResourceId
		{
			get
			{
				return resourceId;
			}
			set	
			{
				resourceId = value;
				DictionaryUtil.Add(QueryParameters, "ResourceId", value);
			}
		}

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

		public Dictionary<object,object> Tags
		{
			get
			{
				return tags;
			}
			set	
			{
				tags = value;
				DictionaryUtil.Add(QueryParameters, "Tags", JsonConvert.SerializeObject(value));
			}
		}

		public string ParentExecutionId
		{
			get
			{
				return parentExecutionId;
			}
			set	
			{
				parentExecutionId = value;
				DictionaryUtil.Add(QueryParameters, "ParentExecutionId", value);
			}
		}

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

		public string Category
		{
			get
			{
				return category;
			}
			set	
			{
				category = value;
				DictionaryUtil.Add(QueryParameters, "Category", value);
			}
		}

		public string ResourceTemplateName
		{
			get
			{
				return resourceTemplateName;
			}
			set	
			{
				resourceTemplateName = value;
				DictionaryUtil.Add(QueryParameters, "ResourceTemplateName", value);
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

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override ListExecutionsResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ListExecutionsResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
