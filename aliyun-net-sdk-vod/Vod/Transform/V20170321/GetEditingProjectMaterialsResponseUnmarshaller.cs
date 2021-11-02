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
using Aliyun.Acs.vod.Model.V20170321;

namespace Aliyun.Acs.vod.Transform.V20170321
{
    public class GetEditingProjectMaterialsResponseUnmarshaller
    {
        public static GetEditingProjectMaterialsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetEditingProjectMaterialsResponse getEditingProjectMaterialsResponse = new GetEditingProjectMaterialsResponse();

			getEditingProjectMaterialsResponse.HttpResponse = _ctx.HttpResponse;
			getEditingProjectMaterialsResponse.RequestId = _ctx.StringValue("GetEditingProjectMaterials.RequestId");

			List<GetEditingProjectMaterialsResponse.GetEditingProjectMaterials_Material> getEditingProjectMaterialsResponse_materialList = new List<GetEditingProjectMaterialsResponse.GetEditingProjectMaterials_Material>();
			for (int i = 0; i < _ctx.Length("GetEditingProjectMaterials.MaterialList.Length"); i++) {
				GetEditingProjectMaterialsResponse.GetEditingProjectMaterials_Material material = new GetEditingProjectMaterialsResponse.GetEditingProjectMaterials_Material();
				material.MaterialId = _ctx.StringValue("GetEditingProjectMaterials.MaterialList["+ i +"].MaterialId");
				material.Title = _ctx.StringValue("GetEditingProjectMaterials.MaterialList["+ i +"].Title");
				material.Tags = _ctx.StringValue("GetEditingProjectMaterials.MaterialList["+ i +"].Tags");
				material.Status = _ctx.StringValue("GetEditingProjectMaterials.MaterialList["+ i +"].Status");
				material.Size = _ctx.LongValue("GetEditingProjectMaterials.MaterialList["+ i +"].Size");
				material.Duration = _ctx.FloatValue("GetEditingProjectMaterials.MaterialList["+ i +"].Duration");
				material.Description = _ctx.StringValue("GetEditingProjectMaterials.MaterialList["+ i +"].Description");
				material.CreationTime = _ctx.StringValue("GetEditingProjectMaterials.MaterialList["+ i +"].CreationTime");
				material.ModifiedTime = _ctx.StringValue("GetEditingProjectMaterials.MaterialList["+ i +"].ModifiedTime");
				material.CoverURL = _ctx.StringValue("GetEditingProjectMaterials.MaterialList["+ i +"].CoverURL");
				material.CateId = _ctx.IntegerValue("GetEditingProjectMaterials.MaterialList["+ i +"].CateId");
				material.CateName = _ctx.StringValue("GetEditingProjectMaterials.MaterialList["+ i +"].CateName");
				material.Source = _ctx.StringValue("GetEditingProjectMaterials.MaterialList["+ i +"].Source");
				material.SpriteConfig = _ctx.StringValue("GetEditingProjectMaterials.MaterialList["+ i +"].SpriteConfig");
				material.MaterialType = _ctx.StringValue("GetEditingProjectMaterials.MaterialList["+ i +"].MaterialType");

				List<string> material_snapshots = new List<string>();
				for (int j = 0; j < _ctx.Length("GetEditingProjectMaterials.MaterialList["+ i +"].Snapshots.Length"); j++) {
					material_snapshots.Add(_ctx.StringValue("GetEditingProjectMaterials.MaterialList["+ i +"].Snapshots["+ j +"]"));
				}
				material.Snapshots = material_snapshots;

				List<string> material_sprites = new List<string>();
				for (int j = 0; j < _ctx.Length("GetEditingProjectMaterials.MaterialList["+ i +"].Sprites.Length"); j++) {
					material_sprites.Add(_ctx.StringValue("GetEditingProjectMaterials.MaterialList["+ i +"].Sprites["+ j +"]"));
				}
				material.Sprites = material_sprites;

				getEditingProjectMaterialsResponse_materialList.Add(material);
			}
			getEditingProjectMaterialsResponse.MaterialList = getEditingProjectMaterialsResponse_materialList;
        
			return getEditingProjectMaterialsResponse;
        }
    }
}
