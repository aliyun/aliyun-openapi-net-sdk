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
    public class ListOpsOperationResponseUnmarshaller
    {
        public static ListOpsOperationResponse Unmarshall(UnmarshallerContext context)
        {
			ListOpsOperationResponse listOpsOperationResponse = new ListOpsOperationResponse();

			listOpsOperationResponse.HttpResponse = context.HttpResponse;
			listOpsOperationResponse.RequestId = context.StringValue("ListOpsOperation.RequestId");
			listOpsOperationResponse.Total = context.IntegerValue("ListOpsOperation.Total");
			listOpsOperationResponse.PageNumber = context.IntegerValue("ListOpsOperation.PageNumber");
			listOpsOperationResponse.PageSize = context.IntegerValue("ListOpsOperation.PageSize");

			List<ListOpsOperationResponse.ListOpsOperation_OpsOperationListItem> listOpsOperationResponse_opsOperationList = new List<ListOpsOperationResponse.ListOpsOperation_OpsOperationListItem>();
			for (int i = 0; i < context.Length("ListOpsOperation.OpsOperationList.Length"); i++) {
				ListOpsOperationResponse.ListOpsOperation_OpsOperationListItem opsOperationListItem = new ListOpsOperationResponse.ListOpsOperation_OpsOperationListItem();
				opsOperationListItem.Id = context.LongValue("ListOpsOperation.OpsOperationList["+ i +"].Id");
				opsOperationListItem.StartTime = context.StringValue("ListOpsOperation.OpsOperationList["+ i +"].StartTime");
				opsOperationListItem.EndTime = context.StringValue("ListOpsOperation.OpsOperationList["+ i +"].EndTime");
				opsOperationListItem.OpsCommandId = context.LongValue("ListOpsOperation.OpsOperationList["+ i +"].OpsCommandId");
				opsOperationListItem.OpsCommandName = context.StringValue("ListOpsOperation.OpsOperationList["+ i +"].OpsCommandName");
				opsOperationListItem.Status = context.StringValue("ListOpsOperation.OpsOperationList["+ i +"].Status");
				opsOperationListItem.TotalTaskNum = context.LongValue("ListOpsOperation.OpsOperationList["+ i +"].TotalTaskNum");
				opsOperationListItem.FailedTaskNum = context.LongValue("ListOpsOperation.OpsOperationList["+ i +"].FailedTaskNum");
				opsOperationListItem.FinishedTaskNum = context.LongValue("ListOpsOperation.OpsOperationList["+ i +"].FinishedTaskNum");
				opsOperationListItem.ClusterId = context.StringValue("ListOpsOperation.OpsOperationList["+ i +"].ClusterId");
				opsOperationListItem.RegionId = context.StringValue("ListOpsOperation.OpsOperationList["+ i +"].RegionId");
				opsOperationListItem._Params = context.StringValue("ListOpsOperation.OpsOperationList["+ i +"].Params");
				opsOperationListItem.Remark = context.StringValue("ListOpsOperation.OpsOperationList["+ i +"].Remark");
				opsOperationListItem.RunningTime = context.LongValue("ListOpsOperation.OpsOperationList["+ i +"].RunningTime");
				opsOperationListItem.Category = context.StringValue("ListOpsOperation.OpsOperationList["+ i +"].Category");

				listOpsOperationResponse_opsOperationList.Add(opsOperationListItem);
			}
			listOpsOperationResponse.OpsOperationList = listOpsOperationResponse_opsOperationList;
        
			return listOpsOperationResponse;
        }
    }
}
