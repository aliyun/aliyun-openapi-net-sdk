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
    public class QuerySystemTemplateListResponseUnmarshaller
    {
        public static QuerySystemTemplateListResponse Unmarshall(UnmarshallerContext context)
        {
			QuerySystemTemplateListResponse querySystemTemplateListResponse = new QuerySystemTemplateListResponse();

			querySystemTemplateListResponse.HttpResponse = context.HttpResponse;
			querySystemTemplateListResponse.RequestId = context.StringValue("QuerySystemTemplateList.RequestId");

			List<string> nonExistTids = new List<string>();
			for (int i = 0; i < context.Length("QuerySystemTemplateList.NonExistTids.Length"); i++) {
				nonExistTids.Add(context.StringValue("QuerySystemTemplateList.NonExistTids["+ i +"]"));
			}
			querySystemTemplateListResponse.NonExistTids = nonExistTids;

			List<QuerySystemTemplateListResponse.Template> templateList = new List<QuerySystemTemplateListResponse.Template>();
			for (int i = 0; i < context.Length("QuerySystemTemplateList.TemplateList.Length"); i++) {
				QuerySystemTemplateListResponse.Template template = new QuerySystemTemplateListResponse.Template();
				template.Id = context.StringValue("QuerySystemTemplateList.TemplateList["+ i +"].Id");
				template.Name = context.StringValue("QuerySystemTemplateList.TemplateList["+ i +"].Name");
				template.State = context.StringValue("QuerySystemTemplateList.TemplateList["+ i +"].State");

				QuerySystemTemplateListResponse.Template.Container_ container = new QuerySystemTemplateListResponse.Template.Container_();
				container.Format = context.StringValue("QuerySystemTemplateList.TemplateList["+ i +"].Container.Format");
				template.Container = container;

				QuerySystemTemplateListResponse.Template.Video_ video = new QuerySystemTemplateListResponse.Template.Video_();
				video.Codec = context.StringValue("QuerySystemTemplateList.TemplateList["+ i +"].Video.Codec");
				video.Profile = context.StringValue("QuerySystemTemplateList.TemplateList["+ i +"].Video.Profile");
				video.Bitrate = context.StringValue("QuerySystemTemplateList.TemplateList["+ i +"].Video.Bitrate");
				video.Crf = context.StringValue("QuerySystemTemplateList.TemplateList["+ i +"].Video.Crf");
				video.Width = context.StringValue("QuerySystemTemplateList.TemplateList["+ i +"].Video.Width");
				video.Height = context.StringValue("QuerySystemTemplateList.TemplateList["+ i +"].Video.Height");
				video.Fps = context.StringValue("QuerySystemTemplateList.TemplateList["+ i +"].Video.Fps");
				video.Gop = context.StringValue("QuerySystemTemplateList.TemplateList["+ i +"].Video.Gop");
				video.Preset = context.StringValue("QuerySystemTemplateList.TemplateList["+ i +"].Video.Preset");
				video.ScanMode = context.StringValue("QuerySystemTemplateList.TemplateList["+ i +"].Video.ScanMode");
				video.Bufsize = context.StringValue("QuerySystemTemplateList.TemplateList["+ i +"].Video.Bufsize");
				video.Maxrate = context.StringValue("QuerySystemTemplateList.TemplateList["+ i +"].Video.Maxrate");
				video.PixFmt = context.StringValue("QuerySystemTemplateList.TemplateList["+ i +"].Video.PixFmt");
				video.Degrain = context.StringValue("QuerySystemTemplateList.TemplateList["+ i +"].Video.Degrain");
				video.Qscale = context.StringValue("QuerySystemTemplateList.TemplateList["+ i +"].Video.Qscale");
				video.Remove = context.StringValue("QuerySystemTemplateList.TemplateList["+ i +"].Video.Remove");

				QuerySystemTemplateListResponse.Template.Video_.BitrateBnd_ bitrateBnd = new QuerySystemTemplateListResponse.Template.Video_.BitrateBnd_();
				bitrateBnd.Max = context.StringValue("QuerySystemTemplateList.TemplateList["+ i +"].Video.BitrateBnd.Max");
				bitrateBnd.Min = context.StringValue("QuerySystemTemplateList.TemplateList["+ i +"].Video.BitrateBnd.Min");
				video.BitrateBnd = bitrateBnd;
				template.Video = video;

				QuerySystemTemplateListResponse.Template.Audio_ audio = new QuerySystemTemplateListResponse.Template.Audio_();
				audio.Codec = context.StringValue("QuerySystemTemplateList.TemplateList["+ i +"].Audio.Codec");
				audio.Profile = context.StringValue("QuerySystemTemplateList.TemplateList["+ i +"].Audio.Profile");
				audio.Samplerate = context.StringValue("QuerySystemTemplateList.TemplateList["+ i +"].Audio.Samplerate");
				audio.Bitrate = context.StringValue("QuerySystemTemplateList.TemplateList["+ i +"].Audio.Bitrate");
				audio.Channels = context.StringValue("QuerySystemTemplateList.TemplateList["+ i +"].Audio.Channels");
				audio.Qscale = context.StringValue("QuerySystemTemplateList.TemplateList["+ i +"].Audio.Qscale");
				audio.Remove = context.StringValue("QuerySystemTemplateList.TemplateList["+ i +"].Audio.Remove");
				template.Audio = audio;

				QuerySystemTemplateListResponse.Template.TransConfig_ transConfig = new QuerySystemTemplateListResponse.Template.TransConfig_();
				transConfig.TransMode = context.StringValue("QuerySystemTemplateList.TemplateList["+ i +"].TransConfig.TransMode");
				template.TransConfig = transConfig;

				QuerySystemTemplateListResponse.Template.MuxConfig_ muxConfig = new QuerySystemTemplateListResponse.Template.MuxConfig_();

				QuerySystemTemplateListResponse.Template.MuxConfig_.Segment_ segment = new QuerySystemTemplateListResponse.Template.MuxConfig_.Segment_();
				segment.Duration = context.StringValue("QuerySystemTemplateList.TemplateList["+ i +"].MuxConfig.Segment.Duration");
				muxConfig.Segment = segment;

				QuerySystemTemplateListResponse.Template.MuxConfig_.Gif_ gif = new QuerySystemTemplateListResponse.Template.MuxConfig_.Gif_();
				gif.Loop = context.StringValue("QuerySystemTemplateList.TemplateList["+ i +"].MuxConfig.Gif.Loop");
				gif.FinalDelay = context.StringValue("QuerySystemTemplateList.TemplateList["+ i +"].MuxConfig.Gif.FinalDelay");
				muxConfig.Gif = gif;
				template.MuxConfig = muxConfig;

				templateList.Add(template);
			}
			querySystemTemplateListResponse.TemplateList = templateList;
        
			return querySystemTemplateListResponse;
        }
    }
}