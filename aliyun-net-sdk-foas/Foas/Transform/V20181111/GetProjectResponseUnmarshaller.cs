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
    public class GetProjectResponseUnmarshaller
    {
        public static GetProjectResponse Unmarshall(UnmarshallerContext context)
        {
			GetProjectResponse getProjectResponse = new GetProjectResponse();

			getProjectResponse.HttpResponse = context.HttpResponse;
			getProjectResponse.RequestId = context.StringValue("GetProject.RequestId");

			GetProjectResponse.GetProject_Project project = new GetProjectResponse.GetProject_Project();
			project.Name = context.StringValue("GetProject.Project.Name");
			project.State = context.StringValue("GetProject.Project.State");
			project.Creator = context.StringValue("GetProject.Project.Creator");
			project.CreateTime = context.LongValue("GetProject.Project.CreateTime");
			project.Modifier = context.StringValue("GetProject.Project.Modifier");
			project.ModifyTime = context.LongValue("GetProject.Project.ModifyTime");
			project.Description = context.StringValue("GetProject.Project.Description");
			project.DeployType = context.StringValue("GetProject.Project.DeployType");
			project.ClusterId = context.StringValue("GetProject.Project.ClusterId");
			project.ManagerIds = context.StringValue("GetProject.Project.ManagerIds");
			project.Region = context.StringValue("GetProject.Project.Region");
			project.Id = context.StringValue("GetProject.Project.Id");
			getProjectResponse.Project = project;
        
			return getProjectResponse;
        }
    }
}
