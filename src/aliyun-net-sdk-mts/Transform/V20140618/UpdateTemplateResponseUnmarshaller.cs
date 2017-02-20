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
    public class UpdateTemplateResponseUnmarshaller
    {
        public static UpdateTemplateResponse Unmarshall(UnmarshallerContext context)
        {
            UpdateTemplateResponse updateTemplateResponse = new UpdateTemplateResponse()
            {
                HttpResponse = context.HttpResponse,
                RequestId = context.StringValue("UpdateTemplate.RequestId")
            };
            UpdateTemplateResponse.Template_ template = new UpdateTemplateResponse.Template_()
            {
                Id = context.StringValue("UpdateTemplate.Template.Id"),
                Name = context.StringValue("UpdateTemplate.Template.Name"),
                State = context.StringValue("UpdateTemplate.Template.State")
            };
            UpdateTemplateResponse.Template_.Container_ container = new UpdateTemplateResponse.Template_.Container_()
            {
                Format = context.StringValue("UpdateTemplate.Template.Container.Format")
            };
            template.Container = container;

            UpdateTemplateResponse.Template_.Video_ video = new UpdateTemplateResponse.Template_.Video_()
            {
                Codec = context.StringValue("UpdateTemplate.Template.Video.Codec"),
                Profile = context.StringValue("UpdateTemplate.Template.Video.Profile"),
                Bitrate = context.StringValue("UpdateTemplate.Template.Video.Bitrate"),
                Crf = context.StringValue("UpdateTemplate.Template.Video.Crf"),
                Width = context.StringValue("UpdateTemplate.Template.Video.Width"),
                Height = context.StringValue("UpdateTemplate.Template.Video.Height"),
                Fps = context.StringValue("UpdateTemplate.Template.Video.Fps"),
                Gop = context.StringValue("UpdateTemplate.Template.Video.Gop"),
                Preset = context.StringValue("UpdateTemplate.Template.Video.Preset"),
                ScanMode = context.StringValue("UpdateTemplate.Template.Video.ScanMode"),
                Bufsize = context.StringValue("UpdateTemplate.Template.Video.Bufsize"),
                Maxrate = context.StringValue("UpdateTemplate.Template.Video.Maxrate"),
                PixFmt = context.StringValue("UpdateTemplate.Template.Video.PixFmt"),
                Degrain = context.StringValue("UpdateTemplate.Template.Video.Degrain"),
                Qscale = context.StringValue("UpdateTemplate.Template.Video.Qscale"),
                Remove = context.StringValue("UpdateTemplate.Template.Video.Remove"),
                Crop = context.StringValue("UpdateTemplate.Template.Video.Crop"),
                Pad = context.StringValue("UpdateTemplate.Template.Video.Pad"),
                MaxFps = context.StringValue("UpdateTemplate.Template.Video.MaxFps")
            };
            UpdateTemplateResponse.Template_.Video_.BitrateBnd_ bitrateBnd = new UpdateTemplateResponse.Template_.Video_.BitrateBnd_()
            {
                Max = context.StringValue("UpdateTemplate.Template.Video.BitrateBnd.Max"),
                Min = context.StringValue("UpdateTemplate.Template.Video.BitrateBnd.Min")
            };
            video.BitrateBnd = bitrateBnd;
			template.Video = video;

            UpdateTemplateResponse.Template_.Audio_ audio = new UpdateTemplateResponse.Template_.Audio_()
            {
                Codec = context.StringValue("UpdateTemplate.Template.Audio.Codec"),
                Profile = context.StringValue("UpdateTemplate.Template.Audio.Profile"),
                Samplerate = context.StringValue("UpdateTemplate.Template.Audio.Samplerate"),
                Bitrate = context.StringValue("UpdateTemplate.Template.Audio.Bitrate"),
                Channels = context.StringValue("UpdateTemplate.Template.Audio.Channels"),
                Qscale = context.StringValue("UpdateTemplate.Template.Audio.Qscale"),
                Remove = context.StringValue("UpdateTemplate.Template.Audio.Remove")
            };
            template.Audio = audio;

            UpdateTemplateResponse.Template_.TransConfig_ transConfig = new UpdateTemplateResponse.Template_.TransConfig_()
            {
                TransMode = context.StringValue("UpdateTemplate.Template.TransConfig.TransMode"),
                IsCheckReso = context.StringValue("UpdateTemplate.Template.TransConfig.IsCheckReso"),
                IsCheckResoFail = context.StringValue("UpdateTemplate.Template.TransConfig.IsCheckResoFail"),
                IsCheckVideoBitrate = context.StringValue("UpdateTemplate.Template.TransConfig.IsCheckVideoBitrate"),
                IsCheckAudioBitrate = context.StringValue("UpdateTemplate.Template.TransConfig.IsCheckAudioBitrate"),
                AdjDarMethod = context.StringValue("UpdateTemplate.Template.TransConfig.AdjDarMethod")
            };
            template.TransConfig = transConfig;

			UpdateTemplateResponse.Template_.MuxConfig_ muxConfig = new UpdateTemplateResponse.Template_.MuxConfig_();

            UpdateTemplateResponse.Template_.MuxConfig_.Segment_ segment = new UpdateTemplateResponse.Template_.MuxConfig_.Segment_()
            {
                Duration = context.StringValue("UpdateTemplate.Template.MuxConfig.Segment.Duration")
            };
            muxConfig.Segment = segment;

            UpdateTemplateResponse.Template_.MuxConfig_.Gif_ gif = new UpdateTemplateResponse.Template_.MuxConfig_.Gif_()
            {
                Loop = context.StringValue("UpdateTemplate.Template.MuxConfig.Gif.Loop"),
                FinalDelay = context.StringValue("UpdateTemplate.Template.MuxConfig.Gif.FinalDelay"),
                IsCustomPalette = context.StringValue("UpdateTemplate.Template.MuxConfig.Gif.IsCustomPalette"),
                DitherMode = context.StringValue("UpdateTemplate.Template.MuxConfig.Gif.DitherMode")
            };
            muxConfig.Gif = gif;
			template.MuxConfig = muxConfig;
			updateTemplateResponse.Template = template;
        
			return updateTemplateResponse;
        }
    }
}