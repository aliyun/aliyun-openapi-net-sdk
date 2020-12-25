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
using Aliyun.Acs.Emr.Model.V20160408;

namespace Aliyun.Acs.Emr.Transform.V20160408
{
    public class ListFlowProjectResponseUnmarshaller
    {
        public static ListFlowProjectResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListFlowProjectResponse listFlowProjectResponse = new ListFlowProjectResponse();

			listFlowProjectResponse.HttpResponse = _ctx.HttpResponse;
			listFlowProjectResponse.RequestId = _ctx.StringValue("ListFlowProject.RequestId");
			listFlowProjectResponse.PageNumber = _ctx.IntegerValue("ListFlowProject.PageNumber");
			listFlowProjectResponse.PageSize = _ctx.IntegerValue("ListFlowProject.PageSize");
			listFlowProjectResponse.Total = _ctx.IntegerValue("ListFlowProject.Total");

			List<ListFlowProjectResponse.ListFlowProject_Project> listFlowProjectResponse_projects = new List<ListFlowProjectResponse.ListFlowProject_Project>();
			for (int i = 0; i < _ctx.Length("ListFlowProject.Projects.Length"); i++) {
				ListFlowProjectResponse.ListFlowProject_Project project = new ListFlowProjectResponse.ListFlowProject_Project();
				project.Id = _ctx.StringValue("ListFlowProject.Projects["+ i +"].Id");
				project.GmtCreate = _ctx.LongValue("ListFlowProject.Projects["+ i +"].GmtCreate");
				project.GmtModified = _ctx.LongValue("ListFlowProject.Projects["+ i +"].GmtModified");
				project.UserId = _ctx.StringValue("ListFlowProject.Projects["+ i +"].UserId");
				project.Name = _ctx.StringValue("ListFlowProject.Projects["+ i +"].Name");
				project.Description = _ctx.StringValue("ListFlowProject.Projects["+ i +"].Description");

				listFlowProjectResponse_projects.Add(project);
			}
			listFlowProjectResponse.Projects = listFlowProjectResponse_projects;
        
			return listFlowProjectResponse;
        }
    }
}
