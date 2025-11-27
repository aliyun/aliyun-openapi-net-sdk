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
    public class DescribeParameterGroupSupportParamResponseUnmarshaller
    {
        public static DescribeParameterGroupSupportParamResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeParameterGroupSupportParamResponse describeParameterGroupSupportParamResponse = new DescribeParameterGroupSupportParamResponse();

			describeParameterGroupSupportParamResponse.HttpResponse = _ctx.HttpResponse;
			describeParameterGroupSupportParamResponse.RequestId = _ctx.StringValue("DescribeParameterGroupSupportParam.RequestId");

			List<DescribeParameterGroupSupportParamResponse.DescribeParameterGroupSupportParam_ResourceListItem> describeParameterGroupSupportParamResponse_resourceList = new List<DescribeParameterGroupSupportParamResponse.DescribeParameterGroupSupportParam_ResourceListItem>();
			for (int i = 0; i < _ctx.Length("DescribeParameterGroupSupportParam.ResourceList.Length"); i++) {
				DescribeParameterGroupSupportParamResponse.DescribeParameterGroupSupportParam_ResourceListItem resourceListItem = new DescribeParameterGroupSupportParamResponse.DescribeParameterGroupSupportParam_ResourceListItem();
				resourceListItem.DbType = _ctx.StringValue("DescribeParameterGroupSupportParam.ResourceList["+ i +"].DbType");
				resourceListItem.DbVersion = _ctx.StringValue("DescribeParameterGroupSupportParam.ResourceList["+ i +"].DbVersion");
				resourceListItem.Category = _ctx.StringValue("DescribeParameterGroupSupportParam.ResourceList["+ i +"].Category");
				resourceListItem.ParamName = _ctx.StringValue("DescribeParameterGroupSupportParam.ResourceList["+ i +"].ParamName");

				describeParameterGroupSupportParamResponse_resourceList.Add(resourceListItem);
			}
			describeParameterGroupSupportParamResponse.ResourceList = describeParameterGroupSupportParamResponse_resourceList;
        
			return describeParameterGroupSupportParamResponse;
        }
    }
}
