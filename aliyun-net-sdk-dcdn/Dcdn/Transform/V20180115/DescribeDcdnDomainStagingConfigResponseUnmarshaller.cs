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
    public class DescribeDcdnDomainStagingConfigResponseUnmarshaller
    {
        public static DescribeDcdnDomainStagingConfigResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeDcdnDomainStagingConfigResponse describeDcdnDomainStagingConfigResponse = new DescribeDcdnDomainStagingConfigResponse();

			describeDcdnDomainStagingConfigResponse.HttpResponse = context.HttpResponse;
			describeDcdnDomainStagingConfigResponse.RequestId = context.StringValue("DescribeDcdnDomainStagingConfig.RequestId");

			List<DescribeDcdnDomainStagingConfigResponse.DescribeDcdnDomainStagingConfig_DomainConfig> describeDcdnDomainStagingConfigResponse_domainConfigs = new List<DescribeDcdnDomainStagingConfigResponse.DescribeDcdnDomainStagingConfig_DomainConfig>();
			for (int i = 0; i < context.Length("DescribeDcdnDomainStagingConfig.DomainConfigs.Length"); i++) {
				DescribeDcdnDomainStagingConfigResponse.DescribeDcdnDomainStagingConfig_DomainConfig domainConfig = new DescribeDcdnDomainStagingConfigResponse.DescribeDcdnDomainStagingConfig_DomainConfig();
				domainConfig.FunctionName = context.StringValue("DescribeDcdnDomainStagingConfig.DomainConfigs["+ i +"].FunctionName");
				domainConfig.ConfigId = context.StringValue("DescribeDcdnDomainStagingConfig.DomainConfigs["+ i +"].ConfigId");
				domainConfig.Status = context.StringValue("DescribeDcdnDomainStagingConfig.DomainConfigs["+ i +"].Status");

				List<DescribeDcdnDomainStagingConfigResponse.DescribeDcdnDomainStagingConfig_DomainConfig.DescribeDcdnDomainStagingConfig_FunctionArg> domainConfig_functionArgs = new List<DescribeDcdnDomainStagingConfigResponse.DescribeDcdnDomainStagingConfig_DomainConfig.DescribeDcdnDomainStagingConfig_FunctionArg>();
				for (int j = 0; j < context.Length("DescribeDcdnDomainStagingConfig.DomainConfigs["+ i +"].FunctionArgs.Length"); j++) {
					DescribeDcdnDomainStagingConfigResponse.DescribeDcdnDomainStagingConfig_DomainConfig.DescribeDcdnDomainStagingConfig_FunctionArg functionArg = new DescribeDcdnDomainStagingConfigResponse.DescribeDcdnDomainStagingConfig_DomainConfig.DescribeDcdnDomainStagingConfig_FunctionArg();
					functionArg.ArgName = context.StringValue("DescribeDcdnDomainStagingConfig.DomainConfigs["+ i +"].FunctionArgs["+ j +"].ArgName");
					functionArg.ArgValue = context.StringValue("DescribeDcdnDomainStagingConfig.DomainConfigs["+ i +"].FunctionArgs["+ j +"].ArgValue");

					domainConfig_functionArgs.Add(functionArg);
				}
				domainConfig.FunctionArgs = domainConfig_functionArgs;

				describeDcdnDomainStagingConfigResponse_domainConfigs.Add(domainConfig);
			}
			describeDcdnDomainStagingConfigResponse.DomainConfigs = describeDcdnDomainStagingConfigResponse_domainConfigs;
        
			return describeDcdnDomainStagingConfigResponse;
        }
    }
}
