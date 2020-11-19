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
    public class DescribeCdnDomainConfigsResponseUnmarshaller
    {
        public static DescribeCdnDomainConfigsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeCdnDomainConfigsResponse describeCdnDomainConfigsResponse = new DescribeCdnDomainConfigsResponse();

			describeCdnDomainConfigsResponse.HttpResponse = _ctx.HttpResponse;
			describeCdnDomainConfigsResponse.RequestId = _ctx.StringValue("DescribeCdnDomainConfigs.RequestId");

			List<DescribeCdnDomainConfigsResponse.DescribeCdnDomainConfigs_DomainConfig> describeCdnDomainConfigsResponse_domainConfigs = new List<DescribeCdnDomainConfigsResponse.DescribeCdnDomainConfigs_DomainConfig>();
			for (int i = 0; i < _ctx.Length("DescribeCdnDomainConfigs.DomainConfigs.Length"); i++) {
				DescribeCdnDomainConfigsResponse.DescribeCdnDomainConfigs_DomainConfig domainConfig = new DescribeCdnDomainConfigsResponse.DescribeCdnDomainConfigs_DomainConfig();
				domainConfig.FunctionName = _ctx.StringValue("DescribeCdnDomainConfigs.DomainConfigs["+ i +"].FunctionName");
				domainConfig.ConfigId = _ctx.StringValue("DescribeCdnDomainConfigs.DomainConfigs["+ i +"].ConfigId");
				domainConfig.Status = _ctx.StringValue("DescribeCdnDomainConfigs.DomainConfigs["+ i +"].Status");

				List<DescribeCdnDomainConfigsResponse.DescribeCdnDomainConfigs_DomainConfig.DescribeCdnDomainConfigs_FunctionArg> domainConfig_functionArgs = new List<DescribeCdnDomainConfigsResponse.DescribeCdnDomainConfigs_DomainConfig.DescribeCdnDomainConfigs_FunctionArg>();
				for (int j = 0; j < _ctx.Length("DescribeCdnDomainConfigs.DomainConfigs["+ i +"].FunctionArgs.Length"); j++) {
					DescribeCdnDomainConfigsResponse.DescribeCdnDomainConfigs_DomainConfig.DescribeCdnDomainConfigs_FunctionArg functionArg = new DescribeCdnDomainConfigsResponse.DescribeCdnDomainConfigs_DomainConfig.DescribeCdnDomainConfigs_FunctionArg();
					functionArg.ArgName = _ctx.StringValue("DescribeCdnDomainConfigs.DomainConfigs["+ i +"].FunctionArgs["+ j +"].ArgName");
					functionArg.ArgValue = _ctx.StringValue("DescribeCdnDomainConfigs.DomainConfigs["+ i +"].FunctionArgs["+ j +"].ArgValue");

					domainConfig_functionArgs.Add(functionArg);
				}
				domainConfig.FunctionArgs = domainConfig_functionArgs;

				describeCdnDomainConfigsResponse_domainConfigs.Add(domainConfig);
			}
			describeCdnDomainConfigsResponse.DomainConfigs = describeCdnDomainConfigsResponse_domainConfigs;
        
			return describeCdnDomainConfigsResponse;
        }
    }
}
