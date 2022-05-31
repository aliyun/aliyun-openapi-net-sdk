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
    public class DescribeCompanyTemplateVersionsResponseUnmarshaller
    {
        public static DescribeCompanyTemplateVersionsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeCompanyTemplateVersionsResponse describeCompanyTemplateVersionsResponse = new DescribeCompanyTemplateVersionsResponse();

			describeCompanyTemplateVersionsResponse.HttpResponse = _ctx.HttpResponse;
			describeCompanyTemplateVersionsResponse.TotalCount = _ctx.IntegerValue("DescribeCompanyTemplateVersions.TotalCount");
			describeCompanyTemplateVersionsResponse.RequestId = _ctx.StringValue("DescribeCompanyTemplateVersions.RequestId");
			describeCompanyTemplateVersionsResponse.ErrorMessage = _ctx.StringValue("DescribeCompanyTemplateVersions.ErrorMessage");
			describeCompanyTemplateVersionsResponse.Success = _ctx.BooleanValue("DescribeCompanyTemplateVersions.Success");
			describeCompanyTemplateVersionsResponse.ErrorCode = _ctx.StringValue("DescribeCompanyTemplateVersions.ErrorCode");
			describeCompanyTemplateVersionsResponse.Code = _ctx.StringValue("DescribeCompanyTemplateVersions.Code");
			describeCompanyTemplateVersionsResponse.Message = _ctx.StringValue("DescribeCompanyTemplateVersions.Message");
			describeCompanyTemplateVersionsResponse.DynamicMessage = _ctx.StringValue("DescribeCompanyTemplateVersions.DynamicMessage");
			describeCompanyTemplateVersionsResponse.DynamicCode = _ctx.StringValue("DescribeCompanyTemplateVersions.DynamicCode");
			describeCompanyTemplateVersionsResponse.PageSize = _ctx.IntegerValue("DescribeCompanyTemplateVersions.PageSize");
			describeCompanyTemplateVersionsResponse.PageNumber = _ctx.IntegerValue("DescribeCompanyTemplateVersions.PageNumber");

			List<DescribeCompanyTemplateVersionsResponse.DescribeCompanyTemplateVersions_SelectItemInfo> describeCompanyTemplateVersionsResponse_versions = new List<DescribeCompanyTemplateVersionsResponse.DescribeCompanyTemplateVersions_SelectItemInfo>();
			for (int i = 0; i < _ctx.Length("DescribeCompanyTemplateVersions.Versions.Length"); i++) {
				DescribeCompanyTemplateVersionsResponse.DescribeCompanyTemplateVersions_SelectItemInfo selectItemInfo = new DescribeCompanyTemplateVersionsResponse.DescribeCompanyTemplateVersions_SelectItemInfo();
				selectItemInfo.Version = _ctx.StringValue("DescribeCompanyTemplateVersions.Versions["+ i +"].Version");

				describeCompanyTemplateVersionsResponse_versions.Add(selectItemInfo);
			}
			describeCompanyTemplateVersionsResponse.Versions = describeCompanyTemplateVersionsResponse_versions;
        
			return describeCompanyTemplateVersionsResponse;
        }
    }
}
