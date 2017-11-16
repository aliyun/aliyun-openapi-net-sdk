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
    public class QueryAnalysisJobListResponseUnmarshaller
    {
        public static QueryAnalysisJobListResponse Unmarshall(UnmarshallerContext context)
        {
			QueryAnalysisJobListResponse queryAnalysisJobListResponse = new QueryAnalysisJobListResponse();

			queryAnalysisJobListResponse.HttpResponse = context.HttpResponse;
			queryAnalysisJobListResponse.RequestId = context.StringValue("QueryAnalysisJobList.RequestId");

			List<string> queryAnalysisJobListResponse_nonExistAnalysisJobIds = new List<string>();
			for (int i = 0; i < context.Length("QueryAnalysisJobList.NonExistAnalysisJobIds.Length"); i++) {
				queryAnalysisJobListResponse_nonExistAnalysisJobIds.Add(context.StringValue("QueryAnalysisJobList.NonExistAnalysisJobIds["+ i +"]"));
			}
			queryAnalysisJobListResponse.NonExistAnalysisJobIds = queryAnalysisJobListResponse_nonExistAnalysisJobIds;

			List<QueryAnalysisJobListResponse.QueryAnalysisJobList_AnalysisJob> queryAnalysisJobListResponse_analysisJobList = new List<QueryAnalysisJobListResponse.QueryAnalysisJobList_AnalysisJob>();
			for (int i = 0; i < context.Length("QueryAnalysisJobList.AnalysisJobList.Length"); i++) {
				QueryAnalysisJobListResponse.QueryAnalysisJobList_AnalysisJob analysisJob = new QueryAnalysisJobListResponse.QueryAnalysisJobList_AnalysisJob();
				analysisJob.Id = context.StringValue("QueryAnalysisJobList.AnalysisJobList["+ i +"].Id");
				analysisJob.UserData = context.StringValue("QueryAnalysisJobList.AnalysisJobList["+ i +"].UserData");
				analysisJob.State = context.StringValue("QueryAnalysisJobList.AnalysisJobList["+ i +"].State");
				analysisJob.Code = context.StringValue("QueryAnalysisJobList.AnalysisJobList["+ i +"].Code");
				analysisJob.Message = context.StringValue("QueryAnalysisJobList.AnalysisJobList["+ i +"].Message");
				analysisJob.Percent = context.LongValue("QueryAnalysisJobList.AnalysisJobList["+ i +"].Percent");
				analysisJob.CreationTime = context.StringValue("QueryAnalysisJobList.AnalysisJobList["+ i +"].CreationTime");
				analysisJob.PipelineId = context.StringValue("QueryAnalysisJobList.AnalysisJobList["+ i +"].PipelineId");
				analysisJob.Priority = context.StringValue("QueryAnalysisJobList.AnalysisJobList["+ i +"].Priority");

				QueryAnalysisJobListResponse.QueryAnalysisJobList_AnalysisJob.QueryAnalysisJobList_InputFile inputFile = new QueryAnalysisJobListResponse.QueryAnalysisJobList_AnalysisJob.QueryAnalysisJobList_InputFile();
				inputFile.Bucket = context.StringValue("QueryAnalysisJobList.AnalysisJobList["+ i +"].InputFile.Bucket");
				inputFile.Location = context.StringValue("QueryAnalysisJobList.AnalysisJobList["+ i +"].InputFile.Location");
				inputFile._Object = context.StringValue("QueryAnalysisJobList.AnalysisJobList["+ i +"].InputFile.Object");
				analysisJob.InputFile = inputFile;

				QueryAnalysisJobListResponse.QueryAnalysisJobList_AnalysisJob.QueryAnalysisJobList_AnalysisConfig analysisConfig = new QueryAnalysisJobListResponse.QueryAnalysisJobList_AnalysisJob.QueryAnalysisJobList_AnalysisConfig();

				QueryAnalysisJobListResponse.QueryAnalysisJobList_AnalysisJob.QueryAnalysisJobList_AnalysisConfig.QueryAnalysisJobList_QualityControl qualityControl = new QueryAnalysisJobListResponse.QueryAnalysisJobList_AnalysisJob.QueryAnalysisJobList_AnalysisConfig.QueryAnalysisJobList_QualityControl();
				qualityControl.RateQuality = context.StringValue("QueryAnalysisJobList.AnalysisJobList["+ i +"].AnalysisConfig.QualityControl.RateQuality");
				qualityControl.MethodStreaming = context.StringValue("QueryAnalysisJobList.AnalysisJobList["+ i +"].AnalysisConfig.QualityControl.MethodStreaming");
				analysisConfig.QualityControl = qualityControl;

				QueryAnalysisJobListResponse.QueryAnalysisJobList_AnalysisJob.QueryAnalysisJobList_AnalysisConfig.QueryAnalysisJobList_PropertiesControl propertiesControl = new QueryAnalysisJobListResponse.QueryAnalysisJobList_AnalysisJob.QueryAnalysisJobList_AnalysisConfig.QueryAnalysisJobList_PropertiesControl();
				propertiesControl.Deinterlace = context.StringValue("QueryAnalysisJobList.AnalysisJobList["+ i +"].AnalysisConfig.PropertiesControl.Deinterlace");

				QueryAnalysisJobListResponse.QueryAnalysisJobList_AnalysisJob.QueryAnalysisJobList_AnalysisConfig.QueryAnalysisJobList_PropertiesControl.QueryAnalysisJobList_Crop crop = new QueryAnalysisJobListResponse.QueryAnalysisJobList_AnalysisJob.QueryAnalysisJobList_AnalysisConfig.QueryAnalysisJobList_PropertiesControl.QueryAnalysisJobList_Crop();
				crop.Mode = context.StringValue("QueryAnalysisJobList.AnalysisJobList["+ i +"].AnalysisConfig.PropertiesControl.Crop.Mode");
				crop.Width = context.StringValue("QueryAnalysisJobList.AnalysisJobList["+ i +"].AnalysisConfig.PropertiesControl.Crop.Width");
				crop.Height = context.StringValue("QueryAnalysisJobList.AnalysisJobList["+ i +"].AnalysisConfig.PropertiesControl.Crop.Height");
				crop.Top = context.StringValue("QueryAnalysisJobList.AnalysisJobList["+ i +"].AnalysisConfig.PropertiesControl.Crop.Top");
				crop.Left = context.StringValue("QueryAnalysisJobList.AnalysisJobList["+ i +"].AnalysisConfig.PropertiesControl.Crop.Left");
				propertiesControl.Crop = crop;
				analysisConfig.PropertiesControl = propertiesControl;
				analysisJob.AnalysisConfig = analysisConfig;

				QueryAnalysisJobListResponse.QueryAnalysisJobList_AnalysisJob.QueryAnalysisJobList_MNSMessageResult mNSMessageResult = new QueryAnalysisJobListResponse.QueryAnalysisJobList_AnalysisJob.QueryAnalysisJobList_MNSMessageResult();
				mNSMessageResult.MessageId = context.StringValue("QueryAnalysisJobList.AnalysisJobList["+ i +"].MNSMessageResult.MessageId");
				mNSMessageResult.ErrorMessage = context.StringValue("QueryAnalysisJobList.AnalysisJobList["+ i +"].MNSMessageResult.ErrorMessage");
				mNSMessageResult.ErrorCode = context.StringValue("QueryAnalysisJobList.AnalysisJobList["+ i +"].MNSMessageResult.ErrorCode");
				analysisJob.MNSMessageResult = mNSMessageResult;

				List<QueryAnalysisJobListResponse.QueryAnalysisJobList_AnalysisJob.QueryAnalysisJobList_Template> analysisJob_templateList = new List<QueryAnalysisJobListResponse.QueryAnalysisJobList_AnalysisJob.QueryAnalysisJobList_Template>();
				for (int j = 0; j < context.Length("QueryAnalysisJobList.AnalysisJobList["+ i +"].TemplateList.Length"); j++) {
					QueryAnalysisJobListResponse.QueryAnalysisJobList_AnalysisJob.QueryAnalysisJobList_Template template = new QueryAnalysisJobListResponse.QueryAnalysisJobList_AnalysisJob.QueryAnalysisJobList_Template();
					template.Id = context.StringValue("QueryAnalysisJobList.AnalysisJobList["+ i +"].TemplateList["+ j +"].Id");
					template.Name = context.StringValue("QueryAnalysisJobList.AnalysisJobList["+ i +"].TemplateList["+ j +"].Name");
					template.State = context.StringValue("QueryAnalysisJobList.AnalysisJobList["+ i +"].TemplateList["+ j +"].State");

					QueryAnalysisJobListResponse.QueryAnalysisJobList_AnalysisJob.QueryAnalysisJobList_Template.QueryAnalysisJobList_Container container = new QueryAnalysisJobListResponse.QueryAnalysisJobList_AnalysisJob.QueryAnalysisJobList_Template.QueryAnalysisJobList_Container();
					container.Format = context.StringValue("QueryAnalysisJobList.AnalysisJobList["+ i +"].TemplateList["+ j +"].Container.Format");
					template.Container = container;

					QueryAnalysisJobListResponse.QueryAnalysisJobList_AnalysisJob.QueryAnalysisJobList_Template.QueryAnalysisJobList_Video video = new QueryAnalysisJobListResponse.QueryAnalysisJobList_AnalysisJob.QueryAnalysisJobList_Template.QueryAnalysisJobList_Video();
					video.Codec = context.StringValue("QueryAnalysisJobList.AnalysisJobList["+ i +"].TemplateList["+ j +"].Video.Codec");
					video.Profile = context.StringValue("QueryAnalysisJobList.AnalysisJobList["+ i +"].TemplateList["+ j +"].Video.Profile");
					video.Bitrate = context.StringValue("QueryAnalysisJobList.AnalysisJobList["+ i +"].TemplateList["+ j +"].Video.Bitrate");
					video.Crf = context.StringValue("QueryAnalysisJobList.AnalysisJobList["+ i +"].TemplateList["+ j +"].Video.Crf");
					video.Width = context.StringValue("QueryAnalysisJobList.AnalysisJobList["+ i +"].TemplateList["+ j +"].Video.Width");
					video.Height = context.StringValue("QueryAnalysisJobList.AnalysisJobList["+ i +"].TemplateList["+ j +"].Video.Height");
					video.Fps = context.StringValue("QueryAnalysisJobList.AnalysisJobList["+ i +"].TemplateList["+ j +"].Video.Fps");
					video.Gop = context.StringValue("QueryAnalysisJobList.AnalysisJobList["+ i +"].TemplateList["+ j +"].Video.Gop");
					video.Preset = context.StringValue("QueryAnalysisJobList.AnalysisJobList["+ i +"].TemplateList["+ j +"].Video.Preset");
					video.ScanMode = context.StringValue("QueryAnalysisJobList.AnalysisJobList["+ i +"].TemplateList["+ j +"].Video.ScanMode");
					video.Bufsize = context.StringValue("QueryAnalysisJobList.AnalysisJobList["+ i +"].TemplateList["+ j +"].Video.Bufsize");
					video.Maxrate = context.StringValue("QueryAnalysisJobList.AnalysisJobList["+ i +"].TemplateList["+ j +"].Video.Maxrate");
					video.PixFmt = context.StringValue("QueryAnalysisJobList.AnalysisJobList["+ i +"].TemplateList["+ j +"].Video.PixFmt");
					video.Degrain = context.StringValue("QueryAnalysisJobList.AnalysisJobList["+ i +"].TemplateList["+ j +"].Video.Degrain");
					video.Qscale = context.StringValue("QueryAnalysisJobList.AnalysisJobList["+ i +"].TemplateList["+ j +"].Video.Qscale");

					QueryAnalysisJobListResponse.QueryAnalysisJobList_AnalysisJob.QueryAnalysisJobList_Template.QueryAnalysisJobList_Video.QueryAnalysisJobList_BitrateBnd bitrateBnd = new QueryAnalysisJobListResponse.QueryAnalysisJobList_AnalysisJob.QueryAnalysisJobList_Template.QueryAnalysisJobList_Video.QueryAnalysisJobList_BitrateBnd();
					bitrateBnd.Max = context.StringValue("QueryAnalysisJobList.AnalysisJobList["+ i +"].TemplateList["+ j +"].Video.BitrateBnd.Max");
					bitrateBnd.Min = context.StringValue("QueryAnalysisJobList.AnalysisJobList["+ i +"].TemplateList["+ j +"].Video.BitrateBnd.Min");
					video.BitrateBnd = bitrateBnd;
					template.Video = video;

					QueryAnalysisJobListResponse.QueryAnalysisJobList_AnalysisJob.QueryAnalysisJobList_Template.QueryAnalysisJobList_Audio audio = new QueryAnalysisJobListResponse.QueryAnalysisJobList_AnalysisJob.QueryAnalysisJobList_Template.QueryAnalysisJobList_Audio();
					audio.Codec = context.StringValue("QueryAnalysisJobList.AnalysisJobList["+ i +"].TemplateList["+ j +"].Audio.Codec");
					audio.Profile = context.StringValue("QueryAnalysisJobList.AnalysisJobList["+ i +"].TemplateList["+ j +"].Audio.Profile");
					audio.Samplerate = context.StringValue("QueryAnalysisJobList.AnalysisJobList["+ i +"].TemplateList["+ j +"].Audio.Samplerate");
					audio.Bitrate = context.StringValue("QueryAnalysisJobList.AnalysisJobList["+ i +"].TemplateList["+ j +"].Audio.Bitrate");
					audio.Channels = context.StringValue("QueryAnalysisJobList.AnalysisJobList["+ i +"].TemplateList["+ j +"].Audio.Channels");
					audio.Qscale = context.StringValue("QueryAnalysisJobList.AnalysisJobList["+ i +"].TemplateList["+ j +"].Audio.Qscale");
					template.Audio = audio;

					QueryAnalysisJobListResponse.QueryAnalysisJobList_AnalysisJob.QueryAnalysisJobList_Template.QueryAnalysisJobList_TransConfig transConfig = new QueryAnalysisJobListResponse.QueryAnalysisJobList_AnalysisJob.QueryAnalysisJobList_Template.QueryAnalysisJobList_TransConfig();
					transConfig.TransMode = context.StringValue("QueryAnalysisJobList.AnalysisJobList["+ i +"].TemplateList["+ j +"].TransConfig.TransMode");
					template.TransConfig = transConfig;

					QueryAnalysisJobListResponse.QueryAnalysisJobList_AnalysisJob.QueryAnalysisJobList_Template.QueryAnalysisJobList_MuxConfig muxConfig = new QueryAnalysisJobListResponse.QueryAnalysisJobList_AnalysisJob.QueryAnalysisJobList_Template.QueryAnalysisJobList_MuxConfig();

					QueryAnalysisJobListResponse.QueryAnalysisJobList_AnalysisJob.QueryAnalysisJobList_Template.QueryAnalysisJobList_MuxConfig.QueryAnalysisJobList_Segment segment = new QueryAnalysisJobListResponse.QueryAnalysisJobList_AnalysisJob.QueryAnalysisJobList_Template.QueryAnalysisJobList_MuxConfig.QueryAnalysisJobList_Segment();
					segment.Duration = context.StringValue("QueryAnalysisJobList.AnalysisJobList["+ i +"].TemplateList["+ j +"].MuxConfig.Segment.Duration");
					muxConfig.Segment = segment;

					QueryAnalysisJobListResponse.QueryAnalysisJobList_AnalysisJob.QueryAnalysisJobList_Template.QueryAnalysisJobList_MuxConfig.QueryAnalysisJobList_Gif gif = new QueryAnalysisJobListResponse.QueryAnalysisJobList_AnalysisJob.QueryAnalysisJobList_Template.QueryAnalysisJobList_MuxConfig.QueryAnalysisJobList_Gif();
					gif.Loop = context.StringValue("QueryAnalysisJobList.AnalysisJobList["+ i +"].TemplateList["+ j +"].MuxConfig.Gif.Loop");
					gif.FinalDelay = context.StringValue("QueryAnalysisJobList.AnalysisJobList["+ i +"].TemplateList["+ j +"].MuxConfig.Gif.FinalDelay");
					muxConfig.Gif = gif;
					template.MuxConfig = muxConfig;

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