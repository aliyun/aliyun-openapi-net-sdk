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
    public class DescribeFlowCategoryResponseUnmarshaller
    {
        public static DescribeFlowCategoryResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeFlowCategoryResponse describeFlowCategoryResponse = new DescribeFlowCategoryResponse();

			describeFlowCategoryResponse.HttpResponse = context.HttpResponse;
			describeFlowCategoryResponse.RequestId = context.StringValue("DescribeFlowCategory.RequestId");
			describeFlowCategoryResponse.Id = context.StringValue("DescribeFlowCategory.Id");
			describeFlowCategoryResponse.GmtCreate = context.LongValue("DescribeFlowCategory.GmtCreate");
			describeFlowCategoryResponse.GmtModified = context.LongValue("DescribeFlowCategory.GmtModified");
			describeFlowCategoryResponse.Name = context.StringValue("DescribeFlowCategory.Name");
			describeFlowCategoryResponse.ParentId = context.StringValue("DescribeFlowCategory.ParentId");
			describeFlowCategoryResponse.Type = context.StringValue("DescribeFlowCategory.Type");
			describeFlowCategoryResponse.CategoryType = context.StringValue("DescribeFlowCategory.CategoryType");
			describeFlowCategoryResponse.ObjectType = context.StringValue("DescribeFlowCategory.ObjectType");
			describeFlowCategoryResponse.ObjectId = context.StringValue("DescribeFlowCategory.ObjectId");
			describeFlowCategoryResponse.ProjectId = context.StringValue("DescribeFlowCategory.ProjectId");
        
			return describeFlowCategoryResponse;
        }
    }
}
