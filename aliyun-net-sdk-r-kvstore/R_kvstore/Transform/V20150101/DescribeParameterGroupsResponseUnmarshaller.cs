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
using Aliyun.Acs.R_kvstore.Model.V20150101;

namespace Aliyun.Acs.R_kvstore.Transform.V20150101
{
    public class DescribeParameterGroupsResponseUnmarshaller
    {
        public static DescribeParameterGroupsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeParameterGroupsResponse describeParameterGroupsResponse = new DescribeParameterGroupsResponse();

			describeParameterGroupsResponse.HttpResponse = _ctx.HttpResponse;
			describeParameterGroupsResponse.RequestId = _ctx.StringValue("DescribeParameterGroups.RequestId");

			List<DescribeParameterGroupsResponse.DescribeParameterGroups_ParameterGroup> describeParameterGroupsResponse_parameterGroups = new List<DescribeParameterGroupsResponse.DescribeParameterGroups_ParameterGroup>();
			for (int i = 0; i < _ctx.Length("DescribeParameterGroups.ParameterGroups.Length"); i++) {
				DescribeParameterGroupsResponse.DescribeParameterGroups_ParameterGroup parameterGroup = new DescribeParameterGroupsResponse.DescribeParameterGroups_ParameterGroup();
				parameterGroup.EngineVersion = _ctx.StringValue("DescribeParameterGroups.ParameterGroups["+ i +"].EngineVersion");
				parameterGroup.Modified = _ctx.StringValue("DescribeParameterGroups.ParameterGroups["+ i +"].Modified");
				parameterGroup.ParameterGroupName = _ctx.StringValue("DescribeParameterGroups.ParameterGroups["+ i +"].ParameterGroupName");
				parameterGroup.ParameterGroupDesc = _ctx.StringValue("DescribeParameterGroups.ParameterGroups["+ i +"].ParameterGroupDesc");
				parameterGroup.Engine = _ctx.StringValue("DescribeParameterGroups.ParameterGroups["+ i +"].Engine");
				parameterGroup.ParamGroupId = _ctx.StringValue("DescribeParameterGroups.ParameterGroups["+ i +"].ParamGroupId");
				parameterGroup.Created = _ctx.StringValue("DescribeParameterGroups.ParameterGroups["+ i +"].Created");
				parameterGroup.Category = _ctx.LongValue("DescribeParameterGroups.ParameterGroups["+ i +"].Category");

				describeParameterGroupsResponse_parameterGroups.Add(parameterGroup);
			}
			describeParameterGroupsResponse.ParameterGroups = describeParameterGroupsResponse_parameterGroups;
        
			return describeParameterGroupsResponse;
        }
    }
}
