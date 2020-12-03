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
    public class GetMetaTableChangeLogResponseUnmarshaller
    {
        public static GetMetaTableChangeLogResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetMetaTableChangeLogResponse getMetaTableChangeLogResponse = new GetMetaTableChangeLogResponse();

			getMetaTableChangeLogResponse.HttpResponse = _ctx.HttpResponse;
			getMetaTableChangeLogResponse.RequestId = _ctx.StringValue("GetMetaTableChangeLog.RequestId");
			getMetaTableChangeLogResponse.ErrorCode = _ctx.StringValue("GetMetaTableChangeLog.ErrorCode");
			getMetaTableChangeLogResponse.ErrorMessage = _ctx.StringValue("GetMetaTableChangeLog.ErrorMessage");
			getMetaTableChangeLogResponse.HttpStatusCode = _ctx.IntegerValue("GetMetaTableChangeLog.HttpStatusCode");
			getMetaTableChangeLogResponse.Success = _ctx.BooleanValue("GetMetaTableChangeLog.Success");

			GetMetaTableChangeLogResponse.GetMetaTableChangeLog_Data data = new GetMetaTableChangeLogResponse.GetMetaTableChangeLog_Data();
			data.PageNumber = _ctx.IntegerValue("GetMetaTableChangeLog.Data.PageNumber");
			data.PageSize = _ctx.IntegerValue("GetMetaTableChangeLog.Data.PageSize");
			data.TotalCount = _ctx.LongValue("GetMetaTableChangeLog.Data.TotalCount");

			List<GetMetaTableChangeLogResponse.GetMetaTableChangeLog_Data.GetMetaTableChangeLog_DataEntityListItem> data_dataEntityList = new List<GetMetaTableChangeLogResponse.GetMetaTableChangeLog_Data.GetMetaTableChangeLog_DataEntityListItem>();
			for (int i = 0; i < _ctx.Length("GetMetaTableChangeLog.Data.DataEntityList.Length"); i++) {
				GetMetaTableChangeLogResponse.GetMetaTableChangeLog_Data.GetMetaTableChangeLog_DataEntityListItem dataEntityListItem = new GetMetaTableChangeLogResponse.GetMetaTableChangeLog_Data.GetMetaTableChangeLog_DataEntityListItem();
				dataEntityListItem.CreateTime = _ctx.LongValue("GetMetaTableChangeLog.Data.DataEntityList["+ i +"].CreateTime");
				dataEntityListItem.ModifiedTime = _ctx.LongValue("GetMetaTableChangeLog.Data.DataEntityList["+ i +"].ModifiedTime");
				dataEntityListItem.ChangeType = _ctx.StringValue("GetMetaTableChangeLog.Data.DataEntityList["+ i +"].ChangeType");
				dataEntityListItem._Operator = _ctx.StringValue("GetMetaTableChangeLog.Data.DataEntityList["+ i +"].Operator");
				dataEntityListItem.ObjectType = _ctx.StringValue("GetMetaTableChangeLog.Data.DataEntityList["+ i +"].ObjectType");
				dataEntityListItem.ChangeContent = _ctx.StringValue("GetMetaTableChangeLog.Data.DataEntityList["+ i +"].ChangeContent");

				data_dataEntityList.Add(dataEntityListItem);
			}
			data.DataEntityList = data_dataEntityList;
			getMetaTableChangeLogResponse.Data = data;
        
			return getMetaTableChangeLogResponse;
        }
    }
}
