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
    public class GetAIVideoTagResultResponseUnmarshaller
    {
        public static GetAIVideoTagResultResponse Unmarshall(UnmarshallerContext context)
        {
			GetAIVideoTagResultResponse getAIVideoTagResultResponse = new GetAIVideoTagResultResponse();

			getAIVideoTagResultResponse.HttpResponse = context.HttpResponse;
			getAIVideoTagResultResponse.RequestId = context.StringValue("GetAIVideoTagResult.RequestId");

			GetAIVideoTagResultResponse.GetAIVideoTagResult_VideoTagResult videoTagResult = new GetAIVideoTagResultResponse.GetAIVideoTagResult_VideoTagResult();

			List<GetAIVideoTagResultResponse.GetAIVideoTagResult_VideoTagResult.GetAIVideoTagResult_CategoryItem> videoTagResult_category = new List<GetAIVideoTagResultResponse.GetAIVideoTagResult_VideoTagResult.GetAIVideoTagResult_CategoryItem>();
			for (int i = 0; i < context.Length("GetAIVideoTagResult.VideoTagResult.Category.Length"); i++) {
				GetAIVideoTagResultResponse.GetAIVideoTagResult_VideoTagResult.GetAIVideoTagResult_CategoryItem categoryItem = new GetAIVideoTagResultResponse.GetAIVideoTagResult_VideoTagResult.GetAIVideoTagResult_CategoryItem();
				categoryItem.Tag = context.StringValue("GetAIVideoTagResult.VideoTagResult.Category["+ i +"].Tag");

				videoTagResult_category.Add(categoryItem);
			}
			videoTagResult.Category = videoTagResult_category;

			List<GetAIVideoTagResultResponse.GetAIVideoTagResult_VideoTagResult.GetAIVideoTagResult_PersonItem> videoTagResult_person = new List<GetAIVideoTagResultResponse.GetAIVideoTagResult_VideoTagResult.GetAIVideoTagResult_PersonItem>();
			for (int i = 0; i < context.Length("GetAIVideoTagResult.VideoTagResult.Person.Length"); i++) {
				GetAIVideoTagResultResponse.GetAIVideoTagResult_VideoTagResult.GetAIVideoTagResult_PersonItem personItem = new GetAIVideoTagResultResponse.GetAIVideoTagResult_VideoTagResult.GetAIVideoTagResult_PersonItem();
				personItem.FaceUrl = context.StringValue("GetAIVideoTagResult.VideoTagResult.Person["+ i +"].FaceUrl");
				personItem.Tag = context.StringValue("GetAIVideoTagResult.VideoTagResult.Person["+ i +"].Tag");

				List<string> personItem_times = new List<string>();
				for (int j = 0; j < context.Length("GetAIVideoTagResult.VideoTagResult.Person["+ i +"].Times.Length"); j++) {
					personItem_times.Add(context.StringValue("GetAIVideoTagResult.VideoTagResult.Person["+ i +"].Times["+ j +"]"));
				}
				personItem.Times = personItem_times;

				videoTagResult_person.Add(personItem);
			}
			videoTagResult.Person = videoTagResult_person;

			List<GetAIVideoTagResultResponse.GetAIVideoTagResult_VideoTagResult.GetAIVideoTagResult_TimeItem> videoTagResult_time = new List<GetAIVideoTagResultResponse.GetAIVideoTagResult_VideoTagResult.GetAIVideoTagResult_TimeItem>();
			for (int i = 0; i < context.Length("GetAIVideoTagResult.VideoTagResult.Time.Length"); i++) {
				GetAIVideoTagResultResponse.GetAIVideoTagResult_VideoTagResult.GetAIVideoTagResult_TimeItem timeItem = new GetAIVideoTagResultResponse.GetAIVideoTagResult_VideoTagResult.GetAIVideoTagResult_TimeItem();
				timeItem.Tag = context.StringValue("GetAIVideoTagResult.VideoTagResult.Time["+ i +"].Tag");

				List<string> timeItem_times1 = new List<string>();
				for (int j = 0; j < context.Length("GetAIVideoTagResult.VideoTagResult.Time["+ i +"].Times.Length"); j++) {
					timeItem_times1.Add(context.StringValue("GetAIVideoTagResult.VideoTagResult.Time["+ i +"].Times["+ j +"]"));
				}
				timeItem.Times1 = timeItem_times1;

				videoTagResult_time.Add(timeItem);
			}
			videoTagResult.Time = videoTagResult_time;

			List<GetAIVideoTagResultResponse.GetAIVideoTagResult_VideoTagResult.GetAIVideoTagResult_LocationItem> videoTagResult_location = new List<GetAIVideoTagResultResponse.GetAIVideoTagResult_VideoTagResult.GetAIVideoTagResult_LocationItem>();
			for (int i = 0; i < context.Length("GetAIVideoTagResult.VideoTagResult.Location.Length"); i++) {
				GetAIVideoTagResultResponse.GetAIVideoTagResult_VideoTagResult.GetAIVideoTagResult_LocationItem locationItem = new GetAIVideoTagResultResponse.GetAIVideoTagResult_VideoTagResult.GetAIVideoTagResult_LocationItem();
				locationItem.Tag = context.StringValue("GetAIVideoTagResult.VideoTagResult.Location["+ i +"].Tag");

				List<string> locationItem_times2 = new List<string>();
				for (int j = 0; j < context.Length("GetAIVideoTagResult.VideoTagResult.Location["+ i +"].Times.Length"); j++) {
					locationItem_times2.Add(context.StringValue("GetAIVideoTagResult.VideoTagResult.Location["+ i +"].Times["+ j +"]"));
				}
				locationItem.Times2 = locationItem_times2;

				videoTagResult_location.Add(locationItem);
			}
			videoTagResult.Location = videoTagResult_location;

			List<GetAIVideoTagResultResponse.GetAIVideoTagResult_VideoTagResult.GetAIVideoTagResult_KeywordItem> videoTagResult_keyword = new List<GetAIVideoTagResultResponse.GetAIVideoTagResult_VideoTagResult.GetAIVideoTagResult_KeywordItem>();
			for (int i = 0; i < context.Length("GetAIVideoTagResult.VideoTagResult.Keyword.Length"); i++) {
				GetAIVideoTagResultResponse.GetAIVideoTagResult_VideoTagResult.GetAIVideoTagResult_KeywordItem keywordItem = new GetAIVideoTagResultResponse.GetAIVideoTagResult_VideoTagResult.GetAIVideoTagResult_KeywordItem();
				keywordItem.Tag = context.StringValue("GetAIVideoTagResult.VideoTagResult.Keyword["+ i +"].Tag");

				List<string> keywordItem_times3 = new List<string>();
				for (int j = 0; j < context.Length("GetAIVideoTagResult.VideoTagResult.Keyword["+ i +"].Times.Length"); j++) {
					keywordItem_times3.Add(context.StringValue("GetAIVideoTagResult.VideoTagResult.Keyword["+ i +"].Times["+ j +"]"));
				}
				keywordItem.Times3 = keywordItem_times3;

				videoTagResult_keyword.Add(keywordItem);
			}
			videoTagResult.Keyword = videoTagResult_keyword;
			getAIVideoTagResultResponse.VideoTagResult = videoTagResult;
        
			return getAIVideoTagResultResponse;
        }
    }
}
