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
using Aliyun.Acs.retailcloud.Model.V20180313;

namespace Aliyun.Acs.retailcloud.Transform.V20180313
{
    public class DescribeAppResourceAllocResponseUnmarshaller
    {
        public static DescribeAppResourceAllocResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeAppResourceAllocResponse describeAppResourceAllocResponse = new DescribeAppResourceAllocResponse();

			describeAppResourceAllocResponse.HttpResponse = _ctx.HttpResponse;
			describeAppResourceAllocResponse.Code = _ctx.IntegerValue("DescribeAppResourceAlloc.Code");
			describeAppResourceAllocResponse.ErrMsg = _ctx.StringValue("DescribeAppResourceAlloc.ErrMsg");
			describeAppResourceAllocResponse.RequestId = _ctx.StringValue("DescribeAppResourceAlloc.RequestId");
			describeAppResourceAllocResponse.Success = _ctx.BooleanValue("DescribeAppResourceAlloc.Success");

			DescribeAppResourceAllocResponse.DescribeAppResourceAlloc_Result result = new DescribeAppResourceAllocResponse.DescribeAppResourceAlloc_Result();
			result.AppEnvId = _ctx.LongValue("DescribeAppResourceAlloc.Result.AppEnvId");
			result.AppId = _ctx.LongValue("DescribeAppResourceAlloc.Result.AppId");
			result.ClusterId = _ctx.StringValue("DescribeAppResourceAlloc.Result.ClusterId");
			result.Id = _ctx.LongValue("DescribeAppResourceAlloc.Result.Id");
			result.ResourceDef = _ctx.StringValue("DescribeAppResourceAlloc.Result.ResourceDef");
			describeAppResourceAllocResponse.Result = result;
        
			return describeAppResourceAllocResponse;
        }
    }
}
