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
using Aliyun.Acs.dms_enterprise.Model.V20181101;

namespace Aliyun.Acs.dms_enterprise.Transform.V20181101
{
    public class ListSQLReviewOriginSQLResponseUnmarshaller
    {
        public static ListSQLReviewOriginSQLResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListSQLReviewOriginSQLResponse listSQLReviewOriginSQLResponse = new ListSQLReviewOriginSQLResponse();

			listSQLReviewOriginSQLResponse.HttpResponse = _ctx.HttpResponse;
			listSQLReviewOriginSQLResponse.RequestId = _ctx.StringValue("ListSQLReviewOriginSQL.RequestId");
			listSQLReviewOriginSQLResponse.ErrorCode = _ctx.StringValue("ListSQLReviewOriginSQL.ErrorCode");
			listSQLReviewOriginSQLResponse.ErrorMessage = _ctx.StringValue("ListSQLReviewOriginSQL.ErrorMessage");
			listSQLReviewOriginSQLResponse.Success = _ctx.BooleanValue("ListSQLReviewOriginSQL.Success");
			listSQLReviewOriginSQLResponse.TotalCount = _ctx.IntegerValue("ListSQLReviewOriginSQL.TotalCount");

			List<ListSQLReviewOriginSQLResponse.ListSQLReviewOriginSQL_OriginSQLListItem> listSQLReviewOriginSQLResponse_originSQLList = new List<ListSQLReviewOriginSQLResponse.ListSQLReviewOriginSQL_OriginSQLListItem>();
			for (int i = 0; i < _ctx.Length("ListSQLReviewOriginSQL.OriginSQLList.Length"); i++) {
				ListSQLReviewOriginSQLResponse.ListSQLReviewOriginSQL_OriginSQLListItem originSQLListItem = new ListSQLReviewOriginSQLResponse.ListSQLReviewOriginSQL_OriginSQLListItem();
				originSQLListItem.SQLId = _ctx.LongValue("ListSQLReviewOriginSQL.OriginSQLList["+ i +"].SQLId");
				originSQLListItem.FileId = _ctx.LongValue("ListSQLReviewOriginSQL.OriginSQLList["+ i +"].FileId");
				originSQLListItem.FileName = _ctx.StringValue("ListSQLReviewOriginSQL.OriginSQLList["+ i +"].FileName");
				originSQLListItem.SQLContent = _ctx.StringValue("ListSQLReviewOriginSQL.OriginSQLList["+ i +"].SQLContent");
				originSQLListItem.CheckStatus = _ctx.StringValue("ListSQLReviewOriginSQL.OriginSQLList["+ i +"].CheckStatus");
				originSQLListItem.StatusDesc = _ctx.StringValue("ListSQLReviewOriginSQL.OriginSQLList["+ i +"].StatusDesc");
				originSQLListItem.CheckedTime = _ctx.StringValue("ListSQLReviewOriginSQL.OriginSQLList["+ i +"].CheckedTime");
				originSQLListItem.SqlHash = _ctx.StringValue("ListSQLReviewOriginSQL.OriginSQLList["+ i +"].SqlHash");
				originSQLListItem.ReviewSummary = _ctx.StringValue("ListSQLReviewOriginSQL.OriginSQLList["+ i +"].ReviewSummary");
				originSQLListItem.SQLReviewQueryKey = _ctx.StringValue("ListSQLReviewOriginSQL.OriginSQLList["+ i +"].SQLReviewQueryKey");

				listSQLReviewOriginSQLResponse_originSQLList.Add(originSQLListItem);
			}
			listSQLReviewOriginSQLResponse.OriginSQLList = listSQLReviewOriginSQLResponse_originSQLList;
        
			return listSQLReviewOriginSQLResponse;
        }
    }
}
