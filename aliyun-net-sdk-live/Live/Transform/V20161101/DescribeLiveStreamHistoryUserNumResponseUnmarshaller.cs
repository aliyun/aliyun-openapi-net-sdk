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
    public class DescribeLiveStreamHistoryUserNumResponseUnmarshaller
    {
        public static DescribeLiveStreamHistoryUserNumResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeLiveStreamHistoryUserNumResponse describeLiveStreamHistoryUserNumResponse = new DescribeLiveStreamHistoryUserNumResponse();

			describeLiveStreamHistoryUserNumResponse.HttpResponse = context.HttpResponse;
			describeLiveStreamHistoryUserNumResponse.RequestId = context.StringValue("DescribeLiveStreamHistoryUserNum.RequestId");

			List<DescribeLiveStreamHistoryUserNumResponse.DescribeLiveStreamHistoryUserNum_LiveStreamUserNumInfo> describeLiveStreamHistoryUserNumResponse_liveStreamUserNumInfos = new List<DescribeLiveStreamHistoryUserNumResponse.DescribeLiveStreamHistoryUserNum_LiveStreamUserNumInfo>();
			for (int i = 0; i < context.Length("DescribeLiveStreamHistoryUserNum.LiveStreamUserNumInfos.Length"); i++) {
				DescribeLiveStreamHistoryUserNumResponse.DescribeLiveStreamHistoryUserNum_LiveStreamUserNumInfo liveStreamUserNumInfo = new DescribeLiveStreamHistoryUserNumResponse.DescribeLiveStreamHistoryUserNum_LiveStreamUserNumInfo();
				liveStreamUserNumInfo.StreamTime = context.StringValue("DescribeLiveStreamHistoryUserNum.LiveStreamUserNumInfos["+ i +"].StreamTime");
				liveStreamUserNumInfo.UserNum = context.StringValue("DescribeLiveStreamHistoryUserNum.LiveStreamUserNumInfos["+ i +"].UserNum");

				describeLiveStreamHistoryUserNumResponse_liveStreamUserNumInfos.Add(liveStreamUserNumInfo);
			}
			describeLiveStreamHistoryUserNumResponse.LiveStreamUserNumInfos = describeLiveStreamHistoryUserNumResponse_liveStreamUserNumInfos;
        
			return describeLiveStreamHistoryUserNumResponse;
        }
    }
}