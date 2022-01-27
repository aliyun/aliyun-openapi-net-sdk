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
        public static DescribeFlowCategoryResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeFlowCategoryResponse describeFlowCategoryResponse = new DescribeFlowCategoryResponse();

			describeFlowCategoryResponse.HttpResponse = _ctx.HttpResponse;
			describeFlowCategoryResponse.RequestId = _ctx.StringValue("DescribeFlowCategory.RequestId");
			describeFlowCategoryResponse.Id = _ctx.StringValue("DescribeFlowCategory.Id");
			describeFlowCategoryResponse.GmtCreate = _ctx.LongValue("DescribeFlowCategory.GmtCreate");
			describeFlowCategoryResponse.GmtModified = _ctx.LongValue("DescribeFlowCategory.GmtModified");
			describeFlowCategoryResponse.Name = _ctx.StringValue("DescribeFlowCategory.Name");
			describeFlowCategoryResponse.ParentId = _ctx.StringValue("DescribeFlowCategory.ParentId");
			describeFlowCategoryResponse.Type = _ctx.StringValue("DescribeFlowCategory.Type");
			describeFlowCategoryResponse.CategoryType = _ctx.StringValue("DescribeFlowCategory.CategoryType");
			describeFlowCategoryResponse.ObjectType = _ctx.StringValue("DescribeFlowCategory.ObjectType");
			describeFlowCategoryResponse.ObjectId = _ctx.StringValue("DescribeFlowCategory.ObjectId");
			describeFlowCategoryResponse.ProjectId = _ctx.StringValue("DescribeFlowCategory.ProjectId");
        
			return describeFlowCategoryResponse;
        }
    }
}
