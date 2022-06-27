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
    public class DescribeLiveStreamTranscodeStreamNumResponseUnmarshaller
    {
        public static DescribeLiveStreamTranscodeStreamNumResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeLiveStreamTranscodeStreamNumResponse describeLiveStreamTranscodeStreamNumResponse = new DescribeLiveStreamTranscodeStreamNumResponse();

			describeLiveStreamTranscodeStreamNumResponse.HttpResponse = _ctx.HttpResponse;
			describeLiveStreamTranscodeStreamNumResponse.RequestId = _ctx.StringValue("DescribeLiveStreamTranscodeStreamNum.RequestId");
			describeLiveStreamTranscodeStreamNumResponse.Total = _ctx.LongValue("DescribeLiveStreamTranscodeStreamNum.Total");
			describeLiveStreamTranscodeStreamNumResponse.TranscodedNumber = _ctx.LongValue("DescribeLiveStreamTranscodeStreamNum.TranscodedNumber");
			describeLiveStreamTranscodeStreamNumResponse.UntranscodeNumber = _ctx.LongValue("DescribeLiveStreamTranscodeStreamNum.UntranscodeNumber");
			describeLiveStreamTranscodeStreamNumResponse.LazyTranscodedNumber = _ctx.LongValue("DescribeLiveStreamTranscodeStreamNum.LazyTranscodedNumber");
        
			return describeLiveStreamTranscodeStreamNumResponse;
        }
    }
}
