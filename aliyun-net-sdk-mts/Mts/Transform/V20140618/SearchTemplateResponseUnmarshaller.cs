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
using Aliyun.Acs.Mts.Model.V20140618;

namespace Aliyun.Acs.Mts.Transform.V20140618
{
    public class SearchTemplateResponseUnmarshaller
    {
        public static SearchTemplateResponse Unmarshall(UnmarshallerContext _ctx)
        {
			SearchTemplateResponse searchTemplateResponse = new SearchTemplateResponse();

			searchTemplateResponse.HttpResponse = _ctx.HttpResponse;
			searchTemplateResponse.TotalCount = _ctx.LongValue("SearchTemplate.TotalCount");
			searchTemplateResponse.PageSize = _ctx.LongValue("SearchTemplate.PageSize");
			searchTemplateResponse.RequestId = _ctx.StringValue("SearchTemplate.RequestId");
			searchTemplateResponse.PageNumber = _ctx.LongValue("SearchTemplate.PageNumber");

			List<SearchTemplateResponse.SearchTemplate_Template> searchTemplateResponse_templateList = new List<SearchTemplateResponse.SearchTemplate_Template>();
			for (int i = 0; i < _ctx.Length("SearchTemplate.TemplateList.Length"); i++) {
				SearchTemplateResponse.SearchTemplate_Template template = new SearchTemplateResponse.SearchTemplate_Template();
				template.State = _ctx.StringValue("SearchTemplate.TemplateList["+ i +"].State");
				template.Name = _ctx.StringValue("SearchTemplate.TemplateList["+ i +"].Name");
				template.Id = _ctx.StringValue("SearchTemplate.TemplateList["+ i +"].Id");
				template.CreationTime = _ctx.StringValue("SearchTemplate.TemplateList["+ i +"].CreationTime");

				SearchTemplateResponse.SearchTemplate_Template.SearchTemplate_Video video = new SearchTemplateResponse.SearchTemplate_Template.SearchTemplate_Video();
				video.Bufsize = _ctx.StringValue("SearchTemplate.TemplateList["+ i +"].Video.Bufsize");
				video.LongShortMode = _ctx.StringValue("SearchTemplate.TemplateList["+ i +"].Video.LongShortMode");
				video.Degrain = _ctx.StringValue("SearchTemplate.TemplateList["+ i +"].Video.Degrain");
				video.PixFmt = _ctx.StringValue("SearchTemplate.TemplateList["+ i +"].Video.PixFmt");
				video.Pad = _ctx.StringValue("SearchTemplate.TemplateList["+ i +"].Video.Pad");
				video.Codec = _ctx.StringValue("SearchTemplate.TemplateList["+ i +"].Video.Codec");
				video.Height = _ctx.StringValue("SearchTemplate.TemplateList["+ i +"].Video.Height");
				video.Qscale = _ctx.StringValue("SearchTemplate.TemplateList["+ i +"].Video.Qscale");
				video.Crop = _ctx.StringValue("SearchTemplate.TemplateList["+ i +"].Video.Crop");
				video.Bitrate = _ctx.StringValue("SearchTemplate.TemplateList["+ i +"].Video.Bitrate");
				video.Maxrate = _ctx.StringValue("SearchTemplate.TemplateList["+ i +"].Video.Maxrate");
				video.MaxFps = _ctx.StringValue("SearchTemplate.TemplateList["+ i +"].Video.MaxFps");
				video.Profile = _ctx.StringValue("SearchTemplate.TemplateList["+ i +"].Video.Profile");
				video.Crf = _ctx.StringValue("SearchTemplate.TemplateList["+ i +"].Video.Crf");
				video._Remove = _ctx.StringValue("SearchTemplate.TemplateList["+ i +"].Video.Remove");
				video.Gop = _ctx.StringValue("SearchTemplate.TemplateList["+ i +"].Video.Gop");
				video.Width = _ctx.StringValue("SearchTemplate.TemplateList["+ i +"].Video.Width");
				video.Fps = _ctx.StringValue("SearchTemplate.TemplateList["+ i +"].Video.Fps");
				video.Preset = _ctx.StringValue("SearchTemplate.TemplateList["+ i +"].Video.Preset");
				video.ScanMode = _ctx.StringValue("SearchTemplate.TemplateList["+ i +"].Video.ScanMode");
				video.ResoPriority = _ctx.StringValue("SearchTemplate.TemplateList["+ i +"].Video.ResoPriority");
				video.Hdr2sdr = _ctx.StringValue("SearchTemplate.TemplateList["+ i +"].Video.Hdr2sdr");

				SearchTemplateResponse.SearchTemplate_Template.SearchTemplate_Video.SearchTemplate_BitrateBnd bitrateBnd = new SearchTemplateResponse.SearchTemplate_Template.SearchTemplate_Video.SearchTemplate_BitrateBnd();
				bitrateBnd.Max = _ctx.StringValue("SearchTemplate.TemplateList["+ i +"].Video.BitrateBnd.Max");
				bitrateBnd.Min = _ctx.StringValue("SearchTemplate.TemplateList["+ i +"].Video.BitrateBnd.Min");
				video.BitrateBnd = bitrateBnd;

				SearchTemplateResponse.SearchTemplate_Template.SearchTemplate_Video.SearchTemplate_NarrowBand narrowBand = new SearchTemplateResponse.SearchTemplate_Template.SearchTemplate_Video.SearchTemplate_NarrowBand();
				narrowBand.Abrmax = _ctx.FloatValue("SearchTemplate.TemplateList["+ i +"].Video.NarrowBand.Abrmax");
				narrowBand.MaxAbrRatio = _ctx.FloatValue("SearchTemplate.TemplateList["+ i +"].Video.NarrowBand.MaxAbrRatio");
				narrowBand.Version = _ctx.StringValue("SearchTemplate.TemplateList["+ i +"].Video.NarrowBand.Version");
				video.NarrowBand = narrowBand;
				template.Video = video;

				SearchTemplateResponse.SearchTemplate_Template.SearchTemplate_TransConfig transConfig = new SearchTemplateResponse.SearchTemplate_Template.SearchTemplate_TransConfig();
				transConfig.IsCheckAudioBitrate = _ctx.StringValue("SearchTemplate.TemplateList["+ i +"].TransConfig.IsCheckAudioBitrate");
				transConfig.TransMode = _ctx.StringValue("SearchTemplate.TemplateList["+ i +"].TransConfig.TransMode");
				transConfig.IsCheckReso = _ctx.StringValue("SearchTemplate.TemplateList["+ i +"].TransConfig.IsCheckReso");
				transConfig.IsCheckVideoBitrateFail = _ctx.StringValue("SearchTemplate.TemplateList["+ i +"].TransConfig.IsCheckVideoBitrateFail");
				transConfig.AdjDarMethod = _ctx.StringValue("SearchTemplate.TemplateList["+ i +"].TransConfig.AdjDarMethod");
				transConfig.IsCheckVideoBitrate = _ctx.StringValue("SearchTemplate.TemplateList["+ i +"].TransConfig.IsCheckVideoBitrate");
				transConfig.IsCheckResoFail = _ctx.StringValue("SearchTemplate.TemplateList["+ i +"].TransConfig.IsCheckResoFail");
				transConfig.IsCheckAudioBitrateFail = _ctx.StringValue("SearchTemplate.TemplateList["+ i +"].TransConfig.IsCheckAudioBitrateFail");
				template.TransConfig = transConfig;

				SearchTemplateResponse.SearchTemplate_Template.SearchTemplate_MuxConfig muxConfig = new SearchTemplateResponse.SearchTemplate_Template.SearchTemplate_MuxConfig();

				SearchTemplateResponse.SearchTemplate_Template.SearchTemplate_MuxConfig.SearchTemplate_Gif gif = new SearchTemplateResponse.SearchTemplate_Template.SearchTemplate_MuxConfig.SearchTemplate_Gif();
				gif.FinalDelay = _ctx.StringValue("SearchTemplate.TemplateList["+ i +"].MuxConfig.Gif.FinalDelay");
				gif.DitherMode = _ctx.StringValue("SearchTemplate.TemplateList["+ i +"].MuxConfig.Gif.DitherMode");
				gif.Loop = _ctx.StringValue("SearchTemplate.TemplateList["+ i +"].MuxConfig.Gif.Loop");
				gif.IsCustomPalette = _ctx.StringValue("SearchTemplate.TemplateList["+ i +"].MuxConfig.Gif.IsCustomPalette");
				muxConfig.Gif = gif;

				SearchTemplateResponse.SearchTemplate_Template.SearchTemplate_MuxConfig.SearchTemplate_Segment segment = new SearchTemplateResponse.SearchTemplate_Template.SearchTemplate_MuxConfig.SearchTemplate_Segment();
				segment.Duration = _ctx.StringValue("SearchTemplate.TemplateList["+ i +"].MuxConfig.Segment.Duration");
				muxConfig.Segment = segment;
				template.MuxConfig = muxConfig;

				SearchTemplateResponse.SearchTemplate_Template.SearchTemplate_Audio audio = new SearchTemplateResponse.SearchTemplate_Template.SearchTemplate_Audio();
				audio.Profile = _ctx.StringValue("SearchTemplate.TemplateList["+ i +"].Audio.Profile");
				audio._Remove = _ctx.StringValue("SearchTemplate.TemplateList["+ i +"].Audio.Remove");
				audio.Codec = _ctx.StringValue("SearchTemplate.TemplateList["+ i +"].Audio.Codec");
				audio.Samplerate = _ctx.StringValue("SearchTemplate.TemplateList["+ i +"].Audio.Samplerate");
				audio.Qscale = _ctx.StringValue("SearchTemplate.TemplateList["+ i +"].Audio.Qscale");
				audio.Channels = _ctx.StringValue("SearchTemplate.TemplateList["+ i +"].Audio.Channels");
				audio.Bitrate = _ctx.StringValue("SearchTemplate.TemplateList["+ i +"].Audio.Bitrate");
				template.Audio = audio;

				SearchTemplateResponse.SearchTemplate_Template.SearchTemplate_Container container = new SearchTemplateResponse.SearchTemplate_Template.SearchTemplate_Container();
				container.Format = _ctx.StringValue("SearchTemplate.TemplateList["+ i +"].Container.Format");
				template.Container = container;

				SearchTemplateResponse.SearchTemplate_Template.SearchTemplate_FrontendHint frontendHint = new SearchTemplateResponse.SearchTemplate_Template.SearchTemplate_FrontendHint();
				frontendHint.TranscodeType = _ctx.StringValue("SearchTemplate.TemplateList["+ i +"].FrontendHint.TranscodeType");
				frontendHint.BitrateControlType = _ctx.StringValue("SearchTemplate.TemplateList["+ i +"].FrontendHint.BitrateControlType");
				frontendHint.Source = _ctx.StringValue("SearchTemplate.TemplateList["+ i +"].FrontendHint.Source");
				frontendHint.IsDynamic = _ctx.BooleanValue("SearchTemplate.TemplateList["+ i +"].FrontendHint.IsDynamic");
				frontendHint.HasOldHdr2Sdr = _ctx.BooleanValue("SearchTemplate.TemplateList["+ i +"].FrontendHint.HasOldHdr2Sdr");
				template.FrontendHint = frontendHint;

				searchTemplateResponse_templateList.Add(template);
			}
			searchTemplateResponse.TemplateList = searchTemplateResponse_templateList;
        
			return searchTemplateResponse;
        }
    }
}
