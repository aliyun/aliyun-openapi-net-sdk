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
using Aliyun.Acs.vod.Model.V20170321;

namespace Aliyun.Acs.vod.Transform.V20170321
{
    public class GetVideoPlayAuthResponseUnmarshaller
    {
        public static GetVideoPlayAuthResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetVideoPlayAuthResponse getVideoPlayAuthResponse = new GetVideoPlayAuthResponse();

			getVideoPlayAuthResponse.HttpResponse = _ctx.HttpResponse;
			getVideoPlayAuthResponse.PlayAuth = _ctx.StringValue("GetVideoPlayAuth.PlayAuth");
			getVideoPlayAuthResponse.RequestId = _ctx.StringValue("GetVideoPlayAuth.RequestId");

			GetVideoPlayAuthResponse.GetVideoPlayAuth_VideoMeta videoMeta = new GetVideoPlayAuthResponse.GetVideoPlayAuth_VideoMeta();
			videoMeta.Status = _ctx.StringValue("GetVideoPlayAuth.VideoMeta.Status");
			videoMeta.Duration = _ctx.FloatValue("GetVideoPlayAuth.VideoMeta.Duration");
			videoMeta.Title = _ctx.StringValue("GetVideoPlayAuth.VideoMeta.Title");
			videoMeta.VideoId = _ctx.StringValue("GetVideoPlayAuth.VideoMeta.VideoId");
			videoMeta.CoverURL = _ctx.StringValue("GetVideoPlayAuth.VideoMeta.CoverURL");
			getVideoPlayAuthResponse.VideoMeta = videoMeta;
        
			return getVideoPlayAuthResponse;
        }
    }
}
