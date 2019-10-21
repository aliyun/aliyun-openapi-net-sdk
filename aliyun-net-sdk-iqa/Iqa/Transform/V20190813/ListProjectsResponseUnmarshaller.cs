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
using Aliyun.Acs.iqa.Model.V20190813;

namespace Aliyun.Acs.iqa.Transform.V20190813
{
    public class ListProjectsResponseUnmarshaller
    {
        public static ListProjectsResponse Unmarshall(UnmarshallerContext context)
        {
			ListProjectsResponse listProjectsResponse = new ListProjectsResponse();

			listProjectsResponse.HttpResponse = context.HttpResponse;
			listProjectsResponse.RequestId = context.StringValue("ListProjects.RequestId");
			listProjectsResponse.TotalCount = context.IntegerValue("ListProjects.TotalCount");
			listProjectsResponse.PageNumber = context.IntegerValue("ListProjects.PageNumber");
			listProjectsResponse.PageSize = context.IntegerValue("ListProjects.PageSize");

			List<ListProjectsResponse.ListProjects_Project> listProjectsResponse_projects = new List<ListProjectsResponse.ListProjects_Project>();
			for (int i = 0; i < context.Length("ListProjects.Projects.Length"); i++) {
				ListProjectsResponse.ListProjects_Project project = new ListProjectsResponse.ListProjects_Project();
				project.ProjectType = context.StringValue("ListProjects.Projects["+ i +"].ProjectType");
				project.ProjectId = context.StringValue("ListProjects.Projects["+ i +"].ProjectId");
				project.ProjectName = context.StringValue("ListProjects.Projects["+ i +"].ProjectName");
				project.CreateTime = context.LongValue("ListProjects.Projects["+ i +"].CreateTime");
				project.DeployTime = context.LongValue("ListProjects.Projects["+ i +"].DeployTime");
				project.ModelId = context.StringValue("ListProjects.Projects["+ i +"].ModelId");
				project.QuestionCount = context.IntegerValue("ListProjects.Projects["+ i +"].QuestionCount");
				project.DataStatus = context.StringValue("ListProjects.Projects["+ i +"].DataStatus");
				project.TestServiceStatus = context.StringValue("ListProjects.Projects["+ i +"].TestServiceStatus");
				project.OnlineServiceStatus = context.StringValue("ListProjects.Projects["+ i +"].OnlineServiceStatus");
				project.DeployAvailable = context.StringValue("ListProjects.Projects["+ i +"].DeployAvailable");
				project.ModelName = context.StringValue("ListProjects.Projects["+ i +"].ModelName");

				listProjectsResponse_projects.Add(project);
			}
			listProjectsResponse.Projects = listProjectsResponse_projects;
        
			return listProjectsResponse;
        }
    }
}
