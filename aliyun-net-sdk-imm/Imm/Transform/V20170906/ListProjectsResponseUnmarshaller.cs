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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.imm.Model.V20170906;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.imm.Transform.V20170906
{
    public class ListProjectsResponseUnmarshaller
    {
        public static ListProjectsResponse Unmarshall(UnmarshallerContext context)
        {
			ListProjectsResponse listProjectsResponse = new ListProjectsResponse();

			listProjectsResponse.HttpResponse = context.HttpResponse;
			listProjectsResponse.RequestId = context.StringValue("ListProjects.RequestId");
			listProjectsResponse.NextMarker = context.StringValue("ListProjects.NextMarker");

			List<ListProjectsResponse.ListProjects_ProjectsItem> listProjectsResponse_projects = new List<ListProjectsResponse.ListProjects_ProjectsItem>();
			for (int i = 0; i < context.Length("ListProjects.Projects.Length"); i++) {
				ListProjectsResponse.ListProjects_ProjectsItem projectsItem = new ListProjectsResponse.ListProjects_ProjectsItem();
				projectsItem.Project = context.StringValue("ListProjects.Projects["+ i +"].Project");
				projectsItem.Endpoint = context.StringValue("ListProjects.Projects["+ i +"].Endpoint");
				projectsItem.ServiceRole = context.StringValue("ListProjects.Projects["+ i +"].ServiceRole");
				projectsItem.CreateTime = context.StringValue("ListProjects.Projects["+ i +"].CreateTime");
				projectsItem.ModifyTime = context.StringValue("ListProjects.Projects["+ i +"].ModifyTime");
				projectsItem.CU = context.IntegerValue("ListProjects.Projects["+ i +"].CU");
				projectsItem.Type = context.StringValue("ListProjects.Projects["+ i +"].Type");

				List<ListProjectsResponse.ListProjects_ProjectsItem.ListProjects_EnginesItem> projectsItem_engines = new List<ListProjectsResponse.ListProjects_ProjectsItem.ListProjects_EnginesItem>();
				for (int j = 0; j < context.Length("ListProjects.Projects["+ i +"].Engines.Length"); j++) {
					ListProjectsResponse.ListProjects_ProjectsItem.ListProjects_EnginesItem enginesItem = new ListProjectsResponse.ListProjects_ProjectsItem.ListProjects_EnginesItem();
					enginesItem.Name = context.StringValue("ListProjects.Projects["+ i +"].Engines["+ j +"].Name");
					enginesItem.JobTtl = context.LongValue("ListProjects.Projects["+ i +"].Engines["+ j +"].JobTtl");

					projectsItem_engines.Add(enginesItem);
				}
				projectsItem.Engines = projectsItem_engines;

				List<ListProjectsResponse.ListProjects_ProjectsItem.ListProjects_IndexersItem> projectsItem_indexers = new List<ListProjectsResponse.ListProjects_ProjectsItem.ListProjects_IndexersItem>();
				for (int j = 0; j < context.Length("ListProjects.Projects["+ i +"].Indexers.Length"); j++) {
					ListProjectsResponse.ListProjects_ProjectsItem.ListProjects_IndexersItem indexersItem = new ListProjectsResponse.ListProjects_ProjectsItem.ListProjects_IndexersItem();
					indexersItem.Name = context.StringValue("ListProjects.Projects["+ i +"].Indexers["+ j +"].Name");
					indexersItem.Status = context.StringValue("ListProjects.Projects["+ i +"].Indexers["+ j +"].Status");

					projectsItem_indexers.Add(indexersItem);
				}
				projectsItem.Indexers = projectsItem_indexers;

				listProjectsResponse_projects.Add(projectsItem);
			}
			listProjectsResponse.Projects = listProjectsResponse_projects;
        
			return listProjectsResponse;
        }
    }
}