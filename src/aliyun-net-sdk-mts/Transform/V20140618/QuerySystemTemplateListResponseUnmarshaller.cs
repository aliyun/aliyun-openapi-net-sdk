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
    public class QuerySystemTemplateListResponseUnmarshaller
    {
        public static QuerySystemTemplateListResponse Unmarshall(UnmarshallerContext context)
        {
            QuerySystemTemplateListResponse querySystemTemplateListResponse = new QuerySystemTemplateListResponse()
            {
                HttpResponse = context.HttpResponse,
                RequestId = context.StringValue("QuerySystemTemplateList.RequestId")
            };
            List<string> nonExistTids = new List<string>();
			for (int i = 0; i < context.Length("QuerySystemTemplateList.NonExistTids.Length"); i++) {
				nonExistTids.Add(context.StringValue($"QuerySystemTemplateList.NonExistTids[{i}]"));
			}
			querySystemTemplateListResponse.NonExistTids = nonExistTids;

			List<QuerySystemTemplateListResponse.Template> templateList = new List<QuerySystemTemplateListResponse.Template>();
			for (int i = 0; i < context.Length("QuerySystemTemplateList.TemplateList.Length"); i++) {
                QuerySystemTemplateListResponse.Template template = new QuerySystemTemplateListResponse.Template()
                {
                    Id = context.StringValue($"QuerySystemTemplateList.TemplateList[{i}].Id"),
                    Name = context.StringValue($"QuerySystemTemplateList.TemplateList[{i}].Name"),
                    State = context.StringValue($"QuerySystemTemplateList.TemplateList[{i}].State")
                };
                QuerySystemTemplateListResponse.Template.Container_ container = new QuerySystemTemplateListResponse.Template.Container_()
                {
                    Format = context.StringValue($"QuerySystemTemplateList.TemplateList[{i}].Container.Format")
                };
                template.Container = container;

                QuerySystemTemplateListResponse.Template.Video_ video = new QuerySystemTemplateListResponse.Template.Video_()
                {
                    Codec = context.StringValue($"QuerySystemTemplateList.TemplateList[{i}].Video.Codec"),
                    Profile = context.StringValue($"QuerySystemTemplateList.TemplateList[{i}].Video.Profile"),
                    Bitrate = context.StringValue($"QuerySystemTemplateList.TemplateList[{i}].Video.Bitrate"),
                    Crf = context.StringValue($"QuerySystemTemplateList.TemplateList[{i}].Video.Crf"),
                    Width = context.StringValue($"QuerySystemTemplateList.TemplateList[{i}].Video.Width"),
                    Height = context.StringValue($"QuerySystemTemplateList.TemplateList[{i}].Video.Height"),
                    Fps = context.StringValue($"QuerySystemTemplateList.TemplateList[{i}].Video.Fps"),
                    Gop = context.StringValue($"QuerySystemTemplateList.TemplateList[{i}].Video.Gop"),
                    Preset = context.StringValue($"QuerySystemTemplateList.TemplateList[{i}].Video.Preset"),
                    ScanMode = context.StringValue($"QuerySystemTemplateList.TemplateList[{i}].Video.ScanMode"),
                    Bufsize = context.StringValue($"QuerySystemTemplateList.TemplateList[{i}].Video.Bufsize"),
                    Maxrate = context.StringValue($"QuerySystemTemplateList.TemplateList[{i}].Video.Maxrate"),
                    PixFmt = context.StringValue($"QuerySystemTemplateList.TemplateList[{i}].Video.PixFmt"),
                    Degrain = context.StringValue($"QuerySystemTemplateList.TemplateList[{i}].Video.Degrain"),
                    Qscale = context.StringValue($"QuerySystemTemplateList.TemplateList[{i}].Video.Qscale"),
                    Remove = context.StringValue($"QuerySystemTemplateList.TemplateList[{i}].Video.Remove")
                };
                QuerySystemTemplateListResponse.Template.Video_.BitrateBnd_ bitrateBnd = new QuerySystemTemplateListResponse.Template.Video_.BitrateBnd_()
                {
                    Max = context.StringValue($"QuerySystemTemplateList.TemplateList[{i}].Video.BitrateBnd.Max"),
                    Min = context.StringValue($"QuerySystemTemplateList.TemplateList[{i}].Video.BitrateBnd.Min")
                };
                video.BitrateBnd = bitrateBnd;
				template.Video = video;

                QuerySystemTemplateListResponse.Template.Audio_ audio = new QuerySystemTemplateListResponse.Template.Audio_()
                {
                    Codec = context.StringValue($"QuerySystemTemplateList.TemplateList[{i}].Audio.Codec"),
                    Profile = context.StringValue($"QuerySystemTemplateList.TemplateList[{i}].Audio.Profile"),
                    Samplerate = context.StringValue($"QuerySystemTemplateList.TemplateList[{i}].Audio.Samplerate"),
                    Bitrate = context.StringValue($"QuerySystemTemplateList.TemplateList[{i}].Audio.Bitrate"),
                    Channels = context.StringValue($"QuerySystemTemplateList.TemplateList[{i}].Audio.Channels"),
                    Qscale = context.StringValue($"QuerySystemTemplateList.TemplateList[{i}].Audio.Qscale"),
                    Remove = context.StringValue($"QuerySystemTemplateList.TemplateList[{i}].Audio.Remove")
                };
                template.Audio = audio;

                QuerySystemTemplateListResponse.Template.TransConfig_ transConfig = new QuerySystemTemplateListResponse.Template.TransConfig_()
                {
                    TransMode = context.StringValue($"QuerySystemTemplateList.TemplateList[{i}].TransConfig.TransMode")
                };
                template.TransConfig = transConfig;

				QuerySystemTemplateListResponse.Template.MuxConfig_ muxConfig = new QuerySystemTemplateListResponse.Template.MuxConfig_();

                QuerySystemTemplateListResponse.Template.MuxConfig_.Segment_ segment = new QuerySystemTemplateListResponse.Template.MuxConfig_.Segment_()
                {
                    Duration = context.StringValue($"QuerySystemTemplateList.TemplateList[{i}].MuxConfig.Segment.Duration")
                };
                muxConfig.Segment = segment;

                QuerySystemTemplateListResponse.Template.MuxConfig_.Gif_ gif = new QuerySystemTemplateListResponse.Template.MuxConfig_.Gif_()
                {
                    Loop = context.StringValue($"QuerySystemTemplateList.TemplateList[{i}].MuxConfig.Gif.Loop"),
                    FinalDelay = context.StringValue($"QuerySystemTemplateList.TemplateList[{i}].MuxConfig.Gif.FinalDelay")
                };
                muxConfig.Gif = gif;
				template.MuxConfig = muxConfig;

				templateList.Add(template);
			}
			querySystemTemplateListResponse.TemplateList = templateList;
        
			return querySystemTemplateListResponse;
        }
    }
}