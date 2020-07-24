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
using Aliyun.Acs.imm.Model.V20170906;

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
				projectsItem.BillingType = context.StringValue("ListProjects.Projects["+ i +"].BillingType");
				projectsItem.RegionId = context.StringValue("ListProjects.Projects["+ i +"].RegionId");

				listProjectsResponse_projects.Add(projectsItem);
			}
			listProjectsResponse.Projects = listProjectsResponse_projects;
        
			return listProjectsResponse;
        }
    }
}
