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
    public class DescribeLiveStreamRecordContentResponseUnmarshaller
    {
        public static DescribeLiveStreamRecordContentResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeLiveStreamRecordContentResponse describeLiveStreamRecordContentResponse = new DescribeLiveStreamRecordContentResponse();

			describeLiveStreamRecordContentResponse.HttpResponse = _ctx.HttpResponse;
			describeLiveStreamRecordContentResponse.RequestId = _ctx.StringValue("DescribeLiveStreamRecordContent.RequestId");

			List<DescribeLiveStreamRecordContentResponse.DescribeLiveStreamRecordContent_RecordContentInfo> describeLiveStreamRecordContentResponse_recordContentInfoList = new List<DescribeLiveStreamRecordContentResponse.DescribeLiveStreamRecordContent_RecordContentInfo>();
			for (int i = 0; i < _ctx.Length("DescribeLiveStreamRecordContent.RecordContentInfoList.Length"); i++) {
				DescribeLiveStreamRecordContentResponse.DescribeLiveStreamRecordContent_RecordContentInfo recordContentInfo = new DescribeLiveStreamRecordContentResponse.DescribeLiveStreamRecordContent_RecordContentInfo();
				recordContentInfo.OssEndpoint = _ctx.StringValue("DescribeLiveStreamRecordContent.RecordContentInfoList["+ i +"].OssEndpoint");
				recordContentInfo.OssBucket = _ctx.StringValue("DescribeLiveStreamRecordContent.RecordContentInfoList["+ i +"].OssBucket");
				recordContentInfo.OssObjectPrefix = _ctx.StringValue("DescribeLiveStreamRecordContent.RecordContentInfoList["+ i +"].OssObjectPrefix");
				recordContentInfo.StartTime = _ctx.StringValue("DescribeLiveStreamRecordContent.RecordContentInfoList["+ i +"].StartTime");
				recordContentInfo.EndTime = _ctx.StringValue("DescribeLiveStreamRecordContent.RecordContentInfoList["+ i +"].EndTime");
				recordContentInfo.Duration = _ctx.FloatValue("DescribeLiveStreamRecordContent.RecordContentInfoList["+ i +"].Duration");

				describeLiveStreamRecordContentResponse_recordContentInfoList.Add(recordContentInfo);
			}
			describeLiveStreamRecordContentResponse.RecordContentInfoList = describeLiveStreamRecordContentResponse_recordContentInfoList;
        
			return describeLiveStreamRecordContentResponse;
        }
    }
}
