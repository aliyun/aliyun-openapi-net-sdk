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
using Aliyun.Acs.vs.Model.V20181212;

namespace Aliyun.Acs.vs.Transform.V20181212
{
    public class DescribeVsDomainConfigsResponseUnmarshaller
    {
        public static DescribeVsDomainConfigsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeVsDomainConfigsResponse describeVsDomainConfigsResponse = new DescribeVsDomainConfigsResponse();

			describeVsDomainConfigsResponse.HttpResponse = context.HttpResponse;
			describeVsDomainConfigsResponse.RequestId = context.StringValue("DescribeVsDomainConfigs.RequestId");

			List<DescribeVsDomainConfigsResponse.DescribeVsDomainConfigs_DomainConfig> describeVsDomainConfigsResponse_domainConfigs = new List<DescribeVsDomainConfigsResponse.DescribeVsDomainConfigs_DomainConfig>();
			for (int i = 0; i < context.Length("DescribeVsDomainConfigs.DomainConfigs.Length"); i++) {
				DescribeVsDomainConfigsResponse.DescribeVsDomainConfigs_DomainConfig domainConfig = new DescribeVsDomainConfigsResponse.DescribeVsDomainConfigs_DomainConfig();
				domainConfig.FunctionName = context.StringValue("DescribeVsDomainConfigs.DomainConfigs["+ i +"].FunctionName");
				domainConfig.ConfigId = context.StringValue("DescribeVsDomainConfigs.DomainConfigs["+ i +"].ConfigId");
				domainConfig.Status = context.StringValue("DescribeVsDomainConfigs.DomainConfigs["+ i +"].Status");

				List<DescribeVsDomainConfigsResponse.DescribeVsDomainConfigs_DomainConfig.DescribeVsDomainConfigs_FunctionArg> domainConfig_functionArgs = new List<DescribeVsDomainConfigsResponse.DescribeVsDomainConfigs_DomainConfig.DescribeVsDomainConfigs_FunctionArg>();
				for (int j = 0; j < context.Length("DescribeVsDomainConfigs.DomainConfigs["+ i +"].FunctionArgs.Length"); j++) {
					DescribeVsDomainConfigsResponse.DescribeVsDomainConfigs_DomainConfig.DescribeVsDomainConfigs_FunctionArg functionArg = new DescribeVsDomainConfigsResponse.DescribeVsDomainConfigs_DomainConfig.DescribeVsDomainConfigs_FunctionArg();
					functionArg.ArgName = context.StringValue("DescribeVsDomainConfigs.DomainConfigs["+ i +"].FunctionArgs["+ j +"].ArgName");
					functionArg.ArgValue = context.StringValue("DescribeVsDomainConfigs.DomainConfigs["+ i +"].FunctionArgs["+ j +"].ArgValue");

					domainConfig_functionArgs.Add(functionArg);
				}
				domainConfig.FunctionArgs = domainConfig_functionArgs;

				describeVsDomainConfigsResponse_domainConfigs.Add(domainConfig);
			}
			describeVsDomainConfigsResponse.DomainConfigs = describeVsDomainConfigsResponse_domainConfigs;
        
			return describeVsDomainConfigsResponse;
        }
    }
}
