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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.live.Model.V20161101;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.live.Transform.V20161101
{
    public class DescribeCasterStreamUrlResponseUnmarshaller
    {
        public static DescribeCasterStreamUrlResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeCasterStreamUrlResponse describeCasterStreamUrlResponse = new DescribeCasterStreamUrlResponse();

			describeCasterStreamUrlResponse.HttpResponse = context.HttpResponse;
			describeCasterStreamUrlResponse.RequestId = context.StringValue("DescribeCasterStreamUrl.RequestId");
			describeCasterStreamUrlResponse.CasterId = context.StringValue("DescribeCasterStreamUrl.CasterId");
			describeCasterStreamUrlResponse.Total = context.IntegerValue("DescribeCasterStreamUrl.Total");

			List<DescribeCasterStreamUrlResponse.DescribeCasterStreamUrl_CasterStream> describeCasterStreamUrlResponse_casterStreams = new List<DescribeCasterStreamUrlResponse.DescribeCasterStreamUrl_CasterStream>();
			for (int i = 0; i < context.Length("DescribeCasterStreamUrl.CasterStreams.Length"); i++) {
				DescribeCasterStreamUrlResponse.DescribeCasterStreamUrl_CasterStream casterStream = new DescribeCasterStreamUrlResponse.DescribeCasterStreamUrl_CasterStream();
				casterStream.SceneId = context.StringValue("DescribeCasterStreamUrl.CasterStreams["+ i +"].SceneId");
				casterStream.StreamUrl = context.StringValue("DescribeCasterStreamUrl.CasterStreams["+ i +"].StreamUrl");
				casterStream.OutputType = context.IntegerValue("DescribeCasterStreamUrl.CasterStreams["+ i +"].OutputType");

				List<DescribeCasterStreamUrlResponse.DescribeCasterStreamUrl_CasterStream.DescribeCasterStreamUrl_StreamInfo> casterStream_streamInfos = new List<DescribeCasterStreamUrlResponse.DescribeCasterStreamUrl_CasterStream.DescribeCasterStreamUrl_StreamInfo>();
				for (int j = 0; j < context.Length("DescribeCasterStreamUrl.CasterStreams["+ i +"].StreamInfos.Length"); j++) {
					DescribeCasterStreamUrlResponse.DescribeCasterStreamUrl_CasterStream.DescribeCasterStreamUrl_StreamInfo streamInfo = new DescribeCasterStreamUrlResponse.DescribeCasterStreamUrl_CasterStream.DescribeCasterStreamUrl_StreamInfo();
					streamInfo.TranscodeConfig = context.StringValue("DescribeCasterStreamUrl.CasterStreams["+ i +"].StreamInfos["+ j +"].TranscodeConfig");
					streamInfo.VideoFormat = context.StringValue("DescribeCasterStreamUrl.CasterStreams["+ i +"].StreamInfos["+ j +"].VideoFormat");
					streamInfo.OutputStreamUrl = context.StringValue("DescribeCasterStreamUrl.CasterStreams["+ i +"].StreamInfos["+ j +"].OutputStreamUrl");

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