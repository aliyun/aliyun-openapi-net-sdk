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
using Aliyun.Acs.Rds.Model.V20140815;

namespace Aliyun.Acs.Rds.Transform.V20140815
{
    public class DescribeSignedEventActionsResponseUnmarshaller
    {
        public static DescribeSignedEventActionsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeSignedEventActionsResponse describeSignedEventActionsResponse = new DescribeSignedEventActionsResponse();

			describeSignedEventActionsResponse.HttpResponse = context.HttpResponse;
			describeSignedEventActionsResponse.RequestId = context.StringValue("DescribeSignedEventActions.RequestId");
			describeSignedEventActionsResponse.NextPageEventId = context.IntegerValue("DescribeSignedEventActions.NextPageEventId");
			describeSignedEventActionsResponse.PageRecordCount = context.IntegerValue("DescribeSignedEventActions.PageRecordCount");
			describeSignedEventActionsResponse.FromBegin = context.BooleanValue("DescribeSignedEventActions.FromBegin");
			describeSignedEventActionsResponse.ToEnd = context.BooleanValue("DescribeSignedEventActions.ToEnd");

			List<DescribeSignedEventActionsResponse.DescribeSignedEventActions_EventItemsItem> describeSignedEventActionsResponse_eventItems = new List<DescribeSignedEventActionsResponse.DescribeSignedEventActions_EventItemsItem>();
			for (int i = 0; i < context.Length("DescribeSignedEventActions.EventItems.Length"); i++) {
				DescribeSignedEventActionsResponse.DescribeSignedEventActions_EventItemsItem eventItemsItem = new DescribeSignedEventActionsResponse.DescribeSignedEventActions_EventItemsItem();
				eventItemsItem.EventId = context.IntegerValue("DescribeSignedEventActions.EventItems["+ i +"].EventId");
				eventItemsItem.EventContent = context.StringValue("DescribeSignedEventActions.EventItems["+ i +"].EventContent");
				eventItemsItem.EventSig = context.StringValue("DescribeSignedEventActions.EventItems["+ i +"].EventSig");
				eventItemsItem.EventRcpt = context.StringValue("DescribeSignedEventActions.EventItems["+ i +"].EventRcpt");

				describeSignedEventActionsResponse_eventItems.Add(eventItemsItem);
			}
			describeSignedEventActionsResponse.EventItems = describeSignedEventActionsResponse_eventItems;
        
			return describeSignedEventActionsResponse;
        }
    }
}
