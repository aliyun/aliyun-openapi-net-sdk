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
    public class DescribeLiveDomainTranscodeDataResponseUnmarshaller
    {
        public static DescribeLiveDomainTranscodeDataResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeLiveDomainTranscodeDataResponse describeLiveDomainTranscodeDataResponse = new DescribeLiveDomainTranscodeDataResponse();

			describeLiveDomainTranscodeDataResponse.HttpResponse = _ctx.HttpResponse;
			describeLiveDomainTranscodeDataResponse.RequestId = _ctx.StringValue("DescribeLiveDomainTranscodeData.RequestId");

			List<DescribeLiveDomainTranscodeDataResponse.DescribeLiveDomainTranscodeData_TranscodeDataInfo> describeLiveDomainTranscodeDataResponse_transcodeDataInfos = new List<DescribeLiveDomainTranscodeDataResponse.DescribeLiveDomainTranscodeData_TranscodeDataInfo>();
			for (int i = 0; i < _ctx.Length("DescribeLiveDomainTranscodeData.TranscodeDataInfos.Length"); i++) {
				DescribeLiveDomainTranscodeDataResponse.DescribeLiveDomainTranscodeData_TranscodeDataInfo transcodeDataInfo = new DescribeLiveDomainTranscodeDataResponse.DescribeLiveDomainTranscodeData_TranscodeDataInfo();
				transcodeDataInfo.Date = _ctx.StringValue("DescribeLiveDomainTranscodeData.TranscodeDataInfos["+ i +"].Date");
				transcodeDataInfo.Total = _ctx.IntegerValue("DescribeLiveDomainTranscodeData.TranscodeDataInfos["+ i +"].Total");
				transcodeDataInfo.Detail = _ctx.StringValue("DescribeLiveDomainTranscodeData.TranscodeDataInfos["+ i +"].Detail");

				describeLiveDomainTranscodeDataResponse_transcodeDataInfos.Add(transcodeDataInfo);
			}
			describeLiveDomainTranscodeDataResponse.TranscodeDataInfos = describeLiveDomainTranscodeDataResponse_transcodeDataInfos;
        
			return describeLiveDomainTranscodeDataResponse;
        }
    }
}
