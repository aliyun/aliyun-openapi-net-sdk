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
using Aliyun.Acs.Green.Model.V20170823;

namespace Aliyun.Acs.Green.Transform.V20170823
{
    public class DescribeOssIncrementOverviewResponseUnmarshaller
    {
        public static DescribeOssIncrementOverviewResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeOssIncrementOverviewResponse describeOssIncrementOverviewResponse = new DescribeOssIncrementOverviewResponse();

			describeOssIncrementOverviewResponse.HttpResponse = _ctx.HttpResponse;
			describeOssIncrementOverviewResponse.RequestId = _ctx.StringValue("DescribeOssIncrementOverview.RequestId");
			describeOssIncrementOverviewResponse.ImageCount = _ctx.IntegerValue("DescribeOssIncrementOverview.ImageCount");
			describeOssIncrementOverviewResponse.VideoCount = _ctx.IntegerValue("DescribeOssIncrementOverview.VideoCount");
			describeOssIncrementOverviewResponse.VideoFrameCount = _ctx.IntegerValue("DescribeOssIncrementOverview.VideoFrameCount");
			describeOssIncrementOverviewResponse.PornUnhandleCount = _ctx.IntegerValue("DescribeOssIncrementOverview.PornUnhandleCount");
			describeOssIncrementOverviewResponse.TerrorismUnhandleCount = _ctx.IntegerValue("DescribeOssIncrementOverview.TerrorismUnhandleCount");
			describeOssIncrementOverviewResponse.AdUnhandleCount = _ctx.IntegerValue("DescribeOssIncrementOverview.AdUnhandleCount");
			describeOssIncrementOverviewResponse.LiveUnhandleCount = _ctx.IntegerValue("DescribeOssIncrementOverview.LiveUnhandleCount");
			describeOssIncrementOverviewResponse.VoiceAntispamUnhandleCount = _ctx.IntegerValue("DescribeOssIncrementOverview.VoiceAntispamUnhandleCount");
        
			return describeOssIncrementOverviewResponse;
        }
    }
}
