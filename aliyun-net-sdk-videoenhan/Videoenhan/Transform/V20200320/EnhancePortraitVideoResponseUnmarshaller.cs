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
    public class EnhancePortraitVideoResponseUnmarshaller
    {
        public static EnhancePortraitVideoResponse Unmarshall(UnmarshallerContext _ctx)
        {
			EnhancePortraitVideoResponse enhancePortraitVideoResponse = new EnhancePortraitVideoResponse();

			enhancePortraitVideoResponse.HttpResponse = _ctx.HttpResponse;
			enhancePortraitVideoResponse.RequestId = _ctx.StringValue("EnhancePortraitVideo.RequestId");
			enhancePortraitVideoResponse.Code = _ctx.StringValue("EnhancePortraitVideo.Code");
			enhancePortraitVideoResponse.Message = _ctx.StringValue("EnhancePortraitVideo.Message");

			EnhancePortraitVideoResponse.EnhancePortraitVideo_Data data = new EnhancePortraitVideoResponse.EnhancePortraitVideo_Data();
			data.VideoUrl = _ctx.StringValue("EnhancePortraitVideo.Data.VideoUrl");
			enhancePortraitVideoResponse.Data = data;
        
			return enhancePortraitVideoResponse;
        }
    }
}
