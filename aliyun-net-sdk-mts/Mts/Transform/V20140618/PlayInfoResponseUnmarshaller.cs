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
using Aliyun.Acs.Mts.Model.V20140618;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Mts.Transform.V20140618
{
    public class PlayInfoResponseUnmarshaller
    {
        public static PlayInfoResponse Unmarshall(UnmarshallerContext context)
        {
			PlayInfoResponse playInfoResponse = new PlayInfoResponse();

			playInfoResponse.HttpResponse = context.HttpResponse;
			playInfoResponse.RequestId = context.StringValue("PlayInfo.RequestId");

			List<string> playInfoResponse_notFoundCDNDomain = new List<string>();
			for (int i = 0; i < context.Length("PlayInfo.NotFoundCDNDomain.Length"); i++) {
				playInfoResponse_notFoundCDNDomain.Add(context.StringValue("PlayInfo.NotFoundCDNDomain["+ i +"]"));
			}
			playInfoResponse.NotFoundCDNDomain = playInfoResponse_notFoundCDNDomain;

			List<PlayInfoResponse.PlayInfo_PlayInfo> playInfoResponse_playInfoList = new List<PlayInfoResponse.PlayInfo_PlayInfo>();
			for (int i = 0; i < context.Length("PlayInfo.PlayInfoList.Length"); i++) {
				PlayInfoResponse.PlayInfo_PlayInfo playInfo = new PlayInfoResponse.PlayInfo_PlayInfo();
				playInfo.Url = context.StringValue("PlayInfo.PlayInfoList["+ i +"].Url");
				playInfo.Duration = context.StringValue("PlayInfo.PlayInfoList["+ i +"].Duration");
				playInfo.Size = context.StringValue("PlayInfo.PlayInfoList["+ i +"].Size");
				playInfo.Width = context.StringValue("PlayInfo.PlayInfoList["+ i +"].Width");
				playInfo.Height = context.StringValue("PlayInfo.PlayInfoList["+ i +"].Height");
				playInfo.Bitrate = context.StringValue("PlayInfo.PlayInfoList["+ i +"].Bitrate");
				playInfo.Fps = context.StringValue("PlayInfo.PlayInfoList["+ i +"].Fps");
				playInfo.Format = context.StringValue("PlayInfo.PlayInfoList["+ i +"].Format");
				playInfo.Definition = context.StringValue("PlayInfo.PlayInfoList["+ i +"].Definition");
				playInfo.Encryption = context.StringValue("PlayInfo.PlayInfoList["+ i +"].Encryption");
				playInfo.Rand = context.StringValue("PlayInfo.PlayInfoList["+ i +"].Rand");
				playInfo.Plaintext = context.StringValue("PlayInfo.PlayInfoList["+ i +"].Plaintext");
				playInfo.Complexity = context.StringValue("PlayInfo.PlayInfoList["+ i +"].Complexity");
				playInfo.ActivityName = context.StringValue("PlayInfo.PlayInfoList["+ i +"].ActivityName");

				playInfoResponse_playInfoList.Add(playInfo);
			}
			playInfoResponse.PlayInfoList = playInfoResponse_playInfoList;
        
			return playInfoResponse;
        }
    }
}