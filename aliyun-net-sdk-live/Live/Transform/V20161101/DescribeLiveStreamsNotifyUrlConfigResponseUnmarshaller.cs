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
    public class DescribeLiveStreamsNotifyUrlConfigResponseUnmarshaller
    {
        public static DescribeLiveStreamsNotifyUrlConfigResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeLiveStreamsNotifyUrlConfigResponse describeLiveStreamsNotifyUrlConfigResponse = new DescribeLiveStreamsNotifyUrlConfigResponse();

			describeLiveStreamsNotifyUrlConfigResponse.HttpResponse = _ctx.HttpResponse;
			describeLiveStreamsNotifyUrlConfigResponse.RequestId = _ctx.StringValue("DescribeLiveStreamsNotifyUrlConfig.RequestId");

			DescribeLiveStreamsNotifyUrlConfigResponse.DescribeLiveStreamsNotifyUrlConfig_LiveStreamsNotifyConfig liveStreamsNotifyConfig = new DescribeLiveStreamsNotifyUrlConfigResponse.DescribeLiveStreamsNotifyUrlConfig_LiveStreamsNotifyConfig();
			liveStreamsNotifyConfig.DomainName = _ctx.StringValue("DescribeLiveStreamsNotifyUrlConfig.LiveStreamsNotifyConfig.DomainName");
			liveStreamsNotifyConfig.NotifyUrl = _ctx.StringValue("DescribeLiveStreamsNotifyUrlConfig.LiveStreamsNotifyConfig.NotifyUrl");
			liveStreamsNotifyConfig.AuthType = _ctx.StringValue("DescribeLiveStreamsNotifyUrlConfig.LiveStreamsNotifyConfig.AuthType");
			liveStreamsNotifyConfig.AuthKey = _ctx.StringValue("DescribeLiveStreamsNotifyUrlConfig.LiveStreamsNotifyConfig.AuthKey");
			describeLiveStreamsNotifyUrlConfigResponse.LiveStreamsNotifyConfig = liveStreamsNotifyConfig;
        
			return describeLiveStreamsNotifyUrlConfigResponse;
        }
    }
}
