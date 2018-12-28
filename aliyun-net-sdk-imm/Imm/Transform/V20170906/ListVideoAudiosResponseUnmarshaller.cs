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
using Aliyun.Acs.imm.Model.V20170906;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.imm.Transform.V20170906
{
    public class ListVideoAudiosResponseUnmarshaller
    {
        public static ListVideoAudiosResponse Unmarshall(UnmarshallerContext context)
        {
			ListVideoAudiosResponse listVideoAudiosResponse = new ListVideoAudiosResponse();

			listVideoAudiosResponse.HttpResponse = context.HttpResponse;
			listVideoAudiosResponse.SetId = context.StringValue("ListVideoAudios.SetId");
			listVideoAudiosResponse.VideoUri = context.StringValue("ListVideoAudios.VideoUri");
			listVideoAudiosResponse.NextMarker = context.StringValue("ListVideoAudios.NextMarker");
			listVideoAudiosResponse.RequestId = context.StringValue("ListVideoAudios.RequestId");

			List<ListVideoAudiosResponse.ListVideoAudios_AudiosItem> listVideoAudiosResponse_audios = new List<ListVideoAudiosResponse.ListVideoAudios_AudiosItem>();
			for (int i = 0; i < context.Length("ListVideoAudios.Audios.Length"); i++) {
				ListVideoAudiosResponse.ListVideoAudios_AudiosItem audiosItem = new ListVideoAudiosResponse.ListVideoAudios_AudiosItem();
				audiosItem.AudioDuration = context.FloatValue("ListVideoAudios.Audios["+ i +"].AudioDuration");
				audiosItem.AudioUri = context.StringValue("ListVideoAudios.Audios["+ i +"].AudioUri");
				audiosItem.AudioRate = context.IntegerValue("ListVideoAudios.Audios["+ i +"].AudioRate");
				audiosItem.SourceType = context.StringValue("ListVideoAudios.Audios["+ i +"].SourceType");
				audiosItem.ModifyTime = context.StringValue("ListVideoAudios.Audios["+ i +"].ModifyTime");
				audiosItem.FileSize = context.IntegerValue("ListVideoAudios.Audios["+ i +"].FileSize");
				audiosItem.SourceUri = context.StringValue("ListVideoAudios.Audios["+ i +"].SourceUri");
				audiosItem.CreateTime = context.StringValue("ListVideoAudios.Audios["+ i +"].CreateTime");
				audiosItem.RemarksA = context.StringValue("ListVideoAudios.Audios["+ i +"].RemarksA");
				audiosItem.RemarksB = context.StringValue("ListVideoAudios.Audios["+ i +"].RemarksB");
				audiosItem.AudioTextsStatus = context.StringValue("ListVideoAudios.Audios["+ i +"].AudioTextsStatus");
				audiosItem.AudioTextsModifyTime = context.StringValue("ListVideoAudios.Audios["+ i +"].AudioTextsModifyTime");
				audiosItem.ProcessModifyTime = context.StringValue("ListVideoAudios.Audios["+ i +"].ProcessModifyTime");
				audiosItem.ProcessStatus = context.StringValue("ListVideoAudios.Audios["+ i +"].ProcessStatus");
				audiosItem.SourcePosition = context.StringValue("ListVideoAudios.Audios["+ i +"].SourcePosition");
				audiosItem.AudioFormat = context.StringValue("ListVideoAudios.Audios["+ i +"].AudioFormat");
				audiosItem.AudioTextsFailReason = context.StringValue("ListVideoAudios.Audios["+ i +"].AudioTextsFailReason");
				audiosItem.ProcessFailReason = context.StringValue("ListVideoAudios.Audios["+ i +"].ProcessFailReason");

				List<ListVideoAudiosResponse.ListVideoAudios_AudiosItem.ListVideoAudios_AudioTextsItem> audiosItem_audioTexts = new List<ListVideoAudiosResponse.ListVideoAudios_AudiosItem.ListVideoAudios_AudioTextsItem>();
				for (int j = 0; j < context.Length("ListVideoAudios.Audios["+ i +"].AudioTexts.Length"); j++) {
					ListVideoAudiosResponse.ListVideoAudios_AudiosItem.ListVideoAudios_AudioTextsItem audioTextsItem = new ListVideoAudiosResponse.ListVideoAudios_AudiosItem.ListVideoAudios_AudioTextsItem();
					audioTextsItem.Text = context.StringValue("ListVideoAudios.Audios["+ i +"].AudioTexts["+ j +"].Text");
					audioTextsItem.BeginTime = context.FloatValue("ListVideoAudios.Audios["+ i +"].AudioTexts["+ j +"].BeginTime");
					audioTextsItem.EndTime = context.FloatValue("ListVideoAudios.Audios["+ i +"].AudioTexts["+ j +"].EndTime");
					audioTextsItem.SilenceDuration = context.FloatValue("ListVideoAudios.Audios["+ i +"].AudioTexts["+ j +"].SilenceDuration");
					audioTextsItem.EmotionValue = context.FloatValue("ListVideoAudios.Audios["+ i +"].AudioTexts["+ j +"].EmotionValue");
					audioTextsItem.ChannelId = context.IntegerValue("ListVideoAudios.Audios["+ i +"].AudioTexts["+ j +"].ChannelId");
					audioTextsItem.SpeechRate = context.IntegerValue("ListVideoAudios.Audios["+ i +"].AudioTexts["+ j +"].SpeechRate");
					audioTextsItem.Confidence = context.FloatValue("ListVideoAudios.Audios["+ i +"].AudioTexts["+ j +"].Confidence");
					audioTextsItem.Person = context.StringValue("ListVideoAudios.Audios["+ i +"].AudioTexts["+ j +"].Person");
					audioTextsItem.Library = context.StringValue("ListVideoAudios.Audios["+ i +"].AudioTexts["+ j +"].Library");

					audiosItem_audioTexts.Add(audioTextsItem);
				}
				audiosItem.AudioTexts = audiosItem_audioTexts;

				listVideoAudiosResponse_audios.Add(audiosItem);
			}
			listVideoAudiosResponse.Audios = listVideoAudiosResponse_audios;
        
			return listVideoAudiosResponse;
        }
    }
}