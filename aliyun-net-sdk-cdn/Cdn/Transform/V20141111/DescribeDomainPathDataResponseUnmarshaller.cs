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
    public class DescribeDomainPathDataResponseUnmarshaller
    {
        public static DescribeDomainPathDataResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDomainPathDataResponse describeDomainPathDataResponse = new DescribeDomainPathDataResponse();

			describeDomainPathDataResponse.HttpResponse = _ctx.HttpResponse;
			describeDomainPathDataResponse.RequestId = _ctx.StringValue("DescribeDomainPathData.RequestId");
			describeDomainPathDataResponse.DomainName = _ctx.StringValue("DescribeDomainPathData.DomainName");
			describeDomainPathDataResponse.StartTime = _ctx.StringValue("DescribeDomainPathData.StartTime");
			describeDomainPathDataResponse.EndTime = _ctx.StringValue("DescribeDomainPathData.EndTime");
			describeDomainPathDataResponse.PageSize = _ctx.IntegerValue("DescribeDomainPathData.PageSize");
			describeDomainPathDataResponse.PageNumber = _ctx.IntegerValue("DescribeDomainPathData.PageNumber");
			describeDomainPathDataResponse.DataInterval = _ctx.StringValue("DescribeDomainPathData.DataInterval");
			describeDomainPathDataResponse.TotalCount = _ctx.IntegerValue("DescribeDomainPathData.TotalCount");

			List<DescribeDomainPathDataResponse.DescribeDomainPathData_UsageData> describeDomainPathDataResponse_pathDataPerInterval = new List<DescribeDomainPathDataResponse.DescribeDomainPathData_UsageData>();
			for (int i = 0; i < _ctx.Length("DescribeDomainPathData.PathDataPerInterval.Length"); i++) {
				DescribeDomainPathDataResponse.DescribeDomainPathData_UsageData usageData = new DescribeDomainPathDataResponse.DescribeDomainPathData_UsageData();
				usageData.Traffic = _ctx.IntegerValue("DescribeDomainPathData.PathDataPerInterval["+ i +"].Traffic");
				usageData.Acc = _ctx.IntegerValue("DescribeDomainPathData.PathDataPerInterval["+ i +"].Acc");
				usageData.Path = _ctx.StringValue("DescribeDomainPathData.PathDataPerInterval["+ i +"].Path");
				usageData.Time = _ctx.StringValue("DescribeDomainPathData.PathDataPerInterval["+ i +"].Time");

				describeDomainPathDataResponse_pathDataPerInterval.Add(usageData);
			}
			describeDomainPathDataResponse.PathDataPerInterval = describeDomainPathDataResponse_pathDataPerInterval;
        
			return describeDomainPathDataResponse;
        }
    }
}
