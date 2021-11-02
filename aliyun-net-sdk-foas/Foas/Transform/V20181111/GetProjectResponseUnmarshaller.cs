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
        public static GetProjectResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetProjectResponse getProjectResponse = new GetProjectResponse();

			getProjectResponse.HttpResponse = _ctx.HttpResponse;
			getProjectResponse.RequestId = _ctx.StringValue("GetProject.RequestId");

			GetProjectResponse.GetProject_Project project = new GetProjectResponse.GetProject_Project();
			project.Name = _ctx.StringValue("GetProject.Project.Name");
			project.State = _ctx.StringValue("GetProject.Project.State");
			project.Creator = _ctx.StringValue("GetProject.Project.Creator");
			project.CreateTime = _ctx.LongValue("GetProject.Project.CreateTime");
			project.Modifier = _ctx.StringValue("GetProject.Project.Modifier");
			project.ModifyTime = _ctx.LongValue("GetProject.Project.ModifyTime");
			project.Description = _ctx.StringValue("GetProject.Project.Description");
			project.DeployType = _ctx.StringValue("GetProject.Project.DeployType");
			project.ClusterId = _ctx.StringValue("GetProject.Project.ClusterId");
			project.ManagerIds = _ctx.StringValue("GetProject.Project.ManagerIds");
			project.Region = _ctx.StringValue("GetProject.Project.Region");
			project.Id = _ctx.StringValue("GetProject.Project.Id");
			project.GlobalJobConfig = _ctx.StringValue("GetProject.Project.GlobalJobConfig");
			getProjectResponse.Project = project;
        
			return getProjectResponse;
        }
    }
}
