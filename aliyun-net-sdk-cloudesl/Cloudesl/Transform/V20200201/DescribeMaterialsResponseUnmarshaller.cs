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
    public class DescribeMaterialsResponseUnmarshaller
    {
        public static DescribeMaterialsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeMaterialsResponse describeMaterialsResponse = new DescribeMaterialsResponse();

			describeMaterialsResponse.HttpResponse = _ctx.HttpResponse;
			describeMaterialsResponse.TotalCount = _ctx.IntegerValue("DescribeMaterials.TotalCount");
			describeMaterialsResponse.PageNumber = _ctx.IntegerValue("DescribeMaterials.PageNumber");
			describeMaterialsResponse.PageSize = _ctx.IntegerValue("DescribeMaterials.PageSize");
			describeMaterialsResponse.RequestId = _ctx.StringValue("DescribeMaterials.RequestId");
			describeMaterialsResponse.Success = _ctx.BooleanValue("DescribeMaterials.Success");
			describeMaterialsResponse.Message = _ctx.StringValue("DescribeMaterials.Message");
			describeMaterialsResponse.ErrorCode = _ctx.StringValue("DescribeMaterials.ErrorCode");
			describeMaterialsResponse.ErrorMessage = _ctx.StringValue("DescribeMaterials.ErrorMessage");
			describeMaterialsResponse.Code = _ctx.StringValue("DescribeMaterials.Code");
			describeMaterialsResponse.DynamicCode = _ctx.StringValue("DescribeMaterials.DynamicCode");
			describeMaterialsResponse.DynamicMessage = _ctx.StringValue("DescribeMaterials.DynamicMessage");

			List<DescribeMaterialsResponse.DescribeMaterials_Material> describeMaterialsResponse_materials = new List<DescribeMaterialsResponse.DescribeMaterials_Material>();
			for (int i = 0; i < _ctx.Length("DescribeMaterials.Materials.Length"); i++) {
				DescribeMaterialsResponse.DescribeMaterials_Material material = new DescribeMaterialsResponse.DescribeMaterials_Material();
				material.MaterialId = _ctx.StringValue("DescribeMaterials.Materials["+ i +"].MaterialId");
				material.Size = _ctx.StringValue("DescribeMaterials.Materials["+ i +"].Size");
				material.Period = _ctx.IntegerValue("DescribeMaterials.Materials["+ i +"].Period");
				material.Content = _ctx.StringValue("DescribeMaterials.Materials["+ i +"].Content");
				material.Thumbnail = _ctx.StringValue("DescribeMaterials.Materials["+ i +"].Thumbnail");
				material.Type = _ctx.IntegerValue("DescribeMaterials.Materials["+ i +"].Type");
				material.Source = _ctx.StringValue("DescribeMaterials.Materials["+ i +"].Source");
				material.Name = _ctx.StringValue("DescribeMaterials.Materials["+ i +"].Name");

				describeMaterialsResponse_materials.Add(material);
			}
			describeMaterialsResponse.Materials = describeMaterialsResponse_materials;
        
			return describeMaterialsResponse;
        }
    }
}
