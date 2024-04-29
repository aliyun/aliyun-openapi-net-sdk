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
using Aliyun.Acs.live.Model.V20161101;

namespace Aliyun.Acs.live.Transform.V20161101
{
    public class DescribeLiveRecordNotifyRecordsResponseUnmarshaller
    {
        public static DescribeLiveRecordNotifyRecordsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeLiveRecordNotifyRecordsResponse describeLiveRecordNotifyRecordsResponse = new DescribeLiveRecordNotifyRecordsResponse();

			describeLiveRecordNotifyRecordsResponse.HttpResponse = _ctx.HttpResponse;
			describeLiveRecordNotifyRecordsResponse.Code = _ctx.IntegerValue("DescribeLiveRecordNotifyRecords.Code");
			describeLiveRecordNotifyRecordsResponse.Msg = _ctx.StringValue("DescribeLiveRecordNotifyRecords.Msg");
			describeLiveRecordNotifyRecordsResponse.PageNum = _ctx.IntegerValue("DescribeLiveRecordNotifyRecords.PageNum");
			describeLiveRecordNotifyRecordsResponse.PageSize = _ctx.IntegerValue("DescribeLiveRecordNotifyRecords.PageSize");
			describeLiveRecordNotifyRecordsResponse.RequestId = _ctx.StringValue("DescribeLiveRecordNotifyRecords.RequestId");
			describeLiveRecordNotifyRecordsResponse.TotalNum = _ctx.IntegerValue("DescribeLiveRecordNotifyRecords.TotalNum");
			describeLiveRecordNotifyRecordsResponse.TotalPage = _ctx.IntegerValue("DescribeLiveRecordNotifyRecords.TotalPage");

			List<DescribeLiveRecordNotifyRecordsResponse.DescribeLiveRecordNotifyRecords_Callback> describeLiveRecordNotifyRecordsResponse_callbackList = new List<DescribeLiveRecordNotifyRecordsResponse.DescribeLiveRecordNotifyRecords_Callback>();
			for (int i = 0; i < _ctx.Length("DescribeLiveRecordNotifyRecords.CallbackList.Length"); i++) {
				DescribeLiveRecordNotifyRecordsResponse.DescribeLiveRecordNotifyRecords_Callback callback = new DescribeLiveRecordNotifyRecordsResponse.DescribeLiveRecordNotifyRecords_Callback();
				callback.AppName = _ctx.StringValue("DescribeLiveRecordNotifyRecords.CallbackList["+ i +"].AppName");
				callback.Description = _ctx.StringValue("DescribeLiveRecordNotifyRecords.CallbackList["+ i +"].Description");
				callback.DomainName = _ctx.StringValue("DescribeLiveRecordNotifyRecords.CallbackList["+ i +"].DomainName");
				callback.NotifyContent = _ctx.StringValue("DescribeLiveRecordNotifyRecords.CallbackList["+ i +"].NotifyContent");
				callback.NotifyResult = _ctx.StringValue("DescribeLiveRecordNotifyRecords.CallbackList["+ i +"].NotifyResult");
				callback.NotifyTime = _ctx.StringValue("DescribeLiveRecordNotifyRecords.CallbackList["+ i +"].NotifyTime");
				callback.NotifyType = _ctx.StringValue("DescribeLiveRecordNotifyRecords.CallbackList["+ i +"].NotifyType");
				callback.NotifyUrl = _ctx.StringValue("DescribeLiveRecordNotifyRecords.CallbackList["+ i +"].NotifyUrl");
				callback.StreamName = _ctx.StringValue("DescribeLiveRecordNotifyRecords.CallbackList["+ i +"].StreamName");

				describeLiveRecordNotifyRecordsResponse_callbackList.Add(callback);
			}
			describeLiveRecordNotifyRecordsResponse.CallbackList = describeLiveRecordNotifyRecordsResponse_callbackList;
        
			return describeLiveRecordNotifyRecordsResponse;
        }
    }
}
