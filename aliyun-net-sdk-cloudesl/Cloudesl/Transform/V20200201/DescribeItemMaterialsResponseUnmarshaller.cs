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
    public class DescribeItemMaterialsResponseUnmarshaller
    {
        public static DescribeItemMaterialsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeItemMaterialsResponse describeItemMaterialsResponse = new DescribeItemMaterialsResponse();

			describeItemMaterialsResponse.HttpResponse = _ctx.HttpResponse;
			describeItemMaterialsResponse.TotalCount = _ctx.IntegerValue("DescribeItemMaterials.TotalCount");
			describeItemMaterialsResponse.PageNumber = _ctx.IntegerValue("DescribeItemMaterials.PageNumber");
			describeItemMaterialsResponse.PageSize = _ctx.IntegerValue("DescribeItemMaterials.PageSize");
			describeItemMaterialsResponse.RequestId = _ctx.StringValue("DescribeItemMaterials.RequestId");
			describeItemMaterialsResponse.Success = _ctx.BooleanValue("DescribeItemMaterials.Success");
			describeItemMaterialsResponse.Message = _ctx.StringValue("DescribeItemMaterials.Message");
			describeItemMaterialsResponse.ErrorCode = _ctx.StringValue("DescribeItemMaterials.ErrorCode");
			describeItemMaterialsResponse.ErrorMessage = _ctx.StringValue("DescribeItemMaterials.ErrorMessage");
			describeItemMaterialsResponse.Code = _ctx.StringValue("DescribeItemMaterials.Code");
			describeItemMaterialsResponse.DynamicCode = _ctx.StringValue("DescribeItemMaterials.DynamicCode");
			describeItemMaterialsResponse.DynamicMessage = _ctx.StringValue("DescribeItemMaterials.DynamicMessage");

			List<DescribeItemMaterialsResponse.DescribeItemMaterials_ItemMaterialInfo> describeItemMaterialsResponse_materials = new List<DescribeItemMaterialsResponse.DescribeItemMaterials_ItemMaterialInfo>();
			for (int i = 0; i < _ctx.Length("DescribeItemMaterials.Materials.Length"); i++) {
				DescribeItemMaterialsResponse.DescribeItemMaterials_ItemMaterialInfo itemMaterialInfo = new DescribeItemMaterialsResponse.DescribeItemMaterials_ItemMaterialInfo();
				itemMaterialInfo.BarCode = _ctx.StringValue("DescribeItemMaterials.Materials["+ i +"].BarCode");
				itemMaterialInfo.ItemName = _ctx.StringValue("DescribeItemMaterials.Materials["+ i +"].ItemName");
				itemMaterialInfo.GmtCreate = _ctx.StringValue("DescribeItemMaterials.Materials["+ i +"].GmtCreate");

				describeItemMaterialsResponse_materials.Add(itemMaterialInfo);
			}
			describeItemMaterialsResponse.Materials = describeItemMaterialsResponse_materials;
        
			return describeItemMaterialsResponse;
        }
    }
}
