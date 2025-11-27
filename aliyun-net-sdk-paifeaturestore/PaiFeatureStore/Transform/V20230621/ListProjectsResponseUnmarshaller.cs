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
using Aliyun.Acs.PaiFeatureStore.Model.V20230621;

namespace Aliyun.Acs.PaiFeatureStore.Transform.V20230621
{
    public class ListProjectsResponseUnmarshaller
    {
        public static ListProjectsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListProjectsResponse listProjectsResponse = new ListProjectsResponse();

			listProjectsResponse.HttpResponse = _ctx.HttpResponse;
			listProjectsResponse.RequestId = _ctx.StringValue("ListProjects.RequestId");
			listProjectsResponse.TotalCount = _ctx.LongValue("ListProjects.TotalCount");

			List<ListProjectsResponse.ListProjects_ProjectsItem> listProjectsResponse_projects = new List<ListProjectsResponse.ListProjects_ProjectsItem>();
			for (int i = 0; i < _ctx.Length("ListProjects.Projects.Length"); i++) {
				ListProjectsResponse.ListProjects_ProjectsItem projectsItem = new ListProjectsResponse.ListProjects_ProjectsItem();
				projectsItem.ProjectId = _ctx.StringValue("ListProjects.Projects["+ i +"].ProjectId");
				projectsItem.Name = _ctx.StringValue("ListProjects.Projects["+ i +"].Name");
				projectsItem.Description = _ctx.StringValue("ListProjects.Projects["+ i +"].Description");
				projectsItem.OfflineDatasourceType = _ctx.StringValue("ListProjects.Projects["+ i +"].OfflineDatasourceType");
				projectsItem.OfflineDatasourceId = _ctx.StringValue("ListProjects.Projects["+ i +"].OfflineDatasourceId");
				projectsItem.OfflineDatasourceName = _ctx.StringValue("ListProjects.Projects["+ i +"].OfflineDatasourceName");
				projectsItem.OnlineDatasourceType = _ctx.StringValue("ListProjects.Projects["+ i +"].OnlineDatasourceType");
				projectsItem.OnlineDatasourceId = _ctx.StringValue("ListProjects.Projects["+ i +"].OnlineDatasourceId");
				projectsItem.OnlineDatasourceName = _ctx.StringValue("ListProjects.Projects["+ i +"].OnlineDatasourceName");
				projectsItem.OfflineLifecycle = _ctx.IntegerValue("ListProjects.Projects["+ i +"].OfflineLifecycle");
				projectsItem.FeatureEntityCount = _ctx.IntegerValue("ListProjects.Projects["+ i +"].FeatureEntityCount");
				projectsItem.FeatureViewCount = _ctx.IntegerValue("ListProjects.Projects["+ i +"].FeatureViewCount");
				projectsItem.ModelCount = _ctx.IntegerValue("ListProjects.Projects["+ i +"].ModelCount");
				projectsItem.Owner = _ctx.StringValue("ListProjects.Projects["+ i +"].Owner");
				projectsItem.GmtCreateTime = _ctx.StringValue("ListProjects.Projects["+ i +"].GmtCreateTime");
				projectsItem.GmtModifiedTime = _ctx.StringValue("ListProjects.Projects["+ i +"].GmtModifiedTime");

				listProjectsResponse_projects.Add(projectsItem);
			}
			listProjectsResponse.Projects = listProjectsResponse_projects;
        
			return listProjectsResponse;
        }
    }
}
