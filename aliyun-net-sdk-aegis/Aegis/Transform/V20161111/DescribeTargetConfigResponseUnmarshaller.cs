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
using Aliyun.Acs.aegis.Model.V20161111;

namespace Aliyun.Acs.aegis.Transform.V20161111
{
    public class DescribeTargetConfigResponseUnmarshaller
    {
        public static DescribeTargetConfigResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeTargetConfigResponse describeTargetConfigResponse = new DescribeTargetConfigResponse();

			describeTargetConfigResponse.HttpResponse = context.HttpResponse;
			describeTargetConfigResponse.RequestId = context.StringValue("DescribeTargetConfig.RequestId");
			describeTargetConfigResponse.TotalCount = context.IntegerValue("DescribeTargetConfig.TotalCount");

			List<DescribeTargetConfigResponse.DescribeTargetConfig_TargetConfig> describeTargetConfigResponse_targetConfigs = new List<DescribeTargetConfigResponse.DescribeTargetConfig_TargetConfig>();
			for (int i = 0; i < context.Length("DescribeTargetConfig.TargetConfigs.Length"); i++) {
				DescribeTargetConfigResponse.DescribeTargetConfig_TargetConfig targetConfig = new DescribeTargetConfigResponse.DescribeTargetConfig_TargetConfig();
				targetConfig.Type = context.StringValue("DescribeTargetConfig.TargetConfigs["+ i +"].Type");
				targetConfig.Config = context.StringValue("DescribeTargetConfig.TargetConfigs["+ i +"].Config");
				targetConfig.OverAllConfig = context.StringValue("DescribeTargetConfig.TargetConfigs["+ i +"].OverAllConfig");

				describeTargetConfigResponse_targetConfigs.Add(targetConfig);
			}
			describeTargetConfigResponse.TargetConfigs = describeTargetConfigResponse_targetConfigs;
        
			return describeTargetConfigResponse;
        }
    }
}
