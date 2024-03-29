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
using Aliyun.Acs.Sas.Model.V20181203;

namespace Aliyun.Acs.Sas.Transform.V20181203
{
    public class DescribeStrategyTargetResponseUnmarshaller
    {
        public static DescribeStrategyTargetResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeStrategyTargetResponse describeStrategyTargetResponse = new DescribeStrategyTargetResponse();

			describeStrategyTargetResponse.HttpResponse = _ctx.HttpResponse;
			describeStrategyTargetResponse.RequestId = _ctx.StringValue("DescribeStrategyTarget.RequestId");

			List<DescribeStrategyTargetResponse.DescribeStrategyTarget_StrategyTarget> describeStrategyTargetResponse_strategyTargets = new List<DescribeStrategyTargetResponse.DescribeStrategyTarget_StrategyTarget>();
			for (int i = 0; i < _ctx.Length("DescribeStrategyTarget.StrategyTargets.Length"); i++) {
				DescribeStrategyTargetResponse.DescribeStrategyTarget_StrategyTarget strategyTarget = new DescribeStrategyTargetResponse.DescribeStrategyTarget_StrategyTarget();
				strategyTarget.BindUuidCount = _ctx.IntegerValue("DescribeStrategyTarget.StrategyTargets["+ i +"].BindUuidCount");
				strategyTarget.Flag = _ctx.StringValue("DescribeStrategyTarget.StrategyTargets["+ i +"].Flag");
				strategyTarget.Target = _ctx.StringValue("DescribeStrategyTarget.StrategyTargets["+ i +"].Target");
				strategyTarget.TargetType = _ctx.StringValue("DescribeStrategyTarget.StrategyTargets["+ i +"].TargetType");

				describeStrategyTargetResponse_strategyTargets.Add(strategyTarget);
			}
			describeStrategyTargetResponse.StrategyTargets = describeStrategyTargetResponse_strategyTargets;
        
			return describeStrategyTargetResponse;
        }
    }
}
