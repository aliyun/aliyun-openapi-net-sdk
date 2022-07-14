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
using Aliyun.Acs.antiddos_public.Model.V20170518;

namespace Aliyun.Acs.antiddos_public.Transform.V20170518
{
    public class DescribeDdosThresholdResponseUnmarshaller
    {
        public static DescribeDdosThresholdResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDdosThresholdResponse describeDdosThresholdResponse = new DescribeDdosThresholdResponse();

			describeDdosThresholdResponse.HttpResponse = _ctx.HttpResponse;
			describeDdosThresholdResponse.RequestId = _ctx.StringValue("DescribeDdosThreshold.RequestId");

			List<DescribeDdosThresholdResponse.DescribeDdosThreshold_Threshold> describeDdosThresholdResponse_thresholds = new List<DescribeDdosThresholdResponse.DescribeDdosThreshold_Threshold>();
			for (int i = 0; i < _ctx.Length("DescribeDdosThreshold.Thresholds.Length"); i++) {
				DescribeDdosThresholdResponse.DescribeDdosThreshold_Threshold threshold = new DescribeDdosThresholdResponse.DescribeDdosThreshold_Threshold();
				threshold.DdosType = _ctx.StringValue("DescribeDdosThreshold.Thresholds["+ i +"].DdosType");
				threshold.IsAuto = _ctx.BooleanValue("DescribeDdosThreshold.Thresholds["+ i +"].IsAuto");
				threshold.MaxBps = _ctx.IntegerValue("DescribeDdosThreshold.Thresholds["+ i +"].MaxBps");
				threshold.ElasticBps = _ctx.IntegerValue("DescribeDdosThreshold.Thresholds["+ i +"].ElasticBps");
				threshold.InstanceId = _ctx.StringValue("DescribeDdosThreshold.Thresholds["+ i +"].InstanceId");
				threshold.Bps = _ctx.IntegerValue("DescribeDdosThreshold.Thresholds["+ i +"].Bps");
				threshold.Pps = _ctx.IntegerValue("DescribeDdosThreshold.Thresholds["+ i +"].Pps");
				threshold.MaxPps = _ctx.IntegerValue("DescribeDdosThreshold.Thresholds["+ i +"].MaxPps");
				threshold.InternetIp = _ctx.StringValue("DescribeDdosThreshold.Thresholds["+ i +"].InternetIp");

				describeDdosThresholdResponse_thresholds.Add(threshold);
			}
			describeDdosThresholdResponse.Thresholds = describeDdosThresholdResponse_thresholds;
        
			return describeDdosThresholdResponse;
        }
    }
}
