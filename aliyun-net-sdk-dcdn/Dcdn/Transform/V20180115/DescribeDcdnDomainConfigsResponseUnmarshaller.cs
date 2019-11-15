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
    public class DescribeDcdnDomainConfigsResponseUnmarshaller
    {
        public static DescribeDcdnDomainConfigsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeDcdnDomainConfigsResponse describeDcdnDomainConfigsResponse = new DescribeDcdnDomainConfigsResponse();

			describeDcdnDomainConfigsResponse.HttpResponse = context.HttpResponse;
			describeDcdnDomainConfigsResponse.RequestId = context.StringValue("DescribeDcdnDomainConfigs.RequestId");

			List<DescribeDcdnDomainConfigsResponse.DescribeDcdnDomainConfigs_DomainConfig> describeDcdnDomainConfigsResponse_domainConfigs = new List<DescribeDcdnDomainConfigsResponse.DescribeDcdnDomainConfigs_DomainConfig>();
			for (int i = 0; i < context.Length("DescribeDcdnDomainConfigs.DomainConfigs.Length"); i++) {
				DescribeDcdnDomainConfigsResponse.DescribeDcdnDomainConfigs_DomainConfig domainConfig = new DescribeDcdnDomainConfigsResponse.DescribeDcdnDomainConfigs_DomainConfig();
				domainConfig.FunctionName = context.StringValue("DescribeDcdnDomainConfigs.DomainConfigs["+ i +"].FunctionName");
				domainConfig.ConfigId = context.StringValue("DescribeDcdnDomainConfigs.DomainConfigs["+ i +"].ConfigId");
				domainConfig.Status = context.StringValue("DescribeDcdnDomainConfigs.DomainConfigs["+ i +"].Status");

				List<DescribeDcdnDomainConfigsResponse.DescribeDcdnDomainConfigs_DomainConfig.DescribeDcdnDomainConfigs_FunctionArg> domainConfig_functionArgs = new List<DescribeDcdnDomainConfigsResponse.DescribeDcdnDomainConfigs_DomainConfig.DescribeDcdnDomainConfigs_FunctionArg>();
				for (int j = 0; j < context.Length("DescribeDcdnDomainConfigs.DomainConfigs["+ i +"].FunctionArgs.Length"); j++) {
					DescribeDcdnDomainConfigsResponse.DescribeDcdnDomainConfigs_DomainConfig.DescribeDcdnDomainConfigs_FunctionArg functionArg = new DescribeDcdnDomainConfigsResponse.DescribeDcdnDomainConfigs_DomainConfig.DescribeDcdnDomainConfigs_FunctionArg();
					functionArg.ArgName = context.StringValue("DescribeDcdnDomainConfigs.DomainConfigs["+ i +"].FunctionArgs["+ j +"].ArgName");
					functionArg.ArgValue = context.StringValue("DescribeDcdnDomainConfigs.DomainConfigs["+ i +"].FunctionArgs["+ j +"].ArgValue");

					domainConfig_functionArgs.Add(functionArg);
				}
				domainConfig.FunctionArgs = domainConfig_functionArgs;

				describeDcdnDomainConfigsResponse_domainConfigs.Add(domainConfig);
			}
			describeDcdnDomainConfigsResponse.DomainConfigs = describeDcdnDomainConfigsResponse_domainConfigs;
        
			return describeDcdnDomainConfigsResponse;
        }
    }
}
