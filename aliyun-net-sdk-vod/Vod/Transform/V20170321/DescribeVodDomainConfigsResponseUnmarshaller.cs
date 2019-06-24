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
using Aliyun.Acs.vod.Model.V20170321;

namespace Aliyun.Acs.vod.Transform.V20170321
{
    public class DescribeVodDomainConfigsResponseUnmarshaller
    {
        public static DescribeVodDomainConfigsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeVodDomainConfigsResponse describeVodDomainConfigsResponse = new DescribeVodDomainConfigsResponse();

			describeVodDomainConfigsResponse.HttpResponse = context.HttpResponse;
			describeVodDomainConfigsResponse.RequestId = context.StringValue("DescribeVodDomainConfigs.RequestId");

			List<DescribeVodDomainConfigsResponse.DescribeVodDomainConfigs_DomainConfig> describeVodDomainConfigsResponse_domainConfigs = new List<DescribeVodDomainConfigsResponse.DescribeVodDomainConfigs_DomainConfig>();
			for (int i = 0; i < context.Length("DescribeVodDomainConfigs.DomainConfigs.Length"); i++) {
				DescribeVodDomainConfigsResponse.DescribeVodDomainConfigs_DomainConfig domainConfig = new DescribeVodDomainConfigsResponse.DescribeVodDomainConfigs_DomainConfig();
				domainConfig.FunctionName = context.StringValue("DescribeVodDomainConfigs.DomainConfigs["+ i +"].FunctionName");
				domainConfig.ConfigId = context.StringValue("DescribeVodDomainConfigs.DomainConfigs["+ i +"].ConfigId");
				domainConfig.Status = context.StringValue("DescribeVodDomainConfigs.DomainConfigs["+ i +"].Status");

				List<DescribeVodDomainConfigsResponse.DescribeVodDomainConfigs_DomainConfig.DescribeVodDomainConfigs_FunctionArg> domainConfig_functionArgs = new List<DescribeVodDomainConfigsResponse.DescribeVodDomainConfigs_DomainConfig.DescribeVodDomainConfigs_FunctionArg>();
				for (int j = 0; j < context.Length("DescribeVodDomainConfigs.DomainConfigs["+ i +"].FunctionArgs.Length"); j++) {
					DescribeVodDomainConfigsResponse.DescribeVodDomainConfigs_DomainConfig.DescribeVodDomainConfigs_FunctionArg functionArg = new DescribeVodDomainConfigsResponse.DescribeVodDomainConfigs_DomainConfig.DescribeVodDomainConfigs_FunctionArg();
					functionArg.ArgName = context.StringValue("DescribeVodDomainConfigs.DomainConfigs["+ i +"].FunctionArgs["+ j +"].ArgName");
					functionArg.ArgValue = context.StringValue("DescribeVodDomainConfigs.DomainConfigs["+ i +"].FunctionArgs["+ j +"].ArgValue");

					domainConfig_functionArgs.Add(functionArg);
				}
				domainConfig.FunctionArgs = domainConfig_functionArgs;

				describeVodDomainConfigsResponse_domainConfigs.Add(domainConfig);
			}
			describeVodDomainConfigsResponse.DomainConfigs = describeVodDomainConfigsResponse_domainConfigs;
        
			return describeVodDomainConfigsResponse;
        }
    }
}
