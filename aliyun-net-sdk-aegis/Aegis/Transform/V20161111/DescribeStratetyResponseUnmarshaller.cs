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
using Aliyun.Acs.aegis.Model.V20161111;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.aegis.Transform.V20161111
{
    public class DescribeStratetyResponseUnmarshaller
    {
        public static DescribeStratetyResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeStratetyResponse describeStratetyResponse = new DescribeStratetyResponse();

			describeStratetyResponse.HttpResponse = context.HttpResponse;
			describeStratetyResponse.RequestId = context.StringValue("DescribeStratety.RequestId");
			describeStratetyResponse.Count = context.IntegerValue("DescribeStratety.Count");

			List<DescribeStratetyResponse.DescribeStratety_Data> describeStratetyResponse_strategies = new List<DescribeStratetyResponse.DescribeStratety_Data>();
			for (int i = 0; i < context.Length("DescribeStratety.Strategies.Length"); i++) {
				DescribeStratetyResponse.DescribeStratety_Data data = new DescribeStratetyResponse.DescribeStratety_Data();
				data.CycleDays = context.IntegerValue("DescribeStratety.Strategies["+ i +"].CycleDays");
				data.Id = context.IntegerValue("DescribeStratety.Strategies["+ i +"].Id");
				data.CycleStartTime = context.IntegerValue("DescribeStratety.Strategies["+ i +"].CycleStartTime");
				data.Type = context.IntegerValue("DescribeStratety.Strategies["+ i +"].Type");
				data.Name = context.StringValue("DescribeStratety.Strategies["+ i +"].Name");
				data.RiskCount = context.IntegerValue("DescribeStratety.Strategies["+ i +"].RiskCount");
				data.EcsCount = context.IntegerValue("DescribeStratety.Strategies["+ i +"].EcsCount");

				List<DescribeStratetyResponse.DescribeStratety_Data.DescribeStratety_ConfigTarget> data_configTargets = new List<DescribeStratetyResponse.DescribeStratety_Data.DescribeStratety_ConfigTarget>();
				for (int j = 0; j < context.Length("DescribeStratety.Strategies["+ i +"].ConfigTargets.Length"); j++) {
					DescribeStratetyResponse.DescribeStratety_Data.DescribeStratety_ConfigTarget configTarget = new DescribeStratetyResponse.DescribeStratety_Data.DescribeStratety_ConfigTarget();
					configTarget.Flag = context.StringValue("DescribeStratety.Strategies["+ i +"].ConfigTargets["+ j +"].Flag");
					configTarget.TargetType = context.StringValue("DescribeStratety.Strategies["+ i +"].ConfigTargets["+ j +"].TargetType");
					configTarget.Target = context.StringValue("DescribeStratety.Strategies["+ i +"].ConfigTargets["+ j +"].Target");

					data_configTargets.Add(configTarget);
				}
				data.ConfigTargets = data_configTargets;

				describeStratetyResponse_strategies.Add(data);
			}
			describeStratetyResponse.Strategies = describeStratetyResponse_strategies;
        
			return describeStratetyResponse;
        }
    }
}