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
    public class DescribeLiveDomainOnlineUserNumResponseUnmarshaller
    {
        public static DescribeLiveDomainOnlineUserNumResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeLiveDomainOnlineUserNumResponse describeLiveDomainOnlineUserNumResponse = new DescribeLiveDomainOnlineUserNumResponse();

			describeLiveDomainOnlineUserNumResponse.HttpResponse = _ctx.HttpResponse;
			describeLiveDomainOnlineUserNumResponse.RequestId = _ctx.StringValue("DescribeLiveDomainOnlineUserNum.RequestId");
			describeLiveDomainOnlineUserNumResponse.StreamCount = _ctx.IntegerValue("DescribeLiveDomainOnlineUserNum.StreamCount");
			describeLiveDomainOnlineUserNumResponse.UserCount = _ctx.IntegerValue("DescribeLiveDomainOnlineUserNum.UserCount");

			List<DescribeLiveDomainOnlineUserNumResponse.DescribeLiveDomainOnlineUserNum_LiveStreamOnlineUserNumInfo> describeLiveDomainOnlineUserNumResponse_onlineUserInfo = new List<DescribeLiveDomainOnlineUserNumResponse.DescribeLiveDomainOnlineUserNum_LiveStreamOnlineUserNumInfo>();
			for (int i = 0; i < _ctx.Length("DescribeLiveDomainOnlineUserNum.OnlineUserInfo.Length"); i++) {
				DescribeLiveDomainOnlineUserNumResponse.DescribeLiveDomainOnlineUserNum_LiveStreamOnlineUserNumInfo liveStreamOnlineUserNumInfo = new DescribeLiveDomainOnlineUserNumResponse.DescribeLiveDomainOnlineUserNum_LiveStreamOnlineUserNumInfo();
				liveStreamOnlineUserNumInfo.StreamName = _ctx.StringValue("DescribeLiveDomainOnlineUserNum.OnlineUserInfo["+ i +"].StreamName");

				List<DescribeLiveDomainOnlineUserNumResponse.DescribeLiveDomainOnlineUserNum_LiveStreamOnlineUserNumInfo.DescribeLiveDomainOnlineUserNum_Info> liveStreamOnlineUserNumInfo_infos = new List<DescribeLiveDomainOnlineUserNumResponse.DescribeLiveDomainOnlineUserNum_LiveStreamOnlineUserNumInfo.DescribeLiveDomainOnlineUserNum_Info>();
				for (int j = 0; j < _ctx.Length("DescribeLiveDomainOnlineUserNum.OnlineUserInfo["+ i +"].Infos.Length"); j++) {
					DescribeLiveDomainOnlineUserNumResponse.DescribeLiveDomainOnlineUserNum_LiveStreamOnlineUserNumInfo.DescribeLiveDomainOnlineUserNum_Info info = new DescribeLiveDomainOnlineUserNumResponse.DescribeLiveDomainOnlineUserNum_LiveStreamOnlineUserNumInfo.DescribeLiveDomainOnlineUserNum_Info();
					info.TranscodeTemplate = _ctx.StringValue("DescribeLiveDomainOnlineUserNum.OnlineUserInfo["+ i +"].Infos["+ j +"].TranscodeTemplate");
					info.UserNumber = _ctx.LongValue("DescribeLiveDomainOnlineUserNum.OnlineUserInfo["+ i +"].Infos["+ j +"].UserNumber");

					liveStreamOnlineUserNumInfo_infos.Add(info);
				}
				liveStreamOnlineUserNumInfo.Infos = liveStreamOnlineUserNumInfo_infos;

				describeLiveDomainOnlineUserNumResponse_onlineUserInfo.Add(liveStreamOnlineUserNumInfo);
			}
			describeLiveDomainOnlineUserNumResponse.OnlineUserInfo = describeLiveDomainOnlineUserNumResponse_onlineUserInfo;
        
			return describeLiveDomainOnlineUserNumResponse;
        }
    }
}
