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
using Aliyun.Acs.Linkvisual.Model.V20180120;

namespace Aliyun.Acs.Linkvisual.Transform.V20180120
{
    public class QueryRecordResponseUnmarshaller
    {
        public static QueryRecordResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryRecordResponse queryRecordResponse = new QueryRecordResponse();

			queryRecordResponse.HttpResponse = _ctx.HttpResponse;
			queryRecordResponse.Code = _ctx.StringValue("QueryRecord.Code");
			queryRecordResponse.RequestId = _ctx.StringValue("QueryRecord.RequestId");
			queryRecordResponse.ErrorMessage = _ctx.StringValue("QueryRecord.ErrorMessage");
			queryRecordResponse.Success = _ctx.BooleanValue("QueryRecord.Success");

			QueryRecordResponse.QueryRecord_Data data = new QueryRecordResponse.QueryRecord_Data();
			data.Page = _ctx.IntegerValue("QueryRecord.Data.Page");
			data.PageSize = _ctx.IntegerValue("QueryRecord.Data.PageSize");

			List<QueryRecordResponse.QueryRecord_Data.QueryRecord_ListItem> data_list = new List<QueryRecordResponse.QueryRecord_Data.QueryRecord_ListItem>();
			for (int i = 0; i < _ctx.Length("QueryRecord.Data.List.Length"); i++) {
				QueryRecordResponse.QueryRecord_Data.QueryRecord_ListItem listItem = new QueryRecordResponse.QueryRecord_Data.QueryRecord_ListItem();
				listItem.SnapshotUrl = _ctx.StringValue("QueryRecord.Data.List["+ i +"].SnapshotUrl");
				listItem.EndTime = _ctx.StringValue("QueryRecord.Data.List["+ i +"].EndTime");
				listItem.RecordType = _ctx.IntegerValue("QueryRecord.Data.List["+ i +"].RecordType");
				listItem.StreamType = _ctx.IntegerValue("QueryRecord.Data.List["+ i +"].StreamType");
				listItem.BeginTime = _ctx.StringValue("QueryRecord.Data.List["+ i +"].BeginTime");
				listItem.FileName = _ctx.StringValue("QueryRecord.Data.List["+ i +"].FileName");
				listItem.VideoFrameNumber = _ctx.IntegerValue("QueryRecord.Data.List["+ i +"].VideoFrameNumber");
				listItem.FileSize = _ctx.IntegerValue("QueryRecord.Data.List["+ i +"].FileSize");

				data_list.Add(listItem);
			}
			data.List = data_list;
			queryRecordResponse.Data = data;
        
			return queryRecordResponse;
        }
    }
}
