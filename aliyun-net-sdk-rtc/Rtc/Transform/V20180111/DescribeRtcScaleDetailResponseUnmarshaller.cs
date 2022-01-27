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
using Aliyun.Acs.rtc.Model.V20180111;

namespace Aliyun.Acs.rtc.Transform.V20180111
{
    public class DescribeRtcScaleDetailResponseUnmarshaller
    {
        public static DescribeRtcScaleDetailResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeRtcScaleDetailResponse describeRtcScaleDetailResponse = new DescribeRtcScaleDetailResponse();

			describeRtcScaleDetailResponse.HttpResponse = _ctx.HttpResponse;
			describeRtcScaleDetailResponse.RequestId = _ctx.StringValue("DescribeRtcScaleDetail.RequestId");

			List<DescribeRtcScaleDetailResponse.DescribeRtcScaleDetail_ScaleItem> describeRtcScaleDetailResponse_scale = new List<DescribeRtcScaleDetailResponse.DescribeRtcScaleDetail_ScaleItem>();
			for (int i = 0; i < _ctx.Length("DescribeRtcScaleDetail.Scale.Length"); i++) {
				DescribeRtcScaleDetailResponse.DescribeRtcScaleDetail_ScaleItem scaleItem = new DescribeRtcScaleDetailResponse.DescribeRtcScaleDetail_ScaleItem();
				scaleItem.TS = _ctx.StringValue("DescribeRtcScaleDetail.Scale["+ i +"].TS");
				scaleItem.CC = _ctx.LongValue("DescribeRtcScaleDetail.Scale["+ i +"].CC");
				scaleItem.UC = _ctx.LongValue("DescribeRtcScaleDetail.Scale["+ i +"].UC");

				describeRtcScaleDetailResponse_scale.Add(scaleItem);
			}
			describeRtcScaleDetailResponse.Scale = describeRtcScaleDetailResponse_scale;
        
			return describeRtcScaleDetailResponse;
        }
    }
}
