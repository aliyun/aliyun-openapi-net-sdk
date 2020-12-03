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
using Aliyun.Acs.dataworks_public.Model.V20200518;

namespace Aliyun.Acs.dataworks_public.Transform.V20200518
{
    public class ListProjectsResponseUnmarshaller
    {
        public static ListProjectsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListProjectsResponse listProjectsResponse = new ListProjectsResponse();

			listProjectsResponse.HttpResponse = _ctx.HttpResponse;
			listProjectsResponse.RequestId = _ctx.StringValue("ListProjects.RequestId");

			ListProjectsResponse.ListProjects_PageResult pageResult = new ListProjectsResponse.ListProjects_PageResult();
			pageResult.PageNumber = _ctx.IntegerValue("ListProjects.PageResult.PageNumber");
			pageResult.PageSize = _ctx.IntegerValue("ListProjects.PageResult.PageSize");
			pageResult.TotalCount = _ctx.IntegerValue("ListProjects.PageResult.TotalCount");

			List<ListProjectsResponse.ListProjects_PageResult.ListProjects_Project> pageResult_projectList = new List<ListProjectsResponse.ListProjects_PageResult.ListProjects_Project>();
			for (int i = 0; i < _ctx.Length("ListProjects.PageResult.ProjectList.Length"); i++) {
				ListProjectsResponse.ListProjects_PageResult.ListProjects_Project project = new ListProjectsResponse.ListProjects_PageResult.ListProjects_Project();
				project.ProjectName = _ctx.StringValue("ListProjects.PageResult.ProjectList["+ i +"].ProjectName");
				project.ProjectIdentifier = _ctx.StringValue("ListProjects.PageResult.ProjectList["+ i +"].ProjectIdentifier");
				project.ProjectDescription = _ctx.StringValue("ListProjects.PageResult.ProjectList["+ i +"].ProjectDescription");
				project.ProjectStatus = _ctx.IntegerValue("ListProjects.PageResult.ProjectList["+ i +"].ProjectStatus");
				project.ProjectId = _ctx.LongValue("ListProjects.PageResult.ProjectList["+ i +"].ProjectId");
				project.ProjectOwnerBaseId = _ctx.StringValue("ListProjects.PageResult.ProjectList["+ i +"].ProjectOwnerBaseId");
				project.ProjectStatusCode = _ctx.StringValue("ListProjects.PageResult.ProjectList["+ i +"].ProjectStatusCode");

				pageResult_projectList.Add(project);
			}
			pageResult.ProjectList = pageResult_projectList;
			listProjectsResponse.PageResult = pageResult;
        
			return listProjectsResponse;
        }
    }
}
