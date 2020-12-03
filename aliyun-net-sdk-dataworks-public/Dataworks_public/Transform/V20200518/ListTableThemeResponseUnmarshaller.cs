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
    public class ListTableThemeResponseUnmarshaller
    {
        public static ListTableThemeResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListTableThemeResponse listTableThemeResponse = new ListTableThemeResponse();

			listTableThemeResponse.HttpResponse = _ctx.HttpResponse;
			listTableThemeResponse.RequestId = _ctx.StringValue("ListTableTheme.RequestId");
			listTableThemeResponse.ErrorCode = _ctx.StringValue("ListTableTheme.ErrorCode");
			listTableThemeResponse.ErrorMessage = _ctx.StringValue("ListTableTheme.ErrorMessage");
			listTableThemeResponse.HttpStatusCode = _ctx.IntegerValue("ListTableTheme.HttpStatusCode");
			listTableThemeResponse.Success = _ctx.BooleanValue("ListTableTheme.Success");

			ListTableThemeResponse.ListTableTheme_Data data = new ListTableThemeResponse.ListTableTheme_Data();
			data.TotalCount = _ctx.LongValue("ListTableTheme.Data.TotalCount");

			List<ListTableThemeResponse.ListTableTheme_Data.ListTableTheme_ThemeListItem> data_themeList = new List<ListTableThemeResponse.ListTableTheme_Data.ListTableTheme_ThemeListItem>();
			for (int i = 0; i < _ctx.Length("ListTableTheme.Data.ThemeList.Length"); i++) {
				ListTableThemeResponse.ListTableTheme_Data.ListTableTheme_ThemeListItem themeListItem = new ListTableThemeResponse.ListTableTheme_Data.ListTableTheme_ThemeListItem();
				themeListItem.ThemeId = _ctx.LongValue("ListTableTheme.Data.ThemeList["+ i +"].ThemeId");
				themeListItem.Name = _ctx.StringValue("ListTableTheme.Data.ThemeList["+ i +"].Name");
				themeListItem.Level = _ctx.IntegerValue("ListTableTheme.Data.ThemeList["+ i +"].Level");
				themeListItem.ParentId = _ctx.LongValue("ListTableTheme.Data.ThemeList["+ i +"].ParentId");
				themeListItem.ProjectId = _ctx.LongValue("ListTableTheme.Data.ThemeList["+ i +"].ProjectId");
				themeListItem.Creator = _ctx.StringValue("ListTableTheme.Data.ThemeList["+ i +"].Creator");
				themeListItem.CreateTimeStamp = _ctx.LongValue("ListTableTheme.Data.ThemeList["+ i +"].CreateTimeStamp");

				data_themeList.Add(themeListItem);
			}
			data.ThemeList = data_themeList;
			listTableThemeResponse.Data = data;
        
			return listTableThemeResponse;
        }
    }
}
