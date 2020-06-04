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
using Aliyun.Acs.vod.Model.V20170321;

namespace Aliyun.Acs.vod.Transform.V20170321
{
    public class GetTranscodeTemplateGroupResponseUnmarshaller
    {
        public static GetTranscodeTemplateGroupResponse Unmarshall(UnmarshallerContext context)
        {
			GetTranscodeTemplateGroupResponse getTranscodeTemplateGroupResponse = new GetTranscodeTemplateGroupResponse();

			getTranscodeTemplateGroupResponse.HttpResponse = context.HttpResponse;
			getTranscodeTemplateGroupResponse.RequestId = context.StringValue("GetTranscodeTemplateGroup.RequestId");

			GetTranscodeTemplateGroupResponse.GetTranscodeTemplateGroup_TranscodeTemplateGroup transcodeTemplateGroup = new GetTranscodeTemplateGroupResponse.GetTranscodeTemplateGroup_TranscodeTemplateGroup();
			transcodeTemplateGroup.CreationTime = context.StringValue("GetTranscodeTemplateGroup.TranscodeTemplateGroup.CreationTime");
			transcodeTemplateGroup.ModifyTime = context.StringValue("GetTranscodeTemplateGroup.TranscodeTemplateGroup.ModifyTime");
			transcodeTemplateGroup.Name = context.StringValue("GetTranscodeTemplateGroup.TranscodeTemplateGroup.Name");
			transcodeTemplateGroup.IsDefault = context.StringValue("GetTranscodeTemplateGroup.TranscodeTemplateGroup.IsDefault");
			transcodeTemplateGroup.Locked = context.StringValue("GetTranscodeTemplateGroup.TranscodeTemplateGroup.Locked");
			transcodeTemplateGroup.TranscodeMode = context.StringValue("GetTranscodeTemplateGroup.TranscodeTemplateGroup.TranscodeMode");
			transcodeTemplateGroup.AppId = context.StringValue("GetTranscodeTemplateGroup.TranscodeTemplateGroup.AppId");
			transcodeTemplateGroup.TranscodeTemplateGroupId = context.StringValue("GetTranscodeTemplateGroup.TranscodeTemplateGroup.TranscodeTemplateGroupId");

			List<GetTranscodeTemplateGroupResponse.GetTranscodeTemplateGroup_TranscodeTemplateGroup.GetTranscodeTemplateGroup_TranscodeTemplate> transcodeTemplateGroup_transcodeTemplateList = new List<GetTranscodeTemplateGroupResponse.GetTranscodeTemplateGroup_TranscodeTemplateGroup.GetTranscodeTemplateGroup_TranscodeTemplate>();
			for (int i = 0; i < context.Length("GetTranscodeTemplateGroup.TranscodeTemplateGroup.TranscodeTemplateList.Length"); i++) {
				GetTranscodeTemplateGroupResponse.GetTranscodeTemplateGroup_TranscodeTemplateGroup.GetTranscodeTemplateGroup_TranscodeTemplate transcodeTemplate = new GetTranscodeTemplateGroupResponse.GetTranscodeTemplateGroup_TranscodeTemplateGroup.GetTranscodeTemplateGroup_TranscodeTemplate();
				transcodeTemplate.TranscodeTemplateId = context.StringValue("GetTranscodeTemplateGroup.TranscodeTemplateGroup.TranscodeTemplateList["+ i +"].TranscodeTemplateId");
				transcodeTemplate.Video = context.StringValue("GetTranscodeTemplateGroup.TranscodeTemplateGroup.TranscodeTemplateList["+ i +"].Video");
				transcodeTemplate.Audio = context.StringValue("GetTranscodeTemplateGroup.TranscodeTemplateGroup.TranscodeTemplateList["+ i +"].Audio");
				transcodeTemplate.Container = context.StringValue("GetTranscodeTemplateGroup.TranscodeTemplateGroup.TranscodeTemplateList["+ i +"].Container");
				transcodeTemplate.MuxConfig = context.StringValue("GetTranscodeTemplateGroup.TranscodeTemplateGroup.TranscodeTemplateList["+ i +"].MuxConfig");
				transcodeTemplate.TransConfig = context.StringValue("GetTranscodeTemplateGroup.TranscodeTemplateGroup.TranscodeTemplateList["+ i +"].TransConfig");
				transcodeTemplate.Definition = context.StringValue("GetTranscodeTemplateGroup.TranscodeTemplateGroup.TranscodeTemplateList["+ i +"].Definition");
				transcodeTemplate.EncryptSetting = context.StringValue("GetTranscodeTemplateGroup.TranscodeTemplateGroup.TranscodeTemplateList["+ i +"].EncryptSetting");
				transcodeTemplate.PackageSetting = context.StringValue("GetTranscodeTemplateGroup.TranscodeTemplateGroup.TranscodeTemplateList["+ i +"].PackageSetting");
				transcodeTemplate.SubtitleList = context.StringValue("GetTranscodeTemplateGroup.TranscodeTemplateGroup.TranscodeTemplateList["+ i +"].SubtitleList");
				transcodeTemplate.OpeningList = context.StringValue("GetTranscodeTemplateGroup.TranscodeTemplateGroup.TranscodeTemplateList["+ i +"].OpeningList");
				transcodeTemplate.TailSlateList = context.StringValue("GetTranscodeTemplateGroup.TranscodeTemplateGroup.TranscodeTemplateList["+ i +"].TailSlateList");
				transcodeTemplate.TemplateName = context.StringValue("GetTranscodeTemplateGroup.TranscodeTemplateGroup.TranscodeTemplateList["+ i +"].TemplateName");
				transcodeTemplate.TranscodeFileRegular = context.StringValue("GetTranscodeTemplateGroup.TranscodeTemplateGroup.TranscodeTemplateList["+ i +"].TranscodeFileRegular");
				transcodeTemplate.Clip = context.StringValue("GetTranscodeTemplateGroup.TranscodeTemplateGroup.TranscodeTemplateList["+ i +"].Clip");
				transcodeTemplate.Rotate = context.StringValue("GetTranscodeTemplateGroup.TranscodeTemplateGroup.TranscodeTemplateList["+ i +"].Rotate");
				transcodeTemplate.Type = context.StringValue("GetTranscodeTemplateGroup.TranscodeTemplateGroup.TranscodeTemplateList["+ i +"].Type");
				transcodeTemplate.UserData = context.StringValue("GetTranscodeTemplateGroup.TranscodeTemplateGroup.TranscodeTemplateList["+ i +"].UserData");

				List<string> transcodeTemplate_watermarkIds = new List<string>();
				for (int j = 0; j < context.Length("GetTranscodeTemplateGroup.TranscodeTemplateGroup.TranscodeTemplateList["+ i +"].WatermarkIds.Length"); j++) {
					transcodeTemplate_watermarkIds.Add(context.StringValue("GetTranscodeTemplateGroup.TranscodeTemplateGroup.TranscodeTemplateList["+ i +"].WatermarkIds["+ j +"]"));
				}
				transcodeTemplate.WatermarkIds = transcodeTemplate_watermarkIds;

				transcodeTemplateGroup_transcodeTemplateList.Add(transcodeTemplate);
			}
			transcodeTemplateGroup.TranscodeTemplateList = transcodeTemplateGroup_transcodeTemplateList;
			getTranscodeTemplateGroupResponse.TranscodeTemplateGroup = transcodeTemplateGroup;
        
			return getTranscodeTemplateGroupResponse;
        }
    }
}
