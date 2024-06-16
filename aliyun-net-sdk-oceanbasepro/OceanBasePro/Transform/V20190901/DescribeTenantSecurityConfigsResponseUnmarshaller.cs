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
    public class DescribeTenantSecurityConfigsResponseUnmarshaller
    {
        public static DescribeTenantSecurityConfigsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeTenantSecurityConfigsResponse describeTenantSecurityConfigsResponse = new DescribeTenantSecurityConfigsResponse();

			describeTenantSecurityConfigsResponse.HttpResponse = _ctx.HttpResponse;
			describeTenantSecurityConfigsResponse.RequestId = _ctx.StringValue("DescribeTenantSecurityConfigs.RequestId");

			DescribeTenantSecurityConfigsResponse.DescribeTenantSecurityConfigs_Configs configs = new DescribeTenantSecurityConfigsResponse.DescribeTenantSecurityConfigs_Configs();
			configs.TotalCheckCount = _ctx.IntegerValue("DescribeTenantSecurityConfigs.Configs.TotalCheckCount");
			configs.TotalRiskCount = _ctx.IntegerValue("DescribeTenantSecurityConfigs.Configs.TotalRiskCount");
			configs.CheckId = _ctx.StringValue("DescribeTenantSecurityConfigs.Configs.CheckId");
			configs.InstanceId = _ctx.StringValue("DescribeTenantSecurityConfigs.Configs.InstanceId");
			configs.CheckTime = _ctx.StringValue("DescribeTenantSecurityConfigs.Configs.CheckTime");

			List<DescribeTenantSecurityConfigsResponse.DescribeTenantSecurityConfigs_Configs.DescribeTenantSecurityConfigs_TenantSecurityConfigsItem> configs_tenantSecurityConfigs = new List<DescribeTenantSecurityConfigsResponse.DescribeTenantSecurityConfigs_Configs.DescribeTenantSecurityConfigs_TenantSecurityConfigsItem>();
			for (int i = 0; i < _ctx.Length("DescribeTenantSecurityConfigs.Configs.TenantSecurityConfigs.Length"); i++) {
				DescribeTenantSecurityConfigsResponse.DescribeTenantSecurityConfigs_Configs.DescribeTenantSecurityConfigs_TenantSecurityConfigsItem tenantSecurityConfigsItem = new DescribeTenantSecurityConfigsResponse.DescribeTenantSecurityConfigs_Configs.DescribeTenantSecurityConfigs_TenantSecurityConfigsItem();
				tenantSecurityConfigsItem.TenantId = _ctx.StringValue("DescribeTenantSecurityConfigs.Configs.TenantSecurityConfigs["+ i +"].TenantId");
				tenantSecurityConfigsItem.TenantName = _ctx.StringValue("DescribeTenantSecurityConfigs.Configs.TenantSecurityConfigs["+ i +"].TenantName");
				tenantSecurityConfigsItem.RiskCount = _ctx.IntegerValue("DescribeTenantSecurityConfigs.Configs.TenantSecurityConfigs["+ i +"].RiskCount");

				List<DescribeTenantSecurityConfigsResponse.DescribeTenantSecurityConfigs_Configs.DescribeTenantSecurityConfigs_TenantSecurityConfigsItem.DescribeTenantSecurityConfigs_SecurityConfigsItem> tenantSecurityConfigsItem_securityConfigs = new List<DescribeTenantSecurityConfigsResponse.DescribeTenantSecurityConfigs_Configs.DescribeTenantSecurityConfigs_TenantSecurityConfigsItem.DescribeTenantSecurityConfigs_SecurityConfigsItem>();
				for (int j = 0; j < _ctx.Length("DescribeTenantSecurityConfigs.Configs.TenantSecurityConfigs["+ i +"].SecurityConfigs.Length"); j++) {
					DescribeTenantSecurityConfigsResponse.DescribeTenantSecurityConfigs_Configs.DescribeTenantSecurityConfigs_TenantSecurityConfigsItem.DescribeTenantSecurityConfigs_SecurityConfigsItem securityConfigsItem = new DescribeTenantSecurityConfigsResponse.DescribeTenantSecurityConfigs_Configs.DescribeTenantSecurityConfigs_TenantSecurityConfigsItem.DescribeTenantSecurityConfigs_SecurityConfigsItem();
					securityConfigsItem.ConfigGroup = _ctx.StringValue("DescribeTenantSecurityConfigs.Configs.TenantSecurityConfigs["+ i +"].SecurityConfigs["+ j +"].ConfigGroup");
					securityConfigsItem.ConfigName = _ctx.StringValue("DescribeTenantSecurityConfigs.Configs.TenantSecurityConfigs["+ i +"].SecurityConfigs["+ j +"].ConfigName");
					securityConfigsItem.Risk = _ctx.BooleanValue("DescribeTenantSecurityConfigs.Configs.TenantSecurityConfigs["+ i +"].SecurityConfigs["+ j +"].Risk");
					securityConfigsItem.RiskDescription = _ctx.StringValue("DescribeTenantSecurityConfigs.Configs.TenantSecurityConfigs["+ i +"].SecurityConfigs["+ j +"].RiskDescription");
					securityConfigsItem.ConfigDescription = _ctx.StringValue("DescribeTenantSecurityConfigs.Configs.TenantSecurityConfigs["+ i +"].SecurityConfigs["+ j +"].ConfigDescription");

					tenantSecurityConfigsItem_securityConfigs.Add(securityConfigsItem);
				}
				tenantSecurityConfigsItem.SecurityConfigs = tenantSecurityConfigsItem_securityConfigs;

				configs_tenantSecurityConfigs.Add(tenantSecurityConfigsItem);
			}
			configs.TenantSecurityConfigs = configs_tenantSecurityConfigs;
			describeTenantSecurityConfigsResponse.Configs = configs;
        
			return describeTenantSecurityConfigsResponse;
        }
    }
}
