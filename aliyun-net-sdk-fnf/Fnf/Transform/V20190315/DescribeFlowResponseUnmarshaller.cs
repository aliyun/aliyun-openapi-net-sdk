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
using Aliyun.Acs.fnf.Model.V20190315;

namespace Aliyun.Acs.fnf.Transform.V20190315
{
    public class DescribeFlowResponseUnmarshaller
    {
        public static DescribeFlowResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeFlowResponse describeFlowResponse = new DescribeFlowResponse();

			describeFlowResponse.HttpResponse = _ctx.HttpResponse;
			describeFlowResponse.RequestId = _ctx.StringValue("DescribeFlow.RequestId");
			describeFlowResponse.Name = _ctx.StringValue("DescribeFlow.Name");
			describeFlowResponse.Description = _ctx.StringValue("DescribeFlow.Description");
			describeFlowResponse.Definition = _ctx.StringValue("DescribeFlow.Definition");
			describeFlowResponse.Id = _ctx.StringValue("DescribeFlow.Id");
			describeFlowResponse.Type = _ctx.StringValue("DescribeFlow.Type");
			describeFlowResponse.RoleArn = _ctx.StringValue("DescribeFlow.RoleArn");
			describeFlowResponse.CreatedTime = _ctx.StringValue("DescribeFlow.CreatedTime");
			describeFlowResponse.LastModifiedTime = _ctx.StringValue("DescribeFlow.LastModifiedTime");
			describeFlowResponse.ExternalStorageLocation = _ctx.StringValue("DescribeFlow.ExternalStorageLocation");
        
			return describeFlowResponse;
        }
    }
}
