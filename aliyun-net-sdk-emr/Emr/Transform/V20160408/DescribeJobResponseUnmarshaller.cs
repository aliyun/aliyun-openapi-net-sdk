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
    public class DescribeJobResponseUnmarshaller
    {
        public static DescribeJobResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeJobResponse describeJobResponse = new DescribeJobResponse();

			describeJobResponse.HttpResponse = _ctx.HttpResponse;
			describeJobResponse.RequestId = _ctx.StringValue("DescribeJob.RequestId");
			describeJobResponse.Id = _ctx.StringValue("DescribeJob.Id");
			describeJobResponse.Name = _ctx.StringValue("DescribeJob.Name");
			describeJobResponse.FailAct = _ctx.StringValue("DescribeJob.FailAct");
			describeJobResponse.Type = _ctx.StringValue("DescribeJob.Type");
			describeJobResponse.MaxRetry = _ctx.IntegerValue("DescribeJob.MaxRetry");
			describeJobResponse.RetryInterval = _ctx.IntegerValue("DescribeJob.RetryInterval");
			describeJobResponse.RunParameter = _ctx.StringValue("DescribeJob.RunParameter");
        
			return describeJobResponse;
        }
    }
}
