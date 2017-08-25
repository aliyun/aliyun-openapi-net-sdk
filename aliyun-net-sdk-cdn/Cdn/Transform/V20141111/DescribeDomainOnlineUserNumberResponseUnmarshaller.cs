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
using Aliyun.Acs.Cdn.Model.V20141111;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Cdn.Transform.V20141111
{
    public class DescribeDomainOnlineUserNumberResponseUnmarshaller
    {
        public static DescribeDomainOnlineUserNumberResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeDomainOnlineUserNumberResponse describeDomainOnlineUserNumberResponse = new DescribeDomainOnlineUserNumberResponse();

			describeDomainOnlineUserNumberResponse.HttpResponse = context.HttpResponse;
			describeDomainOnlineUserNumberResponse.RequestId = context.StringValue("DescribeDomainOnlineUserNumber.RequestId");

			List<DescribeDomainOnlineUserNumberResponse.DescribeDomainOnlineUserNumber_LiveStreamOnlineUserNumInfo> describeDomainOnlineUserNumberResponse_liveStreamOnlineUserNumInfos = new List<DescribeDomainOnlineUserNumberResponse.DescribeDomainOnlineUserNumber_LiveStreamOnlineUserNumInfo>();
			for (int i = 0; i < context.Length("DescribeDomainOnlineUserNumber.LiveStreamOnlineUserNumInfos.Length"); i++) {
				DescribeDomainOnlineUserNumberResponse.DescribeDomainOnlineUserNumber_LiveStreamOnlineUserNumInfo liveStreamOnlineUserNumInfo = new DescribeDomainOnlineUserNumberResponse.DescribeDomainOnlineUserNumber_LiveStreamOnlineUserNumInfo();
				liveStreamOnlineUserNumInfo.Time = context.StringValue("DescribeDomainOnlineUserNumber.LiveStreamOnlineUserNumInfos["+ i +"].Time");
				liveStreamOnlineUserNumInfo.UserNumber = context.LongValue("DescribeDomainOnlineUserNumber.LiveStreamOnlineUserNumInfos["+ i +"].UserNumber");

				describeDomainOnlineUserNumberResponse_liveStreamOnlineUserNumInfos.Add(liveStreamOnlineUserNumInfo);
			}
			describeDomainOnlineUserNumberResponse.LiveStreamOnlineUserNumInfos = describeDomainOnlineUserNumberResponse_liveStreamOnlineUserNumInfos;
        
			return describeDomainOnlineUserNumberResponse;
        }
    }
}