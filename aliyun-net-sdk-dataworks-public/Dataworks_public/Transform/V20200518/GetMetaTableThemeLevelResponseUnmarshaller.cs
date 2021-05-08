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
using Aliyun.Acs.dataworks_public.Model.V20200518;

namespace Aliyun.Acs.dataworks_public.Transform.V20200518
{
    public class GetMetaTableThemeLevelResponseUnmarshaller
    {
        public static GetMetaTableThemeLevelResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetMetaTableThemeLevelResponse getMetaTableThemeLevelResponse = new GetMetaTableThemeLevelResponse();

			getMetaTableThemeLevelResponse.HttpResponse = _ctx.HttpResponse;
			getMetaTableThemeLevelResponse.RequestId = _ctx.StringValue("GetMetaTableThemeLevel.RequestId");
			getMetaTableThemeLevelResponse.ErrorCode = _ctx.StringValue("GetMetaTableThemeLevel.ErrorCode");
			getMetaTableThemeLevelResponse.ErrorMessage = _ctx.StringValue("GetMetaTableThemeLevel.ErrorMessage");
			getMetaTableThemeLevelResponse.HttpStatusCode = _ctx.IntegerValue("GetMetaTableThemeLevel.HttpStatusCode");
			getMetaTableThemeLevelResponse.Success = _ctx.BooleanValue("GetMetaTableThemeLevel.Success");

			GetMetaTableThemeLevelResponse.GetMetaTableThemeLevel_Entity entity = new GetMetaTableThemeLevelResponse.GetMetaTableThemeLevel_Entity();

			List<GetMetaTableThemeLevelResponse.GetMetaTableThemeLevel_Entity.GetMetaTableThemeLevel_ThemeItem> entity_theme = new List<GetMetaTableThemeLevelResponse.GetMetaTableThemeLevel_Entity.GetMetaTableThemeLevel_ThemeItem>();
			for (int i = 0; i < _ctx.Length("GetMetaTableThemeLevel.Entity.Theme.Length"); i++) {
				GetMetaTableThemeLevelResponse.GetMetaTableThemeLevel_Entity.GetMetaTableThemeLevel_ThemeItem themeItem = new GetMetaTableThemeLevelResponse.GetMetaTableThemeLevel_Entity.GetMetaTableThemeLevel_ThemeItem();
				themeItem.ThemeId = _ctx.LongValue("GetMetaTableThemeLevel.Entity.Theme["+ i +"].ThemeId");
				themeItem.Name = _ctx.StringValue("GetMetaTableThemeLevel.Entity.Theme["+ i +"].Name");
				themeItem.Level = _ctx.IntegerValue("GetMetaTableThemeLevel.Entity.Theme["+ i +"].Level");
				themeItem.ParentId = _ctx.LongValue("GetMetaTableThemeLevel.Entity.Theme["+ i +"].ParentId");

				entity_theme.Add(themeItem);
			}
			entity.Theme = entity_theme;

			List<GetMetaTableThemeLevelResponse.GetMetaTableThemeLevel_Entity.GetMetaTableThemeLevel_LevelItem> entity_level = new List<GetMetaTableThemeLevelResponse.GetMetaTableThemeLevel_Entity.GetMetaTableThemeLevel_LevelItem>();
			for (int i = 0; i < _ctx.Length("GetMetaTableThemeLevel.Entity.Level.Length"); i++) {
				GetMetaTableThemeLevelResponse.GetMetaTableThemeLevel_Entity.GetMetaTableThemeLevel_LevelItem levelItem = new GetMetaTableThemeLevelResponse.GetMetaTableThemeLevel_Entity.GetMetaTableThemeLevel_LevelItem();
				levelItem.LevelId = _ctx.LongValue("GetMetaTableThemeLevel.Entity.Level["+ i +"].LevelId");
				levelItem.Name = _ctx.StringValue("GetMetaTableThemeLevel.Entity.Level["+ i +"].Name");
				levelItem.Type = _ctx.IntegerValue("GetMetaTableThemeLevel.Entity.Level["+ i +"].Type");
				levelItem.Description = _ctx.StringValue("GetMetaTableThemeLevel.Entity.Level["+ i +"].Description");

				entity_level.Add(levelItem);
			}
			entity.Level = entity_level;
			getMetaTableThemeLevelResponse.Entity = entity;
        
			return getMetaTableThemeLevelResponse;
        }
    }
}
