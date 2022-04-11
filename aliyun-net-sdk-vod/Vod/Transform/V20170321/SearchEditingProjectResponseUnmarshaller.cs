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
    public class SearchEditingProjectResponseUnmarshaller
    {
        public static SearchEditingProjectResponse Unmarshall(UnmarshallerContext _ctx)
        {
			SearchEditingProjectResponse searchEditingProjectResponse = new SearchEditingProjectResponse();

			searchEditingProjectResponse.HttpResponse = _ctx.HttpResponse;
			searchEditingProjectResponse.Total = _ctx.IntegerValue("SearchEditingProject.Total");
			searchEditingProjectResponse.RequestId = _ctx.StringValue("SearchEditingProject.RequestId");

			List<SearchEditingProjectResponse.SearchEditingProject_Project> searchEditingProjectResponse_projectList = new List<SearchEditingProjectResponse.SearchEditingProject_Project>();
			for (int i = 0; i < _ctx.Length("SearchEditingProject.ProjectList.Length"); i++) {
				SearchEditingProjectResponse.SearchEditingProject_Project project = new SearchEditingProjectResponse.SearchEditingProject_Project();
				project.StorageLocation = _ctx.StringValue("SearchEditingProject.ProjectList["+ i +"].StorageLocation");
				project.Status = _ctx.StringValue("SearchEditingProject.ProjectList["+ i +"].Status");
				project.CreationTime = _ctx.StringValue("SearchEditingProject.ProjectList["+ i +"].CreationTime");
				project.ModifiedTime = _ctx.StringValue("SearchEditingProject.ProjectList["+ i +"].ModifiedTime");
				project.Description = _ctx.StringValue("SearchEditingProject.ProjectList["+ i +"].Description");
				project.CoverURL = _ctx.StringValue("SearchEditingProject.ProjectList["+ i +"].CoverURL");
				project.ProjectId = _ctx.StringValue("SearchEditingProject.ProjectList["+ i +"].ProjectId");
				project.Duration = _ctx.FloatValue("SearchEditingProject.ProjectList["+ i +"].Duration");
				project.Title = _ctx.StringValue("SearchEditingProject.ProjectList["+ i +"].Title");
				project.RegionId = _ctx.StringValue("SearchEditingProject.ProjectList["+ i +"].RegionId");

				searchEditingProjectResponse_projectList.Add(project);
			}
			searchEditingProjectResponse.ProjectList = searchEditingProjectResponse_projectList;
        
			return searchEditingProjectResponse;
        }
    }
}
