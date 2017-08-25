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
    public class DescribeLiveStreamOnlineUserNumByDomainResponseUnmarshaller
    {
        public static DescribeLiveStreamOnlineUserNumByDomainResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeLiveStreamOnlineUserNumByDomainResponse describeLiveStreamOnlineUserNumByDomainResponse = new DescribeLiveStreamOnlineUserNumByDomainResponse();

			describeLiveStreamOnlineUserNumByDomainResponse.HttpResponse = context.HttpResponse;
			describeLiveStreamOnlineUserNumByDomainResponse.RequestId = context.StringValue("DescribeLiveStreamOnlineUserNumByDomain.RequestId");
			describeLiveStreamOnlineUserNumByDomainResponse.TotalUserNumber = context.LongValue("DescribeLiveStreamOnlineUserNumByDomain.TotalUserNumber");
			describeLiveStreamOnlineUserNumByDomainResponse.Count = context.LongValue("DescribeLiveStreamOnlineUserNumByDomain.Count");
			describeLiveStreamOnlineUserNumByDomainResponse.PageNumber = context.LongValue("DescribeLiveStreamOnlineUserNumByDomain.PageNumber");
			describeLiveStreamOnlineUserNumByDomainResponse.PageSize = context.LongValue("DescribeLiveStreamOnlineUserNumByDomain.PageSize");

			List<DescribeLiveStreamOnlineUserNumByDomainResponse.DescribeLiveStreamOnlineUserNumByDomain_LiveStreamOnlineUserNumInfo> describeLiveStreamOnlineUserNumByDomainResponse_onlineUserInfo = new List<DescribeLiveStreamOnlineUserNumByDomainResponse.DescribeLiveStreamOnlineUserNumByDomain_LiveStreamOnlineUserNumInfo>();
			for (int i = 0; i < context.Length("DescribeLiveStreamOnlineUserNumByDomain.OnlineUserInfo.Length"); i++) {
				DescribeLiveStreamOnlineUserNumByDomainResponse.DescribeLiveStreamOnlineUserNumByDomain_LiveStreamOnlineUserNumInfo liveStreamOnlineUserNumInfo = new DescribeLiveStreamOnlineUserNumByDomainResponse.DescribeLiveStreamOnlineUserNumByDomain_LiveStreamOnlineUserNumInfo();
				liveStreamOnlineUserNumInfo.StreamUrl = context.StringValue("DescribeLiveStreamOnlineUserNumByDomain.OnlineUserInfo["+ i +"].StreamUrl");
				liveStreamOnlineUserNumInfo.UserNumber = context.LongValue("DescribeLiveStreamOnlineUserNumByDomain.OnlineUserInfo["+ i +"].UserNumber");
				liveStreamOnlineUserNumInfo.Time = context.StringValue("DescribeLiveStreamOnlineUserNumByDomain.OnlineUserInfo["+ i +"].Time");

				describeLiveStreamOnlineUserNumByDomainResponse_onlineUserInfo.Add(liveStreamOnlineUserNumInfo);
			}
			describeLiveStreamOnlineUserNumByDomainResponse.OnlineUserInfo = describeLiveStreamOnlineUserNumByDomainResponse_onlineUserInfo;
        
			return describeLiveStreamOnlineUserNumByDomainResponse;
        }
    }
}