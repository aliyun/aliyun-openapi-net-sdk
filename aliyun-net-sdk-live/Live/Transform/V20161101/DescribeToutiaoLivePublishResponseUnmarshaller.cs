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
    public class DescribeToutiaoLivePublishResponseUnmarshaller
    {
        public static DescribeToutiaoLivePublishResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeToutiaoLivePublishResponse describeToutiaoLivePublishResponse = new DescribeToutiaoLivePublishResponse();

			describeToutiaoLivePublishResponse.HttpResponse = _ctx.HttpResponse;
			describeToutiaoLivePublishResponse.Description = _ctx.StringValue("DescribeToutiaoLivePublish.Description");
			describeToutiaoLivePublishResponse.RequestId = _ctx.StringValue("DescribeToutiaoLivePublish.RequestId");

			List<DescribeToutiaoLivePublishResponse.DescribeToutiaoLivePublish_ContentItem> describeToutiaoLivePublishResponse_content = new List<DescribeToutiaoLivePublishResponse.DescribeToutiaoLivePublish_ContentItem>();
			for (int i = 0; i < _ctx.Length("DescribeToutiaoLivePublish.Content.Length"); i++) {
				DescribeToutiaoLivePublishResponse.DescribeToutiaoLivePublish_ContentItem contentItem = new DescribeToutiaoLivePublishResponse.DescribeToutiaoLivePublish_ContentItem();
				contentItem.Domain = _ctx.StringValue("DescribeToutiaoLivePublish.Content["+ i +"].Domain");
				contentItem.StreamName = _ctx.StringValue("DescribeToutiaoLivePublish.Content["+ i +"].StreamName");
				contentItem.App = _ctx.StringValue("DescribeToutiaoLivePublish.Content["+ i +"].App");
				contentItem.Fps = _ctx.FloatValue("DescribeToutiaoLivePublish.Content["+ i +"].Fps");
				contentItem.Flr = _ctx.FloatValue("DescribeToutiaoLivePublish.Content["+ i +"].Flr");
				contentItem.Timestamp = _ctx.LongValue("DescribeToutiaoLivePublish.Content["+ i +"].Timestamp");
				contentItem.Bitrate = _ctx.FloatValue("DescribeToutiaoLivePublish.Content["+ i +"].Bitrate");
				contentItem.BwDiff = _ctx.FloatValue("DescribeToutiaoLivePublish.Content["+ i +"].BwDiff");
				contentItem.CdnName = _ctx.StringValue("DescribeToutiaoLivePublish.Content["+ i +"].CdnName");

				describeToutiaoLivePublishResponse_content.Add(contentItem);
			}
			describeToutiaoLivePublishResponse.Content = describeToutiaoLivePublishResponse_content;
        
			return describeToutiaoLivePublishResponse;
        }
    }
}
