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
using Aliyun.Acs.Copyright.Model.V20190123;

namespace Aliyun.Acs.Copyright.Transform.V20190123
{
    public class ListUserHistoryProducesResponseUnmarshaller
    {
        public static ListUserHistoryProducesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListUserHistoryProducesResponse listUserHistoryProducesResponse = new ListUserHistoryProducesResponse();

			listUserHistoryProducesResponse.HttpResponse = _ctx.HttpResponse;
			listUserHistoryProducesResponse.PageNum = _ctx.IntegerValue("ListUserHistoryProduces.PageNum");
			listUserHistoryProducesResponse.PageSize = _ctx.IntegerValue("ListUserHistoryProduces.PageSize");
			listUserHistoryProducesResponse.RequestId = _ctx.StringValue("ListUserHistoryProduces.RequestId");
			listUserHistoryProducesResponse.Success = _ctx.BooleanValue("ListUserHistoryProduces.Success");
			listUserHistoryProducesResponse.TotalItemNum = _ctx.IntegerValue("ListUserHistoryProduces.TotalItemNum");
			listUserHistoryProducesResponse.TotalPageNum = _ctx.IntegerValue("ListUserHistoryProduces.TotalPageNum");

			List<ListUserHistoryProducesResponse.ListUserHistoryProduces_Produces> listUserHistoryProducesResponse_data = new List<ListUserHistoryProducesResponse.ListUserHistoryProduces_Produces>();
			for (int i = 0; i < _ctx.Length("ListUserHistoryProduces.Data.Length"); i++) {
				ListUserHistoryProducesResponse.ListUserHistoryProduces_Produces produces = new ListUserHistoryProducesResponse.ListUserHistoryProduces_Produces();
				produces.BizId = _ctx.StringValue("ListUserHistoryProduces.Data["+ i +"].BizId");
				produces.BizType = _ctx.StringValue("ListUserHistoryProduces.Data["+ i +"].BizType");
				produces.ExtInfo = _ctx.StringValue("ListUserHistoryProduces.Data["+ i +"].ExtInfo");
				produces.IntentionBizId = _ctx.StringValue("ListUserHistoryProduces.Data["+ i +"].IntentionBizId");
				produces.ModifyTime = _ctx.StringValue("ListUserHistoryProduces.Data["+ i +"].ModifyTime");
				produces.OldOrder = _ctx.BooleanValue("ListUserHistoryProduces.Data["+ i +"].OldOrder");
				produces.OrderId = _ctx.StringValue("ListUserHistoryProduces.Data["+ i +"].OrderId");
				produces.OrderPrice = _ctx.StringValue("ListUserHistoryProduces.Data["+ i +"].OrderPrice");
				produces.OrderTime = _ctx.StringValue("ListUserHistoryProduces.Data["+ i +"].OrderTime");
				produces.PartnerCode = _ctx.StringValue("ListUserHistoryProduces.Data["+ i +"].PartnerCode");
				produces.SolutionBizId = _ctx.StringValue("ListUserHistoryProduces.Data["+ i +"].SolutionBizId");
				produces.Status = _ctx.IntegerValue("ListUserHistoryProduces.Data["+ i +"].Status");
				produces.UserId = _ctx.StringValue("ListUserHistoryProduces.Data["+ i +"].UserId");
				produces.SerialNumber = _ctx.StringValue("ListUserHistoryProduces.Data["+ i +"].SerialNumber");

				listUserHistoryProducesResponse_data.Add(produces);
			}
			listUserHistoryProducesResponse.Data = listUserHistoryProducesResponse_data;
        
			return listUserHistoryProducesResponse;
        }
    }
}
