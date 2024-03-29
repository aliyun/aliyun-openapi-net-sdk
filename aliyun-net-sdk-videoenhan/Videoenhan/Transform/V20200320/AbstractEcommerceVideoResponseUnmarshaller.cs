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
    public class AbstractEcommerceVideoResponseUnmarshaller
    {
        public static AbstractEcommerceVideoResponse Unmarshall(UnmarshallerContext _ctx)
        {
			AbstractEcommerceVideoResponse abstractEcommerceVideoResponse = new AbstractEcommerceVideoResponse();

			abstractEcommerceVideoResponse.HttpResponse = _ctx.HttpResponse;
			abstractEcommerceVideoResponse.RequestId = _ctx.StringValue("AbstractEcommerceVideo.RequestId");
			abstractEcommerceVideoResponse.Code = _ctx.StringValue("AbstractEcommerceVideo.Code");
			abstractEcommerceVideoResponse.Message = _ctx.StringValue("AbstractEcommerceVideo.Message");

			AbstractEcommerceVideoResponse.AbstractEcommerceVideo_Data data = new AbstractEcommerceVideoResponse.AbstractEcommerceVideo_Data();
			data.VideoCoverUrl = _ctx.StringValue("AbstractEcommerceVideo.Data.VideoCoverUrl");
			data.VideoUrl = _ctx.StringValue("AbstractEcommerceVideo.Data.VideoUrl");
			abstractEcommerceVideoResponse.Data = data;
        
			return abstractEcommerceVideoResponse;
        }
    }
}
