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
using Aliyun.Acs.OceanBasePro.Model.V20190901;

namespace Aliyun.Acs.OceanBasePro.Transform.V20190901
{
    public class DescribeInstanceSecurityConfigsResponseUnmarshaller
    {
        public static DescribeInstanceSecurityConfigsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeInstanceSecurityConfigsResponse describeInstanceSecurityConfigsResponse = new DescribeInstanceSecurityConfigsResponse();

			describeInstanceSecurityConfigsResponse.HttpResponse = _ctx.HttpResponse;
			describeInstanceSecurityConfigsResponse.RequestId = _ctx.StringValue("DescribeInstanceSecurityConfigs.RequestId");

			DescribeInstanceSecurityConfigsResponse.DescribeInstanceSecurityConfigs_InstanceSecurityConfigs instanceSecurityConfigs = new DescribeInstanceSecurityConfigsResponse.DescribeInstanceSecurityConfigs_InstanceSecurityConfigs();
			instanceSecurityConfigs.TotalCheckCount = _ctx.IntegerValue("DescribeInstanceSecurityConfigs.InstanceSecurityConfigs.TotalCheckCount");
			instanceSecurityConfigs.TotalRiskCount = _ctx.IntegerValue("DescribeInstanceSecurityConfigs.InstanceSecurityConfigs.TotalRiskCount");
			instanceSecurityConfigs.CheckTime = _ctx.StringValue("DescribeInstanceSecurityConfigs.InstanceSecurityConfigs.CheckTime");
			instanceSecurityConfigs.InstanceId = _ctx.StringValue("DescribeInstanceSecurityConfigs.InstanceSecurityConfigs.InstanceId");
			instanceSecurityConfigs.CheckId = _ctx.StringValue("DescribeInstanceSecurityConfigs.InstanceSecurityConfigs.CheckId");

			List<DescribeInstanceSecurityConfigsResponse.DescribeInstanceSecurityConfigs_InstanceSecurityConfigs.DescribeInstanceSecurityConfigs_SecurityConfigsItem> instanceSecurityConfigs_securityConfigs = new List<DescribeInstanceSecurityConfigsResponse.DescribeInstanceSecurityConfigs_InstanceSecurityConfigs.DescribeInstanceSecurityConfigs_SecurityConfigsItem>();
			for (int i = 0; i < _ctx.Length("DescribeInstanceSecurityConfigs.InstanceSecurityConfigs.SecurityConfigs.Length"); i++) {
				DescribeInstanceSecurityConfigsResponse.DescribeInstanceSecurityConfigs_InstanceSecurityConfigs.DescribeInstanceSecurityConfigs_SecurityConfigsItem securityConfigsItem = new DescribeInstanceSecurityConfigsResponse.DescribeInstanceSecurityConfigs_InstanceSecurityConfigs.DescribeInstanceSecurityConfigs_SecurityConfigsItem();
				securityConfigsItem.ConfigName = _ctx.StringValue("DescribeInstanceSecurityConfigs.InstanceSecurityConfigs.SecurityConfigs["+ i +"].ConfigName");
				securityConfigsItem.Risk = _ctx.BooleanValue("DescribeInstanceSecurityConfigs.InstanceSecurityConfigs.SecurityConfigs["+ i +"].Risk");
				securityConfigsItem.RiskDescription = _ctx.StringValue("DescribeInstanceSecurityConfigs.InstanceSecurityConfigs.SecurityConfigs["+ i +"].RiskDescription");
				securityConfigsItem.ConfigGroup = _ctx.StringValue("DescribeInstanceSecurityConfigs.InstanceSecurityConfigs.SecurityConfigs["+ i +"].ConfigGroup");
				securityConfigsItem.ConfigDescription = _ctx.StringValue("DescribeInstanceSecurityConfigs.InstanceSecurityConfigs.SecurityConfigs["+ i +"].ConfigDescription");

				instanceSecurityConfigs_securityConfigs.Add(securityConfigsItem);
			}
			instanceSecurityConfigs.SecurityConfigs = instanceSecurityConfigs_securityConfigs;
			describeInstanceSecurityConfigsResponse.InstanceSecurityConfigs = instanceSecurityConfigs;
        
			return describeInstanceSecurityConfigsResponse;
        }
    }
}
