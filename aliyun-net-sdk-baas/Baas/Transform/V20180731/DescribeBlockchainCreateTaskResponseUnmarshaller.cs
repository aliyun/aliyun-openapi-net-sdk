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
    public class DescribeBlockchainCreateTaskResponseUnmarshaller
    {
        public static DescribeBlockchainCreateTaskResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeBlockchainCreateTaskResponse describeBlockchainCreateTaskResponse = new DescribeBlockchainCreateTaskResponse();

			describeBlockchainCreateTaskResponse.HttpResponse = context.HttpResponse;
			describeBlockchainCreateTaskResponse.RequestId = context.StringValue("DescribeBlockchainCreateTask.RequestId");

			DescribeBlockchainCreateTaskResponse.DescribeBlockchainCreateTask_Result result = new DescribeBlockchainCreateTaskResponse.DescribeBlockchainCreateTask_Result();

			DescribeBlockchainCreateTaskResponse.DescribeBlockchainCreateTask_Result.DescribeBlockchainCreateTask_Pagination pagination = new DescribeBlockchainCreateTaskResponse.DescribeBlockchainCreateTask_Result.DescribeBlockchainCreateTask_Pagination();
			pagination.PageSize = context.IntegerValue("DescribeBlockchainCreateTask.Result.Pagination.PageSize");
			pagination.Current = context.IntegerValue("DescribeBlockchainCreateTask.Result.Pagination.Current");
			pagination.Total = context.IntegerValue("DescribeBlockchainCreateTask.Result.Pagination.Total");
			result.Pagination = pagination;

			List<DescribeBlockchainCreateTaskResponse.DescribeBlockchainCreateTask_Result.DescribeBlockchainCreateTask_BlockchainCreateTasksItem> result_blockchainCreateTasks = new List<DescribeBlockchainCreateTaskResponse.DescribeBlockchainCreateTask_Result.DescribeBlockchainCreateTask_BlockchainCreateTasksItem>();
			for (int i = 0; i < context.Length("DescribeBlockchainCreateTask.Result.BlockchainCreateTasks.Length"); i++) {
				DescribeBlockchainCreateTaskResponse.DescribeBlockchainCreateTask_Result.DescribeBlockchainCreateTask_BlockchainCreateTasksItem blockchainCreateTasksItem = new DescribeBlockchainCreateTaskResponse.DescribeBlockchainCreateTask_Result.DescribeBlockchainCreateTask_BlockchainCreateTasksItem();
				blockchainCreateTasksItem.Bizid = context.StringValue("DescribeBlockchainCreateTask.Result.BlockchainCreateTasks["+ i +"].Bizid");
				blockchainCreateTasksItem.Name = context.StringValue("DescribeBlockchainCreateTask.Result.BlockchainCreateTasks["+ i +"].Name");
				blockchainCreateTasksItem.Status = context.StringValue("DescribeBlockchainCreateTask.Result.BlockchainCreateTasks["+ i +"].Status");
				blockchainCreateTasksItem.Memo = context.StringValue("DescribeBlockchainCreateTask.Result.BlockchainCreateTasks["+ i +"].Memo");
				blockchainCreateTasksItem.CreateTime = context.LongValue("DescribeBlockchainCreateTask.Result.BlockchainCreateTasks["+ i +"].CreateTime");

				result_blockchainCreateTasks.Add(blockchainCreateTasksItem);
			}
			result.BlockchainCreateTasks = result_blockchainCreateTasks;
			describeBlockchainCreateTaskResponse.Result = result;
        
			return describeBlockchainCreateTaskResponse;
        }
    }
}