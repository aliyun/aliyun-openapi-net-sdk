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
    public class SearchTemplateResponseUnmarshaller
    {
        public static SearchTemplateResponse Unmarshall(UnmarshallerContext context)
        {
            SearchTemplateResponse searchTemplateResponse = new SearchTemplateResponse()
            {
                HttpResponse = context.HttpResponse,
                RequestId = context.StringValue("SearchTemplate.RequestId"),
                TotalCount = context.LongValue("SearchTemplate.TotalCount"),
                PageNumber = context.LongValue("SearchTemplate.PageNumber"),
                PageSize = context.LongValue("SearchTemplate.PageSize")
            };
            List<SearchTemplateResponse.Template> templateList = new List<SearchTemplateResponse.Template>();
			for (int i = 0; i < context.Length("SearchTemplate.TemplateList.Length"); i++) {
                SearchTemplateResponse.Template template = new SearchTemplateResponse.Template()
                {
                    Id = context.StringValue($"SearchTemplate.TemplateList[{i}].Id"),
                    Name = context.StringValue($"SearchTemplate.TemplateList[{i}].Name"),
                    State = context.StringValue($"SearchTemplate.TemplateList[{i}].State")
                };
                SearchTemplateResponse.Template.Container_ container = new SearchTemplateResponse.Template.Container_()
                {
                    Format = context.StringValue($"SearchTemplate.TemplateList[{i}].Container.Format")
                };
                template.Container = container;

                SearchTemplateResponse.Template.Video_ video = new SearchTemplateResponse.Template.Video_()
                {
                    Codec = context.StringValue($"SearchTemplate.TemplateList[{i}].Video.Codec"),
                    Profile = context.StringValue($"SearchTemplate.TemplateList[{i}].Video.Profile"),
                    Bitrate = context.StringValue($"SearchTemplate.TemplateList[{i}].Video.Bitrate"),
                    Crf = context.StringValue($"SearchTemplate.TemplateList[{i}].Video.Crf"),
                    Width = context.StringValue($"SearchTemplate.TemplateList[{i}].Video.Width"),
                    Height = context.StringValue($"SearchTemplate.TemplateList[{i}].Video.Height"),
                    Fps = context.StringValue($"SearchTemplate.TemplateList[{i}].Video.Fps"),
                    Gop = context.StringValue($"SearchTemplate.TemplateList[{i}].Video.Gop"),
                    Preset = context.StringValue($"SearchTemplate.TemplateList[{i}].Video.Preset"),
                    ScanMode = context.StringValue($"SearchTemplate.TemplateList[{i}].Video.ScanMode"),
                    Bufsize = context.StringValue($"SearchTemplate.TemplateList[{i}].Video.Bufsize"),
                    Maxrate = context.StringValue($"SearchTemplate.TemplateList[{i}].Video.Maxrate"),
                    PixFmt = context.StringValue($"SearchTemplate.TemplateList[{i}].Video.PixFmt"),
                    Degrain = context.StringValue($"SearchTemplate.TemplateList[{i}].Video.Degrain"),
                    Qscale = context.StringValue($"SearchTemplate.TemplateList[{i}].Video.Qscale"),
                    Remove = context.StringValue($"SearchTemplate.TemplateList[{i}].Video.Remove"),
                    Crop = context.StringValue($"SearchTemplate.TemplateList[{i}].Video.Crop"),
                    Pad = context.StringValue($"SearchTemplate.TemplateList[{i}].Video.Pad"),
                    MaxFps = context.StringValue($"SearchTemplate.TemplateList[{i}].Video.MaxFps")
                };
                SearchTemplateResponse.Template.Video_.BitrateBnd_ bitrateBnd = new SearchTemplateResponse.Template.Video_.BitrateBnd_()
                {
                    Max = context.StringValue($"SearchTemplate.TemplateList[{i}].Video.BitrateBnd.Max"),
                    Min = context.StringValue($"SearchTemplate.TemplateList[{i}].Video.BitrateBnd.Min")
                };
                video.BitrateBnd = bitrateBnd;
				template.Video = video;

                SearchTemplateResponse.Template.Audio_ audio = new SearchTemplateResponse.Template.Audio_()
                {
                    Codec = context.StringValue($"SearchTemplate.TemplateList[{i}].Audio.Codec"),
                    Profile = context.StringValue($"SearchTemplate.TemplateList[{i}].Audio.Profile"),
                    Samplerate = context.StringValue($"SearchTemplate.TemplateList[{i}].Audio.Samplerate"),
                    Bitrate = context.StringValue($"SearchTemplate.TemplateList[{i}].Audio.Bitrate"),
                    Channels = context.StringValue($"SearchTemplate.TemplateList[{i}].Audio.Channels"),
                    Qscale = context.StringValue($"SearchTemplate.TemplateList[{i}].Audio.Qscale"),
                    Remove = context.StringValue($"SearchTemplate.TemplateList[{i}].Audio.Remove")
                };
                template.Audio = audio;

                SearchTemplateResponse.Template.TransConfig_ transConfig = new SearchTemplateResponse.Template.TransConfig_()
                {
                    TransMode = context.StringValue($"SearchTemplate.TemplateList[{i}].TransConfig.TransMode"),
                    IsCheckReso = context.StringValue($"SearchTemplate.TemplateList[{i}].TransConfig.IsCheckReso"),
                    IsCheckResoFail = context.StringValue($"SearchTemplate.TemplateList[{i}].TransConfig.IsCheckResoFail"),
                    IsCheckVideoBitrate = context.StringValue($"SearchTemplate.TemplateList[{i}].TransConfig.IsCheckVideoBitrate"),
                    IsCheckAudioBitrate = context.StringValue($"SearchTemplate.TemplateList[{i}].TransConfig.IsCheckAudioBitrate"),
                    AdjDarMethod = context.StringValue($"SearchTemplate.TemplateList[{i}].TransConfig.AdjDarMethod")
                };
                template.TransConfig = transConfig;

				SearchTemplateResponse.Template.MuxConfig_ muxConfig = new SearchTemplateResponse.Template.MuxConfig_();

                SearchTemplateResponse.Template.MuxConfig_.Segment_ segment = new SearchTemplateResponse.Template.MuxConfig_.Segment_()
                {
                    Duration = context.StringValue($"SearchTemplate.TemplateList[{i}].MuxConfig.Segment.Duration")
                };
                muxConfig.Segment = segment;

                SearchTemplateResponse.Template.MuxConfig_.Gif_ gif = new SearchTemplateResponse.Template.MuxConfig_.Gif_()
                {
                    Loop = context.StringValue($"SearchTemplate.TemplateList[{i}].MuxConfig.Gif.Loop"),
                    FinalDelay = context.StringValue($"SearchTemplate.TemplateList[{i}].MuxConfig.Gif.FinalDelay"),
                    IsCustomPalette = context.StringValue($"SearchTemplate.TemplateList[{i}].MuxConfig.Gif.IsCustomPalette"),
                    DitherMode = context.StringValue($"SearchTemplate.TemplateList[{i}].MuxConfig.Gif.DitherMode")
                };
                muxConfig.Gif = gif;
				template.MuxConfig = muxConfig;

				templateList.Add(template);
			}
			searchTemplateResponse.TemplateList = templateList;
        
			return searchTemplateResponse;
        }
    }
}