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
			getMediaMetaResponse.MediaUri = _ctx.StringValue("GetMediaMeta.MediaUri");
			getMediaMetaResponse.RequestId = _ctx.StringValue("GetMediaMeta.RequestId");

			GetMediaMetaResponse.GetMediaMeta_MediaMeta mediaMeta = new GetMediaMetaResponse.GetMediaMeta_MediaMeta();

			GetMediaMetaResponse.GetMediaMeta_MediaMeta.GetMediaMeta_MediaFormat mediaFormat = new GetMediaMetaResponse.GetMediaMeta_MediaMeta.GetMediaMeta_MediaFormat();
			mediaFormat.Size = _ctx.StringValue("GetMediaMeta.MediaMeta.MediaFormat.Size");
			mediaFormat.NumberStreams = _ctx.IntegerValue("GetMediaMeta.MediaMeta.MediaFormat.NumberStreams");
			mediaFormat.FormatLongName = _ctx.StringValue("GetMediaMeta.MediaMeta.MediaFormat.FormatLongName");
			mediaFormat.StartTime = _ctx.StringValue("GetMediaMeta.MediaMeta.MediaFormat.StartTime");
			mediaFormat.CreationTime = _ctx.StringValue("GetMediaMeta.MediaMeta.MediaFormat.CreationTime");
			mediaFormat.FormatName = _ctx.StringValue("GetMediaMeta.MediaMeta.MediaFormat.FormatName");
			mediaFormat.Duration = _ctx.StringValue("GetMediaMeta.MediaMeta.MediaFormat.Duration");
			mediaFormat.Bitrate = _ctx.StringValue("GetMediaMeta.MediaMeta.MediaFormat.Bitrate");
			mediaFormat.Location = _ctx.StringValue("GetMediaMeta.MediaMeta.MediaFormat.Location");
			mediaFormat.NumberPrograms = _ctx.IntegerValue("GetMediaMeta.MediaMeta.MediaFormat.NumberPrograms");

			GetMediaMetaResponse.GetMediaMeta_MediaMeta.GetMediaMeta_MediaFormat.GetMediaMeta_Address address = new GetMediaMetaResponse.GetMediaMeta_MediaMeta.GetMediaMeta_MediaFormat.GetMediaMeta_Address();
			address.Township = _ctx.StringValue("GetMediaMeta.MediaMeta.MediaFormat.Address.Township");
			address.AddressLine = _ctx.StringValue("GetMediaMeta.MediaMeta.MediaFormat.Address.AddressLine");
			address.Country = _ctx.StringValue("GetMediaMeta.MediaMeta.MediaFormat.Address.Country");
			address.City = _ctx.StringValue("GetMediaMeta.MediaMeta.MediaFormat.Address.City");
			address.District = _ctx.StringValue("GetMediaMeta.MediaMeta.MediaFormat.Address.District");
			address.Province = _ctx.StringValue("GetMediaMeta.MediaMeta.MediaFormat.Address.Province");
			mediaFormat.Address = address;

			GetMediaMetaResponse.GetMediaMeta_MediaMeta.GetMediaMeta_MediaFormat.GetMediaMeta_Tag tag = new GetMediaMetaResponse.GetMediaMeta_MediaMeta.GetMediaMeta_MediaFormat.GetMediaMeta_Tag();
			tag.Artist = _ctx.StringValue("GetMediaMeta.MediaMeta.MediaFormat.Tag.Artist");
			tag.Composer = _ctx.StringValue("GetMediaMeta.MediaMeta.MediaFormat.Tag.Composer");
			tag.Performer = _ctx.StringValue("GetMediaMeta.MediaMeta.MediaFormat.Tag.Performer");
			tag.Language = _ctx.StringValue("GetMediaMeta.MediaMeta.MediaFormat.Tag.Language");
			tag.CreationTime = _ctx.StringValue("GetMediaMeta.MediaMeta.MediaFormat.Tag.CreationTime");
			tag.Title = _ctx.StringValue("GetMediaMeta.MediaMeta.MediaFormat.Tag.Title");
			tag.Album = _ctx.StringValue("GetMediaMeta.MediaMeta.MediaFormat.Tag.Album");
			tag.AlbumArtist = _ctx.StringValue("GetMediaMeta.MediaMeta.MediaFormat.Tag.AlbumArtist");
			mediaFormat.Tag = tag;
			mediaMeta.MediaFormat = mediaFormat;

			GetMediaMetaResponse.GetMediaMeta_MediaMeta.GetMediaMeta_MediaStreams mediaStreams = new GetMediaMetaResponse.GetMediaMeta_MediaMeta.GetMediaMeta_MediaStreams();

			List<GetMediaMetaResponse.GetMediaMeta_MediaMeta.GetMediaMeta_MediaStreams.GetMediaMeta_VideoStream> mediaStreams_videoStreams = new List<GetMediaMetaResponse.GetMediaMeta_MediaMeta.GetMediaMeta_MediaStreams.GetMediaMeta_VideoStream>();
			for (int i = 0; i < _ctx.Length("GetMediaMeta.MediaMeta.MediaStreams.VideoStreams.Length"); i++) {
				GetMediaMetaResponse.GetMediaMeta_MediaMeta.GetMediaMeta_MediaStreams.GetMediaMeta_VideoStream videoStream = new GetMediaMetaResponse.GetMediaMeta_MediaMeta.GetMediaMeta_MediaStreams.GetMediaMeta_VideoStream();
				videoStream.CodecTag = _ctx.StringValue("GetMediaMeta.MediaMeta.MediaStreams.VideoStreams["+ i +"].CodecTag");
				videoStream.Frames = _ctx.StringValue("GetMediaMeta.MediaMeta.MediaStreams.VideoStreams["+ i +"].Frames");
				videoStream.CodecTimeBase = _ctx.StringValue("GetMediaMeta.MediaMeta.MediaStreams.VideoStreams["+ i +"].CodecTimeBase");
				videoStream.Rotate = _ctx.StringValue("GetMediaMeta.MediaMeta.MediaStreams.VideoStreams["+ i +"].Rotate");
				videoStream.SampleAspectRatio = _ctx.StringValue("GetMediaMeta.MediaMeta.MediaStreams.VideoStreams["+ i +"].SampleAspectRatio");
				videoStream.StartTime = _ctx.StringValue("GetMediaMeta.MediaMeta.MediaStreams.VideoStreams["+ i +"].StartTime");
				videoStream.Duration = _ctx.StringValue("GetMediaMeta.MediaMeta.MediaStreams.VideoStreams["+ i +"].Duration");
				videoStream.Index = _ctx.IntegerValue("GetMediaMeta.MediaMeta.MediaStreams.VideoStreams["+ i +"].Index");
				videoStream.CodecName = _ctx.StringValue("GetMediaMeta.MediaMeta.MediaStreams.VideoStreams["+ i +"].CodecName");
				videoStream.Bitrate = _ctx.StringValue("GetMediaMeta.MediaMeta.MediaStreams.VideoStreams["+ i +"].Bitrate");
				videoStream.Profile = _ctx.StringValue("GetMediaMeta.MediaMeta.MediaStreams.VideoStreams["+ i +"].Profile");
				videoStream.DisplayAspectRatio = _ctx.StringValue("GetMediaMeta.MediaMeta.MediaStreams.VideoStreams["+ i +"].DisplayAspectRatio");
				videoStream.HasBFrames = _ctx.IntegerValue("GetMediaMeta.MediaMeta.MediaStreams.VideoStreams["+ i +"].HasBFrames");
				videoStream.CodecTagString = _ctx.StringValue("GetMediaMeta.MediaMeta.MediaStreams.VideoStreams["+ i +"].CodecTagString");
				videoStream.AverageFrameRate = _ctx.StringValue("GetMediaMeta.MediaMeta.MediaStreams.VideoStreams["+ i +"].AverageFrameRate");
				videoStream.Language = _ctx.StringValue("GetMediaMeta.MediaMeta.MediaStreams.VideoStreams["+ i +"].Language");
				videoStream.CodecLongName = _ctx.StringValue("GetMediaMeta.MediaMeta.MediaStreams.VideoStreams["+ i +"].CodecLongName");
				videoStream.PixelFormat = _ctx.StringValue("GetMediaMeta.MediaMeta.MediaStreams.VideoStreams["+ i +"].PixelFormat");
				videoStream.Level = _ctx.IntegerValue("GetMediaMeta.MediaMeta.MediaStreams.VideoStreams["+ i +"].Level");
				videoStream.Height = _ctx.IntegerValue("GetMediaMeta.MediaMeta.MediaStreams.VideoStreams["+ i +"].Height");
				videoStream.FrameRrate = _ctx.StringValue("GetMediaMeta.MediaMeta.MediaStreams.VideoStreams["+ i +"].FrameRrate");
				videoStream.Width = _ctx.IntegerValue("GetMediaMeta.MediaMeta.MediaStreams.VideoStreams["+ i +"].Width");
				videoStream.TimeBase = _ctx.StringValue("GetMediaMeta.MediaMeta.MediaStreams.VideoStreams["+ i +"].TimeBase");

				mediaStreams_videoStreams.Add(videoStream);
			}
			mediaStreams.VideoStreams = mediaStreams_videoStreams;

			List<GetMediaMetaResponse.GetMediaMeta_MediaMeta.GetMediaMeta_MediaStreams.GetMediaMeta_SubtitleStream> mediaStreams_subtitleStreams = new List<GetMediaMetaResponse.GetMediaMeta_MediaMeta.GetMediaMeta_MediaStreams.GetMediaMeta_SubtitleStream>();
			for (int i = 0; i < _ctx.Length("GetMediaMeta.MediaMeta.MediaStreams.SubtitleStreams.Length"); i++) {
				GetMediaMetaResponse.GetMediaMeta_MediaMeta.GetMediaMeta_MediaStreams.GetMediaMeta_SubtitleStream subtitleStream = new GetMediaMetaResponse.GetMediaMeta_MediaMeta.GetMediaMeta_MediaStreams.GetMediaMeta_SubtitleStream();
				subtitleStream.Language = _ctx.StringValue("GetMediaMeta.MediaMeta.MediaStreams.SubtitleStreams["+ i +"].Language");
				subtitleStream.Index = _ctx.IntegerValue("GetMediaMeta.MediaMeta.MediaStreams.SubtitleStreams["+ i +"].Index");

				mediaStreams_subtitleStreams.Add(subtitleStream);
			}
			mediaStreams.SubtitleStreams = mediaStreams_subtitleStreams;

			List<GetMediaMetaResponse.GetMediaMeta_MediaMeta.GetMediaMeta_MediaStreams.GetMediaMeta_AudioStream> mediaStreams_audioStreams = new List<GetMediaMetaResponse.GetMediaMeta_MediaMeta.GetMediaMeta_MediaStreams.GetMediaMeta_AudioStream>();
			for (int i = 0; i < _ctx.Length("GetMediaMeta.MediaMeta.MediaStreams.AudioStreams.Length"); i++) {
				GetMediaMetaResponse.GetMediaMeta_MediaMeta.GetMediaMeta_MediaStreams.GetMediaMeta_AudioStream audioStream = new GetMediaMetaResponse.GetMediaMeta_MediaMeta.GetMediaMeta_MediaStreams.GetMediaMeta_AudioStream();
				audioStream.CodecTag = _ctx.StringValue("GetMediaMeta.MediaMeta.MediaStreams.AudioStreams["+ i +"].CodecTag");
				audioStream.Frames = _ctx.StringValue("GetMediaMeta.MediaMeta.MediaStreams.AudioStreams["+ i +"].Frames");
				audioStream.CodecTimeBase = _ctx.StringValue("GetMediaMeta.MediaMeta.MediaStreams.AudioStreams["+ i +"].CodecTimeBase");
				audioStream.ChannelLayout = _ctx.StringValue("GetMediaMeta.MediaMeta.MediaStreams.AudioStreams["+ i +"].ChannelLayout");
				audioStream.StartTime = _ctx.StringValue("GetMediaMeta.MediaMeta.MediaStreams.AudioStreams["+ i +"].StartTime");
				audioStream.Duration = _ctx.StringValue("GetMediaMeta.MediaMeta.MediaStreams.AudioStreams["+ i +"].Duration");
				audioStream.Index = _ctx.IntegerValue("GetMediaMeta.MediaMeta.MediaStreams.AudioStreams["+ i +"].Index");
				audioStream.CodecName = _ctx.StringValue("GetMediaMeta.MediaMeta.MediaStreams.AudioStreams["+ i +"].CodecName");
				audioStream.Bitrate = _ctx.StringValue("GetMediaMeta.MediaMeta.MediaStreams.AudioStreams["+ i +"].Bitrate");
				audioStream.SampleFormat = _ctx.StringValue("GetMediaMeta.MediaMeta.MediaStreams.AudioStreams["+ i +"].SampleFormat");
				audioStream.Channels = _ctx.IntegerValue("GetMediaMeta.MediaMeta.MediaStreams.AudioStreams["+ i +"].Channels");
				audioStream.CodecTagString = _ctx.StringValue("GetMediaMeta.MediaMeta.MediaStreams.AudioStreams["+ i +"].CodecTagString");
				audioStream.SampleRate = _ctx.StringValue("GetMediaMeta.MediaMeta.MediaStreams.AudioStreams["+ i +"].SampleRate");
				audioStream.Language = _ctx.StringValue("GetMediaMeta.MediaMeta.MediaStreams.AudioStreams["+ i +"].Language");
				audioStream.CodecLongName = _ctx.StringValue("GetMediaMeta.MediaMeta.MediaStreams.AudioStreams["+ i +"].CodecLongName");
				audioStream.TimeBase = _ctx.StringValue("GetMediaMeta.MediaMeta.MediaStreams.AudioStreams["+ i +"].TimeBase");

				mediaStreams_audioStreams.Add(audioStream);
			}
			mediaStreams.AudioStreams = mediaStreams_audioStreams;
			mediaMeta.MediaStreams = mediaStreams;
			getMediaMetaResponse.MediaMeta = mediaMeta;
        
			return getMediaMetaResponse;
        }
    }
}
