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
using Aliyun.Acs.Emr.Model.V20160408;

namespace Aliyun.Acs.Emr.Transform.V20160408
{
    public class ListFlowNodeSqlResultResponseUnmarshaller
    {
        public static ListFlowNodeSqlResultResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListFlowNodeSqlResultResponse listFlowNodeSqlResultResponse = new ListFlowNodeSqlResultResponse();

			listFlowNodeSqlResultResponse.HttpResponse = _ctx.HttpResponse;
			listFlowNodeSqlResultResponse.RequestId = _ctx.StringValue("ListFlowNodeSqlResult.RequestId");
			listFlowNodeSqlResultResponse.End = _ctx.BooleanValue("ListFlowNodeSqlResult.End");

			List<string> listFlowNodeSqlResultResponse_headerList = new List<string>();
			for (int i = 0; i < _ctx.Length("ListFlowNodeSqlResult.HeaderList.Length"); i++) {
				listFlowNodeSqlResultResponse_headerList.Add(_ctx.StringValue("ListFlowNodeSqlResult.HeaderList["+ i +"]"));
			}
			listFlowNodeSqlResultResponse.HeaderList = listFlowNodeSqlResultResponse_headerList;

			List<ListFlowNodeSqlResultResponse.ListFlowNodeSqlResult_Row> listFlowNodeSqlResultResponse_rowList = new List<ListFlowNodeSqlResultResponse.ListFlowNodeSqlResult_Row>();
			for (int i = 0; i < _ctx.Length("ListFlowNodeSqlResult.RowList.Length"); i++) {
				ListFlowNodeSqlResultResponse.ListFlowNodeSqlResult_Row row = new ListFlowNodeSqlResultResponse.ListFlowNodeSqlResult_Row();
				row.RowIndex = _ctx.IntegerValue("ListFlowNodeSqlResult.RowList["+ i +"].RowIndex");

				List<string> row_rowItemList = new List<string>();
				for (int j = 0; j < _ctx.Length("ListFlowNodeSqlResult.RowList["+ i +"].RowItemList.Length"); j++) {
					row_rowItemList.Add(_ctx.StringValue("ListFlowNodeSqlResult.RowList["+ i +"].RowItemList["+ j +"]"));
				}
				row.RowItemList = row_rowItemList;

				listFlowNodeSqlResultResponse_rowList.Add(row);
			}
			listFlowNodeSqlResultResponse.RowList = listFlowNodeSqlResultResponse_rowList;
        
			return listFlowNodeSqlResultResponse;
        }
    }
}
