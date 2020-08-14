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
using Aliyun.Acs.teambition_aliyun.Model.V20200226;

namespace Aliyun.Acs.teambition_aliyun.Transform.V20200226
{
    public class ListProjectSprintsResponseUnmarshaller
    {
        public static ListProjectSprintsResponse Unmarshall(UnmarshallerContext context)
        {
			ListProjectSprintsResponse listProjectSprintsResponse = new ListProjectSprintsResponse();

			listProjectSprintsResponse.HttpResponse = context.HttpResponse;
			listProjectSprintsResponse.Successful = context.BooleanValue("ListProjectSprints.Successful");
			listProjectSprintsResponse.ErrorCode = context.StringValue("ListProjectSprints.ErrorCode");
			listProjectSprintsResponse.ErrorMsg = context.StringValue("ListProjectSprints.ErrorMsg");
			listProjectSprintsResponse.RequestId = context.StringValue("ListProjectSprints.RequestId");

			List<ListProjectSprintsResponse.ListProjectSprints_Sprint> listProjectSprintsResponse_object = new List<ListProjectSprintsResponse.ListProjectSprints_Sprint>();
			for (int i = 0; i < context.Length("ListProjectSprints.Object.Length"); i++) {
				ListProjectSprintsResponse.ListProjectSprints_Sprint sprint = new ListProjectSprintsResponse.ListProjectSprints_Sprint();
				sprint.Accomplished = context.StringValue("ListProjectSprints.Object["+ i +"].Accomplished");
				sprint.IsDeleted = context.BooleanValue("ListProjectSprints.Object["+ i +"].IsDeleted");
				sprint.Created = context.StringValue("ListProjectSprints.Object["+ i +"].Created");
				sprint.DueDate = context.StringValue("ListProjectSprints.Object["+ i +"].DueDate");
				sprint.Name = context.StringValue("ListProjectSprints.Object["+ i +"].Name");
				sprint.CreatorId = context.StringValue("ListProjectSprints.Object["+ i +"].CreatorId");
				sprint.Id = context.StringValue("ListProjectSprints.Object["+ i +"].Id");
				sprint.Updated = context.StringValue("ListProjectSprints.Object["+ i +"].Updated");
				sprint.StartDate = context.StringValue("ListProjectSprints.Object["+ i +"].StartDate");
				sprint.Status = context.StringValue("ListProjectSprints.Object["+ i +"].Status");
				sprint.ProjectId = context.StringValue("ListProjectSprints.Object["+ i +"].ProjectId");

				ListProjectSprintsResponse.ListProjectSprints_Sprint.ListProjectSprints_PlanToDo planToDo = new ListProjectSprintsResponse.ListProjectSprints_Sprint.ListProjectSprints_PlanToDo();
				planToDo.StoryPoints = context.IntegerValue("ListProjectSprints.Object["+ i +"].PlanToDo.StoryPoints");
				planToDo.WorkTimes = context.IntegerValue("ListProjectSprints.Object["+ i +"].PlanToDo.WorkTimes");
				planToDo.Tasks = context.IntegerValue("ListProjectSprints.Object["+ i +"].PlanToDo.Tasks");
				sprint.PlanToDo = planToDo;

				listProjectSprintsResponse_object.Add(sprint);
			}
			listProjectSprintsResponse._Object = listProjectSprintsResponse_object;
        
			return listProjectSprintsResponse;
        }
    }
}
