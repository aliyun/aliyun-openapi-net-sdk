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
    public class DescribeDomainSlowRatioResponseUnmarshaller
    {
        public static DescribeDomainSlowRatioResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDomainSlowRatioResponse describeDomainSlowRatioResponse = new DescribeDomainSlowRatioResponse();

			describeDomainSlowRatioResponse.HttpResponse = _ctx.HttpResponse;
			describeDomainSlowRatioResponse.EndTime = _ctx.StringValue("DescribeDomainSlowRatio.EndTime");
			describeDomainSlowRatioResponse.DataInterval = _ctx.IntegerValue("DescribeDomainSlowRatio.DataInterval");
			describeDomainSlowRatioResponse.PageNumber = _ctx.IntegerValue("DescribeDomainSlowRatio.PageNumber");
			describeDomainSlowRatioResponse.PageSize = _ctx.IntegerValue("DescribeDomainSlowRatio.PageSize");
			describeDomainSlowRatioResponse.TotalCount = _ctx.IntegerValue("DescribeDomainSlowRatio.TotalCount");
			describeDomainSlowRatioResponse.StartTime = _ctx.StringValue("DescribeDomainSlowRatio.StartTime");

			List<DescribeDomainSlowRatioResponse.DescribeDomainSlowRatio_SlowRatioData> describeDomainSlowRatioResponse_slowRatioDataPerInterval = new List<DescribeDomainSlowRatioResponse.DescribeDomainSlowRatio_SlowRatioData>();
			for (int i = 0; i < _ctx.Length("DescribeDomainSlowRatio.SlowRatioDataPerInterval.Length"); i++) {
				DescribeDomainSlowRatioResponse.DescribeDomainSlowRatio_SlowRatioData slowRatioData = new DescribeDomainSlowRatioResponse.DescribeDomainSlowRatio_SlowRatioData();
				slowRatioData.TotalUsers = _ctx.IntegerValue("DescribeDomainSlowRatio.SlowRatioDataPerInterval["+ i +"].TotalUsers");
				slowRatioData.SlowUsers = _ctx.IntegerValue("DescribeDomainSlowRatio.SlowRatioDataPerInterval["+ i +"].SlowUsers");
				slowRatioData.SlowRatio = _ctx.FloatValue("DescribeDomainSlowRatio.SlowRatioDataPerInterval["+ i +"].SlowRatio");
				slowRatioData.RegionNameZh = _ctx.StringValue("DescribeDomainSlowRatio.SlowRatioDataPerInterval["+ i +"].RegionNameZh");
				slowRatioData.RegionNameEn = _ctx.StringValue("DescribeDomainSlowRatio.SlowRatioDataPerInterval["+ i +"].RegionNameEn");
				slowRatioData.IspNameZh = _ctx.StringValue("DescribeDomainSlowRatio.SlowRatioDataPerInterval["+ i +"].IspNameZh");
				slowRatioData.IspNameEn = _ctx.StringValue("DescribeDomainSlowRatio.SlowRatioDataPerInterval["+ i +"].IspNameEn");
				slowRatioData.Time = _ctx.StringValue("DescribeDomainSlowRatio.SlowRatioDataPerInterval["+ i +"].Time");

				describeDomainSlowRatioResponse_slowRatioDataPerInterval.Add(slowRatioData);
			}
			describeDomainSlowRatioResponse.SlowRatioDataPerInterval = describeDomainSlowRatioResponse_slowRatioDataPerInterval;
        
			return describeDomainSlowRatioResponse;
        }
    }
}
