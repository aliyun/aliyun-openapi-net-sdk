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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.vod.Model.V20170321;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.vod.Transform.V20170321
{
    public class GetEditingProjectMaterialsResponseUnmarshaller
    {
        public static GetEditingProjectMaterialsResponse Unmarshall(UnmarshallerContext context)
        {
			GetEditingProjectMaterialsResponse getEditingProjectMaterialsResponse = new GetEditingProjectMaterialsResponse();

			getEditingProjectMaterialsResponse.HttpResponse = context.HttpResponse;
			getEditingProjectMaterialsResponse.RequestId = context.StringValue("GetEditingProjectMaterials.RequestId");

			List<GetEditingProjectMaterialsResponse.GetEditingProjectMaterials_Material> getEditingProjectMaterialsResponse_materialList = new List<GetEditingProjectMaterialsResponse.GetEditingProjectMaterials_Material>();
			for (int i = 0; i < context.Length("GetEditingProjectMaterials.MaterialList.Length"); i++) {
				GetEditingProjectMaterialsResponse.GetEditingProjectMaterials_Material material = new GetEditingProjectMaterialsResponse.GetEditingProjectMaterials_Material();
				material.MaterialId = context.StringValue("GetEditingProjectMaterials.MaterialList["+ i +"].MaterialId");
				material.Title = context.StringValue("GetEditingProjectMaterials.MaterialList["+ i +"].Title");
				material.Tags = context.StringValue("GetEditingProjectMaterials.MaterialList["+ i +"].Tags");
				material.Status = context.StringValue("GetEditingProjectMaterials.MaterialList["+ i +"].Status");
				material.Size = context.LongValue("GetEditingProjectMaterials.MaterialList["+ i +"].Size");
				material.Duration = context.FloatValue("GetEditingProjectMaterials.MaterialList["+ i +"].Duration");
				material.Description = context.StringValue("GetEditingProjectMaterials.MaterialList["+ i +"].Description");
				material.CreationTime = context.StringValue("GetEditingProjectMaterials.MaterialList["+ i +"].CreationTime");
				material.ModifiedTime = context.StringValue("GetEditingProjectMaterials.MaterialList["+ i +"].ModifiedTime");
				material.CoverURL = context.StringValue("GetEditingProjectMaterials.MaterialList["+ i +"].CoverURL");
				material.CateId = context.IntegerValue("GetEditingProjectMaterials.MaterialList["+ i +"].CateId");
				material.CateName = context.StringValue("GetEditingProjectMaterials.MaterialList["+ i +"].CateName");
				material.Source = context.StringValue("GetEditingProjectMaterials.MaterialList["+ i +"].Source");

				List<string> material_snapshots = new List<string>();
				for (int j = 0; j < context.Length("GetEditingProjectMaterials.MaterialList["+ i +"].Snapshots.Length"); j++) {
					material_snapshots.Add(context.StringValue("GetEditingProjectMaterials.MaterialList["+ i +"].Snapshots["+ j +"]"));
				}
				material.Snapshots = material_snapshots;

				List<string> material_sprites = new List<string>();
				for (int j = 0; j < context.Length("GetEditingProjectMaterials.MaterialList["+ i +"].Sprites.Length"); j++) {
					material_sprites.Add(context.StringValue("GetEditingProjectMaterials.MaterialList["+ i +"].Sprites["+ j +"]"));
				}
				material.Sprites = material_sprites;

				getEditingProjectMaterialsResponse_materialList.Add(material);
			}
			getEditingProjectMaterialsResponse.MaterialList = getEditingProjectMaterialsResponse_materialList;
        
			return getEditingProjectMaterialsResponse;
        }
    }
}