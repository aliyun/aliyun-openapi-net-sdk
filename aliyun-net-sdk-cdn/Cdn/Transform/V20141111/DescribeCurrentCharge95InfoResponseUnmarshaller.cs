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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Cdn.Model.V20141111;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Cdn.Transform.V20141111
{
    public class DescribeCurrentCharge95InfoResponseUnmarshaller
    {
        public static DescribeCurrentCharge95InfoResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeCurrentCharge95InfoResponse describeCurrentCharge95InfoResponse = new DescribeCurrentCharge95InfoResponse();

			describeCurrentCharge95InfoResponse.HttpResponse = context.HttpResponse;
			describeCurrentCharge95InfoResponse.RequestId = context.StringValue("DescribeCurrentCharge95Info.RequestId");

			DescribeCurrentCharge95InfoResponse.CurrentCharge95Info_ currentCharge95Info = new DescribeCurrentCharge95InfoResponse.CurrentCharge95Info_();
			currentCharge95Info.Max95Bps = context.LongValue("DescribeCurrentCharge95Info.CurrentCharge95Info.Max95Bps");
			currentCharge95Info.DomesticMax95Bps = context.LongValue("DescribeCurrentCharge95Info.CurrentCharge95Info.DomesticMax95Bps");
			currentCharge95Info.OverseasMax95Bps = context.LongValue("DescribeCurrentCharge95Info.CurrentCharge95Info.OverseasMax95Bps");
			currentCharge95Info.EffectiveFactor = context.FloatValue("DescribeCurrentCharge95Info.CurrentCharge95Info.EffectiveFactor");
			currentCharge95Info.Cost = context.FloatValue("DescribeCurrentCharge95Info.CurrentCharge95Info.Cost");
			currentCharge95Info.UserName = context.StringValue("DescribeCurrentCharge95Info.CurrentCharge95Info.UserName");
			describeCurrentCharge95InfoResponse.CurrentCharge95Info = currentCharge95Info;
        
			return describeCurrentCharge95InfoResponse;
        }
    }
}