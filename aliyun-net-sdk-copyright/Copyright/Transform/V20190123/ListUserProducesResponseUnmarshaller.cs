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
    public class ListUserProducesResponseUnmarshaller
    {
        public static ListUserProducesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListUserProducesResponse listUserProducesResponse = new ListUserProducesResponse();

			listUserProducesResponse.HttpResponse = _ctx.HttpResponse;
			listUserProducesResponse.PageNum = _ctx.IntegerValue("ListUserProduces.PageNum");
			listUserProducesResponse.PageSize = _ctx.IntegerValue("ListUserProduces.PageSize");
			listUserProducesResponse.RequestId = _ctx.StringValue("ListUserProduces.RequestId");
			listUserProducesResponse.Success = _ctx.BooleanValue("ListUserProduces.Success");
			listUserProducesResponse.TotalItemNum = _ctx.IntegerValue("ListUserProduces.TotalItemNum");
			listUserProducesResponse.TotalPageNum = _ctx.IntegerValue("ListUserProduces.TotalPageNum");

			List<ListUserProducesResponse.ListUserProduces_Produces> listUserProducesResponse_data = new List<ListUserProducesResponse.ListUserProduces_Produces>();
			for (int i = 0; i < _ctx.Length("ListUserProduces.Data.Length"); i++) {
				ListUserProducesResponse.ListUserProduces_Produces produces = new ListUserProducesResponse.ListUserProduces_Produces();
				produces.BizId = _ctx.StringValue("ListUserProduces.Data["+ i +"].BizId");
				produces.BizType = _ctx.StringValue("ListUserProduces.Data["+ i +"].BizType");
				produces.EndTime = _ctx.StringValue("ListUserProduces.Data["+ i +"].EndTime");
				produces.ExtInfo = _ctx.StringValue("ListUserProduces.Data["+ i +"].ExtInfo");
				produces.IntentionBizId = _ctx.StringValue("ListUserProduces.Data["+ i +"].IntentionBizId");
				produces.ModifyTime = _ctx.StringValue("ListUserProduces.Data["+ i +"].ModifyTime");
				produces.OrderId = _ctx.StringValue("ListUserProduces.Data["+ i +"].OrderId");
				produces.OrderPrice = _ctx.StringValue("ListUserProduces.Data["+ i +"].OrderPrice");
				produces.OrderTime = _ctx.StringValue("ListUserProduces.Data["+ i +"].OrderTime");
				produces.PartnerCode = _ctx.StringValue("ListUserProduces.Data["+ i +"].PartnerCode");
				produces.SolutionBizId = _ctx.StringValue("ListUserProduces.Data["+ i +"].SolutionBizId");
				produces.StartTime = _ctx.StringValue("ListUserProduces.Data["+ i +"].StartTime");
				produces.Status = _ctx.IntegerValue("ListUserProduces.Data["+ i +"].Status");
				produces.UserId = _ctx.StringValue("ListUserProduces.Data["+ i +"].UserId");

				listUserProducesResponse_data.Add(produces);
			}
			listUserProducesResponse.Data = listUserProducesResponse_data;
        
			return listUserProducesResponse;
        }
    }
}
