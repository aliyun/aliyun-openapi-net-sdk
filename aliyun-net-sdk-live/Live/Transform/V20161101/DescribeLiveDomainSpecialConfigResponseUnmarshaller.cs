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
using Aliyun.Acs.live.Model.V20161101;

namespace Aliyun.Acs.live.Transform.V20161101
{
    public class DescribeLiveDomainSpecialConfigResponseUnmarshaller
    {
        public static DescribeLiveDomainSpecialConfigResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeLiveDomainSpecialConfigResponse describeLiveDomainSpecialConfigResponse = new DescribeLiveDomainSpecialConfigResponse();

			describeLiveDomainSpecialConfigResponse.HttpResponse = _ctx.HttpResponse;
			describeLiveDomainSpecialConfigResponse.RequestId = _ctx.StringValue("DescribeLiveDomainSpecialConfig.RequestId");

			List<DescribeLiveDomainSpecialConfigResponse.DescribeLiveDomainSpecialConfig_Config> describeLiveDomainSpecialConfigResponse_configs = new List<DescribeLiveDomainSpecialConfigResponse.DescribeLiveDomainSpecialConfig_Config>();
			for (int i = 0; i < _ctx.Length("DescribeLiveDomainSpecialConfig.Configs.Length"); i++) {
				DescribeLiveDomainSpecialConfigResponse.DescribeLiveDomainSpecialConfig_Config config = new DescribeLiveDomainSpecialConfigResponse.DescribeLiveDomainSpecialConfig_Config();
				config.Name = _ctx.StringValue("DescribeLiveDomainSpecialConfig.Configs["+ i +"].Name");
				config.ConfigId = _ctx.LongValue("DescribeLiveDomainSpecialConfig.Configs["+ i +"].ConfigId");
				config._Value = _ctx.StringValue("DescribeLiveDomainSpecialConfig.Configs["+ i +"].Value");

				describeLiveDomainSpecialConfigResponse_configs.Add(config);
			}
			describeLiveDomainSpecialConfigResponse.Configs = describeLiveDomainSpecialConfigResponse_configs;
        
			return describeLiveDomainSpecialConfigResponse;
        }
    }
}
