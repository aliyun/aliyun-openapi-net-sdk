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
    public class DescribeLiveStreamSnapshotInfoResponseUnmarshaller
    {
        public static DescribeLiveStreamSnapshotInfoResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeLiveStreamSnapshotInfoResponse describeLiveStreamSnapshotInfoResponse = new DescribeLiveStreamSnapshotInfoResponse();

			describeLiveStreamSnapshotInfoResponse.HttpResponse = _ctx.HttpResponse;
			describeLiveStreamSnapshotInfoResponse.NextStartTime = _ctx.StringValue("DescribeLiveStreamSnapshotInfo.NextStartTime");
			describeLiveStreamSnapshotInfoResponse.RequestId = _ctx.StringValue("DescribeLiveStreamSnapshotInfo.RequestId");

			List<DescribeLiveStreamSnapshotInfoResponse.DescribeLiveStreamSnapshotInfo_LiveStreamSnapshotInfo> describeLiveStreamSnapshotInfoResponse_liveStreamSnapshotInfoList = new List<DescribeLiveStreamSnapshotInfoResponse.DescribeLiveStreamSnapshotInfo_LiveStreamSnapshotInfo>();
			for (int i = 0; i < _ctx.Length("DescribeLiveStreamSnapshotInfo.LiveStreamSnapshotInfoList.Length"); i++) {
				DescribeLiveStreamSnapshotInfoResponse.DescribeLiveStreamSnapshotInfo_LiveStreamSnapshotInfo liveStreamSnapshotInfo = new DescribeLiveStreamSnapshotInfoResponse.DescribeLiveStreamSnapshotInfo_LiveStreamSnapshotInfo();
				liveStreamSnapshotInfo.OssObject = _ctx.StringValue("DescribeLiveStreamSnapshotInfo.LiveStreamSnapshotInfoList["+ i +"].OssObject");
				liveStreamSnapshotInfo.OssBucket = _ctx.StringValue("DescribeLiveStreamSnapshotInfo.LiveStreamSnapshotInfoList["+ i +"].OssBucket");
				liveStreamSnapshotInfo.CreateTime = _ctx.StringValue("DescribeLiveStreamSnapshotInfo.LiveStreamSnapshotInfoList["+ i +"].CreateTime");
				liveStreamSnapshotInfo.OssEndpoint = _ctx.StringValue("DescribeLiveStreamSnapshotInfo.LiveStreamSnapshotInfoList["+ i +"].OssEndpoint");
				liveStreamSnapshotInfo.IsOverlay = _ctx.BooleanValue("DescribeLiveStreamSnapshotInfo.LiveStreamSnapshotInfoList["+ i +"].IsOverlay");
				liveStreamSnapshotInfo.CreateTimestamp = _ctx.LongValue("DescribeLiveStreamSnapshotInfo.LiveStreamSnapshotInfoList["+ i +"].CreateTimestamp");

				describeLiveStreamSnapshotInfoResponse_liveStreamSnapshotInfoList.Add(liveStreamSnapshotInfo);
			}
			describeLiveStreamSnapshotInfoResponse.LiveStreamSnapshotInfoList = describeLiveStreamSnapshotInfoResponse_liveStreamSnapshotInfoList;
        
			return describeLiveStreamSnapshotInfoResponse;
        }
    }
}
