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
using Aliyun.Acs.live.Model.V20161101;

namespace Aliyun.Acs.live.Transform.V20161101
{
    public class DescribeToutiaoLivePlayResponseUnmarshaller
    {
        public static DescribeToutiaoLivePlayResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeToutiaoLivePlayResponse describeToutiaoLivePlayResponse = new DescribeToutiaoLivePlayResponse();

			describeToutiaoLivePlayResponse.HttpResponse = _ctx.HttpResponse;
			describeToutiaoLivePlayResponse.Description = _ctx.StringValue("DescribeToutiaoLivePlay.Description");
			describeToutiaoLivePlayResponse.RequestId = _ctx.StringValue("DescribeToutiaoLivePlay.RequestId");

			List<DescribeToutiaoLivePlayResponse.DescribeToutiaoLivePlay_ContentItem> describeToutiaoLivePlayResponse_content = new List<DescribeToutiaoLivePlayResponse.DescribeToutiaoLivePlay_ContentItem>();
			for (int i = 0; i < _ctx.Length("DescribeToutiaoLivePlay.Content.Length"); i++) {
				DescribeToutiaoLivePlayResponse.DescribeToutiaoLivePlay_ContentItem contentItem = new DescribeToutiaoLivePlayResponse.DescribeToutiaoLivePlay_ContentItem();
				contentItem.Domain = _ctx.StringValue("DescribeToutiaoLivePlay.Content["+ i +"].Domain");
				contentItem.Bandwidth = _ctx.FloatValue("DescribeToutiaoLivePlay.Content["+ i +"].Bandwidth");
				contentItem.StreamName = _ctx.StringValue("DescribeToutiaoLivePlay.Content["+ i +"].StreamName");
				contentItem.App = _ctx.StringValue("DescribeToutiaoLivePlay.Content["+ i +"].App");
				contentItem.PlayNum = _ctx.LongValue("DescribeToutiaoLivePlay.Content["+ i +"].PlayNum");
				contentItem.Timestamp = _ctx.LongValue("DescribeToutiaoLivePlay.Content["+ i +"].Timestamp");
				contentItem.CdnName = _ctx.StringValue("DescribeToutiaoLivePlay.Content["+ i +"].CdnName");

				describeToutiaoLivePlayResponse_content.Add(contentItem);
			}
			describeToutiaoLivePlayResponse.Content = describeToutiaoLivePlayResponse_content;
        
			return describeToutiaoLivePlayResponse;
        }
    }
}
