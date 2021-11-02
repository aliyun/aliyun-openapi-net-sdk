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
    public class GetEditingProjectResponseUnmarshaller
    {
        public static GetEditingProjectResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetEditingProjectResponse getEditingProjectResponse = new GetEditingProjectResponse();

			getEditingProjectResponse.HttpResponse = _ctx.HttpResponse;
			getEditingProjectResponse.RequestId = _ctx.StringValue("GetEditingProject.RequestId");

			GetEditingProjectResponse.GetEditingProject_Project project = new GetEditingProjectResponse.GetEditingProject_Project();
			project.ProjectId = _ctx.StringValue("GetEditingProject.Project.ProjectId");
			project.CreationTime = _ctx.StringValue("GetEditingProject.Project.CreationTime");
			project.ModifiedTime = _ctx.StringValue("GetEditingProject.Project.ModifiedTime");
			project.Status = _ctx.StringValue("GetEditingProject.Project.Status");
			project.Description = _ctx.StringValue("GetEditingProject.Project.Description");
			project.Title = _ctx.StringValue("GetEditingProject.Project.Title");
			project.Timeline = _ctx.StringValue("GetEditingProject.Project.Timeline");
			project.CoverURL = _ctx.StringValue("GetEditingProject.Project.CoverURL");
			project.StorageLocation = _ctx.StringValue("GetEditingProject.Project.StorageLocation");
			project.RegionId = _ctx.StringValue("GetEditingProject.Project.RegionId");
			project.FEExtend = _ctx.StringValue("GetEditingProject.Project.FEExtend");
			getEditingProjectResponse.Project = project;
        
			return getEditingProjectResponse;
        }
    }
}
