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
    public class ListResourcePoolResponseUnmarshaller
    {
        public static ListResourcePoolResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListResourcePoolResponse listResourcePoolResponse = new ListResourcePoolResponse();

			listResourcePoolResponse.HttpResponse = _ctx.HttpResponse;
			listResourcePoolResponse.RequestId = _ctx.StringValue("ListResourcePool.RequestId");
			listResourcePoolResponse.PageNumber = _ctx.IntegerValue("ListResourcePool.PageNumber");
			listResourcePoolResponse.PageSize = _ctx.IntegerValue("ListResourcePool.PageSize");
			listResourcePoolResponse.Total = _ctx.IntegerValue("ListResourcePool.Total");

			List<ListResourcePoolResponse.ListResourcePool_PoolInfo> listResourcePoolResponse_poolInfoList = new List<ListResourcePoolResponse.ListResourcePool_PoolInfo>();
			for (int i = 0; i < _ctx.Length("ListResourcePool.PoolInfoList.Length"); i++) {
				ListResourcePoolResponse.ListResourcePool_PoolInfo poolInfo = new ListResourcePoolResponse.ListResourcePool_PoolInfo();

				ListResourcePoolResponse.ListResourcePool_PoolInfo.ListResourcePool_EcmResourcePool ecmResourcePool = new ListResourcePoolResponse.ListResourcePool_PoolInfo.ListResourcePool_EcmResourcePool();
				ecmResourcePool.Id = _ctx.LongValue("ListResourcePool.PoolInfoList["+ i +"].EcmResourcePool.Id");
				ecmResourcePool.Name = _ctx.StringValue("ListResourcePool.PoolInfoList["+ i +"].EcmResourcePool.Name");
				ecmResourcePool.PoolType = _ctx.StringValue("ListResourcePool.PoolInfoList["+ i +"].EcmResourcePool.PoolType");
				ecmResourcePool.Active = _ctx.BooleanValue("ListResourcePool.PoolInfoList["+ i +"].EcmResourcePool.Active");
				ecmResourcePool.Note = _ctx.StringValue("ListResourcePool.PoolInfoList["+ i +"].EcmResourcePool.Note");
				ecmResourcePool.UserId = _ctx.StringValue("ListResourcePool.PoolInfoList["+ i +"].EcmResourcePool.UserId");
				ecmResourcePool.YarnSiteConfig = _ctx.StringValue("ListResourcePool.PoolInfoList["+ i +"].EcmResourcePool.YarnSiteConfig");
				poolInfo.EcmResourcePool = ecmResourcePool;

				List<ListResourcePoolResponse.ListResourcePool_PoolInfo.ListResourcePool_Queue> poolInfo_queueList = new List<ListResourcePoolResponse.ListResourcePool_PoolInfo.ListResourcePool_Queue>();
				for (int j = 0; j < _ctx.Length("ListResourcePool.PoolInfoList["+ i +"].QueueList.Length"); j++) {
					ListResourcePoolResponse.ListResourcePool_PoolInfo.ListResourcePool_Queue queue = new ListResourcePoolResponse.ListResourcePool_PoolInfo.ListResourcePool_Queue();

					ListResourcePoolResponse.ListResourcePool_PoolInfo.ListResourcePool_Queue.ListResourcePool_EcmResourceQueue ecmResourceQueue = new ListResourcePoolResponse.ListResourcePool_PoolInfo.ListResourcePool_Queue.ListResourcePool_EcmResourceQueue();
					ecmResourceQueue.Id = _ctx.LongValue("ListResourcePool.PoolInfoList["+ i +"].QueueList["+ j +"].EcmResourceQueue.Id");
					ecmResourceQueue.Name = _ctx.StringValue("ListResourcePool.PoolInfoList["+ i +"].QueueList["+ j +"].EcmResourceQueue.Name");
					ecmResourceQueue.QualifiedName = _ctx.StringValue("ListResourcePool.PoolInfoList["+ i +"].QueueList["+ j +"].EcmResourceQueue.QualifiedName");
					ecmResourceQueue.QueueType = _ctx.StringValue("ListResourcePool.PoolInfoList["+ i +"].QueueList["+ j +"].EcmResourceQueue.QueueType");
					ecmResourceQueue.ParentQueueId = _ctx.LongValue("ListResourcePool.PoolInfoList["+ i +"].QueueList["+ j +"].EcmResourceQueue.ParentQueueId");
					ecmResourceQueue.Leaf = _ctx.BooleanValue("ListResourcePool.PoolInfoList["+ i +"].QueueList["+ j +"].EcmResourceQueue.Leaf");
					ecmResourceQueue.Status = _ctx.StringValue("ListResourcePool.PoolInfoList["+ i +"].QueueList["+ j +"].EcmResourceQueue.Status");
					ecmResourceQueue.UserId = _ctx.StringValue("ListResourcePool.PoolInfoList["+ i +"].QueueList["+ j +"].EcmResourceQueue.UserId");
					ecmResourceQueue.ResourcePoolId = _ctx.LongValue("ListResourcePool.PoolInfoList["+ i +"].QueueList["+ j +"].EcmResourceQueue.ResourcePoolId");
					queue.EcmResourceQueue = ecmResourceQueue;

					List<ListResourcePoolResponse.ListResourcePool_PoolInfo.ListResourcePool_Queue.ListResourcePool_EcmResourcePoolConfig> queue_ecmResourcePoolConfigList1 = new List<ListResourcePoolResponse.ListResourcePool_PoolInfo.ListResourcePool_Queue.ListResourcePool_EcmResourcePoolConfig>();
					for (int k = 0; k < _ctx.Length("ListResourcePool.PoolInfoList["+ i +"].QueueList["+ j +"].EcmResourcePoolConfigList.Length"); k++) {
						ListResourcePoolResponse.ListResourcePool_PoolInfo.ListResourcePool_Queue.ListResourcePool_EcmResourcePoolConfig ecmResourcePoolConfig = new ListResourcePoolResponse.ListResourcePool_PoolInfo.ListResourcePool_Queue.ListResourcePool_EcmResourcePoolConfig();
						ecmResourcePoolConfig.Id = _ctx.LongValue("ListResourcePool.PoolInfoList["+ i +"].QueueList["+ j +"].EcmResourcePoolConfigList["+ k +"].Id");
						ecmResourcePoolConfig.ConfigKey = _ctx.StringValue("ListResourcePool.PoolInfoList["+ i +"].QueueList["+ j +"].EcmResourcePoolConfigList["+ k +"].ConfigKey");
						ecmResourcePoolConfig.ConfigValue = _ctx.StringValue("ListResourcePool.PoolInfoList["+ i +"].QueueList["+ j +"].EcmResourcePoolConfigList["+ k +"].ConfigValue");
						ecmResourcePoolConfig.ConfigType = _ctx.StringValue("ListResourcePool.PoolInfoList["+ i +"].QueueList["+ j +"].EcmResourcePoolConfigList["+ k +"].ConfigType");
						ecmResourcePoolConfig.Category = _ctx.StringValue("ListResourcePool.PoolInfoList["+ i +"].QueueList["+ j +"].EcmResourcePoolConfigList["+ k +"].Category");
						ecmResourcePoolConfig.Status = _ctx.StringValue("ListResourcePool.PoolInfoList["+ i +"].QueueList["+ j +"].EcmResourcePoolConfigList["+ k +"].Status");
						ecmResourcePoolConfig.Note = _ctx.StringValue("ListResourcePool.PoolInfoList["+ i +"].QueueList["+ j +"].EcmResourcePoolConfigList["+ k +"].Note");

						queue_ecmResourcePoolConfigList1.Add(ecmResourcePoolConfig);
					}
					queue.EcmResourcePoolConfigList1 = queue_ecmResourcePoolConfigList1;

					poolInfo_queueList.Add(queue);
				}
				poolInfo.QueueList = poolInfo_queueList;

				List<ListResourcePoolResponse.ListResourcePool_PoolInfo.ListResourcePool_EcmResourcePoolConfig2> poolInfo_ecmResourcePoolConfigList = new List<ListResourcePoolResponse.ListResourcePool_PoolInfo.ListResourcePool_EcmResourcePoolConfig2>();
				for (int j = 0; j < _ctx.Length("ListResourcePool.PoolInfoList["+ i +"].EcmResourcePoolConfigList.Length"); j++) {
					ListResourcePoolResponse.ListResourcePool_PoolInfo.ListResourcePool_EcmResourcePoolConfig2 ecmResourcePoolConfig2 = new ListResourcePoolResponse.ListResourcePool_PoolInfo.ListResourcePool_EcmResourcePoolConfig2();
					ecmResourcePoolConfig2.Id = _ctx.LongValue("ListResourcePool.PoolInfoList["+ i +"].EcmResourcePoolConfigList["+ j +"].Id");
					ecmResourcePoolConfig2.ConfigKey = _ctx.StringValue("ListResourcePool.PoolInfoList["+ i +"].EcmResourcePoolConfigList["+ j +"].ConfigKey");
					ecmResourcePoolConfig2.ConfigValue = _ctx.StringValue("ListResourcePool.PoolInfoList["+ i +"].EcmResourcePoolConfigList["+ j +"].ConfigValue");
					ecmResourcePoolConfig2.ConfigType = _ctx.StringValue("ListResourcePool.PoolInfoList["+ i +"].EcmResourcePoolConfigList["+ j +"].ConfigType");
					ecmResourcePoolConfig2.Category = _ctx.StringValue("ListResourcePool.PoolInfoList["+ i +"].EcmResourcePoolConfigList["+ j +"].Category");
					ecmResourcePoolConfig2.Status = _ctx.StringValue("ListResourcePool.PoolInfoList["+ i +"].EcmResourcePoolConfigList["+ j +"].Status");
					ecmResourcePoolConfig2.Note = _ctx.StringValue("ListResourcePool.PoolInfoList["+ i +"].EcmResourcePoolConfigList["+ j +"].Note");

					poolInfo_ecmResourcePoolConfigList.Add(ecmResourcePoolConfig2);
				}
				poolInfo.EcmResourcePoolConfigList = poolInfo_ecmResourcePoolConfigList;

				listResourcePoolResponse_poolInfoList.Add(poolInfo);
			}
			listResourcePoolResponse.PoolInfoList = listResourcePoolResponse_poolInfoList;
        
			return listResourcePoolResponse;
        }
    }
}
