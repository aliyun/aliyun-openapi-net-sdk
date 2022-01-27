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
    public class ListUserProduceOperateLogsResponseUnmarshaller
    {
        public static ListUserProduceOperateLogsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListUserProduceOperateLogsResponse listUserProduceOperateLogsResponse = new ListUserProduceOperateLogsResponse();

			listUserProduceOperateLogsResponse.HttpResponse = _ctx.HttpResponse;
			listUserProduceOperateLogsResponse.PageNum = _ctx.IntegerValue("ListUserProduceOperateLogs.PageNum");
			listUserProduceOperateLogsResponse.PageSize = _ctx.IntegerValue("ListUserProduceOperateLogs.PageSize");
			listUserProduceOperateLogsResponse.RequestId = _ctx.StringValue("ListUserProduceOperateLogs.RequestId");
			listUserProduceOperateLogsResponse.Success = _ctx.BooleanValue("ListUserProduceOperateLogs.Success");
			listUserProduceOperateLogsResponse.TotalItemNum = _ctx.IntegerValue("ListUserProduceOperateLogs.TotalItemNum");
			listUserProduceOperateLogsResponse.TotalPageNum = _ctx.IntegerValue("ListUserProduceOperateLogs.TotalPageNum");

			List<ListUserProduceOperateLogsResponse.ListUserProduceOperateLogs_OpateLogs> listUserProduceOperateLogsResponse_data = new List<ListUserProduceOperateLogsResponse.ListUserProduceOperateLogs_OpateLogs>();
			for (int i = 0; i < _ctx.Length("ListUserProduceOperateLogs.Data.Length"); i++) {
				ListUserProduceOperateLogsResponse.ListUserProduceOperateLogs_OpateLogs opateLogs = new ListUserProduceOperateLogsResponse.ListUserProduceOperateLogs_OpateLogs();
				opateLogs.BizId = _ctx.StringValue("ListUserProduceOperateLogs.Data["+ i +"].BizId");
				opateLogs.BizType = _ctx.StringValue("ListUserProduceOperateLogs.Data["+ i +"].BizType");
				opateLogs.OperateName = _ctx.StringValue("ListUserProduceOperateLogs.Data["+ i +"].OperateName");
				opateLogs.OperateTime = _ctx.LongValue("ListUserProduceOperateLogs.Data["+ i +"].OperateTime");
				opateLogs.OperateUserType = _ctx.StringValue("ListUserProduceOperateLogs.Data["+ i +"].OperateUserType");
				opateLogs.BizStatus = _ctx.IntegerValue("ListUserProduceOperateLogs.Data["+ i +"].BizStatus");
				opateLogs.ToBizStatus = _ctx.IntegerValue("ListUserProduceOperateLogs.Data["+ i +"].ToBizStatus");

				listUserProduceOperateLogsResponse_data.Add(opateLogs);
			}
			listUserProduceOperateLogsResponse.Data = listUserProduceOperateLogsResponse_data;
        
			return listUserProduceOperateLogsResponse;
        }
    }
}
