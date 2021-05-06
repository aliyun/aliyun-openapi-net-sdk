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
using Aliyun.Acs.polardb.Model.V20170801;

namespace Aliyun.Acs.polardb.Transform.V20170801
{
    public class DescribeParameterGroupsResponseUnmarshaller
    {
        public static DescribeParameterGroupsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeParameterGroupsResponse describeParameterGroupsResponse = new DescribeParameterGroupsResponse();

			describeParameterGroupsResponse.HttpResponse = _ctx.HttpResponse;
			describeParameterGroupsResponse.RequestId = _ctx.StringValue("DescribeParameterGroups.RequestId");

			List<DescribeParameterGroupsResponse.DescribeParameterGroups_ParameterGroupsItem> describeParameterGroupsResponse_parameterGroups = new List<DescribeParameterGroupsResponse.DescribeParameterGroups_ParameterGroupsItem>();
			for (int i = 0; i < _ctx.Length("DescribeParameterGroups.ParameterGroups.Length"); i++) {
				DescribeParameterGroupsResponse.DescribeParameterGroups_ParameterGroupsItem parameterGroupsItem = new DescribeParameterGroupsResponse.DescribeParameterGroups_ParameterGroupsItem();
				parameterGroupsItem.DBVersion = _ctx.StringValue("DescribeParameterGroups.ParameterGroups["+ i +"].DBVersion");
				parameterGroupsItem.ParameterGroupId = _ctx.StringValue("DescribeParameterGroups.ParameterGroups["+ i +"].ParameterGroupId");
				parameterGroupsItem.ForceRestart = _ctx.StringValue("DescribeParameterGroups.ParameterGroups["+ i +"].ForceRestart");
				parameterGroupsItem.ParameterGroupName = _ctx.StringValue("DescribeParameterGroups.ParameterGroups["+ i +"].ParameterGroupName");
				parameterGroupsItem.CreateTime = _ctx.StringValue("DescribeParameterGroups.ParameterGroups["+ i +"].CreateTime");
				parameterGroupsItem.ParameterGroupDesc = _ctx.StringValue("DescribeParameterGroups.ParameterGroups["+ i +"].ParameterGroupDesc");
				parameterGroupsItem.ParameterGroupType = _ctx.StringValue("DescribeParameterGroups.ParameterGroups["+ i +"].ParameterGroupType");
				parameterGroupsItem.ParameterCounts = _ctx.LongValue("DescribeParameterGroups.ParameterGroups["+ i +"].ParameterCounts");
				parameterGroupsItem.DBType = _ctx.StringValue("DescribeParameterGroups.ParameterGroups["+ i +"].DBType");

				describeParameterGroupsResponse_parameterGroups.Add(parameterGroupsItem);
			}
			describeParameterGroupsResponse.ParameterGroups = describeParameterGroupsResponse_parameterGroups;
        
			return describeParameterGroupsResponse;
        }
    }
}
