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
    public class SearchTemplateResponseUnmarshaller
    {
        public static SearchTemplateResponse Unmarshall(UnmarshallerContext context)
        {
			SearchTemplateResponse searchTemplateResponse = new SearchTemplateResponse();

			searchTemplateResponse.HttpResponse = context.HttpResponse;
			searchTemplateResponse.RequestId = context.StringValue("SearchTemplate.RequestId");
			searchTemplateResponse.TotalCount = context.LongValue("SearchTemplate.TotalCount");
			searchTemplateResponse.PageNumber = context.LongValue("SearchTemplate.PageNumber");
			searchTemplateResponse.PageSize = context.LongValue("SearchTemplate.PageSize");

			List<SearchTemplateResponse.SearchTemplate_Template> searchTemplateResponse_templateList = new List<SearchTemplateResponse.SearchTemplate_Template>();
			for (int i = 0; i < context.Length("SearchTemplate.TemplateList.Length"); i++) {
				SearchTemplateResponse.SearchTemplate_Template template = new SearchTemplateResponse.SearchTemplate_Template();
				template.Id = context.StringValue("SearchTemplate.TemplateList["+ i +"].Id");
				template.Name = context.StringValue("SearchTemplate.TemplateList["+ i +"].Name");
				template.State = context.StringValue("SearchTemplate.TemplateList["+ i +"].State");

				SearchTemplateResponse.SearchTemplate_Template.SearchTemplate_Container container = new SearchTemplateResponse.SearchTemplate_Template.SearchTemplate_Container();
				container.Format = context.StringValue("SearchTemplate.TemplateList["+ i +"].Container.Format");
				template.Container = container;

				SearchTemplateResponse.SearchTemplate_Template.SearchTemplate_Video video = new SearchTemplateResponse.SearchTemplate_Template.SearchTemplate_Video();
				video.Codec = context.StringValue("SearchTemplate.TemplateList["+ i +"].Video.Codec");
				video.Profile = context.StringValue("SearchTemplate.TemplateList["+ i +"].Video.Profile");
				video.Bitrate = context.StringValue("SearchTemplate.TemplateList["+ i +"].Video.Bitrate");
				video.Crf = context.StringValue("SearchTemplate.TemplateList["+ i +"].Video.Crf");
				video.Width = context.StringValue("SearchTemplate.TemplateList["+ i +"].Video.Width");
				video.Height = context.StringValue("SearchTemplate.TemplateList["+ i +"].Video.Height");
				video.Fps = context.StringValue("SearchTemplate.TemplateList["+ i +"].Video.Fps");
				video.Gop = context.StringValue("SearchTemplate.TemplateList["+ i +"].Video.Gop");
				video.Preset = context.StringValue("SearchTemplate.TemplateList["+ i +"].Video.Preset");
				video.ScanMode = context.StringValue("SearchTemplate.TemplateList["+ i +"].Video.ScanMode");
				video.Bufsize = context.StringValue("SearchTemplate.TemplateList["+ i +"].Video.Bufsize");
				video.Maxrate = context.StringValue("SearchTemplate.TemplateList["+ i +"].Video.Maxrate");
				video.PixFmt = context.StringValue("SearchTemplate.TemplateList["+ i +"].Video.PixFmt");
				video.Degrain = context.StringValue("SearchTemplate.TemplateList["+ i +"].Video.Degrain");
				video.Qscale = context.StringValue("SearchTemplate.TemplateList["+ i +"].Video.Qscale");
				video._Remove = context.StringValue("SearchTemplate.TemplateList["+ i +"].Video.Remove");
				video.Crop = context.StringValue("SearchTemplate.TemplateList["+ i +"].Video.Crop");
				video.Pad = context.StringValue("SearchTemplate.TemplateList["+ i +"].Video.Pad");
				video.MaxFps = context.StringValue("SearchTemplate.TemplateList["+ i +"].Video.MaxFps");

				SearchTemplateResponse.SearchTemplate_Template.SearchTemplate_Video.SearchTemplate_BitrateBnd bitrateBnd = new SearchTemplateResponse.SearchTemplate_Template.SearchTemplate_Video.SearchTemplate_BitrateBnd();
				bitrateBnd.Max = context.StringValue("SearchTemplate.TemplateList["+ i +"].Video.BitrateBnd.Max");
				bitrateBnd.Min = context.StringValue("SearchTemplate.TemplateList["+ i +"].Video.BitrateBnd.Min");
				video.BitrateBnd = bitrateBnd;
				template.Video = video;

				SearchTemplateResponse.SearchTemplate_Template.SearchTemplate_Audio audio = new SearchTemplateResponse.SearchTemplate_Template.SearchTemplate_Audio();
				audio.Codec = context.StringValue("SearchTemplate.TemplateList["+ i +"].Audio.Codec");
				audio.Profile = context.StringValue("SearchTemplate.TemplateList["+ i +"].Audio.Profile");
				audio.Samplerate = context.StringValue("SearchTemplate.TemplateList["+ i +"].Audio.Samplerate");
				audio.Bitrate = context.StringValue("SearchTemplate.TemplateList["+ i +"].Audio.Bitrate");
				audio.Channels = context.StringValue("SearchTemplate.TemplateList["+ i +"].Audio.Channels");
				audio.Qscale = context.StringValue("SearchTemplate.TemplateList["+ i +"].Audio.Qscale");
				audio._Remove = context.StringValue("SearchTemplate.TemplateList["+ i +"].Audio.Remove");
				template.Audio = audio;

				SearchTemplateResponse.SearchTemplate_Template.SearchTemplate_TransConfig transConfig = new SearchTemplateResponse.SearchTemplate_Template.SearchTemplate_TransConfig();
				transConfig.TransMode = context.StringValue("SearchTemplate.TemplateList["+ i +"].TransConfig.TransMode");
				transConfig.IsCheckReso = context.StringValue("SearchTemplate.TemplateList["+ i +"].TransConfig.IsCheckReso");
				transConfig.IsCheckResoFail = context.StringValue("SearchTemplate.TemplateList["+ i +"].TransConfig.IsCheckResoFail");
				transConfig.IsCheckVideoBitrate = context.StringValue("SearchTemplate.TemplateList["+ i +"].TransConfig.IsCheckVideoBitrate");
				transConfig.IsCheckAudioBitrate = context.StringValue("SearchTemplate.TemplateList["+ i +"].TransConfig.IsCheckAudioBitrate");
				transConfig.AdjDarMethod = context.StringValue("SearchTemplate.TemplateList["+ i +"].TransConfig.AdjDarMethod");
				transConfig.IsCheckVideoBitrateFail = context.StringValue("SearchTemplate.TemplateList["+ i +"].TransConfig.IsCheckVideoBitrateFail");
				transConfig.IsCheckAudioBitrateFail = context.StringValue("SearchTemplate.TemplateList["+ i +"].TransConfig.IsCheckAudioBitrateFail");
				template.TransConfig = transConfig;

				SearchTemplateResponse.SearchTemplate_Template.SearchTemplate_MuxConfig muxConfig = new SearchTemplateResponse.SearchTemplate_Template.SearchTemplate_MuxConfig();

				SearchTemplateResponse.SearchTemplate_Template.SearchTemplate_MuxConfig.SearchTemplate_Segment segment = new SearchTemplateResponse.SearchTemplate_Template.SearchTemplate_MuxConfig.SearchTemplate_Segment();
				segment.Duration = context.StringValue("SearchTemplate.TemplateList["+ i +"].MuxConfig.Segment.Duration");
				muxConfig.Segment = segment;

				SearchTemplateResponse.SearchTemplate_Template.SearchTemplate_MuxConfig.SearchTemplate_Gif gif = new SearchTemplateResponse.SearchTemplate_Template.SearchTemplate_MuxConfig.SearchTemplate_Gif();
				gif.Loop = context.StringValue("SearchTemplate.TemplateList["+ i +"].MuxConfig.Gif.Loop");
				gif.FinalDelay = context.StringValue("SearchTemplate.TemplateList["+ i +"].MuxConfig.Gif.FinalDelay");
				gif.IsCustomPalette = context.StringValue("SearchTemplate.TemplateList["+ i +"].MuxConfig.Gif.IsCustomPalette");
				gif.DitherMode = context.StringValue("SearchTemplate.TemplateList["+ i +"].MuxConfig.Gif.DitherMode");
				muxConfig.Gif = gif;
				template.MuxConfig = muxConfig;

				searchTemplateResponse_templateList.Add(template);
			}
			searchTemplateResponse.TemplateList = searchTemplateResponse_templateList;
        
			return searchTemplateResponse;
        }
    }
}