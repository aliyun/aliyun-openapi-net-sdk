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
        public static DescribeDomainInfoResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDomainInfoResponse describeDomainInfoResponse = new DescribeDomainInfoResponse();

			describeDomainInfoResponse.HttpResponse = _ctx.HttpResponse;
			describeDomainInfoResponse.RequestId = _ctx.StringValue("DescribeDomainInfo.RequestId");
			describeDomainInfoResponse.DomainId = _ctx.StringValue("DescribeDomainInfo.DomainId");
			describeDomainInfoResponse.DomainName = _ctx.StringValue("DescribeDomainInfo.DomainName");
			describeDomainInfoResponse.PunyCode = _ctx.StringValue("DescribeDomainInfo.PunyCode");
			describeDomainInfoResponse.AliDomain = _ctx.BooleanValue("DescribeDomainInfo.AliDomain");
			describeDomainInfoResponse.Remark = _ctx.StringValue("DescribeDomainInfo.Remark");
			describeDomainInfoResponse.GroupId = _ctx.StringValue("DescribeDomainInfo.GroupId");
			describeDomainInfoResponse.GroupName = _ctx.StringValue("DescribeDomainInfo.GroupName");
			describeDomainInfoResponse.InstanceId = _ctx.StringValue("DescribeDomainInfo.InstanceId");
			describeDomainInfoResponse.VersionCode = _ctx.StringValue("DescribeDomainInfo.VersionCode");
			describeDomainInfoResponse.VersionName = _ctx.StringValue("DescribeDomainInfo.VersionName");
			describeDomainInfoResponse.MinTtl = _ctx.LongValue("DescribeDomainInfo.MinTtl");
			describeDomainInfoResponse.RecordLineTreeJson = _ctx.StringValue("DescribeDomainInfo.RecordLineTreeJson");
			describeDomainInfoResponse.LineType = _ctx.StringValue("DescribeDomainInfo.LineType");
			describeDomainInfoResponse.RegionLines = _ctx.BooleanValue("DescribeDomainInfo.RegionLines");
			describeDomainInfoResponse.InBlackHole = _ctx.BooleanValue("DescribeDomainInfo.InBlackHole");
			describeDomainInfoResponse.InClean = _ctx.BooleanValue("DescribeDomainInfo.InClean");
			describeDomainInfoResponse.SlaveDns = _ctx.BooleanValue("DescribeDomainInfo.SlaveDns");
			describeDomainInfoResponse.ResourceGroupId = _ctx.StringValue("DescribeDomainInfo.ResourceGroupId");
			describeDomainInfoResponse.CreateTime = _ctx.StringValue("DescribeDomainInfo.CreateTime");

			List<string> describeDomainInfoResponse_dnsServers = new List<string>();
			for (int i = 0; i < _ctx.Length("DescribeDomainInfo.DnsServers.Length"); i++) {
				describeDomainInfoResponse_dnsServers.Add(_ctx.StringValue("DescribeDomainInfo.DnsServers["+ i +"]"));
			}
			describeDomainInfoResponse.DnsServers = describeDomainInfoResponse_dnsServers;

			List<string> describeDomainInfoResponse_availableTtls = new List<string>();
			for (int i = 0; i < _ctx.Length("DescribeDomainInfo.AvailableTtls.Length"); i++) {
				describeDomainInfoResponse_availableTtls.Add(_ctx.StringValue("DescribeDomainInfo.AvailableTtls["+ i +"]"));
			}
			describeDomainInfoResponse.AvailableTtls = describeDomainInfoResponse_availableTtls;

			List<DescribeDomainInfoResponse.DescribeDomainInfo_RecordLine> describeDomainInfoResponse_recordLines = new List<DescribeDomainInfoResponse.DescribeDomainInfo_RecordLine>();
			for (int i = 0; i < _ctx.Length("DescribeDomainInfo.RecordLines.Length"); i++) {
				DescribeDomainInfoResponse.DescribeDomainInfo_RecordLine recordLine = new DescribeDomainInfoResponse.DescribeDomainInfo_RecordLine();
				recordLine.LineCode = _ctx.StringValue("DescribeDomainInfo.RecordLines["+ i +"].LineCode");
				recordLine.FatherCode = _ctx.StringValue("DescribeDomainInfo.RecordLines["+ i +"].FatherCode");
				recordLine.LineName = _ctx.StringValue("DescribeDomainInfo.RecordLines["+ i +"].LineName");
				recordLine.LineDisplayName = _ctx.StringValue("DescribeDomainInfo.RecordLines["+ i +"].LineDisplayName");

				describeDomainInfoResponse_recordLines.Add(recordLine);
			}
			describeDomainInfoResponse.RecordLines = describeDomainInfoResponse_recordLines;
        
			return describeDomainInfoResponse;
        }
    }
}
