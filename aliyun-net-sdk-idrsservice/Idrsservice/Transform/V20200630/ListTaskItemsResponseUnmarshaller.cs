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
using Aliyun.Acs.idrsservice.Model.V20200630;

namespace Aliyun.Acs.idrsservice.Transform.V20200630
{
    public class ListTaskItemsResponseUnmarshaller
    {
        public static ListTaskItemsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListTaskItemsResponse listTaskItemsResponse = new ListTaskItemsResponse();

			listTaskItemsResponse.HttpResponse = _ctx.HttpResponse;
			listTaskItemsResponse.Code = _ctx.StringValue("ListTaskItems.Code");
			listTaskItemsResponse.Message = _ctx.StringValue("ListTaskItems.Message");
			listTaskItemsResponse.RequestId = _ctx.StringValue("ListTaskItems.RequestId");

			List<ListTaskItemsResponse.ListTaskItems_DataItem> listTaskItemsResponse_data = new List<ListTaskItemsResponse.ListTaskItems_DataItem>();
			for (int i = 0; i < _ctx.Length("ListTaskItems.Data.Length"); i++) {
				ListTaskItemsResponse.ListTaskItems_DataItem dataItem = new ListTaskItemsResponse.ListTaskItems_DataItem();
				dataItem.CreatedAt = _ctx.StringValue("ListTaskItems.Data["+ i +"].CreatedAt");
				dataItem.Message = _ctx.StringValue("ListTaskItems.Data["+ i +"].Message");
				dataItem.Name = _ctx.StringValue("ListTaskItems.Data["+ i +"].Name");
				dataItem.Output = _ctx.StringValue("ListTaskItems.Data["+ i +"].Output");
				dataItem.SegmentSeq = _ctx.LongValue("ListTaskItems.Data["+ i +"].SegmentSeq");
				dataItem.Status = _ctx.StringValue("ListTaskItems.Data["+ i +"].Status");

				listTaskItemsResponse_data.Add(dataItem);
			}
			listTaskItemsResponse.Data = listTaskItemsResponse_data;
        
			return listTaskItemsResponse;
        }
    }
}
