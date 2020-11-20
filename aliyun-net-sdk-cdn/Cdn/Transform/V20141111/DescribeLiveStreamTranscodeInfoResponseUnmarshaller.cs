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
using Aliyun.Acs.Cdn.Model.V20141111;

namespace Aliyun.Acs.Cdn.Transform.V20141111
{
    public class DescribeLiveStreamTranscodeInfoResponseUnmarshaller
    {
        public static DescribeLiveStreamTranscodeInfoResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeLiveStreamTranscodeInfoResponse describeLiveStreamTranscodeInfoResponse = new DescribeLiveStreamTranscodeInfoResponse();

			describeLiveStreamTranscodeInfoResponse.HttpResponse = _ctx.HttpResponse;
			describeLiveStreamTranscodeInfoResponse.RequestId = _ctx.StringValue("DescribeLiveStreamTranscodeInfo.RequestId");

			List<DescribeLiveStreamTranscodeInfoResponse.DescribeLiveStreamTranscodeInfo_DomainTranscodeInfo> describeLiveStreamTranscodeInfoResponse_domainTranscodeList = new List<DescribeLiveStreamTranscodeInfoResponse.DescribeLiveStreamTranscodeInfo_DomainTranscodeInfo>();
			for (int i = 0; i < _ctx.Length("DescribeLiveStreamTranscodeInfo.DomainTranscodeList.Length"); i++) {
				DescribeLiveStreamTranscodeInfoResponse.DescribeLiveStreamTranscodeInfo_DomainTranscodeInfo domainTranscodeInfo = new DescribeLiveStreamTranscodeInfoResponse.DescribeLiveStreamTranscodeInfo_DomainTranscodeInfo();
				domainTranscodeInfo.TranscodeApp = _ctx.StringValue("DescribeLiveStreamTranscodeInfo.DomainTranscodeList["+ i +"].TranscodeApp");
				domainTranscodeInfo.TranscodeId = _ctx.StringValue("DescribeLiveStreamTranscodeInfo.DomainTranscodeList["+ i +"].TranscodeId");
				domainTranscodeInfo.TranscodeName = _ctx.StringValue("DescribeLiveStreamTranscodeInfo.DomainTranscodeList["+ i +"].TranscodeName");
				domainTranscodeInfo.TranscodeRecord = _ctx.StringValue("DescribeLiveStreamTranscodeInfo.DomainTranscodeList["+ i +"].TranscodeRecord");
				domainTranscodeInfo.TranscodeSnapshot = _ctx.StringValue("DescribeLiveStreamTranscodeInfo.DomainTranscodeList["+ i +"].TranscodeSnapshot");
				domainTranscodeInfo.TranscodeTemplate = _ctx.StringValue("DescribeLiveStreamTranscodeInfo.DomainTranscodeList["+ i +"].TranscodeTemplate");

				describeLiveStreamTranscodeInfoResponse_domainTranscodeList.Add(domainTranscodeInfo);
			}
			describeLiveStreamTranscodeInfoResponse.DomainTranscodeList = describeLiveStreamTranscodeInfoResponse_domainTranscodeList;
        
			return describeLiveStreamTranscodeInfoResponse;
        }
    }
}
