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
using Aliyun.Acs.Dds.Model.V20151201;

namespace Aliyun.Acs.Dds.Transform.V20151201
{
    public class DescribeActiveOperationTaskTypeResponseUnmarshaller
    {
        public static DescribeActiveOperationTaskTypeResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeActiveOperationTaskTypeResponse describeActiveOperationTaskTypeResponse = new DescribeActiveOperationTaskTypeResponse();

			describeActiveOperationTaskTypeResponse.HttpResponse = _ctx.HttpResponse;
			describeActiveOperationTaskTypeResponse.RequestId = _ctx.StringValue("DescribeActiveOperationTaskType.RequestId");

			List<DescribeActiveOperationTaskTypeResponse.DescribeActiveOperationTaskType_Items> describeActiveOperationTaskTypeResponse_typeList = new List<DescribeActiveOperationTaskTypeResponse.DescribeActiveOperationTaskType_Items>();
			for (int i = 0; i < _ctx.Length("DescribeActiveOperationTaskType.TypeList.Length"); i++) {
				DescribeActiveOperationTaskTypeResponse.DescribeActiveOperationTaskType_Items items = new DescribeActiveOperationTaskTypeResponse.DescribeActiveOperationTaskType_Items();
				items.TaskType = _ctx.StringValue("DescribeActiveOperationTaskType.TypeList["+ i +"].TaskType");
				items.TaskTypeInfoEn = _ctx.StringValue("DescribeActiveOperationTaskType.TypeList["+ i +"].TaskTypeInfoEn");
				items.TaskTypeInfoZh = _ctx.StringValue("DescribeActiveOperationTaskType.TypeList["+ i +"].TaskTypeInfoZh");
				items.Count = _ctx.IntegerValue("DescribeActiveOperationTaskType.TypeList["+ i +"].Count");

				describeActiveOperationTaskTypeResponse_typeList.Add(items);
			}
			describeActiveOperationTaskTypeResponse.TypeList = describeActiveOperationTaskTypeResponse_typeList;
        
			return describeActiveOperationTaskTypeResponse;
        }
    }
}
