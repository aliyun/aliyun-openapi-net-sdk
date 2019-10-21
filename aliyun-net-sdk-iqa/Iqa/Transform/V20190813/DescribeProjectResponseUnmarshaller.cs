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
using Aliyun.Acs.iqa.Model.V20190813;

namespace Aliyun.Acs.iqa.Transform.V20190813
{
    public class DescribeProjectResponseUnmarshaller
    {
        public static DescribeProjectResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeProjectResponse describeProjectResponse = new DescribeProjectResponse();

			describeProjectResponse.HttpResponse = context.HttpResponse;
			describeProjectResponse.RequestId = context.StringValue("DescribeProject.RequestId");
			describeProjectResponse.ProjectType = context.StringValue("DescribeProject.ProjectType");
			describeProjectResponse.ProjectId = context.StringValue("DescribeProject.ProjectId");
			describeProjectResponse.ProjectName = context.StringValue("DescribeProject.ProjectName");
			describeProjectResponse.CreateTime = context.LongValue("DescribeProject.CreateTime");
			describeProjectResponse.DeployTime = context.LongValue("DescribeProject.DeployTime");
			describeProjectResponse.ModelId = context.StringValue("DescribeProject.ModelId");
			describeProjectResponse.ModelName = context.StringValue("DescribeProject.ModelName");
			describeProjectResponse.QuestionCount = context.IntegerValue("DescribeProject.QuestionCount");
			describeProjectResponse.DataStatus = context.StringValue("DescribeProject.DataStatus");
			describeProjectResponse.TestServiceStatus = context.StringValue("DescribeProject.TestServiceStatus");
			describeProjectResponse.OnlineServiceStatus = context.StringValue("DescribeProject.OnlineServiceStatus");
			describeProjectResponse.DeployAvailable = context.StringValue("DescribeProject.DeployAvailable");
        
			return describeProjectResponse;
        }
    }
}
