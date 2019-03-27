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
using Aliyun.Acs.ivision.Model.V20190308;

namespace Aliyun.Acs.ivision.Transform.V20190308
{
    public class CreateProjectResponseUnmarshaller
    {
        public static CreateProjectResponse Unmarshall(UnmarshallerContext context)
        {
			CreateProjectResponse createProjectResponse = new CreateProjectResponse();

			createProjectResponse.HttpResponse = context.HttpResponse;
			createProjectResponse.RequestId = context.StringValue("CreateProject.RequestId");

			CreateProjectResponse.CreateProject_Project project = new CreateProjectResponse.CreateProject_Project();
			project.ProjectId = context.StringValue("CreateProject.Project.ProjectId");
			project.Name = context.StringValue("CreateProject.Project.Name");
			project.Description = context.StringValue("CreateProject.Project.Description");
			project.ProType = context.StringValue("CreateProject.Project.ProType");
			project.IterCount = context.IntegerValue("CreateProject.Project.IterCount");
			project.CreationTime = context.StringValue("CreateProject.Project.CreationTime");
			project.Status = context.StringValue("CreateProject.Project.Status");
			createProjectResponse.Project = project;
        
			return createProjectResponse;
        }
    }
}
