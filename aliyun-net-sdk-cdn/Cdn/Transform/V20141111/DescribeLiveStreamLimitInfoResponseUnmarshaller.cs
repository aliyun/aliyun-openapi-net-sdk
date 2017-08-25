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
    public class DescribeLiveStreamLimitInfoResponseUnmarshaller
    {
        public static DescribeLiveStreamLimitInfoResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeLiveStreamLimitInfoResponse describeLiveStreamLimitInfoResponse = new DescribeLiveStreamLimitInfoResponse();

			describeLiveStreamLimitInfoResponse.HttpResponse = context.HttpResponse;
			describeLiveStreamLimitInfoResponse.RequestId = context.StringValue("DescribeLiveStreamLimitInfo.RequestId");

			List<DescribeLiveStreamLimitInfoResponse.DescribeLiveStreamLimitInfo_UserLimitMode> describeLiveStreamLimitInfoResponse_userLimitLists = new List<DescribeLiveStreamLimitInfoResponse.DescribeLiveStreamLimitInfo_UserLimitMode>();
			for (int i = 0; i < context.Length("DescribeLiveStreamLimitInfo.UserLimitLists.Length"); i++) {
				DescribeLiveStreamLimitInfoResponse.DescribeLiveStreamLimitInfo_UserLimitMode userLimitMode = new DescribeLiveStreamLimitInfoResponse.DescribeLiveStreamLimitInfo_UserLimitMode();
				userLimitMode.LimitDomain = context.StringValue("DescribeLiveStreamLimitInfo.UserLimitLists["+ i +"].LimitDomain");
				userLimitMode.LimitNum = context.StringValue("DescribeLiveStreamLimitInfo.UserLimitLists["+ i +"].LimitNum");
				userLimitMode.LimitTranscodeNum = context.StringValue("DescribeLiveStreamLimitInfo.UserLimitLists["+ i +"].LimitTranscodeNum");

				describeLiveStreamLimitInfoResponse_userLimitLists.Add(userLimitMode);
			}
			describeLiveStreamLimitInfoResponse.UserLimitLists = describeLiveStreamLimitInfoResponse_userLimitLists;
        
			return describeLiveStreamLimitInfoResponse;
        }
    }
}