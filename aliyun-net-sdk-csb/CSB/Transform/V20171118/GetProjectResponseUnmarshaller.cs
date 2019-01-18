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
using Aliyun.Acs.CSB.Model.V20171118;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.CSB.Transform.V20171118
{
    public class GetProjectResponseUnmarshaller
    {
        public static GetProjectResponse Unmarshall(UnmarshallerContext context)
        {
			GetProjectResponse getProjectResponse = new GetProjectResponse();

			getProjectResponse.HttpResponse = context.HttpResponse;
			getProjectResponse.Code = context.IntegerValue("GetProject.Code");
			getProjectResponse.Message = context.StringValue("GetProject.Message");
			getProjectResponse.RequestId = context.StringValue("GetProject.RequestId");

			GetProjectResponse.GetProject_Data data = new GetProjectResponse.GetProject_Data();

			List<GetProjectResponse.GetProject_Data.GetProject_Project> data_projectList = new List<GetProjectResponse.GetProject_Data.GetProject_Project>();
			for (int i = 0; i < context.Length("GetProject.Data.ProjectList.Length"); i++) {
				GetProjectResponse.GetProject_Data.GetProject_Project project = new GetProjectResponse.GetProject_Data.GetProject_Project();
				project.ApiNum = context.IntegerValue("GetProject.Data.ProjectList["+ i +"].ApiNum");
				project.CsbId = context.LongValue("GetProject.Data.ProjectList["+ i +"].CsbId");
				project.DeleteFlag = context.IntegerValue("GetProject.Data.ProjectList["+ i +"].DeleteFlag");
				project.Description = context.StringValue("GetProject.Data.ProjectList["+ i +"].Description");
				project.GmtCreate = context.LongValue("GetProject.Data.ProjectList["+ i +"].GmtCreate");
				project.GmtModified = context.LongValue("GetProject.Data.ProjectList["+ i +"].GmtModified");
				project.Id = context.LongValue("GetProject.Data.ProjectList["+ i +"].Id");
				project.InterfaceJarLocation = context.StringValue("GetProject.Data.ProjectList["+ i +"].InterfaceJarLocation");
				project.InterfaceJarName = context.StringValue("GetProject.Data.ProjectList["+ i +"].InterfaceJarName");
				project.JarFileKey = context.StringValue("GetProject.Data.ProjectList["+ i +"].JarFileKey");
				project.OwnerId = context.StringValue("GetProject.Data.ProjectList["+ i +"].OwnerId");
				project.ProjectName = context.StringValue("GetProject.Data.ProjectList["+ i +"].ProjectName");
				project.ProjectOwnerEmail = context.StringValue("GetProject.Data.ProjectList["+ i +"].ProjectOwnerEmail");
				project.ProjectOwnerName = context.StringValue("GetProject.Data.ProjectList["+ i +"].ProjectOwnerName");
				project.ProjectOwnerPhoneNum = context.StringValue("GetProject.Data.ProjectList["+ i +"].ProjectOwnerPhoneNum");
				project.Status = context.IntegerValue("GetProject.Data.ProjectList["+ i +"].Status");
				project.UserId = context.StringValue("GetProject.Data.ProjectList["+ i +"].UserId");

				data_projectList.Add(project);
			}
			data.ProjectList = data_projectList;
			getProjectResponse.Data = data;
        
			return getProjectResponse;
        }
    }
}