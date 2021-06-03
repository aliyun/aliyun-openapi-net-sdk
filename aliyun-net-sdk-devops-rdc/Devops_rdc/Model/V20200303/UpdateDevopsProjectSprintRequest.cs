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
    public class UpdateDevopsProjectSprintRequest : RpcAcsRequest<UpdateDevopsProjectSprintResponse>
    {
        public UpdateDevopsProjectSprintRequest()
            : base("devops-rdc", "2020-03-03", "UpdateDevopsProjectSprint")
        {
			Method = MethodType.POST;
        }

		private string executorId;

		private string description;

		private string startDate;

		private string orgId;

		private string sprintId;

		private string dueDate;

		private string name;

		private string projectId;

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

		public string Description
		{
			get
			{
				return description;
			}
			set	
			{
				description = value;
				DictionaryUtil.Add(BodyParameters, "Description", value);
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

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override UpdateDevopsProjectSprintResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return UpdateDevopsProjectSprintResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
