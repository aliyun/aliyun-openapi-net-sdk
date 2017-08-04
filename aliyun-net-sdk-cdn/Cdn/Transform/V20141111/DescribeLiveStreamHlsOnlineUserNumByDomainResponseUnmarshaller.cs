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
    public class DescribeLiveStreamHlsOnlineUserNumByDomainResponseUnmarshaller
    {
        public static DescribeLiveStreamHlsOnlineUserNumByDomainResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeLiveStreamHlsOnlineUserNumByDomainResponse describeLiveStreamHlsOnlineUserNumByDomainResponse = new DescribeLiveStreamHlsOnlineUserNumByDomainResponse();

			describeLiveStreamHlsOnlineUserNumByDomainResponse.HttpResponse = context.HttpResponse;
			describeLiveStreamHlsOnlineUserNumByDomainResponse.RequestId = context.StringValue("DescribeLiveStreamHlsOnlineUserNumByDomain.RequestId");
			describeLiveStreamHlsOnlineUserNumByDomainResponse.TotalUserNumber = context.LongValue("DescribeLiveStreamHlsOnlineUserNumByDomain.TotalUserNumber");
			describeLiveStreamHlsOnlineUserNumByDomainResponse.Count = context.LongValue("DescribeLiveStreamHlsOnlineUserNumByDomain.Count");
			describeLiveStreamHlsOnlineUserNumByDomainResponse.PageNumber = context.LongValue("DescribeLiveStreamHlsOnlineUserNumByDomain.PageNumber");
			describeLiveStreamHlsOnlineUserNumByDomainResponse.PageSize = context.LongValue("DescribeLiveStreamHlsOnlineUserNumByDomain.PageSize");

			List<DescribeLiveStreamHlsOnlineUserNumByDomainResponse.DescribeLiveStreamHlsOnlineUserNumByDomain_LiveStreamOnlineUserNumInfo> describeLiveStreamHlsOnlineUserNumByDomainResponse_onlineUserInfo = new List<DescribeLiveStreamHlsOnlineUserNumByDomainResponse.DescribeLiveStreamHlsOnlineUserNumByDomain_LiveStreamOnlineUserNumInfo>();
			for (int i = 0; i < context.Length("DescribeLiveStreamHlsOnlineUserNumByDomain.OnlineUserInfo.Length"); i++) {
				DescribeLiveStreamHlsOnlineUserNumByDomainResponse.DescribeLiveStreamHlsOnlineUserNumByDomain_LiveStreamOnlineUserNumInfo liveStreamOnlineUserNumInfo = new DescribeLiveStreamHlsOnlineUserNumByDomainResponse.DescribeLiveStreamHlsOnlineUserNumByDomain_LiveStreamOnlineUserNumInfo();
				liveStreamOnlineUserNumInfo.StreamUrl = context.StringValue("DescribeLiveStreamHlsOnlineUserNumByDomain.OnlineUserInfo["+ i +"].StreamUrl");
				liveStreamOnlineUserNumInfo.UserNumber = context.LongValue("DescribeLiveStreamHlsOnlineUserNumByDomain.OnlineUserInfo["+ i +"].UserNumber");
				liveStreamOnlineUserNumInfo.Time = context.StringValue("DescribeLiveStreamHlsOnlineUserNumByDomain.OnlineUserInfo["+ i +"].Time");

				describeLiveStreamHlsOnlineUserNumByDomainResponse_onlineUserInfo.Add(liveStreamOnlineUserNumInfo);
			}
			describeLiveStreamHlsOnlineUserNumByDomainResponse.OnlineUserInfo = describeLiveStreamHlsOnlineUserNumByDomainResponse_onlineUserInfo;
        
			return describeLiveStreamHlsOnlineUserNumByDomainResponse;
        }
    }
}