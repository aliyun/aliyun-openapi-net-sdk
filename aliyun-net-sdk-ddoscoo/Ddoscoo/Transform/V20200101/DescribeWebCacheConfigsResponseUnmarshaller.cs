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
using Aliyun.Acs.ddoscoo.Model.V20200101;

namespace Aliyun.Acs.ddoscoo.Transform.V20200101
{
    public class DescribeWebCacheConfigsResponseUnmarshaller
    {
        public static DescribeWebCacheConfigsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeWebCacheConfigsResponse describeWebCacheConfigsResponse = new DescribeWebCacheConfigsResponse();

			describeWebCacheConfigsResponse.HttpResponse = _ctx.HttpResponse;
			describeWebCacheConfigsResponse.RequestId = _ctx.StringValue("DescribeWebCacheConfigs.RequestId");

			List<DescribeWebCacheConfigsResponse.DescribeWebCacheConfigs_CacheConfig> describeWebCacheConfigsResponse_domainCacheConfigs = new List<DescribeWebCacheConfigsResponse.DescribeWebCacheConfigs_CacheConfig>();
			for (int i = 0; i < _ctx.Length("DescribeWebCacheConfigs.DomainCacheConfigs.Length"); i++) {
				DescribeWebCacheConfigsResponse.DescribeWebCacheConfigs_CacheConfig cacheConfig = new DescribeWebCacheConfigsResponse.DescribeWebCacheConfigs_CacheConfig();
				cacheConfig.Mode = _ctx.StringValue("DescribeWebCacheConfigs.DomainCacheConfigs["+ i +"].Mode");
				cacheConfig.Enable = _ctx.IntegerValue("DescribeWebCacheConfigs.DomainCacheConfigs["+ i +"].Enable");
				cacheConfig.Domain = _ctx.StringValue("DescribeWebCacheConfigs.DomainCacheConfigs["+ i +"].Domain");

				List<DescribeWebCacheConfigsResponse.DescribeWebCacheConfigs_CacheConfig.DescribeWebCacheConfigs_CustomRule> cacheConfig_customRules = new List<DescribeWebCacheConfigsResponse.DescribeWebCacheConfigs_CacheConfig.DescribeWebCacheConfigs_CustomRule>();
				for (int j = 0; j < _ctx.Length("DescribeWebCacheConfigs.DomainCacheConfigs["+ i +"].CustomRules.Length"); j++) {
					DescribeWebCacheConfigsResponse.DescribeWebCacheConfigs_CacheConfig.DescribeWebCacheConfigs_CustomRule customRule = new DescribeWebCacheConfigsResponse.DescribeWebCacheConfigs_CacheConfig.DescribeWebCacheConfigs_CustomRule();
					customRule.Mode = _ctx.StringValue("DescribeWebCacheConfigs.DomainCacheConfigs["+ i +"].CustomRules["+ j +"].Mode");
					customRule.Name = _ctx.StringValue("DescribeWebCacheConfigs.DomainCacheConfigs["+ i +"].CustomRules["+ j +"].Name");
					customRule.CacheTtl = _ctx.LongValue("DescribeWebCacheConfigs.DomainCacheConfigs["+ i +"].CustomRules["+ j +"].CacheTtl");
					customRule.Uri = _ctx.StringValue("DescribeWebCacheConfigs.DomainCacheConfigs["+ i +"].CustomRules["+ j +"].Uri");

					cacheConfig_customRules.Add(customRule);
				}
				cacheConfig.CustomRules = cacheConfig_customRules;

				describeWebCacheConfigsResponse_domainCacheConfigs.Add(cacheConfig);
			}
			describeWebCacheConfigsResponse.DomainCacheConfigs = describeWebCacheConfigsResponse_domainCacheConfigs;
        
			return describeWebCacheConfigsResponse;
        }
    }
}
