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
    public class ListJobExecutionPlanParamsResponseUnmarshaller
    {
        public static ListJobExecutionPlanParamsResponse Unmarshall(UnmarshallerContext context)
        {
			ListJobExecutionPlanParamsResponse listJobExecutionPlanParamsResponse = new ListJobExecutionPlanParamsResponse();

			listJobExecutionPlanParamsResponse.HttpResponse = context.HttpResponse;
			listJobExecutionPlanParamsResponse.RequestId = context.StringValue("ListJobExecutionPlanParams.RequestId");
			listJobExecutionPlanParamsResponse.Success = context.StringValue("ListJobExecutionPlanParams.Success");
			listJobExecutionPlanParamsResponse.ErrCode = context.StringValue("ListJobExecutionPlanParams.ErrCode");
			listJobExecutionPlanParamsResponse.ErrMsg = context.StringValue("ListJobExecutionPlanParams.ErrMsg");

			List<ListJobExecutionPlanParamsResponse.ListJobExecutionPlanParams_ParamInfo> listJobExecutionPlanParamsResponse_paramInfoList = new List<ListJobExecutionPlanParamsResponse.ListJobExecutionPlanParams_ParamInfo>();
			for (int i = 0; i < context.Length("ListJobExecutionPlanParams.ParamInfoList.Length"); i++) {
				ListJobExecutionPlanParamsResponse.ListJobExecutionPlanParams_ParamInfo paramInfo = new ListJobExecutionPlanParamsResponse.ListJobExecutionPlanParams_ParamInfo();
				paramInfo.ParamBizType = context.StringValue("ListJobExecutionPlanParams.ParamInfoList["+ i +"].ParamBizType");
				paramInfo.RelateId = context.StringValue("ListJobExecutionPlanParams.ParamInfoList["+ i +"].RelateId");
				paramInfo.ParamName = context.StringValue("ListJobExecutionPlanParams.ParamInfoList["+ i +"].ParamName");
				paramInfo.ParamValue = context.StringValue("ListJobExecutionPlanParams.ParamInfoList["+ i +"].ParamValue");
				paramInfo.UtcCreateTimestamp = context.LongValue("ListJobExecutionPlanParams.ParamInfoList["+ i +"].UtcCreateTimestamp");
				paramInfo.UtcModifiedTimestamp = context.LongValue("ListJobExecutionPlanParams.ParamInfoList["+ i +"].UtcModifiedTimestamp");

				listJobExecutionPlanParamsResponse_paramInfoList.Add(paramInfo);
			}
			listJobExecutionPlanParamsResponse.ParamInfoList = listJobExecutionPlanParamsResponse_paramInfoList;
        
			return listJobExecutionPlanParamsResponse;
        }
    }
}
