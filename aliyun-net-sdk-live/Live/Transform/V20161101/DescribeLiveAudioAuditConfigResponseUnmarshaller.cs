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
    public class DescribeLiveAudioAuditConfigResponseUnmarshaller
    {
        public static DescribeLiveAudioAuditConfigResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeLiveAudioAuditConfigResponse describeLiveAudioAuditConfigResponse = new DescribeLiveAudioAuditConfigResponse();

			describeLiveAudioAuditConfigResponse.HttpResponse = context.HttpResponse;
			describeLiveAudioAuditConfigResponse.RequestId = context.StringValue("DescribeLiveAudioAuditConfig.RequestId");

			List<DescribeLiveAudioAuditConfigResponse.DescribeLiveAudioAuditConfig_LiveAudioAuditConfig> describeLiveAudioAuditConfigResponse_liveAudioAuditConfigList = new List<DescribeLiveAudioAuditConfigResponse.DescribeLiveAudioAuditConfig_LiveAudioAuditConfig>();
			for (int i = 0; i < context.Length("DescribeLiveAudioAuditConfig.LiveAudioAuditConfigList.Length"); i++) {
				DescribeLiveAudioAuditConfigResponse.DescribeLiveAudioAuditConfig_LiveAudioAuditConfig liveAudioAuditConfig = new DescribeLiveAudioAuditConfigResponse.DescribeLiveAudioAuditConfig_LiveAudioAuditConfig();
				liveAudioAuditConfig.DomainName = context.StringValue("DescribeLiveAudioAuditConfig.LiveAudioAuditConfigList["+ i +"].DomainName");
				liveAudioAuditConfig.AppName = context.StringValue("DescribeLiveAudioAuditConfig.LiveAudioAuditConfigList["+ i +"].AppName");
				liveAudioAuditConfig.StreamName = context.StringValue("DescribeLiveAudioAuditConfig.LiveAudioAuditConfigList["+ i +"].StreamName");
				liveAudioAuditConfig.BizType = context.StringValue("DescribeLiveAudioAuditConfig.LiveAudioAuditConfigList["+ i +"].BizType");

				List<string> liveAudioAuditConfig_scenes = new List<string>();
				for (int j = 0; j < context.Length("DescribeLiveAudioAuditConfig.LiveAudioAuditConfigList["+ i +"].Scenes.Length"); j++) {
					liveAudioAuditConfig_scenes.Add(context.StringValue("DescribeLiveAudioAuditConfig.LiveAudioAuditConfigList["+ i +"].Scenes["+ j +"]"));
				}
				liveAudioAuditConfig.Scenes = liveAudioAuditConfig_scenes;

				describeLiveAudioAuditConfigResponse_liveAudioAuditConfigList.Add(liveAudioAuditConfig);
			}
			describeLiveAudioAuditConfigResponse.LiveAudioAuditConfigList = describeLiveAudioAuditConfigResponse_liveAudioAuditConfigList;
        
			return describeLiveAudioAuditConfigResponse;
        }
    }
}
