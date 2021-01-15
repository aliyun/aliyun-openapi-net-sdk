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
    public class ListPersonTopResponseUnmarshaller
    {
        public static ListPersonTopResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListPersonTopResponse listPersonTopResponse = new ListPersonTopResponse();

			listPersonTopResponse.HttpResponse = _ctx.HttpResponse;
			listPersonTopResponse.Code = _ctx.StringValue("ListPersonTop.Code");
			listPersonTopResponse.Message = _ctx.StringValue("ListPersonTop.Message");
			listPersonTopResponse.RequestId = _ctx.StringValue("ListPersonTop.RequestId");
			listPersonTopResponse.PageNumber = _ctx.LongValue("ListPersonTop.PageNumber");
			listPersonTopResponse.PageSize = _ctx.LongValue("ListPersonTop.PageSize");
			listPersonTopResponse.TotalCount = _ctx.LongValue("ListPersonTop.TotalCount");

			List<ListPersonTopResponse.ListPersonTop_DataItem> listPersonTopResponse_data = new List<ListPersonTopResponse.ListPersonTop_DataItem>();
			for (int i = 0; i < _ctx.Length("ListPersonTop.Data.Length"); i++) {
				ListPersonTopResponse.ListPersonTop_DataItem dataItem = new ListPersonTopResponse.ListPersonTop_DataItem();
				dataItem.CorpId = _ctx.StringValue("ListPersonTop.Data["+ i +"].CorpId");
				dataItem.PersonId = _ctx.StringValue("ListPersonTop.Data["+ i +"].PersonId");
				dataItem.PoiId = _ctx.StringValue("ListPersonTop.Data["+ i +"].PoiId");
				dataItem.PoiName = _ctx.StringValue("ListPersonTop.Data["+ i +"].PoiName");
				dataItem.PassHour = _ctx.StringValue("ListPersonTop.Data["+ i +"].PassHour");
				dataItem.Frequency = _ctx.StringValue("ListPersonTop.Data["+ i +"].Frequency");

				listPersonTopResponse_data.Add(dataItem);
			}
			listPersonTopResponse.Data = listPersonTopResponse_data;
        
			return listPersonTopResponse;
        }
    }
}
