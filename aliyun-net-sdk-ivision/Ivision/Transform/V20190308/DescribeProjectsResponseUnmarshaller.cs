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
using Aliyun.Acs.ivision.Model.V20190308;

namespace Aliyun.Acs.ivision.Transform.V20190308
{
    public class DescribeProjectsResponseUnmarshaller
    {
        public static DescribeProjectsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeProjectsResponse describeProjectsResponse = new DescribeProjectsResponse();

			describeProjectsResponse.HttpResponse = context.HttpResponse;
			describeProjectsResponse.RequestId = context.StringValue("DescribeProjects.RequestId");
			describeProjectsResponse.TotalNum = context.LongValue("DescribeProjects.TotalNum");
			describeProjectsResponse.CurrentPage = context.LongValue("DescribeProjects.CurrentPage");
			describeProjectsResponse.PageSize = context.LongValue("DescribeProjects.PageSize");
			describeProjectsResponse.NextPageToken = context.StringValue("DescribeProjects.NextPageToken");

			List<DescribeProjectsResponse.DescribeProjects_Project> describeProjectsResponse_projects = new List<DescribeProjectsResponse.DescribeProjects_Project>();
			for (int i = 0; i < context.Length("DescribeProjects.Projects.Length"); i++) {
				DescribeProjectsResponse.DescribeProjects_Project project = new DescribeProjectsResponse.DescribeProjects_Project();
				project.ProjectId = context.StringValue("DescribeProjects.Projects["+ i +"].ProjectId");
				project.Name = context.StringValue("DescribeProjects.Projects["+ i +"].Name");
				project.Description = context.StringValue("DescribeProjects.Projects["+ i +"].Description");
				project.ProType = context.StringValue("DescribeProjects.Projects["+ i +"].ProType");
				project.IterCount = context.IntegerValue("DescribeProjects.Projects["+ i +"].IterCount");
				project.CreationTime = context.StringValue("DescribeProjects.Projects["+ i +"].CreationTime");
				project.Status = context.StringValue("DescribeProjects.Projects["+ i +"].Status");

				describeProjectsResponse_projects.Add(project);
			}
			describeProjectsResponse.Projects = describeProjectsResponse_projects;
        
			return describeProjectsResponse;
        }
    }
}
