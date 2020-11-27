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
        public static ListDevopsProjectSprintsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListDevopsProjectSprintsResponse listDevopsProjectSprintsResponse = new ListDevopsProjectSprintsResponse();

			listDevopsProjectSprintsResponse.HttpResponse = _ctx.HttpResponse;
			listDevopsProjectSprintsResponse.Successful = _ctx.BooleanValue("ListDevopsProjectSprints.Successful");
			listDevopsProjectSprintsResponse.ErrorCode = _ctx.StringValue("ListDevopsProjectSprints.ErrorCode");
			listDevopsProjectSprintsResponse.ErrorMsg = _ctx.StringValue("ListDevopsProjectSprints.ErrorMsg");
			listDevopsProjectSprintsResponse.RequestId = _ctx.StringValue("ListDevopsProjectSprints.RequestId");

			List<ListDevopsProjectSprintsResponse.ListDevopsProjectSprints_Sprint> listDevopsProjectSprintsResponse_object = new List<ListDevopsProjectSprintsResponse.ListDevopsProjectSprints_Sprint>();
			for (int i = 0; i < _ctx.Length("ListDevopsProjectSprints.Object.Length"); i++) {
				ListDevopsProjectSprintsResponse.ListDevopsProjectSprints_Sprint sprint = new ListDevopsProjectSprintsResponse.ListDevopsProjectSprints_Sprint();
				sprint.Accomplished = _ctx.StringValue("ListDevopsProjectSprints.Object["+ i +"].Accomplished");
				sprint.IsDeleted = _ctx.BooleanValue("ListDevopsProjectSprints.Object["+ i +"].IsDeleted");
				sprint.Created = _ctx.StringValue("ListDevopsProjectSprints.Object["+ i +"].Created");
				sprint.DueDate = _ctx.StringValue("ListDevopsProjectSprints.Object["+ i +"].DueDate");
				sprint.Name = _ctx.StringValue("ListDevopsProjectSprints.Object["+ i +"].Name");
				sprint.CreatorId = _ctx.StringValue("ListDevopsProjectSprints.Object["+ i +"].CreatorId");
				sprint.Id = _ctx.StringValue("ListDevopsProjectSprints.Object["+ i +"].Id");
				sprint.Updated = _ctx.StringValue("ListDevopsProjectSprints.Object["+ i +"].Updated");
				sprint.StartDate = _ctx.StringValue("ListDevopsProjectSprints.Object["+ i +"].StartDate");
				sprint.Status = _ctx.StringValue("ListDevopsProjectSprints.Object["+ i +"].Status");
				sprint.ProjectId = _ctx.StringValue("ListDevopsProjectSprints.Object["+ i +"].ProjectId");

				ListDevopsProjectSprintsResponse.ListDevopsProjectSprints_Sprint.ListDevopsProjectSprints_PlanToDo planToDo = new ListDevopsProjectSprintsResponse.ListDevopsProjectSprints_Sprint.ListDevopsProjectSprints_PlanToDo();
				planToDo.StoryPoints = _ctx.IntegerValue("ListDevopsProjectSprints.Object["+ i +"].PlanToDo.StoryPoints");
				planToDo.WorkTimes = _ctx.IntegerValue("ListDevopsProjectSprints.Object["+ i +"].PlanToDo.WorkTimes");
				planToDo.Tasks = _ctx.IntegerValue("ListDevopsProjectSprints.Object["+ i +"].PlanToDo.Tasks");
				sprint.PlanToDo = planToDo;

				listDevopsProjectSprintsResponse_object.Add(sprint);
			}
			listDevopsProjectSprintsResponse._Object = listDevopsProjectSprintsResponse_object;
        
			return listDevopsProjectSprintsResponse;
        }
    }
}
