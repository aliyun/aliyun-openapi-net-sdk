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
    public class DescribeLiveStreamOptimizedFeatureConfigResponseUnmarshaller
    {
        public static DescribeLiveStreamOptimizedFeatureConfigResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeLiveStreamOptimizedFeatureConfigResponse describeLiveStreamOptimizedFeatureConfigResponse = new DescribeLiveStreamOptimizedFeatureConfigResponse();

			describeLiveStreamOptimizedFeatureConfigResponse.HttpResponse = context.HttpResponse;
			describeLiveStreamOptimizedFeatureConfigResponse.RequestId = context.StringValue("DescribeLiveStreamOptimizedFeatureConfig.RequestId");

			List<DescribeLiveStreamOptimizedFeatureConfigResponse.DescribeLiveStreamOptimizedFeatureConfig_LiveStreamOptimizedFeatureConfig> describeLiveStreamOptimizedFeatureConfigResponse_liveStreamOptimizedFeatureConfigList = new List<DescribeLiveStreamOptimizedFeatureConfigResponse.DescribeLiveStreamOptimizedFeatureConfig_LiveStreamOptimizedFeatureConfig>();
			for (int i = 0; i < context.Length("DescribeLiveStreamOptimizedFeatureConfig.LiveStreamOptimizedFeatureConfigList.Length"); i++) {
				DescribeLiveStreamOptimizedFeatureConfigResponse.DescribeLiveStreamOptimizedFeatureConfig_LiveStreamOptimizedFeatureConfig liveStreamOptimizedFeatureConfig = new DescribeLiveStreamOptimizedFeatureConfigResponse.DescribeLiveStreamOptimizedFeatureConfig_LiveStreamOptimizedFeatureConfig();
				liveStreamOptimizedFeatureConfig.DomainName = context.StringValue("DescribeLiveStreamOptimizedFeatureConfig.LiveStreamOptimizedFeatureConfigList["+ i +"].DomainName");
				liveStreamOptimizedFeatureConfig.ConfigName = context.StringValue("DescribeLiveStreamOptimizedFeatureConfig.LiveStreamOptimizedFeatureConfigList["+ i +"].ConfigName");
				liveStreamOptimizedFeatureConfig.ConfigStatus = context.StringValue("DescribeLiveStreamOptimizedFeatureConfig.LiveStreamOptimizedFeatureConfigList["+ i +"].ConfigStatus");
				liveStreamOptimizedFeatureConfig.ConfigValue = context.StringValue("DescribeLiveStreamOptimizedFeatureConfig.LiveStreamOptimizedFeatureConfigList["+ i +"].ConfigValue");

				describeLiveStreamOptimizedFeatureConfigResponse_liveStreamOptimizedFeatureConfigList.Add(liveStreamOptimizedFeatureConfig);
			}
			describeLiveStreamOptimizedFeatureConfigResponse.LiveStreamOptimizedFeatureConfigList = describeLiveStreamOptimizedFeatureConfigResponse_liveStreamOptimizedFeatureConfigList;
        
			return describeLiveStreamOptimizedFeatureConfigResponse;
        }
    }
}
