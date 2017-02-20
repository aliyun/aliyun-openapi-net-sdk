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
using System.Collections.Generic;

namespace Aliyun.Acs.Cdn.Transform.V20141111
{
    public class DescribeLiveStreamDomainAppInfoResponseUnmarshaller
    {
        public static DescribeLiveStreamDomainAppInfoResponse Unmarshall(UnmarshallerContext context)
        {
            DescribeLiveStreamDomainAppInfoResponse describeLiveStreamDomainAppInfoResponse = new DescribeLiveStreamDomainAppInfoResponse()
            {
                HttpResponse = context.HttpResponse,
                RequestId = context.StringValue("DescribeLiveStreamDomainAppInfo.RequestId")
            };
            List<DescribeLiveStreamDomainAppInfoResponse.DomainAppInfo> domainAppList = new List<DescribeLiveStreamDomainAppInfoResponse.DomainAppInfo>();
			for (int i = 0; i < context.Length("DescribeLiveStreamDomainAppInfo.DomainAppList.Length"); i++) {
                DescribeLiveStreamDomainAppInfoResponse.DomainAppInfo domainAppInfo = new DescribeLiveStreamDomainAppInfoResponse.DomainAppInfo()
                {
                    AppDomain = context.StringValue($"DescribeLiveStreamDomainAppInfo.DomainAppList[{i}].AppDomain"),
                    AppId = context.StringValue($"DescribeLiveStreamDomainAppInfo.DomainAppList[{i}].AppId"),
                    AppKey = context.StringValue($"DescribeLiveStreamDomainAppInfo.DomainAppList[{i}].AppKey"),
                    AppOssBucket = context.StringValue($"DescribeLiveStreamDomainAppInfo.DomainAppList[{i}].AppOssBucket"),
                    AppOssHost = context.StringValue($"DescribeLiveStreamDomainAppInfo.DomainAppList[{i}].AppOssHost"),
                    AppOwnerId = context.StringValue($"DescribeLiveStreamDomainAppInfo.DomainAppList[{i}].AppOwnerId"),
                    AppSecret = context.StringValue($"DescribeLiveStreamDomainAppInfo.DomainAppList[{i}].AppSecret"),
                    UpdateTime = context.StringValue($"DescribeLiveStreamDomainAppInfo.DomainAppList[{i}].UpdateTime")
                };
                domainAppList.Add(domainAppInfo);
			}
			describeLiveStreamDomainAppInfoResponse.DomainAppList = domainAppList;
        
			return describeLiveStreamDomainAppInfoResponse;
        }
    }
}