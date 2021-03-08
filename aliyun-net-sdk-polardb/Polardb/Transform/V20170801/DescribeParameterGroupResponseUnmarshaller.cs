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
    public class DescribeParameterGroupResponseUnmarshaller
    {
        public static DescribeParameterGroupResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeParameterGroupResponse describeParameterGroupResponse = new DescribeParameterGroupResponse();

			describeParameterGroupResponse.HttpResponse = _ctx.HttpResponse;
			describeParameterGroupResponse.RequestId = _ctx.StringValue("DescribeParameterGroup.RequestId");

			List<DescribeParameterGroupResponse.DescribeParameterGroup_ParameterGroupItem> describeParameterGroupResponse_parameterGroup = new List<DescribeParameterGroupResponse.DescribeParameterGroup_ParameterGroupItem>();
			for (int i = 0; i < _ctx.Length("DescribeParameterGroup.ParameterGroup.Length"); i++) {
				DescribeParameterGroupResponse.DescribeParameterGroup_ParameterGroupItem parameterGroupItem = new DescribeParameterGroupResponse.DescribeParameterGroup_ParameterGroupItem();
				parameterGroupItem.DBVersion = _ctx.StringValue("DescribeParameterGroup.ParameterGroup["+ i +"].DBVersion");
				parameterGroupItem.ParameterGroupId = _ctx.StringValue("DescribeParameterGroup.ParameterGroup["+ i +"].ParameterGroupId");
				parameterGroupItem.ForceRestart = _ctx.StringValue("DescribeParameterGroup.ParameterGroup["+ i +"].ForceRestart");
				parameterGroupItem.ParameterGroupName = _ctx.StringValue("DescribeParameterGroup.ParameterGroup["+ i +"].ParameterGroupName");
				parameterGroupItem.CreateTime = _ctx.StringValue("DescribeParameterGroup.ParameterGroup["+ i +"].CreateTime");
				parameterGroupItem.ParameterGroupDesc = _ctx.StringValue("DescribeParameterGroup.ParameterGroup["+ i +"].ParameterGroupDesc");
				parameterGroupItem.ParameterGroupType = _ctx.StringValue("DescribeParameterGroup.ParameterGroup["+ i +"].ParameterGroupType");
				parameterGroupItem.ParameterCounts = _ctx.IntegerValue("DescribeParameterGroup.ParameterGroup["+ i +"].ParameterCounts");
				parameterGroupItem.DBType = _ctx.StringValue("DescribeParameterGroup.ParameterGroup["+ i +"].DBType");

				List<DescribeParameterGroupResponse.DescribeParameterGroup_ParameterGroupItem.DescribeParameterGroup_ParameterDetailItem> parameterGroupItem_parameterDetail = new List<DescribeParameterGroupResponse.DescribeParameterGroup_ParameterGroupItem.DescribeParameterGroup_ParameterDetailItem>();
				for (int j = 0; j < _ctx.Length("DescribeParameterGroup.ParameterGroup["+ i +"].ParameterDetail.Length"); j++) {
					DescribeParameterGroupResponse.DescribeParameterGroup_ParameterGroupItem.DescribeParameterGroup_ParameterDetailItem parameterDetailItem = new DescribeParameterGroupResponse.DescribeParameterGroup_ParameterGroupItem.DescribeParameterGroup_ParameterDetailItem();
					parameterDetailItem.ParamValue = _ctx.StringValue("DescribeParameterGroup.ParameterGroup["+ i +"].ParameterDetail["+ j +"].ParamValue");
					parameterDetailItem.ParamName = _ctx.StringValue("DescribeParameterGroup.ParameterGroup["+ i +"].ParameterDetail["+ j +"].ParamName");

					parameterGroupItem_parameterDetail.Add(parameterDetailItem);
				}
				parameterGroupItem.ParameterDetail = parameterGroupItem_parameterDetail;

				describeParameterGroupResponse_parameterGroup.Add(parameterGroupItem);
			}
			describeParameterGroupResponse.ParameterGroup = describeParameterGroupResponse_parameterGroup;
        
			return describeParameterGroupResponse;
        }
    }
}
