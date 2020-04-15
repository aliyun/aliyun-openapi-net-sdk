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
using Aliyun.Acs.Smartag.Model.V20180313;

namespace Aliyun.Acs.Smartag.Transform.V20180313
{
    public class DescribeHealthChecksResponseUnmarshaller
    {
        public static DescribeHealthChecksResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeHealthChecksResponse describeHealthChecksResponse = new DescribeHealthChecksResponse();

			describeHealthChecksResponse.HttpResponse = context.HttpResponse;
			describeHealthChecksResponse.RequestId = context.StringValue("DescribeHealthChecks.RequestId");
			describeHealthChecksResponse.TotalCount = context.IntegerValue("DescribeHealthChecks.TotalCount");
			describeHealthChecksResponse.PageNumber = context.IntegerValue("DescribeHealthChecks.PageNumber");
			describeHealthChecksResponse.PageSize = context.IntegerValue("DescribeHealthChecks.PageSize");

			List<DescribeHealthChecksResponse.DescribeHealthChecks_HealthCheck> describeHealthChecksResponse_healthChecks = new List<DescribeHealthChecksResponse.DescribeHealthChecks_HealthCheck>();
			for (int i = 0; i < context.Length("DescribeHealthChecks.HealthChecks.Length"); i++) {
				DescribeHealthChecksResponse.DescribeHealthChecks_HealthCheck healthCheck = new DescribeHealthChecksResponse.DescribeHealthChecks_HealthCheck();
				healthCheck.HcInstanceId = context.StringValue("DescribeHealthChecks.HealthChecks["+ i +"].HcInstanceId");
				healthCheck.SmartAGId = context.StringValue("DescribeHealthChecks.HealthChecks["+ i +"].SmartAGId");
				healthCheck.Name = context.StringValue("DescribeHealthChecks.HealthChecks["+ i +"].Name");
				healthCheck.Description = context.StringValue("DescribeHealthChecks.HealthChecks["+ i +"].Description");
				healthCheck.Type = context.StringValue("DescribeHealthChecks.HealthChecks["+ i +"].Type");
				healthCheck.DstIpAddr = context.StringValue("DescribeHealthChecks.HealthChecks["+ i +"].DstIpAddr");
				healthCheck.DstPort = context.IntegerValue("DescribeHealthChecks.HealthChecks["+ i +"].DstPort");
				healthCheck.SrcIpAddr = context.StringValue("DescribeHealthChecks.HealthChecks["+ i +"].SrcIpAddr");
				healthCheck.SrcPort = context.IntegerValue("DescribeHealthChecks.HealthChecks["+ i +"].SrcPort");
				healthCheck.ProbeInterval = context.IntegerValue("DescribeHealthChecks.HealthChecks["+ i +"].ProbeInterval");
				healthCheck.ProbeCount = context.IntegerValue("DescribeHealthChecks.HealthChecks["+ i +"].ProbeCount");
				healthCheck.ProbeTimeout = context.IntegerValue("DescribeHealthChecks.HealthChecks["+ i +"].ProbeTimeout");
				healthCheck.RttThreshold = context.IntegerValue("DescribeHealthChecks.HealthChecks["+ i +"].RttThreshold");
				healthCheck.RttFailThreshold = context.IntegerValue("DescribeHealthChecks.HealthChecks["+ i +"].RttFailThreshold");
				healthCheck.FailCountThreshold = context.IntegerValue("DescribeHealthChecks.HealthChecks["+ i +"].FailCountThreshold");
				healthCheck.RelationCount = context.IntegerValue("DescribeHealthChecks.HealthChecks["+ i +"].RelationCount");
				healthCheck.Status = context.StringValue("DescribeHealthChecks.HealthChecks["+ i +"].Status");

				describeHealthChecksResponse_healthChecks.Add(healthCheck);
			}
			describeHealthChecksResponse.HealthChecks = describeHealthChecksResponse_healthChecks;
        
			return describeHealthChecksResponse;
        }
    }
}
