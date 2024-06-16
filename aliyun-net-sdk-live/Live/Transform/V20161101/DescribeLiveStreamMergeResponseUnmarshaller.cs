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
    public class DescribeLiveStreamMergeResponseUnmarshaller
    {
        public static DescribeLiveStreamMergeResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeLiveStreamMergeResponse describeLiveStreamMergeResponse = new DescribeLiveStreamMergeResponse();

			describeLiveStreamMergeResponse.HttpResponse = _ctx.HttpResponse;
			describeLiveStreamMergeResponse.RequestId = _ctx.StringValue("DescribeLiveStreamMerge.RequestId");

			List<DescribeLiveStreamMergeResponse.DescribeLiveStreamMerge_LiveStreamMerge> describeLiveStreamMergeResponse_liveStreamMergeList = new List<DescribeLiveStreamMergeResponse.DescribeLiveStreamMerge_LiveStreamMerge>();
			for (int i = 0; i < _ctx.Length("DescribeLiveStreamMerge.LiveStreamMergeList.Length"); i++) {
				DescribeLiveStreamMergeResponse.DescribeLiveStreamMerge_LiveStreamMerge liveStreamMerge = new DescribeLiveStreamMergeResponse.DescribeLiveStreamMerge_LiveStreamMerge();
				liveStreamMerge.AppName = _ctx.StringValue("DescribeLiveStreamMerge.LiveStreamMergeList["+ i +"].AppName");
				liveStreamMerge.AppUsing = _ctx.StringValue("DescribeLiveStreamMerge.LiveStreamMergeList["+ i +"].AppUsing");
				liveStreamMerge.DomainName = _ctx.StringValue("DescribeLiveStreamMerge.LiveStreamMergeList["+ i +"].DomainName");
				liveStreamMerge.EndTime = _ctx.StringValue("DescribeLiveStreamMerge.LiveStreamMergeList["+ i +"].EndTime");
				liveStreamMerge.ExtraInAppStreams = _ctx.StringValue("DescribeLiveStreamMerge.LiveStreamMergeList["+ i +"].ExtraInAppStreams");
				liveStreamMerge.InAppName1 = _ctx.StringValue("DescribeLiveStreamMerge.LiveStreamMergeList["+ i +"].InAppName1");
				liveStreamMerge.InAppName2 = _ctx.StringValue("DescribeLiveStreamMerge.LiveStreamMergeList["+ i +"].InAppName2");
				liveStreamMerge.InStreamName1 = _ctx.StringValue("DescribeLiveStreamMerge.LiveStreamMergeList["+ i +"].InStreamName1");
				liveStreamMerge.InStreamName2 = _ctx.StringValue("DescribeLiveStreamMerge.LiveStreamMergeList["+ i +"].InStreamName2");
				liveStreamMerge.Protocol = _ctx.StringValue("DescribeLiveStreamMerge.LiveStreamMergeList["+ i +"].Protocol");
				liveStreamMerge.StartTime = _ctx.StringValue("DescribeLiveStreamMerge.LiveStreamMergeList["+ i +"].StartTime");
				liveStreamMerge.StreamName = _ctx.StringValue("DescribeLiveStreamMerge.LiveStreamMergeList["+ i +"].StreamName");
				liveStreamMerge.StreamUsing = _ctx.StringValue("DescribeLiveStreamMerge.LiveStreamMergeList["+ i +"].StreamUsing");

				describeLiveStreamMergeResponse_liveStreamMergeList.Add(liveStreamMerge);
			}
			describeLiveStreamMergeResponse.LiveStreamMergeList = describeLiveStreamMergeResponse_liveStreamMergeList;
        
			return describeLiveStreamMergeResponse;
        }
    }
}
