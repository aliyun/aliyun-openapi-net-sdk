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
using Aliyun.Acs.vod.Model.V20170321;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.vod.Transform.V20170321
{
    public class AddEditingProjectResponseUnmarshaller
    {
        public static AddEditingProjectResponse Unmarshall(UnmarshallerContext context)
        {
			AddEditingProjectResponse addEditingProjectResponse = new AddEditingProjectResponse();

			addEditingProjectResponse.HttpResponse = context.HttpResponse;
			addEditingProjectResponse.RequestId = context.StringValue("AddEditingProject.RequestId");

			AddEditingProjectResponse.AddEditingProject_Project project = new AddEditingProjectResponse.AddEditingProject_Project();
			project.ProjectId = context.StringValue("AddEditingProject.Project.ProjectId");
			project.CreationTime = context.StringValue("AddEditingProject.Project.CreationTime");
			project.ModifiedTime = context.StringValue("AddEditingProject.Project.ModifiedTime");
			project.Status = context.StringValue("AddEditingProject.Project.Status");
			project.Description = context.StringValue("AddEditingProject.Project.Description");
			project.Title = context.StringValue("AddEditingProject.Project.Title");
			addEditingProjectResponse.Project = project;
        
			return addEditingProjectResponse;
        }
    }
}