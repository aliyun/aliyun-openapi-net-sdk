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
        public static ListFlowProjectResponse Unmarshall(UnmarshallerContext context)
        {
			ListFlowProjectResponse listFlowProjectResponse = new ListFlowProjectResponse();

			listFlowProjectResponse.HttpResponse = context.HttpResponse;
			listFlowProjectResponse.RequestId = context.StringValue("ListFlowProject.RequestId");
			listFlowProjectResponse.PageNumber = context.IntegerValue("ListFlowProject.PageNumber");
			listFlowProjectResponse.PageSize = context.IntegerValue("ListFlowProject.PageSize");
			listFlowProjectResponse.Total = context.IntegerValue("ListFlowProject.Total");

			List<ListFlowProjectResponse.ListFlowProject_Project> listFlowProjectResponse_projects = new List<ListFlowProjectResponse.ListFlowProject_Project>();
			for (int i = 0; i < context.Length("ListFlowProject.Projects.Length"); i++) {
				ListFlowProjectResponse.ListFlowProject_Project project = new ListFlowProjectResponse.ListFlowProject_Project();
				project.Id = context.StringValue("ListFlowProject.Projects["+ i +"].Id");
				project.GmtCreate = context.LongValue("ListFlowProject.Projects["+ i +"].GmtCreate");
				project.GmtModified = context.LongValue("ListFlowProject.Projects["+ i +"].GmtModified");
				project.UserId = context.StringValue("ListFlowProject.Projects["+ i +"].UserId");
				project.Name = context.StringValue("ListFlowProject.Projects["+ i +"].Name");
				project.Description = context.StringValue("ListFlowProject.Projects["+ i +"].Description");

				listFlowProjectResponse_projects.Add(project);
			}
			listFlowProjectResponse.Projects = listFlowProjectResponse_projects;
        
			return listFlowProjectResponse;
        }
    }
}
