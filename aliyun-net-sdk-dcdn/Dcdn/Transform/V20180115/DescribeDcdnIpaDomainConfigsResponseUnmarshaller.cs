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
using Aliyun.Acs.dcdn.Model.V20180115;

namespace Aliyun.Acs.dcdn.Transform.V20180115
{
    public class DescribeDcdnIpaDomainConfigsResponseUnmarshaller
    {
        public static DescribeDcdnIpaDomainConfigsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDcdnIpaDomainConfigsResponse describeDcdnIpaDomainConfigsResponse = new DescribeDcdnIpaDomainConfigsResponse();

			describeDcdnIpaDomainConfigsResponse.HttpResponse = _ctx.HttpResponse;
			describeDcdnIpaDomainConfigsResponse.RequestId = _ctx.StringValue("DescribeDcdnIpaDomainConfigs.RequestId");

			List<DescribeDcdnIpaDomainConfigsResponse.DescribeDcdnIpaDomainConfigs_DomainConfig> describeDcdnIpaDomainConfigsResponse_domainConfigs = new List<DescribeDcdnIpaDomainConfigsResponse.DescribeDcdnIpaDomainConfigs_DomainConfig>();
			for (int i = 0; i < _ctx.Length("DescribeDcdnIpaDomainConfigs.DomainConfigs.Length"); i++) {
				DescribeDcdnIpaDomainConfigsResponse.DescribeDcdnIpaDomainConfigs_DomainConfig domainConfig = new DescribeDcdnIpaDomainConfigsResponse.DescribeDcdnIpaDomainConfigs_DomainConfig();
				domainConfig.FunctionName = _ctx.StringValue("DescribeDcdnIpaDomainConfigs.DomainConfigs["+ i +"].FunctionName");
				domainConfig.ConfigId = _ctx.StringValue("DescribeDcdnIpaDomainConfigs.DomainConfigs["+ i +"].ConfigId");
				domainConfig.Status = _ctx.StringValue("DescribeDcdnIpaDomainConfigs.DomainConfigs["+ i +"].Status");

				List<DescribeDcdnIpaDomainConfigsResponse.DescribeDcdnIpaDomainConfigs_DomainConfig.DescribeDcdnIpaDomainConfigs_FunctionArg> domainConfig_functionArgs = new List<DescribeDcdnIpaDomainConfigsResponse.DescribeDcdnIpaDomainConfigs_DomainConfig.DescribeDcdnIpaDomainConfigs_FunctionArg>();
				for (int j = 0; j < _ctx.Length("DescribeDcdnIpaDomainConfigs.DomainConfigs["+ i +"].FunctionArgs.Length"); j++) {
					DescribeDcdnIpaDomainConfigsResponse.DescribeDcdnIpaDomainConfigs_DomainConfig.DescribeDcdnIpaDomainConfigs_FunctionArg functionArg = new DescribeDcdnIpaDomainConfigsResponse.DescribeDcdnIpaDomainConfigs_DomainConfig.DescribeDcdnIpaDomainConfigs_FunctionArg();
					functionArg.ArgName = _ctx.StringValue("DescribeDcdnIpaDomainConfigs.DomainConfigs["+ i +"].FunctionArgs["+ j +"].ArgName");
					functionArg.ArgValue = _ctx.StringValue("DescribeDcdnIpaDomainConfigs.DomainConfigs["+ i +"].FunctionArgs["+ j +"].ArgValue");

					domainConfig_functionArgs.Add(functionArg);
				}
				domainConfig.FunctionArgs = domainConfig_functionArgs;

				describeDcdnIpaDomainConfigsResponse_domainConfigs.Add(domainConfig);
			}
			describeDcdnIpaDomainConfigsResponse.DomainConfigs = describeDcdnIpaDomainConfigsResponse_domainConfigs;
        
			return describeDcdnIpaDomainConfigsResponse;
        }
    }
}
