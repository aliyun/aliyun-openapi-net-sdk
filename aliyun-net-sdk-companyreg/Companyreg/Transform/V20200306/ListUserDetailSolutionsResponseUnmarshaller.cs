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
using Aliyun.Acs.companyreg.Model.V20200306;

namespace Aliyun.Acs.companyreg.Transform.V20200306
{
    public class ListUserDetailSolutionsResponseUnmarshaller
    {
        public static ListUserDetailSolutionsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListUserDetailSolutionsResponse listUserDetailSolutionsResponse = new ListUserDetailSolutionsResponse();

			listUserDetailSolutionsResponse.HttpResponse = _ctx.HttpResponse;
			listUserDetailSolutionsResponse.CurrentPageNum = _ctx.IntegerValue("ListUserDetailSolutions.CurrentPageNum");
			listUserDetailSolutionsResponse.PageSize = _ctx.IntegerValue("ListUserDetailSolutions.PageSize");
			listUserDetailSolutionsResponse.RequestId = _ctx.StringValue("ListUserDetailSolutions.RequestId");
			listUserDetailSolutionsResponse.TotalItemNum = _ctx.IntegerValue("ListUserDetailSolutions.TotalItemNum");
			listUserDetailSolutionsResponse.TotalPageNum = _ctx.IntegerValue("ListUserDetailSolutions.TotalPageNum");

			List<ListUserDetailSolutionsResponse.ListUserDetailSolutions_Solution> listUserDetailSolutionsResponse_data = new List<ListUserDetailSolutionsResponse.ListUserDetailSolutions_Solution>();
			for (int i = 0; i < _ctx.Length("ListUserDetailSolutions.Data.Length"); i++) {
				ListUserDetailSolutionsResponse.ListUserDetailSolutions_Solution solution = new ListUserDetailSolutionsResponse.ListUserDetailSolutions_Solution();
				solution.BizId = _ctx.StringValue("ListUserDetailSolutions.Data["+ i +"].BizId");
				solution.BizType = _ctx.StringValue("ListUserDetailSolutions.Data["+ i +"].BizType");
				solution.CreateTime = _ctx.LongValue("ListUserDetailSolutions.Data["+ i +"].CreateTime");
				solution.DeliveryOrderBizId = _ctx.StringValue("ListUserDetailSolutions.Data["+ i +"].DeliveryOrderBizId");
				solution.ExtInfo = _ctx.StringValue("ListUserDetailSolutions.Data["+ i +"].ExtInfo");
				solution.IntentionAssignBizId = _ctx.StringValue("ListUserDetailSolutions.Data["+ i +"].IntentionAssignBizId");
				solution.IntentionBizId = _ctx.StringValue("ListUserDetailSolutions.Data["+ i +"].IntentionBizId");
				solution.PartnerCode = _ctx.StringValue("ListUserDetailSolutions.Data["+ i +"].PartnerCode");
				solution.Reason = _ctx.StringValue("ListUserDetailSolutions.Data["+ i +"].Reason");
				solution.Status = _ctx.IntegerValue("ListUserDetailSolutions.Data["+ i +"].Status");
				solution.UpdateTime = _ctx.LongValue("ListUserDetailSolutions.Data["+ i +"].UpdateTime");
				solution.UserId = _ctx.StringValue("ListUserDetailSolutions.Data["+ i +"].UserId");

				listUserDetailSolutionsResponse_data.Add(solution);
			}
			listUserDetailSolutionsResponse.Data = listUserDetailSolutionsResponse_data;
        
			return listUserDetailSolutionsResponse;
        }
    }
}
