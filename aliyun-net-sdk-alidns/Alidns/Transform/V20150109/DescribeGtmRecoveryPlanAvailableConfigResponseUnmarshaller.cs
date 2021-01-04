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
using Aliyun.Acs.Alidns.Model.V20150109;

namespace Aliyun.Acs.Alidns.Transform.V20150109
{
    public class DescribeGtmRecoveryPlanAvailableConfigResponseUnmarshaller
    {
        public static DescribeGtmRecoveryPlanAvailableConfigResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeGtmRecoveryPlanAvailableConfigResponse describeGtmRecoveryPlanAvailableConfigResponse = new DescribeGtmRecoveryPlanAvailableConfigResponse();

			describeGtmRecoveryPlanAvailableConfigResponse.HttpResponse = _ctx.HttpResponse;
			describeGtmRecoveryPlanAvailableConfigResponse.RequestId = _ctx.StringValue("DescribeGtmRecoveryPlanAvailableConfig.RequestId");

			List<DescribeGtmRecoveryPlanAvailableConfigResponse.DescribeGtmRecoveryPlanAvailableConfig_Instance> describeGtmRecoveryPlanAvailableConfigResponse_instances = new List<DescribeGtmRecoveryPlanAvailableConfigResponse.DescribeGtmRecoveryPlanAvailableConfig_Instance>();
			for (int i = 0; i < _ctx.Length("DescribeGtmRecoveryPlanAvailableConfig.Instances.Length"); i++) {
				DescribeGtmRecoveryPlanAvailableConfigResponse.DescribeGtmRecoveryPlanAvailableConfig_Instance instance = new DescribeGtmRecoveryPlanAvailableConfigResponse.DescribeGtmRecoveryPlanAvailableConfig_Instance();
				instance.InstanceId = _ctx.StringValue("DescribeGtmRecoveryPlanAvailableConfig.Instances["+ i +"].InstanceId");
				instance.InstanceName = _ctx.StringValue("DescribeGtmRecoveryPlanAvailableConfig.Instances["+ i +"].InstanceName");

				List<DescribeGtmRecoveryPlanAvailableConfigResponse.DescribeGtmRecoveryPlanAvailableConfig_Instance.DescribeGtmRecoveryPlanAvailableConfig_AddrPool> instance_addrPools = new List<DescribeGtmRecoveryPlanAvailableConfigResponse.DescribeGtmRecoveryPlanAvailableConfig_Instance.DescribeGtmRecoveryPlanAvailableConfig_AddrPool>();
				for (int j = 0; j < _ctx.Length("DescribeGtmRecoveryPlanAvailableConfig.Instances["+ i +"].AddrPools.Length"); j++) {
					DescribeGtmRecoveryPlanAvailableConfigResponse.DescribeGtmRecoveryPlanAvailableConfig_Instance.DescribeGtmRecoveryPlanAvailableConfig_AddrPool addrPool = new DescribeGtmRecoveryPlanAvailableConfigResponse.DescribeGtmRecoveryPlanAvailableConfig_Instance.DescribeGtmRecoveryPlanAvailableConfig_AddrPool();
					addrPool.AddrPoolId = _ctx.StringValue("DescribeGtmRecoveryPlanAvailableConfig.Instances["+ i +"].AddrPools["+ j +"].AddrPoolId");
					addrPool.Name = _ctx.StringValue("DescribeGtmRecoveryPlanAvailableConfig.Instances["+ i +"].AddrPools["+ j +"].Name");

					instance_addrPools.Add(addrPool);
				}
				instance.AddrPools = instance_addrPools;

				describeGtmRecoveryPlanAvailableConfigResponse_instances.Add(instance);
			}
			describeGtmRecoveryPlanAvailableConfigResponse.Instances = describeGtmRecoveryPlanAvailableConfigResponse_instances;
        
			return describeGtmRecoveryPlanAvailableConfigResponse;
        }
    }
}
