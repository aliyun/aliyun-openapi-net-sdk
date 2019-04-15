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
using Aliyun.Acs.aegis.Model.V20161111;

namespace Aliyun.Acs.aegis.Transform.V20161111
{
    public class DescribeSlsProjectResponseUnmarshaller
    {
        public static DescribeSlsProjectResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeSlsProjectResponse describeSlsProjectResponse = new DescribeSlsProjectResponse();

			describeSlsProjectResponse.HttpResponse = context.HttpResponse;
			describeSlsProjectResponse.RequestId = context.StringValue("DescribeSlsProject.RequestId");

			List<DescribeSlsProjectResponse.DescribeSlsProject_SlsProjectDataItem> describeSlsProjectResponse_slsProjectData = new List<DescribeSlsProjectResponse.DescribeSlsProject_SlsProjectDataItem>();
			for (int i = 0; i < context.Length("DescribeSlsProject.SlsProjectData.Length"); i++) {
				DescribeSlsProjectResponse.DescribeSlsProject_SlsProjectDataItem slsProjectDataItem = new DescribeSlsProjectResponse.DescribeSlsProject_SlsProjectDataItem();
				slsProjectDataItem.Project = context.StringValue("DescribeSlsProject.SlsProjectData["+ i +"].Project");

				List<string> slsProjectDataItem_logStore = new List<string>();
				for (int j = 0; j < context.Length("DescribeSlsProject.SlsProjectData["+ i +"].LogStore.Length"); j++) {
					slsProjectDataItem_logStore.Add(context.StringValue("DescribeSlsProject.SlsProjectData["+ i +"].LogStore["+ j +"]"));
				}
				slsProjectDataItem.LogStore = slsProjectDataItem_logStore;

				describeSlsProjectResponse_slsProjectData.Add(slsProjectDataItem);
			}
			describeSlsProjectResponse.SlsProjectData = describeSlsProjectResponse_slsProjectData;
        
			return describeSlsProjectResponse;
        }
    }
}
