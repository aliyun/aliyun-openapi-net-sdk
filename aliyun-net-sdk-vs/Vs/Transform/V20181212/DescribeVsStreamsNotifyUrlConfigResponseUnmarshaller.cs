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
using Aliyun.Acs.vs.Model.V20181212;

namespace Aliyun.Acs.vs.Transform.V20181212
{
    public class DescribeVsStreamsNotifyUrlConfigResponseUnmarshaller
    {
        public static DescribeVsStreamsNotifyUrlConfigResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeVsStreamsNotifyUrlConfigResponse describeVsStreamsNotifyUrlConfigResponse = new DescribeVsStreamsNotifyUrlConfigResponse();

			describeVsStreamsNotifyUrlConfigResponse.HttpResponse = _ctx.HttpResponse;
			describeVsStreamsNotifyUrlConfigResponse.RequestId = _ctx.StringValue("DescribeVsStreamsNotifyUrlConfig.RequestId");

			DescribeVsStreamsNotifyUrlConfigResponse.DescribeVsStreamsNotifyUrlConfig_LiveStreamsNotifyConfig liveStreamsNotifyConfig = new DescribeVsStreamsNotifyUrlConfigResponse.DescribeVsStreamsNotifyUrlConfig_LiveStreamsNotifyConfig();
			liveStreamsNotifyConfig.DomainName = _ctx.StringValue("DescribeVsStreamsNotifyUrlConfig.LiveStreamsNotifyConfig.DomainName");
			liveStreamsNotifyConfig.NotifyUrl = _ctx.StringValue("DescribeVsStreamsNotifyUrlConfig.LiveStreamsNotifyConfig.NotifyUrl");
			liveStreamsNotifyConfig.AuthType = _ctx.StringValue("DescribeVsStreamsNotifyUrlConfig.LiveStreamsNotifyConfig.AuthType");
			liveStreamsNotifyConfig.AuthKey = _ctx.StringValue("DescribeVsStreamsNotifyUrlConfig.LiveStreamsNotifyConfig.AuthKey");
			describeVsStreamsNotifyUrlConfigResponse.LiveStreamsNotifyConfig = liveStreamsNotifyConfig;
        
			return describeVsStreamsNotifyUrlConfigResponse;
        }
    }
}
