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
    public class ListUserSolutionsResponseUnmarshaller
    {
        public static ListUserSolutionsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListUserSolutionsResponse listUserSolutionsResponse = new ListUserSolutionsResponse();

			listUserSolutionsResponse.HttpResponse = _ctx.HttpResponse;
			listUserSolutionsResponse.RequestId = _ctx.StringValue("ListUserSolutions.RequestId");
			listUserSolutionsResponse.TotalItemNum = _ctx.IntegerValue("ListUserSolutions.TotalItemNum");
			listUserSolutionsResponse.CurrentPageNum = _ctx.IntegerValue("ListUserSolutions.CurrentPageNum");
			listUserSolutionsResponse.PageSize = _ctx.IntegerValue("ListUserSolutions.PageSize");
			listUserSolutionsResponse.TotalPageNum = _ctx.IntegerValue("ListUserSolutions.TotalPageNum");

			List<ListUserSolutionsResponse.ListUserSolutions_Solution> listUserSolutionsResponse_data = new List<ListUserSolutionsResponse.ListUserSolutions_Solution>();
			for (int i = 0; i < _ctx.Length("ListUserSolutions.Data.Length"); i++) {
				ListUserSolutionsResponse.ListUserSolutions_Solution solution = new ListUserSolutionsResponse.ListUserSolutions_Solution();
				solution.BizType = _ctx.StringValue("ListUserSolutions.Data["+ i +"].BizType");
				solution.BizId = _ctx.StringValue("ListUserSolutions.Data["+ i +"].BizId");
				solution.UserId = _ctx.StringValue("ListUserSolutions.Data["+ i +"].UserId");
				solution.IntentionBizId = _ctx.StringValue("ListUserSolutions.Data["+ i +"].IntentionBizId");
				solution.PartnerCode = _ctx.StringValue("ListUserSolutions.Data["+ i +"].PartnerCode");
				solution.Status = _ctx.IntegerValue("ListUserSolutions.Data["+ i +"].Status");
				solution.Reason = _ctx.StringValue("ListUserSolutions.Data["+ i +"].Reason");
				solution.UpdateTime = _ctx.LongValue("ListUserSolutions.Data["+ i +"].UpdateTime");
				solution.CreateTime = _ctx.LongValue("ListUserSolutions.Data["+ i +"].CreateTime");
				solution.DeliveryOrderBizId = _ctx.StringValue("ListUserSolutions.Data["+ i +"].DeliveryOrderBizId");
				solution.IntentionAssignBizId = _ctx.StringValue("ListUserSolutions.Data["+ i +"].IntentionAssignBizId");

				listUserSolutionsResponse_data.Add(solution);
			}
			listUserSolutionsResponse.Data = listUserSolutionsResponse_data;
        
			return listUserSolutionsResponse;
        }
    }
}
