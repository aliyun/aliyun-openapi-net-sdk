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
using Aliyun.Acs.cloud_siem.Model.V20220616;

namespace Aliyun.Acs.cloud_siem.Transform.V20220616
{
    public class DescribeAutomateResponseConfigCounterResponseUnmarshaller
    {
        public static DescribeAutomateResponseConfigCounterResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeAutomateResponseConfigCounterResponse describeAutomateResponseConfigCounterResponse = new DescribeAutomateResponseConfigCounterResponse();

			describeAutomateResponseConfigCounterResponse.HttpResponse = _ctx.HttpResponse;
			describeAutomateResponseConfigCounterResponse.Success = _ctx.BooleanValue("DescribeAutomateResponseConfigCounter.Success");
			describeAutomateResponseConfigCounterResponse.Code = _ctx.IntegerValue("DescribeAutomateResponseConfigCounter.Code");
			describeAutomateResponseConfigCounterResponse.Message = _ctx.StringValue("DescribeAutomateResponseConfigCounter.Message");
			describeAutomateResponseConfigCounterResponse.RequestId = _ctx.StringValue("DescribeAutomateResponseConfigCounter.RequestId");

			DescribeAutomateResponseConfigCounterResponse.DescribeAutomateResponseConfigCounter_Data data = new DescribeAutomateResponseConfigCounterResponse.DescribeAutomateResponseConfigCounter_Data();
			data.All = _ctx.LongValue("DescribeAutomateResponseConfigCounter.Data.All");
			data.Online = _ctx.LongValue("DescribeAutomateResponseConfigCounter.Data.Online");
			describeAutomateResponseConfigCounterResponse.Data = data;
        
			return describeAutomateResponseConfigCounterResponse;
        }
    }
}
