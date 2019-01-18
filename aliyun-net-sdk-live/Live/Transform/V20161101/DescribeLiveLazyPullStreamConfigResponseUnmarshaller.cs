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
    public class DescribeLiveLazyPullStreamConfigResponseUnmarshaller
    {
        public static DescribeLiveLazyPullStreamConfigResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeLiveLazyPullStreamConfigResponse describeLiveLazyPullStreamConfigResponse = new DescribeLiveLazyPullStreamConfigResponse();

			describeLiveLazyPullStreamConfigResponse.HttpResponse = context.HttpResponse;
			describeLiveLazyPullStreamConfigResponse.RequestId = context.StringValue("DescribeLiveLazyPullStreamConfig.RequestId");

			List<DescribeLiveLazyPullStreamConfigResponse.DescribeLiveLazyPullStreamConfig_LiveLazyPullConfig> describeLiveLazyPullStreamConfigResponse_liveLazyPullConfigList = new List<DescribeLiveLazyPullStreamConfigResponse.DescribeLiveLazyPullStreamConfig_LiveLazyPullConfig>();
			for (int i = 0; i < context.Length("DescribeLiveLazyPullStreamConfig.LiveLazyPullConfigList.Length"); i++) {
				DescribeLiveLazyPullStreamConfigResponse.DescribeLiveLazyPullStreamConfig_LiveLazyPullConfig liveLazyPullConfig = new DescribeLiveLazyPullStreamConfigResponse.DescribeLiveLazyPullStreamConfig_LiveLazyPullConfig();
				liveLazyPullConfig.DomainName = context.StringValue("DescribeLiveLazyPullStreamConfig.LiveLazyPullConfigList["+ i +"].DomainName");
				liveLazyPullConfig.AppName = context.StringValue("DescribeLiveLazyPullStreamConfig.LiveLazyPullConfigList["+ i +"].AppName");
				liveLazyPullConfig.PullDomainName = context.StringValue("DescribeLiveLazyPullStreamConfig.LiveLazyPullConfigList["+ i +"].PullDomainName");
				liveLazyPullConfig.PullAppName = context.StringValue("DescribeLiveLazyPullStreamConfig.LiveLazyPullConfigList["+ i +"].PullAppName");
				liveLazyPullConfig.PullProtocol = context.StringValue("DescribeLiveLazyPullStreamConfig.LiveLazyPullConfigList["+ i +"].PullProtocol");
				liveLazyPullConfig.PullAuthType = context.StringValue("DescribeLiveLazyPullStreamConfig.LiveLazyPullConfigList["+ i +"].PullAuthType");
				liveLazyPullConfig.PullAuthKey = context.StringValue("DescribeLiveLazyPullStreamConfig.LiveLazyPullConfigList["+ i +"].PullAuthKey");

				describeLiveLazyPullStreamConfigResponse_liveLazyPullConfigList.Add(liveLazyPullConfig);
			}
			describeLiveLazyPullStreamConfigResponse.LiveLazyPullConfigList = describeLiveLazyPullStreamConfigResponse_liveLazyPullConfigList;
        
			return describeLiveLazyPullStreamConfigResponse;
        }
    }
}