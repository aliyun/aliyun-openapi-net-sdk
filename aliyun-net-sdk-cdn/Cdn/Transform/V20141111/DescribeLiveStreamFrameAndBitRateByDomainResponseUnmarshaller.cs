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
    public class DescribeLiveStreamFrameAndBitRateByDomainResponseUnmarshaller
    {
        public static DescribeLiveStreamFrameAndBitRateByDomainResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeLiveStreamFrameAndBitRateByDomainResponse describeLiveStreamFrameAndBitRateByDomainResponse = new DescribeLiveStreamFrameAndBitRateByDomainResponse();

			describeLiveStreamFrameAndBitRateByDomainResponse.HttpResponse = context.HttpResponse;
			describeLiveStreamFrameAndBitRateByDomainResponse.RequestId = context.StringValue("DescribeLiveStreamFrameAndBitRateByDomain.RequestId");
			describeLiveStreamFrameAndBitRateByDomainResponse.Count = context.LongValue("DescribeLiveStreamFrameAndBitRateByDomain.Count");
			describeLiveStreamFrameAndBitRateByDomainResponse.PageNumber = context.LongValue("DescribeLiveStreamFrameAndBitRateByDomain.PageNumber");
			describeLiveStreamFrameAndBitRateByDomainResponse.PageSize = context.LongValue("DescribeLiveStreamFrameAndBitRateByDomain.PageSize");

			List<DescribeLiveStreamFrameAndBitRateByDomainResponse.DescribeLiveStreamFrameAndBitRateByDomain_FrameRateAndBitRateInfo> describeLiveStreamFrameAndBitRateByDomainResponse_frameRateAndBitRateInfos = new List<DescribeLiveStreamFrameAndBitRateByDomainResponse.DescribeLiveStreamFrameAndBitRateByDomain_FrameRateAndBitRateInfo>();
			for (int i = 0; i < context.Length("DescribeLiveStreamFrameAndBitRateByDomain.FrameRateAndBitRateInfos.Length"); i++) {
				DescribeLiveStreamFrameAndBitRateByDomainResponse.DescribeLiveStreamFrameAndBitRateByDomain_FrameRateAndBitRateInfo frameRateAndBitRateInfo = new DescribeLiveStreamFrameAndBitRateByDomainResponse.DescribeLiveStreamFrameAndBitRateByDomain_FrameRateAndBitRateInfo();
				frameRateAndBitRateInfo.StreamUrl = context.StringValue("DescribeLiveStreamFrameAndBitRateByDomain.FrameRateAndBitRateInfos["+ i +"].StreamUrl");
				frameRateAndBitRateInfo.VideoFrameRate = context.FloatValue("DescribeLiveStreamFrameAndBitRateByDomain.FrameRateAndBitRateInfos["+ i +"].VideoFrameRate");
				frameRateAndBitRateInfo.AudioFrameRate = context.FloatValue("DescribeLiveStreamFrameAndBitRateByDomain.FrameRateAndBitRateInfos["+ i +"].AudioFrameRate");
				frameRateAndBitRateInfo.BitRate = context.FloatValue("DescribeLiveStreamFrameAndBitRateByDomain.FrameRateAndBitRateInfos["+ i +"].BitRate");
				frameRateAndBitRateInfo.Time = context.StringValue("DescribeLiveStreamFrameAndBitRateByDomain.FrameRateAndBitRateInfos["+ i +"].Time");

				describeLiveStreamFrameAndBitRateByDomainResponse_frameRateAndBitRateInfos.Add(frameRateAndBitRateInfo);
			}
			describeLiveStreamFrameAndBitRateByDomainResponse.FrameRateAndBitRateInfos = describeLiveStreamFrameAndBitRateByDomainResponse_frameRateAndBitRateInfos;
        
			return describeLiveStreamFrameAndBitRateByDomainResponse;
        }
    }
}