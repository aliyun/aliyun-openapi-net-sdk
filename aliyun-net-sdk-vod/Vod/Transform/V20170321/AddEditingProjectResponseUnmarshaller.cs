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
using Aliyun.Acs.vod.Model.V20170321;

namespace Aliyun.Acs.vod.Transform.V20170321
{
    public class AddEditingProjectResponseUnmarshaller
    {
        public static AddEditingProjectResponse Unmarshall(UnmarshallerContext _ctx)
        {
			AddEditingProjectResponse addEditingProjectResponse = new AddEditingProjectResponse();

			addEditingProjectResponse.HttpResponse = _ctx.HttpResponse;
			addEditingProjectResponse.RequestId = _ctx.StringValue("AddEditingProject.RequestId");

			AddEditingProjectResponse.AddEditingProject_Project project = new AddEditingProjectResponse.AddEditingProject_Project();
			project.ProjectId = _ctx.StringValue("AddEditingProject.Project.ProjectId");
			project.CreationTime = _ctx.StringValue("AddEditingProject.Project.CreationTime");
			project.ModifiedTime = _ctx.StringValue("AddEditingProject.Project.ModifiedTime");
			project.Status = _ctx.StringValue("AddEditingProject.Project.Status");
			project.Description = _ctx.StringValue("AddEditingProject.Project.Description");
			project.Title = _ctx.StringValue("AddEditingProject.Project.Title");
			addEditingProjectResponse.Project = project;
        
			return addEditingProjectResponse;
        }
    }
}
