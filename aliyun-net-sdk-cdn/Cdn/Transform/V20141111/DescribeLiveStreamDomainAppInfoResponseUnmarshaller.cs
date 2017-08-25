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
    public class DescribeLiveStreamDomainAppInfoResponseUnmarshaller
    {
        public static DescribeLiveStreamDomainAppInfoResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeLiveStreamDomainAppInfoResponse describeLiveStreamDomainAppInfoResponse = new DescribeLiveStreamDomainAppInfoResponse();

			describeLiveStreamDomainAppInfoResponse.HttpResponse = context.HttpResponse;
			describeLiveStreamDomainAppInfoResponse.RequestId = context.StringValue("DescribeLiveStreamDomainAppInfo.RequestId");

			List<DescribeLiveStreamDomainAppInfoResponse.DescribeLiveStreamDomainAppInfo_DomainAppInfo> describeLiveStreamDomainAppInfoResponse_domainAppList = new List<DescribeLiveStreamDomainAppInfoResponse.DescribeLiveStreamDomainAppInfo_DomainAppInfo>();
			for (int i = 0; i < context.Length("DescribeLiveStreamDomainAppInfo.DomainAppList.Length"); i++) {
				DescribeLiveStreamDomainAppInfoResponse.DescribeLiveStreamDomainAppInfo_DomainAppInfo domainAppInfo = new DescribeLiveStreamDomainAppInfoResponse.DescribeLiveStreamDomainAppInfo_DomainAppInfo();
				domainAppInfo.AppDomain = context.StringValue("DescribeLiveStreamDomainAppInfo.DomainAppList["+ i +"].AppDomain");
				domainAppInfo.AppId = context.StringValue("DescribeLiveStreamDomainAppInfo.DomainAppList["+ i +"].AppId");
				domainAppInfo.AppKey = context.StringValue("DescribeLiveStreamDomainAppInfo.DomainAppList["+ i +"].AppKey");
				domainAppInfo.AppOssBucket = context.StringValue("DescribeLiveStreamDomainAppInfo.DomainAppList["+ i +"].AppOssBucket");
				domainAppInfo.AppOssHost = context.StringValue("DescribeLiveStreamDomainAppInfo.DomainAppList["+ i +"].AppOssHost");
				domainAppInfo.AppOwnerId = context.StringValue("DescribeLiveStreamDomainAppInfo.DomainAppList["+ i +"].AppOwnerId");
				domainAppInfo.AppSecret = context.StringValue("DescribeLiveStreamDomainAppInfo.DomainAppList["+ i +"].AppSecret");
				domainAppInfo.UpdateTime = context.StringValue("DescribeLiveStreamDomainAppInfo.DomainAppList["+ i +"].UpdateTime");

				describeLiveStreamDomainAppInfoResponse_domainAppList.Add(domainAppInfo);
			}
			describeLiveStreamDomainAppInfoResponse.DomainAppList = describeLiveStreamDomainAppInfoResponse_domainAppList;
        
			return describeLiveStreamDomainAppInfoResponse;
        }
    }
}