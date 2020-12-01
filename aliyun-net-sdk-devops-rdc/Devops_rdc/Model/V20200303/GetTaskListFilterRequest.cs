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
using Aliyun.Acs.devops_rdc;
using Aliyun.Acs.devops_rdc.Transform;
using Aliyun.Acs.devops_rdc.Transform.V20200303;

namespace Aliyun.Acs.devops_rdc.Model.V20200303
{
    public class GetTaskListFilterRequest : RpcAcsRequest<GetTaskListFilterResponse>
    {
        public GetTaskListFilterRequest()
            : base("devops-rdc", "2020-03-03", "GetTaskListFilter")
        {
			Method = MethodType.POST;
        }

		private string involveMembers;

		private string executorId;

		private string orderCondition;

		private string sprintId;

		private string extra;

		private int? pageSize;

		private string scenarioFieldConfigId;

		private bool? isDone;

		private string objectType;

		private string projectId;

		private string pageToken;

		private string order;

		private string tagId;

		private string taskFlowStatusId;

		private string dueDateStart;

		private string creatorId;

		private string priority;

		private string dueDateEnd;

		private string orgId;

		private string name;

		public string InvolveMembers
		{
			get
			{
				return involveMembers;
			}
			set	
			{
				involveMembers = value;
				DictionaryUtil.Add(BodyParameters, "InvolveMembers", value);
			}
		}

		public string ExecutorId
		{
			get
			{
				return executorId;
			}
			set	
			{
				executorId = value;
				DictionaryUtil.Add(BodyParameters, "ExecutorId", value);
			}
		}

		public string OrderCondition
		{
			get
			{
				return orderCondition;
			}
			set	
			{
				orderCondition = value;
				DictionaryUtil.Add(BodyParameters, "OrderCondition", value);
			}
		}

		public string SprintId
		{
			get
			{
				return sprintId;
			}
			set	
			{
				sprintId = value;
				DictionaryUtil.Add(BodyParameters, "SprintId", value);
			}
		}

		public string Extra
		{
			get
			{
				return extra;
			}
			set	
			{
				extra = value;
				DictionaryUtil.Add(BodyParameters, "Extra", value);
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
				DictionaryUtil.Add(BodyParameters, "PageSize", value.ToString());
			}
		}

		public string ScenarioFieldConfigId
		{
			get
			{
				return scenarioFieldConfigId;
			}
			set	
			{
				scenarioFieldConfigId = value;
				DictionaryUtil.Add(BodyParameters, "ScenarioFieldConfigId", value);
			}
		}

		public bool? IsDone
		{
			get
			{
				return isDone;
			}
			set	
			{
				isDone = value;
				DictionaryUtil.Add(BodyParameters, "IsDone", value.ToString());
			}
		}

		public string ObjectType
		{
			get
			{
				return objectType;
			}
			set	
			{
				objectType = value;
				DictionaryUtil.Add(BodyParameters, "ObjectType", value);
			}
		}

		public string ProjectId
		{
			get
			{
				return projectId;
			}
			set	
			{
				projectId = value;
				DictionaryUtil.Add(BodyParameters, "ProjectId", value);
			}
		}

		public string PageToken
		{
			get
			{
				return pageToken;
			}
			set	
			{
				pageToken = value;
				DictionaryUtil.Add(BodyParameters, "PageToken", value);
			}
		}

		public string Order
		{
			get
			{
				return order;
			}
			set	
			{
				order = value;
				DictionaryUtil.Add(BodyParameters, "Order", value);
			}
		}

		public string TagId
		{
			get
			{
				return tagId;
			}
			set	
			{
				tagId = value;
				DictionaryUtil.Add(BodyParameters, "TagId", value);
			}
		}

		public string TaskFlowStatusId
		{
			get
			{
				return taskFlowStatusId;
			}
			set	
			{
				taskFlowStatusId = value;
				DictionaryUtil.Add(BodyParameters, "TaskFlowStatusId", value);
			}
		}

		public string DueDateStart
		{
			get
			{
				return dueDateStart;
			}
			set	
			{
				dueDateStart = value;
				DictionaryUtil.Add(BodyParameters, "DueDateStart", value);
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
				DictionaryUtil.Add(BodyParameters, "CreatorId", value);
			}
		}

		public string Priority
		{
			get
			{
				return priority;
			}
			set	
			{
				priority = value;
				DictionaryUtil.Add(BodyParameters, "Priority", value);
			}
		}

		public string DueDateEnd
		{
			get
			{
				return dueDateEnd;
			}
			set	
			{
				dueDateEnd = value;
				DictionaryUtil.Add(BodyParameters, "DueDateEnd", value);
			}
		}

		public string OrgId
		{
			get
			{
				return orgId;
			}
			set	
			{
				orgId = value;
				DictionaryUtil.Add(BodyParameters, "OrgId", value);
			}
		}

		public string Name
		{
			get
			{
				return name;
			}
			set	
			{
				name = value;
				DictionaryUtil.Add(BodyParameters, "Name", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override GetTaskListFilterResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return GetTaskListFilterResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
