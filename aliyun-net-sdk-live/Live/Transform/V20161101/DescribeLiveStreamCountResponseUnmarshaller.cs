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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.live.Model.V20161101;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.live.Transform.V20161101
{
    public class DescribeLiveStreamCountResponseUnmarshaller
    {
        public static DescribeLiveStreamCountResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeLiveStreamCountResponse describeLiveStreamCountResponse = new DescribeLiveStreamCountResponse();

			describeLiveStreamCountResponse.HttpResponse = context.HttpResponse;
			describeLiveStreamCountResponse.RequestId = context.StringValue("DescribeLiveStreamCount.RequestId");

			List<DescribeLiveStreamCountResponse.DescribeLiveStreamCount_StreamCountInfo> describeLiveStreamCountResponse_streamCountInfos = new List<DescribeLiveStreamCountResponse.DescribeLiveStreamCount_StreamCountInfo>();
			for (int i = 0; i < context.Length("DescribeLiveStreamCount.StreamCountInfos.Length"); i++) {
				DescribeLiveStreamCountResponse.DescribeLiveStreamCount_StreamCountInfo streamCountInfo = new DescribeLiveStreamCountResponse.DescribeLiveStreamCount_StreamCountInfo();
				streamCountInfo.Count = context.LongValue("DescribeLiveStreamCount.StreamCountInfos["+ i +"].Count");
				streamCountInfo.Limit = context.LongValue("DescribeLiveStreamCount.StreamCountInfos["+ i +"].Limit");
				streamCountInfo.Type = context.StringValue("DescribeLiveStreamCount.StreamCountInfos["+ i +"].Type");

				List<DescribeLiveStreamCountResponse.DescribeLiveStreamCount_StreamCountInfo.DescribeLiveStreamCount_StreamCountDetail> streamCountInfo_streamCountDetails = new List<DescribeLiveStreamCountResponse.DescribeLiveStreamCount_StreamCountInfo.DescribeLiveStreamCount_StreamCountDetail>();
				for (int j = 0; j < context.Length("DescribeLiveStreamCount.StreamCountInfos["+ i +"].StreamCountDetails.Length"); j++) {
					DescribeLiveStreamCountResponse.DescribeLiveStreamCount_StreamCountInfo.DescribeLiveStreamCount_StreamCountDetail streamCountDetail = new DescribeLiveStreamCountResponse.DescribeLiveStreamCount_StreamCountInfo.DescribeLiveStreamCount_StreamCountDetail();
					streamCountDetail.Format = context.StringValue("DescribeLiveStreamCount.StreamCountInfos["+ i +"].StreamCountDetails["+ j +"].Format");
					streamCountDetail.VideoDataRate = context.LongValue("DescribeLiveStreamCount.StreamCountInfos["+ i +"].StreamCountDetails["+ j +"].VideoDataRate");
					streamCountDetail.Count = context.LongValue("DescribeLiveStreamCount.StreamCountInfos["+ i +"].StreamCountDetails["+ j +"].Count");

					streamCountInfo_streamCountDetails.Add(streamCountDetail);
				}
				streamCountInfo.StreamCountDetails = streamCountInfo_streamCountDetails;

				describeLiveStreamCountResponse_streamCountInfos.Add(streamCountInfo);
			}
			describeLiveStreamCountResponse.StreamCountInfos = describeLiveStreamCountResponse_streamCountInfos;
        
			return describeLiveStreamCountResponse;
        }
    }
}