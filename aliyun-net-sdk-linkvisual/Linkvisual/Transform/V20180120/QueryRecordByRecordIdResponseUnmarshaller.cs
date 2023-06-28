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
    public class QueryRecordByRecordIdResponseUnmarshaller
    {
        public static QueryRecordByRecordIdResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryRecordByRecordIdResponse queryRecordByRecordIdResponse = new QueryRecordByRecordIdResponse();

			queryRecordByRecordIdResponse.HttpResponse = _ctx.HttpResponse;
			queryRecordByRecordIdResponse.Code = _ctx.StringValue("QueryRecordByRecordId.Code");
			queryRecordByRecordIdResponse.RequestId = _ctx.StringValue("QueryRecordByRecordId.RequestId");
			queryRecordByRecordIdResponse.ErrorMessage = _ctx.StringValue("QueryRecordByRecordId.ErrorMessage");
			queryRecordByRecordIdResponse.Success = _ctx.BooleanValue("QueryRecordByRecordId.Success");

			List<QueryRecordByRecordIdResponse.QueryRecordByRecordId_DataItem> queryRecordByRecordIdResponse_data = new List<QueryRecordByRecordIdResponse.QueryRecordByRecordId_DataItem>();
			for (int i = 0; i < _ctx.Length("QueryRecordByRecordId.Data.Length"); i++) {
				QueryRecordByRecordIdResponse.QueryRecordByRecordId_DataItem dataItem = new QueryRecordByRecordIdResponse.QueryRecordByRecordId_DataItem();
				dataItem.EndTime = _ctx.StringValue("QueryRecordByRecordId.Data["+ i +"].EndTime");
				dataItem.FileName = _ctx.StringValue("QueryRecordByRecordId.Data["+ i +"].FileName");
				dataItem.VodUrl = _ctx.StringValue("QueryRecordByRecordId.Data["+ i +"].VodUrl");
				dataItem.BeginTime = _ctx.StringValue("QueryRecordByRecordId.Data["+ i +"].BeginTime");

				queryRecordByRecordIdResponse_data.Add(dataItem);
			}
			queryRecordByRecordIdResponse.Data = queryRecordByRecordIdResponse_data;
        
			return queryRecordByRecordIdResponse;
        }
    }
}
