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
using Aliyun.Acs.ddoscoo.Model.V20200101;

namespace Aliyun.Acs.ddoscoo.Transform.V20200101
{
    public class DescribeBlockStatusResponseUnmarshaller
    {
        public static DescribeBlockStatusResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeBlockStatusResponse describeBlockStatusResponse = new DescribeBlockStatusResponse();

			describeBlockStatusResponse.HttpResponse = _ctx.HttpResponse;
			describeBlockStatusResponse.RequestId = _ctx.StringValue("DescribeBlockStatus.RequestId");

			List<DescribeBlockStatusResponse.DescribeBlockStatus_StatusItem> describeBlockStatusResponse_statusList = new List<DescribeBlockStatusResponse.DescribeBlockStatus_StatusItem>();
			for (int i = 0; i < _ctx.Length("DescribeBlockStatus.StatusList.Length"); i++) {
				DescribeBlockStatusResponse.DescribeBlockStatus_StatusItem statusItem = new DescribeBlockStatusResponse.DescribeBlockStatus_StatusItem();
				statusItem.Ip = _ctx.StringValue("DescribeBlockStatus.StatusList["+ i +"].Ip");

				List<DescribeBlockStatusResponse.DescribeBlockStatus_StatusItem.DescribeBlockStatus_BlockStatusItem> statusItem_blockStatusList = new List<DescribeBlockStatusResponse.DescribeBlockStatus_StatusItem.DescribeBlockStatus_BlockStatusItem>();
				for (int j = 0; j < _ctx.Length("DescribeBlockStatus.StatusList["+ i +"].BlockStatusList.Length"); j++) {
					DescribeBlockStatusResponse.DescribeBlockStatus_StatusItem.DescribeBlockStatus_BlockStatusItem blockStatusItem = new DescribeBlockStatusResponse.DescribeBlockStatus_StatusItem.DescribeBlockStatus_BlockStatusItem();
					blockStatusItem.StartTime = _ctx.LongValue("DescribeBlockStatus.StatusList["+ i +"].BlockStatusList["+ j +"].StartTime");
					blockStatusItem.Line = _ctx.StringValue("DescribeBlockStatus.StatusList["+ i +"].BlockStatusList["+ j +"].Line");
					blockStatusItem.EndTime = _ctx.LongValue("DescribeBlockStatus.StatusList["+ i +"].BlockStatusList["+ j +"].EndTime");
					blockStatusItem.BlockStatus = _ctx.StringValue("DescribeBlockStatus.StatusList["+ i +"].BlockStatusList["+ j +"].BlockStatus");

					statusItem_blockStatusList.Add(blockStatusItem);
				}
				statusItem.BlockStatusList = statusItem_blockStatusList;

				describeBlockStatusResponse_statusList.Add(statusItem);
			}
			describeBlockStatusResponse.StatusList = describeBlockStatusResponse_statusList;
        
			return describeBlockStatusResponse;
        }
    }
}
