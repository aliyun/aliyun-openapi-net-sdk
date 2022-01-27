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
using Aliyun.Acs.videorecog.Model.V20200320;

namespace Aliyun.Acs.videorecog.Transform.V20200320
{
    public class UnderstandVideoContentResponseUnmarshaller
    {
        public static UnderstandVideoContentResponse Unmarshall(UnmarshallerContext _ctx)
        {
			UnderstandVideoContentResponse understandVideoContentResponse = new UnderstandVideoContentResponse();

			understandVideoContentResponse.HttpResponse = _ctx.HttpResponse;
			understandVideoContentResponse.Message = _ctx.StringValue("UnderstandVideoContent.Message");
			understandVideoContentResponse.RequestId = _ctx.StringValue("UnderstandVideoContent.RequestId");
			understandVideoContentResponse.Code = _ctx.StringValue("UnderstandVideoContent.Code");

			UnderstandVideoContentResponse.UnderstandVideoContent_Data data = new UnderstandVideoContentResponse.UnderstandVideoContent_Data();
			data.TagInfo = _ctx.StringValue("UnderstandVideoContent.Data.TagInfo");

			UnderstandVideoContentResponse.UnderstandVideoContent_Data.UnderstandVideoContent_VideoInfo videoInfo = new UnderstandVideoContentResponse.UnderstandVideoContent_Data.UnderstandVideoContent_VideoInfo();
			videoInfo.Fps = _ctx.FloatValue("UnderstandVideoContent.Data.VideoInfo.Fps");
			videoInfo.Duration = _ctx.LongValue("UnderstandVideoContent.Data.VideoInfo.Duration");
			videoInfo.Height = _ctx.LongValue("UnderstandVideoContent.Data.VideoInfo.Height");
			videoInfo.Width = _ctx.LongValue("UnderstandVideoContent.Data.VideoInfo.Width");
			data.VideoInfo = videoInfo;
			understandVideoContentResponse.Data = data;
        
			return understandVideoContentResponse;
        }
    }
}
