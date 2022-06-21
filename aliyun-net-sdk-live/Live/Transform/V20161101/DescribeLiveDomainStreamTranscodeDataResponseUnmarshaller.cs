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
    public class DescribeLiveDomainStreamTranscodeDataResponseUnmarshaller
    {
        public static DescribeLiveDomainStreamTranscodeDataResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeLiveDomainStreamTranscodeDataResponse describeLiveDomainStreamTranscodeDataResponse = new DescribeLiveDomainStreamTranscodeDataResponse();

			describeLiveDomainStreamTranscodeDataResponse.HttpResponse = _ctx.HttpResponse;
			describeLiveDomainStreamTranscodeDataResponse.RequestId = _ctx.StringValue("DescribeLiveDomainStreamTranscodeData.RequestId");

			List<DescribeLiveDomainStreamTranscodeDataResponse.DescribeLiveDomainStreamTranscodeData_TranscodeData> describeLiveDomainStreamTranscodeDataResponse_transcodeDataList = new List<DescribeLiveDomainStreamTranscodeDataResponse.DescribeLiveDomainStreamTranscodeData_TranscodeData>();
			for (int i = 0; i < _ctx.Length("DescribeLiveDomainStreamTranscodeData.TranscodeDataList.Length"); i++) {
				DescribeLiveDomainStreamTranscodeDataResponse.DescribeLiveDomainStreamTranscodeData_TranscodeData transcodeData = new DescribeLiveDomainStreamTranscodeDataResponse.DescribeLiveDomainStreamTranscodeData_TranscodeData();
				transcodeData.TimeStamp = _ctx.StringValue("DescribeLiveDomainStreamTranscodeData.TranscodeDataList["+ i +"].TimeStamp");
				transcodeData.Domain = _ctx.StringValue("DescribeLiveDomainStreamTranscodeData.TranscodeDataList["+ i +"].Domain");
				transcodeData.Region = _ctx.StringValue("DescribeLiveDomainStreamTranscodeData.TranscodeDataList["+ i +"].Region");
				transcodeData.TanscodeType = _ctx.StringValue("DescribeLiveDomainStreamTranscodeData.TranscodeDataList["+ i +"].TanscodeType");
				transcodeData.Resolution = _ctx.StringValue("DescribeLiveDomainStreamTranscodeData.TranscodeDataList["+ i +"].Resolution");
				transcodeData.Fps = _ctx.StringValue("DescribeLiveDomainStreamTranscodeData.TranscodeDataList["+ i +"].Fps");
				transcodeData.Duration = _ctx.IntegerValue("DescribeLiveDomainStreamTranscodeData.TranscodeDataList["+ i +"].Duration");

				describeLiveDomainStreamTranscodeDataResponse_transcodeDataList.Add(transcodeData);
			}
			describeLiveDomainStreamTranscodeDataResponse.TranscodeDataList = describeLiveDomainStreamTranscodeDataResponse_transcodeDataList;
        
			return describeLiveDomainStreamTranscodeDataResponse;
        }
    }
}
