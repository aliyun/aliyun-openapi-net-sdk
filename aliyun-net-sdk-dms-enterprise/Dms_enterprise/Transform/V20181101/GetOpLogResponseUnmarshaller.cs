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
    public class GetOpLogResponseUnmarshaller
    {
        public static GetOpLogResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetOpLogResponse getOpLogResponse = new GetOpLogResponse();

			getOpLogResponse.HttpResponse = _ctx.HttpResponse;
			getOpLogResponse.TotalCount = _ctx.LongValue("GetOpLog.TotalCount");
			getOpLogResponse.RequestId = _ctx.StringValue("GetOpLog.RequestId");
			getOpLogResponse.ErrorCode = _ctx.StringValue("GetOpLog.ErrorCode");
			getOpLogResponse.ErrorMessage = _ctx.StringValue("GetOpLog.ErrorMessage");
			getOpLogResponse.Success = _ctx.BooleanValue("GetOpLog.Success");

			List<GetOpLogResponse.GetOpLog_OpLogDetail> getOpLogResponse_opLogDetails = new List<GetOpLogResponse.GetOpLog_OpLogDetail>();
			for (int i = 0; i < _ctx.Length("GetOpLog.OpLogDetails.Length"); i++) {
				GetOpLogResponse.GetOpLog_OpLogDetail opLogDetail = new GetOpLogResponse.GetOpLog_OpLogDetail();
				opLogDetail.Module = _ctx.StringValue("GetOpLog.OpLogDetails["+ i +"].Module");
				opLogDetail.Database = _ctx.StringValue("GetOpLog.OpLogDetails["+ i +"].Database");
				opLogDetail.UserId = _ctx.LongValue("GetOpLog.OpLogDetails["+ i +"].UserId");
				opLogDetail.OpContent = _ctx.StringValue("GetOpLog.OpLogDetails["+ i +"].OpContent");
				opLogDetail.UserNick = _ctx.StringValue("GetOpLog.OpLogDetails["+ i +"].UserNick");
				opLogDetail.OrderId = _ctx.LongValue("GetOpLog.OpLogDetails["+ i +"].OrderId");
				opLogDetail.OpTime = _ctx.StringValue("GetOpLog.OpLogDetails["+ i +"].OpTime");

				getOpLogResponse_opLogDetails.Add(opLogDetail);
			}
			getOpLogResponse.OpLogDetails = getOpLogResponse_opLogDetails;
        
			return getOpLogResponse;
        }
    }
}
