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
using Aliyun.Acs.CDRS.Model.V20201101;

namespace Aliyun.Acs.CDRS.Transform.V20201101
{
    public class PaginateProjectResponseUnmarshaller
    {
        public static PaginateProjectResponse Unmarshall(UnmarshallerContext _ctx)
        {
			PaginateProjectResponse paginateProjectResponse = new PaginateProjectResponse();

			paginateProjectResponse.HttpResponse = _ctx.HttpResponse;
			paginateProjectResponse.Code = _ctx.StringValue("PaginateProject.Code");
			paginateProjectResponse.Message = _ctx.StringValue("PaginateProject.Message");
			paginateProjectResponse.RequestId = _ctx.StringValue("PaginateProject.RequestId");

			PaginateProjectResponse.PaginateProject_Data data = new PaginateProjectResponse.PaginateProject_Data();
			data.PageNumber = _ctx.IntegerValue("PaginateProject.Data.PageNumber");
			data.PageSize = _ctx.IntegerValue("PaginateProject.Data.PageSize");
			data.TotalCount = _ctx.IntegerValue("PaginateProject.Data.TotalCount");
			data.TotalPage = _ctx.IntegerValue("PaginateProject.Data.TotalPage");

			List<PaginateProjectResponse.PaginateProject_Data.PaginateProject_RecordsItem> data_records = new List<PaginateProjectResponse.PaginateProject_Data.PaginateProject_RecordsItem>();
			for (int i = 0; i < _ctx.Length("PaginateProject.Data.Records.Length"); i++) {
				PaginateProjectResponse.PaginateProject_Data.PaginateProject_RecordsItem recordsItem = new PaginateProjectResponse.PaginateProject_Data.PaginateProject_RecordsItem();
				recordsItem.UserId = _ctx.StringValue("PaginateProject.Data.Records["+ i +"].UserId");
				recordsItem.Type = _ctx.StringValue("PaginateProject.Data.Records["+ i +"].Type");
				recordsItem.CorpId = _ctx.StringValue("PaginateProject.Data.Records["+ i +"].CorpId");
				recordsItem.Name = _ctx.StringValue("PaginateProject.Data.Records["+ i +"].Name");
				recordsItem.CreatedTime = _ctx.StringValue("PaginateProject.Data.Records["+ i +"].CreatedTime");
				recordsItem.ModifiedTime = _ctx.StringValue("PaginateProject.Data.Records["+ i +"].ModifiedTime");
				recordsItem.Icon = _ctx.StringValue("PaginateProject.Data.Records["+ i +"].Icon");
				recordsItem.Description = _ctx.StringValue("PaginateProject.Data.Records["+ i +"].Description");
				recordsItem.AggregateSceneCode = _ctx.StringValue("PaginateProject.Data.Records["+ i +"].AggregateSceneCode");

				data_records.Add(recordsItem);
			}
			data.Records = data_records;
			paginateProjectResponse.Data = data;
        
			return paginateProjectResponse;
        }
    }
}
