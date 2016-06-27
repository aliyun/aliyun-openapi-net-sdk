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
    public class ListSystemTemplateResponseUnmarshaller
    {
        public static ListSystemTemplateResponse Unmarshall(UnmarshallerContext context)
        {
			ListSystemTemplateResponse listSystemTemplateResponse = new ListSystemTemplateResponse();

			listSystemTemplateResponse.HttpResponse = context.HttpResponse;
			listSystemTemplateResponse.RequestId = context.StringValue("ListSystemTemplate.RequestId");

			List<string> nonExistTids = new List<string>();
			for (int i = 0; i < context.Length("ListSystemTemplate.NonExistTids.Length"); i++) {
				nonExistTids.Add(context.StringValue("ListSystemTemplate.NonExistTids["+ i +"]"));
			}
			listSystemTemplateResponse.NonExistTids = nonExistTids;

			List<ListSystemTemplateResponse.Template> templateList = new List<ListSystemTemplateResponse.Template>();
			for (int i = 0; i < context.Length("ListSystemTemplate.TemplateList.Length"); i++) {
				ListSystemTemplateResponse.Template template = new ListSystemTemplateResponse.Template();
				template.Id = context.StringValue("ListSystemTemplate.TemplateList["+ i +"].Id");
				template.Name = context.StringValue("ListSystemTemplate.TemplateList["+ i +"].Name");
				template.State = context.StringValue("ListSystemTemplate.TemplateList["+ i +"].State");

				ListSystemTemplateResponse.Template.Container_ container = new ListSystemTemplateResponse.Template.Container_();
				container.Format = context.StringValue("ListSystemTemplate.TemplateList["+ i +"].Container.Format");
				template.Container = container;

				ListSystemTemplateResponse.Template.Video_ video = new ListSystemTemplateResponse.Template.Video_();
				video.Codec = context.StringValue("ListSystemTemplate.TemplateList["+ i +"].Video.Codec");
				video.Profile = context.StringValue("ListSystemTemplate.TemplateList["+ i +"].Video.Profile");
				video.Bitrate = context.StringValue("ListSystemTemplate.TemplateList["+ i +"].Video.Bitrate");
				video.Crf = context.StringValue("ListSystemTemplate.TemplateList["+ i +"].Video.Crf");
				video.Width = context.StringValue("ListSystemTemplate.TemplateList["+ i +"].Video.Width");
				video.Height = context.StringValue("ListSystemTemplate.TemplateList["+ i +"].Video.Height");
				video.Fps = context.StringValue("ListSystemTemplate.TemplateList["+ i +"].Video.Fps");
				video.Gop = context.StringValue("ListSystemTemplate.TemplateList["+ i +"].Video.Gop");
				video.Preset = context.StringValue("ListSystemTemplate.TemplateList["+ i +"].Video.Preset");
				video.ScanMode = context.StringValue("ListSystemTemplate.TemplateList["+ i +"].Video.ScanMode");
				video.Bufsize = context.StringValue("ListSystemTemplate.TemplateList["+ i +"].Video.Bufsize");
				video.Maxrate = context.StringValue("ListSystemTemplate.TemplateList["+ i +"].Video.Maxrate");
				video.PixFmt = context.StringValue("ListSystemTemplate.TemplateList["+ i +"].Video.PixFmt");
				video.Degrain = context.StringValue("ListSystemTemplate.TemplateList["+ i +"].Video.Degrain");
				video.Qscale = context.StringValue("ListSystemTemplate.TemplateList["+ i +"].Video.Qscale");
				video.Remove = context.StringValue("ListSystemTemplate.TemplateList["+ i +"].Video.Remove");

				ListSystemTemplateResponse.Template.Video_.BitrateBnd_ bitrateBnd = new ListSystemTemplateResponse.Template.Video_.BitrateBnd_();
				bitrateBnd.Max = context.StringValue("ListSystemTemplate.TemplateList["+ i +"].Video.BitrateBnd.Max");
				bitrateBnd.Min = context.StringValue("ListSystemTemplate.TemplateList["+ i +"].Video.BitrateBnd.Min");
				video.BitrateBnd = bitrateBnd;
				template.Video = video;

				ListSystemTemplateResponse.Template.Audio_ audio = new ListSystemTemplateResponse.Template.Audio_();
				audio.Codec = context.StringValue("ListSystemTemplate.TemplateList["+ i +"].Audio.Codec");
				audio.Profile = context.StringValue("ListSystemTemplate.TemplateList["+ i +"].Audio.Profile");
				audio.Samplerate = context.StringValue("ListSystemTemplate.TemplateList["+ i +"].Audio.Samplerate");
				audio.Bitrate = context.StringValue("ListSystemTemplate.TemplateList["+ i +"].Audio.Bitrate");
				audio.Channels = context.StringValue("ListSystemTemplate.TemplateList["+ i +"].Audio.Channels");
				audio.Qscale = context.StringValue("ListSystemTemplate.TemplateList["+ i +"].Audio.Qscale");
				audio.Remove = context.StringValue("ListSystemTemplate.TemplateList["+ i +"].Audio.Remove");
				template.Audio = audio;

				ListSystemTemplateResponse.Template.TransConfig_ transConfig = new ListSystemTemplateResponse.Template.TransConfig_();
				transConfig.TransMode = context.StringValue("ListSystemTemplate.TemplateList["+ i +"].TransConfig.TransMode");
				template.TransConfig = transConfig;

				ListSystemTemplateResponse.Template.MuxConfig_ muxConfig = new ListSystemTemplateResponse.Template.MuxConfig_();

				ListSystemTemplateResponse.Template.MuxConfig_.Segment_ segment = new ListSystemTemplateResponse.Template.MuxConfig_.Segment_();
				segment.Duration = context.StringValue("ListSystemTemplate.TemplateList["+ i +"].MuxConfig.Segment.Duration");
				muxConfig.Segment = segment;

				ListSystemTemplateResponse.Template.MuxConfig_.Gif_ gif = new ListSystemTemplateResponse.Template.MuxConfig_.Gif_();
				gif.Loop = context.StringValue("ListSystemTemplate.TemplateList["+ i +"].MuxConfig.Gif.Loop");
				gif.FinalDelay = context.StringValue("ListSystemTemplate.TemplateList["+ i +"].MuxConfig.Gif.FinalDelay");
				muxConfig.Gif = gif;
				template.MuxConfig = muxConfig;

				templateList.Add(template);
			}
			listSystemTemplateResponse.TemplateList = templateList;
        
			return listSystemTemplateResponse;
        }
    }
}