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
using Aliyun.Acs.adb.Model.V20211201;

namespace Aliyun.Acs.adb.Transform.V20211201
{
    public class DescribeDBClusterHealthStatusResponseUnmarshaller
    {
        public static DescribeDBClusterHealthStatusResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDBClusterHealthStatusResponse describeDBClusterHealthStatusResponse = new DescribeDBClusterHealthStatusResponse();

			describeDBClusterHealthStatusResponse.HttpResponse = _ctx.HttpResponse;
			describeDBClusterHealthStatusResponse.InstanceStatus = _ctx.StringValue("DescribeDBClusterHealthStatus.InstanceStatus");
			describeDBClusterHealthStatusResponse.RequestId = _ctx.StringValue("DescribeDBClusterHealthStatus.RequestId");

			DescribeDBClusterHealthStatusResponse.DescribeDBClusterHealthStatus_CS cS = new DescribeDBClusterHealthStatusResponse.DescribeDBClusterHealthStatus_CS();
			cS.ActiveCount = _ctx.LongValue("DescribeDBClusterHealthStatus.CS.ActiveCount");
			cS.UnavailableCount = _ctx.LongValue("DescribeDBClusterHealthStatus.CS.UnavailableCount");
			cS.RiskCount = _ctx.LongValue("DescribeDBClusterHealthStatus.CS.RiskCount");
			cS.ExpectedCount = _ctx.LongValue("DescribeDBClusterHealthStatus.CS.ExpectedCount");
			cS.Status = _ctx.StringValue("DescribeDBClusterHealthStatus.CS.Status");
			describeDBClusterHealthStatusResponse.CS = cS;

			DescribeDBClusterHealthStatusResponse.DescribeDBClusterHealthStatus_Executor executor = new DescribeDBClusterHealthStatusResponse.DescribeDBClusterHealthStatus_Executor();
			executor.ActiveCount = _ctx.LongValue("DescribeDBClusterHealthStatus.Executor.ActiveCount");
			executor.UnavailableCount = _ctx.LongValue("DescribeDBClusterHealthStatus.Executor.UnavailableCount");
			executor.RiskCount = _ctx.LongValue("DescribeDBClusterHealthStatus.Executor.RiskCount");
			executor.ExpectedCount = _ctx.LongValue("DescribeDBClusterHealthStatus.Executor.ExpectedCount");
			executor.Status = _ctx.StringValue("DescribeDBClusterHealthStatus.Executor.Status");
			describeDBClusterHealthStatusResponse.Executor = executor;

			DescribeDBClusterHealthStatusResponse.DescribeDBClusterHealthStatus_Worker worker = new DescribeDBClusterHealthStatusResponse.DescribeDBClusterHealthStatus_Worker();
			worker.ActiveCount = _ctx.LongValue("DescribeDBClusterHealthStatus.Worker.ActiveCount");
			worker.UnavailableCount = _ctx.LongValue("DescribeDBClusterHealthStatus.Worker.UnavailableCount");
			worker.RiskCount = _ctx.LongValue("DescribeDBClusterHealthStatus.Worker.RiskCount");
			worker.ExpectedCount = _ctx.LongValue("DescribeDBClusterHealthStatus.Worker.ExpectedCount");
			worker.Status = _ctx.StringValue("DescribeDBClusterHealthStatus.Worker.Status");
			describeDBClusterHealthStatusResponse.Worker = worker;
        
			return describeDBClusterHealthStatusResponse;
        }
    }
}
