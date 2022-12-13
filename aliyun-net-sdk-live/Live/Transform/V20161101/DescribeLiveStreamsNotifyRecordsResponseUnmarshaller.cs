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
    public class DescribeLiveStreamsNotifyRecordsResponseUnmarshaller
    {
        public static DescribeLiveStreamsNotifyRecordsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeLiveStreamsNotifyRecordsResponse describeLiveStreamsNotifyRecordsResponse = new DescribeLiveStreamsNotifyRecordsResponse();

			describeLiveStreamsNotifyRecordsResponse.HttpResponse = _ctx.HttpResponse;
			describeLiveStreamsNotifyRecordsResponse.TotalPage = _ctx.IntegerValue("DescribeLiveStreamsNotifyRecords.TotalPage");
			describeLiveStreamsNotifyRecordsResponse.PageNum = _ctx.IntegerValue("DescribeLiveStreamsNotifyRecords.PageNum");
			describeLiveStreamsNotifyRecordsResponse.PageSize = _ctx.IntegerValue("DescribeLiveStreamsNotifyRecords.PageSize");
			describeLiveStreamsNotifyRecordsResponse.RequestId = _ctx.StringValue("DescribeLiveStreamsNotifyRecords.RequestId");
			describeLiveStreamsNotifyRecordsResponse.TotalNum = _ctx.IntegerValue("DescribeLiveStreamsNotifyRecords.TotalNum");

			List<DescribeLiveStreamsNotifyRecordsResponse.DescribeLiveStreamsNotifyRecords_LiveStreamNotifyRecordsInfo> describeLiveStreamsNotifyRecordsResponse_notifyRecordsInfo = new List<DescribeLiveStreamsNotifyRecordsResponse.DescribeLiveStreamsNotifyRecords_LiveStreamNotifyRecordsInfo>();
			for (int i = 0; i < _ctx.Length("DescribeLiveStreamsNotifyRecords.NotifyRecordsInfo.Length"); i++) {
				DescribeLiveStreamsNotifyRecordsResponse.DescribeLiveStreamsNotifyRecords_LiveStreamNotifyRecordsInfo liveStreamNotifyRecordsInfo = new DescribeLiveStreamsNotifyRecordsResponse.DescribeLiveStreamsNotifyRecords_LiveStreamNotifyRecordsInfo();
				liveStreamNotifyRecordsInfo.AppName = _ctx.StringValue("DescribeLiveStreamsNotifyRecords.NotifyRecordsInfo["+ i +"].AppName");
				liveStreamNotifyRecordsInfo.NotifyType = _ctx.StringValue("DescribeLiveStreamsNotifyRecords.NotifyRecordsInfo["+ i +"].NotifyType");
				liveStreamNotifyRecordsInfo.NotifyContent = _ctx.StringValue("DescribeLiveStreamsNotifyRecords.NotifyRecordsInfo["+ i +"].NotifyContent");
				liveStreamNotifyRecordsInfo.Description = _ctx.StringValue("DescribeLiveStreamsNotifyRecords.NotifyRecordsInfo["+ i +"].Description");
				liveStreamNotifyRecordsInfo.StreamName = _ctx.StringValue("DescribeLiveStreamsNotifyRecords.NotifyRecordsInfo["+ i +"].StreamName");
				liveStreamNotifyRecordsInfo.NotifyUrl = _ctx.StringValue("DescribeLiveStreamsNotifyRecords.NotifyRecordsInfo["+ i +"].NotifyUrl");
				liveStreamNotifyRecordsInfo.NotifyResult = _ctx.StringValue("DescribeLiveStreamsNotifyRecords.NotifyRecordsInfo["+ i +"].NotifyResult");
				liveStreamNotifyRecordsInfo.NotifyTime = _ctx.StringValue("DescribeLiveStreamsNotifyRecords.NotifyRecordsInfo["+ i +"].NotifyTime");
				liveStreamNotifyRecordsInfo.DomainName = _ctx.StringValue("DescribeLiveStreamsNotifyRecords.NotifyRecordsInfo["+ i +"].DomainName");

				describeLiveStreamsNotifyRecordsResponse_notifyRecordsInfo.Add(liveStreamNotifyRecordsInfo);
			}
			describeLiveStreamsNotifyRecordsResponse.NotifyRecordsInfo = describeLiveStreamsNotifyRecordsResponse_notifyRecordsInfo;
        
			return describeLiveStreamsNotifyRecordsResponse;
        }
    }
}
