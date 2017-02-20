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
    public class QueryAnalysisJobListResponseUnmarshaller
    {
        public static QueryAnalysisJobListResponse Unmarshall(UnmarshallerContext context)
        {
            QueryAnalysisJobListResponse queryAnalysisJobListResponse = new QueryAnalysisJobListResponse()
            {
                HttpResponse = context.HttpResponse,
                RequestId = context.StringValue("QueryAnalysisJobList.RequestId")
            };
            List<string> nonExistAnalysisJobIds = new List<string>();
			for (int i = 0; i < context.Length("QueryAnalysisJobList.NonExistAnalysisJobIds.Length"); i++) {
				nonExistAnalysisJobIds.Add(context.StringValue($"QueryAnalysisJobList.NonExistAnalysisJobIds[{i}]"));
			}
			queryAnalysisJobListResponse.NonExistAnalysisJobIds = nonExistAnalysisJobIds;

			List<QueryAnalysisJobListResponse.AnalysisJob> analysisJobList = new List<QueryAnalysisJobListResponse.AnalysisJob>();
			for (int i = 0; i < context.Length("QueryAnalysisJobList.AnalysisJobList.Length"); i++) {
                QueryAnalysisJobListResponse.AnalysisJob analysisJob = new QueryAnalysisJobListResponse.AnalysisJob()
                {
                    Id = context.StringValue($"QueryAnalysisJobList.AnalysisJobList[{i}].Id"),
                    UserData = context.StringValue($"QueryAnalysisJobList.AnalysisJobList[{i}].UserData"),
                    State = context.StringValue($"QueryAnalysisJobList.AnalysisJobList[{i}].State"),
                    Code = context.StringValue($"QueryAnalysisJobList.AnalysisJobList[{i}].Code"),
                    Message = context.StringValue($"QueryAnalysisJobList.AnalysisJobList[{i}].Message"),
                    Percent = context.LongValue($"QueryAnalysisJobList.AnalysisJobList[{i}].Percent"),
                    CreationTime = context.StringValue($"QueryAnalysisJobList.AnalysisJobList[{i}].CreationTime"),
                    PipelineId = context.StringValue($"QueryAnalysisJobList.AnalysisJobList[{i}].PipelineId"),
                    Priority = context.StringValue($"QueryAnalysisJobList.AnalysisJobList[{i}].Priority")
                };
                QueryAnalysisJobListResponse.AnalysisJob.InputFile_ inputFile = new QueryAnalysisJobListResponse.AnalysisJob.InputFile_()
                {
                    Bucket = context.StringValue($"QueryAnalysisJobList.AnalysisJobList[{i}].InputFile.Bucket"),
                    Location = context.StringValue($"QueryAnalysisJobList.AnalysisJobList[{i}].InputFile.Location"),
                    Object = context.StringValue($"QueryAnalysisJobList.AnalysisJobList[{i}].InputFile.Object")
                };
                analysisJob.InputFile = inputFile;

				QueryAnalysisJobListResponse.AnalysisJob.AnalysisConfig_ analysisConfig = new QueryAnalysisJobListResponse.AnalysisJob.AnalysisConfig_();

                QueryAnalysisJobListResponse.AnalysisJob.AnalysisConfig_.QualityControl_ qualityControl = new QueryAnalysisJobListResponse.AnalysisJob.AnalysisConfig_.QualityControl_()
                {
                    RateQuality = context.StringValue($"QueryAnalysisJobList.AnalysisJobList[{i}].AnalysisConfig.QualityControl.RateQuality"),
                    MethodStreaming = context.StringValue($"QueryAnalysisJobList.AnalysisJobList[{i}].AnalysisConfig.QualityControl.MethodStreaming")
                };
                analysisConfig.QualityControl = qualityControl;

                QueryAnalysisJobListResponse.AnalysisJob.AnalysisConfig_.PropertiesControl_ propertiesControl = new QueryAnalysisJobListResponse.AnalysisJob.AnalysisConfig_.PropertiesControl_()
                {
                    Deinterlace = context.StringValue($"QueryAnalysisJobList.AnalysisJobList[{i}].AnalysisConfig.PropertiesControl.Deinterlace")
                };
                QueryAnalysisJobListResponse.AnalysisJob.AnalysisConfig_.PropertiesControl_.Crop_ crop = new QueryAnalysisJobListResponse.AnalysisJob.AnalysisConfig_.PropertiesControl_.Crop_()
                {
                    Mode = context.StringValue($"QueryAnalysisJobList.AnalysisJobList[{i}].AnalysisConfig.PropertiesControl.Crop.Mode"),
                    Width = context.StringValue($"QueryAnalysisJobList.AnalysisJobList[{i}].AnalysisConfig.PropertiesControl.Crop.Width"),
                    Height = context.StringValue($"QueryAnalysisJobList.AnalysisJobList[{i}].AnalysisConfig.PropertiesControl.Crop.Height"),
                    Top = context.StringValue($"QueryAnalysisJobList.AnalysisJobList[{i}].AnalysisConfig.PropertiesControl.Crop.Top"),
                    Left = context.StringValue($"QueryAnalysisJobList.AnalysisJobList[{i}].AnalysisConfig.PropertiesControl.Crop.Left")
                };
                propertiesControl.Crop = crop;
				analysisConfig.PropertiesControl = propertiesControl;
				analysisJob.AnalysisConfig = analysisConfig;

                QueryAnalysisJobListResponse.AnalysisJob.MnsMessageResult_ mNsMessageResult = new QueryAnalysisJobListResponse.AnalysisJob.MnsMessageResult_()
                {
                    MessageId = context.StringValue($"QueryAnalysisJobList.AnalysisJobList[{i}].MNSMessageResult.MessageId"),
                    ErrorMessage = context.StringValue($"QueryAnalysisJobList.AnalysisJobList[{i}].MNSMessageResult.ErrorMessage"),
                    ErrorCode = context.StringValue($"QueryAnalysisJobList.AnalysisJobList[{i}].MNSMessageResult.ErrorCode")
                };
                analysisJob.MnsMessageResult = mNsMessageResult;

				List<QueryAnalysisJobListResponse.AnalysisJob.Template> templateList = new List<QueryAnalysisJobListResponse.AnalysisJob.Template>();
				for (int j = 0; j < context.Length($"QueryAnalysisJobList.AnalysisJobList[{i}].TemplateList.Length"); j++) {
                    QueryAnalysisJobListResponse.AnalysisJob.Template template = new QueryAnalysisJobListResponse.AnalysisJob.Template()
                    {
                        Id = context.StringValue($"QueryAnalysisJobList.AnalysisJobList[{i}].TemplateList[{j}].Id"),
                        Name = context.StringValue($"QueryAnalysisJobList.AnalysisJobList[{i}].TemplateList[{j}].Name"),
                        State = context.StringValue($"QueryAnalysisJobList.AnalysisJobList[{i}].TemplateList[{j}].State")
                    };
                    QueryAnalysisJobListResponse.AnalysisJob.Template.Container_ container = new QueryAnalysisJobListResponse.AnalysisJob.Template.Container_()
                    {
                        Format = context.StringValue($"QueryAnalysisJobList.AnalysisJobList[{i}].TemplateList[{j}].Container.Format")
                    };
                    template.Container = container;

                    QueryAnalysisJobListResponse.AnalysisJob.Template.Video_ video = new QueryAnalysisJobListResponse.AnalysisJob.Template.Video_()
                    {
                        Codec = context.StringValue($"QueryAnalysisJobList.AnalysisJobList[{i}].TemplateList[{j}].Video.Codec"),
                        Profile = context.StringValue($"QueryAnalysisJobList.AnalysisJobList[{i}].TemplateList[{j}].Video.Profile"),
                        Bitrate = context.StringValue($"QueryAnalysisJobList.AnalysisJobList[{i}].TemplateList[{j}].Video.Bitrate"),
                        Crf = context.StringValue($"QueryAnalysisJobList.AnalysisJobList[{i}].TemplateList[{j}].Video.Crf"),
                        Width = context.StringValue($"QueryAnalysisJobList.AnalysisJobList[{i}].TemplateList[{j}].Video.Width"),
                        Height = context.StringValue($"QueryAnalysisJobList.AnalysisJobList[{i}].TemplateList[{j}].Video.Height"),
                        Fps = context.StringValue($"QueryAnalysisJobList.AnalysisJobList[{i}].TemplateList[{j}].Video.Fps"),
                        Gop = context.StringValue($"QueryAnalysisJobList.AnalysisJobList[{i}].TemplateList[{j}].Video.Gop"),
                        Preset = context.StringValue($"QueryAnalysisJobList.AnalysisJobList[{i}].TemplateList[{j}].Video.Preset"),
                        ScanMode = context.StringValue($"QueryAnalysisJobList.AnalysisJobList[{i}].TemplateList[{j}].Video.ScanMode"),
                        Bufsize = context.StringValue($"QueryAnalysisJobList.AnalysisJobList[{i}].TemplateList[{j}].Video.Bufsize"),
                        Maxrate = context.StringValue($"QueryAnalysisJobList.AnalysisJobList[{i}].TemplateList[{j}].Video.Maxrate"),
                        PixFmt = context.StringValue($"QueryAnalysisJobList.AnalysisJobList[{i}].TemplateList[{j}].Video.PixFmt"),
                        Degrain = context.StringValue($"QueryAnalysisJobList.AnalysisJobList[{i}].TemplateList[{j}].Video.Degrain"),
                        Qscale = context.StringValue($"QueryAnalysisJobList.AnalysisJobList[{i}].TemplateList[{j}].Video.Qscale")
                    };
                    QueryAnalysisJobListResponse.AnalysisJob.Template.Video_.BitrateBnd_ bitrateBnd = new QueryAnalysisJobListResponse.AnalysisJob.Template.Video_.BitrateBnd_()
                    {
                        Max = context.StringValue($"QueryAnalysisJobList.AnalysisJobList[{i}].TemplateList[{j}].Video.BitrateBnd.Max"),
                        Min = context.StringValue($"QueryAnalysisJobList.AnalysisJobList[{i}].TemplateList[{j}].Video.BitrateBnd.Min")
                    };
                    video.BitrateBnd = bitrateBnd;
					template.Video = video;

                    QueryAnalysisJobListResponse.AnalysisJob.Template.Audio_ audio = new QueryAnalysisJobListResponse.AnalysisJob.Template.Audio_()
                    {
                        Codec = context.StringValue($"QueryAnalysisJobList.AnalysisJobList[{i}].TemplateList[{j}].Audio.Codec"),
                        Profile = context.StringValue($"QueryAnalysisJobList.AnalysisJobList[{i}].TemplateList[{j}].Audio.Profile"),
                        Samplerate = context.StringValue($"QueryAnalysisJobList.AnalysisJobList[{i}].TemplateList[{j}].Audio.Samplerate"),
                        Bitrate = context.StringValue($"QueryAnalysisJobList.AnalysisJobList[{i}].TemplateList[{j}].Audio.Bitrate"),
                        Channels = context.StringValue($"QueryAnalysisJobList.AnalysisJobList[{i}].TemplateList[{j}].Audio.Channels"),
                        Qscale = context.StringValue($"QueryAnalysisJobList.AnalysisJobList[{i}].TemplateList[{j}].Audio.Qscale")
                    };
                    template.Audio = audio;

                    QueryAnalysisJobListResponse.AnalysisJob.Template.TransConfig_ transConfig = new QueryAnalysisJobListResponse.AnalysisJob.Template.TransConfig_()
                    {
                        TransMode = context.StringValue($"QueryAnalysisJobList.AnalysisJobList[{i}].TemplateList[{j}].TransConfig.TransMode")
                    };
                    template.TransConfig = transConfig;

					QueryAnalysisJobListResponse.AnalysisJob.Template.MuxConfig_ muxConfig = new QueryAnalysisJobListResponse.AnalysisJob.Template.MuxConfig_();

                    QueryAnalysisJobListResponse.AnalysisJob.Template.MuxConfig_.Segment_ segment = new QueryAnalysisJobListResponse.AnalysisJob.Template.MuxConfig_.Segment_()
                    {
                        Duration = context.StringValue($"QueryAnalysisJobList.AnalysisJobList[{i}].TemplateList[{j}].MuxConfig.Segment.Duration")
                    };
                    muxConfig.Segment = segment;

                    QueryAnalysisJobListResponse.AnalysisJob.Template.MuxConfig_.Gif_ gif = new QueryAnalysisJobListResponse.AnalysisJob.Template.MuxConfig_.Gif_()
                    {
                        Loop = context.StringValue($"QueryAnalysisJobList.AnalysisJobList[{i}].TemplateList[{j}].MuxConfig.Gif.Loop"),
                        FinalDelay = context.StringValue($"QueryAnalysisJobList.AnalysisJobList[{i}].TemplateList[{j}].MuxConfig.Gif.FinalDelay")
                    };
                    muxConfig.Gif = gif;
					template.MuxConfig = muxConfig;

					templateList.Add(template);
				}
				analysisJob.TemplateList = templateList;

				analysisJobList.Add(analysisJob);
			}
			queryAnalysisJobListResponse.AnalysisJobList = analysisJobList;
        
			return queryAnalysisJobListResponse;
        }
    }
}