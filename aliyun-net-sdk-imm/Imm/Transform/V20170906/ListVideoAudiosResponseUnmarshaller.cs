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
using Aliyun.Acs.imm.Model.V20170906;

namespace Aliyun.Acs.imm.Transform.V20170906
{
    public class ListVideoAudiosResponseUnmarshaller
    {
        public static ListVideoAudiosResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListVideoAudiosResponse listVideoAudiosResponse = new ListVideoAudiosResponse();

			listVideoAudiosResponse.HttpResponse = _ctx.HttpResponse;
			listVideoAudiosResponse.SetId = _ctx.StringValue("ListVideoAudios.SetId");
			listVideoAudiosResponse.VideoUri = _ctx.StringValue("ListVideoAudios.VideoUri");
			listVideoAudiosResponse.NextMarker = _ctx.StringValue("ListVideoAudios.NextMarker");
			listVideoAudiosResponse.RequestId = _ctx.StringValue("ListVideoAudios.RequestId");

			List<ListVideoAudiosResponse.ListVideoAudios_AudiosItem> listVideoAudiosResponse_audios = new List<ListVideoAudiosResponse.ListVideoAudios_AudiosItem>();
			for (int i = 0; i < _ctx.Length("ListVideoAudios.Audios.Length"); i++) {
				ListVideoAudiosResponse.ListVideoAudios_AudiosItem audiosItem = new ListVideoAudiosResponse.ListVideoAudios_AudiosItem();
				audiosItem.AudioDuration = _ctx.FloatValue("ListVideoAudios.Audios["+ i +"].AudioDuration");
				audiosItem.AudioUri = _ctx.StringValue("ListVideoAudios.Audios["+ i +"].AudioUri");
				audiosItem.AudioRate = _ctx.IntegerValue("ListVideoAudios.Audios["+ i +"].AudioRate");
				audiosItem.SourceType = _ctx.StringValue("ListVideoAudios.Audios["+ i +"].SourceType");
				audiosItem.ModifyTime = _ctx.StringValue("ListVideoAudios.Audios["+ i +"].ModifyTime");
				audiosItem.FileSize = _ctx.IntegerValue("ListVideoAudios.Audios["+ i +"].FileSize");
				audiosItem.SourceUri = _ctx.StringValue("ListVideoAudios.Audios["+ i +"].SourceUri");
				audiosItem.CreateTime = _ctx.StringValue("ListVideoAudios.Audios["+ i +"].CreateTime");
				audiosItem.RemarksA = _ctx.StringValue("ListVideoAudios.Audios["+ i +"].RemarksA");
				audiosItem.RemarksB = _ctx.StringValue("ListVideoAudios.Audios["+ i +"].RemarksB");
				audiosItem.AudioTextsStatus = _ctx.StringValue("ListVideoAudios.Audios["+ i +"].AudioTextsStatus");
				audiosItem.AudioTextsModifyTime = _ctx.StringValue("ListVideoAudios.Audios["+ i +"].AudioTextsModifyTime");
				audiosItem.ProcessModifyTime = _ctx.StringValue("ListVideoAudios.Audios["+ i +"].ProcessModifyTime");
				audiosItem.ProcessStatus = _ctx.StringValue("ListVideoAudios.Audios["+ i +"].ProcessStatus");
				audiosItem.SourcePosition = _ctx.StringValue("ListVideoAudios.Audios["+ i +"].SourcePosition");
				audiosItem.AudioFormat = _ctx.StringValue("ListVideoAudios.Audios["+ i +"].AudioFormat");
				audiosItem.AudioTextsFailReason = _ctx.StringValue("ListVideoAudios.Audios["+ i +"].AudioTextsFailReason");
				audiosItem.ProcessFailReason = _ctx.StringValue("ListVideoAudios.Audios["+ i +"].ProcessFailReason");
				audiosItem.RemarksC = _ctx.StringValue("ListVideoAudios.Audios["+ i +"].RemarksC");
				audiosItem.RemarksD = _ctx.StringValue("ListVideoAudios.Audios["+ i +"].RemarksD");
				audiosItem.ExternalId = _ctx.StringValue("ListVideoAudios.Audios["+ i +"].ExternalId");

				List<ListVideoAudiosResponse.ListVideoAudios_AudiosItem.ListVideoAudios_AudioTextsItem> audiosItem_audioTexts = new List<ListVideoAudiosResponse.ListVideoAudios_AudiosItem.ListVideoAudios_AudioTextsItem>();
				for (int j = 0; j < _ctx.Length("ListVideoAudios.Audios["+ i +"].AudioTexts.Length"); j++) {
					ListVideoAudiosResponse.ListVideoAudios_AudiosItem.ListVideoAudios_AudioTextsItem audioTextsItem = new ListVideoAudiosResponse.ListVideoAudios_AudiosItem.ListVideoAudios_AudioTextsItem();
					audioTextsItem.Text = _ctx.StringValue("ListVideoAudios.Audios["+ i +"].AudioTexts["+ j +"].Text");
					audioTextsItem.BeginTime = _ctx.FloatValue("ListVideoAudios.Audios["+ i +"].AudioTexts["+ j +"].BeginTime");
					audioTextsItem.EndTime = _ctx.FloatValue("ListVideoAudios.Audios["+ i +"].AudioTexts["+ j +"].EndTime");
					audioTextsItem.SilenceDuration = _ctx.FloatValue("ListVideoAudios.Audios["+ i +"].AudioTexts["+ j +"].SilenceDuration");
					audioTextsItem.EmotionValue = _ctx.FloatValue("ListVideoAudios.Audios["+ i +"].AudioTexts["+ j +"].EmotionValue");
					audioTextsItem.ChannelId = _ctx.IntegerValue("ListVideoAudios.Audios["+ i +"].AudioTexts["+ j +"].ChannelId");
					audioTextsItem.SpeechRate = _ctx.IntegerValue("ListVideoAudios.Audios["+ i +"].AudioTexts["+ j +"].SpeechRate");
					audioTextsItem.Confidence = _ctx.FloatValue("ListVideoAudios.Audios["+ i +"].AudioTexts["+ j +"].Confidence");
					audioTextsItem.Person = _ctx.StringValue("ListVideoAudios.Audios["+ i +"].AudioTexts["+ j +"].Person");
					audioTextsItem.Library = _ctx.StringValue("ListVideoAudios.Audios["+ i +"].AudioTexts["+ j +"].Library");

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
