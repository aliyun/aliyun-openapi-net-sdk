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
    public class DescribeTargetResponseUnmarshaller
    {
        public static DescribeTargetResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeTargetResponse describeTargetResponse = new DescribeTargetResponse();

			describeTargetResponse.HttpResponse = context.HttpResponse;
			describeTargetResponse.RequestId = context.StringValue("DescribeTarget.RequestId");
			describeTargetResponse.TotalCount = context.IntegerValue("DescribeTarget.TotalCount");

			List<DescribeTargetResponse.DescribeTarget_Target> describeTargetResponse_targets = new List<DescribeTargetResponse.DescribeTarget_Target>();
			for (int i = 0; i < context.Length("DescribeTarget.Targets.Length"); i++) {
				DescribeTargetResponse.DescribeTarget_Target target = new DescribeTargetResponse.DescribeTarget_Target();
				target.TargetType = context.StringValue("DescribeTarget.Targets["+ i +"].TargetType");
				target.Target = context.StringValue("DescribeTarget.Targets["+ i +"].Target");
				target.Flag = context.StringValue("DescribeTarget.Targets["+ i +"].Flag");

				describeTargetResponse_targets.Add(target);
			}
			describeTargetResponse.Targets = describeTargetResponse_targets;
        
			return describeTargetResponse;
        }
    }
}
