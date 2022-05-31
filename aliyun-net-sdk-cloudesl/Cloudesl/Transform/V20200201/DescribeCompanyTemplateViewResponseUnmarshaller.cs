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
using Aliyun.Acs.cloudesl.Model.V20200201;

namespace Aliyun.Acs.cloudesl.Transform.V20200201
{
    public class DescribeCompanyTemplateViewResponseUnmarshaller
    {
        public static DescribeCompanyTemplateViewResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeCompanyTemplateViewResponse describeCompanyTemplateViewResponse = new DescribeCompanyTemplateViewResponse();

			describeCompanyTemplateViewResponse.HttpResponse = _ctx.HttpResponse;
			describeCompanyTemplateViewResponse.Data = _ctx.StringValue("DescribeCompanyTemplateView.Data");
			describeCompanyTemplateViewResponse.RequestId = _ctx.StringValue("DescribeCompanyTemplateView.RequestId");
			describeCompanyTemplateViewResponse.ErrorMessage = _ctx.StringValue("DescribeCompanyTemplateView.ErrorMessage");
			describeCompanyTemplateViewResponse.Success = _ctx.BooleanValue("DescribeCompanyTemplateView.Success");
			describeCompanyTemplateViewResponse.ErrorCode = _ctx.StringValue("DescribeCompanyTemplateView.ErrorCode");
			describeCompanyTemplateViewResponse.Code = _ctx.StringValue("DescribeCompanyTemplateView.Code");
			describeCompanyTemplateViewResponse.Message = _ctx.StringValue("DescribeCompanyTemplateView.Message");
			describeCompanyTemplateViewResponse.DynamicMessage = _ctx.StringValue("DescribeCompanyTemplateView.DynamicMessage");
			describeCompanyTemplateViewResponse.DynamicCode = _ctx.StringValue("DescribeCompanyTemplateView.DynamicCode");
        
			return describeCompanyTemplateViewResponse;
        }
    }
}
