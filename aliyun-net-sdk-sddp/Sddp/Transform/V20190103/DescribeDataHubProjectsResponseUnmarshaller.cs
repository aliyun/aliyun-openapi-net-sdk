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
using Aliyun.Acs.Sddp.Model.V20190103;

namespace Aliyun.Acs.Sddp.Transform.V20190103
{
    public class DescribeDataHubProjectsResponseUnmarshaller
    {
        public static DescribeDataHubProjectsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeDataHubProjectsResponse describeDataHubProjectsResponse = new DescribeDataHubProjectsResponse();

			describeDataHubProjectsResponse.HttpResponse = context.HttpResponse;
			describeDataHubProjectsResponse.RequestId = context.StringValue("DescribeDataHubProjects.RequestId");
			describeDataHubProjectsResponse.PageSize = context.IntegerValue("DescribeDataHubProjects.PageSize");
			describeDataHubProjectsResponse.CurrentPage = context.IntegerValue("DescribeDataHubProjects.CurrentPage");
			describeDataHubProjectsResponse.TotalCount = context.IntegerValue("DescribeDataHubProjects.TotalCount");

			List<DescribeDataHubProjectsResponse.DescribeDataHubProjects_Project> describeDataHubProjectsResponse_items = new List<DescribeDataHubProjectsResponse.DescribeDataHubProjects_Project>();
			for (int i = 0; i < context.Length("DescribeDataHubProjects.Items.Length"); i++) {
				DescribeDataHubProjectsResponse.DescribeDataHubProjects_Project project = new DescribeDataHubProjectsResponse.DescribeDataHubProjects_Project();
				project.Id = context.LongValue("DescribeDataHubProjects.Items["+ i +"].Id");
				project.Name = context.StringValue("DescribeDataHubProjects.Items["+ i +"].Name");
				project.Description = context.StringValue("DescribeDataHubProjects.Items["+ i +"].Description");
				project.CreationTime = context.LongValue("DescribeDataHubProjects.Items["+ i +"].CreationTime");
				project.TopicCount = context.StringValue("DescribeDataHubProjects.Items["+ i +"].TopicCount");
				project.TopicTupleCount = context.StringValue("DescribeDataHubProjects.Items["+ i +"].TopicTupleCount");
				project.TopicBlobCount = context.LongValue("DescribeDataHubProjects.Items["+ i +"].TopicBlobCount");
				project.UserId = context.LongValue("DescribeDataHubProjects.Items["+ i +"].UserId");
				project.LoginName = context.StringValue("DescribeDataHubProjects.Items["+ i +"].LoginName");
				project.DisplayName = context.StringValue("DescribeDataHubProjects.Items["+ i +"].DisplayName");

				describeDataHubProjectsResponse_items.Add(project);
			}
			describeDataHubProjectsResponse.Items = describeDataHubProjectsResponse_items;
        
			return describeDataHubProjectsResponse;
        }
    }
}
