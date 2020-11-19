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
using Aliyun.Acs.Cdn.Model.V20180510;

namespace Aliyun.Acs.Cdn.Transform.V20180510
{
    public class DescribeCdnDomainStagingConfigResponseUnmarshaller
    {
        public static DescribeCdnDomainStagingConfigResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeCdnDomainStagingConfigResponse describeCdnDomainStagingConfigResponse = new DescribeCdnDomainStagingConfigResponse();

			describeCdnDomainStagingConfigResponse.HttpResponse = _ctx.HttpResponse;
			describeCdnDomainStagingConfigResponse.RequestId = _ctx.StringValue("DescribeCdnDomainStagingConfig.RequestId");

			List<DescribeCdnDomainStagingConfigResponse.DescribeCdnDomainStagingConfig_DomainConfig> describeCdnDomainStagingConfigResponse_domainConfigs = new List<DescribeCdnDomainStagingConfigResponse.DescribeCdnDomainStagingConfig_DomainConfig>();
			for (int i = 0; i < _ctx.Length("DescribeCdnDomainStagingConfig.DomainConfigs.Length"); i++) {
				DescribeCdnDomainStagingConfigResponse.DescribeCdnDomainStagingConfig_DomainConfig domainConfig = new DescribeCdnDomainStagingConfigResponse.DescribeCdnDomainStagingConfig_DomainConfig();
				domainConfig.FunctionName = _ctx.StringValue("DescribeCdnDomainStagingConfig.DomainConfigs["+ i +"].FunctionName");
				domainConfig.ConfigId = _ctx.StringValue("DescribeCdnDomainStagingConfig.DomainConfigs["+ i +"].ConfigId");
				domainConfig.Status = _ctx.StringValue("DescribeCdnDomainStagingConfig.DomainConfigs["+ i +"].Status");

				List<DescribeCdnDomainStagingConfigResponse.DescribeCdnDomainStagingConfig_DomainConfig.DescribeCdnDomainStagingConfig_FunctionArg> domainConfig_functionArgs = new List<DescribeCdnDomainStagingConfigResponse.DescribeCdnDomainStagingConfig_DomainConfig.DescribeCdnDomainStagingConfig_FunctionArg>();
				for (int j = 0; j < _ctx.Length("DescribeCdnDomainStagingConfig.DomainConfigs["+ i +"].FunctionArgs.Length"); j++) {
					DescribeCdnDomainStagingConfigResponse.DescribeCdnDomainStagingConfig_DomainConfig.DescribeCdnDomainStagingConfig_FunctionArg functionArg = new DescribeCdnDomainStagingConfigResponse.DescribeCdnDomainStagingConfig_DomainConfig.DescribeCdnDomainStagingConfig_FunctionArg();
					functionArg.ArgName = _ctx.StringValue("DescribeCdnDomainStagingConfig.DomainConfigs["+ i +"].FunctionArgs["+ j +"].ArgName");
					functionArg.ArgValue = _ctx.StringValue("DescribeCdnDomainStagingConfig.DomainConfigs["+ i +"].FunctionArgs["+ j +"].ArgValue");

					domainConfig_functionArgs.Add(functionArg);
				}
				domainConfig.FunctionArgs = domainConfig_functionArgs;

				describeCdnDomainStagingConfigResponse_domainConfigs.Add(domainConfig);
			}
			describeCdnDomainStagingConfigResponse.DomainConfigs = describeCdnDomainStagingConfigResponse_domainConfigs;
        
			return describeCdnDomainStagingConfigResponse;
        }
    }
}
