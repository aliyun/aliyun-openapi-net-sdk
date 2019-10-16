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
        public static DescribeParameterGroupResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeParameterGroupResponse describeParameterGroupResponse = new DescribeParameterGroupResponse();

			describeParameterGroupResponse.HttpResponse = context.HttpResponse;
			describeParameterGroupResponse.RequestId = context.StringValue("DescribeParameterGroup.RequestId");

			List<DescribeParameterGroupResponse.DescribeParameterGroup_ParameterGroup> describeParameterGroupResponse_paramGroup = new List<DescribeParameterGroupResponse.DescribeParameterGroup_ParameterGroup>();
			for (int i = 0; i < context.Length("DescribeParameterGroup.ParamGroup.Length"); i++) {
				DescribeParameterGroupResponse.DescribeParameterGroup_ParameterGroup parameterGroup = new DescribeParameterGroupResponse.DescribeParameterGroup_ParameterGroup();
				parameterGroup.ParameterGroupType = context.IntegerValue("DescribeParameterGroup.ParamGroup["+ i +"].ParameterGroupType");
				parameterGroup.ParameterGroupName = context.StringValue("DescribeParameterGroup.ParamGroup["+ i +"].ParameterGroupName");
				parameterGroup.ParamCounts = context.IntegerValue("DescribeParameterGroup.ParamGroup["+ i +"].ParamCounts");
				parameterGroup.ParameterGroupDesc = context.StringValue("DescribeParameterGroup.ParamGroup["+ i +"].ParameterGroupDesc");
				parameterGroup.ForceRestart = context.IntegerValue("DescribeParameterGroup.ParamGroup["+ i +"].ForceRestart");
				parameterGroup.Engine = context.StringValue("DescribeParameterGroup.ParamGroup["+ i +"].Engine");
				parameterGroup.EngineVersion = context.StringValue("DescribeParameterGroup.ParamGroup["+ i +"].EngineVersion");
				parameterGroup.ParameterGroupId = context.IntegerValue("DescribeParameterGroup.ParamGroup["+ i +"].ParameterGroupId");
				parameterGroup.CreateTime = context.StringValue("DescribeParameterGroup.ParamGroup["+ i +"].CreateTime");
				parameterGroup.UpdateTime = context.StringValue("DescribeParameterGroup.ParamGroup["+ i +"].UpdateTime");

				List<DescribeParameterGroupResponse.DescribeParameterGroup_ParameterGroup.DescribeParameterGroup_ParameterDetail> parameterGroup_paramDetail = new List<DescribeParameterGroupResponse.DescribeParameterGroup_ParameterGroup.DescribeParameterGroup_ParameterDetail>();
				for (int j = 0; j < context.Length("DescribeParameterGroup.ParamGroup["+ i +"].ParamDetail.Length"); j++) {
					DescribeParameterGroupResponse.DescribeParameterGroup_ParameterGroup.DescribeParameterGroup_ParameterDetail parameterDetail = new DescribeParameterGroupResponse.DescribeParameterGroup_ParameterGroup.DescribeParameterGroup_ParameterDetail();
					parameterDetail.ParamName = context.StringValue("DescribeParameterGroup.ParamGroup["+ i +"].ParamDetail["+ j +"].ParamName");
					parameterDetail.ParamValue = context.StringValue("DescribeParameterGroup.ParamGroup["+ i +"].ParamDetail["+ j +"].ParamValue");

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
