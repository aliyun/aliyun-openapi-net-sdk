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
    public class DescribeCdnUserConfigsResponseUnmarshaller
    {
        public static DescribeCdnUserConfigsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeCdnUserConfigsResponse describeCdnUserConfigsResponse = new DescribeCdnUserConfigsResponse();

			describeCdnUserConfigsResponse.HttpResponse = _ctx.HttpResponse;
			describeCdnUserConfigsResponse.RequestId = _ctx.StringValue("DescribeCdnUserConfigs.RequestId");

			List<DescribeCdnUserConfigsResponse.DescribeCdnUserConfigs_Config> describeCdnUserConfigsResponse_configs = new List<DescribeCdnUserConfigsResponse.DescribeCdnUserConfigs_Config>();
			for (int i = 0; i < _ctx.Length("DescribeCdnUserConfigs.Configs.Length"); i++) {
				DescribeCdnUserConfigsResponse.DescribeCdnUserConfigs_Config config = new DescribeCdnUserConfigsResponse.DescribeCdnUserConfigs_Config();
				config.ArgValue = _ctx.StringValue("DescribeCdnUserConfigs.Configs["+ i +"].ArgValue");
				config.ArgName = _ctx.StringValue("DescribeCdnUserConfigs.Configs["+ i +"].ArgName");
				config.FunctionName = _ctx.StringValue("DescribeCdnUserConfigs.Configs["+ i +"].FunctionName");

				describeCdnUserConfigsResponse_configs.Add(config);
			}
			describeCdnUserConfigsResponse.Configs = describeCdnUserConfigsResponse_configs;
        
			return describeCdnUserConfigsResponse;
        }
    }
}
