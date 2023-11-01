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
using Aliyun.Acs.cloud_siem.Model.V20220616;

namespace Aliyun.Acs.cloud_siem.Transform.V20220616
{
    public class DescribeEventDisposeResponseUnmarshaller
    {
        public static DescribeEventDisposeResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeEventDisposeResponse describeEventDisposeResponse = new DescribeEventDisposeResponse();

			describeEventDisposeResponse.HttpResponse = _ctx.HttpResponse;
			describeEventDisposeResponse.Success = _ctx.BooleanValue("DescribeEventDispose.Success");
			describeEventDisposeResponse.Code = _ctx.IntegerValue("DescribeEventDispose.Code");
			describeEventDisposeResponse.Message = _ctx.StringValue("DescribeEventDispose.Message");
			describeEventDisposeResponse.RequestId = _ctx.StringValue("DescribeEventDispose.RequestId");

			DescribeEventDisposeResponse.DescribeEventDispose_Data data = new DescribeEventDisposeResponse.DescribeEventDispose_Data();
			data.Status = _ctx.IntegerValue("DescribeEventDispose.Data.Status");
			data.Remark = _ctx.StringValue("DescribeEventDispose.Data.Remark");

			List<string> data_eventDispose = new List<string>();
			for (int i = 0; i < _ctx.Length("DescribeEventDispose.Data.EventDispose.Length"); i++) {
				data_eventDispose.Add(_ctx.StringValue("DescribeEventDispose.Data.EventDispose["+ i +"]"));
			}
			data.EventDispose = data_eventDispose;

			DescribeEventDisposeResponse.DescribeEventDispose_Data.DescribeEventDispose_ReceiverInfo receiverInfo = new DescribeEventDisposeResponse.DescribeEventDispose_Data.DescribeEventDispose_ReceiverInfo();
			receiverInfo.Id = _ctx.LongValue("DescribeEventDispose.Data.ReceiverInfo.Id");
			receiverInfo.GmtCreate = _ctx.StringValue("DescribeEventDispose.Data.ReceiverInfo.GmtCreate");
			receiverInfo.GmtModified = _ctx.StringValue("DescribeEventDispose.Data.ReceiverInfo.GmtModified");
			receiverInfo.IncidentUuid = _ctx.StringValue("DescribeEventDispose.Data.ReceiverInfo.IncidentUuid");
			receiverInfo.MessageTitle = _ctx.StringValue("DescribeEventDispose.Data.ReceiverInfo.MessageTitle");
			receiverInfo.Receiver = _ctx.StringValue("DescribeEventDispose.Data.ReceiverInfo.Receiver");
			receiverInfo.Channel = _ctx.StringValue("DescribeEventDispose.Data.ReceiverInfo.Channel");
			receiverInfo.Status = _ctx.IntegerValue("DescribeEventDispose.Data.ReceiverInfo.Status");
			data.ReceiverInfo = receiverInfo;
			describeEventDisposeResponse.Data = data;
        
			return describeEventDisposeResponse;
        }
    }
}
