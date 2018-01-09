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
using Aliyun.Acs.cloudwf.Model.V20170328;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.cloudwf.Transform.V20170328
{
    public class GetRadioRunHistoryTimeSerResponseUnmarshaller
    {
        public static GetRadioRunHistoryTimeSerResponse Unmarshall(UnmarshallerContext context)
        {
			GetRadioRunHistoryTimeSerResponse getRadioRunHistoryTimeSerResponse = new GetRadioRunHistoryTimeSerResponse();

			getRadioRunHistoryTimeSerResponse.HttpResponse = context.HttpResponse;
			getRadioRunHistoryTimeSerResponse.RequestId = context.StringValue("GetRadioRunHistoryTimeSer.RequestId");
			getRadioRunHistoryTimeSerResponse.Success = context.BooleanValue("GetRadioRunHistoryTimeSer.Success");
			getRadioRunHistoryTimeSerResponse.Message = context.StringValue("GetRadioRunHistoryTimeSer.Message");
			getRadioRunHistoryTimeSerResponse.Data = context.StringValue("GetRadioRunHistoryTimeSer.Data");
			getRadioRunHistoryTimeSerResponse.ErrorCode = context.IntegerValue("GetRadioRunHistoryTimeSer.ErrorCode");
			getRadioRunHistoryTimeSerResponse.ErrorMsg = context.StringValue("GetRadioRunHistoryTimeSer.ErrorMsg");
        
			return getRadioRunHistoryTimeSerResponse;
        }
    }
}