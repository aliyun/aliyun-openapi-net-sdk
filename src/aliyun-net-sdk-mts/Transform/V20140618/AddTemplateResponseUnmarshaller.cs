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

namespace Aliyun.Acs.Mts.Transform.V20140618
{
    public class AddTemplateResponseUnmarshaller
    {
        public static AddTemplateResponse Unmarshall(UnmarshallerContext context)
        {
            AddTemplateResponse addTemplateResponse = new AddTemplateResponse()
            {
                HttpResponse = context.HttpResponse,
                RequestId = context.StringValue("AddTemplate.RequestId")
            };
            AddTemplateResponse.Template_ template = new AddTemplateResponse.Template_()
            {
                Id = context.StringValue("AddTemplate.Template.Id"),
                Name = context.StringValue("AddTemplate.Template.Name"),
                State = context.StringValue("AddTemplate.Template.State")
            };
            AddTemplateResponse.Template_.Container_ container = new AddTemplateResponse.Template_.Container_()
            {
                Format = context.StringValue("AddTemplate.Template.Container.Format")
            };
            template.Container = container;

            AddTemplateResponse.Template_.Video_ video = new AddTemplateResponse.Template_.Video_()
            {
                Codec = context.StringValue("AddTemplate.Template.Video.Codec"),
                Profile = context.StringValue("AddTemplate.Template.Video.Profile"),
                Bitrate = context.StringValue("AddTemplate.Template.Video.Bitrate"),
                Crf = context.StringValue("AddTemplate.Template.Video.Crf"),
                Width = context.StringValue("AddTemplate.Template.Video.Width"),
                Height = context.StringValue("AddTemplate.Template.Video.Height"),
                Fps = context.StringValue("AddTemplate.Template.Video.Fps"),
                Gop = context.StringValue("AddTemplate.Template.Video.Gop"),
                Preset = context.StringValue("AddTemplate.Template.Video.Preset"),
                ScanMode = context.StringValue("AddTemplate.Template.Video.ScanMode"),
                Bufsize = context.StringValue("AddTemplate.Template.Video.Bufsize"),
                Maxrate = context.StringValue("AddTemplate.Template.Video.Maxrate"),
                PixFmt = context.StringValue("AddTemplate.Template.Video.PixFmt"),
                Degrain = context.StringValue("AddTemplate.Template.Video.Degrain"),
                Qscale = context.StringValue("AddTemplate.Template.Video.Qscale"),
                Remove = context.StringValue("AddTemplate.Template.Video.Remove"),
                Crop = context.StringValue("AddTemplate.Template.Video.Crop"),
                Pad = context.StringValue("AddTemplate.Template.Video.Pad"),
                MaxFps = context.StringValue("AddTemplate.Template.Video.MaxFps")
            };
            AddTemplateResponse.Template_.Video_.BitrateBnd_ bitrateBnd = new AddTemplateResponse.Template_.Video_.BitrateBnd_()
            {
                Max = context.StringValue("AddTemplate.Template.Video.BitrateBnd.Max"),
                Min = context.StringValue("AddTemplate.Template.Video.BitrateBnd.Min")
            };
            video.BitrateBnd = bitrateBnd;
			template.Video = video;

            AddTemplateResponse.Template_.Audio_ audio = new AddTemplateResponse.Template_.Audio_()
            {
                Codec = context.StringValue("AddTemplate.Template.Audio.Codec"),
                Profile = context.StringValue("AddTemplate.Template.Audio.Profile"),
                Samplerate = context.StringValue("AddTemplate.Template.Audio.Samplerate"),
                Bitrate = context.StringValue("AddTemplate.Template.Audio.Bitrate"),
                Channels = context.StringValue("AddTemplate.Template.Audio.Channels"),
                Qscale = context.StringValue("AddTemplate.Template.Audio.Qscale"),
                Remove = context.StringValue("AddTemplate.Template.Audio.Remove")
            };
            template.Audio = audio;

            AddTemplateResponse.Template_.TransConfig_ transConfig = new AddTemplateResponse.Template_.TransConfig_()
            {
                TransMode = context.StringValue("AddTemplate.Template.TransConfig.TransMode"),
                IsCheckReso = context.StringValue("AddTemplate.Template.TransConfig.IsCheckReso"),
                IsCheckResoFail = context.StringValue("AddTemplate.Template.TransConfig.IsCheckResoFail"),
                IsCheckVideoBitrate = context.StringValue("AddTemplate.Template.TransConfig.IsCheckVideoBitrate"),
                IsCheckAudioBitrate = context.StringValue("AddTemplate.Template.TransConfig.IsCheckAudioBitrate"),
                AdjDarMethod = context.StringValue("AddTemplate.Template.TransConfig.AdjDarMethod")
            };
            template.TransConfig = transConfig;

			AddTemplateResponse.Template_.MuxConfig_ muxConfig = new AddTemplateResponse.Template_.MuxConfig_();

            AddTemplateResponse.Template_.MuxConfig_.Segment_ segment = new AddTemplateResponse.Template_.MuxConfig_.Segment_()
            {
                Duration = context.StringValue("AddTemplate.Template.MuxConfig.Segment.Duration")
            };
            muxConfig.Segment = segment;

            AddTemplateResponse.Template_.MuxConfig_.Gif_ gif = new AddTemplateResponse.Template_.MuxConfig_.Gif_()
            {
                Loop = context.StringValue("AddTemplate.Template.MuxConfig.Gif.Loop"),
                FinalDelay = context.StringValue("AddTemplate.Template.MuxConfig.Gif.FinalDelay"),
                IsCustomPalette = context.StringValue("AddTemplate.Template.MuxConfig.Gif.IsCustomPalette"),
                DitherMode = context.StringValue("AddTemplate.Template.MuxConfig.Gif.DitherMode")
            };
            muxConfig.Gif = gif;
			template.MuxConfig = muxConfig;
			addTemplateResponse.Template = template;
        
			return addTemplateResponse;
        }
    }
}