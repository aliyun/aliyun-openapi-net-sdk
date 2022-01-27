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
using Aliyun.Acs.videoenhan.Model.V20200320;

namespace Aliyun.Acs.videoenhan.Transform.V20200320
{
    public class InterpolateVideoFrameResponseUnmarshaller
    {
        public static InterpolateVideoFrameResponse Unmarshall(UnmarshallerContext _ctx)
        {
			InterpolateVideoFrameResponse interpolateVideoFrameResponse = new InterpolateVideoFrameResponse();

			interpolateVideoFrameResponse.HttpResponse = _ctx.HttpResponse;
			interpolateVideoFrameResponse.RequestId = _ctx.StringValue("InterpolateVideoFrame.RequestId");

			InterpolateVideoFrameResponse.InterpolateVideoFrame_Data data = new InterpolateVideoFrameResponse.InterpolateVideoFrame_Data();
			data.VideoURL = _ctx.StringValue("InterpolateVideoFrame.Data.VideoURL");
			interpolateVideoFrameResponse.Data = data;
        
			return interpolateVideoFrameResponse;
        }
    }
}
