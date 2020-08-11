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
        public static ListProjectsResponse Unmarshall(UnmarshallerContext context)
        {
			ListProjectsResponse listProjectsResponse = new ListProjectsResponse();

			listProjectsResponse.HttpResponse = context.HttpResponse;
			listProjectsResponse.RequestId = context.StringValue("ListProjects.RequestId");

			ListProjectsResponse.ListProjects_PageResult pageResult = new ListProjectsResponse.ListProjects_PageResult();
			pageResult.PageNumber = context.IntegerValue("ListProjects.PageResult.PageNumber");
			pageResult.PageSize = context.IntegerValue("ListProjects.PageResult.PageSize");
			pageResult.TotalCount = context.IntegerValue("ListProjects.PageResult.TotalCount");

			List<ListProjectsResponse.ListProjects_PageResult.ListProjects_Project> pageResult_projectList = new List<ListProjectsResponse.ListProjects_PageResult.ListProjects_Project>();
			for (int i = 0; i < context.Length("ListProjects.PageResult.ProjectList.Length"); i++) {
				ListProjectsResponse.ListProjects_PageResult.ListProjects_Project project = new ListProjectsResponse.ListProjects_PageResult.ListProjects_Project();
				project.ProjectName = context.StringValue("ListProjects.PageResult.ProjectList["+ i +"].ProjectName");
				project.ProjectIdentifier = context.StringValue("ListProjects.PageResult.ProjectList["+ i +"].ProjectIdentifier");
				project.ProjectDescription = context.StringValue("ListProjects.PageResult.ProjectList["+ i +"].ProjectDescription");
				project.ProjectStatus = context.IntegerValue("ListProjects.PageResult.ProjectList["+ i +"].ProjectStatus");
				project.ProjectId = context.LongValue("ListProjects.PageResult.ProjectList["+ i +"].ProjectId");
				project.ProjectOwnerBaseId = context.StringValue("ListProjects.PageResult.ProjectList["+ i +"].ProjectOwnerBaseId");
				project.ProjectStatusCode = context.StringValue("ListProjects.PageResult.ProjectList["+ i +"].ProjectStatusCode");

				pageResult_projectList.Add(project);
			}
			pageResult.ProjectList = pageResult_projectList;
			listProjectsResponse.PageResult = pageResult;
        
			return listProjectsResponse;
        }
    }
}
