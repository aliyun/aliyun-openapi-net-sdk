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
using Aliyun.Acs.Emr.Model.V20160408;

namespace Aliyun.Acs.Emr.Transform.V20160408
{
    public class DescribeDataSourceResponseUnmarshaller
    {
        public static DescribeDataSourceResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeDataSourceResponse describeDataSourceResponse = new DescribeDataSourceResponse();

			describeDataSourceResponse.HttpResponse = context.HttpResponse;
			describeDataSourceResponse.RequestId = context.StringValue("DescribeDataSource.RequestId");
			describeDataSourceResponse.Id = context.StringValue("DescribeDataSource.Id");
			describeDataSourceResponse.Name = context.StringValue("DescribeDataSource.Name");
			describeDataSourceResponse.Description = context.StringValue("DescribeDataSource.Description");
			describeDataSourceResponse.CategoryId = context.StringValue("DescribeDataSource.CategoryId");
			describeDataSourceResponse.Status = context.StringValue("DescribeDataSource.Status");
			describeDataSourceResponse.SourceType = context.StringValue("DescribeDataSource.SourceType");
			describeDataSourceResponse.CreateFrom = context.StringValue("DescribeDataSource.CreateFrom");
			describeDataSourceResponse.Conf = context.StringValue("DescribeDataSource.Conf");
			describeDataSourceResponse.ClusterId = context.StringValue("DescribeDataSource.ClusterId");
			describeDataSourceResponse.Creator = context.StringValue("DescribeDataSource.Creator");
			describeDataSourceResponse.Modifier = context.StringValue("DescribeDataSource.Modifier");
			describeDataSourceResponse.GmtCreate = context.LongValue("DescribeDataSource.GmtCreate");
			describeDataSourceResponse.GmtModified = context.LongValue("DescribeDataSource.GmtModified");
        
			return describeDataSourceResponse;
        }
    }
}
