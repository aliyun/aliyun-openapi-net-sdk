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
    public class DescribeEslModelByTemplateVersionResponseUnmarshaller
    {
        public static DescribeEslModelByTemplateVersionResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeEslModelByTemplateVersionResponse describeEslModelByTemplateVersionResponse = new DescribeEslModelByTemplateVersionResponse();

			describeEslModelByTemplateVersionResponse.HttpResponse = _ctx.HttpResponse;
			describeEslModelByTemplateVersionResponse.TotalCount = _ctx.IntegerValue("DescribeEslModelByTemplateVersion.TotalCount");
			describeEslModelByTemplateVersionResponse.RequestId = _ctx.StringValue("DescribeEslModelByTemplateVersion.RequestId");
			describeEslModelByTemplateVersionResponse.ErrorMessage = _ctx.StringValue("DescribeEslModelByTemplateVersion.ErrorMessage");
			describeEslModelByTemplateVersionResponse.Success = _ctx.BooleanValue("DescribeEslModelByTemplateVersion.Success");
			describeEslModelByTemplateVersionResponse.ErrorCode = _ctx.StringValue("DescribeEslModelByTemplateVersion.ErrorCode");
			describeEslModelByTemplateVersionResponse.Code = _ctx.StringValue("DescribeEslModelByTemplateVersion.Code");
			describeEslModelByTemplateVersionResponse.Message = _ctx.StringValue("DescribeEslModelByTemplateVersion.Message");
			describeEslModelByTemplateVersionResponse.DynamicMessage = _ctx.StringValue("DescribeEslModelByTemplateVersion.DynamicMessage");
			describeEslModelByTemplateVersionResponse.DynamicCode = _ctx.StringValue("DescribeEslModelByTemplateVersion.DynamicCode");
			describeEslModelByTemplateVersionResponse.PageNumber = _ctx.IntegerValue("DescribeEslModelByTemplateVersion.PageNumber");
			describeEslModelByTemplateVersionResponse.PageSize = _ctx.IntegerValue("DescribeEslModelByTemplateVersion.PageSize");

			List<DescribeEslModelByTemplateVersionResponse.DescribeEslModelByTemplateVersion_SelectItemInfo> describeEslModelByTemplateVersionResponse_eslModels = new List<DescribeEslModelByTemplateVersionResponse.DescribeEslModelByTemplateVersion_SelectItemInfo>();
			for (int i = 0; i < _ctx.Length("DescribeEslModelByTemplateVersion.EslModels.Length"); i++) {
				DescribeEslModelByTemplateVersionResponse.DescribeEslModelByTemplateVersion_SelectItemInfo selectItemInfo = new DescribeEslModelByTemplateVersionResponse.DescribeEslModelByTemplateVersion_SelectItemInfo();
				selectItemInfo.ModelId = _ctx.StringValue("DescribeEslModelByTemplateVersion.EslModels["+ i +"].ModelId");
				selectItemInfo.Name = _ctx.StringValue("DescribeEslModelByTemplateVersion.EslModels["+ i +"].Name");
				selectItemInfo.Image = _ctx.StringValue("DescribeEslModelByTemplateVersion.EslModels["+ i +"].Image");
				selectItemInfo.DeviceType = _ctx.StringValue("DescribeEslModelByTemplateVersion.EslModels["+ i +"].DeviceType");
				selectItemInfo.Vendor = _ctx.StringValue("DescribeEslModelByTemplateVersion.EslModels["+ i +"].Vendor");
				selectItemInfo.ScreenWidth = _ctx.IntegerValue("DescribeEslModelByTemplateVersion.EslModels["+ i +"].ScreenWidth");
				selectItemInfo.ScreenHeight = _ctx.IntegerValue("DescribeEslModelByTemplateVersion.EslModels["+ i +"].ScreenHeight");
				selectItemInfo.EslSize = _ctx.StringValue("DescribeEslModelByTemplateVersion.EslModels["+ i +"].EslSize");
				selectItemInfo.EslPhysicalSize = _ctx.StringValue("DescribeEslModelByTemplateVersion.EslModels["+ i +"].EslPhysicalSize");

				describeEslModelByTemplateVersionResponse_eslModels.Add(selectItemInfo);
			}
			describeEslModelByTemplateVersionResponse.EslModels = describeEslModelByTemplateVersionResponse_eslModels;
        
			return describeEslModelByTemplateVersionResponse;
        }
    }
}
