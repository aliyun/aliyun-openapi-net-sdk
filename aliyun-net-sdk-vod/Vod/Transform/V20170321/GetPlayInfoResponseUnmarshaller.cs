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
    public class GetPlayInfoResponseUnmarshaller
    {
        public static GetPlayInfoResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetPlayInfoResponse getPlayInfoResponse = new GetPlayInfoResponse();

			getPlayInfoResponse.HttpResponse = _ctx.HttpResponse;
			getPlayInfoResponse.RequestId = _ctx.StringValue("GetPlayInfo.RequestId");

			GetPlayInfoResponse.GetPlayInfo_VideoBase videoBase = new GetPlayInfoResponse.GetPlayInfo_VideoBase();
			videoBase.CreationTime = _ctx.StringValue("GetPlayInfo.VideoBase.CreationTime");
			videoBase.Status = _ctx.StringValue("GetPlayInfo.VideoBase.Status");
			videoBase.TranscodeMode = _ctx.StringValue("GetPlayInfo.VideoBase.TranscodeMode");
			videoBase.OutputType = _ctx.StringValue("GetPlayInfo.VideoBase.OutputType");
			videoBase.VideoId = _ctx.StringValue("GetPlayInfo.VideoBase.VideoId");
			videoBase.CoverURL = _ctx.StringValue("GetPlayInfo.VideoBase.CoverURL");
			videoBase.Duration = _ctx.StringValue("GetPlayInfo.VideoBase.Duration");
			videoBase.Title = _ctx.StringValue("GetPlayInfo.VideoBase.Title");
			videoBase.MediaType = _ctx.StringValue("GetPlayInfo.VideoBase.MediaType");
			videoBase.DanMuURL = _ctx.StringValue("GetPlayInfo.VideoBase.DanMuURL");
			videoBase.StorageClass = _ctx.StringValue("GetPlayInfo.VideoBase.StorageClass");

			List<GetPlayInfoResponse.GetPlayInfo_VideoBase.GetPlayInfo_Thumbnail> videoBase_thumbnailList = new List<GetPlayInfoResponse.GetPlayInfo_VideoBase.GetPlayInfo_Thumbnail>();
			for (int i = 0; i < _ctx.Length("GetPlayInfo.VideoBase.ThumbnailList.Length"); i++) {
				GetPlayInfoResponse.GetPlayInfo_VideoBase.GetPlayInfo_Thumbnail thumbnail = new GetPlayInfoResponse.GetPlayInfo_VideoBase.GetPlayInfo_Thumbnail();
				thumbnail.URL = _ctx.StringValue("GetPlayInfo.VideoBase.ThumbnailList["+ i +"].URL");

				videoBase_thumbnailList.Add(thumbnail);
			}
			videoBase.ThumbnailList = videoBase_thumbnailList;
			getPlayInfoResponse.VideoBase = videoBase;

			List<GetPlayInfoResponse.GetPlayInfo_PlayInfo> getPlayInfoResponse_playInfoList = new List<GetPlayInfoResponse.GetPlayInfo_PlayInfo>();
			for (int i = 0; i < _ctx.Length("GetPlayInfo.PlayInfoList.Length"); i++) {
				GetPlayInfoResponse.GetPlayInfo_PlayInfo playInfo = new GetPlayInfoResponse.GetPlayInfo_PlayInfo();
				playInfo.CreationTime = _ctx.StringValue("GetPlayInfo.PlayInfoList["+ i +"].CreationTime");
				playInfo.Status = _ctx.StringValue("GetPlayInfo.PlayInfoList["+ i +"].Status");
				playInfo.Specification = _ctx.StringValue("GetPlayInfo.PlayInfoList["+ i +"].Specification");
				playInfo.Complexity = _ctx.StringValue("GetPlayInfo.PlayInfoList["+ i +"].Complexity");
				playInfo.NarrowBandType = _ctx.StringValue("GetPlayInfo.PlayInfoList["+ i +"].NarrowBandType");
				playInfo.Height = _ctx.LongValue("GetPlayInfo.PlayInfoList["+ i +"].Height");
				playInfo.Bitrate = _ctx.StringValue("GetPlayInfo.PlayInfoList["+ i +"].Bitrate");
				playInfo.ModificationTime = _ctx.StringValue("GetPlayInfo.PlayInfoList["+ i +"].ModificationTime");
				playInfo.WatermarkId = _ctx.StringValue("GetPlayInfo.PlayInfoList["+ i +"].WatermarkId");
				playInfo.Encrypt = _ctx.LongValue("GetPlayInfo.PlayInfoList["+ i +"].Encrypt");
				playInfo.Definition = _ctx.StringValue("GetPlayInfo.PlayInfoList["+ i +"].Definition");
				playInfo.Rand = _ctx.StringValue("GetPlayInfo.PlayInfoList["+ i +"].Rand");
				playInfo.EncryptType = _ctx.StringValue("GetPlayInfo.PlayInfoList["+ i +"].EncryptType");
				playInfo.PreprocessStatus = _ctx.StringValue("GetPlayInfo.PlayInfoList["+ i +"].PreprocessStatus");
				playInfo.StreamType = _ctx.StringValue("GetPlayInfo.PlayInfoList["+ i +"].StreamType");
				playInfo.JobId = _ctx.StringValue("GetPlayInfo.PlayInfoList["+ i +"].JobId");
				playInfo.Plaintext = _ctx.StringValue("GetPlayInfo.PlayInfoList["+ i +"].Plaintext");
				playInfo.Size = _ctx.LongValue("GetPlayInfo.PlayInfoList["+ i +"].Size");
				playInfo.Width = _ctx.LongValue("GetPlayInfo.PlayInfoList["+ i +"].Width");
				playInfo.Fps = _ctx.StringValue("GetPlayInfo.PlayInfoList["+ i +"].Fps");
				playInfo.Duration = _ctx.StringValue("GetPlayInfo.PlayInfoList["+ i +"].Duration");
				playInfo.PlayURL = _ctx.StringValue("GetPlayInfo.PlayInfoList["+ i +"].PlayURL");
				playInfo.Format = _ctx.StringValue("GetPlayInfo.PlayInfoList["+ i +"].Format");
				playInfo.HDRType = _ctx.StringValue("GetPlayInfo.PlayInfoList["+ i +"].HDRType");
				playInfo.BitDepth = _ctx.IntegerValue("GetPlayInfo.PlayInfoList["+ i +"].BitDepth");
				playInfo.JobType = _ctx.IntegerValue("GetPlayInfo.PlayInfoList["+ i +"].JobType");
				playInfo.JobExt = _ctx.StringValue("GetPlayInfo.PlayInfoList["+ i +"].JobExt");

				getPlayInfoResponse_playInfoList.Add(playInfo);
			}
			getPlayInfoResponse.PlayInfoList = getPlayInfoResponse_playInfoList;
        
			return getPlayInfoResponse;
        }
    }
}
