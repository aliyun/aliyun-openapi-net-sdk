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
    public class DescribeConfigOfVersionResponseUnmarshaller
    {
        public static DescribeConfigOfVersionResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeConfigOfVersionResponse describeConfigOfVersionResponse = new DescribeConfigOfVersionResponse();

			describeConfigOfVersionResponse.HttpResponse = _ctx.HttpResponse;
			describeConfigOfVersionResponse.RequestId = _ctx.StringValue("DescribeConfigOfVersion.RequestId");

			List<DescribeConfigOfVersionResponse.DescribeConfigOfVersion_VersionConfig> describeConfigOfVersionResponse_versionConfigs = new List<DescribeConfigOfVersionResponse.DescribeConfigOfVersion_VersionConfig>();
			for (int i = 0; i < _ctx.Length("DescribeConfigOfVersion.VersionConfigs.Length"); i++) {
				DescribeConfigOfVersionResponse.DescribeConfigOfVersion_VersionConfig versionConfig = new DescribeConfigOfVersionResponse.DescribeConfigOfVersion_VersionConfig();
				versionConfig.Status = _ctx.StringValue("DescribeConfigOfVersion.VersionConfigs["+ i +"].Status");
				versionConfig.ConfigId = _ctx.StringValue("DescribeConfigOfVersion.VersionConfigs["+ i +"].ConfigId");
				versionConfig.FunctionName = _ctx.StringValue("DescribeConfigOfVersion.VersionConfigs["+ i +"].FunctionName");

				List<DescribeConfigOfVersionResponse.DescribeConfigOfVersion_VersionConfig.DescribeConfigOfVersion_FunctionArg> versionConfig_functionArgs = new List<DescribeConfigOfVersionResponse.DescribeConfigOfVersion_VersionConfig.DescribeConfigOfVersion_FunctionArg>();
				for (int j = 0; j < _ctx.Length("DescribeConfigOfVersion.VersionConfigs["+ i +"].FunctionArgs.Length"); j++) {
					DescribeConfigOfVersionResponse.DescribeConfigOfVersion_VersionConfig.DescribeConfigOfVersion_FunctionArg functionArg = new DescribeConfigOfVersionResponse.DescribeConfigOfVersion_VersionConfig.DescribeConfigOfVersion_FunctionArg();
					functionArg.ArgName = _ctx.StringValue("DescribeConfigOfVersion.VersionConfigs["+ i +"].FunctionArgs["+ j +"].ArgName");
					functionArg.ArgValue = _ctx.StringValue("DescribeConfigOfVersion.VersionConfigs["+ i +"].FunctionArgs["+ j +"].ArgValue");

					versionConfig_functionArgs.Add(functionArg);
				}
				versionConfig.FunctionArgs = versionConfig_functionArgs;

				describeConfigOfVersionResponse_versionConfigs.Add(versionConfig);
			}
			describeConfigOfVersionResponse.VersionConfigs = describeConfigOfVersionResponse_versionConfigs;
        
			return describeConfigOfVersionResponse;
        }
    }
}
