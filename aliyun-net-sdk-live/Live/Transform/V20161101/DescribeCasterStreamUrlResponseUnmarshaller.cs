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
    public class DescribeCasterStreamUrlResponseUnmarshaller
    {
        public static DescribeCasterStreamUrlResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeCasterStreamUrlResponse describeCasterStreamUrlResponse = new DescribeCasterStreamUrlResponse();

			describeCasterStreamUrlResponse.HttpResponse = _ctx.HttpResponse;
			describeCasterStreamUrlResponse.RequestId = _ctx.StringValue("DescribeCasterStreamUrl.RequestId");
			describeCasterStreamUrlResponse.CasterId = _ctx.StringValue("DescribeCasterStreamUrl.CasterId");
			describeCasterStreamUrlResponse.Total = _ctx.IntegerValue("DescribeCasterStreamUrl.Total");

			List<DescribeCasterStreamUrlResponse.DescribeCasterStreamUrl_CasterStream> describeCasterStreamUrlResponse_casterStreams = new List<DescribeCasterStreamUrlResponse.DescribeCasterStreamUrl_CasterStream>();
			for (int i = 0; i < _ctx.Length("DescribeCasterStreamUrl.CasterStreams.Length"); i++) {
				DescribeCasterStreamUrlResponse.DescribeCasterStreamUrl_CasterStream casterStream = new DescribeCasterStreamUrlResponse.DescribeCasterStreamUrl_CasterStream();
				casterStream.SceneId = _ctx.StringValue("DescribeCasterStreamUrl.CasterStreams["+ i +"].SceneId");
				casterStream.StreamUrl = _ctx.StringValue("DescribeCasterStreamUrl.CasterStreams["+ i +"].StreamUrl");
				casterStream.RtmpUrl = _ctx.StringValue("DescribeCasterStreamUrl.CasterStreams["+ i +"].RtmpUrl");
				casterStream.OutputType = _ctx.IntegerValue("DescribeCasterStreamUrl.CasterStreams["+ i +"].OutputType");

				List<DescribeCasterStreamUrlResponse.DescribeCasterStreamUrl_CasterStream.DescribeCasterStreamUrl_StreamInfo> casterStream_streamInfos = new List<DescribeCasterStreamUrlResponse.DescribeCasterStreamUrl_CasterStream.DescribeCasterStreamUrl_StreamInfo>();
				for (int j = 0; j < _ctx.Length("DescribeCasterStreamUrl.CasterStreams["+ i +"].StreamInfos.Length"); j++) {
					DescribeCasterStreamUrlResponse.DescribeCasterStreamUrl_CasterStream.DescribeCasterStreamUrl_StreamInfo streamInfo = new DescribeCasterStreamUrlResponse.DescribeCasterStreamUrl_CasterStream.DescribeCasterStreamUrl_StreamInfo();
					streamInfo.TranscodeConfig = _ctx.StringValue("DescribeCasterStreamUrl.CasterStreams["+ i +"].StreamInfos["+ j +"].TranscodeConfig");
					streamInfo.VideoFormat = _ctx.StringValue("DescribeCasterStreamUrl.CasterStreams["+ i +"].StreamInfos["+ j +"].VideoFormat");
					streamInfo.OutputStreamUrl = _ctx.StringValue("DescribeCasterStreamUrl.CasterStreams["+ i +"].StreamInfos["+ j +"].OutputStreamUrl");

					casterStream_streamInfos.Add(streamInfo);
				}
				casterStream.StreamInfos = casterStream_streamInfos;

				describeCasterStreamUrlResponse_casterStreams.Add(casterStream);
			}
			describeCasterStreamUrlResponse.CasterStreams = describeCasterStreamUrlResponse_casterStreams;
        
			return describeCasterStreamUrlResponse;
        }
    }
}
