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
    public class DescribeAvailableEslModelsResponseUnmarshaller
    {
        public static DescribeAvailableEslModelsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeAvailableEslModelsResponse describeAvailableEslModelsResponse = new DescribeAvailableEslModelsResponse();

			describeAvailableEslModelsResponse.HttpResponse = _ctx.HttpResponse;
			describeAvailableEslModelsResponse.TotalCount = _ctx.IntegerValue("DescribeAvailableEslModels.TotalCount");
			describeAvailableEslModelsResponse.PageSize = _ctx.IntegerValue("DescribeAvailableEslModels.PageSize");
			describeAvailableEslModelsResponse.PageNumber = _ctx.IntegerValue("DescribeAvailableEslModels.PageNumber");
			describeAvailableEslModelsResponse.RequestId = _ctx.StringValue("DescribeAvailableEslModels.RequestId");
			describeAvailableEslModelsResponse.Success = _ctx.BooleanValue("DescribeAvailableEslModels.Success");
			describeAvailableEslModelsResponse.Message = _ctx.StringValue("DescribeAvailableEslModels.Message");
			describeAvailableEslModelsResponse.ErrorCode = _ctx.StringValue("DescribeAvailableEslModels.ErrorCode");
			describeAvailableEslModelsResponse.ErrorMessage = _ctx.StringValue("DescribeAvailableEslModels.ErrorMessage");
			describeAvailableEslModelsResponse.Code = _ctx.StringValue("DescribeAvailableEslModels.Code");
			describeAvailableEslModelsResponse.DynamicCode = _ctx.StringValue("DescribeAvailableEslModels.DynamicCode");
			describeAvailableEslModelsResponse.DynamicMessage = _ctx.StringValue("DescribeAvailableEslModels.DynamicMessage");

			List<DescribeAvailableEslModelsResponse.DescribeAvailableEslModels_SelectItemInfo> describeAvailableEslModelsResponse_eslModels = new List<DescribeAvailableEslModelsResponse.DescribeAvailableEslModels_SelectItemInfo>();
			for (int i = 0; i < _ctx.Length("DescribeAvailableEslModels.EslModels.Length"); i++) {
				DescribeAvailableEslModelsResponse.DescribeAvailableEslModels_SelectItemInfo selectItemInfo = new DescribeAvailableEslModelsResponse.DescribeAvailableEslModels_SelectItemInfo();
				selectItemInfo.ModelId = _ctx.StringValue("DescribeAvailableEslModels.EslModels["+ i +"].ModelId");
				selectItemInfo.Name = _ctx.StringValue("DescribeAvailableEslModels.EslModels["+ i +"].Name");
				selectItemInfo.DeviceType = _ctx.StringValue("DescribeAvailableEslModels.EslModels["+ i +"].DeviceType");
				selectItemInfo.Vendor = _ctx.StringValue("DescribeAvailableEslModels.EslModels["+ i +"].Vendor");
				selectItemInfo.ScreenWidth = _ctx.IntegerValue("DescribeAvailableEslModels.EslModels["+ i +"].ScreenWidth");
				selectItemInfo.ScreenHeight = _ctx.IntegerValue("DescribeAvailableEslModels.EslModels["+ i +"].ScreenHeight");
				selectItemInfo.EslSize = _ctx.StringValue("DescribeAvailableEslModels.EslModels["+ i +"].EslSize");

				describeAvailableEslModelsResponse_eslModels.Add(selectItemInfo);
			}
			describeAvailableEslModelsResponse.EslModels = describeAvailableEslModelsResponse_eslModels;
        
			return describeAvailableEslModelsResponse;
        }
    }
}
