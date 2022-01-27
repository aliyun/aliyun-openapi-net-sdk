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
    public class ListTableLevelResponseUnmarshaller
    {
        public static ListTableLevelResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListTableLevelResponse listTableLevelResponse = new ListTableLevelResponse();

			listTableLevelResponse.HttpResponse = _ctx.HttpResponse;
			listTableLevelResponse.RequestId = _ctx.StringValue("ListTableLevel.RequestId");
			listTableLevelResponse.ErrorCode = _ctx.StringValue("ListTableLevel.ErrorCode");
			listTableLevelResponse.ErrorMessage = _ctx.StringValue("ListTableLevel.ErrorMessage");
			listTableLevelResponse.HttpStatusCode = _ctx.IntegerValue("ListTableLevel.HttpStatusCode");
			listTableLevelResponse.Success = _ctx.BooleanValue("ListTableLevel.Success");

			ListTableLevelResponse.ListTableLevel_TableLevelInfo tableLevelInfo = new ListTableLevelResponse.ListTableLevel_TableLevelInfo();
			tableLevelInfo.TotalCount = _ctx.LongValue("ListTableLevel.TableLevelInfo.TotalCount");

			List<ListTableLevelResponse.ListTableLevel_TableLevelInfo.ListTableLevel_LevelListItem> tableLevelInfo_levelList = new List<ListTableLevelResponse.ListTableLevel_TableLevelInfo.ListTableLevel_LevelListItem>();
			for (int i = 0; i < _ctx.Length("ListTableLevel.TableLevelInfo.LevelList.Length"); i++) {
				ListTableLevelResponse.ListTableLevel_TableLevelInfo.ListTableLevel_LevelListItem levelListItem = new ListTableLevelResponse.ListTableLevel_TableLevelInfo.ListTableLevel_LevelListItem();
				levelListItem.LevelId = _ctx.LongValue("ListTableLevel.TableLevelInfo.LevelList["+ i +"].LevelId");
				levelListItem.Name = _ctx.StringValue("ListTableLevel.TableLevelInfo.LevelList["+ i +"].Name");
				levelListItem.ProjectId = _ctx.LongValue("ListTableLevel.TableLevelInfo.LevelList["+ i +"].ProjectId");
				levelListItem.LevelType = _ctx.IntegerValue("ListTableLevel.TableLevelInfo.LevelList["+ i +"].LevelType");
				levelListItem.Description = _ctx.StringValue("ListTableLevel.TableLevelInfo.LevelList["+ i +"].Description");

				tableLevelInfo_levelList.Add(levelListItem);
			}
			tableLevelInfo.LevelList = tableLevelInfo_levelList;
			listTableLevelResponse.TableLevelInfo = tableLevelInfo;
        
			return listTableLevelResponse;
        }
    }
}
