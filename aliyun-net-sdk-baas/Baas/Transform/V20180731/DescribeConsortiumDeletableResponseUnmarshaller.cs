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
using Aliyun.Acs.Baas.Model.V20180731;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Baas.Transform.V20180731
{
    public class DescribeConsortiumDeletableResponseUnmarshaller
    {
        public static DescribeConsortiumDeletableResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeConsortiumDeletableResponse describeConsortiumDeletableResponse = new DescribeConsortiumDeletableResponse();

			describeConsortiumDeletableResponse.HttpResponse = context.HttpResponse;
			describeConsortiumDeletableResponse.RequestId = context.StringValue("DescribeConsortiumDeletable.RequestId");
			describeConsortiumDeletableResponse.Success = context.BooleanValue("DescribeConsortiumDeletable.Success");
			describeConsortiumDeletableResponse.ErrorCode = context.IntegerValue("DescribeConsortiumDeletable.ErrorCode");

			DescribeConsortiumDeletableResponse.DescribeConsortiumDeletable_Result result = new DescribeConsortiumDeletableResponse.DescribeConsortiumDeletable_Result();
			result.ConsortiumId = context.StringValue("DescribeConsortiumDeletable.Result.ConsortiumId");
			result.Name = context.StringValue("DescribeConsortiumDeletable.Result.Name");
			result.RegionId = context.StringValue("DescribeConsortiumDeletable.Result.RegionId");
			result.ZoneId = context.StringValue("DescribeConsortiumDeletable.Result.ZoneId");
			result.CodeName = context.StringValue("DescribeConsortiumDeletable.Result.CodeName");
			result.Domain = context.StringValue("DescribeConsortiumDeletable.Result.Domain");
			result.Description = context.StringValue("DescribeConsortiumDeletable.Result.Description");
			result.State = context.StringValue("DescribeConsortiumDeletable.Result.State");
			result.Deletable = context.BooleanValue("DescribeConsortiumDeletable.Result.Deletable");
			describeConsortiumDeletableResponse.Result = result;
        
			return describeConsortiumDeletableResponse;
        }
    }
}