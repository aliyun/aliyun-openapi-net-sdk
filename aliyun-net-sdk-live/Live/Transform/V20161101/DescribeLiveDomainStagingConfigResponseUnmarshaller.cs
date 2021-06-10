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
using Aliyun.Acs.live.Model.V20161101;

namespace Aliyun.Acs.live.Transform.V20161101
{
    public class DescribeLiveDomainStagingConfigResponseUnmarshaller
    {
        public static DescribeLiveDomainStagingConfigResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeLiveDomainStagingConfigResponse describeLiveDomainStagingConfigResponse = new DescribeLiveDomainStagingConfigResponse();

			describeLiveDomainStagingConfigResponse.HttpResponse = _ctx.HttpResponse;
			describeLiveDomainStagingConfigResponse.RequestId = _ctx.StringValue("DescribeLiveDomainStagingConfig.RequestId");

			List<DescribeLiveDomainStagingConfigResponse.DescribeLiveDomainStagingConfig_DomainConfig> describeLiveDomainStagingConfigResponse_domainConfigs = new List<DescribeLiveDomainStagingConfigResponse.DescribeLiveDomainStagingConfig_DomainConfig>();
			for (int i = 0; i < _ctx.Length("DescribeLiveDomainStagingConfig.DomainConfigs.Length"); i++) {
				DescribeLiveDomainStagingConfigResponse.DescribeLiveDomainStagingConfig_DomainConfig domainConfig = new DescribeLiveDomainStagingConfigResponse.DescribeLiveDomainStagingConfig_DomainConfig();
				domainConfig.FunctionName = _ctx.StringValue("DescribeLiveDomainStagingConfig.DomainConfigs["+ i +"].FunctionName");
				domainConfig.ConfigId = _ctx.StringValue("DescribeLiveDomainStagingConfig.DomainConfigs["+ i +"].ConfigId");
				domainConfig.Status = _ctx.StringValue("DescribeLiveDomainStagingConfig.DomainConfigs["+ i +"].Status");

				List<DescribeLiveDomainStagingConfigResponse.DescribeLiveDomainStagingConfig_DomainConfig.DescribeLiveDomainStagingConfig_FunctionArg> domainConfig_functionArgs = new List<DescribeLiveDomainStagingConfigResponse.DescribeLiveDomainStagingConfig_DomainConfig.DescribeLiveDomainStagingConfig_FunctionArg>();
				for (int j = 0; j < _ctx.Length("DescribeLiveDomainStagingConfig.DomainConfigs["+ i +"].FunctionArgs.Length"); j++) {
					DescribeLiveDomainStagingConfigResponse.DescribeLiveDomainStagingConfig_DomainConfig.DescribeLiveDomainStagingConfig_FunctionArg functionArg = new DescribeLiveDomainStagingConfigResponse.DescribeLiveDomainStagingConfig_DomainConfig.DescribeLiveDomainStagingConfig_FunctionArg();
					functionArg.ArgName = _ctx.StringValue("DescribeLiveDomainStagingConfig.DomainConfigs["+ i +"].FunctionArgs["+ j +"].ArgName");
					functionArg.ArgValue = _ctx.StringValue("DescribeLiveDomainStagingConfig.DomainConfigs["+ i +"].FunctionArgs["+ j +"].ArgValue");

					domainConfig_functionArgs.Add(functionArg);
				}
				domainConfig.FunctionArgs = domainConfig_functionArgs;

				describeLiveDomainStagingConfigResponse_domainConfigs.Add(domainConfig);
			}
			describeLiveDomainStagingConfigResponse.DomainConfigs = describeLiveDomainStagingConfigResponse_domainConfigs;
        
			return describeLiveDomainStagingConfigResponse;
        }
    }
}
