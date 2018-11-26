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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.dms_enterprise.Model.V20181101;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.dms_enterprise.Transform.V20181101
{
    public class GetOpLogResponseUnmarshaller
    {
        public static GetOpLogResponse Unmarshall(UnmarshallerContext context)
        {
			GetOpLogResponse getOpLogResponse = new GetOpLogResponse();

			getOpLogResponse.HttpResponse = context.HttpResponse;
			getOpLogResponse.RequestId = context.StringValue("GetOpLog.RequestId");
			getOpLogResponse.Success = context.BooleanValue("GetOpLog.Success");
			getOpLogResponse.ErrorMessage = context.StringValue("GetOpLog.ErrorMessage");
			getOpLogResponse.ErrorCode = context.StringValue("GetOpLog.ErrorCode");
			getOpLogResponse.TotalCount = context.LongValue("GetOpLog.TotalCount");

			List<GetOpLogResponse.GetOpLog_OpLogDetail> getOpLogResponse_opLogDetails = new List<GetOpLogResponse.GetOpLog_OpLogDetail>();
			for (int i = 0; i < context.Length("GetOpLog.OpLogDetails.Length"); i++) {
				GetOpLogResponse.GetOpLog_OpLogDetail opLogDetail = new GetOpLogResponse.GetOpLog_OpLogDetail();
				opLogDetail.UserId = context.LongValue("GetOpLog.OpLogDetails["+ i +"].UserId");
				opLogDetail.UserNick = context.StringValue("GetOpLog.OpLogDetails["+ i +"].UserNick");
				opLogDetail.Module = context.StringValue("GetOpLog.OpLogDetails["+ i +"].Module");
				opLogDetail.OpContent = context.StringValue("GetOpLog.OpLogDetails["+ i +"].OpContent");
				opLogDetail.OpTime = context.StringValue("GetOpLog.OpLogDetails["+ i +"].OpTime");
				opLogDetail.Database = context.StringValue("GetOpLog.OpLogDetails["+ i +"].Database");
				opLogDetail.OrderId = context.LongValue("GetOpLog.OpLogDetails["+ i +"].OrderId");

				getOpLogResponse_opLogDetails.Add(opLogDetail);
			}
			getOpLogResponse.OpLogDetails = getOpLogResponse_opLogDetails;
        
			return getOpLogResponse;
        }
    }
}