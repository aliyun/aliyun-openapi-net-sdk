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
using Aliyun.Acs.imm.Model.V20170906;

namespace Aliyun.Acs.imm.Transform.V20170906
{
    public class GetMediaMetaResponseUnmarshaller
    {
        public static GetMediaMetaResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetMediaMetaResponse getMediaMetaResponse = new GetMediaMetaResponse();

			getMediaMetaResponse.HttpResponse = _ctx.HttpResponse;
			getMediaMetaResponse.RequestId = _ctx.StringValue("GetMediaMeta.RequestId");
			getMediaMetaResponse.MediaUri = _ctx.StringValue("GetMediaMeta.MediaUri");

			GetMediaMetaResponse.GetMediaMeta_MediaMeta mediaMeta = new GetMediaMetaResponse.GetMediaMeta_MediaMeta();

			GetMediaMetaResponse.GetMediaMeta_MediaMeta.GetMediaMeta_MediaFormat mediaFormat = new GetMediaMetaResponse.GetMediaMeta_MediaMeta.GetMediaMeta_MediaFormat();
			mediaFormat.NumberStreams = _ctx.IntegerValue("GetMediaMeta.MediaMeta.MediaFormat.NumberStreams");
			mediaFormat.NumberPrograms = _ctx.IntegerValue("GetMediaMeta.MediaMeta.MediaFormat.NumberPrograms");
			mediaFormat.FormatName = _ctx.StringValue("GetMediaMeta.MediaMeta.MediaFormat.FormatName");
			mediaFormat.FormatLongName = _ctx.StringValue("GetMediaMeta.MediaMeta.MediaFormat.FormatLongName");
			mediaFormat.Size = _ctx.StringValue("GetMediaMeta.MediaMeta.MediaFormat.Size");
			mediaFormat.Duration = _ctx.StringValue("GetMediaMeta.MediaMeta.MediaFormat.Duration");
			mediaFormat.StartTime = _ctx.StringValue("GetMediaMeta.MediaMeta.MediaFormat.StartTime");
			mediaFormat.Bitrate = _ctx.StringValue("GetMediaMeta.MediaMeta.MediaFormat.Bitrate");
			mediaFormat.CreationTime = _ctx.StringValue("GetMediaMeta.MediaMeta.MediaFormat.CreationTime");
			mediaFormat.Location = _ctx.StringValue("GetMediaMeta.MediaMeta.MediaFormat.Location");

			GetMediaMetaResponse.GetMediaMeta_MediaMeta.GetMediaMeta_MediaFormat.GetMediaMeta_Address address = new GetMediaMetaResponse.GetMediaMeta_MediaMeta.GetMediaMeta_MediaFormat.GetMediaMeta_Address();
			address.AddressLine = _ctx.StringValue("GetMediaMeta.MediaMeta.MediaFormat.Address.AddressLine");
			address.Country = _ctx.StringValue("GetMediaMeta.MediaMeta.MediaFormat.Address.Country");
			address.Province = _ctx.StringValue("GetMediaMeta.MediaMeta.MediaFormat.Address.Province");
			address.City = _ctx.StringValue("GetMediaMeta.MediaMeta.MediaFormat.Address.City");
			address.District = _ctx.StringValue("GetMediaMeta.MediaMeta.MediaFormat.Address.District");
			address.Township = _ctx.StringValue("GetMediaMeta.MediaMeta.MediaFormat.Address.Township");
			mediaFormat.Address = address;

			GetMediaMetaResponse.GetMediaMeta_MediaMeta.GetMediaMeta_MediaFormat.GetMediaMeta_Tag tag = new GetMediaMetaResponse.GetMediaMeta_MediaMeta.GetMediaMeta_MediaFormat.GetMediaMeta_Tag();
			tag.Language = _ctx.StringValue("GetMediaMeta.MediaMeta.MediaFormat.Tag.Language");
			tag.CreationTime = _ctx.StringValue("GetMediaMeta.MediaMeta.MediaFormat.Tag.CreationTime");
			tag.Album = _ctx.StringValue("GetMediaMeta.MediaMeta.MediaFormat.Tag.Album");
			tag.AlbumArtist = _ctx.StringValue("GetMediaMeta.MediaMeta.MediaFormat.Tag.AlbumArtist");
			tag.Artist = _ctx.StringValue("GetMediaMeta.MediaMeta.MediaFormat.Tag.Artist");
			tag.Composer = _ctx.StringValue("GetMediaMeta.MediaMeta.MediaFormat.Tag.Composer");
			tag.Title = _ctx.StringValue("GetMediaMeta.MediaMeta.MediaFormat.Tag.Title");
			tag.Performer = _ctx.StringValue("GetMediaMeta.MediaMeta.MediaFormat.Tag.Performer");
			mediaFormat.Tag = tag;
			mediaMeta.MediaFormat = mediaFormat;

			GetMediaMetaResponse.GetMediaMeta_MediaMeta.GetMediaMeta_MediaStreams mediaStreams = new GetMediaMetaResponse.GetMediaMeta_MediaMeta.GetMediaMeta_MediaStreams();

			List<GetMediaMetaResponse.GetMediaMeta_MediaMeta.GetMediaMeta_MediaStreams.GetMediaMeta_VideoStream> mediaStreams_videoStreams = new List<GetMediaMetaResponse.GetMediaMeta_MediaMeta.GetMediaMeta_MediaStreams.GetMediaMeta_VideoStream>();
			for (int i = 0; i < _ctx.Length("GetMediaMeta.MediaMeta.MediaStreams.VideoStreams.Length"); i++) {
				GetMediaMetaResponse.GetMediaMeta_MediaMeta.GetMediaMeta_MediaStreams.GetMediaMeta_VideoStream videoStream = new GetMediaMetaResponse.GetMediaMeta_MediaMeta.GetMediaMeta_MediaStreams.GetMediaMeta_VideoStream();
				videoStream.Index = _ctx.IntegerValue("GetMediaMeta.MediaMeta.MediaStreams.VideoStreams["+ i +"].Index");
				videoStream.Language = _ctx.StringValue("GetMediaMeta.MediaMeta.MediaStreams.VideoStreams["+ i +"].Language");
				videoStream.CodecName = _ctx.StringValue("GetMediaMeta.MediaMeta.MediaStreams.VideoStreams["+ i +"].CodecName");
				videoStream.CodecLongName = _ctx.StringValue("GetMediaMeta.MediaMeta.MediaStreams.VideoStreams["+ i +"].CodecLongName");
				videoStream.Profile = _ctx.StringValue("GetMediaMeta.MediaMeta.MediaStreams.VideoStreams["+ i +"].Profile");
				videoStream.CodecTimeBase = _ctx.StringValue("GetMediaMeta.MediaMeta.MediaStreams.VideoStreams["+ i +"].CodecTimeBase");
				videoStream.CodecTagString = _ctx.StringValue("GetMediaMeta.MediaMeta.MediaStreams.VideoStreams["+ i +"].CodecTagString");
				videoStream.CodecTag = _ctx.StringValue("GetMediaMeta.MediaMeta.MediaStreams.VideoStreams["+ i +"].CodecTag");
				videoStream.Width = _ctx.IntegerValue("GetMediaMeta.MediaMeta.MediaStreams.VideoStreams["+ i +"].Width");
				videoStream.Height = _ctx.IntegerValue("GetMediaMeta.MediaMeta.MediaStreams.VideoStreams["+ i +"].Height");
				videoStream.HasBFrames = _ctx.IntegerValue("GetMediaMeta.MediaMeta.MediaStreams.VideoStreams["+ i +"].HasBFrames");
				videoStream.SampleAspectRatio = _ctx.StringValue("GetMediaMeta.MediaMeta.MediaStreams.VideoStreams["+ i +"].SampleAspectRatio");
				videoStream.DisplayAspectRatio = _ctx.StringValue("GetMediaMeta.MediaMeta.MediaStreams.VideoStreams["+ i +"].DisplayAspectRatio");
				videoStream.PixelFormat = _ctx.StringValue("GetMediaMeta.MediaMeta.MediaStreams.VideoStreams["+ i +"].PixelFormat");
				videoStream.Level = _ctx.IntegerValue("GetMediaMeta.MediaMeta.MediaStreams.VideoStreams["+ i +"].Level");
				videoStream.FrameRrate = _ctx.StringValue("GetMediaMeta.MediaMeta.MediaStreams.VideoStreams["+ i +"].FrameRrate");
				videoStream.AverageFrameRate = _ctx.StringValue("GetMediaMeta.MediaMeta.MediaStreams.VideoStreams["+ i +"].AverageFrameRate");
				videoStream.TimeBase = _ctx.StringValue("GetMediaMeta.MediaMeta.MediaStreams.VideoStreams["+ i +"].TimeBase");
				videoStream.StartTime = _ctx.StringValue("GetMediaMeta.MediaMeta.MediaStreams.VideoStreams["+ i +"].StartTime");
				videoStream.Duration = _ctx.StringValue("GetMediaMeta.MediaMeta.MediaStreams.VideoStreams["+ i +"].Duration");
				videoStream.Bitrate = _ctx.StringValue("GetMediaMeta.MediaMeta.MediaStreams.VideoStreams["+ i +"].Bitrate");
				videoStream.Frames = _ctx.StringValue("GetMediaMeta.MediaMeta.MediaStreams.VideoStreams["+ i +"].Frames");
				videoStream.Rotate = _ctx.StringValue("GetMediaMeta.MediaMeta.MediaStreams.VideoStreams["+ i +"].Rotate");

				mediaStreams_videoStreams.Add(videoStream);
			}
			mediaStreams.VideoStreams = mediaStreams_videoStreams;

			List<GetMediaMetaResponse.GetMediaMeta_MediaMeta.GetMediaMeta_MediaStreams.GetMediaMeta_AudioStream> mediaStreams_audioStreams = new List<GetMediaMetaResponse.GetMediaMeta_MediaMeta.GetMediaMeta_MediaStreams.GetMediaMeta_AudioStream>();
			for (int i = 0; i < _ctx.Length("GetMediaMeta.MediaMeta.MediaStreams.AudioStreams.Length"); i++) {
				GetMediaMetaResponse.GetMediaMeta_MediaMeta.GetMediaMeta_MediaStreams.GetMediaMeta_AudioStream audioStream = new GetMediaMetaResponse.GetMediaMeta_MediaMeta.GetMediaMeta_MediaStreams.GetMediaMeta_AudioStream();
				audioStream.Index = _ctx.IntegerValue("GetMediaMeta.MediaMeta.MediaStreams.AudioStreams["+ i +"].Index");
				audioStream.CodecName = _ctx.StringValue("GetMediaMeta.MediaMeta.MediaStreams.AudioStreams["+ i +"].CodecName");
				audioStream.CodecLongName = _ctx.StringValue("GetMediaMeta.MediaMeta.MediaStreams.AudioStreams["+ i +"].CodecLongName");
				audioStream.CodecTimeBase = _ctx.StringValue("GetMediaMeta.MediaMeta.MediaStreams.AudioStreams["+ i +"].CodecTimeBase");
				audioStream.CodecTagString = _ctx.StringValue("GetMediaMeta.MediaMeta.MediaStreams.AudioStreams["+ i +"].CodecTagString");
				audioStream.CodecTag = _ctx.StringValue("GetMediaMeta.MediaMeta.MediaStreams.AudioStreams["+ i +"].CodecTag");
				audioStream.SampleFormat = _ctx.StringValue("GetMediaMeta.MediaMeta.MediaStreams.AudioStreams["+ i +"].SampleFormat");
				audioStream.SampleRate = _ctx.StringValue("GetMediaMeta.MediaMeta.MediaStreams.AudioStreams["+ i +"].SampleRate");
				audioStream.Channels = _ctx.IntegerValue("GetMediaMeta.MediaMeta.MediaStreams.AudioStreams["+ i +"].Channels");
				audioStream.ChannelLayout = _ctx.StringValue("GetMediaMeta.MediaMeta.MediaStreams.AudioStreams["+ i +"].ChannelLayout");
				audioStream.TimeBase = _ctx.StringValue("GetMediaMeta.MediaMeta.MediaStreams.AudioStreams["+ i +"].TimeBase");
				audioStream.StartTime = _ctx.StringValue("GetMediaMeta.MediaMeta.MediaStreams.AudioStreams["+ i +"].StartTime");
				audioStream.Duration = _ctx.StringValue("GetMediaMeta.MediaMeta.MediaStreams.AudioStreams["+ i +"].Duration");
				audioStream.Bitrate = _ctx.StringValue("GetMediaMeta.MediaMeta.MediaStreams.AudioStreams["+ i +"].Bitrate");
				audioStream.Frames = _ctx.StringValue("GetMediaMeta.MediaMeta.MediaStreams.AudioStreams["+ i +"].Frames");
				audioStream.Language = _ctx.StringValue("GetMediaMeta.MediaMeta.MediaStreams.AudioStreams["+ i +"].Language");

				mediaStreams_audioStreams.Add(audioStream);
			}
			mediaStreams.AudioStreams = mediaStreams_audioStreams;

			List<GetMediaMetaResponse.GetMediaMeta_MediaMeta.GetMediaMeta_MediaStreams.GetMediaMeta_SubtitleStream> mediaStreams_subtitleStreams = new List<GetMediaMetaResponse.GetMediaMeta_MediaMeta.GetMediaMeta_MediaStreams.GetMediaMeta_SubtitleStream>();
			for (int i = 0; i < _ctx.Length("GetMediaMeta.MediaMeta.MediaStreams.SubtitleStreams.Length"); i++) {
				GetMediaMetaResponse.GetMediaMeta_MediaMeta.GetMediaMeta_MediaStreams.GetMediaMeta_SubtitleStream subtitleStream = new GetMediaMetaResponse.GetMediaMeta_MediaMeta.GetMediaMeta_MediaStreams.GetMediaMeta_SubtitleStream();
				subtitleStream.Index = _ctx.IntegerValue("GetMediaMeta.MediaMeta.MediaStreams.SubtitleStreams["+ i +"].Index");
				subtitleStream.Language = _ctx.StringValue("GetMediaMeta.MediaMeta.MediaStreams.SubtitleStreams["+ i +"].Language");

				mediaStreams_subtitleStreams.Add(subtitleStream);
			}
			mediaStreams.SubtitleStreams = mediaStreams_subtitleStreams;
			mediaMeta.MediaStreams = mediaStreams;
			getMediaMetaResponse.MediaMeta = mediaMeta;
        
			return getMediaMetaResponse;
        }
    }
}
