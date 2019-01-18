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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.live.Model.V20161101;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.live.Transform.V20161101
{
    public class DescribeLiveMixConfigResponseUnmarshaller
    {
        public static DescribeLiveMixConfigResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeLiveMixConfigResponse describeLiveMixConfigResponse = new DescribeLiveMixConfigResponse();

			describeLiveMixConfigResponse.HttpResponse = context.HttpResponse;
			describeLiveMixConfigResponse.RequestId = context.StringValue("DescribeLiveMixConfig.RequestId");

			List<DescribeLiveMixConfigResponse.DescribeLiveMixConfig_MixConfig> describeLiveMixConfigResponse_mixConfigList = new List<DescribeLiveMixConfigResponse.DescribeLiveMixConfig_MixConfig>();
			for (int i = 0; i < context.Length("DescribeLiveMixConfig.MixConfigList.Length"); i++) {
				DescribeLiveMixConfigResponse.DescribeLiveMixConfig_MixConfig mixConfig = new DescribeLiveMixConfigResponse.DescribeLiveMixConfig_MixConfig();
				mixConfig.DomainName = context.StringValue("DescribeLiveMixConfig.MixConfigList["+ i +"].DomainName");
				mixConfig.AppName = context.StringValue("DescribeLiveMixConfig.MixConfigList["+ i +"].AppName");
				mixConfig.Template = context.StringValue("DescribeLiveMixConfig.MixConfigList["+ i +"].Template");

				describeLiveMixConfigResponse_mixConfigList.Add(mixConfig);
			}
			describeLiveMixConfigResponse.MixConfigList = describeLiveMixConfigResponse_mixConfigList;
        
			return describeLiveMixConfigResponse;
        }
    }
}