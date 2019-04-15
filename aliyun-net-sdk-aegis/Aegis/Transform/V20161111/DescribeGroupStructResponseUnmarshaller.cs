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
    public class DescribeGroupStructResponseUnmarshaller
    {
        public static DescribeGroupStructResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeGroupStructResponse describeGroupStructResponse = new DescribeGroupStructResponse();

			describeGroupStructResponse.HttpResponse = context.HttpResponse;
			describeGroupStructResponse.RequestId = context.StringValue("DescribeGroupStruct.RequestId");
			describeGroupStructResponse.GroupFather = context.IntegerValue("DescribeGroupStruct.GroupFather");
			describeGroupStructResponse.GroupId = context.LongValue("DescribeGroupStruct.GroupId");
			describeGroupStructResponse.GroupName = context.StringValue("DescribeGroupStruct.GroupName");
			describeGroupStructResponse.GroupIndex = context.IntegerValue("DescribeGroupStruct.GroupIndex");
			describeGroupStructResponse.GroupFlag = context.IntegerValue("DescribeGroupStruct.GroupFlag");
			describeGroupStructResponse.GroupLevel = context.IntegerValue("DescribeGroupStruct.GroupLevel");
			describeGroupStructResponse.MachineNum = context.IntegerValue("DescribeGroupStruct.MachineNum");

			List<string> describeGroupStructResponse_groups = new List<string>();
			for (int i = 0; i < context.Length("DescribeGroupStruct.Groups.Length"); i++) {
				describeGroupStructResponse_groups.Add(context.StringValue("DescribeGroupStruct.Groups["+ i +"]"));
			}
			describeGroupStructResponse.Groups = describeGroupStructResponse_groups;
        
			return describeGroupStructResponse;
        }
    }
}
