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
using Aliyun.Acs.vs.Model.V20181212;

namespace Aliyun.Acs.vs.Transform.V20181212
{
    public class DescribeDirectoriesResponseUnmarshaller
    {
        public static DescribeDirectoriesResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeDirectoriesResponse describeDirectoriesResponse = new DescribeDirectoriesResponse();

			describeDirectoriesResponse.HttpResponse = context.HttpResponse;
			describeDirectoriesResponse.RequestId = context.StringValue("DescribeDirectories.RequestId");
			describeDirectoriesResponse.PageSize = context.LongValue("DescribeDirectories.PageSize");
			describeDirectoriesResponse.PageNum = context.LongValue("DescribeDirectories.PageNum");
			describeDirectoriesResponse.PageCount = context.LongValue("DescribeDirectories.PageCount");
			describeDirectoriesResponse.TotalCount = context.LongValue("DescribeDirectories.TotalCount");

			List<DescribeDirectoriesResponse.DescribeDirectories_Directory> describeDirectoriesResponse_directories = new List<DescribeDirectoriesResponse.DescribeDirectories_Directory>();
			for (int i = 0; i < context.Length("DescribeDirectories.Directories.Length"); i++) {
				DescribeDirectoriesResponse.DescribeDirectories_Directory directory = new DescribeDirectoriesResponse.DescribeDirectories_Directory();
				directory.Id = context.StringValue("DescribeDirectories.Directories["+ i +"].Id");
				directory.Name = context.StringValue("DescribeDirectories.Directories["+ i +"].Name");
				directory.Description = context.StringValue("DescribeDirectories.Directories["+ i +"].Description");
				directory.GroupId = context.StringValue("DescribeDirectories.Directories["+ i +"].GroupId");
				directory.ParentId = context.StringValue("DescribeDirectories.Directories["+ i +"].ParentId");
				directory.CreatedTime = context.StringValue("DescribeDirectories.Directories["+ i +"].CreatedTime");

				describeDirectoriesResponse_directories.Add(directory);
			}
			describeDirectoriesResponse.Directories = describeDirectoriesResponse_directories;
        
			return describeDirectoriesResponse;
        }
    }
}
