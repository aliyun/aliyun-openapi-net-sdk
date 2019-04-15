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
    public class DescribeMachineConfigResponseUnmarshaller
    {
        public static DescribeMachineConfigResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeMachineConfigResponse describeMachineConfigResponse = new DescribeMachineConfigResponse();

			describeMachineConfigResponse.HttpResponse = context.HttpResponse;
			describeMachineConfigResponse.RequestId = context.StringValue("DescribeMachineConfig.RequestId");
			describeMachineConfigResponse.Count = context.IntegerValue("DescribeMachineConfig.Count");

			List<DescribeMachineConfigResponse.DescribeMachineConfig_ConfigTarget> describeMachineConfigResponse_configTargets = new List<DescribeMachineConfigResponse.DescribeMachineConfig_ConfigTarget>();
			for (int i = 0; i < context.Length("DescribeMachineConfig.ConfigTargets.Length"); i++) {
				DescribeMachineConfigResponse.DescribeMachineConfig_ConfigTarget configTarget = new DescribeMachineConfigResponse.DescribeMachineConfig_ConfigTarget();
				configTarget.TargetType = context.StringValue("DescribeMachineConfig.ConfigTargets["+ i +"].TargetType");
				configTarget.Target = context.StringValue("DescribeMachineConfig.ConfigTargets["+ i +"].Target");
				configTarget.Flag = context.StringValue("DescribeMachineConfig.ConfigTargets["+ i +"].Flag");

				describeMachineConfigResponse_configTargets.Add(configTarget);
			}
			describeMachineConfigResponse.ConfigTargets = describeMachineConfigResponse_configTargets;
        
			return describeMachineConfigResponse;
        }
    }
}
