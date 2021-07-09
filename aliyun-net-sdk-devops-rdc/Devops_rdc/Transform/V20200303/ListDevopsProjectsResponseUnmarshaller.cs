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
using Aliyun.Acs.devops_rdc.Model.V20200303;

namespace Aliyun.Acs.devops_rdc.Transform.V20200303
{
    public class ListDevopsProjectsResponseUnmarshaller
    {
        public static ListDevopsProjectsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListDevopsProjectsResponse listDevopsProjectsResponse = new ListDevopsProjectsResponse();

			listDevopsProjectsResponse.HttpResponse = _ctx.HttpResponse;
			listDevopsProjectsResponse.ErrorMsg = _ctx.StringValue("ListDevopsProjects.ErrorMsg");
			listDevopsProjectsResponse.RequestId = _ctx.StringValue("ListDevopsProjects.RequestId");
			listDevopsProjectsResponse.Successful = _ctx.BooleanValue("ListDevopsProjects.Successful");
			listDevopsProjectsResponse.ErrorCode = _ctx.StringValue("ListDevopsProjects.ErrorCode");

			ListDevopsProjectsResponse.ListDevopsProjects__Object _object = new ListDevopsProjectsResponse.ListDevopsProjects__Object();
			_object.NextPageToken = _ctx.StringValue("ListDevopsProjects.Object.NextPageToken");

			List<ListDevopsProjectsResponse.ListDevopsProjects__Object.ListDevopsProjects_Project> _object_result = new List<ListDevopsProjectsResponse.ListDevopsProjects__Object.ListDevopsProjects_Project>();
			for (int i = 0; i < _ctx.Length("ListDevopsProjects.Object.Result.Length"); i++) {
				ListDevopsProjectsResponse.ListDevopsProjects__Object.ListDevopsProjects_Project project = new ListDevopsProjectsResponse.ListDevopsProjects__Object.ListDevopsProjects_Project();
				project.Logo = _ctx.StringValue("ListDevopsProjects.Object.Result["+ i +"].Logo");
				project.IsStar = _ctx.BooleanValue("ListDevopsProjects.Object.Result["+ i +"].IsStar");
				project.CreatorId = _ctx.StringValue("ListDevopsProjects.Object.Result["+ i +"].CreatorId");
				project.MembersCount = _ctx.IntegerValue("ListDevopsProjects.Object.Result["+ i +"].MembersCount");
				project.OrganizationId = _ctx.StringValue("ListDevopsProjects.Object.Result["+ i +"].OrganizationId");
				project.Visibility = _ctx.StringValue("ListDevopsProjects.Object.Result["+ i +"].Visibility");
				project.IsTemplate = _ctx.BooleanValue("ListDevopsProjects.Object.Result["+ i +"].IsTemplate");
				project.Description = _ctx.StringValue("ListDevopsProjects.Object.Result["+ i +"].Description");
				project.Updated = _ctx.StringValue("ListDevopsProjects.Object.Result["+ i +"].Updated");
				project.Created = _ctx.StringValue("ListDevopsProjects.Object.Result["+ i +"].Created");
				project.IsArchived = _ctx.BooleanValue("ListDevopsProjects.Object.Result["+ i +"].IsArchived");
				project.Name = _ctx.StringValue("ListDevopsProjects.Object.Result["+ i +"].Name");
				project.IsPublic = _ctx.BooleanValue("ListDevopsProjects.Object.Result["+ i +"].IsPublic");
				project.TasksCount = _ctx.IntegerValue("ListDevopsProjects.Object.Result["+ i +"].TasksCount");
				project.RoleId = _ctx.StringValue("ListDevopsProjects.Object.Result["+ i +"].RoleId");
				project.Id = _ctx.StringValue("ListDevopsProjects.Object.Result["+ i +"].Id");

				_object_result.Add(project);
			}
			_object.Result = _object_result;
			listDevopsProjectsResponse._Object = _object;
        
			return listDevopsProjectsResponse;
        }
    }
}
