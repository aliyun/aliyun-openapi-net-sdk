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
    public class DescribeTemplateByModelResponseUnmarshaller
    {
        public static DescribeTemplateByModelResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeTemplateByModelResponse describeTemplateByModelResponse = new DescribeTemplateByModelResponse();

			describeTemplateByModelResponse.HttpResponse = _ctx.HttpResponse;
			describeTemplateByModelResponse.RequestId = _ctx.StringValue("DescribeTemplateByModel.RequestId");
			describeTemplateByModelResponse.ErrorMessage = _ctx.StringValue("DescribeTemplateByModel.ErrorMessage");
			describeTemplateByModelResponse.Success = _ctx.BooleanValue("DescribeTemplateByModel.Success");
			describeTemplateByModelResponse.ErrorCode = _ctx.StringValue("DescribeTemplateByModel.ErrorCode");
			describeTemplateByModelResponse.Code = _ctx.StringValue("DescribeTemplateByModel.Code");
			describeTemplateByModelResponse.Message = _ctx.StringValue("DescribeTemplateByModel.Message");
			describeTemplateByModelResponse.DynamicMessage = _ctx.StringValue("DescribeTemplateByModel.DynamicMessage");
			describeTemplateByModelResponse.DynamicCode = _ctx.StringValue("DescribeTemplateByModel.DynamicCode");
			describeTemplateByModelResponse.TotalCount = _ctx.IntegerValue("DescribeTemplateByModel.TotalCount");
			describeTemplateByModelResponse.PageSize = _ctx.IntegerValue("DescribeTemplateByModel.PageSize");
			describeTemplateByModelResponse.PageNumber = _ctx.IntegerValue("DescribeTemplateByModel.PageNumber");

			List<DescribeTemplateByModelResponse.DescribeTemplateByModel_SelectItemInfo> describeTemplateByModelResponse_items = new List<DescribeTemplateByModelResponse.DescribeTemplateByModel_SelectItemInfo>();
			for (int i = 0; i < _ctx.Length("DescribeTemplateByModel.Items.Length"); i++) {
				DescribeTemplateByModelResponse.DescribeTemplateByModel_SelectItemInfo selectItemInfo = new DescribeTemplateByModelResponse.DescribeTemplateByModel_SelectItemInfo();
				selectItemInfo.BasePicture = _ctx.StringValue("DescribeTemplateByModel.Items["+ i +"].BasePicture");
				selectItemInfo.TemplateId = _ctx.StringValue("DescribeTemplateByModel.Items["+ i +"].TemplateId");
				selectItemInfo.TemplateName = _ctx.StringValue("DescribeTemplateByModel.Items["+ i +"].TemplateName");
				selectItemInfo.EslSize = _ctx.StringValue("DescribeTemplateByModel.Items["+ i +"].EslSize");
				selectItemInfo.EslType = _ctx.StringValue("DescribeTemplateByModel.Items["+ i +"].EslType");
				selectItemInfo.Width = _ctx.LongValue("DescribeTemplateByModel.Items["+ i +"].Width");
				selectItemInfo.Height = _ctx.LongValue("DescribeTemplateByModel.Items["+ i +"].Height");
				selectItemInfo.TemplateVersion = _ctx.StringValue("DescribeTemplateByModel.Items["+ i +"].TemplateVersion");
				selectItemInfo.Layout = _ctx.StringValue("DescribeTemplateByModel.Items["+ i +"].Layout");
				selectItemInfo.Scene = _ctx.StringValue("DescribeTemplateByModel.Items["+ i +"].Scene");
				selectItemInfo.Brand = _ctx.StringValue("DescribeTemplateByModel.Items["+ i +"].Brand");

				describeTemplateByModelResponse_items.Add(selectItemInfo);
			}
			describeTemplateByModelResponse.Items = describeTemplateByModelResponse_items;
        
			return describeTemplateByModelResponse;
        }
    }
}
