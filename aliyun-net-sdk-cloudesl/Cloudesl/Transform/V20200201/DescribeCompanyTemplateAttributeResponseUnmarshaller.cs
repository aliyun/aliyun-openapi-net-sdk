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
    public class DescribeCompanyTemplateAttributeResponseUnmarshaller
    {
        public static DescribeCompanyTemplateAttributeResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeCompanyTemplateAttributeResponse describeCompanyTemplateAttributeResponse = new DescribeCompanyTemplateAttributeResponse();

			describeCompanyTemplateAttributeResponse.HttpResponse = _ctx.HttpResponse;
			describeCompanyTemplateAttributeResponse.RequestId = _ctx.StringValue("DescribeCompanyTemplateAttribute.RequestId");
			describeCompanyTemplateAttributeResponse.ErrorMessage = _ctx.StringValue("DescribeCompanyTemplateAttribute.ErrorMessage");
			describeCompanyTemplateAttributeResponse.Success = _ctx.BooleanValue("DescribeCompanyTemplateAttribute.Success");
			describeCompanyTemplateAttributeResponse.ErrorCode = _ctx.StringValue("DescribeCompanyTemplateAttribute.ErrorCode");
			describeCompanyTemplateAttributeResponse.Code = _ctx.StringValue("DescribeCompanyTemplateAttribute.Code");
			describeCompanyTemplateAttributeResponse.Message = _ctx.StringValue("DescribeCompanyTemplateAttribute.Message");
			describeCompanyTemplateAttributeResponse.DynamicMessage = _ctx.StringValue("DescribeCompanyTemplateAttribute.DynamicMessage");
			describeCompanyTemplateAttributeResponse.DynamicCode = _ctx.StringValue("DescribeCompanyTemplateAttribute.DynamicCode");

			List<DescribeCompanyTemplateAttributeResponse.DescribeCompanyTemplateAttribute_SelectItemInfo> describeCompanyTemplateAttributeResponse_categoryField = new List<DescribeCompanyTemplateAttributeResponse.DescribeCompanyTemplateAttribute_SelectItemInfo>();
			for (int i = 0; i < _ctx.Length("DescribeCompanyTemplateAttribute.CategoryField.Length"); i++) {
				DescribeCompanyTemplateAttributeResponse.DescribeCompanyTemplateAttribute_SelectItemInfo selectItemInfo = new DescribeCompanyTemplateAttributeResponse.DescribeCompanyTemplateAttribute_SelectItemInfo();
				selectItemInfo.Label = _ctx.StringValue("DescribeCompanyTemplateAttribute.CategoryField["+ i +"].Label");
				selectItemInfo._Value = _ctx.StringValue("DescribeCompanyTemplateAttribute.CategoryField["+ i +"].Value");

				describeCompanyTemplateAttributeResponse_categoryField.Add(selectItemInfo);
			}
			describeCompanyTemplateAttributeResponse.CategoryField = describeCompanyTemplateAttributeResponse_categoryField;

			List<DescribeCompanyTemplateAttributeResponse.DescribeCompanyTemplateAttribute_SelectItemInfo> describeCompanyTemplateAttributeResponse_fontType = new List<DescribeCompanyTemplateAttributeResponse.DescribeCompanyTemplateAttribute_SelectItemInfo>();
			for (int i = 0; i < _ctx.Length("DescribeCompanyTemplateAttribute.FontType.Length"); i++) {
				DescribeCompanyTemplateAttributeResponse.DescribeCompanyTemplateAttribute_SelectItemInfo selectItemInfo = new DescribeCompanyTemplateAttributeResponse.DescribeCompanyTemplateAttribute_SelectItemInfo();
				selectItemInfo.Label = _ctx.StringValue("DescribeCompanyTemplateAttribute.FontType["+ i +"].Label");
				selectItemInfo._Value = _ctx.StringValue("DescribeCompanyTemplateAttribute.FontType["+ i +"].Value");

				describeCompanyTemplateAttributeResponse_fontType.Add(selectItemInfo);
			}
			describeCompanyTemplateAttributeResponse.FontType = describeCompanyTemplateAttributeResponse_fontType;

			List<DescribeCompanyTemplateAttributeResponse.DescribeCompanyTemplateAttribute_SelectItemInfo> describeCompanyTemplateAttributeResponse_deviceType = new List<DescribeCompanyTemplateAttributeResponse.DescribeCompanyTemplateAttribute_SelectItemInfo>();
			for (int i = 0; i < _ctx.Length("DescribeCompanyTemplateAttribute.DeviceType.Length"); i++) {
				DescribeCompanyTemplateAttributeResponse.DescribeCompanyTemplateAttribute_SelectItemInfo selectItemInfo = new DescribeCompanyTemplateAttributeResponse.DescribeCompanyTemplateAttribute_SelectItemInfo();
				selectItemInfo.Label = _ctx.StringValue("DescribeCompanyTemplateAttribute.DeviceType["+ i +"].Label");
				selectItemInfo._Value = _ctx.StringValue("DescribeCompanyTemplateAttribute.DeviceType["+ i +"].Value");

				describeCompanyTemplateAttributeResponse_deviceType.Add(selectItemInfo);
			}
			describeCompanyTemplateAttributeResponse.DeviceType = describeCompanyTemplateAttributeResponse_deviceType;

			List<DescribeCompanyTemplateAttributeResponse.DescribeCompanyTemplateAttribute_SelectItemInfo> describeCompanyTemplateAttributeResponse_templateType = new List<DescribeCompanyTemplateAttributeResponse.DescribeCompanyTemplateAttribute_SelectItemInfo>();
			for (int i = 0; i < _ctx.Length("DescribeCompanyTemplateAttribute.TemplateType.Length"); i++) {
				DescribeCompanyTemplateAttributeResponse.DescribeCompanyTemplateAttribute_SelectItemInfo selectItemInfo = new DescribeCompanyTemplateAttributeResponse.DescribeCompanyTemplateAttribute_SelectItemInfo();
				selectItemInfo.Label = _ctx.StringValue("DescribeCompanyTemplateAttribute.TemplateType["+ i +"].Label");
				selectItemInfo._Value = _ctx.StringValue("DescribeCompanyTemplateAttribute.TemplateType["+ i +"].Value");

				describeCompanyTemplateAttributeResponse_templateType.Add(selectItemInfo);
			}
			describeCompanyTemplateAttributeResponse.TemplateType = describeCompanyTemplateAttributeResponse_templateType;

			List<DescribeCompanyTemplateAttributeResponse.DescribeCompanyTemplateAttribute_SelectItemInfo> describeCompanyTemplateAttributeResponse_sizeType = new List<DescribeCompanyTemplateAttributeResponse.DescribeCompanyTemplateAttribute_SelectItemInfo>();
			for (int i = 0; i < _ctx.Length("DescribeCompanyTemplateAttribute.SizeType.Length"); i++) {
				DescribeCompanyTemplateAttributeResponse.DescribeCompanyTemplateAttribute_SelectItemInfo selectItemInfo = new DescribeCompanyTemplateAttributeResponse.DescribeCompanyTemplateAttribute_SelectItemInfo();
				selectItemInfo.Label = _ctx.StringValue("DescribeCompanyTemplateAttribute.SizeType["+ i +"].Label");
				selectItemInfo._Value = _ctx.StringValue("DescribeCompanyTemplateAttribute.SizeType["+ i +"].Value");

				describeCompanyTemplateAttributeResponse_sizeType.Add(selectItemInfo);
			}
			describeCompanyTemplateAttributeResponse.SizeType = describeCompanyTemplateAttributeResponse_sizeType;
        
			return describeCompanyTemplateAttributeResponse;
        }
    }
}
