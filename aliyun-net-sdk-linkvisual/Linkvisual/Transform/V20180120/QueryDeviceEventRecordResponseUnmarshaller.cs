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
using Aliyun.Acs.Linkvisual.Model.V20180120;

namespace Aliyun.Acs.Linkvisual.Transform.V20180120
{
    public class QueryDeviceEventRecordResponseUnmarshaller
    {
        public static QueryDeviceEventRecordResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryDeviceEventRecordResponse queryDeviceEventRecordResponse = new QueryDeviceEventRecordResponse();

			queryDeviceEventRecordResponse.HttpResponse = _ctx.HttpResponse;
			queryDeviceEventRecordResponse.Code = _ctx.IntegerValue("QueryDeviceEventRecord.Code");
			queryDeviceEventRecordResponse.RequestId = _ctx.StringValue("QueryDeviceEventRecord.RequestId");
			queryDeviceEventRecordResponse.ErrorMessage = _ctx.StringValue("QueryDeviceEventRecord.ErrorMessage");
			queryDeviceEventRecordResponse.Success = _ctx.BooleanValue("QueryDeviceEventRecord.Success");

			List<QueryDeviceEventRecordResponse.QueryDeviceEventRecord_VodInfo> queryDeviceEventRecordResponse_data = new List<QueryDeviceEventRecordResponse.QueryDeviceEventRecord_VodInfo>();
			for (int i = 0; i < _ctx.Length("QueryDeviceEventRecord.Data.Length"); i++) {
				QueryDeviceEventRecordResponse.QueryDeviceEventRecord_VodInfo vodInfo = new QueryDeviceEventRecordResponse.QueryDeviceEventRecord_VodInfo();
				vodInfo.EndTime = _ctx.StringValue("QueryDeviceEventRecord.Data["+ i +"].EndTime");
				vodInfo.FileName = _ctx.StringValue("QueryDeviceEventRecord.Data["+ i +"].FileName");
				vodInfo.VodUrl = _ctx.StringValue("QueryDeviceEventRecord.Data["+ i +"].VodUrl");
				vodInfo.BeginTime = _ctx.StringValue("QueryDeviceEventRecord.Data["+ i +"].BeginTime");

				queryDeviceEventRecordResponse_data.Add(vodInfo);
			}
			queryDeviceEventRecordResponse.Data = queryDeviceEventRecordResponse_data;
        
			return queryDeviceEventRecordResponse;
        }
    }
}
