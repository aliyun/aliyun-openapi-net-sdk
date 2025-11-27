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
using Aliyun.Acs.vod.Model.V20170321;

namespace Aliyun.Acs.vod.Transform.V20170321
{
    public class DescribeMediaDistributionResponseUnmarshaller
    {
        public static DescribeMediaDistributionResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeMediaDistributionResponse describeMediaDistributionResponse = new DescribeMediaDistributionResponse();

			describeMediaDistributionResponse.HttpResponse = _ctx.HttpResponse;
			describeMediaDistributionResponse.RequestId = _ctx.StringValue("DescribeMediaDistribution.RequestId");
			describeMediaDistributionResponse.Total = _ctx.LongValue("DescribeMediaDistribution.Total");

			List<DescribeMediaDistributionResponse.DescribeMediaDistribution_MediaDistribution> describeMediaDistributionResponse_mediaDistributionList = new List<DescribeMediaDistributionResponse.DescribeMediaDistribution_MediaDistribution>();
			for (int i = 0; i < _ctx.Length("DescribeMediaDistribution.MediaDistributionList.Length"); i++) {
				DescribeMediaDistributionResponse.DescribeMediaDistribution_MediaDistribution mediaDistribution = new DescribeMediaDistributionResponse.DescribeMediaDistribution_MediaDistribution();
				mediaDistribution.StartTime = _ctx.StringValue("DescribeMediaDistribution.MediaDistributionList["+ i +"].StartTime");
				mediaDistribution.EndTime = _ctx.StringValue("DescribeMediaDistribution.MediaDistributionList["+ i +"].EndTime");
				mediaDistribution.Count = _ctx.LongValue("DescribeMediaDistribution.MediaDistributionList["+ i +"].Count");

				describeMediaDistributionResponse_mediaDistributionList.Add(mediaDistribution);
			}
			describeMediaDistributionResponse.MediaDistributionList = describeMediaDistributionResponse_mediaDistributionList;
        
			return describeMediaDistributionResponse;
        }
    }
}
