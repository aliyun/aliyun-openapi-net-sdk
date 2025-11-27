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
using Aliyun.Acs.EduInterpreting.Model.V20240828;

namespace Aliyun.Acs.EduInterpreting.Transform.V20240828
{
    public class RecognizeAudioResponseUnmarshaller
    {
        public static RecognizeAudioResponse Unmarshall(UnmarshallerContext _ctx)
        {
			RecognizeAudioResponse recognizeAudioResponse = new RecognizeAudioResponse();

			recognizeAudioResponse.HttpResponse = _ctx.HttpResponse;
			recognizeAudioResponse.RequestId = _ctx.StringValue("RecognizeAudio.RequestId");
			recognizeAudioResponse.TaskId = _ctx.StringValue("RecognizeAudio.TaskId");

			List<RecognizeAudioResponse.RecognizeAudio_ItemListItem> recognizeAudioResponse_itemList = new List<RecognizeAudioResponse.RecognizeAudio_ItemListItem>();
			for (int i = 0; i < _ctx.Length("RecognizeAudio.ItemList.Length"); i++) {
				RecognizeAudioResponse.RecognizeAudio_ItemListItem itemListItem = new RecognizeAudioResponse.RecognizeAudio_ItemListItem();
				itemListItem.BeginTime = _ctx.StringValue("RecognizeAudio.ItemList["+ i +"].BeginTime");
				itemListItem.EndTime = _ctx.StringValue("RecognizeAudio.ItemList["+ i +"].EndTime");
				itemListItem.Text = _ctx.StringValue("RecognizeAudio.ItemList["+ i +"].Text");

				recognizeAudioResponse_itemList.Add(itemListItem);
			}
			recognizeAudioResponse.ItemList = recognizeAudioResponse_itemList;
        
			return recognizeAudioResponse;
        }
    }
}
