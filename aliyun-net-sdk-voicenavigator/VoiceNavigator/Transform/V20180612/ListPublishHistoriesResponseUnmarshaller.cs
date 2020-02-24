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
using Aliyun.Acs.VoiceNavigator.Model.V20180612;

namespace Aliyun.Acs.VoiceNavigator.Transform.V20180612
{
    public class ListPublishHistoriesResponseUnmarshaller
    {
        public static ListPublishHistoriesResponse Unmarshall(UnmarshallerContext context)
        {
			ListPublishHistoriesResponse listPublishHistoriesResponse = new ListPublishHistoriesResponse();

			listPublishHistoriesResponse.HttpResponse = context.HttpResponse;
			listPublishHistoriesResponse.RequestId = context.StringValue("ListPublishHistories.RequestId");
			listPublishHistoriesResponse.TotalCount = context.IntegerValue("ListPublishHistories.TotalCount");
			listPublishHistoriesResponse.PageNumber = context.IntegerValue("ListPublishHistories.PageNumber");
			listPublishHistoriesResponse.PageSize = context.IntegerValue("ListPublishHistories.PageSize");

			List<ListPublishHistoriesResponse.ListPublishHistories_PublishHistoriesItem> listPublishHistoriesResponse_publishHistories = new List<ListPublishHistoriesResponse.ListPublishHistories_PublishHistoriesItem>();
			for (int i = 0; i < context.Length("ListPublishHistories.PublishHistories.Length"); i++) {
				ListPublishHistoriesResponse.ListPublishHistories_PublishHistoriesItem publishHistoriesItem = new ListPublishHistoriesResponse.ListPublishHistories_PublishHistoriesItem();
				publishHistoriesItem.InstanceId = context.StringValue("ListPublishHistories.PublishHistories["+ i +"].InstanceId");
				publishHistoriesItem.Version = context.StringValue("ListPublishHistories.PublishHistories["+ i +"].Version");
				publishHistoriesItem.PublishUserName = context.StringValue("ListPublishHistories.PublishHistories["+ i +"].PublishUserName");
				publishHistoriesItem.PublishTime = context.LongValue("ListPublishHistories.PublishHistories["+ i +"].PublishTime");
				publishHistoriesItem.IsRollbackApplicable = context.BooleanValue("ListPublishHistories.PublishHistories["+ i +"].IsRollbackApplicable");

				listPublishHistoriesResponse_publishHistories.Add(publishHistoriesItem);
			}
			listPublishHistoriesResponse.PublishHistories = listPublishHistoriesResponse_publishHistories;
        
			return listPublishHistoriesResponse;
        }
    }
}
