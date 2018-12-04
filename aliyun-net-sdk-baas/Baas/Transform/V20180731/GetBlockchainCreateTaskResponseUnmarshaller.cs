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
using Aliyun.Acs.Baas.Model.V20180731;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Baas.Transform.V20180731
{
    public class GetBlockchainCreateTaskResponseUnmarshaller
    {
        public static GetBlockchainCreateTaskResponse Unmarshall(UnmarshallerContext context)
        {
			GetBlockchainCreateTaskResponse getBlockchainCreateTaskResponse = new GetBlockchainCreateTaskResponse();

			getBlockchainCreateTaskResponse.HttpResponse = context.HttpResponse;
			getBlockchainCreateTaskResponse.RequestId = context.StringValue("GetBlockchainCreateTask.RequestId");

			GetBlockchainCreateTaskResponse.GetBlockchainCreateTask_Result result = new GetBlockchainCreateTaskResponse.GetBlockchainCreateTask_Result();

			GetBlockchainCreateTaskResponse.GetBlockchainCreateTask_Result.GetBlockchainCreateTask_Pagination pagination = new GetBlockchainCreateTaskResponse.GetBlockchainCreateTask_Result.GetBlockchainCreateTask_Pagination();
			pagination.PageSize = context.IntegerValue("GetBlockchainCreateTask.Result.Pagination.PageSize");
			pagination.Current = context.IntegerValue("GetBlockchainCreateTask.Result.Pagination.Current");
			pagination.Total = context.IntegerValue("GetBlockchainCreateTask.Result.Pagination.Total");
			result.Pagination = pagination;

			List<GetBlockchainCreateTaskResponse.GetBlockchainCreateTask_Result.GetBlockchainCreateTask_BlockchainCreateTasksItem> result_blockchainCreateTasks = new List<GetBlockchainCreateTaskResponse.GetBlockchainCreateTask_Result.GetBlockchainCreateTask_BlockchainCreateTasksItem>();
			for (int i = 0; i < context.Length("GetBlockchainCreateTask.Result.BlockchainCreateTasks.Length"); i++) {
				GetBlockchainCreateTaskResponse.GetBlockchainCreateTask_Result.GetBlockchainCreateTask_BlockchainCreateTasksItem blockchainCreateTasksItem = new GetBlockchainCreateTaskResponse.GetBlockchainCreateTask_Result.GetBlockchainCreateTask_BlockchainCreateTasksItem();
				blockchainCreateTasksItem.Bizid = context.StringValue("GetBlockchainCreateTask.Result.BlockchainCreateTasks["+ i +"].Bizid");
				blockchainCreateTasksItem.Name = context.StringValue("GetBlockchainCreateTask.Result.BlockchainCreateTasks["+ i +"].Name");
				blockchainCreateTasksItem.Status = context.StringValue("GetBlockchainCreateTask.Result.BlockchainCreateTasks["+ i +"].Status");
				blockchainCreateTasksItem.Memo = context.StringValue("GetBlockchainCreateTask.Result.BlockchainCreateTasks["+ i +"].Memo");
				blockchainCreateTasksItem.CreateTime = context.LongValue("GetBlockchainCreateTask.Result.BlockchainCreateTasks["+ i +"].CreateTime");

				result_blockchainCreateTasks.Add(blockchainCreateTasksItem);
			}
			result.BlockchainCreateTasks = result_blockchainCreateTasks;
			getBlockchainCreateTaskResponse.Result = result;
        
			return getBlockchainCreateTaskResponse;
        }
    }
}