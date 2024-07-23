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
    public class QueryAnalysisJobListResponseUnmarshaller
    {
        public static QueryAnalysisJobListResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryAnalysisJobListResponse queryAnalysisJobListResponse = new QueryAnalysisJobListResponse();

			queryAnalysisJobListResponse.HttpResponse = _ctx.HttpResponse;
			queryAnalysisJobListResponse.RequestId = _ctx.StringValue("QueryAnalysisJobList.RequestId");

			List<string> queryAnalysisJobListResponse_nonExistAnalysisJobIds = new List<string>();
			for (int i = 0; i < _ctx.Length("QueryAnalysisJobList.NonExistAnalysisJobIds.Length"); i++) {
				queryAnalysisJobListResponse_nonExistAnalysisJobIds.Add(_ctx.StringValue("QueryAnalysisJobList.NonExistAnalysisJobIds["+ i +"]"));
			}
			queryAnalysisJobListResponse.NonExistAnalysisJobIds = queryAnalysisJobListResponse_nonExistAnalysisJobIds;

			List<QueryAnalysisJobListResponse.QueryAnalysisJobList_AnalysisJob> queryAnalysisJobListResponse_analysisJobList = new List<QueryAnalysisJobListResponse.QueryAnalysisJobList_AnalysisJob>();
			for (int i = 0; i < _ctx.Length("QueryAnalysisJobList.AnalysisJobList.Length"); i++) {
				QueryAnalysisJobListResponse.QueryAnalysisJobList_AnalysisJob analysisJob = new QueryAnalysisJobListResponse.QueryAnalysisJobList_AnalysisJob();
				analysisJob.CreationTime = _ctx.StringValue("QueryAnalysisJobList.AnalysisJobList["+ i +"].CreationTime");
				analysisJob.Percent = _ctx.LongValue("QueryAnalysisJobList.AnalysisJobList["+ i +"].Percent");
				analysisJob.State = _ctx.StringValue("QueryAnalysisJobList.AnalysisJobList["+ i +"].State");
				analysisJob.Message = _ctx.StringValue("QueryAnalysisJobList.AnalysisJobList["+ i +"].Message");
				analysisJob.Priority = _ctx.StringValue("QueryAnalysisJobList.AnalysisJobList["+ i +"].Priority");
				analysisJob.UserData = _ctx.StringValue("QueryAnalysisJobList.AnalysisJobList["+ i +"].UserData");
				analysisJob.Code = _ctx.StringValue("QueryAnalysisJobList.AnalysisJobList["+ i +"].Code");
				analysisJob.PipelineId = _ctx.StringValue("QueryAnalysisJobList.AnalysisJobList["+ i +"].PipelineId");
				analysisJob.Id = _ctx.StringValue("QueryAnalysisJobList.AnalysisJobList["+ i +"].Id");

				QueryAnalysisJobListResponse.QueryAnalysisJobList_AnalysisJob.QueryAnalysisJobList_AnalysisConfig analysisConfig = new QueryAnalysisJobListResponse.QueryAnalysisJobList_AnalysisJob.QueryAnalysisJobList_AnalysisConfig();

				QueryAnalysisJobListResponse.QueryAnalysisJobList_AnalysisJob.QueryAnalysisJobList_AnalysisConfig.QueryAnalysisJobList_QualityControl qualityControl = new QueryAnalysisJobListResponse.QueryAnalysisJobList_AnalysisJob.QueryAnalysisJobList_AnalysisConfig.QueryAnalysisJobList_QualityControl();
				qualityControl.MethodStreaming = _ctx.StringValue("QueryAnalysisJobList.AnalysisJobList["+ i +"].AnalysisConfig.QualityControl.MethodStreaming");
				qualityControl.RateQuality = _ctx.StringValue("QueryAnalysisJobList.AnalysisJobList["+ i +"].AnalysisConfig.QualityControl.RateQuality");
				analysisConfig.QualityControl = qualityControl;

				QueryAnalysisJobListResponse.QueryAnalysisJobList_AnalysisJob.QueryAnalysisJobList_AnalysisConfig.QueryAnalysisJobList_PropertiesControl propertiesControl = new QueryAnalysisJobListResponse.QueryAnalysisJobList_AnalysisJob.QueryAnalysisJobList_AnalysisConfig.QueryAnalysisJobList_PropertiesControl();
				propertiesControl.Deinterlace = _ctx.StringValue("QueryAnalysisJobList.AnalysisJobList["+ i +"].AnalysisConfig.PropertiesControl.Deinterlace");

				QueryAnalysisJobListResponse.QueryAnalysisJobList_AnalysisJob.QueryAnalysisJobList_AnalysisConfig.QueryAnalysisJobList_PropertiesControl.QueryAnalysisJobList_Crop crop = new QueryAnalysisJobListResponse.QueryAnalysisJobList_AnalysisJob.QueryAnalysisJobList_AnalysisConfig.QueryAnalysisJobList_PropertiesControl.QueryAnalysisJobList_Crop();
				crop.Top = _ctx.StringValue("QueryAnalysisJobList.AnalysisJobList["+ i +"].AnalysisConfig.PropertiesControl.Crop.Top");
				crop.Width = _ctx.StringValue("QueryAnalysisJobList.AnalysisJobList["+ i +"].AnalysisConfig.PropertiesControl.Crop.Width");
				crop.Height = _ctx.StringValue("QueryAnalysisJobList.AnalysisJobList["+ i +"].AnalysisConfig.PropertiesControl.Crop.Height");
				crop.Left = _ctx.StringValue("QueryAnalysisJobList.AnalysisJobList["+ i +"].AnalysisConfig.PropertiesControl.Crop.Left");
				crop.Mode = _ctx.StringValue("QueryAnalysisJobList.AnalysisJobList["+ i +"].AnalysisConfig.PropertiesControl.Crop.Mode");
				propertiesControl.Crop = crop;
				analysisConfig.PropertiesControl = propertiesControl;
				analysisJob.AnalysisConfig = analysisConfig;

				QueryAnalysisJobListResponse.QueryAnalysisJobList_AnalysisJob.QueryAnalysisJobList_MNSMessageResult mNSMessageResult = new QueryAnalysisJobListResponse.QueryAnalysisJobList_AnalysisJob.QueryAnalysisJobList_MNSMessageResult();
				mNSMessageResult.MessageId = _ctx.StringValue("QueryAnalysisJobList.AnalysisJobList["+ i +"].MNSMessageResult.MessageId");
				mNSMessageResult.ErrorMessage = _ctx.StringValue("QueryAnalysisJobList.AnalysisJobList["+ i +"].MNSMessageResult.ErrorMessage");
				mNSMessageResult.ErrorCode = _ctx.StringValue("QueryAnalysisJobList.AnalysisJobList["+ i +"].MNSMessageResult.ErrorCode");
				analysisJob.MNSMessageResult = mNSMessageResult;

				QueryAnalysisJobListResponse.QueryAnalysisJobList_AnalysisJob.QueryAnalysisJobList_InputFile inputFile = new QueryAnalysisJobListResponse.QueryAnalysisJobList_AnalysisJob.QueryAnalysisJobList_InputFile();
				inputFile._Object = _ctx.StringValue("QueryAnalysisJobList.AnalysisJobList["+ i +"].InputFile.Object");
				inputFile.Location = _ctx.StringValue("QueryAnalysisJobList.AnalysisJobList["+ i +"].InputFile.Location");
				inputFile.Bucket = _ctx.StringValue("QueryAnalysisJobList.AnalysisJobList["+ i +"].InputFile.Bucket");
				analysisJob.InputFile = inputFile;

				List<QueryAnalysisJobListResponse.QueryAnalysisJobList_AnalysisJob.QueryAnalysisJobList_Template> analysisJob_templateList = new List<QueryAnalysisJobListResponse.QueryAnalysisJobList_AnalysisJob.QueryAnalysisJobList_Template>();
				for (int j = 0; j < _ctx.Length("QueryAnalysisJobList.AnalysisJobList["+ i +"].TemplateList.Length"); j++) {
					QueryAnalysisJobListResponse.QueryAnalysisJobList_AnalysisJob.QueryAnalysisJobList_Template template = new QueryAnalysisJobListResponse.QueryAnalysisJobList_AnalysisJob.QueryAnalysisJobList_Template();
					template.State = _ctx.StringValue("QueryAnalysisJobList.AnalysisJobList["+ i +"].TemplateList["+ j +"].State");
					template.Name = _ctx.StringValue("QueryAnalysisJobList.AnalysisJobList["+ i +"].TemplateList["+ j +"].Name");
					template.Id = _ctx.StringValue("QueryAnalysisJobList.AnalysisJobList["+ i +"].TemplateList["+ j +"].Id");

					QueryAnalysisJobListResponse.QueryAnalysisJobList_AnalysisJob.QueryAnalysisJobList_Template.QueryAnalysisJobList_Video video = new QueryAnalysisJobListResponse.QueryAnalysisJobList_AnalysisJob.QueryAnalysisJobList_Template.QueryAnalysisJobList_Video();
					video.Bufsize = _ctx.StringValue("QueryAnalysisJobList.AnalysisJobList["+ i +"].TemplateList["+ j +"].Video.Bufsize");
					video.Degrain = _ctx.StringValue("QueryAnalysisJobList.AnalysisJobList["+ i +"].TemplateList["+ j +"].Video.Degrain");
					video.PixFmt = _ctx.StringValue("QueryAnalysisJobList.AnalysisJobList["+ i +"].TemplateList["+ j +"].Video.PixFmt");
					video.Codec = _ctx.StringValue("QueryAnalysisJobList.AnalysisJobList["+ i +"].TemplateList["+ j +"].Video.Codec");
					video.Height = _ctx.StringValue("QueryAnalysisJobList.AnalysisJobList["+ i +"].TemplateList["+ j +"].Video.Height");
					video.Qscale = _ctx.StringValue("QueryAnalysisJobList.AnalysisJobList["+ i +"].TemplateList["+ j +"].Video.Qscale");
					video.Bitrate = _ctx.StringValue("QueryAnalysisJobList.AnalysisJobList["+ i +"].TemplateList["+ j +"].Video.Bitrate");
					video.Maxrate = _ctx.StringValue("QueryAnalysisJobList.AnalysisJobList["+ i +"].TemplateList["+ j +"].Video.Maxrate");
					video.Profile = _ctx.StringValue("QueryAnalysisJobList.AnalysisJobList["+ i +"].TemplateList["+ j +"].Video.Profile");
					video.Crf = _ctx.StringValue("QueryAnalysisJobList.AnalysisJobList["+ i +"].TemplateList["+ j +"].Video.Crf");
					video.Gop = _ctx.StringValue("QueryAnalysisJobList.AnalysisJobList["+ i +"].TemplateList["+ j +"].Video.Gop");
					video.Width = _ctx.StringValue("QueryAnalysisJobList.AnalysisJobList["+ i +"].TemplateList["+ j +"].Video.Width");
					video.Fps = _ctx.StringValue("QueryAnalysisJobList.AnalysisJobList["+ i +"].TemplateList["+ j +"].Video.Fps");
					video.Preset = _ctx.StringValue("QueryAnalysisJobList.AnalysisJobList["+ i +"].TemplateList["+ j +"].Video.Preset");
					video.ScanMode = _ctx.StringValue("QueryAnalysisJobList.AnalysisJobList["+ i +"].TemplateList["+ j +"].Video.ScanMode");

					QueryAnalysisJobListResponse.QueryAnalysisJobList_AnalysisJob.QueryAnalysisJobList_Template.QueryAnalysisJobList_Video.QueryAnalysisJobList_BitrateBnd bitrateBnd = new QueryAnalysisJobListResponse.QueryAnalysisJobList_AnalysisJob.QueryAnalysisJobList_Template.QueryAnalysisJobList_Video.QueryAnalysisJobList_BitrateBnd();
					bitrateBnd.Max = _ctx.StringValue("QueryAnalysisJobList.AnalysisJobList["+ i +"].TemplateList["+ j +"].Video.BitrateBnd.Max");
					bitrateBnd.Min = _ctx.StringValue("QueryAnalysisJobList.AnalysisJobList["+ i +"].TemplateList["+ j +"].Video.BitrateBnd.Min");
					video.BitrateBnd = bitrateBnd;
					template.Video = video;

					QueryAnalysisJobListResponse.QueryAnalysisJobList_AnalysisJob.QueryAnalysisJobList_Template.QueryAnalysisJobList_TransConfig transConfig = new QueryAnalysisJobListResponse.QueryAnalysisJobList_AnalysisJob.QueryAnalysisJobList_Template.QueryAnalysisJobList_TransConfig();
					transConfig.TransMode = _ctx.StringValue("QueryAnalysisJobList.AnalysisJobList["+ i +"].TemplateList["+ j +"].TransConfig.TransMode");
					template.TransConfig = transConfig;

					QueryAnalysisJobListResponse.QueryAnalysisJobList_AnalysisJob.QueryAnalysisJobList_Template.QueryAnalysisJobList_MuxConfig muxConfig = new QueryAnalysisJobListResponse.QueryAnalysisJobList_AnalysisJob.QueryAnalysisJobList_Template.QueryAnalysisJobList_MuxConfig();

					QueryAnalysisJobListResponse.QueryAnalysisJobList_AnalysisJob.QueryAnalysisJobList_Template.QueryAnalysisJobList_MuxConfig.QueryAnalysisJobList_Gif gif = new QueryAnalysisJobListResponse.QueryAnalysisJobList_AnalysisJob.QueryAnalysisJobList_Template.QueryAnalysisJobList_MuxConfig.QueryAnalysisJobList_Gif();
					gif.FinalDelay = _ctx.StringValue("QueryAnalysisJobList.AnalysisJobList["+ i +"].TemplateList["+ j +"].MuxConfig.Gif.FinalDelay");
					gif.Loop = _ctx.StringValue("QueryAnalysisJobList.AnalysisJobList["+ i +"].TemplateList["+ j +"].MuxConfig.Gif.Loop");
					muxConfig.Gif = gif;

					QueryAnalysisJobListResponse.QueryAnalysisJobList_AnalysisJob.QueryAnalysisJobList_Template.QueryAnalysisJobList_MuxConfig.QueryAnalysisJobList_Segment segment = new QueryAnalysisJobListResponse.QueryAnalysisJobList_AnalysisJob.QueryAnalysisJobList_Template.QueryAnalysisJobList_MuxConfig.QueryAnalysisJobList_Segment();
					segment.Duration = _ctx.StringValue("QueryAnalysisJobList.AnalysisJobList["+ i +"].TemplateList["+ j +"].MuxConfig.Segment.Duration");
					muxConfig.Segment = segment;
					template.MuxConfig = muxConfig;

					QueryAnalysisJobListResponse.QueryAnalysisJobList_AnalysisJob.QueryAnalysisJobList_Template.QueryAnalysisJobList_Audio audio = new QueryAnalysisJobListResponse.QueryAnalysisJobList_AnalysisJob.QueryAnalysisJobList_Template.QueryAnalysisJobList_Audio();
					audio.Profile = _ctx.StringValue("QueryAnalysisJobList.AnalysisJobList["+ i +"].TemplateList["+ j +"].Audio.Profile");
					audio.Codec = _ctx.StringValue("QueryAnalysisJobList.AnalysisJobList["+ i +"].TemplateList["+ j +"].Audio.Codec");
					audio.Samplerate = _ctx.StringValue("QueryAnalysisJobList.AnalysisJobList["+ i +"].TemplateList["+ j +"].Audio.Samplerate");
					audio.Qscale = _ctx.StringValue("QueryAnalysisJobList.AnalysisJobList["+ i +"].TemplateList["+ j +"].Audio.Qscale");
					audio.Channels = _ctx.StringValue("QueryAnalysisJobList.AnalysisJobList["+ i +"].TemplateList["+ j +"].Audio.Channels");
					audio.Bitrate = _ctx.StringValue("QueryAnalysisJobList.AnalysisJobList["+ i +"].TemplateList["+ j +"].Audio.Bitrate");
					template.Audio = audio;

					QueryAnalysisJobListResponse.QueryAnalysisJobList_AnalysisJob.QueryAnalysisJobList_Template.QueryAnalysisJobList_Container container = new QueryAnalysisJobListResponse.QueryAnalysisJobList_AnalysisJob.QueryAnalysisJobList_Template.QueryAnalysisJobList_Container();
					container.Format = _ctx.StringValue("QueryAnalysisJobList.AnalysisJobList["+ i +"].TemplateList["+ j +"].Container.Format");
					template.Container = container;

					analysisJob_templateList.Add(template);
				}
				analysisJob.TemplateList = analysisJob_templateList;

				queryAnalysisJobListResponse_analysisJobList.Add(analysisJob);
			}
			queryAnalysisJobListResponse.AnalysisJobList = queryAnalysisJobListResponse_analysisJobList;
        
			return queryAnalysisJobListResponse;
        }
    }
}
