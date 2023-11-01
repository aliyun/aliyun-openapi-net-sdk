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
    public class DescribeAlertSourceWithEventResponseUnmarshaller
    {
        public static DescribeAlertSourceWithEventResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeAlertSourceWithEventResponse describeAlertSourceWithEventResponse = new DescribeAlertSourceWithEventResponse();

			describeAlertSourceWithEventResponse.HttpResponse = _ctx.HttpResponse;
			describeAlertSourceWithEventResponse.Success = _ctx.BooleanValue("DescribeAlertSourceWithEvent.Success");
			describeAlertSourceWithEventResponse.Code = _ctx.IntegerValue("DescribeAlertSourceWithEvent.Code");
			describeAlertSourceWithEventResponse.Message = _ctx.StringValue("DescribeAlertSourceWithEvent.Message");
			describeAlertSourceWithEventResponse.RequestId = _ctx.StringValue("DescribeAlertSourceWithEvent.RequestId");

			List<DescribeAlertSourceWithEventResponse.DescribeAlertSourceWithEvent_DataItem> describeAlertSourceWithEventResponse_data = new List<DescribeAlertSourceWithEventResponse.DescribeAlertSourceWithEvent_DataItem>();
			for (int i = 0; i < _ctx.Length("DescribeAlertSourceWithEvent.Data.Length"); i++) {
				DescribeAlertSourceWithEventResponse.DescribeAlertSourceWithEvent_DataItem dataItem = new DescribeAlertSourceWithEventResponse.DescribeAlertSourceWithEvent_DataItem();
				dataItem.SourceName = _ctx.StringValue("DescribeAlertSourceWithEvent.Data["+ i +"].SourceName");
				dataItem.Source = _ctx.StringValue("DescribeAlertSourceWithEvent.Data["+ i +"].Source");

				describeAlertSourceWithEventResponse_data.Add(dataItem);
			}
			describeAlertSourceWithEventResponse.Data = describeAlertSourceWithEventResponse_data;
        
			return describeAlertSourceWithEventResponse;
        }
    }
}
