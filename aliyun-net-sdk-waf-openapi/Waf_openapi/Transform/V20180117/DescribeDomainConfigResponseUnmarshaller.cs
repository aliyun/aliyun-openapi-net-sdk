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
using Aliyun.Acs.waf_openapi.Model.V20180117;

namespace Aliyun.Acs.waf_openapi.Transform.V20180117
{
    public class DescribeDomainConfigResponseUnmarshaller
    {
        public static DescribeDomainConfigResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDomainConfigResponse describeDomainConfigResponse = new DescribeDomainConfigResponse();

			describeDomainConfigResponse.HttpResponse = _ctx.HttpResponse;
			describeDomainConfigResponse.RequestId = _ctx.StringValue("DescribeDomainConfig.RequestId");

			DescribeDomainConfigResponse.DescribeDomainConfig_Result result = new DescribeDomainConfigResponse.DescribeDomainConfig_Result();
			result.WafTaskId = _ctx.StringValue("DescribeDomainConfig.Result.WafTaskId");
			result.Status = _ctx.IntegerValue("DescribeDomainConfig.Result.Status");

			DescribeDomainConfigResponse.DescribeDomainConfig_Result.DescribeDomainConfig_DomainConfig domainConfig = new DescribeDomainConfigResponse.DescribeDomainConfig_Result.DescribeDomainConfig_DomainConfig();
			domainConfig.Cname = _ctx.StringValue("DescribeDomainConfig.Result.DomainConfig.Cname");
			domainConfig.ProtocolType = _ctx.IntegerValue("DescribeDomainConfig.Result.DomainConfig.ProtocolType");
			domainConfig.SourceIps = _ctx.StringValue("DescribeDomainConfig.Result.DomainConfig.SourceIps");
			result.DomainConfig = domainConfig;
			describeDomainConfigResponse.Result = result;
        
			return describeDomainConfigResponse;
        }
    }
}
