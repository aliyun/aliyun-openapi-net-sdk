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
    public class DescribeUpgradeMajorVersionPrecheckTaskResponseUnmarshaller
    {
        public static DescribeUpgradeMajorVersionPrecheckTaskResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeUpgradeMajorVersionPrecheckTaskResponse describeUpgradeMajorVersionPrecheckTaskResponse = new DescribeUpgradeMajorVersionPrecheckTaskResponse();

			describeUpgradeMajorVersionPrecheckTaskResponse.HttpResponse = _ctx.HttpResponse;
			describeUpgradeMajorVersionPrecheckTaskResponse.RequestId = _ctx.StringValue("DescribeUpgradeMajorVersionPrecheckTask.RequestId");
			describeUpgradeMajorVersionPrecheckTaskResponse.TotalRecordCount = _ctx.IntegerValue("DescribeUpgradeMajorVersionPrecheckTask.TotalRecordCount");
			describeUpgradeMajorVersionPrecheckTaskResponse.PageNumber = _ctx.IntegerValue("DescribeUpgradeMajorVersionPrecheckTask.PageNumber");
			describeUpgradeMajorVersionPrecheckTaskResponse.PageRecordCount = _ctx.IntegerValue("DescribeUpgradeMajorVersionPrecheckTask.PageRecordCount");

			List<DescribeUpgradeMajorVersionPrecheckTaskResponse.DescribeUpgradeMajorVersionPrecheckTask_Tasks> describeUpgradeMajorVersionPrecheckTaskResponse_items = new List<DescribeUpgradeMajorVersionPrecheckTaskResponse.DescribeUpgradeMajorVersionPrecheckTask_Tasks>();
			for (int i = 0; i < _ctx.Length("DescribeUpgradeMajorVersionPrecheckTask.Items.Length"); i++) {
				DescribeUpgradeMajorVersionPrecheckTaskResponse.DescribeUpgradeMajorVersionPrecheckTask_Tasks tasks = new DescribeUpgradeMajorVersionPrecheckTaskResponse.DescribeUpgradeMajorVersionPrecheckTask_Tasks();
				tasks.TaskId = _ctx.IntegerValue("DescribeUpgradeMajorVersionPrecheckTask.Items["+ i +"].TaskId");
				tasks.SourceMajorVersion = _ctx.StringValue("DescribeUpgradeMajorVersionPrecheckTask.Items["+ i +"].SourceMajorVersion");
				tasks.TargetMajorVersion = _ctx.StringValue("DescribeUpgradeMajorVersionPrecheckTask.Items["+ i +"].TargetMajorVersion");
				tasks.CheckTime = _ctx.StringValue("DescribeUpgradeMajorVersionPrecheckTask.Items["+ i +"].CheckTime");
				tasks.EffectiveTime = _ctx.StringValue("DescribeUpgradeMajorVersionPrecheckTask.Items["+ i +"].EffectiveTime");
				tasks.Result = _ctx.StringValue("DescribeUpgradeMajorVersionPrecheckTask.Items["+ i +"].Result");
				tasks.Detail = _ctx.StringValue("DescribeUpgradeMajorVersionPrecheckTask.Items["+ i +"].Detail");

				describeUpgradeMajorVersionPrecheckTaskResponse_items.Add(tasks);
			}
			describeUpgradeMajorVersionPrecheckTaskResponse.Items = describeUpgradeMajorVersionPrecheckTaskResponse_items;
        
			return describeUpgradeMajorVersionPrecheckTaskResponse;
        }
    }
}
