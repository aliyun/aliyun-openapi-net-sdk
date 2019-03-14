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
using Aliyun.Acs.Cbn.Model.V20170912;

namespace Aliyun.Acs.Cbn.Transform.V20170912
{
    public class DescribeCenInterRegionBandwidthLimitsResponseUnmarshaller
    {
        public static DescribeCenInterRegionBandwidthLimitsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeCenInterRegionBandwidthLimitsResponse describeCenInterRegionBandwidthLimitsResponse = new DescribeCenInterRegionBandwidthLimitsResponse();

			describeCenInterRegionBandwidthLimitsResponse.HttpResponse = context.HttpResponse;
			describeCenInterRegionBandwidthLimitsResponse.RequestId = context.StringValue("DescribeCenInterRegionBandwidthLimits.RequestId");
			describeCenInterRegionBandwidthLimitsResponse.TotalCount = context.IntegerValue("DescribeCenInterRegionBandwidthLimits.TotalCount");
			describeCenInterRegionBandwidthLimitsResponse.PageNumber = context.IntegerValue("DescribeCenInterRegionBandwidthLimits.PageNumber");
			describeCenInterRegionBandwidthLimitsResponse.PageSize = context.IntegerValue("DescribeCenInterRegionBandwidthLimits.PageSize");

			List<DescribeCenInterRegionBandwidthLimitsResponse.DescribeCenInterRegionBandwidthLimits_CenInterRegionBandwidthLimit> describeCenInterRegionBandwidthLimitsResponse_cenInterRegionBandwidthLimits = new List<DescribeCenInterRegionBandwidthLimitsResponse.DescribeCenInterRegionBandwidthLimits_CenInterRegionBandwidthLimit>();
			for (int i = 0; i < context.Length("DescribeCenInterRegionBandwidthLimits.CenInterRegionBandwidthLimits.Length"); i++) {
				DescribeCenInterRegionBandwidthLimitsResponse.DescribeCenInterRegionBandwidthLimits_CenInterRegionBandwidthLimit cenInterRegionBandwidthLimit = new DescribeCenInterRegionBandwidthLimitsResponse.DescribeCenInterRegionBandwidthLimits_CenInterRegionBandwidthLimit();
				cenInterRegionBandwidthLimit.CenId = context.StringValue("DescribeCenInterRegionBandwidthLimits.CenInterRegionBandwidthLimits["+ i +"].CenId");
				cenInterRegionBandwidthLimit.LocalRegionId = context.StringValue("DescribeCenInterRegionBandwidthLimits.CenInterRegionBandwidthLimits["+ i +"].LocalRegionId");
				cenInterRegionBandwidthLimit.OppositeRegionId = context.StringValue("DescribeCenInterRegionBandwidthLimits.CenInterRegionBandwidthLimits["+ i +"].OppositeRegionId");
				cenInterRegionBandwidthLimit.GeographicSpanId = context.StringValue("DescribeCenInterRegionBandwidthLimits.CenInterRegionBandwidthLimits["+ i +"].GeographicSpanId");
				cenInterRegionBandwidthLimit.BandwidthLimit = context.LongValue("DescribeCenInterRegionBandwidthLimits.CenInterRegionBandwidthLimits["+ i +"].BandwidthLimit");
				cenInterRegionBandwidthLimit.Status = context.StringValue("DescribeCenInterRegionBandwidthLimits.CenInterRegionBandwidthLimits["+ i +"].Status");

				describeCenInterRegionBandwidthLimitsResponse_cenInterRegionBandwidthLimits.Add(cenInterRegionBandwidthLimit);
			}
			describeCenInterRegionBandwidthLimitsResponse.CenInterRegionBandwidthLimits = describeCenInterRegionBandwidthLimitsResponse_cenInterRegionBandwidthLimits;
        
			return describeCenInterRegionBandwidthLimitsResponse;
        }
    }
}
