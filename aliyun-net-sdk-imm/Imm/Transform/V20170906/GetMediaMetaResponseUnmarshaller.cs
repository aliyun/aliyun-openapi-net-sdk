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
        public static GetMediaMetaResponse Unmarshall(UnmarshallerContext context)
        {
			GetMediaMetaResponse getMediaMetaResponse = new GetMediaMetaResponse();

			getMediaMetaResponse.HttpResponse = context.HttpResponse;
			getMediaMetaResponse.RequestId = context.StringValue("GetMediaMeta.RequestId");
			getMediaMetaResponse.MediaUri = context.StringValue("GetMediaMeta.MediaUri");

			GetMediaMetaResponse.GetMediaMeta_MediaMeta mediaMeta = new GetMediaMetaResponse.GetMediaMeta_MediaMeta();

			GetMediaMetaResponse.GetMediaMeta_MediaMeta.GetMediaMeta_MediaFormat mediaFormat = new GetMediaMetaResponse.GetMediaMeta_MediaMeta.GetMediaMeta_MediaFormat();
			mediaFormat.NumberStreams = context.IntegerValue("GetMediaMeta.MediaMeta.MediaFormat.NumberStreams");
			mediaFormat.NumberPrograms = context.IntegerValue("GetMediaMeta.MediaMeta.MediaFormat.NumberPrograms");
			mediaFormat.FormatName = context.StringValue("GetMediaMeta.MediaMeta.MediaFormat.FormatName");
			mediaFormat.FormatLongName = context.StringValue("GetMediaMeta.MediaMeta.MediaFormat.FormatLongName");
			mediaFormat.Size = context.StringValue("GetMediaMeta.MediaMeta.MediaFormat.Size");
			mediaFormat.Duration = context.StringValue("GetMediaMeta.MediaMeta.MediaFormat.Duration");
			mediaFormat.StartTime = context.StringValue("GetMediaMeta.MediaMeta.MediaFormat.StartTime");
			mediaFormat.Bitrate = context.StringValue("GetMediaMeta.MediaMeta.MediaFormat.Bitrate");
			mediaFormat.CreationTime = context.StringValue("GetMediaMeta.MediaMeta.MediaFormat.CreationTime");
			mediaFormat.Location = context.StringValue("GetMediaMeta.MediaMeta.MediaFormat.Location");

			GetMediaMetaResponse.GetMediaMeta_MediaMeta.GetMediaMeta_MediaFormat.GetMediaMeta_Address address = new GetMediaMetaResponse.GetMediaMeta_MediaMeta.GetMediaMeta_MediaFormat.GetMediaMeta_Address();
			address.AddressLine = context.StringValue("GetMediaMeta.MediaMeta.MediaFormat.Address.AddressLine");
			address.Country = context.StringValue("GetMediaMeta.MediaMeta.MediaFormat.Address.Country");
			address.Province = context.StringValue("GetMediaMeta.MediaMeta.MediaFormat.Address.Province");
			address.City = context.StringValue("GetMediaMeta.MediaMeta.MediaFormat.Address.City");
			address.District = context.StringValue("GetMediaMeta.MediaMeta.MediaFormat.Address.District");
			address.Township = context.StringValue("GetMediaMeta.MediaMeta.MediaFormat.Address.Township");
			mediaFormat.Address = address;

			GetMediaMetaResponse.GetMediaMeta_MediaMeta.GetMediaMeta_MediaFormat.GetMediaMeta_Tag tag = new GetMediaMetaResponse.GetMediaMeta_MediaMeta.GetMediaMeta_MediaFormat.GetMediaMeta_Tag();
			tag.Language = context.StringValue("GetMediaMeta.MediaMeta.MediaFormat.Tag.Language");
			tag.CreationTime = context.StringValue("GetMediaMeta.MediaMeta.MediaFormat.Tag.CreationTime");
			tag.Album = context.StringValue("GetMediaMeta.MediaMeta.MediaFormat.Tag.Album");
			tag.AlbumArtist = context.StringValue("GetMediaMeta.MediaMeta.MediaFormat.Tag.AlbumArtist");
			tag.Artist = context.StringValue("GetMediaMeta.MediaMeta.MediaFormat.Tag.Artist");
			tag.Composer = context.StringValue("GetMediaMeta.MediaMeta.MediaFormat.Tag.Composer");
			tag.Title = context.StringValue("GetMediaMeta.MediaMeta.MediaFormat.Tag.Title");
			tag.Performer = context.StringValue("GetMediaMeta.MediaMeta.MediaFormat.Tag.Performer");
			mediaFormat.Tag = tag;
			mediaMeta.MediaFormat = mediaFormat;

			GetMediaMetaResponse.GetMediaMeta_MediaMeta.GetMediaMeta_MediaStreams mediaStreams = new GetMediaMetaResponse.GetMediaMeta_MediaMeta.GetMediaMeta_MediaStreams();

			List<GetMediaMetaResponse.GetMediaMeta_MediaMeta.GetMediaMeta_MediaStreams.GetMediaMeta_VideoStream> mediaStreams_videoStreams = new List<GetMediaMetaResponse.GetMediaMeta_MediaMeta.GetMediaMeta_MediaStreams.GetMediaMeta_VideoStream>();
			for (int i = 0; i < context.Length("GetMediaMeta.MediaMeta.MediaStreams.VideoStreams.Length"); i++) {
				GetMediaMetaResponse.GetMediaMeta_MediaMeta.GetMediaMeta_MediaStreams.GetMediaMeta_VideoStream videoStream = new GetMediaMetaResponse.GetMediaMeta_MediaMeta.GetMediaMeta_MediaStreams.GetMediaMeta_VideoStream();
				videoStream.Index = context.IntegerValue("GetMediaMeta.MediaMeta.MediaStreams.VideoStreams["+ i +"].Index");
				videoStream.Language = context.StringValue("GetMediaMeta.MediaMeta.MediaStreams.VideoStreams["+ i +"].Language");
				videoStream.CodecName = context.StringValue("GetMediaMeta.MediaMeta.MediaStreams.VideoStreams["+ i +"].CodecName");
				videoStream.CodecLongName = context.StringValue("GetMediaMeta.MediaMeta.MediaStreams.VideoStreams["+ i +"].CodecLongName");
				videoStream.Profile = context.StringValue("GetMediaMeta.MediaMeta.MediaStreams.VideoStreams["+ i +"].Profile");
				videoStream.CodecTimeBase = context.StringValue("GetMediaMeta.MediaMeta.MediaStreams.VideoStreams["+ i +"].CodecTimeBase");
				videoStream.CodecTagString = context.StringValue("GetMediaMeta.MediaMeta.MediaStreams.VideoStreams["+ i +"].CodecTagString");
				videoStream.CodecTag = context.StringValue("GetMediaMeta.MediaMeta.MediaStreams.VideoStreams["+ i +"].CodecTag");
				videoStream.Width = context.IntegerValue("GetMediaMeta.MediaMeta.MediaStreams.VideoStreams["+ i +"].Width");
				videoStream.Height = context.IntegerValue("GetMediaMeta.MediaMeta.MediaStreams.VideoStreams["+ i +"].Height");
				videoStream.HasBFrames = context.IntegerValue("GetMediaMeta.MediaMeta.MediaStreams.VideoStreams["+ i +"].HasBFrames");
				videoStream.SampleAspectRatio = context.StringValue("GetMediaMeta.MediaMeta.MediaStreams.VideoStreams["+ i +"].SampleAspectRatio");
				videoStream.DisplayAspectRatio = context.StringValue("GetMediaMeta.MediaMeta.MediaStreams.VideoStreams["+ i +"].DisplayAspectRatio");
				videoStream.PixelFormat = context.StringValue("GetMediaMeta.MediaMeta.MediaStreams.VideoStreams["+ i +"].PixelFormat");
				videoStream.Level = context.IntegerValue("GetMediaMeta.MediaMeta.MediaStreams.VideoStreams["+ i +"].Level");
				videoStream.FrameRrate = context.StringValue("GetMediaMeta.MediaMeta.MediaStreams.VideoStreams["+ i +"].FrameRrate");
				videoStream.AverageFrameRate = context.StringValue("GetMediaMeta.MediaMeta.MediaStreams.VideoStreams["+ i +"].AverageFrameRate");
				videoStream.TimeBase = context.StringValue("GetMediaMeta.MediaMeta.MediaStreams.VideoStreams["+ i +"].TimeBase");
				videoStream.StartTime = context.StringValue("GetMediaMeta.MediaMeta.MediaStreams.VideoStreams["+ i +"].StartTime");
				videoStream.Duration = context.StringValue("GetMediaMeta.MediaMeta.MediaStreams.VideoStreams["+ i +"].Duration");
				videoStream.Bitrate = context.StringValue("GetMediaMeta.MediaMeta.MediaStreams.VideoStreams["+ i +"].Bitrate");
				videoStream.Frames = context.StringValue("GetMediaMeta.MediaMeta.MediaStreams.VideoStreams["+ i +"].Frames");
				videoStream.Rotate = context.StringValue("GetMediaMeta.MediaMeta.MediaStreams.VideoStreams["+ i +"].Rotate");

				mediaStreams_videoStreams.Add(videoStream);
			}
			mediaStreams.VideoStreams = mediaStreams_videoStreams;

			List<GetMediaMetaResponse.GetMediaMeta_MediaMeta.GetMediaMeta_MediaStreams.GetMediaMeta_AudioStream> mediaStreams_audioStreams = new List<GetMediaMetaResponse.GetMediaMeta_MediaMeta.GetMediaMeta_MediaStreams.GetMediaMeta_AudioStream>();
			for (int i = 0; i < context.Length("GetMediaMeta.MediaMeta.MediaStreams.AudioStreams.Length"); i++) {
				GetMediaMetaResponse.GetMediaMeta_MediaMeta.GetMediaMeta_MediaStreams.GetMediaMeta_AudioStream audioStream = new GetMediaMetaResponse.GetMediaMeta_MediaMeta.GetMediaMeta_MediaStreams.GetMediaMeta_AudioStream();
				audioStream.Index = context.IntegerValue("GetMediaMeta.MediaMeta.MediaStreams.AudioStreams["+ i +"].Index");
				audioStream.CodecName = context.StringValue("GetMediaMeta.MediaMeta.MediaStreams.AudioStreams["+ i +"].CodecName");
				audioStream.CodecLongName = context.StringValue("GetMediaMeta.MediaMeta.MediaStreams.AudioStreams["+ i +"].CodecLongName");
				audioStream.CodecTimeBase = context.StringValue("GetMediaMeta.MediaMeta.MediaStreams.AudioStreams["+ i +"].CodecTimeBase");
				audioStream.CodecTagString = context.StringValue("GetMediaMeta.MediaMeta.MediaStreams.AudioStreams["+ i +"].CodecTagString");
				audioStream.CodecTag = context.StringValue("GetMediaMeta.MediaMeta.MediaStreams.AudioStreams["+ i +"].CodecTag");
				audioStream.SampleFormat = context.StringValue("GetMediaMeta.MediaMeta.MediaStreams.AudioStreams["+ i +"].SampleFormat");
				audioStream.SampleRate = context.StringValue("GetMediaMeta.MediaMeta.MediaStreams.AudioStreams["+ i +"].SampleRate");
				audioStream.Channels = context.IntegerValue("GetMediaMeta.MediaMeta.MediaStreams.AudioStreams["+ i +"].Channels");
				audioStream.ChannelLayout = context.StringValue("GetMediaMeta.MediaMeta.MediaStreams.AudioStreams["+ i +"].ChannelLayout");
				audioStream.TimeBase = context.StringValue("GetMediaMeta.MediaMeta.MediaStreams.AudioStreams["+ i +"].TimeBase");
				audioStream.StartTime = context.StringValue("GetMediaMeta.MediaMeta.MediaStreams.AudioStreams["+ i +"].StartTime");
				audioStream.Duration = context.StringValue("GetMediaMeta.MediaMeta.MediaStreams.AudioStreams["+ i +"].Duration");
				audioStream.Bitrate = context.StringValue("GetMediaMeta.MediaMeta.MediaStreams.AudioStreams["+ i +"].Bitrate");
				audioStream.Frames = context.StringValue("GetMediaMeta.MediaMeta.MediaStreams.AudioStreams["+ i +"].Frames");
				audioStream.Language = context.StringValue("GetMediaMeta.MediaMeta.MediaStreams.AudioStreams["+ i +"].Language");

				mediaStreams_audioStreams.Add(audioStream);
			}
			mediaStreams.AudioStreams = mediaStreams_audioStreams;

			List<GetMediaMetaResponse.GetMediaMeta_MediaMeta.GetMediaMeta_MediaStreams.GetMediaMeta_SubtitleStream> mediaStreams_subtitleStreams = new List<GetMediaMetaResponse.GetMediaMeta_MediaMeta.GetMediaMeta_MediaStreams.GetMediaMeta_SubtitleStream>();
			for (int i = 0; i < context.Length("GetMediaMeta.MediaMeta.MediaStreams.SubtitleStreams.Length"); i++) {
				GetMediaMetaResponse.GetMediaMeta_MediaMeta.GetMediaMeta_MediaStreams.GetMediaMeta_SubtitleStream subtitleStream = new GetMediaMetaResponse.GetMediaMeta_MediaMeta.GetMediaMeta_MediaStreams.GetMediaMeta_SubtitleStream();
				subtitleStream.Index = context.IntegerValue("GetMediaMeta.MediaMeta.MediaStreams.SubtitleStreams["+ i +"].Index");
				subtitleStream.Language = context.StringValue("GetMediaMeta.MediaMeta.MediaStreams.SubtitleStreams["+ i +"].Language");

				mediaStreams_subtitleStreams.Add(subtitleStream);
			}
			mediaStreams.SubtitleStreams = mediaStreams_subtitleStreams;
			mediaMeta.MediaStreams = mediaStreams;
			getMediaMetaResponse.MediaMeta = mediaMeta;
        
			return getMediaMetaResponse;
        }
    }
}
