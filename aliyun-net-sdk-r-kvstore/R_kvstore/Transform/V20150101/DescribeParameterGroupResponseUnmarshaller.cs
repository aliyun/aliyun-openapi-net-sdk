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
    public class DescribeParameterGroupResponseUnmarshaller
    {
        public static DescribeParameterGroupResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeParameterGroupResponse describeParameterGroupResponse = new DescribeParameterGroupResponse();

			describeParameterGroupResponse.HttpResponse = _ctx.HttpResponse;
			describeParameterGroupResponse.RequestId = _ctx.StringValue("DescribeParameterGroup.RequestId");

			DescribeParameterGroupResponse.DescribeParameterGroup_ParameterGroup parameterGroup = new DescribeParameterGroupResponse.DescribeParameterGroup_ParameterGroup();
			parameterGroup.EngineVersion = _ctx.StringValue("DescribeParameterGroup.ParameterGroup.EngineVersion");
			parameterGroup.Modified = _ctx.StringValue("DescribeParameterGroup.ParameterGroup.Modified");
			parameterGroup.ParameterGroupName = _ctx.StringValue("DescribeParameterGroup.ParameterGroup.ParameterGroupName");
			parameterGroup.ParameterGroupDesc = _ctx.StringValue("DescribeParameterGroup.ParameterGroup.ParameterGroupDesc");
			parameterGroup.Engine = _ctx.StringValue("DescribeParameterGroup.ParameterGroup.Engine");
			parameterGroup.ParamGroupId = _ctx.StringValue("DescribeParameterGroup.ParameterGroup.ParamGroupId");
			parameterGroup.Created = _ctx.StringValue("DescribeParameterGroup.ParameterGroup.Created");
			parameterGroup.Category = _ctx.LongValue("DescribeParameterGroup.ParameterGroup.Category");

			List<DescribeParameterGroupResponse.DescribeParameterGroup_ParameterGroup.DescribeParameterGroup_ParamGroupDetail> parameterGroup_paramGroupsDetails = new List<DescribeParameterGroupResponse.DescribeParameterGroup_ParameterGroup.DescribeParameterGroup_ParamGroupDetail>();
			for (int i = 0; i < _ctx.Length("DescribeParameterGroup.ParameterGroup.ParamGroupsDetails.Length"); i++) {
				DescribeParameterGroupResponse.DescribeParameterGroup_ParameterGroup.DescribeParameterGroup_ParamGroupDetail paramGroupDetail = new DescribeParameterGroupResponse.DescribeParameterGroup_ParameterGroup.DescribeParameterGroup_ParamGroupDetail();
				paramGroupDetail.ParamName = _ctx.StringValue("DescribeParameterGroup.ParameterGroup.ParamGroupsDetails["+ i +"].ParamName");
				paramGroupDetail.ParamValue = _ctx.StringValue("DescribeParameterGroup.ParameterGroup.ParamGroupsDetails["+ i +"].ParamValue");

				parameterGroup_paramGroupsDetails.Add(paramGroupDetail);
			}
			parameterGroup.ParamGroupsDetails = parameterGroup_paramGroupsDetails;
			describeParameterGroupResponse.ParameterGroup = parameterGroup;
        
			return describeParameterGroupResponse;
        }
    }
}
