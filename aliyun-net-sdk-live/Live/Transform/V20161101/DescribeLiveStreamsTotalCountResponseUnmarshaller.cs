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
    public class DescribeLiveStreamsTotalCountResponseUnmarshaller
    {
        public static DescribeLiveStreamsTotalCountResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeLiveStreamsTotalCountResponse describeLiveStreamsTotalCountResponse = new DescribeLiveStreamsTotalCountResponse();

			describeLiveStreamsTotalCountResponse.HttpResponse = _ctx.HttpResponse;
			describeLiveStreamsTotalCountResponse.RequestId = _ctx.StringValue("DescribeLiveStreamsTotalCount.RequestId");

			List<DescribeLiveStreamsTotalCountResponse.DescribeLiveStreamsTotalCount_StreamCountInfos> describeLiveStreamsTotalCountResponse_streamCountList = new List<DescribeLiveStreamsTotalCountResponse.DescribeLiveStreamsTotalCount_StreamCountInfos>();
			for (int i = 0; i < _ctx.Length("DescribeLiveStreamsTotalCount.StreamCountList.Length"); i++) {
				DescribeLiveStreamsTotalCountResponse.DescribeLiveStreamsTotalCount_StreamCountInfos streamCountInfos = new DescribeLiveStreamsTotalCountResponse.DescribeLiveStreamsTotalCount_StreamCountInfos();
				streamCountInfos.Count = _ctx.IntegerValue("DescribeLiveStreamsTotalCount.StreamCountList["+ i +"].Count");
				streamCountInfos.Timestamp = _ctx.StringValue("DescribeLiveStreamsTotalCount.StreamCountList["+ i +"].Timestamp");

				describeLiveStreamsTotalCountResponse_streamCountList.Add(streamCountInfos);
			}
			describeLiveStreamsTotalCountResponse.StreamCountList = describeLiveStreamsTotalCountResponse_streamCountList;
        
			return describeLiveStreamsTotalCountResponse;
        }
    }
}
