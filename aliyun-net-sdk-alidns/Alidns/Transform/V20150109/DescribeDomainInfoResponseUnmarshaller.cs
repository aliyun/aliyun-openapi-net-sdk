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
using Aliyun.Acs.Alidns.Model.V20150109;

namespace Aliyun.Acs.Alidns.Transform.V20150109
{
    public class DescribeDomainInfoResponseUnmarshaller
    {
        public static DescribeDomainInfoResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeDomainInfoResponse describeDomainInfoResponse = new DescribeDomainInfoResponse();

			describeDomainInfoResponse.HttpResponse = context.HttpResponse;
			describeDomainInfoResponse.RequestId = context.StringValue("DescribeDomainInfo.RequestId");
			describeDomainInfoResponse.DomainId = context.StringValue("DescribeDomainInfo.DomainId");
			describeDomainInfoResponse.DomainName = context.StringValue("DescribeDomainInfo.DomainName");
			describeDomainInfoResponse.PunyCode = context.StringValue("DescribeDomainInfo.PunyCode");
			describeDomainInfoResponse.AliDomain = context.BooleanValue("DescribeDomainInfo.AliDomain");
			describeDomainInfoResponse.Remark = context.StringValue("DescribeDomainInfo.Remark");
			describeDomainInfoResponse.GroupId = context.StringValue("DescribeDomainInfo.GroupId");
			describeDomainInfoResponse.GroupName = context.StringValue("DescribeDomainInfo.GroupName");
			describeDomainInfoResponse.InstanceId = context.StringValue("DescribeDomainInfo.InstanceId");
			describeDomainInfoResponse.VersionCode = context.StringValue("DescribeDomainInfo.VersionCode");
			describeDomainInfoResponse.VersionName = context.StringValue("DescribeDomainInfo.VersionName");
			describeDomainInfoResponse.MinTtl = context.LongValue("DescribeDomainInfo.MinTtl");
			describeDomainInfoResponse.RecordLineTreeJson = context.StringValue("DescribeDomainInfo.RecordLineTreeJson");
			describeDomainInfoResponse.LineType = context.StringValue("DescribeDomainInfo.LineType");
			describeDomainInfoResponse.RegionLines = context.BooleanValue("DescribeDomainInfo.RegionLines");
			describeDomainInfoResponse.InBlackHole = context.BooleanValue("DescribeDomainInfo.InBlackHole");
			describeDomainInfoResponse.InClean = context.BooleanValue("DescribeDomainInfo.InClean");
			describeDomainInfoResponse.SlaveDns = context.BooleanValue("DescribeDomainInfo.SlaveDns");

			List<string> describeDomainInfoResponse_dnsServers = new List<string>();
			for (int i = 0; i < context.Length("DescribeDomainInfo.DnsServers.Length"); i++) {
				describeDomainInfoResponse_dnsServers.Add(context.StringValue("DescribeDomainInfo.DnsServers["+ i +"]"));
			}
			describeDomainInfoResponse.DnsServers = describeDomainInfoResponse_dnsServers;

			List<string> describeDomainInfoResponse_availableTtls = new List<string>();
			for (int i = 0; i < context.Length("DescribeDomainInfo.AvailableTtls.Length"); i++) {
				describeDomainInfoResponse_availableTtls.Add(context.StringValue("DescribeDomainInfo.AvailableTtls["+ i +"]"));
			}
			describeDomainInfoResponse.AvailableTtls = describeDomainInfoResponse_availableTtls;

			List<DescribeDomainInfoResponse.DescribeDomainInfo_RecordLine> describeDomainInfoResponse_recordLines = new List<DescribeDomainInfoResponse.DescribeDomainInfo_RecordLine>();
			for (int i = 0; i < context.Length("DescribeDomainInfo.RecordLines.Length"); i++) {
				DescribeDomainInfoResponse.DescribeDomainInfo_RecordLine recordLine = new DescribeDomainInfoResponse.DescribeDomainInfo_RecordLine();
				recordLine.LineCode = context.StringValue("DescribeDomainInfo.RecordLines["+ i +"].LineCode");
				recordLine.FatherCode = context.StringValue("DescribeDomainInfo.RecordLines["+ i +"].FatherCode");
				recordLine.LineName = context.StringValue("DescribeDomainInfo.RecordLines["+ i +"].LineName");
				recordLine.LineDisplayName = context.StringValue("DescribeDomainInfo.RecordLines["+ i +"].LineDisplayName");

				describeDomainInfoResponse_recordLines.Add(recordLine);
			}
			describeDomainInfoResponse.RecordLines = describeDomainInfoResponse_recordLines;
        
			return describeDomainInfoResponse;
        }
    }
}
