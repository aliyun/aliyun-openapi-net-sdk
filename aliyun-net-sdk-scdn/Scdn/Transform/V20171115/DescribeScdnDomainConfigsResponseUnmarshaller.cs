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
using Aliyun.Acs.scdn.Model.V20171115;

namespace Aliyun.Acs.scdn.Transform.V20171115
{
    public class DescribeScdnDomainConfigsResponseUnmarshaller
    {
        public static DescribeScdnDomainConfigsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeScdnDomainConfigsResponse describeScdnDomainConfigsResponse = new DescribeScdnDomainConfigsResponse();

			describeScdnDomainConfigsResponse.HttpResponse = context.HttpResponse;
			describeScdnDomainConfigsResponse.RequestId = context.StringValue("DescribeScdnDomainConfigs.RequestId");

			List<DescribeScdnDomainConfigsResponse.DescribeScdnDomainConfigs_DomainConfig> describeScdnDomainConfigsResponse_domainConfigs = new List<DescribeScdnDomainConfigsResponse.DescribeScdnDomainConfigs_DomainConfig>();
			for (int i = 0; i < context.Length("DescribeScdnDomainConfigs.DomainConfigs.Length"); i++) {
				DescribeScdnDomainConfigsResponse.DescribeScdnDomainConfigs_DomainConfig domainConfig = new DescribeScdnDomainConfigsResponse.DescribeScdnDomainConfigs_DomainConfig();
				domainConfig.FunctionName = context.StringValue("DescribeScdnDomainConfigs.DomainConfigs["+ i +"].FunctionName");
				domainConfig.ConfigId = context.StringValue("DescribeScdnDomainConfigs.DomainConfigs["+ i +"].ConfigId");
				domainConfig.Status = context.StringValue("DescribeScdnDomainConfigs.DomainConfigs["+ i +"].Status");

				List<DescribeScdnDomainConfigsResponse.DescribeScdnDomainConfigs_DomainConfig.DescribeScdnDomainConfigs_FunctionArg> domainConfig_functionArgs = new List<DescribeScdnDomainConfigsResponse.DescribeScdnDomainConfigs_DomainConfig.DescribeScdnDomainConfigs_FunctionArg>();
				for (int j = 0; j < context.Length("DescribeScdnDomainConfigs.DomainConfigs["+ i +"].FunctionArgs.Length"); j++) {
					DescribeScdnDomainConfigsResponse.DescribeScdnDomainConfigs_DomainConfig.DescribeScdnDomainConfigs_FunctionArg functionArg = new DescribeScdnDomainConfigsResponse.DescribeScdnDomainConfigs_DomainConfig.DescribeScdnDomainConfigs_FunctionArg();
					functionArg.ArgName = context.StringValue("DescribeScdnDomainConfigs.DomainConfigs["+ i +"].FunctionArgs["+ j +"].ArgName");
					functionArg.ArgValue = context.StringValue("DescribeScdnDomainConfigs.DomainConfigs["+ i +"].FunctionArgs["+ j +"].ArgValue");

					domainConfig_functionArgs.Add(functionArg);
				}
				domainConfig.FunctionArgs = domainConfig_functionArgs;

				describeScdnDomainConfigsResponse_domainConfigs.Add(domainConfig);
			}
			describeScdnDomainConfigsResponse.DomainConfigs = describeScdnDomainConfigsResponse_domainConfigs;
        
			return describeScdnDomainConfigsResponse;
        }
    }
}
