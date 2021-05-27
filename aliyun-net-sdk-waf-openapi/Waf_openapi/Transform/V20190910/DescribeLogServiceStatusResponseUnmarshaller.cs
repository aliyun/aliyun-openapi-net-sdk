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
using Aliyun.Acs.waf_openapi.Model.V20190910;

namespace Aliyun.Acs.waf_openapi.Transform.V20190910
{
    public class DescribeLogServiceStatusResponseUnmarshaller
    {
        public static DescribeLogServiceStatusResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeLogServiceStatusResponse describeLogServiceStatusResponse = new DescribeLogServiceStatusResponse();

			describeLogServiceStatusResponse.HttpResponse = _ctx.HttpResponse;
			describeLogServiceStatusResponse.RequestId = _ctx.StringValue("DescribeLogServiceStatus.RequestId");
			describeLogServiceStatusResponse.TotalCount = _ctx.IntegerValue("DescribeLogServiceStatus.TotalCount");

			List<DescribeLogServiceStatusResponse.DescribeLogServiceStatus_Status> describeLogServiceStatusResponse_domainStatus = new List<DescribeLogServiceStatusResponse.DescribeLogServiceStatus_Status>();
			for (int i = 0; i < _ctx.Length("DescribeLogServiceStatus.DomainStatus.Length"); i++) {
				DescribeLogServiceStatusResponse.DescribeLogServiceStatus_Status status = new DescribeLogServiceStatusResponse.DescribeLogServiceStatus_Status();
				status.SlsLogActive = _ctx.IntegerValue("DescribeLogServiceStatus.DomainStatus["+ i +"].SlsLogActive");
				status.Domain = _ctx.StringValue("DescribeLogServiceStatus.DomainStatus["+ i +"].Domain");

				describeLogServiceStatusResponse_domainStatus.Add(status);
			}
			describeLogServiceStatusResponse.DomainStatus = describeLogServiceStatusResponse_domainStatus;
        
			return describeLogServiceStatusResponse;
        }
    }
}
