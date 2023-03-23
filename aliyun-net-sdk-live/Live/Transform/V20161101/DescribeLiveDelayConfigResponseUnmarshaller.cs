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
    public class DescribeLiveDelayConfigResponseUnmarshaller
    {
        public static DescribeLiveDelayConfigResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeLiveDelayConfigResponse describeLiveDelayConfigResponse = new DescribeLiveDelayConfigResponse();

			describeLiveDelayConfigResponse.HttpResponse = _ctx.HttpResponse;
			describeLiveDelayConfigResponse.Domain = _ctx.StringValue("DescribeLiveDelayConfig.Domain");
			describeLiveDelayConfigResponse.RequestId = _ctx.StringValue("DescribeLiveDelayConfig.RequestId");
			describeLiveDelayConfigResponse.TaskTriggerMode = _ctx.StringValue("DescribeLiveDelayConfig.TaskTriggerMode");
			describeLiveDelayConfigResponse.App = _ctx.StringValue("DescribeLiveDelayConfig.App");
			describeLiveDelayConfigResponse.DelayTime = _ctx.StringValue("DescribeLiveDelayConfig.DelayTime");
			describeLiveDelayConfigResponse.Stream = _ctx.StringValue("DescribeLiveDelayConfig.Stream");
        
			return describeLiveDelayConfigResponse;
        }
    }
}
