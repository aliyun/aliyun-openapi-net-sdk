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
using Aliyun.Acs.ivpd.Model.V20190625;

namespace Aliyun.Acs.ivpd.Transform.V20190625
{
    public class HighlightGameVideoResponseUnmarshaller
    {
        public static HighlightGameVideoResponse Unmarshall(UnmarshallerContext context)
        {
			HighlightGameVideoResponse highlightGameVideoResponse = new HighlightGameVideoResponse();

			highlightGameVideoResponse.HttpResponse = context.HttpResponse;
			highlightGameVideoResponse.RequestId = context.StringValue("HighlightGameVideo.RequestId");

			HighlightGameVideoResponse.HighlightGameVideo_Data data = new HighlightGameVideoResponse.HighlightGameVideo_Data();

			List<HighlightGameVideoResponse.HighlightGameVideo_Data.HighlightGameVideo_GameListItem> data_gameList = new List<HighlightGameVideoResponse.HighlightGameVideo_Data.HighlightGameVideo_GameListItem>();
			for (int i = 0; i < context.Length("HighlightGameVideo.Data.GameList.Length"); i++) {
				HighlightGameVideoResponse.HighlightGameVideo_Data.HighlightGameVideo_GameListItem gameListItem = new HighlightGameVideoResponse.HighlightGameVideo_Data.HighlightGameVideo_GameListItem();
				gameListItem.Id = context.StringValue("HighlightGameVideo.Data.GameList["+ i +"].Id");
				gameListItem.End = context.FloatValue("HighlightGameVideo.Data.GameList["+ i +"].End");
				gameListItem.Start = context.FloatValue("HighlightGameVideo.Data.GameList["+ i +"].Start");
				gameListItem.GameInfo = context.StringValue("HighlightGameVideo.Data.GameList["+ i +"].GameInfo");

				data_gameList.Add(gameListItem);
			}
			data.GameList = data_gameList;

			List<HighlightGameVideoResponse.HighlightGameVideo_Data.HighlightGameVideo_HighlightListItem> data_highlightList = new List<HighlightGameVideoResponse.HighlightGameVideo_Data.HighlightGameVideo_HighlightListItem>();
			for (int i = 0; i < context.Length("HighlightGameVideo.Data.HighlightList.Length"); i++) {
				HighlightGameVideoResponse.HighlightGameVideo_Data.HighlightGameVideo_HighlightListItem highlightListItem = new HighlightGameVideoResponse.HighlightGameVideo_Data.HighlightGameVideo_HighlightListItem();
				highlightListItem.Start = context.FloatValue("HighlightGameVideo.Data.HighlightList["+ i +"].Start");
				highlightListItem.End = context.FloatValue("HighlightGameVideo.Data.HighlightList["+ i +"].End");

				data_highlightList.Add(highlightListItem);
			}
			data.HighlightList = data_highlightList;
			highlightGameVideoResponse.Data = data;
        
			return highlightGameVideoResponse;
        }
    }
}
