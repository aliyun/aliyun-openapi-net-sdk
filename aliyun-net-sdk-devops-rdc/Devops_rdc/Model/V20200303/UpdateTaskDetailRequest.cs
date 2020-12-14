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
    public class UpdateTaskDetailRequest : RpcAcsRequest<UpdateTaskDetailResponse>
    {
        public UpdateTaskDetailRequest()
            : base("devops-rdc", "2020-03-03", "UpdateTaskDetail")
        {
			Method = MethodType.POST;
        }

		private string note;

		private string executorId;

		private string startDate;

		private string delInvolvers;

		private string content;

		private string sprintId;

		private string customFieldId;

		private string projectId;

		private string taskId;

		private string taskFlowStatusId;

		private string tagIds;

		private string addInvolvers;

		private long? priority;

		private string orgId;

		private string dueDate;

		private long? workTimes;

		private string storyPoint;

		private string customFieldValues;

		public string Note
		{
			get
			{
				return note;
			}
			set	
			{
				note = value;
				DictionaryUtil.Add(BodyParameters, "Note", value);
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

		public string StartDate
		{
			get
			{
				return startDate;
			}
			set	
			{
				startDate = value;
				DictionaryUtil.Add(BodyParameters, "StartDate", value);
			}
		}

		public string DelInvolvers
		{
			get
			{
				return delInvolvers;
			}
			set	
			{
				delInvolvers = value;
				DictionaryUtil.Add(BodyParameters, "DelInvolvers", value);
			}
		}

		public string Content
		{
			get
			{
				return content;
			}
			set	
			{
				content = value;
				DictionaryUtil.Add(BodyParameters, "Content", value);
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

		public string CustomFieldId
		{
			get
			{
				return customFieldId;
			}
			set	
			{
				customFieldId = value;
				DictionaryUtil.Add(BodyParameters, "CustomFieldId", value);
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

		public string TaskId
		{
			get
			{
				return taskId;
			}
			set	
			{
				taskId = value;
				DictionaryUtil.Add(BodyParameters, "TaskId", value);
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

		public string TagIds
		{
			get
			{
				return tagIds;
			}
			set	
			{
				tagIds = value;
				DictionaryUtil.Add(BodyParameters, "TagIds", value);
			}
		}

		public string AddInvolvers
		{
			get
			{
				return addInvolvers;
			}
			set	
			{
				addInvolvers = value;
				DictionaryUtil.Add(BodyParameters, "AddInvolvers", value);
			}
		}

		public long? Priority
		{
			get
			{
				return priority;
			}
			set	
			{
				priority = value;
				DictionaryUtil.Add(BodyParameters, "Priority", value.ToString());
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

		public string DueDate
		{
			get
			{
				return dueDate;
			}
			set	
			{
				dueDate = value;
				DictionaryUtil.Add(BodyParameters, "DueDate", value);
			}
		}

		public long? WorkTimes
		{
			get
			{
				return workTimes;
			}
			set	
			{
				workTimes = value;
				DictionaryUtil.Add(BodyParameters, "WorkTimes", value.ToString());
			}
		}

		public string StoryPoint
		{
			get
			{
				return storyPoint;
			}
			set	
			{
				storyPoint = value;
				DictionaryUtil.Add(BodyParameters, "StoryPoint", value);
			}
		}

		public string CustomFieldValues
		{
			get
			{
				return customFieldValues;
			}
			set	
			{
				customFieldValues = value;
				DictionaryUtil.Add(BodyParameters, "CustomFieldValues", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override UpdateTaskDetailResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return UpdateTaskDetailResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
