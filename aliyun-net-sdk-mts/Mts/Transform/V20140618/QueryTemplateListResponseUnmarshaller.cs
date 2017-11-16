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

			List<string> queryTemplateListResponse_nonExistTids = new List<string>();
			for (int i = 0; i < context.Length("QueryTemplateList.NonExistTids.Length"); i++) {
				queryTemplateListResponse_nonExistTids.Add(context.StringValue("QueryTemplateList.NonExistTids["+ i +"]"));
			}
			queryTemplateListResponse.NonExistTids = queryTemplateListResponse_nonExistTids;

			List<QueryTemplateListResponse.QueryTemplateList_Template> queryTemplateListResponse_templateList = new List<QueryTemplateListResponse.QueryTemplateList_Template>();
			for (int i = 0; i < context.Length("QueryTemplateList.TemplateList.Length"); i++) {
				QueryTemplateListResponse.QueryTemplateList_Template template = new QueryTemplateListResponse.QueryTemplateList_Template();
				template.Id = context.StringValue("QueryTemplateList.TemplateList["+ i +"].Id");
				template.Name = context.StringValue("QueryTemplateList.TemplateList["+ i +"].Name");
				template.State = context.StringValue("QueryTemplateList.TemplateList["+ i +"].State");

				QueryTemplateListResponse.QueryTemplateList_Template.QueryTemplateList_Container container = new QueryTemplateListResponse.QueryTemplateList_Template.QueryTemplateList_Container();
				container.Format = context.StringValue("QueryTemplateList.TemplateList["+ i +"].Container.Format");
				template.Container = container;

				QueryTemplateListResponse.QueryTemplateList_Template.QueryTemplateList_Video video = new QueryTemplateListResponse.QueryTemplateList_Template.QueryTemplateList_Video();
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
				video._Remove = context.StringValue("QueryTemplateList.TemplateList["+ i +"].Video.Remove");
				video.Crop = context.StringValue("QueryTemplateList.TemplateList["+ i +"].Video.Crop");
				video.Pad = context.StringValue("QueryTemplateList.TemplateList["+ i +"].Video.Pad");
				video.MaxFps = context.StringValue("QueryTemplateList.TemplateList["+ i +"].Video.MaxFps");

				QueryTemplateListResponse.QueryTemplateList_Template.QueryTemplateList_Video.QueryTemplateList_BitrateBnd bitrateBnd = new QueryTemplateListResponse.QueryTemplateList_Template.QueryTemplateList_Video.QueryTemplateList_BitrateBnd();
				bitrateBnd.Max = context.StringValue("QueryTemplateList.TemplateList["+ i +"].Video.BitrateBnd.Max");
				bitrateBnd.Min = context.StringValue("QueryTemplateList.TemplateList["+ i +"].Video.BitrateBnd.Min");
				video.BitrateBnd = bitrateBnd;
				template.Video = video;

				QueryTemplateListResponse.QueryTemplateList_Template.QueryTemplateList_Audio audio = new QueryTemplateListResponse.QueryTemplateList_Template.QueryTemplateList_Audio();
				audio.Codec = context.StringValue("QueryTemplateList.TemplateList["+ i +"].Audio.Codec");
				audio.Profile = context.StringValue("QueryTemplateList.TemplateList["+ i +"].Audio.Profile");
				audio.Samplerate = context.StringValue("QueryTemplateList.TemplateList["+ i +"].Audio.Samplerate");
				audio.Bitrate = context.StringValue("QueryTemplateList.TemplateList["+ i +"].Audio.Bitrate");
				audio.Channels = context.StringValue("QueryTemplateList.TemplateList["+ i +"].Audio.Channels");
				audio.Qscale = context.StringValue("QueryTemplateList.TemplateList["+ i +"].Audio.Qscale");
				audio._Remove = context.StringValue("QueryTemplateList.TemplateList["+ i +"].Audio.Remove");
				template.Audio = audio;

				QueryTemplateListResponse.QueryTemplateList_Template.QueryTemplateList_TransConfig transConfig = new QueryTemplateListResponse.QueryTemplateList_Template.QueryTemplateList_TransConfig();
				transConfig.TransMode = context.StringValue("QueryTemplateList.TemplateList["+ i +"].TransConfig.TransMode");
				transConfig.IsCheckReso = context.StringValue("QueryTemplateList.TemplateList["+ i +"].TransConfig.IsCheckReso");
				transConfig.IsCheckResoFail = context.StringValue("QueryTemplateList.TemplateList["+ i +"].TransConfig.IsCheckResoFail");
				transConfig.IsCheckVideoBitrate = context.StringValue("QueryTemplateList.TemplateList["+ i +"].TransConfig.IsCheckVideoBitrate");
				transConfig.IsCheckAudioBitrate = context.StringValue("QueryTemplateList.TemplateList["+ i +"].TransConfig.IsCheckAudioBitrate");
				transConfig.AdjDarMethod = context.StringValue("QueryTemplateList.TemplateList["+ i +"].TransConfig.AdjDarMethod");
				transConfig.IsCheckVideoBitrateFail = context.StringValue("QueryTemplateList.TemplateList["+ i +"].TransConfig.IsCheckVideoBitrateFail");
				transConfig.IsCheckAudioBitrateFail = context.StringValue("QueryTemplateList.TemplateList["+ i +"].TransConfig.IsCheckAudioBitrateFail");
				template.TransConfig = transConfig;

				QueryTemplateListResponse.QueryTemplateList_Template.QueryTemplateList_MuxConfig muxConfig = new QueryTemplateListResponse.QueryTemplateList_Template.QueryTemplateList_MuxConfig();

				QueryTemplateListResponse.QueryTemplateList_Template.QueryTemplateList_MuxConfig.QueryTemplateList_Segment segment = new QueryTemplateListResponse.QueryTemplateList_Template.QueryTemplateList_MuxConfig.QueryTemplateList_Segment();
				segment.Duration = context.StringValue("QueryTemplateList.TemplateList["+ i +"].MuxConfig.Segment.Duration");
				muxConfig.Segment = segment;

				QueryTemplateListResponse.QueryTemplateList_Template.QueryTemplateList_MuxConfig.QueryTemplateList_Gif gif = new QueryTemplateListResponse.QueryTemplateList_Template.QueryTemplateList_MuxConfig.QueryTemplateList_Gif();
				gif.Loop = context.StringValue("QueryTemplateList.TemplateList["+ i +"].MuxConfig.Gif.Loop");
				gif.FinalDelay = context.StringValue("QueryTemplateList.TemplateList["+ i +"].MuxConfig.Gif.FinalDelay");
				gif.IsCustomPalette = context.StringValue("QueryTemplateList.TemplateList["+ i +"].MuxConfig.Gif.IsCustomPalette");
				gif.DitherMode = context.StringValue("QueryTemplateList.TemplateList["+ i +"].MuxConfig.Gif.DitherMode");
				muxConfig.Gif = gif;
				template.MuxConfig = muxConfig;

				queryTemplateListResponse_templateList.Add(template);
			}
			queryTemplateListResponse.TemplateList = queryTemplateListResponse_templateList;
        
			return queryTemplateListResponse;
        }
    }
}