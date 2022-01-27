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
    public class DescribeParameterGroupResponseUnmarshaller
    {
        public static DescribeParameterGroupResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeParameterGroupResponse describeParameterGroupResponse = new DescribeParameterGroupResponse();

			describeParameterGroupResponse.HttpResponse = _ctx.HttpResponse;
			describeParameterGroupResponse.RequestId = _ctx.StringValue("DescribeParameterGroup.RequestId");

			List<DescribeParameterGroupResponse.DescribeParameterGroup_ParameterGroup> describeParameterGroupResponse_paramGroup = new List<DescribeParameterGroupResponse.DescribeParameterGroup_ParameterGroup>();
			for (int i = 0; i < _ctx.Length("DescribeParameterGroup.ParamGroup.Length"); i++) {
				DescribeParameterGroupResponse.DescribeParameterGroup_ParameterGroup parameterGroup = new DescribeParameterGroupResponse.DescribeParameterGroup_ParameterGroup();
				parameterGroup.ParameterGroupType = _ctx.IntegerValue("DescribeParameterGroup.ParamGroup["+ i +"].ParameterGroupType");
				parameterGroup.ParameterGroupName = _ctx.StringValue("DescribeParameterGroup.ParamGroup["+ i +"].ParameterGroupName");
				parameterGroup.ParamCounts = _ctx.IntegerValue("DescribeParameterGroup.ParamGroup["+ i +"].ParamCounts");
				parameterGroup.ParameterGroupDesc = _ctx.StringValue("DescribeParameterGroup.ParamGroup["+ i +"].ParameterGroupDesc");
				parameterGroup.ForceRestart = _ctx.IntegerValue("DescribeParameterGroup.ParamGroup["+ i +"].ForceRestart");
				parameterGroup.Engine = _ctx.StringValue("DescribeParameterGroup.ParamGroup["+ i +"].Engine");
				parameterGroup.EngineVersion = _ctx.StringValue("DescribeParameterGroup.ParamGroup["+ i +"].EngineVersion");
				parameterGroup.ParameterGroupId = _ctx.StringValue("DescribeParameterGroup.ParamGroup["+ i +"].ParameterGroupId");
				parameterGroup.CreateTime = _ctx.StringValue("DescribeParameterGroup.ParamGroup["+ i +"].CreateTime");
				parameterGroup.UpdateTime = _ctx.StringValue("DescribeParameterGroup.ParamGroup["+ i +"].UpdateTime");

				List<DescribeParameterGroupResponse.DescribeParameterGroup_ParameterGroup.DescribeParameterGroup_ParameterDetail> parameterGroup_paramDetail = new List<DescribeParameterGroupResponse.DescribeParameterGroup_ParameterGroup.DescribeParameterGroup_ParameterDetail>();
				for (int j = 0; j < _ctx.Length("DescribeParameterGroup.ParamGroup["+ i +"].ParamDetail.Length"); j++) {
					DescribeParameterGroupResponse.DescribeParameterGroup_ParameterGroup.DescribeParameterGroup_ParameterDetail parameterDetail = new DescribeParameterGroupResponse.DescribeParameterGroup_ParameterGroup.DescribeParameterGroup_ParameterDetail();
					parameterDetail.ParamName = _ctx.StringValue("DescribeParameterGroup.ParamGroup["+ i +"].ParamDetail["+ j +"].ParamName");
					parameterDetail.ParamValue = _ctx.StringValue("DescribeParameterGroup.ParamGroup["+ i +"].ParamDetail["+ j +"].ParamValue");

					parameterGroup_paramDetail.Add(parameterDetail);
				}
				parameterGroup.ParamDetail = parameterGroup_paramDetail;

				describeParameterGroupResponse_paramGroup.Add(parameterGroup);
			}
			describeParameterGroupResponse.ParamGroup = describeParameterGroupResponse_paramGroup;
        
			return describeParameterGroupResponse;
        }
    }
}
