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
    public class DescribeIpDdosThresholdResponseUnmarshaller
    {
        public static DescribeIpDdosThresholdResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeIpDdosThresholdResponse describeIpDdosThresholdResponse = new DescribeIpDdosThresholdResponse();

			describeIpDdosThresholdResponse.HttpResponse = _ctx.HttpResponse;
			describeIpDdosThresholdResponse.RequestId = _ctx.StringValue("DescribeIpDdosThreshold.RequestId");

			DescribeIpDdosThresholdResponse.DescribeIpDdosThreshold_Threshold threshold = new DescribeIpDdosThresholdResponse.DescribeIpDdosThreshold_Threshold();
			threshold.DdosType = _ctx.StringValue("DescribeIpDdosThreshold.Threshold.DdosType");
			threshold.IsAuto = _ctx.BooleanValue("DescribeIpDdosThreshold.Threshold.IsAuto");
			threshold.MaxBps = _ctx.IntegerValue("DescribeIpDdosThreshold.Threshold.MaxBps");
			threshold.ElasticBps = _ctx.IntegerValue("DescribeIpDdosThreshold.Threshold.ElasticBps");
			threshold.InstanceId = _ctx.StringValue("DescribeIpDdosThreshold.Threshold.InstanceId");
			threshold.Bps = _ctx.IntegerValue("DescribeIpDdosThreshold.Threshold.Bps");
			threshold.Pps = _ctx.IntegerValue("DescribeIpDdosThreshold.Threshold.Pps");
			threshold.MaxPps = _ctx.IntegerValue("DescribeIpDdosThreshold.Threshold.MaxPps");
			threshold.InternetIp = _ctx.StringValue("DescribeIpDdosThreshold.Threshold.InternetIp");
			describeIpDdosThresholdResponse.Threshold = threshold;
        
			return describeIpDdosThresholdResponse;
        }
    }
}
