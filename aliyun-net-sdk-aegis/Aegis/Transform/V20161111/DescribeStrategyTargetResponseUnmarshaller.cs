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
using Aliyun.Acs.aegis.Model.V20161111;

namespace Aliyun.Acs.aegis.Transform.V20161111
{
    public class DescribeStrategyTargetResponseUnmarshaller
    {
        public static DescribeStrategyTargetResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeStrategyTargetResponse describeStrategyTargetResponse = new DescribeStrategyTargetResponse();

			describeStrategyTargetResponse.HttpResponse = context.HttpResponse;
			describeStrategyTargetResponse.RequestId = context.StringValue("DescribeStrategyTarget.RequestId");

			List<DescribeStrategyTargetResponse.DescribeStrategyTarget_StrategyTarget> describeStrategyTargetResponse_strategyTargets = new List<DescribeStrategyTargetResponse.DescribeStrategyTarget_StrategyTarget>();
			for (int i = 0; i < context.Length("DescribeStrategyTarget.StrategyTargets.Length"); i++) {
				DescribeStrategyTargetResponse.DescribeStrategyTarget_StrategyTarget strategyTarget = new DescribeStrategyTargetResponse.DescribeStrategyTarget_StrategyTarget();
				strategyTarget.Flag = context.StringValue("DescribeStrategyTarget.StrategyTargets["+ i +"].Flag");
				strategyTarget.Target = context.StringValue("DescribeStrategyTarget.StrategyTargets["+ i +"].Target");
				strategyTarget.TargetType = context.StringValue("DescribeStrategyTarget.StrategyTargets["+ i +"].TargetType");

				describeStrategyTargetResponse_strategyTargets.Add(strategyTarget);
			}
			describeStrategyTargetResponse.StrategyTargets = describeStrategyTargetResponse_strategyTargets;
        
			return describeStrategyTargetResponse;
        }
    }
}
