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
    public class SearchEditingProjectResponseUnmarshaller
    {
        public static SearchEditingProjectResponse Unmarshall(UnmarshallerContext context)
        {
			SearchEditingProjectResponse searchEditingProjectResponse = new SearchEditingProjectResponse();

			searchEditingProjectResponse.HttpResponse = context.HttpResponse;
			searchEditingProjectResponse.RequestId = context.StringValue("SearchEditingProject.RequestId");
			searchEditingProjectResponse.Total = context.IntegerValue("SearchEditingProject.Total");

			List<SearchEditingProjectResponse.SearchEditingProject_Project> searchEditingProjectResponse_projectList = new List<SearchEditingProjectResponse.SearchEditingProject_Project>();
			for (int i = 0; i < context.Length("SearchEditingProject.ProjectList.Length"); i++) {
				SearchEditingProjectResponse.SearchEditingProject_Project project = new SearchEditingProjectResponse.SearchEditingProject_Project();
				project.ProjectId = context.StringValue("SearchEditingProject.ProjectList["+ i +"].ProjectId");
				project.CreationTime = context.StringValue("SearchEditingProject.ProjectList["+ i +"].CreationTime");
				project.ModifiedTime = context.StringValue("SearchEditingProject.ProjectList["+ i +"].ModifiedTime");
				project.Status = context.StringValue("SearchEditingProject.ProjectList["+ i +"].Status");
				project.Description = context.StringValue("SearchEditingProject.ProjectList["+ i +"].Description");
				project.Title = context.StringValue("SearchEditingProject.ProjectList["+ i +"].Title");
				project.CoverURL = context.StringValue("SearchEditingProject.ProjectList["+ i +"].CoverURL");

				searchEditingProjectResponse_projectList.Add(project);
			}
			searchEditingProjectResponse.ProjectList = searchEditingProjectResponse_projectList;
        
			return searchEditingProjectResponse;
        }
    }
}