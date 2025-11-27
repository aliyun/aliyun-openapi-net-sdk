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
    public class DescribeParameterGroupTemplateListResponseUnmarshaller
    {
        public static DescribeParameterGroupTemplateListResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeParameterGroupTemplateListResponse describeParameterGroupTemplateListResponse = new DescribeParameterGroupTemplateListResponse();

			describeParameterGroupTemplateListResponse.HttpResponse = _ctx.HttpResponse;
			describeParameterGroupTemplateListResponse.RequestId = _ctx.StringValue("DescribeParameterGroupTemplateList.RequestId");
			describeParameterGroupTemplateListResponse.EngineVersion = _ctx.StringValue("DescribeParameterGroupTemplateList.EngineVersion");

			List<DescribeParameterGroupTemplateListResponse.DescribeParameterGroupTemplateList_ParametersItem> describeParameterGroupTemplateListResponse_parameters = new List<DescribeParameterGroupTemplateListResponse.DescribeParameterGroupTemplateList_ParametersItem>();
			for (int i = 0; i < _ctx.Length("DescribeParameterGroupTemplateList.Parameters.Length"); i++) {
				DescribeParameterGroupTemplateListResponse.DescribeParameterGroupTemplateList_ParametersItem parametersItem = new DescribeParameterGroupTemplateListResponse.DescribeParameterGroupTemplateList_ParametersItem();
				parametersItem.SupportModifyForMinorVersion = _ctx.BooleanValue("DescribeParameterGroupTemplateList.Parameters["+ i +"].SupportModifyForMinorVersion");
				parametersItem.CheckingCode = _ctx.StringValue("DescribeParameterGroupTemplateList.Parameters["+ i +"].CheckingCode");
				parametersItem.ParameterValue = _ctx.StringValue("DescribeParameterGroupTemplateList.Parameters["+ i +"].ParameterValue");
				parametersItem.Revisable = _ctx.LongValue("DescribeParameterGroupTemplateList.Parameters["+ i +"].Revisable");
				parametersItem.Factor = _ctx.LongValue("DescribeParameterGroupTemplateList.Parameters["+ i +"].Factor");
				parametersItem.ParameterName = _ctx.StringValue("DescribeParameterGroupTemplateList.Parameters["+ i +"].ParameterName");
				parametersItem.Unit = _ctx.StringValue("DescribeParameterGroupTemplateList.Parameters["+ i +"].Unit");
				parametersItem.ParameterDescription = _ctx.StringValue("DescribeParameterGroupTemplateList.Parameters["+ i +"].ParameterDescription");
				parametersItem.Effective = _ctx.LongValue("DescribeParameterGroupTemplateList.Parameters["+ i +"].Effective");

				describeParameterGroupTemplateListResponse_parameters.Add(parametersItem);
			}
			describeParameterGroupTemplateListResponse.Parameters = describeParameterGroupTemplateListResponse_parameters;
        
			return describeParameterGroupTemplateListResponse;
        }
    }
}
