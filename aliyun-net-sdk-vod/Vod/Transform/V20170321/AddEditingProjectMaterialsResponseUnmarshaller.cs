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
    public class AddEditingProjectMaterialsResponseUnmarshaller
    {
        public static AddEditingProjectMaterialsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			AddEditingProjectMaterialsResponse addEditingProjectMaterialsResponse = new AddEditingProjectMaterialsResponse();

			addEditingProjectMaterialsResponse.HttpResponse = _ctx.HttpResponse;
			addEditingProjectMaterialsResponse.RequestId = _ctx.StringValue("AddEditingProjectMaterials.RequestId");

			List<AddEditingProjectMaterialsResponse.AddEditingProjectMaterials_Material> addEditingProjectMaterialsResponse_materialList = new List<AddEditingProjectMaterialsResponse.AddEditingProjectMaterials_Material>();
			for (int i = 0; i < _ctx.Length("AddEditingProjectMaterials.MaterialList.Length"); i++) {
				AddEditingProjectMaterialsResponse.AddEditingProjectMaterials_Material material = new AddEditingProjectMaterialsResponse.AddEditingProjectMaterials_Material();
				material.Status = _ctx.StringValue("AddEditingProjectMaterials.MaterialList["+ i +"].Status");
				material.CateId = _ctx.IntegerValue("AddEditingProjectMaterials.MaterialList["+ i +"].CateId");
				material.CreateTime = _ctx.StringValue("AddEditingProjectMaterials.MaterialList["+ i +"].CreateTime");
				material.MaterialType = _ctx.StringValue("AddEditingProjectMaterials.MaterialList["+ i +"].MaterialType");
				material.Tags = _ctx.StringValue("AddEditingProjectMaterials.MaterialList["+ i +"].Tags");
				material.SpriteConfig = _ctx.StringValue("AddEditingProjectMaterials.MaterialList["+ i +"].SpriteConfig");
				material.CateName = _ctx.StringValue("AddEditingProjectMaterials.MaterialList["+ i +"].CateName");
				material.Description = _ctx.StringValue("AddEditingProjectMaterials.MaterialList["+ i +"].Description");
				material.MaterialId = _ctx.StringValue("AddEditingProjectMaterials.MaterialList["+ i +"].MaterialId");
				material.Size = _ctx.LongValue("AddEditingProjectMaterials.MaterialList["+ i +"].Size");
				material.CoverURL = _ctx.StringValue("AddEditingProjectMaterials.MaterialList["+ i +"].CoverURL");
				material.Duration = _ctx.FloatValue("AddEditingProjectMaterials.MaterialList["+ i +"].Duration");
				material.CustomerId = _ctx.LongValue("AddEditingProjectMaterials.MaterialList["+ i +"].CustomerId");
				material.Title = _ctx.StringValue("AddEditingProjectMaterials.MaterialList["+ i +"].Title");
				material.ModifyTime = _ctx.StringValue("AddEditingProjectMaterials.MaterialList["+ i +"].ModifyTime");

				List<string> material_sprites = new List<string>();
				for (int j = 0; j < _ctx.Length("AddEditingProjectMaterials.MaterialList["+ i +"].Sprites.Length"); j++) {
					material_sprites.Add(_ctx.StringValue("AddEditingProjectMaterials.MaterialList["+ i +"].Sprites["+ j +"]"));
				}
				material.Sprites = material_sprites;

				List<string> material_snapshots = new List<string>();
				for (int j = 0; j < _ctx.Length("AddEditingProjectMaterials.MaterialList["+ i +"].Snapshots.Length"); j++) {
					material_snapshots.Add(_ctx.StringValue("AddEditingProjectMaterials.MaterialList["+ i +"].Snapshots["+ j +"]"));
				}
				material.Snapshots = material_snapshots;

				addEditingProjectMaterialsResponse_materialList.Add(material);
			}
			addEditingProjectMaterialsResponse.MaterialList = addEditingProjectMaterialsResponse_materialList;
        
			return addEditingProjectMaterialsResponse;
        }
    }
}
