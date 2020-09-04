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
    public class DescribeDcdnConfigOfVersionResponseUnmarshaller
    {
        public static DescribeDcdnConfigOfVersionResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeDcdnConfigOfVersionResponse describeDcdnConfigOfVersionResponse = new DescribeDcdnConfigOfVersionResponse();

			describeDcdnConfigOfVersionResponse.HttpResponse = context.HttpResponse;
			describeDcdnConfigOfVersionResponse.RequestId = context.StringValue("DescribeDcdnConfigOfVersion.RequestId");

			List<DescribeDcdnConfigOfVersionResponse.DescribeDcdnConfigOfVersion_VersionConfig> describeDcdnConfigOfVersionResponse_versionConfigs = new List<DescribeDcdnConfigOfVersionResponse.DescribeDcdnConfigOfVersion_VersionConfig>();
			for (int i = 0; i < context.Length("DescribeDcdnConfigOfVersion.VersionConfigs.Length"); i++) {
				DescribeDcdnConfigOfVersionResponse.DescribeDcdnConfigOfVersion_VersionConfig versionConfig = new DescribeDcdnConfigOfVersionResponse.DescribeDcdnConfigOfVersion_VersionConfig();
				versionConfig.Status = context.StringValue("DescribeDcdnConfigOfVersion.VersionConfigs["+ i +"].Status");
				versionConfig.ConfigId = context.StringValue("DescribeDcdnConfigOfVersion.VersionConfigs["+ i +"].ConfigId");
				versionConfig.FunctionName = context.StringValue("DescribeDcdnConfigOfVersion.VersionConfigs["+ i +"].FunctionName");

				List<DescribeDcdnConfigOfVersionResponse.DescribeDcdnConfigOfVersion_VersionConfig.DescribeDcdnConfigOfVersion_FunctionArg> versionConfig_functionArgs = new List<DescribeDcdnConfigOfVersionResponse.DescribeDcdnConfigOfVersion_VersionConfig.DescribeDcdnConfigOfVersion_FunctionArg>();
				for (int j = 0; j < context.Length("DescribeDcdnConfigOfVersion.VersionConfigs["+ i +"].FunctionArgs.Length"); j++) {
					DescribeDcdnConfigOfVersionResponse.DescribeDcdnConfigOfVersion_VersionConfig.DescribeDcdnConfigOfVersion_FunctionArg functionArg = new DescribeDcdnConfigOfVersionResponse.DescribeDcdnConfigOfVersion_VersionConfig.DescribeDcdnConfigOfVersion_FunctionArg();
					functionArg.ArgName = context.StringValue("DescribeDcdnConfigOfVersion.VersionConfigs["+ i +"].FunctionArgs["+ j +"].ArgName");
					functionArg.ArgValue = context.StringValue("DescribeDcdnConfigOfVersion.VersionConfigs["+ i +"].FunctionArgs["+ j +"].ArgValue");

					versionConfig_functionArgs.Add(functionArg);
				}
				versionConfig.FunctionArgs = versionConfig_functionArgs;

				describeDcdnConfigOfVersionResponse_versionConfigs.Add(versionConfig);
			}
			describeDcdnConfigOfVersionResponse.VersionConfigs = describeDcdnConfigOfVersionResponse_versionConfigs;
        
			return describeDcdnConfigOfVersionResponse;
        }
    }
}
