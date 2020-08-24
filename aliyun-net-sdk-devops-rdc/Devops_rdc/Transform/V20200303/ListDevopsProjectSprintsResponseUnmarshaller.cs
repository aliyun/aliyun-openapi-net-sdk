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
using System;
using System.Collections.Generic;

using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.devops_rdc.Model.V20200303;

namespace Aliyun.Acs.devops_rdc.Transform.V20200303
{
    public class ListDevopsProjectSprintsResponseUnmarshaller
    {
        public static ListDevopsProjectSprintsResponse Unmarshall(UnmarshallerContext context)
        {
			ListDevopsProjectSprintsResponse listDevopsProjectSprintsResponse = new ListDevopsProjectSprintsResponse();

			listDevopsProjectSprintsResponse.HttpResponse = context.HttpResponse;
			listDevopsProjectSprintsResponse.Successful = context.BooleanValue("ListDevopsProjectSprints.Successful");
			listDevopsProjectSprintsResponse.ErrorCode = context.StringValue("ListDevopsProjectSprints.ErrorCode");
			listDevopsProjectSprintsResponse.ErrorMsg = context.StringValue("ListDevopsProjectSprints.ErrorMsg");
			listDevopsProjectSprintsResponse.RequestId = context.StringValue("ListDevopsProjectSprints.RequestId");

			List<ListDevopsProjectSprintsResponse.ListDevopsProjectSprints_Sprint> listDevopsProjectSprintsResponse_object = new List<ListDevopsProjectSprintsResponse.ListDevopsProjectSprints_Sprint>();
			for (int i = 0; i < context.Length("ListDevopsProjectSprints.Object.Length"); i++) {
				ListDevopsProjectSprintsResponse.ListDevopsProjectSprints_Sprint sprint = new ListDevopsProjectSprintsResponse.ListDevopsProjectSprints_Sprint();
				sprint.Accomplished = context.StringValue("ListDevopsProjectSprints.Object["+ i +"].Accomplished");
				sprint.IsDeleted = context.BooleanValue("ListDevopsProjectSprints.Object["+ i +"].IsDeleted");
				sprint.Created = context.StringValue("ListDevopsProjectSprints.Object["+ i +"].Created");
				sprint.DueDate = context.StringValue("ListDevopsProjectSprints.Object["+ i +"].DueDate");
				sprint.Name = context.StringValue("ListDevopsProjectSprints.Object["+ i +"].Name");
				sprint.CreatorId = context.StringValue("ListDevopsProjectSprints.Object["+ i +"].CreatorId");
				sprint.Id = context.StringValue("ListDevopsProjectSprints.Object["+ i +"].Id");
				sprint.Updated = context.StringValue("ListDevopsProjectSprints.Object["+ i +"].Updated");
				sprint.StartDate = context.StringValue("ListDevopsProjectSprints.Object["+ i +"].StartDate");
				sprint.Status = context.StringValue("ListDevopsProjectSprints.Object["+ i +"].Status");
				sprint.ProjectId = context.StringValue("ListDevopsProjectSprints.Object["+ i +"].ProjectId");

				ListDevopsProjectSprintsResponse.ListDevopsProjectSprints_Sprint.ListDevopsProjectSprints_PlanToDo planToDo = new ListDevopsProjectSprintsResponse.ListDevopsProjectSprints_Sprint.ListDevopsProjectSprints_PlanToDo();
				planToDo.StoryPoints = context.IntegerValue("ListDevopsProjectSprints.Object["+ i +"].PlanToDo.StoryPoints");
				planToDo.WorkTimes = context.IntegerValue("ListDevopsProjectSprints.Object["+ i +"].PlanToDo.WorkTimes");
				planToDo.Tasks = context.IntegerValue("ListDevopsProjectSprints.Object["+ i +"].PlanToDo.Tasks");
				sprint.PlanToDo = planToDo;

				listDevopsProjectSprintsResponse_object.Add(sprint);
			}
			listDevopsProjectSprintsResponse._Object = listDevopsProjectSprintsResponse_object;
        
			return listDevopsProjectSprintsResponse;
        }
    }
}
