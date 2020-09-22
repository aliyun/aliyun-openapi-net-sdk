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
    public class DescribeDirectoryResponseUnmarshaller
    {
        public static DescribeDirectoryResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeDirectoryResponse describeDirectoryResponse = new DescribeDirectoryResponse();

			describeDirectoryResponse.HttpResponse = context.HttpResponse;
			describeDirectoryResponse.RequestId = context.StringValue("DescribeDirectory.RequestId");
			describeDirectoryResponse.Id = context.StringValue("DescribeDirectory.Id");
			describeDirectoryResponse.Name = context.StringValue("DescribeDirectory.Name");
			describeDirectoryResponse.Description = context.StringValue("DescribeDirectory.Description");
			describeDirectoryResponse.GroupId = context.StringValue("DescribeDirectory.GroupId");
			describeDirectoryResponse.ParentId = context.StringValue("DescribeDirectory.ParentId");
			describeDirectoryResponse.CreatedTime = context.StringValue("DescribeDirectory.CreatedTime");
        
			return describeDirectoryResponse;
        }
    }
}
