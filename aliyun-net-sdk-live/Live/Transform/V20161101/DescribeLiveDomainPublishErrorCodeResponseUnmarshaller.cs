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
    public class DescribeLiveDomainPublishErrorCodeResponseUnmarshaller
    {
        public static DescribeLiveDomainPublishErrorCodeResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeLiveDomainPublishErrorCodeResponse describeLiveDomainPublishErrorCodeResponse = new DescribeLiveDomainPublishErrorCodeResponse();

			describeLiveDomainPublishErrorCodeResponse.HttpResponse = _ctx.HttpResponse;
			describeLiveDomainPublishErrorCodeResponse.RequestId = _ctx.StringValue("DescribeLiveDomainPublishErrorCode.RequestId");
			describeLiveDomainPublishErrorCodeResponse.DataInterval = _ctx.StringValue("DescribeLiveDomainPublishErrorCode.DataInterval");
			describeLiveDomainPublishErrorCodeResponse.DomainName = _ctx.StringValue("DescribeLiveDomainPublishErrorCode.DomainName");
			describeLiveDomainPublishErrorCodeResponse.StartTime = _ctx.StringValue("DescribeLiveDomainPublishErrorCode.StartTime");
			describeLiveDomainPublishErrorCodeResponse.EndTime = _ctx.StringValue("DescribeLiveDomainPublishErrorCode.EndTime");

			List<DescribeLiveDomainPublishErrorCodeResponse.DescribeLiveDomainPublishErrorCode_Rtcd> describeLiveDomainPublishErrorCodeResponse_realTimeCodeData = new List<DescribeLiveDomainPublishErrorCodeResponse.DescribeLiveDomainPublishErrorCode_Rtcd>();
			for (int i = 0; i < _ctx.Length("DescribeLiveDomainPublishErrorCode.RealTimeCodeData.Length"); i++) {
				DescribeLiveDomainPublishErrorCodeResponse.DescribeLiveDomainPublishErrorCode_Rtcd rtcd = new DescribeLiveDomainPublishErrorCodeResponse.DescribeLiveDomainPublishErrorCode_Rtcd();
				rtcd.TimeStamp = _ctx.StringValue("DescribeLiveDomainPublishErrorCode.RealTimeCodeData["+ i +"].TimeStamp");

				List<DescribeLiveDomainPublishErrorCodeResponse.DescribeLiveDomainPublishErrorCode_Rtcd.DescribeLiveDomainPublishErrorCode_Cd> rtcd_codeData = new List<DescribeLiveDomainPublishErrorCodeResponse.DescribeLiveDomainPublishErrorCode_Rtcd.DescribeLiveDomainPublishErrorCode_Cd>();
				for (int j = 0; j < _ctx.Length("DescribeLiveDomainPublishErrorCode.RealTimeCodeData["+ i +"].CodeData.Length"); j++) {
					DescribeLiveDomainPublishErrorCodeResponse.DescribeLiveDomainPublishErrorCode_Rtcd.DescribeLiveDomainPublishErrorCode_Cd cd = new DescribeLiveDomainPublishErrorCodeResponse.DescribeLiveDomainPublishErrorCode_Rtcd.DescribeLiveDomainPublishErrorCode_Cd();
					cd.Code = _ctx.StringValue("DescribeLiveDomainPublishErrorCode.RealTimeCodeData["+ i +"].CodeData["+ j +"].Code");
					cd.Count = _ctx.StringValue("DescribeLiveDomainPublishErrorCode.RealTimeCodeData["+ i +"].CodeData["+ j +"].Count");
					cd.Proportion = _ctx.StringValue("DescribeLiveDomainPublishErrorCode.RealTimeCodeData["+ i +"].CodeData["+ j +"].Proportion");

					rtcd_codeData.Add(cd);
				}
				rtcd.CodeData = rtcd_codeData;

				describeLiveDomainPublishErrorCodeResponse_realTimeCodeData.Add(rtcd);
			}
			describeLiveDomainPublishErrorCodeResponse.RealTimeCodeData = describeLiveDomainPublishErrorCodeResponse_realTimeCodeData;
        
			return describeLiveDomainPublishErrorCodeResponse;
        }
    }
}
