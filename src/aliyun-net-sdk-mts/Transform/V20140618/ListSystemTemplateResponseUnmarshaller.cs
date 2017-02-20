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
using System.Collections.Generic;

namespace Aliyun.Acs.Mts.Transform.V20140618
{
    public class ListSystemTemplateResponseUnmarshaller
    {
        public static ListSystemTemplateResponse Unmarshall(UnmarshallerContext context)
        {
            ListSystemTemplateResponse listSystemTemplateResponse = new ListSystemTemplateResponse()
            {
                HttpResponse = context.HttpResponse,
                RequestId = context.StringValue("ListSystemTemplate.RequestId")
            };
            List<string> nonExistTids = new List<string>();
			for (int i = 0; i < context.Length("ListSystemTemplate.NonExistTids.Length"); i++) {
				nonExistTids.Add(context.StringValue($"ListSystemTemplate.NonExistTids[{i}]"));
			}
			listSystemTemplateResponse.NonExistTids = nonExistTids;

			List<ListSystemTemplateResponse.Template> templateList = new List<ListSystemTemplateResponse.Template>();
			for (int i = 0; i < context.Length("ListSystemTemplate.TemplateList.Length"); i++) {
                ListSystemTemplateResponse.Template template = new ListSystemTemplateResponse.Template()
                {
                    Id = context.StringValue($"ListSystemTemplate.TemplateList[{i}].Id"),
                    Name = context.StringValue($"ListSystemTemplate.TemplateList[{i}].Name"),
                    State = context.StringValue($"ListSystemTemplate.TemplateList[{i}].State")
                };
                ListSystemTemplateResponse.Template.Container_ container = new ListSystemTemplateResponse.Template.Container_()
                {
                    Format = context.StringValue($"ListSystemTemplate.TemplateList[{i}].Container.Format")
                };
                template.Container = container;

                ListSystemTemplateResponse.Template.Video_ video = new ListSystemTemplateResponse.Template.Video_()
                {
                    Codec = context.StringValue($"ListSystemTemplate.TemplateList[{i}].Video.Codec"),
                    Profile = context.StringValue($"ListSystemTemplate.TemplateList[{i}].Video.Profile"),
                    Bitrate = context.StringValue($"ListSystemTemplate.TemplateList[{i}].Video.Bitrate"),
                    Crf = context.StringValue($"ListSystemTemplate.TemplateList[{i}].Video.Crf"),
                    Width = context.StringValue($"ListSystemTemplate.TemplateList[{i}].Video.Width"),
                    Height = context.StringValue($"ListSystemTemplate.TemplateList[{i}].Video.Height"),
                    Fps = context.StringValue($"ListSystemTemplate.TemplateList[{i}].Video.Fps"),
                    Gop = context.StringValue($"ListSystemTemplate.TemplateList[{i}].Video.Gop"),
                    Preset = context.StringValue($"ListSystemTemplate.TemplateList[{i}].Video.Preset"),
                    ScanMode = context.StringValue($"ListSystemTemplate.TemplateList[{i}].Video.ScanMode"),
                    Bufsize = context.StringValue($"ListSystemTemplate.TemplateList[{i}].Video.Bufsize"),
                    Maxrate = context.StringValue($"ListSystemTemplate.TemplateList[{i}].Video.Maxrate"),
                    PixFmt = context.StringValue($"ListSystemTemplate.TemplateList[{i}].Video.PixFmt"),
                    Degrain = context.StringValue($"ListSystemTemplate.TemplateList[{i}].Video.Degrain"),
                    Qscale = context.StringValue($"ListSystemTemplate.TemplateList[{i}].Video.Qscale"),
                    Remove = context.StringValue($"ListSystemTemplate.TemplateList[{i}].Video.Remove")
                };
                ListSystemTemplateResponse.Template.Video_.BitrateBnd_ bitrateBnd = new ListSystemTemplateResponse.Template.Video_.BitrateBnd_()
                {
                    Max = context.StringValue($"ListSystemTemplate.TemplateList[{i}].Video.BitrateBnd.Max"),
                    Min = context.StringValue($"ListSystemTemplate.TemplateList[{i}].Video.BitrateBnd.Min")
                };
                video.BitrateBnd = bitrateBnd;
				template.Video = video;

                ListSystemTemplateResponse.Template.Audio_ audio = new ListSystemTemplateResponse.Template.Audio_()
                {
                    Codec = context.StringValue($"ListSystemTemplate.TemplateList[{i}].Audio.Codec"),
                    Profile = context.StringValue($"ListSystemTemplate.TemplateList[{i}].Audio.Profile"),
                    Samplerate = context.StringValue($"ListSystemTemplate.TemplateList[{i}].Audio.Samplerate"),
                    Bitrate = context.StringValue($"ListSystemTemplate.TemplateList[{i}].Audio.Bitrate"),
                    Channels = context.StringValue($"ListSystemTemplate.TemplateList[{i}].Audio.Channels"),
                    Qscale = context.StringValue($"ListSystemTemplate.TemplateList[{i}].Audio.Qscale"),
                    Remove = context.StringValue($"ListSystemTemplate.TemplateList[{i}].Audio.Remove")
                };
                template.Audio = audio;

                ListSystemTemplateResponse.Template.TransConfig_ transConfig = new ListSystemTemplateResponse.Template.TransConfig_()
                {
                    TransMode = context.StringValue($"ListSystemTemplate.TemplateList[{i}].TransConfig.TransMode")
                };
                template.TransConfig = transConfig;

				ListSystemTemplateResponse.Template.MuxConfig_ muxConfig = new ListSystemTemplateResponse.Template.MuxConfig_();

                ListSystemTemplateResponse.Template.MuxConfig_.Segment_ segment = new ListSystemTemplateResponse.Template.MuxConfig_.Segment_()
                {
                    Duration = context.StringValue($"ListSystemTemplate.TemplateList[{i}].MuxConfig.Segment.Duration")
                };
                muxConfig.Segment = segment;

                ListSystemTemplateResponse.Template.MuxConfig_.Gif_ gif = new ListSystemTemplateResponse.Template.MuxConfig_.Gif_()
                {
                    Loop = context.StringValue($"ListSystemTemplate.TemplateList[{i}].MuxConfig.Gif.Loop"),
                    FinalDelay = context.StringValue($"ListSystemTemplate.TemplateList[{i}].MuxConfig.Gif.FinalDelay")
                };
                muxConfig.Gif = gif;
				template.MuxConfig = muxConfig;

				templateList.Add(template);
			}
			listSystemTemplateResponse.TemplateList = templateList;
        
			return listSystemTemplateResponse;
        }
    }
}