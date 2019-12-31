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
using Aliyun.Acs.Rds.Model.V20140815;

namespace Aliyun.Acs.Rds.Transform.V20140815
{
    public class DescribeParameterGroupsResponseUnmarshaller
    {
        public static DescribeParameterGroupsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeParameterGroupsResponse describeParameterGroupsResponse = new DescribeParameterGroupsResponse();

			describeParameterGroupsResponse.HttpResponse = context.HttpResponse;
			describeParameterGroupsResponse.RequestId = context.StringValue("DescribeParameterGroups.RequestId");
			describeParameterGroupsResponse.SignalForOptimizeParams = context.BooleanValue("DescribeParameterGroups.SignalForOptimizeParams");

			List<DescribeParameterGroupsResponse.DescribeParameterGroups_ParameterGroup> describeParameterGroupsResponse_parameterGroups = new List<DescribeParameterGroupsResponse.DescribeParameterGroups_ParameterGroup>();
			for (int i = 0; i < context.Length("DescribeParameterGroups.ParameterGroups.Length"); i++) {
				DescribeParameterGroupsResponse.DescribeParameterGroups_ParameterGroup parameterGroup = new DescribeParameterGroupsResponse.DescribeParameterGroups_ParameterGroup();
				parameterGroup.ParameterGroupType = context.IntegerValue("DescribeParameterGroups.ParameterGroups["+ i +"].ParameterGroupType");
				parameterGroup.ParameterGroupName = context.StringValue("DescribeParameterGroups.ParameterGroups["+ i +"].ParameterGroupName");
				parameterGroup.ParamCounts = context.IntegerValue("DescribeParameterGroups.ParameterGroups["+ i +"].ParamCounts");
				parameterGroup.ParameterGroupDesc = context.StringValue("DescribeParameterGroups.ParameterGroups["+ i +"].ParameterGroupDesc");
				parameterGroup.ForceRestart = context.IntegerValue("DescribeParameterGroups.ParameterGroups["+ i +"].ForceRestart");
				parameterGroup.Engine = context.StringValue("DescribeParameterGroups.ParameterGroups["+ i +"].Engine");
				parameterGroup.EngineVersion = context.StringValue("DescribeParameterGroups.ParameterGroups["+ i +"].EngineVersion");
				parameterGroup.CreateTime = context.StringValue("DescribeParameterGroups.ParameterGroups["+ i +"].CreateTime");
				parameterGroup.UpdateTime = context.StringValue("DescribeParameterGroups.ParameterGroups["+ i +"].UpdateTime");
				parameterGroup.ParameterGroupId = context.StringValue("DescribeParameterGroups.ParameterGroups["+ i +"].ParameterGroupId");

				describeParameterGroupsResponse_parameterGroups.Add(parameterGroup);
			}
			describeParameterGroupsResponse.ParameterGroups = describeParameterGroupsResponse_parameterGroups;
        
			return describeParameterGroupsResponse;
        }
    }
}
