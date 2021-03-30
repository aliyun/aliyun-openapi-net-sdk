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
using Aliyun.Acs.Airec.Model.V20201126;

namespace Aliyun.Acs.Airec.Transform.V20201126
{
    public class DescribeSceneBucketResponseUnmarshaller
    {
        public static DescribeSceneBucketResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeSceneBucketResponse describeSceneBucketResponse = new DescribeSceneBucketResponse();

			describeSceneBucketResponse.HttpResponse = _ctx.HttpResponse;
			describeSceneBucketResponse.RequestId = _ctx.StringValue("DescribeSceneBucket.requestId");

			DescribeSceneBucketResponse.DescribeSceneBucket_Result result = new DescribeSceneBucketResponse.DescribeSceneBucket_Result();
			result.Num = _ctx.IntegerValue("DescribeSceneBucket.Result.num");
			result.InUse = _ctx.StringValue("DescribeSceneBucket.Result.inUse");
			result.Detail = _ctx.StringValue("DescribeSceneBucket.Result.detail");
			describeSceneBucketResponse.Result = result;
        
			return describeSceneBucketResponse;
        }
    }
}
