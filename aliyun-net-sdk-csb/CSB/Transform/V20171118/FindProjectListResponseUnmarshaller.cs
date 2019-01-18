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
    public class FindProjectListResponseUnmarshaller
    {
        public static FindProjectListResponse Unmarshall(UnmarshallerContext context)
        {
			FindProjectListResponse findProjectListResponse = new FindProjectListResponse();

			findProjectListResponse.HttpResponse = context.HttpResponse;
			findProjectListResponse.Code = context.IntegerValue("FindProjectList.Code");
			findProjectListResponse.Message = context.StringValue("FindProjectList.Message");
			findProjectListResponse.RequestId = context.StringValue("FindProjectList.RequestId");

			FindProjectListResponse.FindProjectList_Data data = new FindProjectListResponse.FindProjectList_Data();
			data.CurrentPage = context.IntegerValue("FindProjectList.Data.CurrentPage");
			data.PageNumber = context.IntegerValue("FindProjectList.Data.PageNumber");
			data.Total = context.IntegerValue("FindProjectList.Data.Total");

			List<FindProjectListResponse.FindProjectList_Data.FindProjectList_Project> data_projectList = new List<FindProjectListResponse.FindProjectList_Data.FindProjectList_Project>();
			for (int i = 0; i < context.Length("FindProjectList.Data.ProjectList.Length"); i++) {
				FindProjectListResponse.FindProjectList_Data.FindProjectList_Project project = new FindProjectListResponse.FindProjectList_Data.FindProjectList_Project();
				project.ApiNum = context.IntegerValue("FindProjectList.Data.ProjectList["+ i +"].ApiNum");
				project.CsbId = context.LongValue("FindProjectList.Data.ProjectList["+ i +"].CsbId");
				project.DeleteFlag = context.IntegerValue("FindProjectList.Data.ProjectList["+ i +"].DeleteFlag");
				project.Description = context.StringValue("FindProjectList.Data.ProjectList["+ i +"].Description");
				project.GmtCreate = context.LongValue("FindProjectList.Data.ProjectList["+ i +"].GmtCreate");
				project.GmtModified = context.LongValue("FindProjectList.Data.ProjectList["+ i +"].GmtModified");
				project.Id = context.LongValue("FindProjectList.Data.ProjectList["+ i +"].Id");
				project.InterfaceJarLocation = context.StringValue("FindProjectList.Data.ProjectList["+ i +"].InterfaceJarLocation");
				project.InterfaceJarName = context.StringValue("FindProjectList.Data.ProjectList["+ i +"].InterfaceJarName");
				project.JarFileKey = context.StringValue("FindProjectList.Data.ProjectList["+ i +"].JarFileKey");
				project.OwnerId = context.StringValue("FindProjectList.Data.ProjectList["+ i +"].OwnerId");
				project.ProjectName = context.StringValue("FindProjectList.Data.ProjectList["+ i +"].ProjectName");
				project.ProjectOwnerEmail = context.StringValue("FindProjectList.Data.ProjectList["+ i +"].ProjectOwnerEmail");
				project.ProjectOwnerName = context.StringValue("FindProjectList.Data.ProjectList["+ i +"].ProjectOwnerName");
				project.ProjectOwnerPhoneNum = context.StringValue("FindProjectList.Data.ProjectList["+ i +"].ProjectOwnerPhoneNum");
				project.Status = context.IntegerValue("FindProjectList.Data.ProjectList["+ i +"].Status");
				project.UserId = context.StringValue("FindProjectList.Data.ProjectList["+ i +"].UserId");

				data_projectList.Add(project);
			}
			data.ProjectList = data_projectList;
			findProjectListResponse.Data = data;
        
			return findProjectListResponse;
        }
    }
}