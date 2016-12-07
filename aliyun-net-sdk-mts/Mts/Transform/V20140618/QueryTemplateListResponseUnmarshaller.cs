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
    public class QueryTemplateListResponseUnmarshaller
    {
        public static QueryTemplateListResponse Unmarshall(UnmarshallerContext context)
        {
			QueryTemplateListResponse queryTemplateListResponse = new QueryTemplateListResponse();

			queryTemplateListResponse.HttpResponse = context.HttpResponse;
			queryTemplateListResponse.RequestId = context.StringValue("QueryTemplateList.RequestId");

			List<string> nonExistTids = new List<string>();
			for (int i = 0; i < context.Length("QueryTemplateList.NonExistTids.Length"); i++) {
				nonExistTids.Add(context.StringValue("QueryTemplateList.NonExistTids["+ i +"]"));
			}
			queryTemplateListResponse.NonExistTids = nonExistTids;

			List<QueryTemplateListResponse.Template> templateList = new List<QueryTemplateListResponse.Template>();
			for (int i = 0; i < context.Length("QueryTemplateList.TemplateList.Length"); i++) {
				QueryTemplateListResponse.Template template = new QueryTemplateListResponse.Template();
				template.Id = context.StringValue("QueryTemplateList.TemplateList["+ i +"].Id");
				template.Name = context.StringValue("QueryTemplateList.TemplateList["+ i +"].Name");
				template.State = context.StringValue("QueryTemplateList.TemplateList["+ i +"].State");

				QueryTemplateListResponse.Template.Container_ container = new QueryTemplateListResponse.Template.Container_();
				container.Format = context.StringValue("QueryTemplateList.TemplateList["+ i +"].Container.Format");
				template.Container = container;

				QueryTemplateListResponse.Template.Video_ video = new QueryTemplateListResponse.Template.Video_();
				video.Codec = context.StringValue("QueryTemplateList.TemplateList["+ i +"].Video.Codec");
				video.Profile = context.StringValue("QueryTemplateList.TemplateList["+ i +"].Video.Profile");
				video.Bitrate = context.StringValue("QueryTemplateList.TemplateList["+ i +"].Video.Bitrate");
				video.Crf = context.StringValue("QueryTemplateList.TemplateList["+ i +"].Video.Crf");
				video.Width = context.StringValue("QueryTemplateList.TemplateList["+ i +"].Video.Width");
				video.Height = context.StringValue("QueryTemplateList.TemplateList["+ i +"].Video.Height");
				video.Fps = context.StringValue("QueryTemplateList.TemplateList["+ i +"].Video.Fps");
				video.Gop = context.StringValue("QueryTemplateList.TemplateList["+ i +"].Video.Gop");
				video.Preset = context.StringValue("QueryTemplateList.TemplateList["+ i +"].Video.Preset");
				video.ScanMode = context.StringValue("QueryTemplateList.TemplateList["+ i +"].Video.ScanMode");
				video.Bufsize = context.StringValue("QueryTemplateList.TemplateList["+ i +"].Video.Bufsize");
				video.Maxrate = context.StringValue("QueryTemplateList.TemplateList["+ i +"].Video.Maxrate");
				video.PixFmt = context.StringValue("QueryTemplateList.TemplateList["+ i +"].Video.PixFmt");
				video.Degrain = context.StringValue("QueryTemplateList.TemplateList["+ i +"].Video.Degrain");
				video.Qscale = context.StringValue("QueryTemplateList.TemplateList["+ i +"].Video.Qscale");
				video.Remove = context.StringValue("QueryTemplateList.TemplateList["+ i +"].Video.Remove");
				video.Crop = context.StringValue("QueryTemplateList.TemplateList["+ i +"].Video.Crop");
				video.Pad = context.StringValue("QueryTemplateList.TemplateList["+ i +"].Video.Pad");
				video.MaxFps = context.StringValue("QueryTemplateList.TemplateList["+ i +"].Video.MaxFps");

				QueryTemplateListResponse.Template.Video_.BitrateBnd_ bitrateBnd = new QueryTemplateListResponse.Template.Video_.BitrateBnd_();
				bitrateBnd.Max = context.StringValue("QueryTemplateList.TemplateList["+ i +"].Video.BitrateBnd.Max");
				bitrateBnd.Min = context.StringValue("QueryTemplateList.TemplateList["+ i +"].Video.BitrateBnd.Min");
				video.BitrateBnd = bitrateBnd;
				template.Video = video;

				QueryTemplateListResponse.Template.Audio_ audio = new QueryTemplateListResponse.Template.Audio_();
				audio.Codec = context.StringValue("QueryTemplateList.TemplateList["+ i +"].Audio.Codec");
				audio.Profile = context.StringValue("QueryTemplateList.TemplateList["+ i +"].Audio.Profile");
				audio.Samplerate = context.StringValue("QueryTemplateList.TemplateList["+ i +"].Audio.Samplerate");
				audio.Bitrate = context.StringValue("QueryTemplateList.TemplateList["+ i +"].Audio.Bitrate");
				audio.Channels = context.StringValue("QueryTemplateList.TemplateList["+ i +"].Audio.Channels");
				audio.Qscale = context.StringValue("QueryTemplateList.TemplateList["+ i +"].Audio.Qscale");
				audio.Remove = context.StringValue("QueryTemplateList.TemplateList["+ i +"].Audio.Remove");
				template.Audio = audio;

				QueryTemplateListResponse.Template.TransConfig_ transConfig = new QueryTemplateListResponse.Template.TransConfig_();
				transConfig.TransMode = context.StringValue("QueryTemplateList.TemplateList["+ i +"].TransConfig.TransMode");
				transConfig.IsCheckReso = context.StringValue("QueryTemplateList.TemplateList["+ i +"].TransConfig.IsCheckReso");
				transConfig.IsCheckResoFail = context.StringValue("QueryTemplateList.TemplateList["+ i +"].TransConfig.IsCheckResoFail");
				transConfig.IsCheckVideoBitrate = context.StringValue("QueryTemplateList.TemplateList["+ i +"].TransConfig.IsCheckVideoBitrate");
				transConfig.IsCheckAudioBitrate = context.StringValue("QueryTemplateList.TemplateList["+ i +"].TransConfig.IsCheckAudioBitrate");
				transConfig.AdjDarMethod = context.StringValue("QueryTemplateList.TemplateList["+ i +"].TransConfig.AdjDarMethod");
				template.TransConfig = transConfig;

				QueryTemplateListResponse.Template.MuxConfig_ muxConfig = new QueryTemplateListResponse.Template.MuxConfig_();

				QueryTemplateListResponse.Template.MuxConfig_.Segment_ segment = new QueryTemplateListResponse.Template.MuxConfig_.Segment_();
				segment.Duration = context.StringValue("QueryTemplateList.TemplateList["+ i +"].MuxConfig.Segment.Duration");
				muxConfig.Segment = segment;

				QueryTemplateListResponse.Template.MuxConfig_.Gif_ gif = new QueryTemplateListResponse.Template.MuxConfig_.Gif_();
				gif.Loop = context.StringValue("QueryTemplateList.TemplateList["+ i +"].MuxConfig.Gif.Loop");
				gif.FinalDelay = context.StringValue("QueryTemplateList.TemplateList["+ i +"].MuxConfig.Gif.FinalDelay");
				gif.IsCustomPalette = context.StringValue("QueryTemplateList.TemplateList["+ i +"].MuxConfig.Gif.IsCustomPalette");
				gif.DitherMode = context.StringValue("QueryTemplateList.TemplateList["+ i +"].MuxConfig.Gif.DitherMode");
				muxConfig.Gif = gif;
				template.MuxConfig = muxConfig;

				templateList.Add(template);
			}
			queryTemplateListResponse.TemplateList = templateList;
        
			return queryTemplateListResponse;
        }
    }
}