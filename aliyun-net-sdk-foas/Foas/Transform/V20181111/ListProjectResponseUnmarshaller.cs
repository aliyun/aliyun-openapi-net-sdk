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
using Aliyun.Acs.foas.Model.V20181111;

namespace Aliyun.Acs.foas.Transform.V20181111
{
    public class ListProjectResponseUnmarshaller
    {
        public static ListProjectResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListProjectResponse listProjectResponse = new ListProjectResponse();

			listProjectResponse.HttpResponse = _ctx.HttpResponse;
			listProjectResponse.RequestId = _ctx.StringValue("ListProject.RequestId");
			listProjectResponse.PageIndex = _ctx.IntegerValue("ListProject.PageIndex");
			listProjectResponse.PageSize = _ctx.IntegerValue("ListProject.PageSize");
			listProjectResponse.TotalPage = _ctx.IntegerValue("ListProject.TotalPage");
			listProjectResponse.TotalCount = _ctx.LongValue("ListProject.TotalCount");

			List<ListProjectResponse.ListProject_Project> listProjectResponse_projects = new List<ListProjectResponse.ListProject_Project>();
			for (int i = 0; i < _ctx.Length("ListProject.Projects.Length"); i++) {
				ListProjectResponse.ListProject_Project project = new ListProjectResponse.ListProject_Project();
				project.Name = _ctx.StringValue("ListProject.Projects["+ i +"].Name");
				project.State = _ctx.StringValue("ListProject.Projects["+ i +"].State");
				project.Creator = _ctx.StringValue("ListProject.Projects["+ i +"].Creator");
				project.CreateTime = _ctx.LongValue("ListProject.Projects["+ i +"].CreateTime");
				project.Modifier = _ctx.StringValue("ListProject.Projects["+ i +"].Modifier");
				project.ModifyTime = _ctx.LongValue("ListProject.Projects["+ i +"].ModifyTime");
				project.Description = _ctx.StringValue("ListProject.Projects["+ i +"].Description");
				project.DeployType = _ctx.StringValue("ListProject.Projects["+ i +"].DeployType");
				project.ClusterId = _ctx.StringValue("ListProject.Projects["+ i +"].ClusterId");
				project.ManagerIds = _ctx.StringValue("ListProject.Projects["+ i +"].ManagerIds");
				project.Region = _ctx.StringValue("ListProject.Projects["+ i +"].Region");
				project.Id = _ctx.StringValue("ListProject.Projects["+ i +"].Id");

				listProjectResponse_projects.Add(project);
			}
			listProjectResponse.Projects = listProjectResponse_projects;
        
			return listProjectResponse;
        }
    }
}
