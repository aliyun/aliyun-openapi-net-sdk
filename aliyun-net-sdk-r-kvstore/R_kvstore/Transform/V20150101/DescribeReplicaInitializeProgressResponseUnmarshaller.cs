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
using Aliyun.Acs.R_kvstore.Model.V20150101;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.R_kvstore.Transform.V20150101
{
    public class DescribeReplicaInitializeProgressResponseUnmarshaller
    {
        public static DescribeReplicaInitializeProgressResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeReplicaInitializeProgressResponse describeReplicaInitializeProgressResponse = new DescribeReplicaInitializeProgressResponse();

			describeReplicaInitializeProgressResponse.HttpResponse = context.HttpResponse;
			describeReplicaInitializeProgressResponse.RequestId = context.StringValue("DescribeReplicaInitializeProgress.RequestId");

			List<DescribeReplicaInitializeProgressResponse.DescribeReplicaInitializeProgress_ItemsItem> describeReplicaInitializeProgressResponse_items = new List<DescribeReplicaInitializeProgressResponse.DescribeReplicaInitializeProgress_ItemsItem>();
			for (int i = 0; i < context.Length("DescribeReplicaInitializeProgress.Items.Length"); i++) {
				DescribeReplicaInitializeProgressResponse.DescribeReplicaInitializeProgress_ItemsItem itemsItem = new DescribeReplicaInitializeProgressResponse.DescribeReplicaInitializeProgress_ItemsItem();
				itemsItem.ReplicaId = context.StringValue("DescribeReplicaInitializeProgress.Items["+ i +"].ReplicaId");
				itemsItem.Status = context.StringValue("DescribeReplicaInitializeProgress.Items["+ i +"].Status");
				itemsItem.Progress = context.StringValue("DescribeReplicaInitializeProgress.Items["+ i +"].Progress");
				itemsItem.FinishTime = context.StringValue("DescribeReplicaInitializeProgress.Items["+ i +"].FinishTime");
				itemsItem.CurrentStep = context.StringValue("DescribeReplicaInitializeProgress.Items["+ i +"].CurrentStep");

				describeReplicaInitializeProgressResponse_items.Add(itemsItem);
			}
			describeReplicaInitializeProgressResponse.Items = describeReplicaInitializeProgressResponse_items;
        
			return describeReplicaInitializeProgressResponse;
        }
    }
}