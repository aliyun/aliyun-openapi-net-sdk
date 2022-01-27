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
    public class DescribeLiveDomainStreamWaterLevelResponseUnmarshaller
    {
        public static DescribeLiveDomainStreamWaterLevelResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeLiveDomainStreamWaterLevelResponse describeLiveDomainStreamWaterLevelResponse = new DescribeLiveDomainStreamWaterLevelResponse();

			describeLiveDomainStreamWaterLevelResponse.HttpResponse = _ctx.HttpResponse;
			describeLiveDomainStreamWaterLevelResponse.RequestId = _ctx.StringValue("DescribeLiveDomainStreamWaterLevel.RequestId");

			DescribeLiveDomainStreamWaterLevelResponse.DescribeLiveDomainStreamWaterLevel_LiveUidWaterLevel liveUidWaterLevel = new DescribeLiveDomainStreamWaterLevelResponse.DescribeLiveDomainStreamWaterLevel_LiveUidWaterLevel();
			liveUidWaterLevel.AliUid = _ctx.StringValue("DescribeLiveDomainStreamWaterLevel.LiveUidWaterLevel.AliUid");
			liveUidWaterLevel.UidRawCount = _ctx.IntegerValue("DescribeLiveDomainStreamWaterLevel.LiveUidWaterLevel.UidRawCount");
			liveUidWaterLevel.UidTranscodeCount = _ctx.IntegerValue("DescribeLiveDomainStreamWaterLevel.LiveUidWaterLevel.UidTranscodeCount");
			liveUidWaterLevel.UidRawLimit = _ctx.IntegerValue("DescribeLiveDomainStreamWaterLevel.LiveUidWaterLevel.UidRawLimit");
			liveUidWaterLevel.UidTranscodeLimit = _ctx.IntegerValue("DescribeLiveDomainStreamWaterLevel.LiveUidWaterLevel.UidTranscodeLimit");
			describeLiveDomainStreamWaterLevelResponse.LiveUidWaterLevel = liveUidWaterLevel;

			List<DescribeLiveDomainStreamWaterLevelResponse.DescribeLiveDomainStreamWaterLevel_LiveDomainWaterLevel> describeLiveDomainStreamWaterLevelResponse_liveDomainWaterLevelList = new List<DescribeLiveDomainStreamWaterLevelResponse.DescribeLiveDomainStreamWaterLevel_LiveDomainWaterLevel>();
			for (int i = 0; i < _ctx.Length("DescribeLiveDomainStreamWaterLevel.LiveDomainWaterLevelList.Length"); i++) {
				DescribeLiveDomainStreamWaterLevelResponse.DescribeLiveDomainStreamWaterLevel_LiveDomainWaterLevel liveDomainWaterLevel = new DescribeLiveDomainStreamWaterLevelResponse.DescribeLiveDomainStreamWaterLevel_LiveDomainWaterLevel();
				liveDomainWaterLevel.DomainName = _ctx.StringValue("DescribeLiveDomainStreamWaterLevel.LiveDomainWaterLevelList["+ i +"].DomainName");
				liveDomainWaterLevel.DomainRawCount = _ctx.IntegerValue("DescribeLiveDomainStreamWaterLevel.LiveDomainWaterLevelList["+ i +"].DomainRawCount");
				liveDomainWaterLevel.DomainTranscodeCount = _ctx.IntegerValue("DescribeLiveDomainStreamWaterLevel.LiveDomainWaterLevelList["+ i +"].DomainTranscodeCount");
				liveDomainWaterLevel.DomainRawLimit = _ctx.IntegerValue("DescribeLiveDomainStreamWaterLevel.LiveDomainWaterLevelList["+ i +"].DomainRawLimit");
				liveDomainWaterLevel.DomainTranscodeLimit = _ctx.IntegerValue("DescribeLiveDomainStreamWaterLevel.LiveDomainWaterLevelList["+ i +"].DomainTranscodeLimit");

				describeLiveDomainStreamWaterLevelResponse_liveDomainWaterLevelList.Add(liveDomainWaterLevel);
			}
			describeLiveDomainStreamWaterLevelResponse.LiveDomainWaterLevelList = describeLiveDomainStreamWaterLevelResponse_liveDomainWaterLevelList;
        
			return describeLiveDomainStreamWaterLevelResponse;
        }
    }
}
